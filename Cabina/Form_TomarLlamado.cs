using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using Cabina.WS;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using ColumnStyle = Infragistics.Win.UltraWinGrid.ColumnStyle;

namespace Cabina
{
    public partial class FormTomarLlamado : Form1
    {
        private FormPrincipalCabina _fp;
        private int _idPlan;
        private bool _nombreAfiliadoCambiado;

        public FormTomarLlamado()
        {
            _nombreAfiliadoCambiado = false;
            InitializeComponent();
        }

        private void FormTomarLlamadoLoad(object sender, EventArgs e)
        {
            ActiveControl = textBoxTelefono;
            /*Que el documento por default sea DNI*/
            ultraGridPaciente.DisplayLayout.Bands["Band 0"].Columns["idTipoDeDocumento"].DefaultCellValue =
                new Service().DefaultDNI(Program.Pin);
            /*Llena el combo Edad en*/
            ultraGridPaciente.DisplayLayout.ValueLists.Add("EdadEn");
            ultraGridPaciente.DisplayLayout.ValueLists["EdadEn"].ValueListItems.Add("A", "a�os");
            ultraGridPaciente.DisplayLayout.ValueLists["EdadEn"].ValueListItems.Add("M", "meses");
            ultraGridPaciente.DisplayLayout.ValueLists["EdadEn"].ValueListItems.Add("D", "d�as");
            ultraGridPaciente.DisplayLayout.Bands[0].Columns["EdadEn"].ValueList =
                ultraGridPaciente.DisplayLayout.ValueLists["EdadEn"];

            /*Llena el combo Sexo*/
            ultraGridPaciente.DisplayLayout.ValueLists.Add("Sexo");
            ultraGridPaciente.DisplayLayout.ValueLists["Sexo"].ValueListItems.Add("M", "Masculino");
            ultraGridPaciente.DisplayLayout.ValueLists["Sexo"].ValueListItems.Add("F", "Femenino");
            ultraGridPaciente.DisplayLayout.ValueLists["Sexo"].ValueListItems.Add(" ", "");
            ultraGridPaciente.DisplayLayout.Bands[0].Columns["Sexo"].ValueList =
                ultraGridPaciente.DisplayLayout.ValueLists["Sexo"];

            /*Conecta el Grid*/
            ultraGridPaciente.DataBind();

            /*Que la edad por default sea en a�os*/
            ultraGridPaciente.DisplayLayout.Bands["Band 0"].Columns["EdadEn"].DefaultCellValue = "A";

            /*Manejo de los Tabs*/
            direccionesAfiliadosUltraGrid.DisplayLayout.TabNavigation = TabNavigation.NextControlOnLastCell;
            motivosPacientesUltraGrid.DisplayLayout.TabNavigation = TabNavigation.NextControlOnLastCell;
            ultraGridPaciente.DisplayLayout.TabNavigation = TabNavigation.NextControlOnLastCell;

            /*Tomo datos del padre*/
            _fp = (FormPrincipalCabina) MdiParent;
            callesBindingSource.DataSource = _fp.dsCallesLista;
            motivosDeLlamadoBindingSource.DataSource = _fp.dsMotivosDeLlamado;
            prepagosBindingSource.DataSource = _fp.dsPrepagos;
            localidadesBindingSource.DataSource = _fp.dsLocalidades1;
            //contratosBindingSource.DataSource = _fp.dsContratosLista;
            barriosListaBindingSource.DataSource = _fp.dsBarrios;
            codigosBindingSource.DataSource = _fp.dsCodigos;
            coberturasBindingSource.DataSource = _fp.dsCoberturas;
            practicasBindingSource.DataSource = _fp.dsPracticas;
            tiposDeDestinoBindingSource.DataSource = _fp.dsTiposDeDestino;
            motivosDeCancelacionPrestacionBindingSource.DataSource = _fp.dsMotivosDeCancelacionPrestacion;
            tiposDeDocumentoBindingSource.DataSource = _fp.dsTiposDeDocumento;
            sistemasBindingSource.DataSource = _fp.dsSistemas;
            dsContratosLista.Merge(new Service().GetContratosRenglonFacturaTodos(Program.Pin));

        }

        private void TextBoxTelefonoEnter(object sender, EventArgs e)
        {
            AcceptButton = buttonBuscarTelefono;
        }

        private void TextBoxTelefonoLeave(object sender, EventArgs e)
        {
            AcceptButton = null;
        }

        private void TextBoxTelefonoKeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxTelefono.Text.Length > 4 ||
                textBoxTelefono.Text == "0")
            {
                buttonBuscarTelefono.Enabled = true;
            }
            else
            {
                buttonBuscarTelefono.Enabled = false;
            }

