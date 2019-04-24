using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using BeforeExitEditModeEventArgs = Infragistics.Win.UltraWinGrid.BeforeExitEditModeEventArgs;
using ColumnStyle = Infragistics.Win.UltraWinGrid.ColumnStyle;

namespace Administración
{
    public partial class FormClientes : Form1
    {
        private bool _salir = true;

        private void FormClientesActivated(object sender, EventArgs e)
        {
            if (clientesUltraGrid.Rows.Count != 0)
                dsContratosLista.Merge(
                    new Service().GetContratosRenglonFactura((int) clientesUltraGrid.Rows[0].Cells["idCliente"].Value,
                        Program.Pin));
        }

        private string Cobrador()
        {
            var idZona = (from d in dsClientes.Direcciones.AsEnumerable()
                where d.Field<bool>("Cobranza")
                select d.Field<int?>("idZona")).FirstOrDefault();
            var cobrador = "";
            if (idZona != null)
            {
                cobrador = (from z in _fp.dsZonas.Zonas.AsEnumerable()
                    join e in _fp.dsEmpleadosLista.EmpleadosLista.AsEnumerable() on
                        z.Field<int?>("idCobrador")
                        equals e.Field<int?>("idEmpleado")
                    where z.Field<int?>("idZona") == Convert.ToInt32(idZona)
                    select e.Field<string>("ApelNomb")).FirstOrDefault();
            }
            return cobrador ?? "";
        }

        private void ultraDropDownNegocios_BeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownNegocios.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        #region Propiedades del Formulario

        private FormPrincipal _fp;

        public FormClientes()
        {
            InitializeComponent();
        }

        public int Cliente { private get; set; }

        #endregion

        #region Load y Activate

        private void FormClientesLoad(object sender, EventArgs e)
        {
            CargarDatasets();
            clientesUltraGrid.Rows.ExpandAll(true);

            dsProtecciones.Merge(new Service().GetProtecciones(Program.Pin));
            dsNegocios.Merge(new Service().GetNegocios(Program.Pin));

            /*Que la fecha de registro de la Solicitud sea la actual*/
            clientesUltraGrid.DisplayLayout.Bands["FK_Solicitudes_Contratos"].Columns["FechaRegistro"].DefaultCellValue
                =
                new Service().HoraActual(Program.Pin);
            clientesUltraGrid.DisplayLayout.Bands["FK_Solicitudes_Contratos"].Columns["idGrabador"].DefaultCellValue =
                Program.IdUsuario;

            clientesUltraGrid.DisplayLayout.Bands["FK_FacturasProforma_Clientes"].Columns["FacturarMes"]
                .DefaultCellValue = 0;

            clientesUltraGrid.DisplayLayout.Bands["FK_RenglonesFacturaProforma_FacturasProforma"].MaxRows =
                (int) _fp.dsSistemas.Sistemas.Rows[0]["MaxCantDetallesPorComprobante"];
            if ((string) Tag != "N") //No es un cliente nuevo. Cargo los datos del cliente.
            {
                /*Carga datos*/
                dsClientes.Merge(new Service().GetCliente(Cliente, Program.Pin));
            }

            if ((string) Tag == "V") // Visualizar.
            {
                buttonAceptar.Visible = false;
                buttonAplicar.Visible = false;
                buttonCancelar.Visible = false;
                buttonSalir.Visible = true;
                foreach (var banda in clientesUltraGrid.DisplayLayout.Bands)
                {
                    banda.Override.AllowAddNew = AllowAddNew.No;
                    foreach (var columna in banda.Columns)
                        columna.Style = ColumnStyle.Edit;
                }
                clientesUltraGrid.DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect;
                clientesUltraGrid.DisplayLayout.Override.AllowDelete = DefaultableBoolean.False;
            }

            /*Llena el combo TipoSolicitud*/
            clientesUltraGrid.DisplayLayout.ValueLists.Add("TiposDeSolicitud");
            clientesUltraGrid.DisplayLayout.ValueLists["TiposDeSolicitud"].ValueListItems.Add("A", "Alta");
            clientesUltraGrid.DisplayLayout.ValueLists["TiposDeSolicitud"].ValueListItems.Add("B", "Baja");
            clientesUltraGrid.DisplayLayout.ValueLists["TiposDeSolicitud"].ValueListItems.Add("S", "Suspensión");
            clientesUltraGrid.DisplayLayout.Bands["FK_Solicitudes_Contratos"].Columns["AltaBajaSusp"].ValueList =
                clientesUltraGrid.DisplayLayout.ValueLists["TiposDeSolicitud"];

            /*Conecta el Grid*/
            clientesUltraGrid.DataBind();
            if (clientesUltraGrid.Rows.Count > 0 && clientesUltraGrid.Rows[0].Cells["CUIT"].Value.ToString().Length < 11)
            {
                clientesUltraGrid.Rows[0].Cells["CUIT"].Column.Header.Caption = @"DNI";
                clientesUltraGrid.Rows[0].Cells["CUIT"].Column.MaskInput = @"{LOC}nnn,nnn,nnn,nnn";
            }
        }

        private void CargarDatasets()
        {
            _fp = (FormPrincipal) MdiParent;
            callesBindingSource.DataSource = _fp.dsCallesLista;
            zonasBindingSource.DataSource = _fp.dsZonas;
            categoriasIVABindingSource.DataSource = _fp.dsCategoriasIVA;
            tiposDeClienteBindingSource.DataSource = _fp.dsTiposDeCliente;
            entidadesDeCobranzaBindingSource.DataSource = _fp.dsEntidadesDeCobranza;
            tiposDeContratoBindingSource.DataSource = _fp.dsTiposDeContrato;
            motivosDeBajaBindingSource.DataSource = _fp.dsMotivosDeBaja;
            codigosBindingSource.DataSource = _fp.dsCodigos;
            barriosBindingSource.DataSource = _fp.dsBarrios;
            tandasDeFacturacionBindingSource.DataSource = _fp.dsTandasDeFacturacion;
            localidadesListaBindingSource.DataSource = _fp.dsLocalidadesLista;
            tomadoresDeBajaBindingSource.DataSource = _fp.dsEmpleadosLista;
            vendedoresBindingSource.DataSource = _fp.dsVendedores;
            //planesBindingSource.DataSource = _fp.dsPlanes;
            tiposDeCobranzaBindingSource.DataSource = _fp.dsTiposDeCobranza;
            usuariosListaBindingSource.DataSource = _fp.dsUsuariosLista;
            prepagosBindingSource.DataSource = _fp.dsPrepagos;
            dsContratosLista.Merge(
                new Service().GetContratosRenglonFactura(Cliente,
                    Program.Pin));
            dsContratosLista.Merge(
                new Service().GetPlanesRenglonFactura(Cliente,
                    Program.Pin));
            dsContratosLista.Merge(
                new Service().GetContratosLista(Program.Pin));
            dsPorcentajeIVA.Merge(new Service().GetPorcentajeIVA(Program.Pin));
            dsParametros.Merge(new Service().GetParametros(Program.Pin));
            empresasSueldoBcoMacroBindingSource.DataSource = _fp.dsEmpresasSueldoBancoMacro;
        }

        #endregion

        #region BeforeDropDown

        private void UltraDropDownTomadoresDeBajaBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownTomadoresDeBaja.DisplayLayout.Bands[0].Columns["ApelNomb"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownBarriosBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownBarrios.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownPlanesBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownPlanes.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownCalleBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownCalle.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownMotivosDeBajaBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownMotivosDeBaja.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownCodigosBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownCodigos.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownZonasBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownZonas.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownCategoriasIVABeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownCategoriasIVA.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownLocalidadBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownLocalidad.DisplayLayout.Bands[0].Columns["NombreCompleto"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownTiposDeClienteBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownTiposDeCliente.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownTiposDeContratoBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownTiposDeContrato.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownEntidadesDeCobranzaBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownEntidadesDeCobranza.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownTiposDeCobranzaBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownTiposDeCobranza.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownVendedoresBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownVendedores.DisplayLayout.Bands[0].Columns["ApelNomb"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownContratosBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownContratos.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
            ultraDropDownContratos.DisplayLayout.Bands[0].Columns["Estado"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownTandasDeFacturacionBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownTandasDeFacturacion.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void ultraDropDownFacturarMes_BeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownFacturarMes.DisplayLayout.Bands[0].Columns["Texto"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        #endregion

        #region Verificar y Updatear

        private bool Verificar() // Lo primero que hace al Aplicar o Aceptar.
        {
            /*Verifica que cada cliente tenga algún contrato*/
            var clientes = clientesUltraGrid.DisplayLayout.Bands["Clientes"]; //Clientes
            foreach (UltraGridRow cadaCliente in clientes.GetRowEnumerator(GridRowType.DataRow)) //El cliente
            {
                if (!Verificar_CUIT(cadaCliente)) return false;
                if (!Verificar_IdTipoDeCobranza(cadaCliente)) return false;
                if (!Verificar_Contratos(cadaCliente)) return false;
                if (!Verificar_Direcciones(cadaCliente)) return false;
                if (!Verificar_FacturasProforma(cadaCliente)) return false;
            }
            return true;
        }

        private bool Verificar_FacturasProforma(UltraGridRow cadaCliente)
        {
            foreach (var factura in cadaCliente.ChildBands["FK_FacturasProforma_Clientes"].Rows)
            {
                if (factura.Cells["idTandaDeFacturacion"].Text == "")
                {
                    MessageBox.Show("Falta una Tanda de Facturación",
                        "Imposible Grabar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }
                if (factura.ChildBands["FK_RenglonesFacturaProforma_FacturasProforma"].Rows.Count == 0)
                {
                    MessageBox.Show("Hay una factura sin renglones.",
                        "Imposible Grabar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }
                //foreach (
                //    var renglonFactura in
                //        factura.ChildBands["FK_RenglonesFacturaProforma_FacturasProforma"].Rows)
                //{
                //    foreach (var celda in renglonFactura.Cells)
                //    {
                //        if (celda.Hidden || celda.Value != DBNull.Value) continue;
                //        MessageBox.Show(this,
                //            Resources.FormClientes_Verificar_El_campo_ + celda.Column.Header.Caption +
                //            Resources.FormClientes_Verificar__está_vacío_,
                //            "Imposible Grabar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        _salir = false;
                //        return false;
                //    }
                //}
            }
            return true;
        }

        private bool Verificar_Direcciones(UltraGridRow cadaCliente)
        {
            var direccionesReales = 0;
            var direccionesCobranza = 0;
            foreach (var direccion in cadaCliente.ChildBands["FK__Direcciones__Clientes"].Rows)
            {
                if (!VerificarDireccionesDelCliente(direccion, ref direccionesReales, ref direccionesCobranza))
                    return false;
            }
            if (direccionesReales < 1)
            {
                MessageBox.Show("No hay ninguna Dirección Real del Cliente",
                    "Imposible Grabar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (direccionesReales > 1)
            {
                MessageBox.Show("Hay más de una Dirección Real del Cliente",
                    "Imposible Grabar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (direccionesCobranza < 1)
            {
                MessageBox.Show("No hay ninguna Dirección de Cobranza del Cliente",
                    "Imposible Grabar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (direccionesCobranza > 1)
            {
                MessageBox.Show("Hay más de una Dirección de Cobranza del Cliente",
                    "Imposible Grabar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            foreach (var contrato in cadaCliente.ChildBands["FK_Contratos_Clientes"].Rows)
            {
                if (!VerificarDireccionesDeContratos(contrato)) return false;
            }
            return true;
        }

        private bool VerificarDireccionesDelCliente(UltraGridRow direccion, ref int direccionesReales,
            ref int direccionesCobranza)
        {
            if (direccion.Cells["Real"].Text == "True")
            {
                direccionesReales++;
            }
            if (direccion.Cells["Cobranza"].Text == "True")
            {
                direccionesCobranza++;
                if (direccion.Cells["idZona"].Value == DBNull.Value &&
                    _fp.dsTiposDeCobranza.TiposDeCobranza.FindByidTipoDeCobranza(
                        (int) clientesUltraGrid.DisplayLayout.Rows[0].Cells["idTipoDeCobranza"].Value).
                        RequiereZonaDeCobranza)
                {
                    MessageBox.Show("Se requiere la Zona en la Dirección de Cobranza.",
                        "Imposible Grabar",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (direccion.Cells["idLocalidad"].Value == DBNull.Value)
            {
                MessageBox.Show("Hay una dirección sin Localidad.",
                    "Imposible Grabar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (direccion.Cells["idCalle"].Value != DBNull.Value &&
                _fp.dsCallesLista.Calles.FindByidCalle((int) direccion.Cells["idCalle"].Value).idLocalidad !=
                (int) direccion.Cells["idLocalidad"].Value)
            {
                MessageBox.Show(
                    "La calle " + direccion.Cells["idCalle"].Text +
                    " no pertenece a " +
                    direccion.Cells["idLocalidad"].Text + ".", "No se pudo grabar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            if (direccion.Cells["idEntreCalle1"].Value != DBNull.Value &&
                _fp.dsCallesLista.Calles.FindByidCalle((int) direccion.Cells["idEntreCalle1"].Value).
                    idLocalidad != (int) direccion.Cells["idLocalidad"].Value)
            {
                MessageBox.Show(
                    "La calle " + direccion.Cells["idEntreCalle1"].Text +
                    " no pertenece a " +
                    direccion.Cells["idLocalidad"].Text + ".", "No se pudo grabar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            if (direccion.Cells["idEntreCalle2"].Value != DBNull.Value &&
                _fp.dsCallesLista.Calles.FindByidCalle((int) direccion.Cells["idEntreCalle2"].Value).
                    idLocalidad != (int) direccion.Cells["idLocalidad"].Value)
            {
                MessageBox.Show(
                    "La calle " + direccion.Cells["idEntreCalle2"].Text +
                    " no pertenece a " +
                    direccion.Cells["idLocalidad"].Text + ".", "No se pudo grabar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            if (direccion.Cells["idBarrio"].Value != DBNull.Value &&
                _fp.dsBarrios.BarriosLista.FindByidBarrio((int) direccion.Cells["idBarrio"].Value).
                    idLocalidad != (int) direccion.Cells["idLocalidad"].Value)
            {
                MessageBox.Show(
                   "El barrio " + direccion.Cells["idBarrio"].Text +
                    " no pertenece a " +
                    direccion.Cells["idLocalidad"].Text + ".", "No se pudo grabar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            try
            {
                var row = direccion;
                if (direccion.Cells["idZona"].Value != DBNull.Value &&
                    !(_fp.dsZonas.Zonas.AsEnumerable().Where(
                        z => z.Field<int?>("idZona") == (int) row.Cells["idZona"].Value &&
                             z.IsNull("idLocalidad"))).Any() &&
                    _fp.dsZonas.Zonas.FindByidZona((int) direccion.Cells["idZona"].Value).idLocalidad !=
                    (int) direccion.Cells["idLocalidad"].Value)
                {
                    MessageBox.Show(
                        "La zona " + direccion.Cells["idZona"].Text +
                        " no pertenece a " +
                        direccion.Cells["idLocalidad"].Text + ".", "No se pudo grabar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (NullReferenceException) // La zona no tiene localidad.
            {
            }
            return true;
        }

        private bool VerificarDireccionesDeContratos(UltraGridRow contrato)
        {
            foreach (var direccion in contrato.ChildBands["FK_Direcciones_Contratos"].Rows)
            {
                if (direccion.Cells["idLocalidad"].Value == DBNull.Value) continue;
                if (direccion.Cells["idCalle"].Value != DBNull.Value &&
                    _fp.dsCallesLista.Calles.FindByidCalle((int) direccion.Cells["idCalle"].Value).
                        idLocalidad != (int) direccion.Cells["idLocalidad"].Value)
                {
                    MessageBox.Show(
                        "La calle " + direccion.Cells["idCalle"].Text +
                        " no pertenece a " +
                        direccion.Cells["idLocalidad"].Text + ".", "No se pudo grabar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }
                if (direccion.Cells["idEntreCalle1"].Value != DBNull.Value &&
                    _fp.dsCallesLista.Calles.FindByidCalle((int) direccion.Cells["idEntreCalle1"].Value).
                        idLocalidad != (int) direccion.Cells["idLocalidad"].Value)
                {
                    MessageBox.Show(
                        "La calle " + direccion.Cells["idEntreCalle1"].Text +
                        " no pertenece a " +
                        direccion.Cells["idLocalidad"].Text + ".", "No se pudo grabar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }
                if (direccion.Cells["idEntreCalle2"].Value != DBNull.Value &&
                    _fp.dsCallesLista.Calles.FindByidCalle((int) direccion.Cells["idEntreCalle2"].Value).
                        idLocalidad != (int) direccion.Cells["idLocalidad"].Value)
                {
                    MessageBox.Show(
                        "La calle " + direccion.Cells["idEntreCalle2"].Text +
                        " no pertenece a " +
                        direccion.Cells["idLocalidad"].Text + ".", "No se pudo grabar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }
                if (direccion.Cells["idBarrio"].Value == DBNull.Value ||
                    _fp.dsBarrios.BarriosLista.FindByidBarrio((int) direccion.Cells["idBarrio"].Value).
                        idLocalidad == (int) direccion.Cells["idLocalidad"].Value) continue;
                MessageBox.Show(
                   "El barrio " + direccion.Cells["idBarrio"].Text +
                    " no pertenece a " +
                    direccion.Cells["idLocalidad"].Text + ".", "No se pudo grabar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool Verificar_Contratos(UltraGridRow cadaCliente)
        {
            var contratos = 0;
            foreach (var contrato in cadaCliente.ChildBands["FK_Contratos_Clientes"].Rows)
            {
                contratos++;
                var nombreContrato = contrato.Cells["Nombre"].Text;
                var solicitudes = 0;
                foreach (var solicitud in contrato.ChildBands["FK_Solicitudes_Contratos"].Rows)
                {
                    solicitudes++;

                    /* Validación de otros datos de la Solicitud.*/
                    if (solicitud.Cells["AltaBajaSusp"].Text == "")
                    {
                        MessageBox.Show(this, "Falta el Tipo de Solicitud",
                            "Solicitud de " + nombreContrato,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    if (solicitud.Cells["Fecha"].Text == "")
                    {
                        MessageBox.Show("Falta la Fecha",
                            "Solicitud de " + nombreContrato,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    if (solicitud.Cells["AltaBajaSusp"].Text == "Alta"
                        && solicitud.Cells["idVendedor"].Text == "")
                    {
                        MessageBox.Show("Falta el Vendedor",
                            "Solicitud de Alta de " + nombreContrato,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    if (solicitud.Cells["AltaBajaSusp"].Text == "Baja"
                        && solicitud.Cells["idMotivoDeBaja"].Text == "")
                    {
                        MessageBox.Show(this, "Falta el Motivo de Baja",
                            "Solicitud de Baja de " + nombreContrato,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    if (solicitud.Cells["AltaBajaSusp"].Text == "Baja"
                        && solicitud.Cells["idTomadorDeBaja"].Text == "")
                    {
                        MessageBox.Show("Falta el Tomador de la Baja",
                            "Solicitud de Baja de " + nombreContrato,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return false;
                    }

                    if (solicitud.Cells["AltaBajaSusp"].Text != "Suspensión" ||
                        solicitud.Cells["FechaFinal"].Text != "") continue;
                    MessageBox.Show("Falta la Fecha Final",
                        "Solicitud de Suspensión de " + nombreContrato,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (solicitudes >= 1) continue;
                MessageBox.Show("No tiene ninguna Solicitud",
                    "Contrato " + nombreContrato,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (contratos < 1)
            {
                MessageBox.Show("No hay ningún Contrato.",
                    "Imposible Grabar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool Verificar_IdTipoDeCobranza(UltraGridRow cadaCliente)
        {
            if (cadaCliente.Cells["idTipoDeCobranza"].Value == DBNull.Value)
            {
                MessageBox.Show("Falta el Tipo de Cobranza.",
                    "Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (
                _fp.dsTiposDeCobranza.TiposDeCobranza.FindByidTipoDeCobranza(
                    (int) cadaCliente.Cells["idTipoDeCobranza"].Value).RequiereEntidadDeCobranza)
            {
                if (cadaCliente.Cells["idEntidadDeCobranza"].Value == DBNull.Value)
                {
                    MessageBox.Show("Falta la Entidad de Cobranza.",
                        "Cliente", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }
                if (
                    _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                        (int) cadaCliente.Cells["idEntidadDeCobranza"].Value).RequiereDocTitular &&
                    cadaCliente.Cells["NumeroDocumentoTitularTarjeta"].Value == DBNull.Value)
                {
                    MessageBox.Show("Falta el Documento del Titular de la Tarjeta.",
                        "Entidad de Cobranza",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (
                    _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                        (int) cadaCliente.Cells["idEntidadDeCobranza"].Value).RequiereVencimiento &&
                    cadaCliente.Cells["VencimientoTarjeta"].Value == DBNull.Value)
                {
                    MessageBox.Show("Falta el vencimiento de la Tarjeta.",
                        "Entidad de Cobranza",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (
                    _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                        (int) cadaCliente.Cells["idEntidadDeCobranza"].Value).RequiereNombreTitular &&
                    cadaCliente.Cells["NombreTitularTarjeta"].Value == DBNull.Value)
                {
                    MessageBox.Show("Falta el nombre del Titular de la Tarjeta.",
                        "Entidad de Cobranza",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (
                    _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                        (int) cadaCliente.Cells["idEntidadDeCobranza"].Value).RequiereNumero &&
                    cadaCliente.Cells["NumeroTarjeta"].Value == DBNull.Value)
                {
                    MessageBox.Show("Falta el número de la Tarjeta.",
                        "Entidad de Cobranza",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (
                    _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                        (int) cadaCliente.Cells["idEntidadDeCobranza"].Value).RequiereTelTitular &&
                    cadaCliente.Cells["TelefonoTitularTarjeta"].Value == DBNull.Value)
                {
                    MessageBox.Show("Falta el teléfono del Titular de la Tarjeta.",
                        "Entidad de Cobranza",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (
                    _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                        (int) cadaCliente.Cells["idEntidadDeCobranza"].Value).RequiereSucursal &&
                    cadaCliente.Cells["Sucursal"].Value == DBNull.Value)
                {
                    MessageBox.Show("Falta la Sucursal del Titular de la Tarjeta",
                        "Entidad de Cobranza",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (
                    _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                        (int) cadaCliente.Cells["idEntidadDeCobranza"].Value).RequiereEmpresa &&
                    cadaCliente.Cells["Empresa"].Value == DBNull.Value)
                {
                    MessageBox.Show("Falta la Empresa del Titular de la Tarjeta",
                        "Entidad de Cobranza",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (
                    _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                        (int) cadaCliente.Cells["idEntidadDeCobranza"].Value).RequiereConvenio &&
                    cadaCliente.Cells["Convenio"].Value == DBNull.Value)
                {
                    MessageBox.Show("Falta el Convenio del Titular de la Tarjeta",
                        "Entidad de Cobranza",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (
                    _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                        (int) cadaCliente.Cells["idEntidadDeCobranza"].Value).RequiereJubilado &&
                    cadaCliente.Cells["Jubilado"].Value == DBNull.Value)
                {
                    MessageBox.Show(
                        "Falta el dato de si es Jubilado el Titular de la Tarjeta",
                        "Entidad de Cobranza",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private bool Verificar_CUIT(UltraGridRow cadaCliente)
        {
// Verificación del CUIT
            if (cadaCliente.Cells["CUIT"].Column.Header.Caption == @"DNI")
            {
                if (cadaCliente.Cells["CUIT"].Value == DBNull.Value)
                {
                    MessageBox.Show("Falta el DNI.", "¡Atención!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            if 
                //(
                (cadaCliente.Cells["CUIT"].Value == DBNull.Value ||
                 cadaCliente.Cells["CUIT"].Text == "__-__,___,___-_" || cadaCliente.Cells["CUIT"].Text == "")
                // &&
                //_fp.dsCategoriasIVA.CategoriasIVA.FindByidCategoriaIVA(ultraDropDownCategoriasIVA.SelectedRow ==
                //                                                       null
                //    ? (int)
                //        cadaCliente.Cells["idCategoriaIva"].
                //            Value
                //    : (int)
                //        ultraDropDownCategoriasIVA.SelectedRow.
                //            Cells["idCategoriaIva"].Value).
                //    ExigeCUIT.ToString(CultureInfo.InvariantCulture) == "True")
            {
                MessageBox.Show("Falta el CUIT.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cadaCliente.Cells["CUIT"].Text != "__-__,___,___-_" && cadaCliente.Cells["CUIT"].Text != "")
            {
                // Validación del CUIT, que no esté ingresado.
                var sCUIT = cadaCliente.Cells["CUIT"].Text.Replace(",", "").Replace("-", "");
                if ((int) _fp.dscuitRepetibles.CUITRepetibles.Compute("Count(CUIT)", "CUIT = " + sCUIT) == 0)
                {
                    var nombClienteAnterior = new Service().NombreCuitIngresado(sCUIT,
                        (int)
                            cadaCliente.Cells["idCliente"].Value,
                        Program.Pin);
                    if (nombClienteAnterior.Length > 0)
                    {
                        MessageBox.Show(this,
                           "El CUIT " + cadaCliente.Cells["CUIT"].Text +
                            " ya figura en nuestros registros" +
                            Environment.NewLine + "perteneciendo a " +
                            nombClienteAnterior +
                            "." +
                            Environment.NewLine + Environment.NewLine +
                            "No podemos ingresarlo otra vez." + Environment.NewLine +
                            Environment.NewLine + "Puede agregar una Solicitud de Alta" +
                            Environment.NewLine + "vía modificación de Clientes.",
                            "CUIT",
                            MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                    /*Validación del CUIT, que sea válido*/

                    if (sCUIT.Length == 11)
                    {
                        var xa = int.Parse(sCUIT.Substring(0, 1))*5;
                        var xb = int.Parse(sCUIT.Substring(1, 1))*4;
                        var xc = int.Parse(sCUIT.Substring(2, 1))*3;
                        var xd = int.Parse(sCUIT.Substring(3, 1))*2;
                        var xe = int.Parse(sCUIT.Substring(4, 1))*7;
                        var xf = int.Parse(sCUIT.Substring(5, 1))*6;
                        var xg = int.Parse(sCUIT.Substring(6, 1))*5;
                        var xh = int.Parse(sCUIT.Substring(7, 1))*4;
                        var xi = int.Parse(sCUIT.Substring(8, 1))*3;
                        var xj = int.Parse(sCUIT.Substring(9, 1))*2;
                        var x = xa + xb + xc + xd + xe + xf + xg + xh + xi + xj;
                        var control = (11 - (x%11))%11;
                        if (control != int.Parse(sCUIT.Substring(10, 1)))
                        {
                            MessageBox.Show("Inválido",
                                "Falta verificar el CUIT",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private bool Updatear()
        {
            var aux = new Service().UpdateCliente(dsClientes, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(this, "No se pudo grabar.", "¡Atención!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            dsClientes.Merge(aux);
            ManejoDatos.AplicarUpdate(dsClientes);
            new Service().ActualizarClienteActivo((int) dsClientes.Clientes.Rows[0]["idCliente"], Program.Pin);
            return true;
        }

        #endregion

        #region Botones

        private void ButtonAplicarClick(object sender, EventArgs e)
        {
            var verificado = Verificar();
            if (!verificado) return;
            var updateado = Updatear();
            if (updateado)
            {
                buttonAplicar.Enabled = false;
            }
            _fp.dsBarrios.Merge(new Service().GetBarriosLista(Program.Pin));
            dsContratosLista.Merge(
                new Service().GetContratosRenglonFactura((int) clientesUltraGrid.Rows[0].Cells["idCliente"].Value,
                    Program.Pin));
            dsContratosLista.Merge(
                new Service().GetPlanesRenglonFactura((int) clientesUltraGrid.Rows[0].Cells["idCliente"].Value,
                    Program.Pin));
            clientesUltraGrid.Rows.ExpandAll(true);
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if (buttonAplicar.Enabled)
            {
                var verificado = Verificar();
                if (!verificado) return;
                var updateado = Updatear();
                if (!updateado) return;
                buttonAplicar.Enabled = false;
                if (_salir)
                    Close();
                else
                {
                    _fp.dsBarrios.Merge(new Service().GetBarriosLista(Program.Pin));
                    dsContratosLista.Merge(
                        new Service().GetContratosRenglonFactura(
                            (int) clientesUltraGrid.Rows[0].Cells["idCliente"].Value,
                            Program.Pin));
                    dsContratosLista.Merge(
                        new Service().GetPlanesRenglonFactura(
                            (int) clientesUltraGrid.Rows[0].Cells["idCliente"].Value,
                            Program.Pin));
                    clientesUltraGrid.Rows.ExpandAll(true);
                }
            }
            else
            {
                Close();
            }
        }

        private void ButtonSalirClick(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Eventos clientesUltraGrid

        private void ClientesUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            if (clientesUltraGrid.ActiveCell.Column.DataType.ToString() == "System.Boolean") return;
                clientesUltraGrid.ActiveCell.SelStart = 0;
        }

        private void ClientesUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void ClientesUltraGridBeforeRowDeactivate(object sender, CancelEventArgs e)
        {
            var renglonActivo = clientesUltraGrid.ActiveRow;
            if (renglonActivo.Band.Key == "FK_EmailsClientes_Clientes" || renglonActivo.Band.Key == "FK_Emails_Contactos")
            {
                if (ManejoDatos.IsValidEmail(renglonActivo.Cells["Email"].Value.ToString()) == false)
                {
                    e.Cancel = true;
                    MessageBox.Show(
                        "No es una dirección de e-mail válida.",
                        "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            BeforeRowDeactivate_Solicitudes(e, renglonActivo);
                // if (renglonActivo.Band.Key == "FK_Solicitudes_Contratos")
            BeforeRowDeactivate_Clientes(e, renglonActivo); // if (renglonActivo.Band.Key == "Clientes")
            if (renglonActivo.Band.Key == "FK_FacturasProforma_Clientes")
            {
                if (renglonActivo.Cells["idTandaDeFacturacion"].Value == DBNull.Value)
                {
                    MessageBox.Show(
                        "Falta la Tanda de Facturación",
                        "Faltan Datos", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    e.Cancel = true;
                }
                if (renglonActivo.Band.Key == "FK_Contratos_Clientes")
                {
                    if (renglonActivo.Cells["idNegocio"].Value == DBNull.Value && (bool)dsParametros.Parametros.Rows[0]["UsaNegocios"])
                    {
                        MessageBox.Show(
                            "Falta el Negocio.",
                            "Faltan Datos", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                }
            }
            if (renglonActivo.Band.Key == "FK_RenglonesFacturaProforma_FacturasProforma")
            {
                if (renglonActivo.Cells["idPorcentajeIVA"].Value == DBNull.Value)
                {
                    e.Cancel = true;
                    MessageBox.Show(
                        "Falta el porcentaje de IVA.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BeforeRowDeactivate_Clientes(CancelEventArgs e, UltraGridRow renglonActivo)
        {
            if (renglonActivo.Band.Key == "Clientes")
            {
                if (renglonActivo.Cells["idCategoriaIva"].Value == DBNull.Value)
                {
                    e.Cancel = true;
                    MessageBox.Show(
                        "Falta la Categoría de IVA.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //else
                //{
                //    if ((renglonActivo.Cells["CUIT"].Value == DBNull.Value ||
                //         renglonActivo.Cells["CUIT"].Text == "__-__,___,___-_" || renglonActivo.Cells["CUIT"].Text == "") &&
                //        _fp.dsCategoriasIVA.CategoriasIVA.FindByidCategoriaIVA(ultraDropDownCategoriasIVA.SelectedRow ==
                //                                                               null
                //            ? (int)
                //                renglonActivo.Cells[
                //                    "idCategoriaIva"].Value
                //            : (int)
                //                ultraDropDownCategoriasIVA.
                //                    SelectedRow.Cells[
                //                        "idCategoriaIva"].Value).
                //            ExigeCUIT.ToString(CultureInfo.InvariantCulture) == "True")
                //    {
                //        e.Cancel = true;
                //        MessageBox.Show(Resources.FormClientes_ClientesUltraGridBeforeRowDeactivate_Falta_el_CUIT_,
                //            "Error",
                //            MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //}
                if (renglonActivo.Cells["CUIT"].Value == DBNull.Value ||
                    renglonActivo.Cells["CUIT"].Text == "__-__,___,___-_" || renglonActivo.Cells["CUIT"].Text == "")
                {
                    e.Cancel = true;
                    MessageBox.Show("Falta el CUIT.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                BeforeRowDeactivateClientes_IdTipoDeCobranza(e, renglonActivo);
                    // if (renglonActivo.Cells["idTipoDeCobranza"].Value == DBNull.Value)
            }
        }

        private void BeforeRowDeactivateClientes_IdTipoDeCobranza(CancelEventArgs e, UltraGridRow renglonActivo)
        {
            if (renglonActivo.Cells["idTipoDeCobranza"].Value == DBNull.Value)
            {
                MessageBox.Show("Falta el Tipo de Cobranza.", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else
            {
                if (
                    _fp.dsTiposDeCobranza.TiposDeCobranza.FindByidTipoDeCobranza(
                        (int) renglonActivo.Cells["idTipoDeCobranza"].Value).RequiereEntidadDeCobranza)
                {
                    if (renglonActivo.Cells["idEntidadDeCobranza"].Value == DBNull.Value)
                    {
                        MessageBox.Show("Falta la Entidad de Cobranza.", "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    else
                    {
                        if (
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereNumero &&
                            renglonActivo.Cells["NumeroTarjeta"].Value == DBNull.Value)
                        {
                            MessageBox.Show("Falta el número de la Tarjeta.",
                                "Entidad de Cobranza",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            e.Cancel = true;
                        }
                        else
                        {
                            if (
                                _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                    (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereVencimiento &&
                                renglonActivo.Cells["VencimientoTarjeta"].Value == DBNull.Value)
                            {
                                MessageBox.Show("Falta el vencimiento de la Tarjeta.",
                                    "Entidad de Cobranza",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                e.Cancel = true;
                            }
                            else
                            {
                                if (
                                    _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                        (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).
                                        RequiereNombreTitular &&
                                    renglonActivo.Cells["NombreTitularTarjeta"].Value == DBNull.Value)
                                {
                                    MessageBox.Show(
                                        "Falta el nombre del Titular de la Tarjeta.",
                                        "Entidad de Cobranza", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                                    e.Cancel = true;
                                }
                                else
                                {
                                    if (
                                        _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                            (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).
                                            RequiereDocTitular &&
                                        renglonActivo.Cells["NumeroDocumentoTitularTarjeta"].Value == DBNull.Value)
                                    {
                                        MessageBox.Show(
                                            "Falta el Documento del Titular de la Tarjeta.",
                                            "Entidad de Cobranza", MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                                        e.Cancel = true;
                                    }
                                    else
                                    {
                                        if (
                                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).
                                                RequiereTelTitular &&
                                            renglonActivo.Cells["TelefonoTitularTarjeta"].Value == DBNull.Value)
                                        {
                                            MessageBox.Show(
                                                "Falta el teléfono del Titular de la Tarjeta.",
                                                "Entidad de Cobranza",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                                            e.Cancel = true;
                                        }
                                        if (
                                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereSucursal &&
                                            renglonActivo.Cells["Sucursal"].Value == DBNull.Value)
                                        {
                                            MessageBox.Show(
                                                "Falta la Sucursal del Titular de la Tarjeta",
                                                "Entidad de Cobranza",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            e.Cancel = true;
                                        }
                                        if (
                                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereEmpresa &&
                                            renglonActivo.Cells["Empresa"].Value == DBNull.Value)
                                        {
                                            MessageBox.Show(
                                                "Falta la Empresa del Titular de la Tarjeta",
                                                "Entidad de Cobranza",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            e.Cancel = true;
                                        }
                                        if (
                                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereConvenio &&
                                            renglonActivo.Cells["Convenio"].Value == DBNull.Value)
                                        {
                                            MessageBox.Show(
                                                "Falta el Convenio del Titular de la Tarjeta",
                                                "Entidad de Cobranza",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            e.Cancel = true;
                                        }
                                        if (
                                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereJubilado &&
                                            renglonActivo.Cells["Jubilado"].Value == DBNull.Value)
                                        {
                                            MessageBox.Show(
                                                "Falta el dato de si es Jubilado el Titular de la Tarjeta",
                                                "Entidad de Cobranza",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            e.Cancel = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void BeforeRowDeactivate_Solicitudes(CancelEventArgs e, UltraGridRow renglonActivo)
        {
            if (renglonActivo.Band.Key == "FK_Solicitudes_Contratos")
            {
                if (renglonActivo.Cells["AltaBajaSusp"].Text == "Alta"
                    && renglonActivo.Cells["idVendedor"].Text == "")
                {
                    e.Cancel = true;
                    MessageBox.Show("Falta el Vendedor", "Imposible Grabar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                if (renglonActivo.Cells["AltaBajaSusp"].Text == "Baja"
                    && renglonActivo.Cells["idMotivoDeBaja"].Text == "")
                {
                    e.Cancel = true;
                    MessageBox.Show(this, "Falta el Motivo de Baja",
                        "Imposible Grabar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                if (renglonActivo.Cells["AltaBajaSusp"].Text == "Baja"
                    && renglonActivo.Cells["idTomadorDeBaja"].Text == "")
                {
                    e.Cancel = true;
                    MessageBox.Show("Falta el Tomador de la Baja",
                        "Solicitud de Baja",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                if (renglonActivo.Cells["AltaBajaSusp"].Text == "Suspensión"
                    && renglonActivo.Cells["FechaFinal"].Text == "")
                {
                    e.Cancel = true;
                    MessageBox.Show("Falta la Fecha Final",
                        "Imposible Grabar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void ClientesUltraGridBeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
        {
            var renglonActivo = clientesUltraGrid.ActiveRow;
            if (renglonActivo.Band.Key != "FK_Solicitudes_Contratos") return;
            if ((int) renglonActivo.Cells["idsolicitud"].Value <= 0) return;
            e.Cancel = true;
            MessageBox.Show(this,
                "No se puede borrar una solicitud que ha sido confirmada.",
                "Solicitud",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ClientesUltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            var renglonActivo = e.Row;
            ClientesUltraGridInitializeRow_Solicitudes(renglonActivo);
            ClientesUltraGridInitializeRow_Clientes(renglonActivo);
            if (e.Row.Band.Key == "FK_Contratos_Clientes")
                if ((bool) dsParametros.Parametros.Rows[0]["UsaNegocios"] == false)
                    e.Row.Cells["idNegocio"].Hidden = true;
            if (e.Row.Band.Key == "FK_Solicitudes_Contratos" && e.Row.Cells["idsolicitud"].Value != null &&
                (int) e.Row.Cells["idsolicitud"].Value > 0)
            {
                e.Row.Activation = Activation.NoEdit;
            }
            if (e.Row.Band.Key != "FK_RenglonesFacturaProforma_FacturasProforma") return;
            if (e.Row.Cells["idContrato"].Value == DBNull.Value) return;
            if (renglonActivo == null) return;
            var cantPlanes = (from pl in dsClientes.Planes.AsEnumerable()
                where
                    pl.Field<int?>("idContrato") == (int) renglonActivo.Cells["idContrato"].Value
                select pl).Count();
            if (cantPlanes == 0)
            {
                e.Row.Cells["idPlan"].Hidden = true;
                e.Row.Cells["Titulares"].Hidden = true;
                e.Row.Cells["idPlan"].Value = DBNull.Value;
                e.Row.Cells["PrecioUnitario"].Hidden = false;
                if (
                    dsContratosLista.ContratosRenglonFactura.FindByidContrato(
                        (int) e.Row.Cells["idContrato"].Value).idTipoDeContrato == 2)
                {
                    e.Row.Cells["Cantidad"].Hidden = false;
                }
                else
                {
                    e.Row.Cells["Cantidad"].Hidden = true;
                    e.Row.Cells["Cantidad"].Value = DBNull.Value;
                }
            }
            else
            {
                e.Row.Cells["idPlan"].Hidden = false;
                e.Row.Cells["Titulares"].Hidden = false;
                if (e.Row.Cells["idPlan"].Value != DBNull.Value &&
                    dsClientes.Planes.FindByidPlan((int) e.Row.Cells["idPlan"].Value).PadronExterno)
                {
                    e.Row.Cells["PrecioUnitario"].Hidden = true;
                    e.Row.Cells["Cantidad"].Hidden = false;
                }
                else
                {
                    e.Row.Cells["PrecioUnitario"].Hidden = true;
                    e.Row.Cells["PrecioUnitario"].Value = DBNull.Value;
                    e.Row.Cells["Cantidad"].Hidden = true;
                    e.Row.Cells["Cantidad"].Value = DBNull.Value;
                }
            }
        }

        private void ClientesUltraGridInitializeRow_Clientes(UltraGridRow renglonActivo)
        {
            if (renglonActivo != null && renglonActivo.Band.Key == "Clientes")
            {
                renglonActivo.ToolTipText = "Doble click para cambiar a DNI.";
                if (renglonActivo.Cells["idTipoDeCobranza"].Value != DBNull.Value)
                {
                    if (
                        _fp.dsTiposDeCobranza.TiposDeCobranza.FindByidTipoDeCobranza(
                            (int) renglonActivo.Cells["idTipoDeCobranza"].Value).RequiereEntidadDeCobranza != true)
                    {
                        renglonActivo.Cells["idEntidadDeCobranza"].Hidden = true;
                        renglonActivo.Cells["NumeroDocumentoTitularTarjeta"].Hidden = true;
                        renglonActivo.Cells["NombreTitularTarjeta"].Hidden = true;
                        renglonActivo.Cells["NumeroTarjeta"].Hidden = true;
                        renglonActivo.Cells["TelefonoTitularTarjeta"].Hidden = true;
                        renglonActivo.Cells["VencimientoTarjeta"].Hidden = true;
                        renglonActivo.Cells["Sucursal"].Hidden = true;
                        renglonActivo.Cells["Empresa"].Hidden = true;
                        renglonActivo.Cells["Convenio"].Hidden = true;
                        renglonActivo.Cells["Jubilado"].Hidden = true;
                        renglonActivo.Cells["Cobrador"].Value = Cobrador();
                        renglonActivo.Cells["Cobrador"].Hidden = (int) renglonActivo.Cells["idTipoDeCobranza"].Value !=
                                                                 1;
                    }
                    else
                    {
                        if (renglonActivo.Cells["idEntidadDeCobranza"].Value != DBNull.Value &&
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereDocTitular)
                        {
                            renglonActivo.Cells["NumeroDocumentoTitularTarjeta"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["NumeroDocumentoTitularTarjeta"].Hidden = true;
                        }
                        if (renglonActivo.Cells["idEntidadDeCobranza"].Value != DBNull.Value &&
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereNombreTitular)
                        {
                            renglonActivo.Cells["NombreTitularTarjeta"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["NombreTitularTarjeta"].Hidden = true;
                        }
                        if (renglonActivo.Cells["idEntidadDeCobranza"].Value != DBNull.Value &&
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereNumero)
                        {
                            renglonActivo.Cells["NumeroTarjeta"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["NumeroTarjeta"].Hidden = true;
                        }
                        if (renglonActivo.Cells["idEntidadDeCobranza"].Value != DBNull.Value &&
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereTelTitular)
                        {
                            renglonActivo.Cells["TelefonoTitularTarjeta"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["TelefonoTitularTarjeta"].Hidden = true;
                        }
                        if (renglonActivo.Cells["idEntidadDeCobranza"].Value != DBNull.Value &&
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereSucursal)
                        {
                            renglonActivo.Cells["Sucursal"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["Sucursal"].Hidden = true;
                        }
                        if (renglonActivo.Cells["idEntidadDeCobranza"].Value != DBNull.Value &&
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereEmpresa)
                        {
                            renglonActivo.Cells["Empresa"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["Empresa"].Hidden = true;
                        }
                        if (renglonActivo.Cells["idEntidadDeCobranza"].Value != DBNull.Value &&
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereConvenio)
                        {
                            renglonActivo.Cells["Convenio"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["Convenio"].Hidden = true;
                        }
                        if (renglonActivo.Cells["idEntidadDeCobranza"].Value != DBNull.Value &&
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereJubilado)
                        {
                            renglonActivo.Cells["Jubilado"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["Jubilado"].Hidden = true;
                        }
                        if (renglonActivo.Cells["idEntidadDeCobranza"].Value != DBNull.Value &&
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereVencimiento)
                        {
                            renglonActivo.Cells["VencimientoTarjeta"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["VencimientoTarjeta"].Hidden = true;
                        }
                    }
                }
            }
        }

        private static void ClientesUltraGridInitializeRow_Solicitudes(UltraGridRow renglonActivo)
        {
            if (renglonActivo != null && renglonActivo.Band.Key == "FK_Solicitudes_Contratos")
            {
                if (renglonActivo.Cells["AltaBajaSusp"].Text == "Alta")
                {
                    renglonActivo.Cells["idVendedor"].Hidden = false;
                    renglonActivo.Cells["Renovacion"].Hidden = false;
                }
                else
                {
                    renglonActivo.Cells["idVendedor"].Value = DBNull.Value;
                    renglonActivo.Cells["idVendedor"].Hidden = true;
                    renglonActivo.Cells["Renovacion"].Value = DBNull.Value;
                    renglonActivo.Cells["Renovacion"].Hidden = true;
                }

                if (renglonActivo.Cells["AltaBajaSusp"].Text == "Baja")
                {
                    renglonActivo.Cells["idMotivoDeBaja"].Hidden = false;
                    renglonActivo.Cells["idTomadorDeBaja"].Hidden = false;
                }
                else
                {
                    renglonActivo.Cells["idMotivoDeBaja"].Value = DBNull.Value;
                    renglonActivo.Cells["idMotivoDeBaja"].Hidden = true;
                    renglonActivo.Cells["idTomadorDeBaja"].Value = DBNull.Value;
                    renglonActivo.Cells["idTomadorDeBaja"].Hidden = true;
                }

                if (renglonActivo.Cells["AltaBajaSusp"].Text == "Suspensión")
                {
                    renglonActivo.Cells["FechaFinal"].Hidden = false;
                }
                else
                {
                    renglonActivo.Cells["FechaFinal"].Value = DBNull.Value;
                    renglonActivo.Cells["FechaFinal"].Hidden = true;
                }
            }
        }

        private void ClientesUltraGridCellChange(object sender, CellEventArgs e)
        {
            var renglonActivo = clientesUltraGrid.ActiveRow;
            var celdaActiva = clientesUltraGrid.ActiveCell;
            //if (renglonActivo != null && celdaActiva != null && renglonActivo.Band.Key == "Clientes" &&
            //    celdaActiva.Column.Key == "idCategoriaIva")
            //{
            //    var exigeCUIT =
            //        _fp.dsCategoriasIVA.CategoriasIVA.FindByidCategoriaIVA(ultraDropDownCategoriasIVA.SelectedRow ==
            //                                                               null
            //            ? (int)celdaActiva.Value
            //            : (int)
            //                ultraDropDownCategoriasIVA.SelectedRow.
            //                    Cells["idCategoriaIva"].Value).
            //            ExigeCUIT.ToString(CultureInfo.InvariantCulture);
            //    if (exigeCUIT == "True")
            //    {
            //        renglonActivo.Cells["CUIT"].Hidden = false;
            //    }
            //    else
            //    {
            //        renglonActivo.Cells["CUIT"].Hidden = true;
            //        renglonActivo.Cells["CUIT"].Column.TabStop = false;
            //        renglonActivo.Cells["CUIT"].Value = DBNull.Value;
            //    }
            //}
            if (renglonActivo != null && renglonActivo.Band.Key == "FK_Solicitudes_Contratos")
            {
                if (renglonActivo.Cells["AltaBajaSusp"].Text == "Alta")
                {
                    renglonActivo.Cells["idVendedor"].Hidden = false;
                    renglonActivo.Cells["Renovacion"].Hidden = false;
                }
                else
                {
                    renglonActivo.Cells["idVendedor"].Value = DBNull.Value;
                    renglonActivo.Cells["idVendedor"].Hidden = true;
                    renglonActivo.Cells["Renovacion"].Value = DBNull.Value;
                    renglonActivo.Cells["Renovacion"].Hidden = true;
                }

                if (renglonActivo.Cells["AltaBajaSusp"].Text == "Baja")
                {
                    renglonActivo.Cells["idMotivoDeBaja"].Hidden = false;
                    renglonActivo.Cells["idTomadorDeBaja"].Hidden = false;
                }
                else
                {
                    renglonActivo.Cells["idMotivoDeBaja"].Value = DBNull.Value;
                    renglonActivo.Cells["idMotivoDeBaja"].Hidden = true;
                    renglonActivo.Cells["idTomadorDeBaja"].Value = DBNull.Value;
                    renglonActivo.Cells["idTomadorDeBaja"].Hidden = true;
                }

                if (renglonActivo.Cells["AltaBajaSusp"].Text == "Suspensión")
                {
                    renglonActivo.Cells["FechaFinal"].Hidden = false;
                }
                else
                {
                    renglonActivo.Cells["FechaFinal"].Value = DBNull.Value;
                    renglonActivo.Cells["FechaFinal"].Hidden = true;
                }
            }
            if (renglonActivo != null && renglonActivo.Band.Key == "Clientes")
            {
                if (celdaActiva != null && celdaActiva.Column.Key == "idTipoDeCobranza")
                {
                    renglonActivo.Update();
                    if (
                        _fp.dsTiposDeCobranza.TiposDeCobranza.FindByidTipoDeCobranza(
                            ultraDropDownTiposDeCobranza.SelectedRow == null
                                ? (int) celdaActiva.Value
                                : (int) ultraDropDownTiposDeCobranza.SelectedRow.Cells["idTipoDeCobranza"].Value).
                            RequiereEntidadDeCobranza)
                    {
                        renglonActivo.Cells["Cobrador"].Hidden = true;
                        renglonActivo.Cells["idEntidadDeCobranza"].Hidden = false;
                        if (renglonActivo.Cells["idEntidadDeCobranza"].Value != DBNull.Value &&
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereDocTitular)
                        {
                            renglonActivo.Cells["NumeroDocumentoTitularTarjeta"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["NumeroDocumentoTitularTarjeta"].Hidden = true;
                        }
                        if (renglonActivo.Cells["idEntidadDeCobranza"].Value != DBNull.Value &&
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereNombreTitular)
                        {
                            renglonActivo.Cells["NombreTitularTarjeta"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["NombreTitularTarjeta"].Hidden = true;
                        }
                        if (renglonActivo.Cells["idEntidadDeCobranza"].Value != DBNull.Value &&
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereNumero)
                        {
                            renglonActivo.Cells["NumeroTarjeta"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["NumeroTarjeta"].Hidden = true;
                        }
                        if (renglonActivo.Cells["idEntidadDeCobranza"].Value != DBNull.Value &&
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereTelTitular)
                        {
                            renglonActivo.Cells["TelefonoTitularTarjeta"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["TelefonoTitularTarjeta"].Hidden = true;
                        }
                        if (renglonActivo.Cells["idEntidadDeCobranza"].Value != DBNull.Value &&
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereSucursal)
                        {
                            renglonActivo.Cells["Sucursal"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["Sucursal"].Hidden = true;
                        }
                        if (renglonActivo.Cells["idEntidadDeCobranza"].Value != DBNull.Value &&
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereEmpresa)
                        {
                            renglonActivo.Cells["Empresa"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["Empresa"].Hidden = true;
                        }
                        if (renglonActivo.Cells["idEntidadDeCobranza"].Value != DBNull.Value &&
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereConvenio)
                        {
                            renglonActivo.Cells["Convenio"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["Convenio"].Hidden = true;
                        }
                        if (renglonActivo.Cells["idEntidadDeCobranza"].Value != DBNull.Value &&
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereJubilado)
                        {
                            renglonActivo.Cells["Jubilado"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["Jubilado"].Hidden = true;
                        }
                        if (renglonActivo.Cells["idEntidadDeCobranza"].Value != DBNull.Value &&
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereVencimiento)
                        {
                            renglonActivo.Cells["VencimientoTarjeta"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["VencimientoTarjeta"].Hidden = true;
                        }
                    }
                    else // No requiere Entidad de Cobranza
                    {
                        renglonActivo.Cells["idEntidadDeCobranza"].Hidden = true;
                        renglonActivo.Cells["NumeroDocumentoTitularTarjeta"].Hidden = true;
                        renglonActivo.Cells["NombreTitularTarjeta"].Hidden = true;
                        renglonActivo.Cells["NumeroTarjeta"].Hidden = true;
                        renglonActivo.Cells["TelefonoTitularTarjeta"].Hidden = true;
                        renglonActivo.Cells["Sucursal"].Hidden = true;
                        renglonActivo.Cells["Empresa"].Hidden = true;
                        renglonActivo.Cells["Convenio"].Hidden = true;
                        renglonActivo.Cells["Jubilado"].Hidden = true;
                        renglonActivo.Cells["VencimientoTarjeta"].Hidden = true;
                        renglonActivo.Cells["Cobrador"].Hidden = (int) celdaActiva.Value != 1;
                    }
                }
                if (celdaActiva != null && celdaActiva.Column.Key == "idEntidadDeCobranza")
                {
                    renglonActivo.Cells["NumeroDocumentoTitularTarjeta"].Hidden =
                        !_fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                            ultraDropDownEntidadesDeCobranza.SelectedRow == null
                                ? (int) celdaActiva.Value
                                : (int) ultraDropDownEntidadesDeCobranza.SelectedRow.Cells["idEntidadDeCobranza"].Value)
                            .RequiereDocTitular;
                    if (ultraDropDownEntidadesDeCobranza.SelectedRow != null)
                    {
                        renglonActivo.Cells["NombreTitularTarjeta"].Hidden =
                            !_fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) ultraDropDownEntidadesDeCobranza.SelectedRow.Cells["idEntidadDeCobranza"].Value).
                                RequiereNombreTitular;
                        if (_fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                            (int) ultraDropDownEntidadesDeCobranza.SelectedRow.Cells["idEntidadDeCobranza"].Value).
                            RequiereNumero)
                        {
                            renglonActivo.Cells["NumeroTarjeta"].Hidden = false;
                            renglonActivo.Cells["NumeroTarjeta"].Column.MaskInput = _fp.dsEntidadesDeCobranza.
                                EntidadesDeCobranza.
                                FindByidEntidadDeCobranza(
                                    (int)
                                        ultraDropDownEntidadesDeCobranza
                                            .SelectedRow.Cells[
                                                "idEntidadDeCobranza"].Value)
                                .
                                MascaraTarjeta.Length == 0
                                ? null
                                : _fp.dsEntidadesDeCobranza.
                                    EntidadesDeCobranza.
                                    FindByidEntidadDeCobranza(
                                        (int)
                                            ultraDropDownEntidadesDeCobranza
                                                .SelectedRow.Cells[
                                                    "idEntidadDeCobranza"]
                                                .Value).
                                    MascaraTarjeta;
                        }
                        else
                        {
                            renglonActivo.Cells["NumeroTarjeta"].Hidden = true;
                        }
                        renglonActivo.Cells["TelefonoTitularTarjeta"].Hidden =
                            !_fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int)
                                    ultraDropDownEntidadesDeCobranza.SelectedRow.Cells["idEntidadDeCobranza"].Value)
                                .RequiereTelTitular;
                        renglonActivo.Cells["Sucursal"].Hidden =
                            !_fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int)
                                    ultraDropDownEntidadesDeCobranza.SelectedRow.Cells["idEntidadDeCobranza"].Value)
                                .RequiereSucursal;
                        renglonActivo.Cells["Empresa"].Hidden =
                            !_fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int)
                                    ultraDropDownEntidadesDeCobranza.SelectedRow.Cells["idEntidadDeCobranza"].Value)
                                .RequiereEmpresa;
                        renglonActivo.Cells["Convenio"].Hidden =
                            !_fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int)
                                    ultraDropDownEntidadesDeCobranza.SelectedRow.Cells["idEntidadDeCobranza"].Value)
                                .RequiereConvenio;
                        renglonActivo.Cells["Jubilado"].Hidden =
                            !_fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int)
                                    ultraDropDownEntidadesDeCobranza.SelectedRow.Cells["idEntidadDeCobranza"].Value)
                                .RequiereJubilado;
                        renglonActivo.Cells["VencimientoTarjeta"].Hidden =
                            !_fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int)
                                    ultraDropDownEntidadesDeCobranza.SelectedRow.Cells["idEntidadDeCobranza"].Value)
                                .RequiereVencimiento;
                    }
                }
            }
            if (renglonActivo != null && renglonActivo.Band.Key == "FK_RenglonesFacturaProforma_FacturasProforma")
            {
                if (celdaActiva != null && celdaActiva.Column.Key == "idContrato")
                {
                    renglonActivo.Update();
                    var condicion = "idContrato = " + celdaActiva.Value;
                    var cantPlanes = (int) dsClientes.Planes.Compute("Count(idContrato)", condicion);
                    if (cantPlanes == 0)
                    {
                        renglonActivo.Cells["idPlan"].Hidden = true;
                        renglonActivo.Cells["Titulares"].Hidden = true;
                        renglonActivo.Cells["idPlan"].Value = DBNull.Value;
                        renglonActivo.Cells["PrecioUnitario"].Hidden = false;
                        if (dsClientes.Contratos.FindByidContrato((int) celdaActiva.Value).idTipoDeContrato == 2)
                        {
                            renglonActivo.Cells["Cantidad"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["Cantidad"].Hidden = true;
                            renglonActivo.Cells["Cantidad"].Value = DBNull.Value;
                        }
                    }
                    else
                    {
                        renglonActivo.Cells["idPlan"].Hidden = false;
                        renglonActivo.Cells["Titulares"].Hidden = false;
                        if (renglonActivo.Cells["idPlan"].Value != DBNull.Value &&
                            dsClientes.Planes.FindByidPlan((int) renglonActivo.Cells["idPlan"].Value).PadronExterno)
                        {
                            renglonActivo.Cells["PrecioUnitario"].Hidden = true;
                            renglonActivo.Cells["Cantidad"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["PrecioUnitario"].Hidden = true;
                            renglonActivo.Cells["PrecioUnitario"].Value = DBNull.Value;
                            renglonActivo.Cells["Cantidad"].Hidden = true;
                            renglonActivo.Cells["Cantidad"].Value = DBNull.Value;
                        }
                    }
                }
            }
            if (e.Cell.Column.Key == "idZona")
            {
                clientesUltraGrid.ActiveRow.Update();
                clientesUltraGrid.Rows[0].Cells["Cobrador"].Value = Cobrador();
            }
            if (e.Cell.Column.Key != "idLocalidad") return;
            ultraDropDownZonas.DisplayLayout.RefreshFilters();
            ultraDropDownBarrios.DisplayLayout.RefreshFilters();
            ultraDropDownCalle.DisplayLayout.RefreshFilters();
        }

        private void ClientesUltraGridBeforeExitEditMode(object sender, BeforeExitEditModeEventArgs e)
        {
            // Expande
            if (clientesUltraGrid.ActiveRow.IsExpandable)
            {
                clientesUltraGrid.ActiveRow.ExpandAll();
            }

            if (clientesUltraGrid.ActiveCell.Band.Key == "Clientes" &&
                clientesUltraGrid.ActiveCell.Column.Key == "CUIT" && clientesUltraGrid.ActiveCell.Column.Header.Caption == @"CUIT")
            {
                if (clientesUltraGrid.ActiveCell.Text != "__-__,___,___-_")
                {
                    // Validación del CUIT, que no esté ingresado.
                    var sCUIT = clientesUltraGrid.ActiveCell.Text.Replace(",", "").Replace("-", "");
                    if ((int) _fp.dscuitRepetibles.CUITRepetibles.Compute("Count(CUIT)", "CUIT = " + sCUIT) == 0)
                    {
                        var nombClienteAnterior = new Service().NombreCuitIngresado(sCUIT,
                            (int)
                                clientesUltraGrid.ActiveRow.Cells
                                    [0].Value, Program.Pin);
                        if (nombClienteAnterior.Length > 0)
                        {
                            e.Cancel = true;
                            MessageBox.Show(this,
                                "El CUIT " + clientesUltraGrid.ActiveCell.Text +
                                " ya figura en nuestros registros" + Environment.NewLine +
                                "perteneciendo a " + nombClienteAnterior +
                                "." +
                                Environment.NewLine +
                                Environment.NewLine + "No podemos ingresarlo otra vez." +
                                Environment.NewLine + Environment.NewLine +
                                "Puede agregar una Solicitud de Alta" +
                                Environment.NewLine +
                                "vía modificación de Clientes.",
                                "Falta verificar el CUIT", MessageBoxButtons.OK,
                                MessageBoxIcon.Stop);
                        }
                        /*Validación del CUIT, que sea válido*/

                        if (sCUIT.Length == 11)
                        {
                            var xa = int.Parse(sCUIT.Substring(0, 1))*5;
                            var xb = int.Parse(sCUIT.Substring(1, 1))*4;
                            var xc = int.Parse(sCUIT.Substring(2, 1))*3;
                            var xd = int.Parse(sCUIT.Substring(3, 1))*2;
                            var xe = int.Parse(sCUIT.Substring(4, 1))*7;
                            var xf = int.Parse(sCUIT.Substring(5, 1))*6;
                            var xg = int.Parse(sCUIT.Substring(6, 1))*5;
                            var xh = int.Parse(sCUIT.Substring(7, 1))*4;
                            var xi = int.Parse(sCUIT.Substring(8, 1))*3;
                            var xj = int.Parse(sCUIT.Substring(9, 1))*2;
                            var x = xa + xb + xc + xd + xe + xf + xg + xh + xi + xj;
                            var control = (11 - (x%11))%11;
                            if (control != int.Parse(sCUIT.Substring(10, 1)))
                            {
                                MessageBox.Show("Inválido",
                                    "Falta verificar el CUIT",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                e.Cancel = true;
                            }
                        }
                    }
                }
            }
            // Validación de la Fecha inicial de la Solicitud
            if ((clientesUltraGrid.ActiveCell.Band.Key != "FK_Solicitudes_Afiliados") ||
                (clientesUltraGrid.ActiveCell.Column.Key != "Fecha"))
            {
            }
            else
            {
                try
                {
                    if ((DateTime) clientesUltraGrid.ActiveCell.Value > new Service().HoraActual(Program.Pin))
                    {
                        var resultado = MessageBox.Show(this,
                            "La Fecha es posterior a hoy." +
                            Environment.NewLine +
                            "¿Es un error?", "¡Atención!",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            e.Cancel = true;
                        }
                    }
                }
                catch (InvalidCastException)
                {
                    //Si dejo la fecha vacía da un error;
                }
            }
        }

        private void ClientesUltraGridAfterRowActivate(object sender, EventArgs e)
        {
            if (clientesUltraGrid.ActiveRow.Band.Key != "FK__Direcciones__Clientes" &&
                clientesUltraGrid.ActiveRow.Band.Key != "FK_Direcciones_Contratos") return;
            ultraDropDownZonas.DisplayLayout.RefreshFilters();
            ultraDropDownBarrios.DisplayLayout.RefreshFilters();
            ultraDropDownCalle.DisplayLayout.RefreshFilters();
        }

        #endregion

        #region Filtros

        private void UltraDropDownCalleFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = clientesUltraGrid.ActiveRow.Cells["idLocalidad"].Value == DBNull.Value
                ? new FilterCondition(e.Row.Band.Columns["idLocalidad"], FilterComparisionOperator.Equals, 0)
                : new FilterCondition(e.Row.Band.Columns["idLocalidad"], FilterComparisionOperator.Equals,
                    _fp.dsLocalidadesLista.LocalidadesLista.FindByidLocalidad(
                        (int) clientesUltraGrid.ActiveRow.Cells["idLocalidad"].Value).
                        idLocalidad);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void UltraDropDownBarriosFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = clientesUltraGrid.ActiveRow.Cells["idLocalidad"].Value == DBNull.Value
                ? new FilterCondition(e.Row.Band.Columns["idLocalidad"], FilterComparisionOperator.Equals, 0)
                : new FilterCondition(e.Row.Band.Columns["idLocalidad"], FilterComparisionOperator.Equals,
                    _fp.dsLocalidadesLista.LocalidadesLista.FindByidLocalidad(
                        (int) clientesUltraGrid.ActiveRow.Cells["idLocalidad"].Value).
                        idLocalidad);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void UltraDropDownVendedoresFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Activo"], FilterComparisionOperator.Equals, true);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void UltraDropDownPlanesFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Activo"], FilterComparisionOperator.Equals, true);
            var fc1 = new FilterCondition(e.Row.Band.Columns["idContrato"], FilterComparisionOperator.Equals,
                (int) clientesUltraGrid.ActiveRow.Cells["idContrato"].Value);
            if (e.Row.MeetsCriteria(fc) && e.Row.MeetsCriteria(fc1))
                e.RowFilteredOut = false;
            else
                e.RowFilteredOut = true;
        }

        private void UltraDropDownZonasFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc1 = new FilterCondition(e.Row.Band.Columns["idLocalidad"], FilterComparisionOperator.Equals,
                DBNull.Value);
            var fc = clientesUltraGrid.ActiveRow.Cells["idLocalidad"].Value == DBNull.Value
                ? new FilterCondition(e.Row.Band.Columns["idLocalidad"], FilterComparisionOperator.Equals, 0)
                : new FilterCondition(e.Row.Band.Columns["idLocalidad"], FilterComparisionOperator.Equals,
                    _fp.dsLocalidadesLista.LocalidadesLista.FindByidLocalidad(
                        (int) clientesUltraGrid.ActiveRow.Cells["idLocalidad"].Value).
                        idLocalidad);
            if (e.Row.MeetsCriteria(fc) || e.Row.MeetsCriteria(fc1))
                e.RowFilteredOut = false;
            else
                e.RowFilteredOut = true;
        }

        private void UltraDropDownTomadoresDeBajaFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Activo"], FilterComparisionOperator.Equals, true);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void UltraDropDownTiposDeCobranzaFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["idTipoDeCobranza"], FilterComparisionOperator.NotEquals, 3);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        #endregion

        #region Varios

        private void UltraDropDownLocalidadRowSelected(object sender, RowSelectedEventArgs e)
        {
            clientesUltraGrid.Update();
            ultraDropDownZonas.DisplayLayout.RefreshFilters();
            ultraDropDownBarrios.DisplayLayout.RefreshFilters();
            ultraDropDownCalle.DisplayLayout.RefreshFilters();
        }

        private void UltraDropDownContratosInitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (e.Row.Cells["Estado"].Text == "Activo")
            {
                e.Row.Cells["Estado"].Appearance.ForeColor = Color.Green;
            }
            if (e.Row.Cells["Estado"].Text == "Baja")
            {
                e.Row.Cells["Estado"].Appearance.ForeColor = Color.Red;
            }
            if (e.Row.Cells["Estado"].Text == "Suspendido")
            {
                e.Row.Cells["Estado"].Appearance.ForeColor = Color.Blue;
            }
        }

        private void UltraDropDownContratosRowSelected(object sender, RowSelectedEventArgs e)
        {
            clientesUltraGrid.Update();
            ultraDropDownPlanes.DisplayLayout.RefreshFilters();
        }

        #endregion

        private void clientesUltraGrid_DoubleClickCell(object sender, DoubleClickCellEventArgs e)
        {
            if (e.Cell.Column.Key == "CUIT")
            {
                if (e.Cell.Column.Header.Caption == @"CUIT")
                {
                    e.Cell.Column.Header.Caption = @"DNI";
                    e.Cell.Column.MaskInput = @"{LOC}nnn,nnn,nnn,nnn";
                }
                else
                {
                    e.Cell.Column.Header.Caption = @"CUIT";
                    e.Cell.Column.MaskInput = @"##-##,###,###-#";
                }
            }
        }

        private void clientesUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                clientesUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}