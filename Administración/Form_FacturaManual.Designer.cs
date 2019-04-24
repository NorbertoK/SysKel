namespace Administración
{
    partial class FormFacturaManual
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand8 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ComprobantesManuales", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn151 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn152 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn153 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo");
            Infragistics.Win.Appearance appearance111 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn154 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente", -1, "ultraDropDownClientes", 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn155 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Prefijo", -1, "ultraDropDownPrefijo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn156 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ServicioDesde");
            Infragistics.Win.Appearance appearance112 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn157 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ServicioHasta");
            Infragistics.Win.Appearance appearance113 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn158 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idFacturaProForma");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn159 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idReferencia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn160 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeComprobante", -1, "ultraDropDownTiposDeComprobante");
            Infragistics.Win.Appearance appearance114 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn161 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK__DetallesC__idCom__07AC1A97");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand9 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK__DetallesC__idCom__07AC1A97", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn162 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDetalleComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn163 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn164 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn165 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Detalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn166 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn167 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario");
            Infragistics.Win.Appearance appearance115 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn168 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPorcentajeIVA", -1, "ultraDropDownPorcentajeIVA");
            Infragistics.Win.Appearance appearance116 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn169 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocio", -1, "ultraDropDownNegocios");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn170 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRenglonFacturaProforma", -1, "ultraDropDownRenglonesFactura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn171 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio", 0);
            Infragistics.Win.Appearance appearance117 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn172 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IVA", 1);
            Infragistics.Win.Appearance appearance118 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn173 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteEscrito", 2, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.Appearance appearance119 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn174 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravado", 3);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn175 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Exento", 4);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn176 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto", 5);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn177 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idFacturaProforma", 6);
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance89 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance90 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance91 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance92 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance93 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance94 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance56 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand7 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ClientesLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn73 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn74 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn75 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCategoriaIva");
            Infragistics.Win.Appearance appearance57 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance58 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance59 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance60 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance61 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance62 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance63 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance64 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance65 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance76 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("PuntosDeVenta", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn58 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPuntoDeVenta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn59 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Prefijo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn60 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn61 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn62 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignadoA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn63 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignadoB");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn64 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Verdadero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn65 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeCA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn66 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeDA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn67 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeCB");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn68 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeDB");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn69 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SolicitaCAE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn70 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignadoM");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn71 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeCM");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn72 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeDM");
            Infragistics.Win.Appearance appearance77 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance78 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance79 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance80 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance81 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance82 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance83 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance84 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance85 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn52 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravado");
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn53 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Exento");
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn54 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto");
            Infragistics.Win.Appearance appearance86 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn55 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal");
            Infragistics.Win.Appearance appearance87 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn56 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IVA");
            Infragistics.Win.Appearance appearance88 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn57 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Total");
            Infragistics.Win.Appearance appearance95 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn1 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("NoGravado");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn2 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Exento");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn3 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn4 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Subtotal");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn5 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("IVA");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn6 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total");
            Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("RenglonesFacturaLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn46 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRenglonFacturaProforma");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn47 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Mostrar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn48 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPorcentajeIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn49 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn50 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn51 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idFacturaProforma");
            Infragistics.Win.Appearance appearance47 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance50 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance51 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance52 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance53 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance54 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance55 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Negocios", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn42 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn43 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Orden");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn44 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn45 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca");
            Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance66 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("PorcentajeIVA", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn37 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPorcentajeIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn38 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoAFIP");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn39 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn40 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn41 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Porcentaje");
            Infragistics.Win.Appearance appearance67 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance68 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance69 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance70 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance71 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance72 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance73 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance74 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance75 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeComprobante", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn28 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn29 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn30 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn31 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteNegativo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn32 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DiscriminaIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn33 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EsFactura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn34 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn35 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn36 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TablaAFIP");
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.dsFacturaManual = new Administración.WS.DsFacturaManual();
            this.comprobantesManualesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comprobantesManualesUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraCalcManager1 = new Infragistics.Win.UltraWinCalcManager.UltraCalcManager(this.components);
            this.dsClientesLista = new Administración.WS.DsClientesLista();
            this.clientesListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPuntosDeVenta = new Administración.WS.DsPuntosDeVenta();
            this.puntosDeVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraDropDownClientes = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraDropDownPrefijo = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.porcentajeIVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPorcentajeIVA = new Administración.WS.DsPorcentajeIVA();
            this.dsCategoriasIVA1 = new Administración.DsCategoriasIVA();
            this.dsNegocios = new Administración.WS.DsNegocios();
            this.negociosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsParametros1 = new Administración.WS.DsParametros();
            this.ds_TiposDeComprobante = new Administración.WS.DsTiposDeComprobante();
            this.totalesUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraDataSource1 = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.ultraDropDownRenglonesFactura = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.renglonesFacturaListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRenglonesFacturaLista = new Administración.WS.DsRenglonesFacturaLista();
            this.ultraDropDownNegocios = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraDropDownPorcentajeIVA = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraDropDownTiposDeComprobante = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tiposDeComprobanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsFacturaOriginal = new Administración.WS.DsFacturaManual();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturaManual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobantesManualesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobantesManualesUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientesLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPuntosDeVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntosDeVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPrefijo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentajeIVABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPorcentajeIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCategoriasIVA1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNegocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negociosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParametros1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_TiposDeComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalesUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownRenglonesFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renglonesFacturaListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRenglonesFacturaLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownNegocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPorcentajeIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeComprobanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturaOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(563, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(482, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 577);
            this.panel1.Size = new System.Drawing.Size(653, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(401, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Location = new System.Drawing.Point(7, 3);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(646, 29);
            this.ultraLabel1.TabIndex = 65;
            this.ultraLabel1.Text = "El Período y el Renglón de factura son opcionales, pero si no están ese item no s" +
    "e dará por facturado y será vuelto a facturar en sucesivas facturaciones automát" +
    "icas.";
            // 
            // dsFacturaManual
            // 
            this.dsFacturaManual.DataSetName = "DsFacturaManual";
            this.dsFacturaManual.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comprobantesManualesBindingSource
            // 
            this.comprobantesManualesBindingSource.DataMember = "ComprobantesManuales";
            this.comprobantesManualesBindingSource.DataSource = this.dsFacturaManual;
            // 
            // comprobantesManualesUltraGrid
            // 
            this.comprobantesManualesUltraGrid.CalcManager = this.ultraCalcManager1;
            this.comprobantesManualesUltraGrid.DataSource = this.comprobantesManualesBindingSource;
            appearance24.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance24.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.comprobantesManualesUltraGrid.DisplayLayout.Appearance = appearance24;
            this.comprobantesManualesUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand8.ColHeaderLines = 2;
            ultraGridColumn151.Header.VisiblePosition = 0;
            ultraGridColumn151.Hidden = true;
            ultraGridColumn151.Width = 122;
            ultraGridColumn152.Header.VisiblePosition = 1;
            ultraGridColumn152.Hidden = true;
            ultraGridColumn152.Width = 116;
            appearance111.TextHAlignAsString = "Center";
            ultraGridColumn153.CellAppearance = appearance111;
            ultraGridColumn153.Header.Caption = "Período";
            ultraGridColumn153.Header.VisiblePosition = 2;
            ultraGridColumn153.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn153.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn153.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn153.MaskInput = "mm/yyyy";
            ultraGridColumn153.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn153.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn153.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(53, 0);
            ultraGridColumn153.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn153.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn153.Width = 40;
            ultraGridColumn154.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn154.Header.Caption = "Cliente";
            ultraGridColumn154.Header.VisiblePosition = 3;
            ultraGridColumn154.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn154.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn154.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(254, 0);
            ultraGridColumn154.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn154.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn154.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn154.Width = 455;
            ultraGridColumn155.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn155.Header.VisiblePosition = 4;
            ultraGridColumn155.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn155.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn155.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(50, 0);
            ultraGridColumn155.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn155.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn155.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn155.Width = 75;
            appearance112.TextHAlignAsString = "Center";
            ultraGridColumn156.CellAppearance = appearance112;
            ultraGridColumn156.Header.Caption = "Servicio Desde";
            ultraGridColumn156.Header.VisiblePosition = 5;
            ultraGridColumn156.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn156.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn156.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(68, 0);
            ultraGridColumn156.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn156.RowLayoutColumnInfo.SpanY = 2;
            appearance113.TextHAlignAsString = "Center";
            ultraGridColumn157.CellAppearance = appearance113;
            ultraGridColumn157.Header.Caption = "Servicio Hasta";
            ultraGridColumn157.Header.VisiblePosition = 6;
            ultraGridColumn157.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn157.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn157.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(72, 0);
            ultraGridColumn157.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn157.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn158.Header.VisiblePosition = 7;
            ultraGridColumn158.Hidden = true;
            ultraGridColumn158.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn158.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn158.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn158.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn159.Header.VisiblePosition = 8;
            ultraGridColumn159.Hidden = true;
            ultraGridColumn160.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
            appearance114.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            appearance114.TextHAlignAsString = "Center";
            ultraGridColumn160.CellAppearance = appearance114;
            ultraGridColumn160.Header.Caption = "Comprobante";
            ultraGridColumn160.Header.VisiblePosition = 9;
            ultraGridColumn160.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn160.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn160.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(112, 0);
            ultraGridColumn160.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn160.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn161.Header.VisiblePosition = 10;
            ultraGridBand8.Columns.AddRange(new object[] {
            ultraGridColumn151,
            ultraGridColumn152,
            ultraGridColumn153,
            ultraGridColumn154,
            ultraGridColumn155,
            ultraGridColumn156,
            ultraGridColumn157,
            ultraGridColumn158,
            ultraGridColumn159,
            ultraGridColumn160,
            ultraGridColumn161});
            ultraGridBand8.MaxRows = 1;
            ultraGridBand8.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.True;
            ultraGridBand8.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            ultraGridBand9.ColHeaderLines = 2;
            ultraGridColumn162.Header.VisiblePosition = 0;
            ultraGridColumn162.Hidden = true;
            ultraGridColumn162.Width = 106;
            ultraGridColumn163.Header.VisiblePosition = 1;
            ultraGridColumn163.Hidden = true;
            ultraGridColumn163.Width = 80;
            ultraGridColumn164.Header.VisiblePosition = 2;
            ultraGridColumn164.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn164.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn164.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(58, 0);
            ultraGridColumn164.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn164.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn164.Width = 46;
            ultraGridColumn165.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            ultraGridColumn165.Header.VisiblePosition = 3;
            ultraGridColumn165.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn165.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn165.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(220, 56);
            ultraGridColumn165.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn165.RowLayoutColumnInfo.SpanY = 4;
            ultraGridColumn165.VertScrollBar = true;
            ultraGridColumn165.Width = 220;
            ultraGridColumn166.Formula = "[Cantidad] *  [PrecioUnitario]";
            ultraGridColumn166.Header.VisiblePosition = 4;
            ultraGridColumn166.Hidden = true;
            ultraGridColumn166.Width = 69;
            appearance115.TextHAlignAsString = "Right";
            ultraGridColumn167.CellAppearance = appearance115;
            ultraGridColumn167.Header.Caption = "Precio Unitario con IVA";
            ultraGridColumn167.Header.VisiblePosition = 5;
            ultraGridColumn167.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn167.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn167.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn167.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn167.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(93, 0);
            ultraGridColumn167.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(93, 0);
            ultraGridColumn167.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn167.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn167.Width = 65;
            ultraGridColumn168.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            appearance116.TextHAlignAsString = "Center";
            ultraGridColumn168.CellAppearance = appearance116;
            ultraGridColumn168.Header.Caption = "Porcentaje IVA";
            ultraGridColumn168.Header.VisiblePosition = 6;
            ultraGridColumn168.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn168.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn168.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(93, 0);
            ultraGridColumn168.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(93, 0);
            ultraGridColumn168.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn168.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn168.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn168.Width = 75;
            ultraGridColumn169.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn169.Header.Caption = "Negocio";
            ultraGridColumn169.Header.VisiblePosition = 7;
            ultraGridColumn169.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn169.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn169.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn169.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn169.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn170.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn170.Header.Caption = "Rengón Factura Proforma";
            ultraGridColumn170.Header.VisiblePosition = 8;
            ultraGridColumn170.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn170.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn170.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(284, 0);
            ultraGridColumn170.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn170.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn170.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn171.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance117.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            appearance117.TextHAlignAsString = "Right";
            ultraGridColumn171.CellAppearance = appearance117;
            ultraGridColumn171.DataType = typeof(decimal);
            ultraGridColumn171.Header.Caption = "Precio Unitario";
            ultraGridColumn171.Header.VisiblePosition = 9;
            ultraGridColumn171.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn171.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn171.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn171.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn171.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(93, 0);
            ultraGridColumn171.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(93, 0);
            ultraGridColumn171.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn171.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn171.Width = 65;
            ultraGridColumn172.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance118.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            appearance118.TextHAlignAsString = "Right";
            ultraGridColumn172.CellAppearance = appearance118;
            ultraGridColumn172.DataType = typeof(decimal);
            ultraGridColumn172.Header.VisiblePosition = 10;
            ultraGridColumn172.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn172.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn172.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn172.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn172.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(93, 0);
            ultraGridColumn172.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(93, 0);
            ultraGridColumn172.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn172.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn172.Width = 58;
            ultraGridColumn173.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance119.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            appearance119.TextHAlignAsString = "Right";
            ultraGridColumn173.CellAppearance = appearance119;
            ultraGridColumn173.DataType = typeof(decimal);
            ultraGridColumn173.Header.Caption = "Importe";
            ultraGridColumn173.Header.VisiblePosition = 11;
            ultraGridColumn173.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn173.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn173.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn173.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn173.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(98, 0);
            ultraGridColumn173.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(98, 0);
            ultraGridColumn173.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn173.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn173.Width = 58;
            ultraGridColumn174.DataType = typeof(decimal);
            ultraGridColumn174.Header.Caption = "No Gravado";
            ultraGridColumn174.Header.VisiblePosition = 12;
            ultraGridColumn174.Hidden = true;
            ultraGridColumn175.DataType = typeof(decimal);
            ultraGridColumn175.Header.VisiblePosition = 13;
            ultraGridColumn175.Hidden = true;
            ultraGridColumn176.DataType = typeof(decimal);
            ultraGridColumn176.Header.VisiblePosition = 14;
            ultraGridColumn176.Hidden = true;
            ultraGridColumn177.DataType = typeof(int);
            ultraGridColumn177.Header.VisiblePosition = 15;
            ultraGridColumn177.Hidden = true;
            ultraGridBand9.Columns.AddRange(new object[] {
            ultraGridColumn162,
            ultraGridColumn163,
            ultraGridColumn164,
            ultraGridColumn165,
            ultraGridColumn166,
            ultraGridColumn167,
            ultraGridColumn168,
            ultraGridColumn169,
            ultraGridColumn170,
            ultraGridColumn171,
            ultraGridColumn172,
            ultraGridColumn173,
            ultraGridColumn174,
            ultraGridColumn175,
            ultraGridColumn176,
            ultraGridColumn177});
            ultraGridBand9.Override.RowFilterMode = Infragistics.Win.UltraWinGrid.RowFilterMode.AllRowsInBand;
            ultraGridBand9.Override.RowSpacingAfter = 10;
            ultraGridBand9.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            ultraGridBand9.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.True;
            ultraGridBand9.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand9.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            this.comprobantesManualesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand8);
            this.comprobantesManualesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand9);
            this.comprobantesManualesUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.comprobantesManualesUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.comprobantesManualesUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance21.BackColor = System.Drawing.SystemColors.Window;
            this.comprobantesManualesUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance21;
            appearance22.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance22.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance22.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comprobantesManualesUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance22;
            this.comprobantesManualesUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.comprobantesManualesUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.comprobantesManualesUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.comprobantesManualesUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.comprobantesManualesUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.comprobantesManualesUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.comprobantesManualesUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance23.BackColor = System.Drawing.Color.Transparent;
            this.comprobantesManualesUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance23;
            appearance89.BackColor = System.Drawing.SystemColors.Control;
            appearance89.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance89.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.comprobantesManualesUltraGrid.DisplayLayout.Override.CellAppearance = appearance89;
            this.comprobantesManualesUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance90.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance90.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance90.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance90.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance90.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.comprobantesManualesUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance90;
            this.comprobantesManualesUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance91.ForeColor = System.Drawing.Color.Red;
            this.comprobantesManualesUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance91;
            this.comprobantesManualesUltraGrid.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Free;
            this.comprobantesManualesUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance92.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.comprobantesManualesUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance92;
            appearance93.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance93.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance93.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.comprobantesManualesUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance93;
            appearance94.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance94.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.comprobantesManualesUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance94;
            this.comprobantesManualesUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comprobantesManualesUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.comprobantesManualesUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.comprobantesManualesUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.comprobantesManualesUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comprobantesManualesUltraGrid.Location = new System.Drawing.Point(3, 28);
            this.comprobantesManualesUltraGrid.Name = "comprobantesManualesUltraGrid";
            this.comprobantesManualesUltraGrid.Size = new System.Drawing.Size(649, 460);
            this.comprobantesManualesUltraGrid.TabIndex = 66;
            this.comprobantesManualesUltraGrid.AfterEnterEditMode += new System.EventHandler(this.comprobantesManualesUltraGrid_AfterEnterEditMode);
            this.comprobantesManualesUltraGrid.CellListSelect += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.comprobantesManualesUltraGrid_CellListSelect);
            this.comprobantesManualesUltraGrid.AfterCellListCloseUp += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.comprobantesManualesUltraGrid_AfterCellListCloseUp);
            this.comprobantesManualesUltraGrid.BeforeCellDeactivate += new System.ComponentModel.CancelEventHandler(this.comprobantesManualesUltraGrid_BeforeCellDeactivate);
            this.comprobantesManualesUltraGrid.BeforeRowDeactivate += new System.ComponentModel.CancelEventHandler(this.comprobantesManualesUltraGrid_BeforeRowDeactivate);
            this.comprobantesManualesUltraGrid.Enter += new System.EventHandler(this.ComprobantesManualesUltraGridEnter);
            // 
            // ultraCalcManager1
            // 
            this.ultraCalcManager1.ContainingControl = this;
            // 
            // dsClientesLista
            // 
            this.dsClientesLista.DataSetName = "DsClientesLista";
            this.dsClientesLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesListaBindingSource
            // 
            this.clientesListaBindingSource.DataMember = "ClientesLista";
            this.clientesListaBindingSource.DataSource = this.dsClientesLista;
            // 
            // dsPuntosDeVenta
            // 
            this.dsPuntosDeVenta.DataSetName = "DsPuntosDeVenta";
            this.dsPuntosDeVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // puntosDeVentaBindingSource
            // 
            this.puntosDeVentaBindingSource.DataMember = "PuntosDeVenta";
            this.puntosDeVentaBindingSource.DataSource = this.dsPuntosDeVenta;
            // 
            // ultraDropDownClientes
            // 
            this.ultraDropDownClientes.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownClientes.DataSource = this.clientesListaBindingSource;
            appearance56.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance56.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance56.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownClientes.DisplayLayout.Appearance = appearance56;
            this.ultraDropDownClientes.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand7.ColHeadersVisible = false;
            ultraGridColumn73.Header.VisiblePosition = 0;
            ultraGridColumn73.Hidden = true;
            ultraGridColumn74.Header.VisiblePosition = 1;
            ultraGridColumn75.Header.VisiblePosition = 2;
            ultraGridColumn75.Hidden = true;
            ultraGridBand7.Columns.AddRange(new object[] {
            ultraGridColumn73,
            ultraGridColumn74,
            ultraGridColumn75});
            ultraGridBand7.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand7.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownClientes.DisplayLayout.BandsSerializer.Add(ultraGridBand7);
            this.ultraDropDownClientes.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownClientes.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownClientes.DisplayLayout.MaxBandDepth = 5;
            appearance57.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownClientes.DisplayLayout.Override.ActiveCellAppearance = appearance57;
            appearance58.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance58.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance58.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance58.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownClientes.DisplayLayout.Override.ActiveRowAppearance = appearance58;
            this.ultraDropDownClientes.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownClientes.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownClientes.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownClientes.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownClientes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownClientes.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownClientes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance59.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownClientes.DisplayLayout.Override.CardAreaAppearance = appearance59;
            appearance60.BackColor = System.Drawing.SystemColors.Control;
            appearance60.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance60.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownClientes.DisplayLayout.Override.CellAppearance = appearance60;
            this.ultraDropDownClientes.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance61.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance61.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance61.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance61.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance61.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownClientes.DisplayLayout.Override.HeaderAppearance = appearance61;
            this.ultraDropDownClientes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance62.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownClientes.DisplayLayout.Override.RowSelectorAppearance = appearance62;
            this.ultraDropDownClientes.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance63.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownClientes.DisplayLayout.Override.SelectedCellAppearance = appearance63;
            appearance64.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance64.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance64.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownClientes.DisplayLayout.Override.SelectedRowAppearance = appearance64;
            appearance65.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance65.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownClientes.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance65;
            this.ultraDropDownClientes.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownClientes.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownClientes.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownClientes.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownClientes.DisplayMember = "NombreCompleto";
            this.ultraDropDownClientes.DropDownWidth = 0;
            this.ultraDropDownClientes.Location = new System.Drawing.Point(225, 131);
            this.ultraDropDownClientes.Name = "ultraDropDownClientes";
            this.ultraDropDownClientes.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownClientes.TabIndex = 67;
            this.ultraDropDownClientes.ValueMember = "idCliente";
            this.ultraDropDownClientes.Visible = false;
            // 
            // ultraDropDownPrefijo
            // 
            this.ultraDropDownPrefijo.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownPrefijo.DataSource = this.puntosDeVentaBindingSource;
            appearance76.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance76.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance76.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPrefijo.DisplayLayout.Appearance = appearance76;
            this.ultraDropDownPrefijo.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand6.ColHeadersVisible = false;
            ultraGridColumn58.Header.VisiblePosition = 0;
            ultraGridColumn58.Hidden = true;
            ultraGridColumn59.Header.VisiblePosition = 1;
            ultraGridColumn60.Header.VisiblePosition = 2;
            ultraGridColumn60.Hidden = true;
            ultraGridColumn61.Header.VisiblePosition = 3;
            ultraGridColumn61.Hidden = true;
            ultraGridColumn62.Header.VisiblePosition = 4;
            ultraGridColumn62.Hidden = true;
            ultraGridColumn63.Header.VisiblePosition = 5;
            ultraGridColumn63.Hidden = true;
            ultraGridColumn64.Header.VisiblePosition = 6;
            ultraGridColumn64.Hidden = true;
            ultraGridColumn65.Header.VisiblePosition = 7;
            ultraGridColumn65.Hidden = true;
            ultraGridColumn66.Header.VisiblePosition = 8;
            ultraGridColumn66.Hidden = true;
            ultraGridColumn67.Header.VisiblePosition = 9;
            ultraGridColumn67.Hidden = true;
            ultraGridColumn68.Header.VisiblePosition = 10;
            ultraGridColumn68.Hidden = true;
            ultraGridColumn69.Header.VisiblePosition = 11;
            ultraGridColumn69.Hidden = true;
            ultraGridColumn70.Header.VisiblePosition = 12;
            ultraGridColumn70.Hidden = true;
            ultraGridColumn71.Header.VisiblePosition = 13;
            ultraGridColumn71.Hidden = true;
            ultraGridColumn72.Header.VisiblePosition = 14;
            ultraGridColumn72.Hidden = true;
            ultraGridBand6.Columns.AddRange(new object[] {
            ultraGridColumn58,
            ultraGridColumn59,
            ultraGridColumn60,
            ultraGridColumn61,
            ultraGridColumn62,
            ultraGridColumn63,
            ultraGridColumn64,
            ultraGridColumn65,
            ultraGridColumn66,
            ultraGridColumn67,
            ultraGridColumn68,
            ultraGridColumn69,
            ultraGridColumn70,
            ultraGridColumn71,
            ultraGridColumn72});
            ultraGridBand6.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand6.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownPrefijo.DisplayLayout.BandsSerializer.Add(ultraGridBand6);
            this.ultraDropDownPrefijo.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPrefijo.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPrefijo.DisplayLayout.MaxBandDepth = 5;
            appearance77.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPrefijo.DisplayLayout.Override.ActiveCellAppearance = appearance77;
            appearance78.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance78.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance78.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance78.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPrefijo.DisplayLayout.Override.ActiveRowAppearance = appearance78;
            this.ultraDropDownPrefijo.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPrefijo.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPrefijo.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPrefijo.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPrefijo.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPrefijo.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPrefijo.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance79.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPrefijo.DisplayLayout.Override.CardAreaAppearance = appearance79;
            appearance80.BackColor = System.Drawing.SystemColors.Control;
            appearance80.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance80.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPrefijo.DisplayLayout.Override.CellAppearance = appearance80;
            this.ultraDropDownPrefijo.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance81.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance81.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance81.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance81.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance81.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPrefijo.DisplayLayout.Override.HeaderAppearance = appearance81;
            this.ultraDropDownPrefijo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance82.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPrefijo.DisplayLayout.Override.RowSelectorAppearance = appearance82;
            this.ultraDropDownPrefijo.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance83.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPrefijo.DisplayLayout.Override.SelectedCellAppearance = appearance83;
            appearance84.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance84.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance84.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPrefijo.DisplayLayout.Override.SelectedRowAppearance = appearance84;
            appearance85.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance85.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPrefijo.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance85;
            this.ultraDropDownPrefijo.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPrefijo.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPrefijo.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPrefijo.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPrefijo.DisplayMember = "Prefijo";
            this.ultraDropDownPrefijo.DropDownWidth = 0;
            this.ultraDropDownPrefijo.Location = new System.Drawing.Point(225, 172);
            this.ultraDropDownPrefijo.Name = "ultraDropDownPrefijo";
            this.ultraDropDownPrefijo.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownPrefijo.TabIndex = 68;
            this.ultraDropDownPrefijo.ValueMember = "Prefijo";
            this.ultraDropDownPrefijo.Visible = false;
            // 
            // porcentajeIVABindingSource
            // 
            this.porcentajeIVABindingSource.DataMember = "PorcentajeIVA";
            this.porcentajeIVABindingSource.DataSource = this.dsPorcentajeIVA;
            // 
            // dsPorcentajeIVA
            // 
            this.dsPorcentajeIVA.DataSetName = "DsPorcentajeIVA";
            this.dsPorcentajeIVA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsCategoriasIVA1
            // 
            this.dsCategoriasIVA1.DataSetName = "DsCategoriasIVA";
            this.dsCategoriasIVA1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsNegocios
            // 
            this.dsNegocios.DataSetName = "DsNegocios";
            this.dsNegocios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // negociosBindingSource
            // 
            this.negociosBindingSource.DataMember = "Negocios";
            this.negociosBindingSource.DataSource = this.dsNegocios;
            // 
            // dsParametros1
            // 
            this.dsParametros1.DataSetName = "DsParametros";
            this.dsParametros1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ds_TiposDeComprobante
            // 
            this.ds_TiposDeComprobante.DataSetName = "DsTiposDeComprobante";
            this.ds_TiposDeComprobante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // totalesUltraGrid
            // 
            this.totalesUltraGrid.CalcManager = this.ultraCalcManager1;
            this.totalesUltraGrid.DataSource = this.ultraDataSource1;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.totalesUltraGrid.DisplayLayout.Appearance = appearance1;
            this.totalesUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn52.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance34.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            appearance34.TextHAlignAsString = "Right";
            ultraGridColumn52.CellAppearance = appearance34;
            ultraGridColumn52.Header.Caption = "No Gravado";
            ultraGridColumn52.Header.VisiblePosition = 0;
            ultraGridColumn52.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn52.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn52.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn52.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn52.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn52.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn52.Width = 89;
            ultraGridColumn53.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance35.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            appearance35.TextHAlignAsString = "Right";
            ultraGridColumn53.CellAppearance = appearance35;
            ultraGridColumn53.Header.VisiblePosition = 1;
            ultraGridColumn53.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn53.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn53.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn53.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn53.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn53.Width = 92;
            ultraGridColumn54.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance86.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            appearance86.TextHAlignAsString = "Right";
            ultraGridColumn54.CellAppearance = appearance86;
            ultraGridColumn54.Header.VisiblePosition = 2;
            ultraGridColumn54.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn54.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn54.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn54.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn54.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn54.Width = 87;
            ultraGridColumn55.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance87.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            appearance87.TextHAlignAsString = "Right";
            ultraGridColumn55.CellAppearance = appearance87;
            ultraGridColumn55.Header.VisiblePosition = 3;
            ultraGridColumn55.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn55.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn55.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn55.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn55.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn55.Width = 87;
            ultraGridColumn56.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance88.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            appearance88.TextHAlignAsString = "Right";
            ultraGridColumn56.CellAppearance = appearance88;
            ultraGridColumn56.Header.VisiblePosition = 4;
            ultraGridColumn56.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn56.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn56.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn56.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn56.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn56.Width = 87;
            ultraGridColumn57.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance95.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            appearance95.TextHAlignAsString = "Right";
            ultraGridColumn57.CellAppearance = appearance95;
            ultraGridColumn57.Header.VisiblePosition = 5;
            ultraGridColumn57.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn57.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn57.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn57.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn57.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn57.Width = 87;
            ultraGridBand5.Columns.AddRange(new object[] {
            ultraGridColumn52,
            ultraGridColumn53,
            ultraGridColumn54,
            ultraGridColumn55,
            ultraGridColumn56,
            ultraGridColumn57});
            ultraGridBand5.MaxRows = 1;
            ultraGridBand5.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            ultraGridBand5.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.Left;
            ultraGridBand5.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand5.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            this.totalesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand5);
            this.totalesUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.totalesUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.totalesUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance8.BackColor = System.Drawing.SystemColors.Window;
            this.totalesUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.totalesUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance9;
            this.totalesUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.totalesUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.totalesUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.totalesUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.totalesUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.totalesUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.totalesUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance10.BackColor = System.Drawing.Color.Transparent;
            this.totalesUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance10;
            appearance26.BackColor = System.Drawing.SystemColors.Control;
            appearance26.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.totalesUltraGrid.DisplayLayout.Override.CellAppearance = appearance26;
            this.totalesUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance27.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance27.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance27.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.totalesUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance27;
            this.totalesUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance28.ForeColor = System.Drawing.Color.Red;
            this.totalesUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance28;
            this.totalesUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.totalesUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance29;
            appearance30.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance30.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.totalesUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance30;
            appearance31.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance31.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.totalesUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance31;
            this.totalesUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.totalesUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.totalesUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.totalesUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.totalesUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalesUltraGrid.Location = new System.Drawing.Point(0, 500);
            this.totalesUltraGrid.Name = "totalesUltraGrid";
            this.totalesUltraGrid.Size = new System.Drawing.Size(656, 65);
            this.totalesUltraGrid.TabIndex = 69;
            // 
            // ultraDataSource1
            // 
            ultraDataColumn1.DataType = typeof(decimal);
            ultraDataColumn2.DataType = typeof(decimal);
            ultraDataColumn3.DataType = typeof(decimal);
            ultraDataColumn4.DataType = typeof(decimal);
            ultraDataColumn5.DataType = typeof(decimal);
            ultraDataColumn6.DataType = typeof(decimal);
            this.ultraDataSource1.Band.Columns.AddRange(new object[] {
            ultraDataColumn1,
            ultraDataColumn2,
            ultraDataColumn3,
            ultraDataColumn4,
            ultraDataColumn5,
            ultraDataColumn6});
            // 
            // ultraDropDownRenglonesFactura
            // 
            this.ultraDropDownRenglonesFactura.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownRenglonesFactura.DataSource = this.renglonesFacturaListaBindingSource;
            appearance46.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance46.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownRenglonesFactura.DisplayLayout.Appearance = appearance46;
            this.ultraDropDownRenglonesFactura.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand4.ColHeadersVisible = false;
            ultraGridColumn46.Header.VisiblePosition = 0;
            ultraGridColumn46.Hidden = true;
            ultraGridColumn47.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn47.Header.VisiblePosition = 1;
            ultraGridColumn48.Header.VisiblePosition = 2;
            ultraGridColumn48.Hidden = true;
            ultraGridColumn49.Header.VisiblePosition = 3;
            ultraGridColumn49.Hidden = true;
            ultraGridColumn50.Header.VisiblePosition = 4;
            ultraGridColumn50.Hidden = true;
            ultraGridColumn51.Header.VisiblePosition = 5;
            ultraGridColumn51.Hidden = true;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn46,
            ultraGridColumn47,
            ultraGridColumn48,
            ultraGridColumn49,
            ultraGridColumn50,
            ultraGridColumn51});
            ultraGridBand4.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand4.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownRenglonesFactura.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.ultraDropDownRenglonesFactura.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownRenglonesFactura.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownRenglonesFactura.DisplayLayout.MaxBandDepth = 5;
            appearance47.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownRenglonesFactura.DisplayLayout.Override.ActiveCellAppearance = appearance47;
            appearance48.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance48.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance48.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance48.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownRenglonesFactura.DisplayLayout.Override.ActiveRowAppearance = appearance48;
            this.ultraDropDownRenglonesFactura.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownRenglonesFactura.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownRenglonesFactura.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownRenglonesFactura.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownRenglonesFactura.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownRenglonesFactura.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownRenglonesFactura.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance49.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownRenglonesFactura.DisplayLayout.Override.CardAreaAppearance = appearance49;
            appearance50.BackColor = System.Drawing.SystemColors.Control;
            appearance50.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance50.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownRenglonesFactura.DisplayLayout.Override.CellAppearance = appearance50;
            this.ultraDropDownRenglonesFactura.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance51.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance51.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance51.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance51.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownRenglonesFactura.DisplayLayout.Override.HeaderAppearance = appearance51;
            this.ultraDropDownRenglonesFactura.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance52.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownRenglonesFactura.DisplayLayout.Override.RowSelectorAppearance = appearance52;
            this.ultraDropDownRenglonesFactura.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance53.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownRenglonesFactura.DisplayLayout.Override.SelectedCellAppearance = appearance53;
            appearance54.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance54.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance54.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownRenglonesFactura.DisplayLayout.Override.SelectedRowAppearance = appearance54;
            appearance55.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance55.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownRenglonesFactura.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance55;
            this.ultraDropDownRenglonesFactura.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownRenglonesFactura.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownRenglonesFactura.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownRenglonesFactura.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownRenglonesFactura.DisplayMember = "Mostrar";
            this.ultraDropDownRenglonesFactura.DropDownWidth = 0;
            this.ultraDropDownRenglonesFactura.Location = new System.Drawing.Point(225, 213);
            this.ultraDropDownRenglonesFactura.Name = "ultraDropDownRenglonesFactura";
            this.ultraDropDownRenglonesFactura.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownRenglonesFactura.TabIndex = 70;
            this.ultraDropDownRenglonesFactura.ValueMember = "idRenglonFacturaProforma";
            this.ultraDropDownRenglonesFactura.Visible = false;
            this.ultraDropDownRenglonesFactura.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.ultraDropDownRenglonesFactura_FilterRow);
            // 
            // renglonesFacturaListaBindingSource
            // 
            this.renglonesFacturaListaBindingSource.DataMember = "RenglonesFacturaLista";
            this.renglonesFacturaListaBindingSource.DataSource = this.dsRenglonesFacturaLista;
            // 
            // dsRenglonesFacturaLista
            // 
            this.dsRenglonesFacturaLista.DataSetName = "DsRenglonesFacturaLista";
            this.dsRenglonesFacturaLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownNegocios
            // 
            this.ultraDropDownNegocios.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownNegocios.DataSource = this.negociosBindingSource;
            appearance36.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance36.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownNegocios.DisplayLayout.Appearance = appearance36;
            ultraGridBand3.ColHeadersVisible = false;
            ultraGridColumn42.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn42.Header.VisiblePosition = 0;
            ultraGridColumn42.Hidden = true;
            ultraGridColumn43.Header.VisiblePosition = 1;
            ultraGridColumn43.Hidden = true;
            ultraGridColumn44.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn44.Header.VisiblePosition = 2;
            ultraGridColumn45.Header.VisiblePosition = 3;
            ultraGridColumn45.Hidden = true;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn42,
            ultraGridColumn43,
            ultraGridColumn44,
            ultraGridColumn45});
            ultraGridBand3.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand3.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownNegocios.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.ultraDropDownNegocios.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownNegocios.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownNegocios.DisplayLayout.MaxBandDepth = 5;
            appearance37.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownNegocios.DisplayLayout.Override.ActiveCellAppearance = appearance37;
            appearance38.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance38.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance38.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance38.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownNegocios.DisplayLayout.Override.ActiveRowAppearance = appearance38;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance39.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownNegocios.DisplayLayout.Override.CardAreaAppearance = appearance39;
            appearance40.BackColor = System.Drawing.SystemColors.Control;
            appearance40.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance40.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownNegocios.DisplayLayout.Override.CellAppearance = appearance40;
            this.ultraDropDownNegocios.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance41.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance41.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance41.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance41.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance41.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownNegocios.DisplayLayout.Override.HeaderAppearance = appearance41;
            this.ultraDropDownNegocios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance42.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownNegocios.DisplayLayout.Override.RowSelectorAppearance = appearance42;
            this.ultraDropDownNegocios.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance43.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownNegocios.DisplayLayout.Override.SelectedCellAppearance = appearance43;
            appearance44.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance44.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance44.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownNegocios.DisplayLayout.Override.SelectedRowAppearance = appearance44;
            appearance45.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance45.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownNegocios.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance45;
            this.ultraDropDownNegocios.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownNegocios.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownNegocios.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownNegocios.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownNegocios.DisplayMember = "Nombre";
            this.ultraDropDownNegocios.Location = new System.Drawing.Point(225, 254);
            this.ultraDropDownNegocios.Name = "ultraDropDownNegocios";
            this.ultraDropDownNegocios.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownNegocios.TabIndex = 71;
            this.ultraDropDownNegocios.ValueMember = "idNegocio";
            this.ultraDropDownNegocios.Visible = false;
            // 
            // ultraDropDownPorcentajeIVA
            // 
            this.ultraDropDownPorcentajeIVA.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownPorcentajeIVA.DataSource = this.porcentajeIVABindingSource;
            appearance66.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance66.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance66.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Appearance = appearance66;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand2.ColHeadersVisible = false;
            ultraGridColumn37.Header.VisiblePosition = 0;
            ultraGridColumn37.Hidden = true;
            ultraGridColumn37.Width = 54;
            ultraGridColumn38.Header.VisiblePosition = 1;
            ultraGridColumn38.Hidden = true;
            ultraGridColumn38.Width = 45;
            ultraGridColumn39.Header.VisiblePosition = 2;
            ultraGridColumn39.Width = 231;
            ultraGridColumn40.Header.VisiblePosition = 3;
            ultraGridColumn40.Hidden = true;
            ultraGridColumn40.Width = 27;
            ultraGridColumn41.Header.VisiblePosition = 4;
            ultraGridColumn41.Hidden = true;
            ultraGridColumn41.Width = 47;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn37,
            ultraGridColumn38,
            ultraGridColumn39,
            ultraGridColumn40,
            ultraGridColumn41});
            this.ultraDropDownPorcentajeIVA.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.ultraDropDownPorcentajeIVA.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.MaxBandDepth = 5;
            appearance67.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.ActiveCellAppearance = appearance67;
            appearance68.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance68.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance68.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance68.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.ActiveRowAppearance = appearance68;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance69.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.CardAreaAppearance = appearance69;
            appearance70.BackColor = System.Drawing.SystemColors.Control;
            appearance70.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance70.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.CellAppearance = appearance70;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance71.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance71.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance71.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance71.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance71.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.HeaderAppearance = appearance71;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance72.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.RowSelectorAppearance = appearance72;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance73.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.SelectedCellAppearance = appearance73;
            appearance74.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance74.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance74.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.SelectedRowAppearance = appearance74;
            appearance75.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance75.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance75;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPorcentajeIVA.DisplayMember = "Descripcion";
            this.ultraDropDownPorcentajeIVA.DropDownWidth = 250;
            this.ultraDropDownPorcentajeIVA.Location = new System.Drawing.Point(225, 295);
            this.ultraDropDownPorcentajeIVA.Name = "ultraDropDownPorcentajeIVA";
            this.ultraDropDownPorcentajeIVA.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownPorcentajeIVA.TabIndex = 72;
            this.ultraDropDownPorcentajeIVA.ValueMember = "idPorcentajeIVA";
            this.ultraDropDownPorcentajeIVA.Visible = false;
            // 
            // ultraDropDownTiposDeComprobante
            // 
            this.ultraDropDownTiposDeComprobante.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownTiposDeComprobante.DataSource = this.tiposDeComprobanteBindingSource;
            appearance11.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Appearance = appearance11;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand1.ColHeadersVisible = false;
            ultraGridColumn28.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn28.Header.VisiblePosition = 0;
            ultraGridColumn28.Hidden = true;
            ultraGridColumn29.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn29.Header.VisiblePosition = 1;
            ultraGridColumn30.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn30.Header.VisiblePosition = 2;
            ultraGridColumn30.Hidden = true;
            ultraGridColumn31.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn31.Header.VisiblePosition = 3;
            ultraGridColumn31.Hidden = true;
            ultraGridColumn32.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn32.Header.VisiblePosition = 4;
            ultraGridColumn32.Hidden = true;
            ultraGridColumn33.Header.VisiblePosition = 5;
            ultraGridColumn33.Hidden = true;
            ultraGridColumn34.Header.VisiblePosition = 6;
            ultraGridColumn34.Hidden = true;
            ultraGridColumn35.Header.VisiblePosition = 7;
            ultraGridColumn35.Hidden = true;
            ultraGridColumn36.Header.VisiblePosition = 8;
            ultraGridColumn36.Hidden = true;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn28,
            ultraGridColumn29,
            ultraGridColumn30,
            ultraGridColumn31,
            ultraGridColumn32,
            ultraGridColumn33,
            ultraGridColumn34,
            ultraGridColumn35,
            ultraGridColumn36});
            ultraGridBand1.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraDropDownTiposDeComprobante.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.MaxBandDepth = 5;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.ActiveCellAppearance = appearance12;
            appearance13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance13.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.ActiveRowAppearance = appearance13;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance14.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.CardAreaAppearance = appearance14;
            appearance15.BackColor = System.Drawing.SystemColors.Control;
            appearance15.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.CellAppearance = appearance15;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance16.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance16.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.HeaderAppearance = appearance16;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance17.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.RowSelectorAppearance = appearance17;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.SelectedCellAppearance = appearance18;
            appearance19.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance19.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.SelectedRowAppearance = appearance19;
            appearance20.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance20.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance20;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTiposDeComprobante.DisplayMember = "Nombre";
            this.ultraDropDownTiposDeComprobante.DropDownWidth = 0;
            this.ultraDropDownTiposDeComprobante.Location = new System.Drawing.Point(225, 336);
            this.ultraDropDownTiposDeComprobante.Name = "ultraDropDownTiposDeComprobante";
            this.ultraDropDownTiposDeComprobante.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownTiposDeComprobante.TabIndex = 73;
            this.ultraDropDownTiposDeComprobante.ValueMember = "idTipoDeComprobante";
            this.ultraDropDownTiposDeComprobante.Visible = false;
            // 
            // tiposDeComprobanteBindingSource
            // 
            this.tiposDeComprobanteBindingSource.DataMember = "TiposDeComprobante";
            this.tiposDeComprobanteBindingSource.DataSource = this.ds_TiposDeComprobante;
            // 
            // dsFacturaOriginal
            // 
            this.dsFacturaOriginal.DataSetName = "DsFacturaManual";
            this.dsFacturaOriginal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormFacturaManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(657, 625);
            this.Controls.Add(this.comprobantesManualesUltraGrid);
            this.Controls.Add(this.ultraDropDownTiposDeComprobante);
            this.Controls.Add(this.ultraDropDownPorcentajeIVA);
            this.Controls.Add(this.ultraDropDownNegocios);
            this.Controls.Add(this.ultraDropDownRenglonesFactura);
            this.Controls.Add(this.totalesUltraGrid);
            this.Controls.Add(this.ultraDropDownPrefijo);
            this.Controls.Add(this.ultraDropDownClientes);
            this.Controls.Add(this.ultraLabel1);
            this.Name = "FormFacturaManual";
            this.Text = "Factura Manual";
            this.Load += new System.EventHandler(this.FormFacturaManual_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraLabel1, 0);
            this.Controls.SetChildIndex(this.ultraDropDownClientes, 0);
            this.Controls.SetChildIndex(this.ultraDropDownPrefijo, 0);
            this.Controls.SetChildIndex(this.totalesUltraGrid, 0);
            this.Controls.SetChildIndex(this.ultraDropDownRenglonesFactura, 0);
            this.Controls.SetChildIndex(this.ultraDropDownNegocios, 0);
            this.Controls.SetChildIndex(this.ultraDropDownPorcentajeIVA, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTiposDeComprobante, 0);
            this.Controls.SetChildIndex(this.comprobantesManualesUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturaManual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobantesManualesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobantesManualesUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientesLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPuntosDeVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntosDeVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPrefijo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentajeIVABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPorcentajeIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCategoriasIVA1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNegocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negociosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParametros1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_TiposDeComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalesUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownRenglonesFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renglonesFacturaListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRenglonesFacturaLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownNegocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPorcentajeIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeComprobanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturaOriginal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private WS.DsFacturaManual dsFacturaManual;
        private System.Windows.Forms.BindingSource comprobantesManualesBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid comprobantesManualesUltraGrid;
        private WS.DsClientesLista dsClientesLista;
        private System.Windows.Forms.BindingSource clientesListaBindingSource;
        private WS.DsPuntosDeVenta dsPuntosDeVenta;
        private System.Windows.Forms.BindingSource puntosDeVentaBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownClientes;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownPrefijo;
        private System.Windows.Forms.BindingSource porcentajeIVABindingSource;
        private WS.DsPorcentajeIVA dsPorcentajeIVA;
        private DsCategoriasIVA dsCategoriasIVA1;
        private WS.DsNegocios dsNegocios;
        private System.Windows.Forms.BindingSource negociosBindingSource;
        private WS.DsParametros dsParametros1;
        private WS.DsTiposDeComprobante ds_TiposDeComprobante;
        private Infragistics.Win.UltraWinGrid.UltraGrid totalesUltraGrid;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownRenglonesFactura;
        private WS.DsRenglonesFacturaLista dsRenglonesFacturaLista;
        private System.Windows.Forms.BindingSource renglonesFacturaListaBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownNegocios;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownPorcentajeIVA;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSource1;
        private Infragistics.Win.UltraWinCalcManager.UltraCalcManager ultraCalcManager1;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTiposDeComprobante;
        private System.Windows.Forms.BindingSource tiposDeComprobanteBindingSource;
        private WS.DsFacturaManual dsFacturaOriginal;
    }
}
