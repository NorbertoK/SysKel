using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Cabina.Properties;
using Cabina.WS;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using ColumnStyle = Infragistics.Win.UltraWinGrid.ColumnStyle;

namespace Cabina
{
    public partial class FormDespacho : Form1
    {
        #region Eventos recursos

        private void UltraDropDownRecursosActivosInitializeRow(object sender, InitializeRowEventArgs e)
        {
            var color = e.Row.Cells["Color"].Value.ToString();
            switch (color)
            {
                case "Rojo":
                    e.Row.Cells["Kolor"].Appearance.Image = 1;
                    break;
                case "Amarillo":
                    e.Row.Cells["Kolor"].Appearance.Image = 3;
                    break;
                case "Verde":
                    e.Row.Cells["Kolor"].Appearance.Image = 4;
                    break;
                case "Azul":
                    e.Row.Cells["Kolor"].Appearance.Image = 5;
                    break;
            }
        }

        #endregion

        #region Verificado

        private bool Verificado()
        {
            if ((int) prestacionesResumenUltraGrid.ActiveRow.Cells["Estado"].Value < 6 &&
                (int) prestacionesResumenUltraGrid.ActiveRow.Cells["Estado"].Value > 1)
            {
                MessageBox.Show(
                    "Hay por lo menos un recurso sin finalizar o cancelar.",
                    "No se puede terminar la Prestación", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (prestacionesUltraGrid.Rows[0].Cells["idMotivoDeCancelacion"].Value == DBNull.Value)
            {
                foreach (
                    UltraGridRow paciente in
                    pacientesUltraGrid.DisplayLayout.Bands[0].GetRowEnumerator(GridRowType.DataRow))
                {
                    var nombrePaciente = paciente.Cells["Nombre"].Value.ToString();
                    if (paciente.Cells["idMedico"].Value == DBNull.Value && ultraDataSourceMedicos.Rows.Count > 0)
                        if (ultraDataSourceMedicos.Rows.Count == 1)
                        {
                            paciente.Cells["idMedico"].Value = ultraDataSourceMedicos.Rows[0]["idEmpleado"];
                        }
                        else
                        {
                            MessageBox.Show(
                                "No está consignado qué médico atendió a " +
                                nombrePaciente,
                                "No se puede terminar la Prestación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return false;
                        }

                    //if (paciente.Cells["idTipoDeDocumento"].Value == DBNull.Value)
                    //{
                    //    MessageBox.Show(
                    //        Resources.FormDespacho_Verificado_Falta_el_Tipo_de_Documento_de_ +
                    //        nombrePaciente,
                    //        Resources.FormDespacho_Verificado_No_se_puede_terminar_la_Prestación,
                    //        MessageBoxButtons.OK,
                    //        MessageBoxIcon.Error);
                    //    return false;
                    //}
                    //if (paciente.Cells["NumeroDeDocumento"].Value == DBNull.Value)
                    //{
                    //    MessageBox.Show(
                    //        Resources.FormDespacho_Verificado_Falta_el_Número_de_Documento_de_ +
                    //        nombrePaciente,
                    //        Resources.FormDespacho_Verificado_No_se_puede_terminar_la_Prestación,
                    //        MessageBoxButtons.OK,
                    //        MessageBoxIcon.Error);
                    //    return false;
                    //}
                    if (paciente.ChildBands["FK__Diagnosticos__Pacientes"].Rows.Count > 0 &&
                        paciente.ChildBands["FK__Medicamentos__Pacientes"].Rows.Count > 0)
                    {
                        paciente.Cells["DatosCompletos"].Value = true;
                        paciente.Update();
                    }

                    if (dsParametros.Parametros[0].CerrarPrestacionesSinDiagnostico == false)
                        foreach (UltraGridChildBand dato in paciente.ChildBands)
                        {
                            if (dato.Rows.Count != 0) continue;
                            var mensaje = nombrePaciente + " no tiene ningún ";
                            if (dato.Key == "FK__Medicamentos__Pacientes")
                            {
                                var dr =
                                    MessageBox.Show(
                                        mensaje + "medicamento." + Environment.NewLine +
                                        "¿Se usó alguno?",
                                        "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (dr == DialogResult.Yes) return false;
                            }
                            else
                            {
                                switch (dato.Key)
                                {
                                    case "FK__MotivosPacientes__Pacientes":
                                        mensaje = mensaje + "Motivo de Llamado";
                                        break;
                                    case "FK__Diagnosticos__Pacientes":
                                        mensaje = mensaje + "Diagnóstico";
                                        break;
                                }

                                MessageBox.Show(mensaje,
                                    "No se puede terminar la Prestación",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                                return false;
                            }
                        }
                }

                var destinos = destinosUltraGrid.DisplayLayout.Bands["Destinos"];
                foreach (UltraGridRow destino in destinos.GetRowEnumerator(GridRowType.DataRow))
                foreach (var direccion in destino.ChildBands["FK_Direcciones_Destinos"].Rows)
                    if (direccion.Cells["idLocalidad"].Value != DBNull.Value)
                    {
                        if (direccion.Cells["idCalle"].Value != DBNull.Value &&
                            _fp.dsCallesLista.Calles.FindByidCalle((int) direccion.Cells["idCalle"].Value)
                                .idLocalidad !=
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
                            _fp.dsCallesLista.Calles.FindByidCalle((int) direccion.Cells["idEntreCalle1"].Value)
                                .idLocalidad != (int) direccion.Cells["idLocalidad"].Value)
                        {
                            MessageBox.Show(
                                "La calle " +
                                direccion.Cells["idEntreCalle1"].Text +
                                " no pertenece a " +
                                direccion.Cells["idLocalidad"].Text + ".",
                                "No se pudo grabar", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return false;
                        }

                        if (direccion.Cells["idEntreCalle2"].Value != DBNull.Value &&
                            _fp.dsCallesLista.Calles.FindByidCalle((int) direccion.Cells["idEntreCalle2"].Value)
                                .idLocalidad != (int) direccion.Cells["idLocalidad"].Value)
                        {
                            MessageBox.Show(
                                "La calle " +
                                direccion.Cells["idEntreCalle2"].Text +
                                " no pertenece a " +
                                direccion.Cells["idLocalidad"].Text + ".",
                                "No se pudo grabar", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return false;
                        }

                        if (direccion.Cells["idBarrio"].Value == DBNull.Value ||
                            _fp.dsBarrios.BarriosLista.FindByidBarrio((int) direccion.Cells["idBarrio"].Value)
                                .idLocalidad == (int) direccion.Cells["idLocalidad"].Value) continue;
                        MessageBox.Show(
                            "El barrio " + direccion.Cells["idBarrio"].Text +
                            " no pertenece a " +
                            direccion.Cells["idLocalidad"].Text + ".",
                            "No se pudo grabar", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return false;
                    }

                foreach (DataRow destino in dsDestinos.Destinos.Rows)
                {
                    try
                    {
                        if (
                            dsTiposDeDestino.TiposDeDestino.FindByidTipoDeDestino((int) destino["idTipoDeDestino"])
                                .ConPacienteABordo)
                        {
                            var idDestino = (int) destino["idDestino"];
                            var recursosDelDestino = from d in dsDestinos.DestinosRecursos.AsEnumerable()
                                where d.Field<int>("idDestino") == idDestino
                                select d;

                            foreach (var recurso in recursosDelDestino)
                                try
                                {
                                    if (recurso["idPaciente"] != DBNull.Value ||
                                        recurso["Cancelado"] != DBNull.Value)
                                        continue;
                                    if (dsPacientesPrestacion.Pacientes.Rows.Count == 1)
                                    {
                                        recurso["idPaciente"] =
                                            dsPacientesPrestacion.Pacientes.Rows[0]["IdPaciente"];
                                    }
                                    else
                                    {
                                        MessageBox.Show(
                                            "Hay un móvil con paciente a bordo y" +
                                            Environment.NewLine +
                                            "no está especificado cuál es el paciente.",
                                            "No se puede terminar la Prestación",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return false;
                                    }
                                }
                                catch (DeletedRowInaccessibleException)
                                {
                                }
                        }
                    }
                    catch (InvalidCastException)
                    {
                        MessageBox.Show("Falta el Tipo de Destino.",
                            "Destino incompleto", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return false;
                    }
                    catch (DeletedRowInaccessibleException)
                    {
                    }

                    try
                    {
                        if (destino.GetChildRows("FK_Direcciones_Destinos").Length < 1)
                        {
                            MessageBox.Show("Hay un destino sin dirección.",
                                "No se puede terminar la Prestación",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    catch (DeletedRowInaccessibleException)
                    {
                    }

                    try
                    {
                        if (destino.GetChildRows("FK_DestinosRecursos_Destinos").Length >= 1) continue;
                        MessageBox.Show("Hay un destino sin recurso.",
                            "No se puede terminar la Prestación",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    catch (DeletedRowInaccessibleException)
                    {
                    }
                }
            }

            return true;
        }

        #endregion

        // TAG: O=Operativo M=Monitor V=Ver C=Cambiar(modificar)

        private void PrestacionesResumenUltraGridAfterSortChange(object sender, BandEventArgs e)
        {
            if (e.Band.SortedColumns.Count == 1 && e.Band.SortedColumns.GetItem(0).ToString() == "Estado")
                e.Band.SortedColumns.Add("Jerarquia", false, false);
        }

        private void PacientesUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            if (pacientesUltraGrid.ActiveCell.Column.Key == "Importe") pacientesUltraGrid.ActiveCell.SelectAll();
            ManejoDatos.SeleccionInicio(sender);
        }

        private void DestinosUltraGridBeforeRowInsert(object sender, BeforeRowInsertEventArgs e)
        {
            if (e.Band.Key != "Destinos") return;
            if (prestacionesResumenUltraGrid.Rows.Count == 0)
            {
                e.Cancel = true;
                MessageBox.Show("No hay prestaciones.",
                    "Imposible agregar un Destino",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            if ("OC".Contains(Tag.ToString()))
                dsDestinos.Destinos.idPrestacionColumn.DefaultValue =
                    (int) prestacionesResumenUltraGrid.ActiveRow.Cells["idPrestacion"].Value;
        }

        private void DestinosUltraGridBeforeCellListDropDown(object sender, CancelableCellEventArgs e)
        {
            if (e.Cell.Column.Key != "idRecurso") return;
            GrabarDestinos();
            dsRecursosLista.Clear();
            dsRecursosLista.Merge(new Service().GetRecursosLista(Program.Pin));
        }

        private void PrestacionesResumenUltraGridInitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            e.Layout.Bands[0].SortedColumns.Clear();
            e.Layout.Bands[0].SortedColumns.Add("EsAgendada", false, false);
            e.Layout.Bands[0].SortedColumns.Add("Estado", false, false);
            e.Layout.Bands[0].SortedColumns.Add("Jerarquia", false, false);
            e.Layout.Bands[0].SortedColumns.Add("Agendada", false, false);
        }

        private void PacientesUltraGridCellListSelect(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key != "idMedicamento") return;
            if ((int) ultraDropDownMedicamentos.SelectedRow.Cells["idMedicamento"].Value ==
                (int) _fp.dsSistemas.Sistemas.Rows[0]["SinMedicamentos"])
            {
                e.Cell.Row.Band.MaxRows = 1;
                e.Cell.Row.Cells["Cantidad"].Value = 0;
                e.Cell.Row.Cells["Unidad"].Value = "";
                e.Cell.Row.Cells["Cantidad"].Hidden = true;
                e.Cell.Row.Cells["Unidad"].Hidden = true;
            }

            else
            {
                e.Cell.Row.Band.MaxRows = 100;
                e.Cell.Row.Cells["Cantidad"].Hidden = false;
                e.Cell.Row.Cells["Unidad"].Hidden = false;
            }
        }

        private void UltraDropDownMedicamentosFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = pacientesUltraGrid.ActiveRow.Index == 0
                ? new FilterCondition(e.Row.Band.Columns["idMedicamento"], FilterComparisionOperator.Equals, 0)
                : new FilterCondition(e.Row.Band.Columns["idMedicamento"], FilterComparisionOperator.Equals,
                    (int) _fp.dsSistemas.Sistemas.Rows[0]["SinMedicamentos"]);
            e.RowFilteredOut = e.Row.MeetsCriteria(fc);
        }

        private void PacientesUltraGridBeforeRowInsert(object sender, BeforeRowInsertEventArgs e)
        {
            if (prestacionesResumenUltraGrid.Rows.Count != 0) return;
            e.Cancel = true;
            MessageBox.Show("No hay prestaciones.",
                "Imposible agregar un Paciente.",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void PacientesUltraGridKeyPress(object sender, KeyPressEventArgs e)
        {
            if (pacientesUltraGrid.ActiveCell.Column.Key != "Nombre") return;
            const string caracteres = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz1234567890";
            if (!caracteres.Contains(e.KeyChar.ToString(CultureInfo.InvariantCulture))) return;
            pacientesUltraGrid.ActiveRow.Cells["EsAfiliado"].Value = false;
            pacientesUltraGrid.ActiveRow.Cells["idAfiliado"].Value = DBNull.Value;
            pacientesUltraGrid.ActiveRow.Cells["idCobertura"].Value = DBNull.Value;
        }

        private void ButtonCerrarPrestacionClick(object sender, EventArgs e)
        {
            if (prestacionesResumenUltraGrid.Rows.Count == 0)
            {
                MessageBox.Show("No hay prestaciones.",
                    "Imposible");
                return;
            }

            var idPrestacion = (int) prestacionesUltraGrid.Rows[0].Cells["idPrestacion"].Value;
            var importe = prestacionesUltraGrid.Rows[0].Cells["Importe"].Value.ToString();
            if (!Verificado()) return;
            dsPrestacion.Prestaciones[0].Terminada = true;
            Grabar();
            if (importe == "" ||
                prestacionesUltraGrid.Rows[0].Cells["idMotivoDeCancelacion"].Value != DBNull.Value) return;
            new Service().HacerComprobantePrestacion(
                idPrestacion, Program.Pin);
            var f = new FormRemesaPrestacion
            {
                IdPrestacion = idPrestacion,
                Text =
                    "Rendición: " +
                    dsPrestacionesResumen.PrestacionesResumen.FindByidPrestacion(
                        idPrestacion).Nombre + " - " +
                    dsPrestacionesResumen.PrestacionesResumen.FindByidPrestacion(
                        idPrestacion).Direccion,
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0)
            };
            f.Show();
        }

        private void PrestacionesResumenUltraGridMouseEnter(object sender, EventArgs e)
        {
            _parada =
                prestacionesResumenUltraGrid.Rows.Count >
                prestacionesResumenUltraGrid.ActiveRowScrollRegion.VisibleRows.Count
                    ? dsParametros.Parametros[0].RefrescoPrestacionesMouse
                    : dsParametros.Parametros[0].RefrescoPrestaciones;
        }

        private void PrestacionesResumenUltraGridMouseLeave(object sender, EventArgs e)
        {
            _parada = dsParametros.Parametros[0].RefrescoPrestaciones;
        }

        private void DestinosUltraGridAfterRowInsert(object sender, RowEventArgs e)
        {
            if (e.Row.Band.Key == "Destinos")
                e.Row.Cells["Orden"].Value = destinosUltraGrid.Rows.Count;
        }

        private void prestacionesResumenUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                prestacionesResumenUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void destinosUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                destinosUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void pacientesUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                pacientesUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void destinosUltraGrid_AfterEnterEditMode(object sender, EventArgs e)
        {
            ManejoDatos.SeleccionInicio(sender);
        }

        private void prestacionesUltraGrid_AfterEnterEditMode(object sender, EventArgs e)
        {
            ManejoDatos.SeleccionInicio(sender);
        }

        #region Propiedades del formulario

        private FormPrincipalCabina _fp;
        private int _parada = 3;

        public FormDespacho()
        {
            InitializeComponent();
        }

        public string Proceso { private get; set; }

        #endregion

        #region Load y Activate del formulario

        private void FormDespachoLoad(object sender, EventArgs e)
        {
            /*Que el documento por default sea DNI*/
            pacientesUltraGrid.DisplayLayout.Bands["Pacientes"].Columns["idTipoDeDocumento"].DefaultCellValue =
                new Service().DefaultDNI(Program.Pin);
            ultraComboVerAgendadas.Value = "todas";
            /*Tomo datos del padre*/
            TomoLosDatosDelPadre();

            if (Tag.ToString() == "M")
            {
                Text = "Monitor de Prestaciones";
                buttonCerrarPrestacion.Visible = false;
            }

            if (Tag.ToString() == "V")
            {
                Text = "Visor de Prestaciones";
                buttonCerrarPrestacion.Visible = false;
            }

            SiEsModificar();
            if ("VC".Contains(Tag.ToString()))
                dsPrestacionesResumen.Merge(new Service().GetPrestacionesAModificar(Proceso,
                    Program.Pin));
            if ("VM".Contains(Tag.ToString()))
            {
                buttonAceptar.Visible = false;
                buttonAgregarPaciente.Visible = false;
                foreach (var banda in prestacionesUltraGrid.DisplayLayout.Bands)
                foreach (var columna in banda.Columns)
                {
                    if (columna.Key == "Imprimir") continue;
                    columna.Style = ColumnStyle.Edit;
                    columna.CellActivation = Activation.NoEdit;
                }

                foreach (var banda in destinosUltraGrid.DisplayLayout.Bands)
                {
                    banda.Override.AllowAddNew = AllowAddNew.No;
                    foreach (var columna in banda.Columns)
                    {
                        columna.Style = ColumnStyle.Edit;
                        columna.CellActivation = Activation.NoEdit;
                    }
                }

                foreach (var banda in pacientesUltraGrid.DisplayLayout.Bands)
                {
                    banda.Override.AllowAddNew = AllowAddNew.No;
                    foreach (var columna in banda.Columns)
                    {
                        columna.Style = ColumnStyle.Edit;
                        columna.CellActivation = Activation.NoEdit;
                    }
                }

                destinosUltraGrid.DisplayLayout.Override.AllowDelete = DefaultableBoolean.False;
                pacientesUltraGrid.DisplayLayout.Override.AllowDelete = DefaultableBoolean.False;
            }

            dsSistemas1.Merge(new Service().GetSistemas(Program.Pin));

            /*Llena el combo Edad en*/
            pacientesUltraGrid.DisplayLayout.ValueLists.Add("EdadEn");
            pacientesUltraGrid.DisplayLayout.ValueLists["EdadEn"].ValueListItems.Add("A", "años");
            pacientesUltraGrid.DisplayLayout.ValueLists["EdadEn"].ValueListItems.Add("M", "meses");
            pacientesUltraGrid.DisplayLayout.ValueLists["EdadEn"].ValueListItems.Add("D", "días");
            pacientesUltraGrid.DisplayLayout.Bands["Pacientes"].Columns["EdadEn"].ValueList =
                pacientesUltraGrid.DisplayLayout.ValueLists["EdadEn"];

            /*Llena el combo Sexo*/
            pacientesUltraGrid.DisplayLayout.ValueLists.Add("Sexo");
            pacientesUltraGrid.DisplayLayout.ValueLists["Sexo"].ValueListItems.Add("M", "M");
            pacientesUltraGrid.DisplayLayout.ValueLists["Sexo"].ValueListItems.Add("F", "F");
            pacientesUltraGrid.DisplayLayout.ValueLists["Sexo"].ValueListItems.Add(" ", "");
            pacientesUltraGrid.DisplayLayout.Bands["Pacientes"].Columns["Sexo"].ValueList =
                pacientesUltraGrid.DisplayLayout.ValueLists["Sexo"];

            /*Conecta el Grid*/
            pacientesUltraGrid.DataBind();

            if (!"OM".Contains(Tag.ToString())) return;
            //Inicia el thread de actualización
            ActualizadorDeDatosDlg actualizadorDeDatosDlg = ActualizadorDeDatos;
            var thActualizacion = new Thread(new ThreadStart(actualizadorDeDatosDlg))
            {
                Name = "ActualizadorDeDatos",
                IsBackground = true
            };
            thActualizacion.Start();
        }

        private void SiEsModificar()
        {
            if (Tag.ToString() == "C")
            {
                Text = "Modificar Prestaciones";
                buttonCerrarPrestacion.Visible = false;
                prestacionesUltraGrid.DisplayLayout.Bands[0].Columns["idTomador"].Style = ColumnStyle.Default;
                prestacionesUltraGrid.DisplayLayout.Bands[0].Columns["idTomador"].CellActivation = Activation.AllowEdit;
                prestacionesUltraGrid.DisplayLayout.Bands[0].Columns["Tomada"].Style =
                    ColumnStyle.DateTimeWithoutDropDown;
                prestacionesUltraGrid.DisplayLayout.Bands[0].Columns["Tomada"].MaskInput = "dd/mm/yyyy hh:mm:ss";
                prestacionesUltraGrid.DisplayLayout.Bands[0].Columns["Tomada"].CellActivation = Activation.AllowEdit;
                destinosUltraGrid.DisplayLayout.Bands["FK_DestinosRecursos_Destinos"].Columns["Asignado"].Style =
                    ColumnStyle.DateTimeWithoutDropDown;
                destinosUltraGrid.DisplayLayout.Bands["FK_DestinosRecursos_Destinos"].Columns["Asignado"].MaskInput =
                    "dd/mm/yyyy hh:mm:ss";
                destinosUltraGrid.DisplayLayout.Bands["FK_DestinosRecursos_Destinos"].Columns["Asignado"].CellActivation
                    = Activation.AllowEdit;
                destinosUltraGrid.DisplayLayout.Bands["FK_DestinosRecursos_Destinos"].Columns["Salida"].Style =
                    ColumnStyle.DateTimeWithoutDropDown;
                destinosUltraGrid.DisplayLayout.Bands["FK_DestinosRecursos_Destinos"].Columns["Salida"].MaskInput =
                    "dd/mm/yyyy hh:mm:ss";
                destinosUltraGrid.DisplayLayout.Bands["FK_DestinosRecursos_Destinos"].Columns["Salida"].CellActivation =
                    Activation.AllowEdit;
                destinosUltraGrid.DisplayLayout.Bands["FK_DestinosRecursos_Destinos"].Columns["Llegada"].Style =
                    ColumnStyle.DateTimeWithoutDropDown;
                destinosUltraGrid.DisplayLayout.Bands["FK_DestinosRecursos_Destinos"].Columns["Llegada"].MaskInput =
                    "dd/mm/yyyy hh:mm:ss";
                destinosUltraGrid.DisplayLayout.Bands["FK_DestinosRecursos_Destinos"].Columns["Llegada"].CellActivation
                    = Activation.AllowEdit;
                destinosUltraGrid.DisplayLayout.Bands["FK_DestinosRecursos_Destinos"].Columns["Terminado"].Style =
                    ColumnStyle.DateTimeWithoutDropDown;
                destinosUltraGrid.DisplayLayout.Bands["FK_DestinosRecursos_Destinos"].Columns["Terminado"].MaskInput =
                    "dd/mm/yyyy hh:mm:ss";
                destinosUltraGrid.DisplayLayout.Bands["FK_DestinosRecursos_Destinos"].Columns["Terminado"]
                    .CellActivation = Activation.AllowEdit;
                destinosUltraGrid.DisplayLayout.Bands["FK_DestinosRecursos_Destinos"].Columns["Cancelado"].Style =
                    ColumnStyle.DateTimeWithoutDropDown;
                destinosUltraGrid.DisplayLayout.Bands["FK_DestinosRecursos_Destinos"].Columns["Cancelado"].MaskInput =
                    "dd/mm/yyyy hh:mm:ss";
                destinosUltraGrid.DisplayLayout.Bands["FK_DestinosRecursos_Destinos"].Columns["Cancelado"]
                    .CellActivation = Activation.AllowEdit;
                destinosUltraGrid.DisplayLayout.Bands["FK_DestinosRecursos_Destinos"].Columns["idDespachador"].Style =
                    ColumnStyle.Default;
                destinosUltraGrid.DisplayLayout.Bands["FK_DestinosRecursos_Destinos"].Columns["idDespachador"]
                    .CellActivation = Activation.AllowEdit;
            }
        }

        private void TomoLosDatosDelPadre()
        {
            _fp = (FormPrincipalCabina) MdiParent;
            callesBindingSource.DataSource = _fp.dsCallesLista;
            motivosDeLlamadoBindingSource.DataSource = _fp.dsMotivosDeLlamado;
            prepagosBindingSource.DataSource = _fp.dsPrepagos;
            localidadesBindingSource.DataSource = _fp.dsLocalidades1;
            contratosBindingSource.DataSource = _fp.dsContratosLista;
            barriosListaBindingSource.DataSource = _fp.dsBarrios;
            codigosBindingSource.DataSource = _fp.dsCodigos;
            coberturasBindingSource.DataSource = _fp.dsCoberturas;
            practicasBindingSource.DataSource = _fp.dsPracticas;
            tiposDeDestinoBindingSource.DataSource = _fp.dsTiposDeDestino;
            motivosDeCancelacionPrestacionBindingSource.DataSource = _fp.dsMotivosDeCancelacionPrestacion;
            medicamentosBindingSource.DataSource = _fp.dsMedicamentos;
            diagnosticosBindingSource.DataSource = _fp.dsDiagnosticos;
            lugaresBindingSource.DataSource = _fp.dsLugares;
            tiposDeDocumentoBindingSource.DataSource = _fp.dsTiposDeDocumento;
            dsParametros.Merge(new Service().GetParametros(Program.Pin));
        }

        private void FormDespachoActivated(object sender, EventArgs e)
        {
            // Llena los combos.
            dsRecursosLista.Merge(new Service().GetRecursosLista(Program.Pin));
            dsTiposDeDestino.Merge(new Service().GetTiposDeDestino(Program.Pin));
            dsContratosLista.Merge(new Service().GetContratosListaNoBaja(Program.Pin));
            dsUsuariosLista.Merge(new Service().GetUsuariosLista(Program.Pin));
            dsMedicos.Merge(new Service().GetMedicos(Program.Pin));
        }

        #endregion

        #region ThreadActualizadorDeDatos

        private void ActualizadorDeDatos()
        {
            while (true)
                try
                {
                    var auxi = new Service().GetPrestacionesResumen(ultraComboVerAgendadas.Value.ToString(),
                        Program.Pin);
                    ActualizarDatos(auxi);
                    if (dsPrestacionesResumen.PrestacionesResumen.Rows.Count != 0) continue;
                    dsPrestacion.Clear();
                    dsDestinos.Clear();
                    dsPacientesPrestacion.Clear();
                }
                catch (NullReferenceException)
                {
                }
                finally
                {
                    Thread.Sleep(_parada * 1000);
                }
            // Este bucle no tiene salida porque oficia de timer. Está bien aunque R# diga que no.

// ReSharper disable FunctionNeverReturns
        }

// ReSharper restore FunctionNeverReturns

        private void ActualizarDatos(DsPrestacionesResumen data)
        {
            //Si no estoy en el thread principal del form me llamo desde él mismo.
            if (InvokeRequired)
            {
                Invoke(new ActualizarDatosDlg(ActualizarDatos), data);
                return;
            }
            //Actualiza la pantalla con los nuevos datos

            var lista = new ArrayList();
            dsPrestacionesResumen.Merge(data);
            foreach (DsPrestacionesResumen.PrestacionesResumenRow row in dsPrestacionesResumen.PrestacionesResumen
            )
                if (data.PrestacionesResumen.FindByidPrestacion(row.idPrestacion) == null)
                    lista.Add(row);
            foreach (DataRow row in lista) row.Delete();
            dsPrestacionesResumen.AcceptChanges();
            var novistos =
                dsPrestacionesResumen.PrestacionesResumen
                    .Select("Estado = 0 AND isnull(Agendada,#01/21/1947#) = #01/21/1947#").Length;
            var nosalio =
                dsPrestacionesResumen.PrestacionesResumen
                    .Select("Estado < 3 AND isnull(Agendada,#01/21/1947#) = #01/21/1947#").Length;
            if (prestacionesResumenUltraGrid.Rows != null)
            {
                prestacionesResumenUltraGrid.BeginUpdate();
                foreach (var renglon in prestacionesResumenUltraGrid.Rows)
                {
                    renglon.Cells["Estado"].Appearance.Image = (int) renglon.Cells["Estado"].Value;
                    renglon.Cells["Jerarquia"].Appearance.Image = (short) renglon.Cells["Jerarquia"].Value;
                }

                prestacionesResumenUltraGrid.EndUpdate();
            }

            panelEstadoGeneral.BackColor = novistos > 0 ? Color.Red : (nosalio > 0 ? Color.Yellow : Color.Green);
            if (prestacionesResumenUltraGrid.DisplayLayout != null)
                prestacionesResumenUltraGrid.DisplayLayout.Bands[0].SortedColumns.RefreshSort(false);
        }

        #region Nested type: ActualizadorDeDatosDlg

        private delegate void ActualizadorDeDatosDlg();

        #endregion

        #region Nested type: ActualizarDatosDlg

        private delegate void ActualizarDatosDlg(DsPrestacionesResumen data);

        #endregion

        #endregion

        #region Eventos prestacionesResumenUltraGrid

        private void PrestacionesResumenUltraGridAfterRowActivate(object sender, EventArgs e)
        {
            if ("OC".Contains(Tag.ToString())) Grabar();
            prestacionesUltraGrid.BeginUpdate();
            prestacionesUltraGrid.SuspendRowSynchronization();
            destinosUltraGrid.BeginUpdate();
            destinosUltraGrid.SuspendRowSynchronization();
            pacientesUltraGrid.BeginUpdate();
            pacientesUltraGrid.SuspendRowSynchronization();
            dsPrestacion.Clear();
            dsDestinos.Clear();
            dsPacientesPrestacion.Clear();
            dsPrestacion.Merge(
                new Service().GetPrestacion(
                    (int) prestacionesResumenUltraGrid.ActiveRow.Cells["idPrestacion"].Value, Program.Pin));
            dsDestinos.Merge(
                new Service().GetDestinos(
                    (int) prestacionesResumenUltraGrid.ActiveRow.Cells["idPrestacion"].Value, Program.Pin));
            dsPacientesPrestacion.Merge(
                new Service().GetPacientes(
                    (int) prestacionesResumenUltraGrid.ActiveRow.Cells["idPrestacion"].Value, Program.Pin));
            prestacionesUltraGrid.ResumeRowSynchronization();
            prestacionesUltraGrid.EndUpdate();
            destinosUltraGrid.ResumeRowSynchronization();
            destinosUltraGrid.EndUpdate();
            pacientesUltraGrid.ResumeRowSynchronization();
            pacientesUltraGrid.EndUpdate();
            destinosUltraGrid.Rows.ExpandAll(true);
            pacientesUltraGrid.Rows.ExpandAll(true);


            if (destinosUltraGrid.Rows.Count > 1)
            {
                destinosUltraGrid.DisplayLayout.Bands[0].Header.Appearance.BackColor = Color.Red;
                destinosUltraGrid.DisplayLayout.Bands[0].Header.Caption =
                    "Destino (Hay " +
                    destinosUltraGrid.Rows.Count + ")";
                destinosUltraGrid.DisplayLayout.Bands[0].Columns["Orden"].Hidden = false;
            }
            else
            {
                destinosUltraGrid.DisplayLayout.Bands[0].Header.Appearance.BackColor = SystemColors.ActiveCaption;
                destinosUltraGrid.DisplayLayout.Bands[0].Header.Caption =
                    "Destino";
                destinosUltraGrid.DisplayLayout.Bands[0].Columns["Orden"].Hidden = true;
            }

            buttonAceptar.Visible = prestacionesResumenUltraGrid.Rows.Count == 1;
            //foreach(var destino in destinosUltraGrid.Rows)
            //{
            //    if (destino.ChildBands[1].Rows.Count > 1)
            //    {
            //        destino.ChildBands[1].Band.Header.Appearance.BackColor = Color.Red;
            //        destino.ChildBands[1].Rows.Band.Header.Caption = "Recurso (Hay " + destino.ChildBands[1].Rows.Count + ")";
            //    }
            //    else
            //    {
            //        destino.ChildBands[1].Band.Header.Appearance.BackColor = SystemColors.ActiveCaption;
            //        destino.ChildBands[1].Band.Header.Caption = "Recurso";
            //    }
            //}
            if (pacientesUltraGrid.Rows.Count > 1)
            {
                pacientesUltraGrid.DisplayLayout.Bands[0].Header.Appearance.BackColor = Color.Red;
                pacientesUltraGrid.DisplayLayout.Bands[0].Header.Caption =
                    "Paciente (Hay " +
                    pacientesUltraGrid.Rows.Count + ")";
            }
            else
            {
                pacientesUltraGrid.DisplayLayout.Bands[0].Header.Appearance.BackColor = SystemColors.ActiveCaption;
                pacientesUltraGrid.DisplayLayout.Bands[0].Header.Caption =
                    "Paciente";
            }
        }

        private void PrestacionesResumenUltraGridMouseUp(object sender, MouseEventArgs e)
        {
            if (Tag.ToString() != "O") return;
            // Declare and retrieves a reference to the UIElement
            var aUiElement =
                prestacionesResumenUltraGrid.DisplayLayout.UIElement.ElementFromPoint(new Point(e.X, e.Y));

            // Declare and retrieve a reference to the row
            var aRow = (UltraGridRow) aUiElement.GetContext(typeof(UltraGridRow));
            // If a row was found display the band and row index
            if (aRow == null || (int) aRow.Cells["Estado"].Value != 0) return;
            new Service().MarcarPrestacionComoVista(
                (int) prestacionesResumenUltraGrid.ActiveRow.Cells["idPrestacion"].Value, Program.Pin);
            dsPrestacion.Merge(
                new Service().GetPrestacion(
                    (int) prestacionesResumenUltraGrid.ActiveRow.Cells["idPrestacion"].Value, Program.Pin));
        }

        #endregion

        #region Eventos prestacionesUltraGrid

        private void PrestacionesUltraGridAfterCellListCloseUp(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key != "idMotivoDeCancelacion") return;
            if ((int) prestacionesResumenUltraGrid.ActiveRow.Cells["Estado"].Value < 4) return;
            MessageBox.Show(
                "Las prestaciones sólo se pueden cancelar antes de llegar al lugar.",
                "No se puede cancelar la prestación",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.Cell.CancelUpdate();
        }

        private void PrestacionesUltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            e.Row.Cells["Imprimir"].Value = "Imprimir";
        }

        private void PrestacionesUltraGridClickCellButton(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key != "Imprimir") return;
            var f = new FormRepImprimirPrestacion
            {
                IdPrestacion = (int) prestacionesUltraGrid.ActiveRow.Cells["idPrestacion"].Value,
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0)
            };
            f.Show();
        }

        private void PrestacionesUltraGridAfterCellActivate(object sender, EventArgs e)
        {
            if (prestacionesUltraGrid.ActiveCell.Column.Key == "idMotivoDeCancelacion")
                prestacionesUltraGrid.ActiveCell.DroppedDown = true;
        }

        #endregion

        #region Eventos destinosUltraGrid

        private void DestinosUltraGridAfterCellActivate(object sender, EventArgs e)
        {
            var hayQueGrabar = false;
            if (destinosUltraGrid.ActiveRow.Band.Key == "FK_DestinosRecursos_Destinos")
            {
                if ("O".Contains(Tag.ToString()))
                {
                    // Pone o saca la hora de los eventos.
                    var columna = destinosUltraGrid.ActiveCell.Column.Key;
                    var celdaActiva = destinosUltraGrid.ActiveCell;
                    var renglonActivo = destinosUltraGrid.ActiveRow;
                    if (columna == "Asignado" || columna == "Salida" || columna == "Llegada" ||
                        columna == "Terminado" ||
                        columna == "Cancelado")
                    {
                        hayQueGrabar = true;
                        if (celdaActiva.Value == DBNull.Value)
                        {
                            celdaActiva.Value = new Service().HoraActual(Program.Pin);
                            if (columna == "Asignado")
                            {
                                renglonActivo.Cells["Salida"].Hidden = false;
                                renglonActivo.Cells["Cancelado"].Hidden = false;
                                destinosUltraGrid.ActiveRow.Cells["idRecurso"].Style = ColumnStyle.Edit;
                                destinosUltraGrid.ActiveRow.Cells["idRecurso"].Activation = Activation.NoEdit;
                                MostrarPlanilla();
                            }

                            if (columna == "Salida")
                            {
                                renglonActivo.Cells["Asignado"].Activation = Activation.Disabled;
                                if (renglonActivo.Cells["Salida"].Value != DBNull.Value)
                                    renglonActivo.Cells["Llegada"].Hidden = false;
                            }

                            if (columna == "Llegada")
                            {
                                renglonActivo.Cells["Salida"].Activation = Activation.Disabled;
                                renglonActivo.Cells["Terminado"].Hidden = false;
                                renglonActivo.Cells["Cancelado"].Hidden = true;
                                ActualizarMedicosActuantes();
                            }

                            if (columna == "Terminado") renglonActivo.Cells["Llegada"].Activation = Activation.Disabled;
                            if (columna == "Cancelado")
                            {
                                renglonActivo.Cells["Asignado"].Activation = Activation.Disabled;
                                if (renglonActivo.Cells["Salida"].Value == DBNull.Value)
                                    renglonActivo.Cells["Salida"].Hidden = true;
                                else
                                    renglonActivo.Cells["Salida"].Activation = Activation.Disabled;
                                renglonActivo.Cells["Llegada"].Hidden = true;
                                renglonActivo.Cells["Terminado"].Hidden = true;
                                renglonActivo.Update();
                                ActualizarMedicosActuantes();
                            }
                        }
                        else // La celda activa tenía hora, se la sacamos.
                        {
                            SacarLaHora(celdaActiva, columna, renglonActivo);
                        }
                    }
                }

                if ("OC".Contains(Tag.ToString()) && destinosUltraGrid.ActiveCell.Column.Key == "Salida")
                {
                    hayQueGrabar = true;
                    // Copia todos los integrantes del Recurso
                    if (destinosUltraGrid.ActiveCell.Value == DBNull.Value)
                    {
                        destinosUltraGrid.ActiveRow.Cells["idMovil"].Value = DBNull.Value;
                        destinosUltraGrid.ActiveRow.Cells["idMedico1"].Value = DBNull.Value;
                        destinosUltraGrid.ActiveRow.Cells["idMedico2"].Value = DBNull.Value;
                        destinosUltraGrid.ActiveRow.Cells["idParamedico1"].Value = DBNull.Value;
                        destinosUltraGrid.ActiveRow.Cells["idParamedico2"].Value = DBNull.Value;
                        destinosUltraGrid.ActiveRow.Cells["idChofer1"].Value = DBNull.Value;
                        destinosUltraGrid.ActiveRow.Cells["idChofer2"].Value = DBNull.Value;
                    }
                    else
                    {
                        // Si el recurso tiene móvil graba el móvil, si el recurso tiene médico graba el médico, etc.
                        if (dsRecursosLista.RecursosLista.AsEnumerable().Where(c => c.Field<int>("idRecurso") ==
                                                                                    (int)
                                                                                    destinosUltraGrid.ActiveRow.Cells[
                                                                                        "idRecurso"].Value &&
                                                                                    !c.IsNull("idMovil")).Count() ==
                            1)
                            destinosUltraGrid.ActiveRow.Cells["idMovil"].Value =
                                dsRecursosLista.RecursosLista.FindByidRecurso(
                                    (int) destinosUltraGrid.ActiveRow.Cells["idRecurso"].Value).idMovil;

                        if (dsRecursosLista.RecursosLista.AsEnumerable().Where(c => c.Field<int>("idRecurso") ==
                                                                                    (int)
                                                                                    destinosUltraGrid.ActiveRow.Cells[
                                                                                        "idRecurso"].Value &&
                                                                                    !c.IsNull("idMedico")).Count() ==
                            1)
                            destinosUltraGrid.ActiveRow.Cells["idMedico1"].Value =
                                dsRecursosLista.RecursosLista.FindByidRecurso(
                                    (int) destinosUltraGrid.ActiveRow.Cells["idRecurso"].Value).idMedico;

                        if (dsRecursosLista.RecursosLista.AsEnumerable().Where(c => c.Field<int>("idRecurso") ==
                                                                                    (int)
                                                                                    destinosUltraGrid.ActiveRow.Cells[
                                                                                        "idRecurso"].Value &&
                                                                                    !c.IsNull("idMedico2")).Count() ==
                            1)
                            destinosUltraGrid.ActiveRow.Cells["idMedico2"].Value =
                                dsRecursosLista.RecursosLista.FindByidRecurso(
                                    (int) destinosUltraGrid.ActiveRow.Cells["idRecurso"].Value).idMedico2;

                        if (dsRecursosLista.RecursosLista.AsEnumerable().Where(c => c.Field<int>("idRecurso") ==
                                                                                    (int)
                                                                                    destinosUltraGrid.ActiveRow.Cells[
                                                                                        "idRecurso"].Value &&
                                                                                    !c.IsNull("idParamedico"))
                                .Count() ==
                            1)
                            destinosUltraGrid.ActiveRow.Cells["idParamedico1"].Value =
                                dsRecursosLista.RecursosLista.FindByidRecurso(
                                    (int) destinosUltraGrid.ActiveRow.Cells["idRecurso"].Value).idParamedico;

                        if (dsRecursosLista.RecursosLista.AsEnumerable().Where(c => c.Field<int>("idRecurso") ==
                                                                                    (int)
                                                                                    destinosUltraGrid.ActiveRow.Cells[
                                                                                        "idRecurso"].Value &&
                                                                                    !c.IsNull("idParamedico2")).Count
                                () == 1)
                            destinosUltraGrid.ActiveRow.Cells["idParamedico2"].Value =
                                dsRecursosLista.RecursosLista.FindByidRecurso(
                                    (int) destinosUltraGrid.ActiveRow.Cells["idRecurso"].Value).idParamedico2;

                        if (dsRecursosLista.RecursosLista.AsEnumerable().Where(c => c.Field<int>("idRecurso") ==
                                                                                    (int)
                                                                                    destinosUltraGrid.ActiveRow.Cells[
                                                                                        "idRecurso"].Value &&
                                                                                    !c.IsNull("idChofer")).Count() ==
                            1)
                            destinosUltraGrid.ActiveRow.Cells["idChofer1"].Value =
                                dsRecursosLista.RecursosLista.FindByidRecurso(
                                    (int) destinosUltraGrid.ActiveRow.Cells["idRecurso"].Value).idChofer;

                        if (dsRecursosLista.RecursosLista.AsEnumerable().Where(c => c.Field<int>("idRecurso") ==
                                                                                    (int)
                                                                                    destinosUltraGrid.ActiveRow.Cells[
                                                                                        "idRecurso"].Value &&
                                                                                    !c.IsNull("idChofer2")).Count() ==
                            1)
                            destinosUltraGrid.ActiveRow.Cells["idChofer2"].Value =
                                dsRecursosLista.RecursosLista.FindByidRecurso(
                                    (int) destinosUltraGrid.ActiveRow.Cells["idRecurso"].Value).idChofer2;
                    }
                }
            }

            if (!hayQueGrabar) return;
            destinosUltraGrid.UpdateData(); //Antes de grabar bajamos al dataset toda la información de la grilla
            GrabarDestinos();
        }

        private void SacarLaHora(UltraGridCell celdaActiva, string columna, UltraGridRow renglonActivo)
        {
            var dr =
                MessageBox.Show(
                    "¿Es cierto que quiere borrar este horario?" +
                    Environment.NewLine +
                    Environment.NewLine +
                    "El horario registrado se perderá en forma irreversible." +
                    Environment.NewLine + Environment.NewLine +
                    "El campo quedará vacío esperando un NUEVO horario.",
                    "¡Atención!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                celdaActiva.Value = DBNull.Value;
                if (columna == "Asignado")
                {
                    renglonActivo.Cells["Salida"].Hidden = true;
                    renglonActivo.Cells["Cancelado"].Hidden = true;
                    destinosUltraGrid.ActiveRow.Cells["idRecurso"].Style = ColumnStyle.Default;
                    destinosUltraGrid.ActiveRow.Cells["idRecurso"].Activation = Activation.AllowEdit;
                }

                if (columna == "Salida")
                {
                    renglonActivo.Cells["Asignado"].Activation = Activation.NoEdit;
                    renglonActivo.Cells["Llegada"].Hidden = true;
                    ActualizarMedicosActuantes();
                }

                if (columna == "Llegada")
                {
                    renglonActivo.Cells["Salida"].Activation = Activation.NoEdit;
                    renglonActivo.Cells["Terminado"].Hidden = true;
                    renglonActivo.Cells["Cancelado"].Hidden = false;
                }

                if (columna == "Terminado") renglonActivo.Cells["Llegada"].Activation = Activation.NoEdit;
                if (columna == "Cancelado")
                {
                    renglonActivo.Cells["Terminado"].Hidden = true;

                    if (renglonActivo.Cells["Salida"].Value == DBNull.Value)
                    {
                        renglonActivo.Cells["Salida"].Hidden = false;
                        renglonActivo.Cells["Asignado"].Activation = Activation.NoEdit;
                    }
                    else
                    {
                        renglonActivo.Cells["Llegada"].Hidden = false;
                        renglonActivo.Cells["Salida"].Activation = Activation.NoEdit;
                    }

                    renglonActivo.Update();
                    ActualizarMedicosActuantes();
                }
            }
        }

        private void MostrarPlanilla()
        {
            if (Settings.Default.Empresa == "AYMED")
            {
                string medico;
                try
                {
                    medico = dsMedicos.EmpleadosLista.FindByidEmpleado(
                        dsRecursosLista.RecursosLista.FindByidRecurso(
                            (int) destinosUltraGrid.ActiveRow.Cells["idRecurso"].Value).idMedico).NombApel;
                }
                catch (Exception)
                {
                    medico = "";
                }

                var frmInformeAsistencia = new FormRepInformeAsistencia
                {
                    Fecha =
                        (DateTime) prestacionesUltraGrid.Rows[0].Cells["Tomada"].Value,
                    Prestacion =
                        Convert.ToInt32(
                            prestacionesUltraGrid.Rows[0].Cells["Numero"].Value.ToString()),
                    Movil =
                        destinosUltraGrid.ActiveRow.Cells["idRecurso"].Text,
                    Medico = medico,
                    Paciente =
                        pacientesUltraGrid.Rows[0].Cells["Nombre"].Value.ToString(),
                    Socio =
                        (pacientesUltraGrid.Rows[0].Cells["IdPrepago"].Text.Length == 0
                            ? ""
                            : pacientesUltraGrid.Rows[0].Cells["IdPrepago"].Text) +
                        (pacientesUltraGrid.Rows[0].Cells["NroAfiliadoPrepago"].Text.Length == 0
                            ? ""
                            : " - " +
                              pacientesUltraGrid.Rows[0].Cells["NroAfiliadoPrepago"].Text),
                    Edad =
                        (pacientesUltraGrid.Rows[0].Cells["Edad"].Text.Length == 0
                            ? ""
                            : pacientesUltraGrid.Rows[0].Cells["Edad"].Text).Replace(" ", "") +
                        (pacientesUltraGrid.Rows[0].Cells["EdadEn"].Text.Length == 0
                            ? ""
                            : " " + pacientesUltraGrid.Rows[0].Cells["EdadEn"].Text),
                    Domicilio =
                        new Service().DireccionCompletaDelDestino(
                            (int) destinosUltraGrid.ActiveRow.Cells["idDestino"].Value,
                            Program.Pin),
                    Telefono = prestacionesUltraGrid.Rows[0].Cells["Telefono"].Text,
                    Antecedentes = pacientesUltraGrid.Rows[0].Cells["Antecedentes"].Text,
                    Motivos =
                        new Service().MotivosDelPaciente(
                            (int) pacientesUltraGrid.Rows[0].Cells["idPaciente"].Value,
                            Program.Pin)
                };
                frmInformeAsistencia.ShowDialog(this);
            }
        }

        private void DestinosUltraGridAfterCellListCloseUp(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key == "idLugar" && "OC".Contains(Tag.ToString()))
            {
                e.Cell.Row.Update();
                if (e.Cell.Row.HasChild() == false) e.Cell.Row.ChildBands[0].Band.AddNew();
                // Copia la dirección del Lugar
                dsDireccionLugar1.Clear();
                try
                {
                    dsDireccionLugar1.Merge(new Service().GetDireccionLugar((int) e.Cell.Value,
                        Program.Pin));
                }
                catch (InvalidCastException)
                {
                }

                if (dsDireccionLugar1.DireccionLugar.Rows.Count > 0)
                {
                    e.Cell.Row.ChildBands["FK_Direcciones_Destinos"].Rows[0].Cells["idLocalidad"].Value =
                        dsDireccionLugar1.DireccionLugar.Rows[0]["idLocalidad"];
                    e.Cell.Row.ChildBands["FK_Direcciones_Destinos"].Rows[0].Cells["idCalle"].Value =
                        dsDireccionLugar1.DireccionLugar.Rows[0]["idCalle"];
                    e.Cell.Row.ChildBands["FK_Direcciones_Destinos"].Rows[0].Cells["Numero"].Value =
                        dsDireccionLugar1.DireccionLugar.Rows[0]["Numero"];
                    e.Cell.Row.ChildBands["FK_Direcciones_Destinos"].Rows[0].Cells["Piso"].Value =
                        dsDireccionLugar1.DireccionLugar.Rows[0]["Piso"];
                    e.Cell.Row.ChildBands["FK_Direcciones_Destinos"].Rows[0].Cells["Departamento"].Value =
                        dsDireccionLugar1.DireccionLugar.Rows[0]["Departamento"];
                    e.Cell.Row.ChildBands["FK_Direcciones_Destinos"].Rows[0].Cells["idBarrio"].Value =
                        dsDireccionLugar1.DireccionLugar.Rows[0]["idBarrio"];
                    e.Cell.Row.ChildBands["FK_Direcciones_Destinos"].Rows[0].Cells["idEntreCalle1"].Value =
                        dsDireccionLugar1.DireccionLugar.Rows[0]["idEntreCalle1"];
                    e.Cell.Row.ChildBands["FK_Direcciones_Destinos"].Rows[0].Cells["idEntreCalle2"].Value =
                        dsDireccionLugar1.DireccionLugar.Rows[0]["idEntreCalle2"];
                    e.Cell.Row.ChildBands["FK_Direcciones_Destinos"].Rows[0].Cells["Observaciones"].Value =
                        dsDireccionLugar1.DireccionLugar.Rows[0]["Observaciones"];
                }
            }

            if (e.Cell.Column.Key == "idRecurso" && "OC".Contains(Tag.ToString()))
                new Service().MarcarPrestacionComoVista(
                    (int) prestacionesResumenUltraGrid.ActiveRow.Cells["idPrestacion"].Value, Program.Pin);
        }

        private void DestinosUltraGridAfterRowActivate(object sender, EventArgs e)
        {
            if (destinosUltraGrid.ActiveRow.Band.Key == "FK_DestinosRecursos_Destinos" &&
                destinosUltraGrid.ActiveRow.Cells["idRecurso"].Value == DBNull.Value)
                destinosUltraGrid.DisplayLayout.Bands["FK_DestinosRecursos_Destinos"].Override.AllowDelete =
                    DefaultableBoolean.True;
            else
                destinosUltraGrid.DisplayLayout.Bands["FK_DestinosRecursos_Destinos"].Override.AllowDelete =
                    DefaultableBoolean.False;
            if (destinosUltraGrid.ActiveRow.Band.Key != "FK_Direcciones_Destinos") return;
            ultraDropDownBarrio.DisplayLayout.RefreshFilters();
            ultraDropDownCalles.DisplayLayout.RefreshFilters();
        }

        private void DestinosUltraGridCellChange(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key != "idCalle") return;
            e.Cell.Row.Cells["idEntreCalle1"].Value = DBNull.Value;
            e.Cell.Row.Cells["idEntreCalle2"].Value = DBNull.Value;
            e.Cell.Row.Cells["idBarrio"].Value = DBNull.Value;
            ultraDropDownCalles.DisplayLayout.RefreshFilters();
            ultraDropDownBarrio.DisplayLayout.RefreshFilters();
        }

        private void DestinosUltraGridInitializeTemplateAddRow(object sender, InitializeTemplateAddRowEventArgs e)
        {
            if (e.TemplateAddRow.Band.Key == "Destinos")
                e.TemplateAddRow.Cells["idPrestacion"].Value =
                    (int) prestacionesResumenUltraGrid.ActiveRow.Cells["idPrestacion"].Value;
        }

        private void DestinosUltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (e.Row.Band.Key != "FK_DestinosRecursos_Destinos") return;
            //Una vez asignado el móvil, no se puede cambiar.
            if (e.Row.Cells["Asignado"].Value != DBNull.Value)
            {
                e.Row.Cells["idRecurso"].Style = ColumnStyle.Edit;
                e.Row.Cells["idRecurso"].Activation = Activation.NoEdit;
            }

            //Comienza la lógica para mostrar u ocultar tiempos.
            if (e.Row.Cells["Terminado"].Value == DBNull.Value)
            {
                if (e.Row.Cells["Llegada"].Value == DBNull.Value)
                {
                    e.Row.Cells["Terminado"].Hidden = true;
                    if (e.Row.Cells["Cancelado"].Value != DBNull.Value) e.Row.Cells["Llegada"].Hidden = true;
                    if (e.Row.Cells["Salida"].Value == DBNull.Value)
                    {
                        e.Row.Cells["Llegada"].Hidden = true;
                        if (e.Row.Cells["Cancelado"].Value != DBNull.Value) e.Row.Cells["Salida"].Hidden = true;
                        if (e.Row.Cells["Asignado"].Value == DBNull.Value)
                        {
                            if (e.Row.Cells["idRecurso"].Value == DBNull.Value) e.Row.Cells["Asignado"].Hidden = true;
                            e.Row.Cells["Cancelado"].Hidden = true;
                            e.Row.Cells["Llegada"].Hidden = true;
                            e.Row.Cells["Salida"].Hidden = true;
                            e.Row.Cells["Terminado"].Hidden = true;
                        }
                        else //Asignado tiene hora.
                        {
                            if (e.Row.Cells["Cancelado"].Value != DBNull.Value)
                            {
                                e.Row.Cells["Salida"].Hidden = true;
                                e.Row.Cells["Asignado"].Activation = Activation.Disabled;
                            }

                            e.Row.Cells["Llegada"].Hidden = true;
                            e.Row.Cells["Terminado"].Hidden = true;
                        }
                    }
                    else //Salida tiene hora.
                    {
                        e.Row.Cells["Asignado"].Activation = Activation.Disabled;
                    }
                }
                else //Llegada tiene hora
                {
                    e.Row.Cells["Salida"].Activation = Activation.Disabled;
                    e.Row.Cells["Asignado"].Activation = Activation.Disabled;
                    e.Row.Cells["Cancelado"].Hidden = true;
                }
            }
            else //Terminado tiene hora.
            {
                e.Row.Cells["Cancelado"].Hidden = true;
                e.Row.Cells["Llegada"].Activation = Activation.Disabled;
                e.Row.Cells["Salida"].Activation = Activation.Disabled;
                e.Row.Cells["Asignado"].Activation = Activation.Disabled;
            }
        }

        private void DestinosUltraGridBeforeCellUpdate(object sender, BeforeCellUpdateEventArgs e)
        {
            if (e.Cell.Column.Key != "Salida" || e.Cell.Value != DBNull.Value) return;
            var singleOrDefault =
                dsRecursosLista.RecursosLista.AsEnumerable().SingleOrDefault(r => r.Field<int?>("idRecurso") ==
                                                                                  (int)
                                                                                  destinosUltraGrid.ActiveRow.Cells[
                                                                                      "idRecurso"].Value);
            if (singleOrDefault != null && singleOrDefault.IsNull("idDestinoRecurso"))
                return;
            if (dsRecursosLista.RecursosLista.FindByidRecurso(
                    (int) destinosUltraGrid.ActiveRow.Cells["idRecurso"].Value).idDestinoRecurso ==
                (int) destinosUltraGrid.ActiveRow.Cells["idDestinoRecurso"].Value) return;
            dsDestinosOtro.Clear();
            dsDestinosOtro.Merge(
                new Service().GetDestinos(
                    new Service().PrestacionDelDestinoRecurso(
                        dsRecursosLista.RecursosLista.FindByidRecurso(
                            (int) destinosUltraGrid.ActiveRow.Cells["idRecurso"].Value).idDestinoRecurso, Program.Pin),
                    Program.Pin));
            if (
                dsRecursosLista.RecursosLista.FindByidRecurso(
                    (int) destinosUltraGrid.ActiveRow.Cells["idRecurso"].Value).Estado == "En camino")
            {
                var dr =
                    MessageBox.Show(
                        "El recurso " +
                        dsRecursosLista.RecursosLista.FindByidRecurso(
                            (int) destinosUltraGrid.ActiveRow.Cells["idRecurso"].Value).Nombre +
                        " está en camino hacia" +
                        Environment.NewLine +
                        dsRecursosLista.RecursosLista.FindByidRecurso(
                            (int) destinosUltraGrid.ActiveRow.Cells["idRecurso"].Value).Direccion + "." +
                        Environment.NewLine + Environment.NewLine +
                        "¿Cancelamos ese viaje?",
                        "Recurso viajando",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    //Cancelar el otro recurso.
                    dsDestinosOtro.DestinosRecursos.FindByidDestinoRecurso(
                                dsRecursosLista.RecursosLista.FindByidRecurso(
                                    (int) destinosUltraGrid.ActiveRow.Cells["idRecurso"].Value).idDestinoRecurso)
                            .Cancelado =
                        new Service().HoraActual(Program.Pin);
                    dsDestinosOtro.DestinosRecursos.FindByidDestinoRecurso(
                                dsRecursosLista.RecursosLista.FindByidRecurso(
                                    (int) destinosUltraGrid.ActiveRow.Cells["idRecurso"].Value).idDestinoRecurso)
                            .Observaciones
                        = "Desviado a la Prestación Nº " + prestacionesUltraGrid.Rows[0].Cells["Numero"].Text +
                          ".";
                    GrabarDestinos();
                    e.Cell.Row.Cells["Asignado"].Activation = Activation.NoEdit;
                }
                else
                {
                    e.Cancel = true;
                }
            }

            if (dsRecursosLista.RecursosLista.FindByidRecurso(
                    (int) destinosUltraGrid.ActiveRow.Cells["idRecurso"].Value).Estado != "En el lugar") return;
            var dr1 =
                MessageBox.Show(
                    "El recurso " +
                    dsRecursosLista.RecursosLista.FindByidRecurso(
                        (int) destinosUltraGrid.ActiveRow.Cells["idRecurso"].Value).Nombre +
                    " está en" +
                    Environment.NewLine +
                    dsRecursosLista.RecursosLista.FindByidRecurso(
                        (int) destinosUltraGrid.ActiveRow.Cells["idRecurso"].Value).Direccion + "." +
                    Environment.NewLine + Environment.NewLine +
                    "¿Se va de ahí? Su actuación quedará terminada.",
                    "Recurso ocupado",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr1 == DialogResult.Yes)
            {
                //Finalizar el otro recurso.
                dsDestinosOtro.DestinosRecursos.FindByidDestinoRecurso(dsRecursosLista.RecursosLista.FindByidRecurso(
                        (int)
                        destinosUltraGrid.ActiveRow.Cells[
                            "idRecurso"].Value).idDestinoRecurso).Terminado =
                    new Service().HoraActual(Program.Pin);
                dsDestinosOtro.DestinosRecursos.FindByidDestinoRecurso(
                            dsRecursosLista.RecursosLista.FindByidRecurso(
                                (int) destinosUltraGrid.ActiveRow.Cells["idRecurso"].Value).idDestinoRecurso)
                        .Observaciones =
                    "Salió a la Prestación Nº " + prestacionesUltraGrid.Rows[0].Cells["Numero"].Text + ".";
                GrabarDestinos();
                e.Cell.Row.Cells["Asignado"].Activation = Activation.NoEdit;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void DestinosUltraGridAfterCellUpdate(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key == "Llegada") ActualizarMedicosActuantes();
        }

        private void DestinosUltraGridBeforeRowDeactivate(object sender, CancelEventArgs e)
        {
            if (destinosUltraGrid.ActiveRow.Band.Key != "Destinos") return;
            if (destinosUltraGrid.ActiveRow.Cells["idTipoDeDestino"].Value != DBNull.Value) return;
            MessageBox.Show("Falta el Tipo de Destino",
                "¡Atención!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            e.Cancel = true;
        }

        #endregion

        #region Eventos pacientesUltraGrid

        private void PacientesUltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (e.Row.Band.Key == "Pacientes")
            {
                ActualizarMedicosActuantes();
                if (e.Row.Cells["idAfiliado"].Value != DBNull.Value) e.Row.Cells["EsAfiliado"].Value = true;
                if ("OC".Contains(Tag.ToString()))
                {
                    e.Row.Cells["BuscarAfiliado"].Value = "Buscar en Padrón";
                    e.Row.Cells["Contrato"].Value = "Contrato";
                }

                e.Row.Cells["AtencionesAnteriores"].Value = "Atenciones Anteriores";
                e.Row.Cells["Planes"].Value = "Planes";
            }

            if (e.Row.Band.Key != "FK__Medicamentos__Pacientes" || e.Row.Cells["idMedicamento"].Value == DBNull.Value ||
                e.Row.Cells["Cantidad"].Value == DBNull.Value) return;
            e.Row.Cells["Unidad"].Value = Convert.ToInt32(e.Row.Cells["Cantidad"].Text) > 1
                ? _fp.dsMedicamentos.Medicamentos.FindByidMedicamento(
                    (int) e.Row.Cells["idMedicamento"].Value).Unidades
                : _fp.dsMedicamentos.Medicamentos.FindByidMedicamento(
                    (int) e.Row.Cells["idMedicamento"].Value).Unidad;
            if ((int) e.Row.Cells["idMedicamento"].Value == (int) _fp.dsSistemas.Sistemas.Rows[0]["SinMedicamentos"])
            {
                e.Row.Band.MaxRows = 1;
                e.Row.Cells["Cantidad"].Value = 0;
                e.Row.Cells["Unidad"].Value = "";
                e.Row.Cells["Cantidad"].Hidden = true;
                e.Row.Cells["Unidad"].Hidden = true;
            }
            else
            {
                e.Row.Band.MaxRows = 100;
                e.Row.Cells["Cantidad"].Hidden = false;
                e.Row.Cells["Unidad"].Hidden = false;
            }
        }

        private void PacientesUltraGridClickCellButton(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key == "BuscarAfiliado" && Tag.ToString() == "O")
            {
                var frmBuscar = new FormBuscarAfiliadoDesdeDespacho();
                frmBuscar.ShowDialog(this);
                if (frmBuscar.DialogResult == DialogResult.OK)
                {
                    dsBuscarTelefono.Clear();
                    dsBuscarTelefono.Merge(new Service().GetAfiliadoDelTelefono(
                        frmBuscar.IdAfiliado, Program.Pin));
                    pacientesUltraGrid.DisplayLayout.ActiveRow.Cells["idAfiliado"].Value =
                        dsBuscarTelefono.Afiliados[0]["idAfiliado"];
                    pacientesUltraGrid.DisplayLayout.ActiveRow.Cells["EsAfiliado"].Value = true;
                    pacientesUltraGrid.DisplayLayout.ActiveRow.Cells["Nombre"].Value =
                        dsBuscarTelefono.Afiliados[0]["Nombre"];
                    if (dsBuscarTelefono.Afiliados[0]["FechaDeNacimiento"].ToString() != "")
                    {
                        pacientesUltraGrid.DisplayLayout.ActiveRow.Cells["Edad"].Value =
                            Convert.ToInt32(
                                XEdad((DateTime) dsBuscarTelefono.Afiliados[0]["FechaDeNacimiento"]).Substring(0, 3));
                        pacientesUltraGrid.DisplayLayout.ActiveRow.Cells["EdadEn"].Value =
                            XEdad((DateTime) dsBuscarTelefono.Afiliados[0]["FechaDeNacimiento"]).Substring(3, 1);
                    }

                    pacientesUltraGrid.DisplayLayout.ActiveRow.Cells["Sexo"].Value =
                        dsBuscarTelefono.Afiliados[0]["Sexo"];
                    pacientesUltraGrid.DisplayLayout.ActiveRow.Cells["idPrepago"].Value =
                        dsBuscarTelefono.Afiliados[0]["idPrepago"];
                    pacientesUltraGrid.DisplayLayout.ActiveRow.Cells["NroAfiliadoPrepago"].Value =
                        dsBuscarTelefono.Afiliados[0]["NumeroAfiliadoPrepago"];
                    if (dsBuscarTelefono.Afiliados[0]["Antecedentes"] != DBNull.Value &&
                        dsBuscarTelefono.Afiliados[0]["Antecedentes"].ToString().Length > 0)
                        if (pacientesUltraGrid.DisplayLayout.ActiveRow.Cells["Antecedentes"].Value == DBNull.Value ||
                            pacientesUltraGrid.DisplayLayout.ActiveRow.Cells["Antecedentes"].Value.ToString().Length ==
                            0)
                            pacientesUltraGrid.DisplayLayout.ActiveRow.Cells["Antecedentes"].Value =
                                dsBuscarTelefono.Afiliados[0]["Antecedentes"].ToString();
                        else
                            pacientesUltraGrid.DisplayLayout.ActiveRow.Cells["Antecedentes"].Value =
                                dsBuscarTelefono.Afiliados[0]["Antecedentes"] + " | " +
                                pacientesUltraGrid.DisplayLayout.ActiveRow.Cells["Antecedentes"].Value;
                    if (frmBuscar.IdContrato != 0)
                    {
                        pacientesUltraGrid.DisplayLayout.ActiveRow.Cells["IdContrato"].Value = frmBuscar.IdContrato;
                        pacientesUltraGrid.DisplayLayout.ActiveRow.Cells["CondicionesContrato"].Value =
                            _fp.dsContratosLista.Contratos.FindByidContrato(frmBuscar.IdContrato).Condiciones;
                        pacientesUltraGrid.DisplayLayout.ActiveRow.Cells["idCobertura"].Value =
                            _fp.dsSistemas.Sistemas[0]["CoberturaContrato"];
                    }
                    else
                    {
                        pacientesUltraGrid.DisplayLayout.Rows[0].Cells["idCobertura"].Value =
                            _fp.dsSistemas.Sistemas[0]["CoberturaAfiliado"];
                        pacientesUltraGrid.DisplayLayout.ActiveRow.Cells["CondicionesContrato"].Value = "";
                    }

                    pacientesUltraGrid.DisplayLayout.ActiveRow.Update();
                }

                frmBuscar.Close();
            }

            if (e.Cell.Column.Key == "Contrato" && Tag.ToString() == "O")
            {
                var frmBuscarContrato = new FormBuscarContratoDesdeDespacho();
                frmBuscarContrato.ShowDialog(this);
                if (frmBuscarContrato.Boton == "Contrato")
                {
                    pacientesUltraGrid.ActiveRow.Cells["idContrato"].Value = frmBuscarContrato.IdContrato;
                    pacientesUltraGrid.ActiveRow.Cells["idCobertura"].Value =
                        _fp.dsSistemas.Sistemas[0]["CoberturaContrato"];
                }

                frmBuscarContrato.Close();
            }

            if (e.Cell.Column.Key == "AtencionesAnteriores")
            {
                var faa = new FormAtencionesAnteriores();
                try
                {
                    faa.IdAfiliado = (int) pacientesUltraGrid.ActiveRow.Cells["idAfiliado"].Value;
                }
                catch
                {
                    faa.IdAfiliado = 0;
                }

                try
                {
                    faa.Telefono = prestacionesUltraGrid.DisplayLayout.Rows[0].Cells["Telefono"].Value.ToString();
                }
                catch
                {
                    faa.Telefono = "";
                }

                faa.IdPrestacion = (int) prestacionesUltraGrid.DisplayLayout.Rows[0].Cells["idPrestacion"].Value;
                faa.ShowDialog();
            }

            if (e.Cell.Column.Key != "Planes") return;
            var pla = new FormPlanesDelAfiliado();
            if (pacientesUltraGrid.ActiveRow.Cells["idAfiliado"].Value == DBNull.Value)
                pla.IdAfiliado = 0;
            else
                pla.IdAfiliado = (int) pacientesUltraGrid.ActiveRow.Cells["idAfiliado"].Value;
            pla.ShowDialog();
        }

        private void PacientesUltraGridInitializeTemplateAddRow(object sender, InitializeTemplateAddRowEventArgs e)
        {
            if (e.TemplateAddRow.Band.Key != "Pacientes") return;
            e.TemplateAddRow.Cells["BuscarAfiliado"].Value = "Buscar en Padrón";
            e.TemplateAddRow.Cells["AtencionesAnteriores"].Value = "Atenciones Anteriores";
            e.TemplateAddRow.Cells["Planes"].Value = "Planes";
            e.TemplateAddRow.Cells["idPrestacion"].Value =
                (int) prestacionesResumenUltraGrid.ActiveRow.Cells["idPrestacion"].Value;
        }

        private void PacientesUltraGridCellChange(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key == "Cantidad" && e.Cell.Text.Length > 0)
                e.Cell.Row.Cells["Unidad"].Value = Convert.ToInt32(e.Cell.Text) > 1
                    ? _fp.dsMedicamentos.Medicamentos.FindByidMedicamento(
                        (int) e.Cell.Row.Cells["idMedicamento"].Value).Unidades
                    : _fp.dsMedicamentos.Medicamentos.FindByidMedicamento(
                        (int) e.Cell.Row.Cells["idMedicamento"].Value).Unidad;
        }

        private void PacientesUltraGridAfterRowUpdate(object sender, RowEventArgs e)
        {
            GrabarPacientes();
        }

        #endregion

        #region Grabar

        private void GrabarPrestacion()
        {
            Validate();
            prestacionesBindingSource1.EndEdit();
            if (!dsPrestacion.HasChanges()) return;
            var cambios = new DsPrestacion();
// ReSharper disable AssignNullToNotNullAttribute
            cambios.Merge(dsPrestacion.GetChanges());
// ReSharper restore AssignNullToNotNullAttribute
            var prest = new Service().UpdatePrestacion(cambios, Program.Pin);
            if (prest == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." +
                    Environment.NewLine + Environment.NewLine +
                    "Póngase en contacto con el Administrador del Sistema.",
                    "Operación Rechazada",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dsPrestacion.Merge(prest);
                ManejoDatos.AplicarUpdate(dsPrestacion);
            }
        }

        private void GrabarDestinos()
        {
            Validate();
            destinosBindingSource.EndEdit();
            if (!dsDestinos.HasChanges() && !dsDestinosOtro.HasChanges()) return;
            if (prestacionesUltraGrid.ActiveRow != null &&
                prestacionesUltraGrid.ActiveRow.Cells["Terminada"].Text == "Sí")
                foreach (var destino in destinosUltraGrid.Rows)
                foreach (var recurso in destino.ChildBands["FK_DestinosRecursos_Destinos"].Rows)
                    recurso.Cells["idRecurso"].Value = DBNull.Value;
                //No hay que guardar este dato en las prestaciones terminadas.
            if (dsDestinos.HasChanges())
            {
                var cambios = new DsDestinos();
// ReSharper disable AssignNullToNotNullAttribute
                cambios.Merge(dsDestinos.GetChanges());
// ReSharper restore AssignNullToNotNullAttribute
                var dest = new Service().UpdateDestinos(cambios, Program.Pin);
                if (dest == null)
                {
                    MessageBox.Show(
                        "La operación fue rechazada por la Base de Datos." +
                        Environment.NewLine + Environment.NewLine +
                        "Póngase en contacto con el Administrador del Sistema.",
                        "Operación Rechazada",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dsDestinos.Merge(dest);
                    ManejoDatos.AplicarUpdate(dsDestinos);
                }
            }

            if (!dsDestinosOtro.HasChanges()) return;
            var cambiosOtro = new DsDestinos();
// ReSharper disable AssignNullToNotNullAttribute
            cambiosOtro.Merge(dsDestinosOtro.GetChanges());
// ReSharper restore AssignNullToNotNullAttribute
            var destOtro = new Service().UpdateDestinos(cambiosOtro, Program.Pin);
            if (destOtro == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." +
                    Environment.NewLine + Environment.NewLine +
                    "Póngase en contacto con el Administrador del Sistema.",
                    "Operación Rechazada",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dsDestinosOtro.Merge(destOtro);
                ManejoDatos.AplicarUpdate(dsDestinosOtro);
            }
        }

        private void GrabarPacientes()
        {
            Validate();
            pacientesBindingSource.EndEdit();
            if (!dsPacientesPrestacion.HasChanges()) return;
            var cambios = new DsPacientesPrestacion();
// ReSharper disable AssignNullToNotNullAttribute
            cambios.Merge(dsPacientesPrestacion.GetChanges());
// ReSharper restore AssignNullToNotNullAttribute
            var pac = new Service().UpdatePacientes(cambios, Program.Pin);
            if (pac == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." +
                    Environment.NewLine + Environment.NewLine +
                    "Póngase en contacto con el Administrador del Sistema.",
                    "Operación Rechazada",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dsPacientesPrestacion.Merge(pac);
                ManejoDatos.AplicarUpdate(dsPacientesPrestacion);
            }
        }

        private void Grabar()
        {
            GrabarPrestacion();
            GrabarDestinos();
            GrabarPacientes();
        }

        #endregion

        #region Filtros

        private void UltraDropDownCallesFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = destinosUltraGrid.ActiveRow.Cells["idLocalidad"].Value == DBNull.Value
                ? new FilterCondition(e.Row.Band.Columns["idLocalidad"], FilterComparisionOperator.Equals, 0)
                : new FilterCondition(e.Row.Band.Columns["idLocalidad"], FilterComparisionOperator.Equals,
                    _fp.dsLocalidades1.Localidades.FindByidLocalidad(
                        (int) destinosUltraGrid.ActiveRow.Cells["idLocalidad"].Value).idLocalidad);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void UltraDropDownBarrioFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = destinosUltraGrid.ActiveRow.Cells["idLocalidad"].Value == DBNull.Value
                ? new FilterCondition(e.Row.Band.Columns["idLocalidad"], FilterComparisionOperator.Equals, 0)
                : new FilterCondition(e.Row.Band.Columns["idLocalidad"], FilterComparisionOperator.Equals,
                    _fp.dsLocalidades1.Localidades.FindByidLocalidad(
                        (int) destinosUltraGrid.ActiveRow.Cells["idLocalidad"].Value).idLocalidad);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        #endregion

        #region Botones

        private void ButtonAgregarPacienteClick(object sender, EventArgs e)
        {
            if (!"OC".Contains(Tag.ToString())) return;
            if (prestacionesResumenUltraGrid.ActiveRow != null)
                dsPacientesPrestacion.Pacientes.idPrestacionColumn.DefaultValue =
                    (int) prestacionesResumenUltraGrid.ActiveRow.Cells["idPrestacion"].Value;
            pacientesUltraGrid.DisplayLayout.Bands["Pacientes"].AddNew();
        }

        private void ButtonReferenciaColoresClick(object sender, EventArgs e)
        {
            var refe = new FormReferenciaColores();
            refe.ShowDialog();
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            Grabar();
        }

        private void ButtonAplicarClick(object sender, EventArgs e)
        {
            if ("OC".Contains(Tag.ToString())) Grabar();
            Close();
        }

        #endregion

        #region Calcula ancho de columnas dropdown

        private void UltraDropDownMotivosCancelacionBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownMotivosCancelacion.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownLugaresBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownLugares.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownLocalidadBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownLocalidad.DisplayLayout.Bands[0].Columns["NombreCompleto"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownCallesBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownCalles.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownBarrioBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownBarrio.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownMedicosBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownMedicos.DisplayLayout.Bands[0].Columns["ApelNomb"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownRecursosActivosBeforeDropDown(object sender, CancelEventArgs e)
        {
            //this.dsRecursosLista.Clear();
            //this.dsRecursosLista.Merge(new WS.Service().GetRecursosLista(Program.Pin));
            ultraDropDownRecursosActivos.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
            ultraDropDownRecursosActivos.DisplayLayout.Bands[0].Columns["Tripulacion"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
            ultraDropDownRecursosActivos.DisplayLayout.Bands[0].Columns["Estado"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
            ultraDropDownRecursosActivos.DisplayLayout.Bands[0].Columns["Direccion"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
            ultraDropDownRecursosActivos.DisplayLayout.Bands[0].Columns["Observaciones"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownCoberturasBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownCoberturas.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownPracticasBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownPracticas.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownPrepagosBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownPrepagos.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownMotivosBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownMotivos.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownDiagnosticosBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownDiagnosticos.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownMedicamentosBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownMedicamentos.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
            ultraDropDownMedicamentos.DisplayLayout.RefreshFilters();
        }

        private void UltraDropDownTiposDeDestinoBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownTiposDeDestino.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownContratosBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownContratos.DisplayLayout.Bands[0].Columns["Contrato"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownTomadoresBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownTomadores.DisplayLayout.Bands[0].Columns["ApelNomb"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownPacientesBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownPacientes.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownDespachadorBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownDespachador.DisplayLayout.Bands[0].Columns["ApelNomb"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownCodigosBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownCodigos.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        #endregion

        #region Varios

        private void ActualizarMedicosActuantes()
        {
            destinosUltraGrid.Update();
            ultraDataSourceMedicos.Rows.Clear();

            foreach (var recurso in from DataRow recurso in dsDestinos.DestinosRecursos.Rows
                where recurso["Cancelado"] == DBNull.Value && recurso["idMedico1"] != DBNull.Value
                let recurso1 = recurso
                let cuantos =
                    ultraDropDownMedicos.Rows.Count(
                        medico =>
                            (int) medico.Cells["idEmpleado"].Value == (int) recurso1["idMedico1"])
                where cuantos == 0
                select recurso)
                ultraDataSourceMedicos.Rows.Add(new[]
                {
                    recurso["idMedico1"],
                    dsMedicos.EmpleadosLista.FindByidEmpleado(
                        (int) recurso["idMedico1"]).ApelNomb,
                    dsMedicos.EmpleadosLista.FindByidEmpleado(
                        (int) recurso["idMedico1"]).NombApel
                });
            foreach (var recurso in from DataRow recurso in dsDestinos.DestinosRecursos.Rows
                where recurso["Cancelado"] == DBNull.Value && recurso["idMedico2"] != DBNull.Value
                let recurso1 = recurso
                let cuantos =
                    ultraDropDownMedicos.Rows.Count(
                        medico =>
                            (int) medico.Cells["idEmpleado"].Value == (int) recurso1["idMedico2"])
                where cuantos == 0
                select recurso)
                ultraDataSourceMedicos.Rows.Add(new[]
                {
                    recurso["idMedico2"],
                    dsMedicos.EmpleadosLista.FindByidEmpleado(
                        (int) recurso["idMedico2"]).ApelNomb,
                    dsMedicos.EmpleadosLista.FindByidEmpleado(
                        (int) recurso["idMedico2"]).NombApel
                });
        }

        private string XEdad(DateTime fechanac)
        {
            var ahora = new Service().HoraActual(Program.Pin);
            // Calculamos la diferencia de años
            var anyos = ahora.Year - fechanac.Year;
            // Restamos un año si estamos antes de el
            // día de nacimiento en el año actual
            if (ahora.Month < fechanac.Month || ahora.Month == fechanac.Month && ahora.Day < fechanac.Day) anyos--;
            if (anyos > 0) return anyos.ToString("000") + "A";
            var meses = ahora.Month - fechanac.Month;
            if (meses < 0) meses = meses + 12;
            if (ahora.Day < fechanac.Day) meses--;
            if (meses > 0) return meses.ToString("000") + "M";
            var dias = ahora - fechanac;
            return dias.Days.ToString("000") + "D";
        }

        #endregion

        #region ultraDropDown... _RowSelected

        private void UltraDropDownContratosRowSelected(object sender, RowSelectedEventArgs e)
        {
            try
            {
                pacientesUltraGrid.ActiveRow.Cells["CondicionesContrato"].Value =
                    _fp.dsContratosLista.Contratos.FindByidContrato(
                        (int) ultraDropDownContratos.SelectedRow.Cells["IdContrato"].Value).Condiciones;
            }
            catch
            {
                pacientesUltraGrid.ActiveRow.Cells["CondicionesContrato"].Value = "";
            }
        }

        private void UltraDropDownRecursosActivosRowSelected(object sender, RowSelectedEventArgs e)
        {
            destinosUltraGrid.ActiveRow.Cells["idDespachador"].Value = Program.IdUsuario;
            destinosUltraGrid.ActiveRow.Cells["Asignado"].Hidden = false;
        }

        private void UltraDropDownLocalidadRowSelected(object sender, RowSelectedEventArgs e)
        {
            destinosUltraGrid.Update();
            ultraDropDownBarrio.DisplayLayout.RefreshFilters();
            ultraDropDownCalles.DisplayLayout.RefreshFilters();
        }

        #endregion
    }
}