            if (e.KeyCode != Keys.Enter)
            {
                labelTelefonoNoEncontrado.Visible = false;
            }
        }

        private void TextBoxTelefonoKeyDown(object sender, KeyEventArgs e)
        {
            HoraInicial();
        }

        private void UltraDropDownCallesFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = direccionesAfiliadosUltraGrid.ActiveRow.Cells["idLocalidad"].Value == DBNull.Value
                ? new FilterCondition(e.Row.Band.Columns["idLocalidad"], FilterComparisionOperator.Equals, 0)
                : new FilterCondition(e.Row.Band.Columns["idLocalidad"], FilterComparisionOperator.Equals,
                    _fp.dsLocalidades1.Localidades.FindByidLocalidad(
                        (int)
                        direccionesAfiliadosUltraGrid.ActiveRow.Cells["idLocalidad"].Value).idLocalidad);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void DireccionesAfiliadosUltraGridCellChange(object sender, CellEventArgs e)
        {
            HoraInicial();

            if (e.Cell.Column.Key != "idCalle") return;
            e.Cell.Row.Cells["idEntreCalle1"].Value = DBNull.Value;
            e.Cell.Row.Cells["idEntreCalle1"].Value = DBNull.Value;
            e.Cell.Row.Cells["idBarrio"].Value = DBNull.Value;
            ultraDropDownCalles.DisplayLayout.RefreshFilters();
            ultraDropDownBarrios.DisplayLayout.RefreshFilters();
        }

        private void UltraDropDownBarriosFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = direccionesAfiliadosUltraGrid.ActiveRow.Cells["idLocalidad"].Value == DBNull.Value
                ? new FilterCondition(e.Row.Band.Columns["idLocalidad"], FilterComparisionOperator.Equals, 0)
                : new FilterCondition(e.Row.Band.Columns["idLocalidad"], FilterComparisionOperator.Equals,
                    _fp.dsLocalidades1.Localidades.FindByidLocalidad(
                        (int)
                        direccionesAfiliadosUltraGrid.ActiveRow.Cells["idLocalidad"].Value).idLocalidad);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void HoraInicial()
        {
            // Fija la hora de tomada la prestaci�n
            if (Convert.ToDateTime(ultraDateTimeEditorTomada.Value).Year != 1947) return;
            ultraDateTimeEditorTomada.Value = new Service().HoraActual(Program.Pin);
            buttonCancelarNuevo.Enabled = false;
        }

        private void MotivosPacientesUltraGridCellChange(object sender, CellEventArgs e)
        {
            HoraInicial();
        }

        private void UltraGridPacienteCellChange(object sender, CellEventArgs e)
        {
            HoraInicial();
            if (e.Cell.Column.Key == "EsAfiliado") SugerirCopago();
        }

        private void UltraTextEditorObservacionesKeyDown(object sender, KeyEventArgs e)
        {
            HoraInicial();
        }

        private void ButtonBuscarTelefonoClick(object sender, EventArgs e)
        {
            buttonBuscarTelefono.Enabled = false;
            var aux = new Service().GetRefTelefono(textBoxTelefono.Text,
                Program.Pin);
            if (aux == null)
            {
                labelTelefonoNoEncontrado.Text =
                    "Tel�fono no encontrado en la Base de Datos.";
                labelTelefonoNoEncontrado.Visible = true;
            }
            else
            {
                var frmBuscar = new FormBuscarDireccionYAfiliado {Aux = aux};
                frmBuscar.ShowDialog(this);
                _idPlan = frmBuscar.IdPlan;
                if (frmBuscar.Boton == "Afiliado")
                {
                    dsBuscarTelefono.Merge(new Service().GetAfiliadoDelTelefono(
                        frmBuscar.IdAfiliado, Program.Pin));
                    DatosAfiliadoDesdeBusqueda();
                    if (frmBuscar.IdContrato == 0)
                        ultraComboCobertura.Value = _fp.dsSistemas.Sistemas[0]["CoberturaAfiliado"];
                    else
                    {
                        ultraComboContratos.Value = frmBuscar.IdContrato;
                        ultraComboCobertura.Value = _fp.dsSistemas.Sistemas[0]["CoberturaContrato"];
                    }
                }

                if (frmBuscar.Boton == "Paciente")
                {
                    labelTelefonoNoEncontrado.Visible = false;
                    dsPacientesPrestacion1.Merge(
                        new Service().GetPaciente(frmBuscar.IdPaciente, Program.Pin));
                    DatosPacienteDesdeBusqueda();
                    ultraComboCobertura.Value = dsPacientesPrestacion1.Pacientes[0]["idCobertura"];
                }

                if (frmBuscar.Boton == "Paciente y Direccion")
                {
                    labelTelefonoNoEncontrado.Visible = false;
                    dsPacientesPrestacion1.Merge(
                        new Service().GetPaciente(frmBuscar.IdPaciente, Program.Pin));
                    DatosPacienteDesdeBusqueda();
                    ultraComboCobertura.Value = dsPacientesPrestacion1.Pacientes[0]["idCobertura"];
                    DireccionDesdeTelefono(frmBuscar.IdDireccion);
                }

                if (frmBuscar.Boton == "Direccion")
                {
                    DireccionDesdeTelefono(frmBuscar.IdDireccion);
                }

                if (frmBuscar.Boton == "Direccion y Afiliado")
                {
                    dsBuscarTelefono.Merge(new Service().GetAfiliadoDelTelefono(
                        frmBuscar.IdAfiliado, Program.Pin));
                    DatosAfiliadoDesdeBusqueda();
                    if (frmBuscar.IdContrato == 0)
                        ultraComboCobertura.Value = _fp.dsSistemas.Sistemas[0]["CoberturaAfiliado"];
                    else
                    {
                        ultraComboContratos.Value = frmBuscar.IdContrato;
                        ultraComboCobertura.Value = _fp.dsSistemas.Sistemas[0]["CoberturaContrato"];
                    }

                    DireccionDesdeTelefono(frmBuscar.IdDireccion);
                    if (frmBuscar.IdContrato != 0)
                    {
                        ultraComboContratos.Value = frmBuscar.IdContrato;
                    }
                }

                if (frmBuscar.Boton == "Contrato")
                {
                    labelTelefonoNoEncontrado.Visible = false;
                    ultraComboContratos.Value = frmBuscar.IdContrato;
                    ultraComboCobertura.Value = _fp.dsSistemas.Sistemas[0]["CoberturaContrato"];
                }

                if (frmBuscar.Boton == "Contrato y Direccion")
                {
                    labelTelefonoNoEncontrado.Visible = false;
                    ultraComboContratos.Value = frmBuscar.IdContrato;
                    DireccionDesdeTelefono(frmBuscar.IdDireccion);
                    ultraComboCobertura.Value = _fp.dsSistemas.Sistemas[0]["CoberturaContrato"];
                }

                frmBuscar.Close();
            }
        }

        private void ButtonBuscarDireccionClick(object sender, EventArgs e)
        {
            DsCabBuscarTelefono aux;
            if (direccionesAfiliadosUltraGrid.Rows.Count == 0 ||
                direccionesAfiliadosUltraGrid.Rows[0].Cells["idLocalidad"].Value == DBNull.Value)
            {
                MessageBox.Show("Para buscar, ingrese por lo menos la localidad.",
                    "Sin datos para buscar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (direccionesAfiliadosUltraGrid.Rows[0].Cells["idCalle"].Value == DBNull.Value)
            {
                aux = new Service().GetRefDireccionLocalidad(
                    (int) direccionesAfiliadosUltraGrid.Rows[0].Cells["idLocalidad"].Value, Program.Pin);
            }
            else
            {
                aux = direccionesAfiliadosUltraGrid.Rows[0].Cells["Numero"].Value == DBNull.Value
                    ? new Service().GetRefDireccionCalle(
                        (int) direccionesAfiliadosUltraGrid.Rows[0].Cells["idCalle"].Value, Program.Pin)
                    : new Service().GetRefDireccion(
                        (int) direccionesAfiliadosUltraGrid.Rows[0].Cells["idCalle"].Value,
                        direccionesAfiliadosUltraGrid.Rows[0].Cells["Numero"].Value.ToString(), Program.Pin);
            }

            //buttonBuscarDireccion.Enabled = false;
            if (aux == null)
            {
                labelTelefonoNoEncontrado.Text =
                    "Direcci�n no encontrada en la Base de Datos.";
                labelTelefonoNoEncontrado.Visible = true;
            }
            else
            {
                var frmBuscar = new FormBuscarDireccionYAfiliado {Aux = aux};
                frmBuscar.ShowDialog(this);
                if (frmBuscar.Boton == "Afiliado")
                {
                    labelTelefonoNoEncontrado.Visible = false;
                    dsBuscarTelefono.Merge(
                        new Service().GetAfiliadoDelTelefono(frmBuscar.IdAfiliado, Program.Pin));
                    DatosAfiliadoDesdeBusqueda();
                    ultraComboCobertura.Value = _fp.dsSistemas.Sistemas[0]["CoberturaAfiliado"];
                    if (frmBuscar.IdContrato != 0)
                    {
                        ultraComboContratos.Value = frmBuscar.IdContrato;
                        ultraComboCobertura.Value = _fp.dsSistemas.Sistemas[0]["CoberturaContrato"];
                    }
                }

                if (frmBuscar.Boton == "Direccion")
                {
                    DireccionDesdeTelefono(frmBuscar.IdDireccion);
                }

                if (frmBuscar.Boton == "Direccion y Afiliado")
                {
                    dsBuscarTelefono.Merge(
                        new Service().GetAfiliadoDelTelefono(frmBuscar.IdAfiliado, Program.Pin));
                    DatosAfiliadoDesdeBusqueda();
                    if (frmBuscar.IdContrato != 0)
                    {
                        ultraComboContratos.Value = frmBuscar.IdContrato;
                        ultraComboCobertura.Value = _fp.dsSistemas.Sistemas[0]["CoberturaContrato"];
                    }
                    else
                    {
                        ultraComboCobertura.Value = _fp.dsSistemas.Sistemas[0]["CoberturaAfiliado"];
                    }

                    DireccionDesdeTelefono(frmBuscar.IdDireccion);
                }

                if (frmBuscar.Boton == "Contrato")
                {
                    labelTelefonoNoEncontrado.Visible = false;
                    ultraComboContratos.Value = frmBuscar.IdContrato;
                    ultraComboCobertura.Value = _fp.dsSistemas.Sistemas[0]["CoberturaContrato"];
                }

                if (frmBuscar.Boton == "Contrato y Direccion")
                {
                    labelTelefonoNoEncontrado.Visible = false;
                    ultraComboContratos.Value = frmBuscar.IdContrato;
                    DireccionDesdeTelefono(frmBuscar.IdDireccion);
                    ultraComboCobertura.Value = _fp.dsSistemas.Sistemas[0]["CoberturaContrato"];
                }

                frmBuscar.Close();
            }
        }

        private string XEdad(DateTime fechanac)
        {
            var ahora = new Service().HoraActual(Program.Pin);
            // Calculamos la diferencia de a�os
            var anyos = ahora.Year - fechanac.Year;
            // Restamos un a�o si estamos antes de el
            // d�a de nacimiento en el a�o actual
            if (ahora.Month < fechanac.Month || (ahora.Month == fechanac.Month && ahora.Day < fechanac.Day))
            {
                anyos--;
            }

            if (anyos > 0)
            {
                return anyos.ToString("000") + "A";
            }

            var meses = ahora.Month - fechanac.Month;
            if (meses < 0)
            {
                meses = meses + 12;
            }

            if (ahora.Day < fechanac.Day)
            {
                meses--;
            }

            if (meses > 0)
            {
                return meses.ToString("000") + "M";
            }

            var dias = ahora - fechanac;
            return dias.Days.ToString("000") + "D";
        }

        private void DatosPacienteDesdeBusqueda()
        {
            _nombreAfiliadoCambiado = false;
            if (ultraGridPaciente.DisplayLayout.Rows.Count == 0)
            {
                ultraGridPaciente.DisplayLayout.Bands[0].AddNew();
            }

            ultraGridPaciente.DisplayLayout.Rows[0].Cells["idAfiliado"].Value =
                dsPacientesPrestacion1.Pacientes[0]["idAfiliado"];
            ultraGridPaciente.DisplayLayout.Rows[0].Cells["idPlan"].Value = _idPlan;
            ultraGridPaciente.DisplayLayout.Rows[0].Cells["EsAfiliado"].Value = false;
            ultraGridPaciente.DisplayLayout.Rows[0].Cells["ApelNomb"].Value =
                dsPacientesPrestacion1.Pacientes[0]["Nombre"];
            ultraGridPaciente.DisplayLayout.Rows[0].Cells["idTipoDeDocumento"].Value =
                dsPacientesPrestacion1.Pacientes[0]["idTipoDeDocumento"];
            ultraGridPaciente.DisplayLayout.Rows[0].Cells["NumeroDeDocumento"].Value =
                dsPacientesPrestacion1.Pacientes[0]["NumeroDeDocumento"];
            /*La edad no la pongo porque es de una prestaci�n anterior y puede haber cambiado.*/
            //ultraGridPaciente.DisplayLayout.Rows[0].Cells["Edad"].Value =
            //    dsPacientesPrestacion1.Pacientes[0]["Edad"];
            //ultraGridPaciente.DisplayLayout.Rows[0].Cells["EdadEn"].Value =
            //    dsPacientesPrestacion1.Pacientes[0]["EdadEn"];
            ultraGridPaciente.DisplayLayout.Rows[0].Cells["Sexo"].Value =
                dsPacientesPrestacion1.Pacientes[0]["Sexo"];
            ultraGridPaciente.DisplayLayout.Rows[0].Cells["idPrepago"].Value =
                dsPacientesPrestacion1.Pacientes[0]["idPrepago"];
            ultraGridPaciente.DisplayLayout.Rows[0].Cells["NumeroPrepago"].Value =
                dsPacientesPrestacion1.Pacientes[0]["NroAfiliadoPrepago"];
            if (dsPacientesPrestacion1.Pacientes[0]["Antecedentes"] != DBNull.Value &&
                dsPacientesPrestacion1.Pacientes[0]["Antecedentes"].ToString().Length > 0)
            {
                if (ultraGridPaciente.DisplayLayout.Rows[0].Cells["Antecedentes"].Value == DBNull.Value ||
                    ultraGridPaciente.DisplayLayout.Rows[0].Cells["Antecedentes"].Value.ToString().Length == 0)
                {
                    ultraGridPaciente.DisplayLayout.Rows[0].Cells["Antecedentes"].Value =
                        dsPacientesPrestacion1.Pacientes[0]["Antecedentes"].ToString();
                }
                else
                {
                    ultraGridPaciente.DisplayLayout.Rows[0].Cells["Antecedentes"].Value =
                        dsPacientesPrestacion1.Pacientes[0]["Antecedentes"] + " | " +
                        ultraGridPaciente.DisplayLayout.Rows[0].Cells["Antecedentes"].Value;
                }
            }

            //ultraGridPaciente.DisplayLayout.Rows[0].Cells["FechaAfiliacion"].Value =
            //    dsPacientesPrestacion1.Pacientes[0]["FechaAfiliacion"];
            ultraGridPaciente.DisplayLayout.Rows[0].Update();
            buttonBuscarPaciente.Enabled = false;
            SugerirCopago();
            var idPlan = (int) ultraGridPaciente.DisplayLayout.Rows[0].Cells["idPlan"].Value;
            if (idPlan != 0)
            {
                var idContrato = new Service().ContratoDelPlan(idPlan, Program.Pin);
                if (idContrato != 0)
                {
                    ultraComboContratos.Value = idContrato;
                    ultraComboCobertura.Value = _fp.dsSistemas.Sistemas[0]["CoberturaContrato"];
                }
            }
        }

        private void DatosAfiliadoDesdeBusqueda()
        {
            _nombreAfiliadoCambiado = false;
            if (ultraGridPaciente.DisplayLayout.Rows.Count == 0)
            {
                ultraGridPaciente.DisplayLayout.Bands[0].AddNew();
            }

            ultraGridPaciente.DisplayLayout.Rows[0].Cells["idAfiliado"].Value =
                dsBuscarTelefono.Afiliados[0]["idAfiliado"];
            ultraGridPaciente.DisplayLayout.Rows[0].Cells["idPlan"].Value = _idPlan;
            ultraGridPaciente.DisplayLayout.Rows[0].Cells["EsAfiliado"].Value = true;
            ultraGridPaciente.DisplayLayout.Rows[0].Cells["ApelNomb"].Value = dsBuscarTelefono.Afiliados[0]["Nombre"];
            ultraGridPaciente.DisplayLayout.Rows[0].Cells["idTipoDeDocumento"].Value =
                dsBuscarTelefono.Afiliados[0]["idTipoDeDocumento"];
            ultraGridPaciente.DisplayLayout.Rows[0].Cells["NumeroDeDocumento"].Value =
                dsBuscarTelefono.Afiliados[0]["NumeroDeDocumento"];
            if (dsBuscarTelefono.Afiliados[0]["FechaDeNacimiento"].ToString() != "")
            {
                ultraGridPaciente.DisplayLayout.Rows[0].Cells["Edad"].Value =
                    Convert.ToInt32(
                        XEdad((DateTime) dsBuscarTelefono.Afiliados[0]["FechaDeNacimiento"]).Substring(0, 3));
                ultraGridPaciente.DisplayLayout.Rows[0].Cells["EdadEn"].Value =
                    XEdad((DateTime) dsBuscarTelefono.Afiliados[0]["FechaDeNacimiento"]).Substring(3, 1);
            }

            ultraGridPaciente.DisplayLayout.Rows[0].Cells["Sexo"].Value = dsBuscarTelefono.Afiliados[0]["Sexo"];
            ultraGridPaciente.DisplayLayout.Rows[0].Cells["idPrepago"].Value =
                dsBuscarTelefono.Afiliados[0]["idPrepago"];
            ultraGridPaciente.DisplayLayout.Rows[0].Cells["NumeroPrepago"].Value =
                dsBuscarTelefono.Afiliados[0]["NumeroAfiliadoPrepago"];
            if (dsBuscarTelefono.Afiliados[0]["Antecedentes"] != DBNull.Value &&
                dsBuscarTelefono.Afiliados[0]["Antecedentes"].ToString().Length > 0)
            {
                if (ultraGridPaciente.DisplayLayout.Rows[0].Cells["Antecedentes"].Value == DBNull.Value ||
                    ultraGridPaciente.DisplayLayout.Rows[0].Cells["Antecedentes"].Value.ToString().Length == 0)
                {
                    ultraGridPaciente.DisplayLayout.Rows[0].Cells["Antecedentes"].Value =
                        dsBuscarTelefono.Afiliados[0]["Antecedentes"].ToString();
                }
                else
                {
                    ultraGridPaciente.DisplayLayout.Rows[0].Cells["Antecedentes"].Value =
                        dsBuscarTelefono.Afiliados[0]["Antecedentes"] + " | " +
                        ultraGridPaciente.DisplayLayout.Rows[0].Cells["Antecedentes"].Value;
                }
            }

            //ultraGridPaciente.DisplayLayout.Rows[0].Cells["FechaAfiliacion"].Value =
            //    dsBuscarTelefono.Afiliados[0]["FechaAfiliacion"];
            ultraGridPaciente.DisplayLayout.Rows[0].Update();
            buttonBuscarPaciente.Enabled = false;
            SugerirCopago();
            var idPlan = (int) ultraGridPaciente.DisplayLayout.Rows[0].Cells["idPlan"].Value;
            if (idPlan != 0)
            {
                var idContrato = new Service().ContratoDelPlan(idPlan, Program.Pin);
                if (idContrato != 0)
                {
                    ultraComboContratos.Value = idContrato;
                    ultraComboCobertura.Value = _fp.dsSistemas.Sistemas[0]["CoberturaContrato"];
                }
            }
        }

        private void DireccionDesdeTelefono(int idDireccion)
        {
            dsBuscarTelefono.Merge(new Service().GetDireccionDelTelefono(idDireccion, Program.Pin));
            if (direccionesAfiliadosUltraGrid.DisplayLayout.Rows.Count == 0)
            {
                direccionesAfiliadosUltraGrid.DisplayLayout.Bands[0].AddNew();
            }

            if (dsBuscarTelefono.Direcciones.Rows.Count > 0)
            {
                direccionesAfiliadosUltraGrid.Rows[0].Cells["idLocalidad"].Value =
                    dsBuscarTelefono.Direcciones[0]["idLocalidad"];
                direccionesAfiliadosUltraGrid.Rows[0].Cells["idCalle"].Value =
                    dsBuscarTelefono.Direcciones[0]["idCalle"];
                direccionesAfiliadosUltraGrid.Rows[0].Cells["Numero"].Value =
                    dsBuscarTelefono.Direcciones[0]["Numero"].ToString();
                direccionesAfiliadosUltraGrid.Rows[0].Cells["Piso"].Value =
                    dsBuscarTelefono.Direcciones[0]["Piso"].ToString();
                direccionesAfiliadosUltraGrid.Rows[0].Cells["Departamento"].Value =
                    dsBuscarTelefono.Direcciones[0]["Departamento"].ToString();

                direccionesAfiliadosUltraGrid.Rows[0].Cells["idEntreCalle1"].Value =
                    dsBuscarTelefono.Direcciones[0]["idEntreCalle1"];

                direccionesAfiliadosUltraGrid.Rows[0].Cells["idEntreCalle2"].Value =
                    dsBuscarTelefono.Direcciones[0]["idEntreCalle2"];

                direccionesAfiliadosUltraGrid.Rows[0].Cells["idBarrio"].Value =
                    dsBuscarTelefono.Direcciones[0]["idBarrio"];

                if (dsBuscarTelefono.Direcciones[0]["Observaciones"] != DBNull.Value &&
                    dsBuscarTelefono.Direcciones[0]["Observaciones"].ToString().Length > 0)
                {
                    if (direccionesAfiliadosUltraGrid.Rows[0].Cells["Observaciones"].Value == DBNull.Value ||
                        direccionesAfiliadosUltraGrid.Rows[0].Cells["Observaciones"].Value.ToString().Length == 0)
                    {
                        direccionesAfiliadosUltraGrid.Rows[0].Cells["Observaciones"].Value =
                            dsBuscarTelefono.Direcciones[0]["Observaciones"].ToString();
                    }
                    else
                    {
                        direccionesAfiliadosUltraGrid.Rows[0].Cells["Observaciones"].Value =
                            dsBuscarTelefono.Direcciones[0]["Observaciones"] + " | " +
                            direccionesAfiliadosUltraGrid.Rows[0].Cells["Observaciones"].Value;
                    }
                }
            }

            direccionesAfiliadosUltraGrid.Rows[0].Update();
            buttonBuscarDireccion.Enabled = false;
        }

        private void ButtonBuscarPacienteClick(object sender, EventArgs e)
        {
            HoraInicial();
            var frmBuscarAfiliadoDesdeToma = new FormBuscarAfiliadoDesdeToma();
            frmBuscarAfiliadoDesdeToma.ShowDialog(this);
            _idPlan = frmBuscarAfiliadoDesdeToma.IdPlan;
            if (frmBuscarAfiliadoDesdeToma.Boton == "Datos del Afiliado")
            {
                dsBuscarTelefono.Merge(
                    new Service().GetAfiliadoDelTelefono(frmBuscarAfiliadoDesdeToma.IdAfiliado, Program.Pin));
                DatosAfiliadoDesdeBusqueda();
                ultraComboCobertura.Value = _fp.dsSistemas.Sistemas[0]["CoberturaAfiliado"];
                if (frmBuscarAfiliadoDesdeToma.IdContrato != 0)
                {
                    ultraComboContratos.Value = frmBuscarAfiliadoDesdeToma.IdContrato;
                    ultraComboCobertura.Value = _fp.dsSistemas.Sistemas[0]["CoberturaContrato"];
                }

                frmBuscarAfiliadoDesdeToma.Close();
            }

            if (frmBuscarAfiliadoDesdeToma.Boton == "Datos de la Direcci�n")
            {
                DireccionDesdeTelefono(frmBuscarAfiliadoDesdeToma.IdDireccion);
            }

            if (frmBuscarAfiliadoDesdeToma.Boton != "Datos del Afiliado y la Direcci�n") return;
            dsBuscarTelefono.Merge(
                new Service().GetAfiliadoDelTelefono(frmBuscarAfiliadoDesdeToma.IdAfiliado, Program.Pin));
            _idPlan = frmBuscarAfiliadoDesdeToma.IdPlan;
            DatosAfiliadoDesdeBusqueda();
            ultraComboCobertura.Value = _fp.dsSistemas.Sistemas[0]["CoberturaAfiliado"];
            if (frmBuscarAfiliadoDesdeToma.IdContrato != 0)
            {
                ultraComboContratos.Value = frmBuscarAfiliadoDesdeToma.IdContrato;
                ultraComboCobertura.Value = _fp.dsSistemas.Sistemas[0]["CoberturaContrato"];
            }

            DireccionDesdeTelefono(frmBuscarAfiliadoDesdeToma.IdDireccion);

            frmBuscarAfiliadoDesdeToma.Close();
        }

        private bool Verificar()
        {
            if (direccionesAfiliadosUltraGrid.Rows.Count == 0 ||
                (direccionesAfiliadosUltraGrid.Rows[0].Cells["idLocalidad"].Value == DBNull.Value &&
                 direccionesAfiliadosUltraGrid.Rows[0].Cells["Observaciones"].Value == DBNull.Value))
            {
                MessageBox.Show("No est� la localidad y no hay Observaciones",
                    "Faltan datos de la Direcci�n",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (ultraComboTiposDeDestino.Value == null)
            {
                MessageBox.Show("Falta el Tipo de Destino",
                    "Faltan datos", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (ultraComboCodigos.Value == null)
            {
                MessageBox.Show("Falta el C�digo",
                    "Faltan datos", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (ultraComboPracticas.Value == null)
            {
                MessageBox.Show("Falta la Pr�ctica",
                    "Faltan datos", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (ultraComboCobertura.Value == null)
            {
                MessageBox.Show("Falta la Cobertura",
                    "Faltan datos", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if ((int) ultraComboCobertura.Value == (int) _fp.dsSistemas.Sistemas.Rows[0]["CoberturaContrato"] &&
                ultraComboContratos.Value == null)
            {
                MessageBox.Show("La cobertura es Contrato y no est� especificado cu�l es el contrato.",
                    "Faltan datos", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (ultraGridPaciente.Rows.Count == 0)
            {
                MessageBox.Show("No hay ning�n dato del paciente.",
                    "Faltan datos", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if ((int) ultraComboCobertura.Value == (int) _fp.dsSistemas.Sistemas.Rows[0]["CoberturaAfiliado"] &&
                (bool) ultraGridPaciente.Rows[0].Cells["EsAfiliado"].Value == false)
            {
                MessageBox.Show("La cobertura es Afiliado y no se ubic� en el padr�n.",
                    "Faltan datos", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (motivosPacientesUltraGrid.Rows.Count == 0 ||
                motivosPacientesUltraGrid.Rows[0].Cells["idMotivoDeLlamado"].Value == DBNull.Value)
            {
                MessageBox.Show("No hay ning�n Motivo de Llamado.",
                    "Faltan datos", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            var direccion = direccionesAfiliadosUltraGrid.Rows[0];
            if (direccion.Cells["idLocalidad"].Value == DBNull.Value)
            {
                MessageBox.Show("No est� la Localidad.",
                    "Faltan datos", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (direccion.Cells["idCalle"].Value != DBNull.Value &&
                _fp.dsCallesLista.Calles.FindByidCalle((int) direccion.Cells["idCalle"].Value).idLocalidad !=
                (int) direccion.Cells["idLocalidad"].Value)
            {
                MessageBox.Show(
                    "La calle " + direccion.Cells["idCalle"].Text +
                    " no pertenece a " +
                    direccion.Cells["idLocalidad"].Text + ".",
                    "No se pudo grabar", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (direccion.Cells["idEntreCalle1"].Value != DBNull.Value &&
                _fp.dsCallesLista.Calles.FindByidCalle((int) direccion.Cells["idEntreCalle1"].Value).idLocalidad !=
                (int) direccion.Cells["idLocalidad"].Value)
            {
                MessageBox.Show(
                    "La calle " + direccion.Cells["idEntreCalle1"].Text +
                    " no pertenece a " +
                    direccion.Cells["idLocalidad"].Text + ".",
                    "No se pudo grabar", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (direccion.Cells["idEntreCalle2"].Value != DBNull.Value &&
                _fp.dsCallesLista.Calles.FindByidCalle((int) direccion.Cells["idEntreCalle2"].Value).idLocalidad !=
                (int) direccion.Cells["idLocalidad"].Value)
            {
                MessageBox.Show(
                    "La calle " + direccion.Cells["idEntreCalle2"].Text +
                    " no pertenece a " +
                    direccion.Cells["idLocalidad"].Text + ".",
                    "No se pudo grabar", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (direccion.Cells["idBarrio"].Value != DBNull.Value &&
                _fp.dsBarrios.BarriosLista.FindByidBarrio((int) direccion.Cells["idBarrio"].Value).idLocalidad !=
                (int) direccion.Cells["idLocalidad"].Value)
            {
                MessageBox.Show(
                    "Falta el N�mero de Documento de " + direccion.Cells["idBarrio"].Text +
                    " no pertenece a " +
                    direccion.Cells["idLocalidad"].Text + ".",
                    "No se pudo grabar", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CrearPrestacion(bool terminada)
        {
            var fechaYHora = (DateTime) ultraDateTimeEditorTomada.Value;
            var telefono = textBoxTelefono.Text;
            var idLocalidad = direccionesAfiliadosUltraGrid.Rows.Count == 0 ||
                              direccionesAfiliadosUltraGrid.Rows[0].Cells["idLocalidad"].Value == DBNull.Value
                ? 0
                : (int) direccionesAfiliadosUltraGrid.Rows[0].Cells["idLocalidad"].Value;
            var idCalle = direccionesAfiliadosUltraGrid.Rows.Count == 0 ||
                          direccionesAfiliadosUltraGrid.Rows[0].Cells["idCalle"].Value == DBNull.Value
                ? 0
                : (int) direccionesAfiliadosUltraGrid.Rows[0].Cells["idCalle"].Value;
            var numero = direccionesAfiliadosUltraGrid.Rows.Count == 0
                ? ""
                : direccionesAfiliadosUltraGrid.Rows[0].Cells["Numero"].Value.ToString();
            var piso = direccionesAfiliadosUltraGrid.Rows.Count == 0
                ? ""
                : direccionesAfiliadosUltraGrid.Rows[0].Cells["Piso"].Value.ToString();
            var departamento = direccionesAfiliadosUltraGrid.Rows.Count == 0
                ? ""
                : direccionesAfiliadosUltraGrid.Rows[0].Cells["Departamento"].Value.ToString();
            var idEntreCalle1 = direccionesAfiliadosUltraGrid.Rows.Count == 0 ||
                                direccionesAfiliadosUltraGrid.Rows[0].Cells["idEntreCalle1"].Value == DBNull.Value
                ? 0
                : (int) direccionesAfiliadosUltraGrid.Rows[0].Cells["idEntreCalle1"].Value;
            var idEntreCalle2 = direccionesAfiliadosUltraGrid.Rows.Count == 0 ||
                                direccionesAfiliadosUltraGrid.Rows[0].Cells["idEntreCalle2"].Value == DBNull.Value
                ? 0
                : (int) direccionesAfiliadosUltraGrid.Rows[0].Cells["idEntreCalle2"].Value;
            var observacionesDireccion = direccionesAfiliadosUltraGrid.Rows.Count == 0
                ? ""
                : direccionesAfiliadosUltraGrid.Rows[0].Cells["Observaciones"].Value.ToString();
            var idBarrio = direccionesAfiliadosUltraGrid.Rows.Count == 0 ||
                           direccionesAfiliadosUltraGrid.Rows[0].Cells["idBarrio"].Value == DBNull.Value
                ? 0
                : (int) direccionesAfiliadosUltraGrid.Rows[0].Cells["idBarrio"].Value;
            var idTipoDeDestino = ultraComboTiposDeDestino.Value == null ? 0 : (int) ultraComboTiposDeDestino.Value;
            var idMotivoDeLlamado1 = motivosPacientesUltraGrid.Rows.Count >= 1 &&
                                     motivosPacientesUltraGrid.Rows[0].Cells["idMotivoDeLlamado"].Value != null
                ? (int) motivosPacientesUltraGrid.Rows[0].Cells["idMotivoDeLlamado"].Value
                : 0;
            var observacionesMotivo1 = motivosPacientesUltraGrid.Rows.Count >= 1
                ? motivosPacientesUltraGrid.Rows[0].Cells["Observaciones"].Value.ToString()
                : "";
            var idMotivoDeLlamado2 = motivosPacientesUltraGrid.Rows.Count >= 2 &&
                                     motivosPacientesUltraGrid.Rows[1].Cells["idMotivoDeLlamado"].Value != null
                ? (int) motivosPacientesUltraGrid.Rows[1].Cells["idMotivoDeLlamado"].Value
                : 0;
            var observacionesMotivo2 = motivosPacientesUltraGrid.Rows.Count >= 2
                ? motivosPacientesUltraGrid.Rows[1].Cells["Observaciones"].Value.ToString()
                : "";
            var idMotivoDeLlamado3 = motivosPacientesUltraGrid.Rows.Count >= 3 &&
                                     motivosPacientesUltraGrid.Rows[2].Cells["idMotivoDeLlamado"].Value != null
                ? (int) motivosPacientesUltraGrid.Rows[2].Cells["idMotivoDeLlamado"].Value
                : 0;
            var observacionesMotivo3 = motivosPacientesUltraGrid.Rows.Count >= 3
                ? motivosPacientesUltraGrid.Rows[2].Cells["Observaciones"].Value.ToString()
                : "";
            var idMotivoDeLlamado4 = motivosPacientesUltraGrid.Rows.Count >= 4 &&
                                     motivosPacientesUltraGrid.Rows[3].Cells["idMotivoDeLlamado"].Value != null
                ? (int) motivosPacientesUltraGrid.Rows[3].Cells["idMotivoDeLlamado"].Value
                : 0;
            var observacionesMotivo4 = motivosPacientesUltraGrid.Rows.Count >= 4
                ? motivosPacientesUltraGrid.Rows[3].Cells["Observaciones"].Value.ToString()
                : "";
            var idAfiliado = ((ultraGridPaciente.Rows.Count == 1) &&
                              (ultraGridPaciente.Rows[0].Cells["idAfiliado"].Value != DBNull.Value))
                ? (int) ultraGridPaciente.Rows[0].Cells["idAfiliado"].Value
                : 0;
            var apelNomb = (ultraGridPaciente.Rows.Count == 1 &&
                            ultraGridPaciente.Rows[0].Cells["ApelNomb"].Value != DBNull.Value)
                ? ultraGridPaciente.Rows[0].Cells["ApelNomb"].Value.ToString()
                : "";
            var edad = (ultraGridPaciente.Rows.Count == 1 &&
                        ultraGridPaciente.Rows[0].Cells["Edad"].Value != DBNull.Value)
                ? (int) ultraGridPaciente.Rows[0].Cells["Edad"].Value
                : 0;
            var edadEn = (ultraGridPaciente.Rows.Count == 1 &&
                          ultraGridPaciente.Rows[0].Cells["EdadEn"].Value != DBNull.Value)
                ? ultraGridPaciente.Rows[0].Cells["EdadEn"].Value.ToString()
                : "";
            var sexo = (ultraGridPaciente.Rows.Count == 1 &&
                        ultraGridPaciente.Rows[0].Cells["Sexo"].Value != DBNull.Value)
                ? ultraGridPaciente.Rows[0].Cells["Sexo"].Value.ToString()
                : "";
            var idTipoDeDocumento = (ultraGridPaciente.Rows.Count == 1 &&
                                     ultraGridPaciente.Rows[0].Cells["idTipoDeDocumento"].Value != DBNull.Value)
                ? (int) ultraGridPaciente.Rows[0].Cells["idTipoDeDocumento"].Value
                : 0;
            var numeroDeDocumento = (ultraGridPaciente.Rows.Count == 1 &&
                                     ultraGridPaciente.Rows[0].Cells["NumeroDeDocumento"].Value != DBNull.Value)
                ? ultraGridPaciente.Rows[0].Cells["NumeroDeDocumento"].Value.ToString()
                : "";
            var idPrepago = (ultraGridPaciente.Rows.Count == 1 &&
                             ultraGridPaciente.Rows[0].Cells["idPrepago"].Value != DBNull.Value)
                ? (int) ultraGridPaciente.Rows[0].Cells["idPrepago"].Value
                : 0;
            var numeroPrepago = (ultraGridPaciente.Rows.Count == 1 &&
                                 ultraGridPaciente.Rows[0].Cells["NumeroPrepago"].Value != DBNull.Value)
                ? ultraGridPaciente.Rows[0].Cells["NumeroPrepago"].Value.ToString()
                : "";
            var importe = (ultraGridPaciente.Rows.Count == 1 &&
                           ultraGridPaciente.Rows[0].Cells["Importe"].Value != DBNull.Value)
                ? (decimal) ultraGridPaciente.Rows[0].Cells["Importe"].Value
                : 0;
            var copagoSugerido = (ultraGridPaciente.Rows.Count == 1 &&
                                  ultraGridPaciente.Rows[0].Cells["CopagoSugerido"].Value != DBNull.Value)
                ? (decimal) ultraGridPaciente.Rows[0].Cells["CopagoSugerido"].Value
                : 0;
            var incidenteExterno = (ultraGridPaciente.Rows.Count == 1 &&
                                    ultraGridPaciente.Rows[0].Cells["IncidenteExterno"].Value != DBNull.Value)
                ? ultraGridPaciente.Rows[0].Cells["IncidenteExterno"].Value.ToString()
                : "";
            var extraCobertura = !(ultraGridPaciente.Rows.Count == 1 &&
                                   (bool) ultraGridPaciente.Rows[0].Cells["ExtraCobertura"].Value == false);
            var antecedentes = (ultraGridPaciente.Rows.Count == 1 &&
                                ultraGridPaciente.Rows[0].Cells["Antecedentes"].Value != DBNull.Value)
                ? ultraGridPaciente.Rows[0].Cells["Antecedentes"].Value.ToString()
                : "";
            var idCodigo = ultraComboCodigos.Value == null ? 0 : (int) ultraComboCodigos.Value;
            var idCobertura = ultraComboCobertura.Value == null ? 0 : (int) ultraComboCobertura.Value;
            var idPractica = ultraComboPracticas.Value == null ? 0 : (int) ultraComboPracticas.Value;
            var observacionesPrestacion = ultraTextEditorObservaciones.Text;
            var idContrato = ultraComboContratos.Value == null ? 0 : (int) ultraComboContratos.Value;
            var idTomador = Program.IdUsuario;
            var idMotivoDeCancelacion = ultraComboMotivoDeCancelacion.Value == null
                ? 0
                : (int) ultraComboMotivoDeCancelacion.Value;
            var aux = new Service().CrearPrestacion(fechaYHora.ToString("yyyyMMdd HH:mm:ss"), telefono, idLocalidad,
                idCalle,
                numero, piso, departamento, idEntreCalle1,
                idEntreCalle2, observacionesDireccion, idBarrio,
                idTipoDeDestino, idMotivoDeLlamado1,
                observacionesMotivo1, idMotivoDeLlamado2,
                observacionesMotivo2, idMotivoDeLlamado3,
                observacionesMotivo3, idMotivoDeLlamado4,
                observacionesMotivo4, idAfiliado, apelNomb,
                idTipoDeDocumento, numeroDeDocumento, edad,
                edadEn, sexo, idPrepago, numeroPrepago, importe,
                antecedentes, idCodigo, idCobertura, idPractica,
                observacionesPrestacion, idContrato, idTomador,
                terminada, idMotivoDeCancelacion,
                incidenteExterno, extraCobertura, copagoSugerido, Program.Pin);
            if (aux == 0)
            {
                MessageBox.Show(
                    "No se pudo grabar." + Environment.NewLine +
                    "Copie los datos en un papel.",
                    "�Atenci�n!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if (!Verificar()) return;
            if (CrearPrestacion(false))
                Close();
        }

        private void MotivosPacientesUltraGridClickCellButton(object sender, CellEventArgs e)
        {
            var frmSiem = new FormSiem
            {
                TresCifras =
                    (e.Cell.Column.Key == "BotonDespacho"
                        ? _fp.dsMotivosDeLlamado.MotivosDeLlamado.FindByidMotivoDeLlamado(
                            (int) e.Cell.Row.Cells["idMotivoDeLlamado"].Value).FichaDespacho
                        : _fp.dsMotivosDeLlamado.MotivosDeLlamado.FindByidMotivoDeLlamado(
                            (int) e.Cell.Row.Cells["idMotivoDeLlamado"].Value).FichaMasInfo)
            };
            frmSiem.ShowDialog();
        }

        private void UltraDropDownMotivosRowSelected(object sender, RowSelectedEventArgs e)
        {
            if (e.Row != null && e.Row.Cells["FichaDespacho"].Value != DBNull.Value)
            {
                motivosPacientesUltraGrid.ActiveRow.Cells["BotonDespacho"].Style = ColumnStyle.Button;
                motivosPacientesUltraGrid.ActiveRow.Cells["BotonDespacho"].Value = "Despacho";
            }
            else
            {
                motivosPacientesUltraGrid.ActiveRow.Cells["BotonDespacho"].Style = ColumnStyle.Edit;
                motivosPacientesUltraGrid.ActiveRow.Cells["BotonDespacho"].Value = "";
            }

            if (e.Row != null && e.Row.Cells["FichaMasInfo"].Value != DBNull.Value)
            {
                motivosPacientesUltraGrid.ActiveRow.Cells["BotonMasInfo"].Style = ColumnStyle.Button;
                motivosPacientesUltraGrid.ActiveRow.Cells["BotonMasInfo"].Value = "M�s Info";
            }
            else
            {
                motivosPacientesUltraGrid.ActiveRow.Cells["BotonMasInfo"].Style = ColumnStyle.Edit;
                motivosPacientesUltraGrid.ActiveRow.Cells["BotonMasInfo"].Value = "";
            }
        }

        private void UltraComboContratosValueChanged(object sender, EventArgs e)
        {
            try
            {
                ultraTextEditorCondContrato.Value =
                    _fp.dsContratosLista.Contratos.FindByidContrato((int) ultraComboContratos.Value).Condiciones;
            }
            catch
            {
                ultraTextEditorCondContrato.Value = "";
            }

            SugerirCopago();
            if (ultraComboContratos.Value == null)
            {
                if ((int) ultraComboCobertura.Value == (int) _fp.dsSistemas.Sistemas[0]["CoberturaContrato"])
                {
                    ultraComboCobertura.Value = null;
                }
            }
            else
                ultraComboCobertura.Value = _fp.dsSistemas.Sistemas[0]["CoberturaContrato"];
        }

        private void ButtonBuscarContratoClick(object sender, EventArgs e)
        {
            HoraInicial();
            var frmBuscarContrato = new FormBuscarContrato();
            frmBuscarContrato.ShowDialog(this);
            if (frmBuscarContrato.Boton == "Contrato")
            {
                labelTelefonoNoEncontrado.Visible = false;
                ultraComboContratos.Value = frmBuscarContrato.IdContrato;
                ultraComboCobertura.Value = _fp.dsSistemas.Sistemas[0]["CoberturaContrato"];
            }

            if (frmBuscarContrato.Boton == "Contrato y Direccion")
            {
                labelTelefonoNoEncontrado.Visible = false;
                ultraComboContratos.Value = frmBuscarContrato.IdContrato;
                DireccionDesdeTelefono(frmBuscarContrato.IdDireccion);
                ultraComboCobertura.Value = _fp.dsSistemas.Sistemas[0]["CoberturaContrato"];
            }

            frmBuscarContrato.Close();
        }

        private void ButtonAtencionesAnterioresClick(object sender, EventArgs e)
        {
            var faa = new FormAtencionesAnteriores();
            try
            {
                faa.IdAfiliado = (int) ultraGridPaciente.DisplayLayout.Rows[0].Cells["idAfiliado"].Value;
            }
            catch
            {
                faa.IdAfiliado = 0;
            }

            try
            {
                faa.Telefono = textBoxTelefono.Text;
            }
            catch
            {
                faa.Telefono = "";
            }

            faa.IdPrestacion = 0;
            faa.ShowDialog();
        }

        private void UltraComboMotivoDeCancelacionItemNotInList(object sender, ValidationErrorEventArgs e)
        {
            if (e.InvalidText == "")
            {
                e.RetainFocus = false; // Permite que haya valores nulos.
            }
        }

        private void UltraComboMotivoDeCancelacionRowSelected(object sender, RowSelectedEventArgs e)
        {
            buttonCancelarNuevo.Enabled = e.Row != null;
        }

        private void ButtonCancelarNuevoClick(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(ultraDateTimeEditorTomada.Value).Year == 1947)
            {
                if (ultraComboMotivoDeCancelacion.Value != null)
                {
                    CrearPrestacion(true);
                }
            }

            Close();
        }

        private void UltraDropDownLocalidadRowSelected(object sender, RowSelectedEventArgs e)
        {
            direccionesAfiliadosUltraGrid.Update();
            ultraDropDownBarrios.DisplayLayout.RefreshFilters();
            ultraDropDownCalles.DisplayLayout.RefreshFilters();
        }

        private void DireccionesAfiliadosUltraGridAfterRowActivate(object sender, EventArgs e)
        {
            ultraDropDownBarrios.DisplayLayout.RefreshFilters();
            ultraDropDownCalles.DisplayLayout.RefreshFilters();
        }

        private void DireccionesAfiliadosUltraGridEnter(object sender, EventArgs e)
        {
            var grid = (UltraGrid) sender;
            if (grid.ActiveRow != null) return;
            grid.Rows.TemplateAddRow.Cells[0].Activate();
            grid.PerformAction(UltraGridAction.EnterEditMode);
        }

        private void MotivosPacientesUltraGridEnter(object sender, EventArgs e)
        {
            var grid = (UltraGrid) sender;
            if (grid.ActiveRow != null) return;
            grid.Rows.TemplateAddRow.Cells[0].Activate();
            grid.PerformAction(UltraGridAction.EnterEditMode);
        }

        private void UltraGridPacienteEnter(object sender, EventArgs e)
        {
            var grid = (UltraGrid) sender;
            if (grid.ActiveRow != null) return;
            grid.Rows.TemplateAddRow.Cells["ApelNomb"].Activate();
            grid.PerformAction(UltraGridAction.EnterEditMode);
        }

        private void UltraGridPacienteAfterEnterEditMode(object sender, EventArgs e)
        {
            if (ultraGridPaciente.ActiveCell.Column.Key == "Importe")
            {
                ultraGridPaciente.ActiveCell.SelectAll();
            }

            ManejoDatos.SeleccionInicio(sender);
        }

        private void UltraComboCodigosRowSelected(object sender, RowSelectedEventArgs e)
        {
            HoraInicial();
        }

        private void UltraComboCoberturaRowSelected(object sender, RowSelectedEventArgs e)
        {
            HoraInicial();
        }

        private void UltraComboPracticasRowSelected(object sender, RowSelectedEventArgs e)
        {
            HoraInicial();
            SugerirCopago();
        }

        private void UltraGridPacienteKeyPress(object sender, KeyPressEventArgs e)
        {
            if (ultraGridPaciente.ActiveCell.Column.Key != "ApelNomb") return;
            const string caracteres = "ABCDEFGHIJKLMN�OPQRSTUVWXYZabcdefghijklmn�opqrstuvwxyz1234567890";
            if (!caracteres.Contains(e.KeyChar.ToString(CultureInfo.InvariantCulture))) return;
            _nombreAfiliadoCambiado = true;
        }

        private void UltraGridPacienteBeforeCellDeactivate(object sender, CancelEventArgs e)
        {
            if (ultraGridPaciente.ActiveCell.Column.Key != "ApelNomb") return;
            if (!_nombreAfiliadoCambiado) return;
            ultraGridPaciente.ActiveRow.Cells["EsAfiliado"].Value = false;
            ultraGridPaciente.ActiveRow.Cells["idAfiliado"].Value = DBNull.Value;
            ultraComboCobertura.Value = DBNull.Value;
        }

        private void SugerirCopago()
        {
            var idContrato = ultraComboContratos.Value == null ? 0 : (int) ultraComboContratos.Value;
            var idTipoDeContrato = ultraComboContratos.Value == null ? 0 : (int) ultraComboContratos.ActiveRow.Cells["idTipoDeContrato"].Value;
            var idPlan = ((ultraGridPaciente.Rows.Count == 1) &&
                          (ultraGridPaciente.Rows[0].Cells["idPlan"].Value != DBNull.Value))
                ? (int) ultraGridPaciente.Rows[0].Cells["idPlan"].Value
                : 0;
            var idTipoDeDestino = ultraComboTiposDeDestino.Value == null ? 0 : (int) ultraComboTiposDeDestino.Value;
            var idCodigo = ultraComboCodigos.Value == null ? 0 : (int) ultraComboCodigos.Value;
            var idPractica = ultraComboPracticas.Value == null ? 0 : (int) ultraComboPracticas.Value;
            var copagoSugerido = new Service().SugerirCopago(idContrato, idPlan, idTipoDeDestino, idCodigo, idPractica,
                idTipoDeContrato, Program.Pin);
            if (ultraGridPaciente.DisplayLayout.Rows.Count == 0)
            {
                ultraGridPaciente.DisplayLayout.Bands[0].AddNew();
            }

            ultraGridPaciente.Rows[0].Cells["Importe"].Value = copagoSugerido;
            ultraGridPaciente.Rows[0].Cells["CopagoSugerido"].Value = copagoSugerido;
        }

        private void UltraComboTiposDeDestinoValueChanged(object sender, EventArgs e)
        {
            SugerirCopago();
        }

        private void UltraComboCodigosValueChanged(object sender, EventArgs e)
        {
            SugerirCopago();
        }

        private void direccionesAfiliadosUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                direccionesAfiliadosUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void motivosPacientesUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                motivosPacientesUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void ultraGridPaciente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ultraGridPaciente.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void direccionesAfiliadosUltraGrid_AfterEnterEditMode(object sender, EventArgs e)
        {
            ManejoDatos.SeleccionInicio(sender);
        }

        private void motivosPacientesUltraGrid_AfterEnterEditMode(object sender, EventArgs e)
        {
            ManejoDatos.SeleccionInicio(sender);
        }
    }
}