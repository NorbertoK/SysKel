using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using Cabina.WS;
using Infragistics.Win.UltraWinDataSource;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    public partial class FormTomarProgramado : Form1
    {
        #region Variables

        private readonly FormDialogoDireccion _formulario = new FormDialogoDireccion();
        private FormPrincipalCabina _fp;
        private bool _nombreAfiliadoCambiado;
        private string _origenODestino;
        private int _idPlan;

        #endregion

        public FormTomarProgramado()
        {
            _nombreAfiliadoCambiado = false;
            InitializeComponent();
        }

        private void FormTomarLlamadoLoad(object sender, EventArgs e)
        {
            /*Que el documento por default sea DNI*/
            ultraGridPaciente.DisplayLayout.Bands["Band 0"].Columns["idTipoDeDocumento"].DefaultCellValue =
                new Service().DefaultDNI(Program.Pin);

            ActiveControl = textBoxTelefono;
            _formulario.MiEvento += PoneValorAVariable;
            /*Llena el combo Edad en*/
            ultraGridPaciente.DisplayLayout.ValueLists.Add("EdadEn");
            ultraGridPaciente.DisplayLayout.ValueLists["EdadEn"].ValueListItems.Add("A", "años");
            ultraGridPaciente.DisplayLayout.ValueLists["EdadEn"].ValueListItems.Add("M", "meses");
            ultraGridPaciente.DisplayLayout.ValueLists["EdadEn"].ValueListItems.Add("D", "días");
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

            /*Que la edad por default sea en años*/
            ultraGridPaciente.DisplayLayout.Bands["Band 0"].Columns["EdadEn"].DefaultCellValue = "A";

            /*Manejo de los Tabs*/
            UltraGridDireccionOrigen.DisplayLayout.TabNavigation = TabNavigation.NextControlOnLastCell;
            ultraGridPaciente.DisplayLayout.TabNavigation = TabNavigation.NextControlOnLastCell;

            /*Tomo datos del padre*/
            _fp = (FormPrincipalCabina) MdiParent;
            callesBindingSource.DataSource = _fp.dsCallesLista;
            prepagosBindingSource.DataSource = _fp.dsPrepagos;
            localidadesBindingSource.DataSource = _fp.dsLocalidades1;
            //contratosBindingSource.DataSource = _fp.dsContratosLista;
            barriosListaBindingSource.DataSource = _fp.dsBarrios;
            coberturasBindingSource.DataSource = _fp.dsCoberturas;
            practicasBindingSource.DataSource = _fp.dsPracticas;
            tiposDeDestinoBindingSource.DataSource = _fp.dsTiposDeDestino;
            lugaresListaBindingSource.DataSource = _fp.dsLugaresLista;
            tiposDeDocumentoBindingSource.DataSource = _fp.dsTiposDeDocumento;
            dsContratosLista.Merge(new Service().GetContratosRenglonFacturaTodos(Program.Pin));
        }

        private void PoneValorAVariable(string mensaje)
        {
            _origenODestino = mensaje;
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

        private void UltraComboLugarDestinoRowSelected(object sender, RowSelectedEventArgs e)
        {
            checkBoxRetorno.Enabled = true;
        }

        private void UltraGridDireccionDestinoCellChange(object sender, CellEventArgs e)
        {
            checkBoxRetorno.Enabled = true;
        }

        #region Direcciones

        private void UltraGridDireccionOrigenEnter(object sender, EventArgs e)
        {
            var grid = (UltraGrid) sender;
            if (grid.ActiveRow != null) return;
            grid.Rows.TemplateAddRow.Cells[0].Activate();
            grid.PerformAction(UltraGridAction.EnterEditMode);
        }

        private void UltraGridDireccionDestinoEnter(object sender, EventArgs e)
        {
            var grid = (UltraGrid) sender;
            if (grid.ActiveRow != null) return;
            grid.Rows.TemplateAddRow.Cells[0].Activate();
            grid.PerformAction(UltraGridAction.EnterEditMode);
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

        private void PonerDireccionDelLugar(string cual)
        {
            dsDireccionLugar.Clear();
            dsDireccionLugar.Merge(
                new Service().GetDireccionLugar(
                    cual == "Origen" ? (int) UltraComboLugarOrigen.Value : (int) ultraComboLugarDestino.Value,
                    Program.Pin));
            var grilla = cual == "Origen" ? UltraGridDireccionOrigen : UltraGridDireccionDestino;
            if (grilla.DisplayLayout.Rows.Count == 0)
            {
                grilla.DisplayLayout.Bands[0].AddNew();
            }
            grilla.Rows[0].Cells["idLocalidad"].Value =
                dsDireccionLugar.DireccionLugar[0]["idLocalidad"];
            grilla.Rows[0].Cells["idCalle"].Value =
                dsDireccionLugar.DireccionLugar[0]["idCalle"];
            grilla.Rows[0].Cells["Numero"].Value =
                dsDireccionLugar.DireccionLugar[0]["Numero"].ToString();
            grilla.Rows[0].Cells["Piso"].Value =
                dsDireccionLugar.DireccionLugar[0]["Piso"].ToString();
            grilla.Rows[0].Cells["Departamento"].Value =
                dsDireccionLugar.DireccionLugar[0]["Departamento"].ToString();
            grilla.Rows[0].Cells["idEntreCalle1"].Value =
                dsDireccionLugar.DireccionLugar[0]["idEntreCalle1"];
            grilla.Rows[0].Cells["idEntreCalle2"].Value =
                dsDireccionLugar.DireccionLugar[0]["idEntreCalle2"];
            grilla.Rows[0].Cells["idBarrio"].Value =
                dsDireccionLugar.DireccionLugar[0]["idBarrio"];
            if (dsDireccionLugar.DireccionLugar[0]["Observaciones"] != DBNull.Value &&
                dsDireccionLugar.DireccionLugar[0]["Observaciones"].ToString().Length > 0)
            {
                if (grilla.Rows[0].Cells["Observaciones"].Value == DBNull.Value ||
                    grilla.Rows[0].Cells["Observaciones"].Value.ToString().Length == 0)
                {
                    grilla.Rows[0].Cells["Observaciones"].Value =
                        dsDireccionLugar.DireccionLugar[0]["Observaciones"].ToString();
                }
                else
                {
                    grilla.Rows[0].Cells["Observaciones"].Value =
                        dsDireccionLugar.DireccionLugar[0]["Observaciones"] + " | " +
                        grilla.Rows[0].Cells["Observaciones"].Value;
                }
            }

            grilla.Rows[0].Update();
        }

        #endregion

        #region Combos

        private void UltraComboCoberturaRowSelected(object sender, RowSelectedEventArgs e)
        {
            HoraInicial();
        }

        private void UltraComboPracticasRowSelected(object sender, RowSelectedEventArgs e)
        {
            HoraInicial();
        }

        private void UltraComboLugarOrigenAfterCloseUp(object sender, EventArgs e)
        {
            PonerDireccionDelLugar("Origen");
        }

        private void UltraComboLugarDestinoAfterCloseUp(object sender, EventArgs e)
        {
            PonerDireccionDelLugar("Destino");
        }

        #endregion

        #region Item not in list

        private void UltraComboCoberturaItemNotInList(object sender, ValidationErrorEventArgs e)
        {
            if (e.InvalidText == "")
            {
                e.RetainFocus = false; // Permite que haya valores nulos.
            }
        }

        private void UltraComboPracticasItemNotInList(object sender, ValidationErrorEventArgs e)
        {
            if (e.InvalidText == "")
            {
                e.RetainFocus = false; // Permite que haya valores nulos.
            }
        }

        private void UltraComboContratosItemNotInList(object sender, ValidationErrorEventArgs e)
        {
            if (e.InvalidText == "")
            {
                e.RetainFocus = false; // Permite que haya valores nulos.
            }
        }

        #endregion

        #region Contrato

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
                if ((int)ultraComboCobertura.Value == (int)_fp.dsSistemas.Sistemas[0]["CoberturaContrato"])
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

        #endregion

        #region Filtros

        private void UltraDropDownBarriosFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = UltraGridDireccionOrigen.ActiveRow.Cells["idLocalidad"].Value == DBNull.Value
                         ? new FilterCondition(e.Row.Band.Columns["idLocalidad"],
                                               FilterComparisionOperator.Equals, 0)
                         : new FilterCondition(e.Row.Band.Columns["idLocalidad"],
                                               FilterComparisionOperator.Equals,
                                               _fp.dsLocalidades1.Localidades.FindByidLocalidad(
                                                   (int)
                                                   UltraGridDireccionOrigen.ActiveRow.Cells["idLocalidad"].
                                                       Value).
                                                   idLocalidad);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void UltraDropDownLocalidadRowSelected(object sender, RowSelectedEventArgs e)
        {
            UltraGridDireccionOrigen.Update();
            ultraDropDownBarrios.DisplayLayout.RefreshFilters();
            ultraDropDownCalles.DisplayLayout.RefreshFilters();
        }

        private void UltraDropDownLocalidad1RowSelected(object sender, RowSelectedEventArgs e)
        {
            UltraGridDireccionDestino.Update();
            ultraDropDownBarrios1.DisplayLayout.RefreshFilters();
            ultraDropDownCalles1.DisplayLayout.RefreshFilters();
        }

        private void DireccionOrigenUltraGridAfterRowActivate(object sender, EventArgs e)
        {
            ultraDropDownBarrios.DisplayLayout.RefreshFilters();
            ultraDropDownCalles.DisplayLayout.RefreshFilters();
        }

        private void DireccionDestinoUltraGridAfterRowActivate(object sender, EventArgs e)
        {
            ultraDropDownBarrios1.DisplayLayout.RefreshFilters();
            ultraDropDownCalles1.DisplayLayout.RefreshFilters();
        }

        private void UltraDropDownCallesFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = UltraGridDireccionOrigen.ActiveRow.Cells["idLocalidad"].Value == DBNull.Value
                         ? new FilterCondition(e.Row.Band.Columns["idLocalidad"],
                                               FilterComparisionOperator.Equals, 0)
                         : new FilterCondition(e.Row.Band.Columns["idLocalidad"],
                                               FilterComparisionOperator.Equals,
                                               _fp.dsLocalidades1.Localidades.FindByidLocalidad(
                                                   (int)
                                                   UltraGridDireccionOrigen.ActiveRow.Cells["idLocalidad"].
                                                       Value).
                                                   idLocalidad);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void UltraDropDownBarrios1FilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = UltraGridDireccionDestino.ActiveRow.Cells["idLocalidad"].Value == DBNull.Value
                         ? new FilterCondition(e.Row.Band.Columns["idLocalidad"],
                                               FilterComparisionOperator.Equals, 0)
                         : new FilterCondition(e.Row.Band.Columns["idLocalidad"],
                                               FilterComparisionOperator.Equals,
                                               _fp.dsLocalidades1.Localidades.FindByidLocalidad(
                                                   (int)
                                                   UltraGridDireccionDestino.ActiveRow.Cells["idLocalidad"].
                                                       Value).
                                                   idLocalidad);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void UltraDropDownCalles1FilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = UltraGridDireccionDestino.ActiveRow.Cells["idLocalidad"].Value == DBNull.Value
                         ? new FilterCondition(e.Row.Band.Columns["idLocalidad"],
                                               FilterComparisionOperator.Equals, 0)
                         : new FilterCondition(e.Row.Band.Columns["idLocalidad"],
                                               FilterComparisionOperator.Equals,
                                               _fp.dsLocalidades1.Localidades.FindByidLocalidad(
                                                   (int)
                                                   UltraGridDireccionDestino.ActiveRow.Cells["idLocalidad"].
                                                       Value).
                                                   idLocalidad);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        #endregion

        #region Terminar

        private bool Verificar()
        {
            if (UltraGridDireccionOrigen.Rows.Count == 0)
            {
                MessageBox.Show("No hay dirección inicial.", "¡Atención!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (
                (UltraGridDireccionOrigen.Rows[0].Cells["idLocalidad"].Value == DBNull.Value &&
                 UltraGridDireccionOrigen.Rows[0].Cells["Observaciones"].Value == DBNull.Value))
            {
                MessageBox.Show("No está la localidad y no hay Observaciones",
                                "Faltan datos de la dirección de origen.",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (UltraGridDireccionDestino.Rows.Count == 1 &&
                (UltraGridDireccionDestino.Rows[0].Cells["idLocalidad"].Value == DBNull.Value &&
                 UltraGridDireccionDestino.Rows[0].Cells["Observaciones"].Value == DBNull.Value))
            {
                MessageBox.Show("No está la localidad y no hay Observaciones",
                                "Faltan datos de la dirección de destino.",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (ultraComboPracticas.Value == null)
            {
                MessageBox.Show("Falta la Práctica",
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
            var direccion = UltraGridDireccionOrigen.Rows[0];
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
                    "Falta el Número de Documento de " + direccion.Cells["idBarrio"].Text +
                    " no pertenece a " +
                    direccion.Cells["idLocalidad"].Text + ".",
                    "No se pudo grabar", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            if (UltraGridDireccionDestino.Rows.Count > 0)
            {
                direccion = UltraGridDireccionDestino.Rows[0];
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
                        "Falta el Número de Documento de " + direccion.Cells["idBarrio"].Text +
                        " no pertenece a " +
                        direccion.Cells["idLocalidad"].Text + ".",
                        "No se pudo grabar", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private bool CrearPrestacion()
        {
            var fechaYHora = (DateTime) ultraDateTimeEditorTomada.Value;
            var telefono = textBoxTelefono.Text;
            var idLocalidad1 = UltraGridDireccionOrigen.Rows.Count == 0 ||
                               UltraGridDireccionOrigen.Rows[0].Cells["idLocalidad"].Value == DBNull.Value
                                   ? 0
                                   : (int) UltraGridDireccionOrigen.Rows[0].Cells["idLocalidad"].Value;
            var idCalle1 = UltraGridDireccionOrigen.Rows.Count == 0 ||
                           UltraGridDireccionOrigen.Rows[0].Cells["idCalle"].Value == DBNull.Value
                               ? 0
                               : (int) UltraGridDireccionOrigen.Rows[0].Cells["idCalle"].Value;
            var numero1 = UltraGridDireccionOrigen.Rows.Count == 0
                              ? ""
                              : UltraGridDireccionOrigen.Rows[0].Cells["Numero"].Value.ToString();
            var piso1 = UltraGridDireccionOrigen.Rows.Count == 0
                            ? ""
                            : UltraGridDireccionOrigen.Rows[0].Cells["Piso"].Value.ToString();
            var departamento1 = UltraGridDireccionOrigen.Rows.Count == 0
                                    ? ""
                                    : UltraGridDireccionOrigen.Rows[0].Cells["Departamento"].Value.ToString();
            var idEntreCalle11 = UltraGridDireccionOrigen.Rows.Count == 0 ||
                                 UltraGridDireccionOrigen.Rows[0].Cells["idEntreCalle1"].Value == DBNull.Value
                                     ? 0
                                     : (int) UltraGridDireccionOrigen.Rows[0].Cells["idEntreCalle1"].Value;
            var idEntreCalle21 = UltraGridDireccionOrigen.Rows.Count == 0 ||
                                 UltraGridDireccionOrigen.Rows[0].Cells["idEntreCalle2"].Value == DBNull.Value
                                     ? 0
                                     : (int) UltraGridDireccionOrigen.Rows[0].Cells["idEntreCalle2"].Value;
            var observacionesDireccion1 = UltraGridDireccionOrigen.Rows.Count == 0
                                              ? ""
                                              : UltraGridDireccionOrigen.Rows[0].Cells["Observaciones"].Value.
                                                    ToString();
            var idBarrio1 = UltraGridDireccionOrigen.Rows.Count == 0 ||
                            UltraGridDireccionOrigen.Rows[0].Cells["idBarrio"].Value == DBNull.Value
                                ? 0
                                : (int) UltraGridDireccionOrigen.Rows[0].Cells["idBarrio"].Value;
            var idLocalidad2 = UltraGridDireccionDestino.Rows.Count == 0 ||
                               UltraGridDireccionDestino.Rows[0].Cells["idLocalidad"].Value == DBNull.Value
                                   ? 0
                                   : (int) UltraGridDireccionDestino.Rows[0].Cells["idLocalidad"].Value;
            var idCalle2 = UltraGridDireccionDestino.Rows.Count == 0 ||
                           UltraGridDireccionDestino.Rows[0].Cells["idCalle"].Value == DBNull.Value
                               ? 0
                               : (int) UltraGridDireccionDestino.Rows[0].Cells["idCalle"].Value;
            var numero2 = UltraGridDireccionDestino.Rows.Count == 0
                              ? ""
                              : UltraGridDireccionDestino.Rows[0].Cells["Numero"].Value.ToString();
            var piso2 = UltraGridDireccionDestino.Rows.Count == 0
                            ? ""
                            : UltraGridDireccionDestino.Rows[0].Cells["Piso"].Value.ToString();
            var departamento2 = UltraGridDireccionDestino.Rows.Count == 0
                                    ? ""
                                    : UltraGridDireccionDestino.Rows[0].Cells["Departamento"].Value.ToString();
            var idEntreCalle12 = UltraGridDireccionDestino.Rows.Count == 0 ||
                                 UltraGridDireccionDestino.Rows[0].Cells["idEntreCalle1"].Value == DBNull.Value
                                     ? 0
                                     : (int) UltraGridDireccionDestino.Rows[0].Cells["idEntreCalle1"].Value;
            var idEntreCalle22 = UltraGridDireccionDestino.Rows.Count == 0 ||
                                 UltraGridDireccionDestino.Rows[0].Cells["idEntreCalle2"].Value == DBNull.Value
                                     ? 0
                                     : (int) UltraGridDireccionDestino.Rows[0].Cells["idEntreCalle2"].Value;
            var observacionesDireccion2 = UltraGridDireccionDestino.Rows.Count == 0
                                              ? ""
                                              : UltraGridDireccionDestino.Rows[0].Cells["Observaciones"].Value.
                                                    ToString();
            var idBarrio2 = UltraGridDireccionDestino.Rows.Count == 0 ||
                            UltraGridDireccionDestino.Rows[0].Cells["idBarrio"].Value == DBNull.Value
                                ? 0
                                : (int) UltraGridDireccionDestino.Rows[0].Cells["idBarrio"].Value;
            var haySegundaDirección = UltraGridDireccionDestino.Rows.Count > 0;
            var esperaYRetorno = checkBoxRetorno.Checked;
            var idAfiliado = ((ultraGridPaciente.Rows.Count == 1) &&
                              (ultraGridPaciente.Rows[0].Cells["idAfiliado"].Value != DBNull.Value))
                                 ? (int) ultraGridPaciente.Rows[0].Cells["idAfiliado"].Value
                                 : 0;
            var apelNomb = (ultraGridPaciente.Rows.Count == 1 &&
                            ultraGridPaciente.Rows[0].Cells["ApelNomb"].Value != DBNull.Value)
                               ? ultraGridPaciente.Rows[0].Cells["ApelNomb"].Value.ToString()
                               : "";
            var idTipoDeDocumento = (ultraGridPaciente.Rows.Count == 1 &&
                                     ultraGridPaciente.Rows[0].Cells["idTipoDeDocumento"].Value != DBNull.Value)
                                        ? (int) ultraGridPaciente.Rows[0].Cells["idTipoDeDocumento"].Value
                                        : 0;
            var numeroDeDocumento = (ultraGridPaciente.Rows.Count == 1 &&
                                     ultraGridPaciente.Rows[0].Cells["NumeroDeDocumento"].Value != DBNull.Value)
                                        ? ultraGridPaciente.Rows[0].Cells["NumeroDeDocumento"].Value.ToString()
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
                              ? (decimal)ultraGridPaciente.Rows[0].Cells["CopagoSugerido"].Value
                              : 0;
            var extraCobertura = !(ultraGridPaciente.Rows.Count == 1 &&
                                   (bool) ultraGridPaciente.Rows[0].Cells["ExtraCobertura"].Value == false);
            var antecedentes = (ultraGridPaciente.Rows.Count == 1 &&
                                ultraGridPaciente.Rows[0].Cells["Antecedentes"].Value != DBNull.Value)
                                   ? ultraGridPaciente.Rows[0].Cells["Antecedentes"].Value.ToString()
                                   : "";
            var idCobertura = ultraComboCobertura.Value == null ? 0 : (int) ultraComboCobertura.Value;
            var idPractica = ultraComboPracticas.Value == null ? 0 : (int) ultraComboPracticas.Value;
            var idContrato = ultraComboContratos.Value == null ? 0 : (int) ultraComboContratos.Value;
            var idTomador = Program.IdUsuario;
            var ds = new DataSet("dsTablaPrestaciones");
            var tblPrestaciones = ds.Tables.Add("tblPrestaciones");
            tblPrestaciones.Columns.Add("Agendada", typeof (DateTime));
            tblPrestaciones.Columns.Add("Observaciones", typeof (String));
            foreach (UltraDataRow prestacion in ultraDataSourcePrestaciones.Rows)
            {
                var nuevaPrestacion = tblPrestaciones.NewRow();
                nuevaPrestacion["Agendada"] = prestacion["Fecha"];
                nuevaPrestacion["Observaciones"] = prestacion["Observaciones"];
                tblPrestaciones.Rows.Add(nuevaPrestacion);
            }
            var xdocu = ds.GetXml();
            var prestacionesXML = new XmlDocument();
            prestacionesXML.LoadXml(xdocu);
            var objNodeLst = prestacionesXML.SelectNodes("//dsTablaPrestaciones/tblPrestaciones/Agendada");
            foreach (XmlNode objNode in objNodeLst)
            {
                //DateTime value is formatted here as per your need.
                var dt = DateTime.Parse(objNode.InnerText);
                objNode.InnerText = dt.ToLocalTime().ToString("yyyy-MM-dd HH:mm");
            }
            var sw = new StringWriter();
            var xw = new XmlTextWriter(sw);
            prestacionesXML.WriteTo(xw);
            var prestacionesString = "<?xml version=\"1.0\" encoding=\"iso-8859-1\"?>" + sw;
            var aux = new Service().CrearPrestacionProgramada(prestacionesString, fechaYHora.ToString("yyyyMMdd HH:mm:ss"),
                                                              telefono, idLocalidad1,
                                                              idCalle1, numero1, piso1, departamento1,
                                                              idEntreCalle11,
                                                              idEntreCalle21, observacionesDireccion1,
                                                              idBarrio1,
                                                              idLocalidad2, idCalle2, numero2, piso2,
                                                              departamento2,
                                                              idEntreCalle12, idEntreCalle22,
                                                              observacionesDireccion2,
                                                              idBarrio2, haySegundaDirección,
                                                              esperaYRetorno, idAfiliado,
                                                              apelNomb, idTipoDeDocumento,
                                                              numeroDeDocumento, edad, edadEn, sexo,
                                                              idPrepago,
                                                              numeroPrepago,
                                                              importe, antecedentes, idCobertura,
                                                              idPractica,
                                                              idContrato, idTomador,
                                                              extraCobertura, copagoSugerido,Program.Pin);
            if (aux == 0)
            {
                MessageBox.Show(
                    "No se pudo grabar.",
                    "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if (!Verificar()) return;
            if (CrearPrestacion())
                Close();
        }

        #endregion

        #region Teléfono

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

        private void ButtonBuscarTelefonoClick(object sender, EventArgs e)
        {
            buttonBuscarTelefono.Enabled = false;
            DsCabBuscarTelefono aux = new Service().GetRefTelefono(textBoxTelefono.Text,
                                                                   Program.Pin);
            if (aux == null)
            {
                labelTelefonoNoEncontrado.Text =
                    "Teléfono no encontrado en la Base de Datos.";
                labelTelefonoNoEncontrado.Visible = true;
            }
            else
            {
                var frmBuscar = new FormBuscarDireccionYAfiliado {Aux = aux};
                frmBuscar.ShowDialog(this);
                if (frmBuscar.Boton == "Afiliado")
                {
                    dsBuscarTelefono.Merge(new Service().GetAfiliadoDelTelefono(
                        frmBuscar.IdAfiliado, Program.Pin));
                    _idPlan = frmBuscar.IdPlan;
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
                    _idPlan = frmBuscar.IdPlan;
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

        internal void DireccionDesdeTelefono(int idDireccion)
        {
            _formulario.ShowDialog();
            dsBuscarTelefono.Clear();
            dsBuscarTelefono.Merge(new Service().GetDireccionDelTelefono(idDireccion, Program.Pin));
            var grilla = _origenODestino == "Origen" ? UltraGridDireccionOrigen : UltraGridDireccionDestino;
            if (grilla.DisplayLayout.Rows.Count == 0)
            {
                grilla.DisplayLayout.Bands[0].AddNew();
            }
            grilla.Rows[0].Cells["idLocalidad"].Value =
                dsBuscarTelefono.Direcciones[0]["idLocalidad"];
            grilla.Rows[0].Cells["idCalle"].Value =
                dsBuscarTelefono.Direcciones[0]["idCalle"];
            grilla.Rows[0].Cells["Numero"].Value =
                dsBuscarTelefono.Direcciones[0]["Numero"].ToString();
            grilla.Rows[0].Cells["Piso"].Value =
                dsBuscarTelefono.Direcciones[0]["Piso"].ToString();
            grilla.Rows[0].Cells["Departamento"].Value =
                dsBuscarTelefono.Direcciones[0]["Departamento"].ToString();
            grilla.Rows[0].Cells["idEntreCalle1"].Value =
                dsBuscarTelefono.Direcciones[0]["idEntreCalle1"];
            grilla.Rows[0].Cells["idEntreCalle2"].Value =
                dsBuscarTelefono.Direcciones[0]["idEntreCalle2"];
            grilla.Rows[0].Cells["idBarrio"].Value =
                dsBuscarTelefono.Direcciones[0]["idBarrio"];
            if (dsBuscarTelefono.Direcciones[0]["Observaciones"] != DBNull.Value &&
                dsBuscarTelefono.Direcciones[0]["Observaciones"].ToString().Length > 0)
            {
                if (grilla.Rows[0].Cells["Observaciones"].Value == DBNull.Value ||
                    grilla.Rows[0].Cells["Observaciones"].Value.ToString().Length == 0)
                {
                    grilla.Rows[0].Cells["Observaciones"].Value =
                        dsBuscarTelefono.Direcciones[0]["Observaciones"].ToString();
                }
                else
                {
                    grilla.Rows[0].Cells["Observaciones"].Value =
                        dsBuscarTelefono.Direcciones[0]["Observaciones"] + " | " +
                        grilla.Rows[0].Cells["Observaciones"].Value;
                }
            }

            grilla.Rows[0].Update();
        }

        #endregion

        #region Hora Inicial

        private void HoraInicial()
        {
            // Fija la hora de tomada la prestación
            if (Convert.ToDateTime(ultraDateTimeEditorTomada.Value).Year != 1947) return;
            ultraDateTimeEditorTomada.Value = new Service().HoraActual(Program.Pin);
        }

        private void UltraGridPacienteCellChange(object sender, CellEventArgs e)
        {
            HoraInicial();
        }

        private void TextBoxTelefonoKeyDown(object sender, KeyEventArgs e)
        {
            HoraInicial();
        }

        #endregion

        #region Paciente

        private string XEdad(DateTime fechanac)
        {
            var ahora = new Service().HoraActual(Program.Pin);
            // Calculamos la diferencia de años
            int anyos = ahora.Year - fechanac.Year;
            // Restamos un año si estamos antes de el
            // día de nacimiento en el año actual
            if (ahora.Month < fechanac.Month || (ahora.Month == fechanac.Month && ahora.Day < fechanac.Day))
            {
                anyos--;
            }
            if (anyos > 0)
            {
                return anyos.ToString("000") + "A";
            }
            int meses = ahora.Month - fechanac.Month;
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
            ultraGridPaciente.DisplayLayout.Rows[0].Cells["ApelNomb"].Value = dsPacientesPrestacion1.Pacientes[0]["Nombre"];
            ultraGridPaciente.DisplayLayout.Rows[0].Cells["idTipoDeDocumento"].Value =
                dsPacientesPrestacion1.Pacientes[0]["idTipoDeDocumento"];
            ultraGridPaciente.DisplayLayout.Rows[0].Cells["NumeroDeDocumento"].Value =
                dsPacientesPrestacion1.Pacientes[0]["NumeroDeDocumento"];
            /*No tomo la edad porque es de una prestación anterior y puede haber cambiado*/
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
            var idPlan = (int)ultraGridPaciente.DisplayLayout.Rows[0].Cells["idPlan"].Value;
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
                    Convert.ToInt32(XEdad((DateTime) dsBuscarTelefono.Afiliados[0]["FechaDeNacimiento"]).Substring(0, 3));
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
            var idPlan = (int)ultraGridPaciente.DisplayLayout.Rows[0].Cells["idPlan"].Value;
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
            if (frmBuscarAfiliadoDesdeToma.Boton == "Datos de la Dirección")
            {
                DireccionDesdeTelefono(frmBuscarAfiliadoDesdeToma.IdDireccion);
            }
            if (frmBuscarAfiliadoDesdeToma.Boton != "Datos del Afiliado y la Dirección") return;
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

        private void UltraGridPacienteKeyPress(object sender, KeyPressEventArgs e)
        {
            if (ultraGridPaciente.ActiveCell.Column.Key != "ApelNomb") return;
            const string caracteres = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz1234567890";
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

        private void UltraGridPacienteAfterEnterEditMode(object sender, EventArgs e)
        {
            if (ultraGridPaciente.ActiveCell.Column.Key == "Importe")
            {
                ultraGridPaciente.ActiveCell.SelectAll();
            }
            ManejoDatos.SeleccionInicio(sender);
        }

        #endregion
        
        private void SugerirCopago()
        {
            var idContrato = ultraComboContratos.Value == null ? 0 : (int)ultraComboContratos.Value;
            var idTipoDeContrato = ultraComboContratos.Value == null ? 0 : (int) ultraComboContratos.ActiveRow.Cells["idTipoDeContrato"].Value;
            var idPlan = _idPlan;
            const int idTipoDeDestino = 0;
            const int idCodigo = 4;
            var idPractica = ultraComboPracticas.Value == null ? 0 : (int)ultraComboPracticas.Value;
            var copagoSugerido = new Service().SugerirCopago(idContrato, idPlan, idTipoDeDestino, idCodigo, idPractica, idTipoDeContrato, Program.Pin);
            if (ultraGridPaciente.DisplayLayout.Rows.Count == 0)
            {
                ultraGridPaciente.DisplayLayout.Bands[0].AddNew();
            }
            ultraGridPaciente.Rows[0].Cells["Importe"].Value = copagoSugerido;
            ultraGridPaciente.Rows[0].Cells["CopagoSugerido"].Value = copagoSugerido;
        }

        private void UltraComboPracticasValueChanged(object sender, EventArgs e)
        {
            SugerirCopago();
        }

        private void UltraGridPrestacionesAfterRowInsert(object sender, RowEventArgs e)
        {
            buttonAceptar.Enabled = ultraGridPrestaciones.Rows.Count > 0;
        }

        private void UltraGridPrestacionesAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = ultraGridPrestaciones.Rows.Count > 0;
        }

        private void ultraGridPaciente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ultraGridPaciente.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void UltraGridDireccionOrigen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                UltraGridDireccionOrigen.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void UltraGridDireccionDestino_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                UltraGridDireccionDestino.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void ultraGridPrestaciones_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ultraGridPrestaciones.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void UltraGridDireccionOrigen_AfterEnterEditMode(object sender, EventArgs e)
        {
            ManejoDatos.SeleccionInicio(sender);
        }

        private void UltraGridDireccionDestino_AfterEnterEditMode(object sender, EventArgs e)
        {
            ManejoDatos.SeleccionInicio(sender);
        }

        private void ultraGridPrestaciones_AfterEnterEditMode(object sender, EventArgs e)
        {
            ManejoDatos.SeleccionInicio(sender);
        }
    }
}