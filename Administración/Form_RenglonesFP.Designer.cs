namespace Administración
{
    partial class FormRenglonesFP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Clientes", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn46 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn47 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RazonSocial");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn48 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreFantasia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn49 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCategoriaIva", -1, "ultraDropDownCategoriasIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn50 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_FacturasProforma_Clientes");
            Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_FacturasProforma_Clientes", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn51 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn52 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idFacturaProforma");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn53 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn54 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTandaDeFacturacion", -1, "ultraDropDownTandasDeFacturacion", 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn55 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_RenglonesFacturaProforma_FacturasProforma");
            Infragistics.Win.Appearance appearance56 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_RenglonesFacturaProforma_FacturasProforma", 1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn56 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idFacturaProforma");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn57 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRenglonFacturaProforma");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn58 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato", -1, "ultraDropDownContratos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn59 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPlan", -1, "ultraDropDownPlanes", 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn60 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn61 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario");
            Infragistics.Win.Appearance appearance57 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn62 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RevisarMensualmente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn63 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Titulares");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn64 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPorcentajeIVA", -1, "ultraDropDownPorcentajeIVA");
            Infragistics.Win.Appearance appearance58 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance51 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance52 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance53 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance54 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance55 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Planes", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn65 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPlan");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn66 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn67 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn68 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn69 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PadronExterno");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TandasDeFacturacion", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn43 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTandaDeFacturacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn44 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn45 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca");
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ContratosRenglonFP", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn70 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn71 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn72 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn73 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn74 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance124 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand7 = new Infragistics.Win.UltraWinGrid.UltraGridBand("PorcentajeIVA", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn75 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPorcentajeIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn76 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoAFIP");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn77 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn78 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn79 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Porcentaje");
            Infragistics.Win.Appearance appearance125 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance126 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance127 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance128 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance129 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance130 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance131 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance132 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance133 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand8 = new Infragistics.Win.UltraWinGrid.UltraGridBand("CategoriasIVA", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn80 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCategoriaIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn81 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn82 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn83 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ExigeCUIT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn84 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Factura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn85 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NdeC");
            Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance47 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance50 = new Infragistics.Win.Appearance();
            this.clientesUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRenglonesDeFactura = new Administración.WS.DsRenglonesDeFactura();
            this.ultraDropDownPlanes = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.planesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPlanes1 = new Administración.WS.DsPlanes();
            this.ultraDropDownTandasDeFacturacion = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tandasDeFacturacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTandasDeFacturacion = new Administración.WS.DsTandasDeFacturacion();
            this.ultraDropDownContratos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.contratosRenglonFPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsContratosLista = new Administración.WS.DsContratosLista();
            this.buttonContraer = new System.Windows.Forms.Button();
            this.buttonExpander = new System.Windows.Forms.Button();
            this.dsClientes = new Administración.WS.DsClientes();
            this.dsPorcentajeIVA = new Administración.WS.DsPorcentajeIVA();
            this.porcentajeIVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraDropDownPorcentajeIVA = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.dsCategoriasIVA = new Administración.WS.DsCategoriasIVA();
            this.categoriasIVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraDropDownCategoriasIVA = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRenglonesDeFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPlanes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTandasDeFacturacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tandasDeFacturacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTandasDeFacturacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownContratos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosRenglonFPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratosLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPorcentajeIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentajeIVABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPorcentajeIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCategoriasIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasIVABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCategoriasIVA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(872, 20);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(764, 20);
            this.buttonAplicar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonExpander);
            this.panel1.Controls.Add(this.buttonContraer);
            this.panel1.Location = new System.Drawing.Point(0, 601);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Size = new System.Drawing.Size(992, 62);
            this.panel1.Controls.SetChildIndex(this.buttonContraer, 0);
            this.panel1.Controls.SetChildIndex(this.buttonExpander, 0);
            this.panel1.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAplicar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAceptar, 0);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(656, 20);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // clientesUltraGrid
            // 
            this.clientesUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientesUltraGrid.DataSource = this.clientesBindingSource;
            appearance31.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance31.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.clientesUltraGrid.DisplayLayout.Appearance = appearance31;
            this.clientesUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn46.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn46.Header.VisiblePosition = 0;
            ultraGridColumn46.Hidden = true;
            ultraGridColumn46.Width = 122;
            ultraGridColumn47.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn47.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn47.Header.Caption = "Razón Social";
            ultraGridColumn47.Header.VisiblePosition = 1;
            ultraGridColumn47.Width = 416;
            ultraGridColumn48.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn48.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn48.Header.Caption = "Nombre Fantasía";
            ultraGridColumn48.Header.VisiblePosition = 2;
            ultraGridColumn48.Width = 331;
            ultraGridColumn49.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn49.Header.Caption = "Categoría IVA";
            ultraGridColumn49.Header.VisiblePosition = 3;
            ultraGridColumn49.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn49.Width = 201;
            ultraGridColumn50.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn50.Header.VisiblePosition = 4;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn46,
            ultraGridColumn47,
            ultraGridColumn48,
            ultraGridColumn49,
            ultraGridColumn50});
            appearance40.FontData.BoldAsString = "True";
            appearance40.FontData.SizeInPoints = 11F;
            appearance40.TextHAlignAsString = "Left";
            ultraGridBand1.Header.Appearance = appearance40;
            ultraGridBand1.HeaderVisible = true;
            ultraGridBand1.MaxRows = 1;
            ultraGridColumn51.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn51.Header.VisiblePosition = 0;
            ultraGridColumn51.Hidden = true;
            ultraGridColumn51.Width = 64;
            ultraGridColumn52.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn52.Header.VisiblePosition = 1;
            ultraGridColumn52.Hidden = true;
            ultraGridColumn52.Width = 112;
            ultraGridColumn53.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn53.Header.VisiblePosition = 3;
            ultraGridColumn53.Width = 408;
            ultraGridColumn54.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn54.Header.Caption = "Tanda de Facturación";
            ultraGridColumn54.Header.VisiblePosition = 2;
            ultraGridColumn54.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn54.Width = 521;
            ultraGridColumn55.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn55.Header.VisiblePosition = 4;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn51,
            ultraGridColumn52,
            ultraGridColumn53,
            ultraGridColumn54,
            ultraGridColumn55});
            appearance56.FontData.BoldAsString = "True";
            appearance56.FontData.SizeInPoints = 11F;
            appearance56.TextHAlignAsString = "Left";
            ultraGridBand2.Header.Appearance = appearance56;
            ultraGridBand2.Header.Caption = "Moldes de Factura";
            ultraGridBand2.HeaderVisible = true;
            ultraGridColumn56.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn56.Header.VisiblePosition = 0;
            ultraGridColumn56.Hidden = true;
            ultraGridColumn56.Width = 77;
            ultraGridColumn57.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn57.Header.VisiblePosition = 1;
            ultraGridColumn57.Hidden = true;
            ultraGridColumn57.Width = 111;
            ultraGridColumn58.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn58.Header.Caption = "Contrato";
            ultraGridColumn58.Header.VisiblePosition = 2;
            ultraGridColumn58.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn58.Width = 220;
            ultraGridColumn59.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn59.Header.Caption = "Plan";
            ultraGridColumn59.Header.VisiblePosition = 3;
            ultraGridColumn59.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn59.Width = 176;
            ultraGridColumn60.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn60.Header.VisiblePosition = 4;
            ultraGridColumn60.Width = 99;
            ultraGridColumn61.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance57.TextHAlignAsString = "Right";
            ultraGridColumn61.CellAppearance = appearance57;
            ultraGridColumn61.Header.Caption = "Precio Unitario";
            ultraGridColumn61.Header.VisiblePosition = 5;
            ultraGridColumn61.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn61.MaskInput = "{LOC}$ n,nnn,nnn.nnn";
            ultraGridColumn61.Width = 130;
            ultraGridColumn62.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn62.Header.Caption = "Revisar";
            ultraGridColumn62.Header.VisiblePosition = 6;
            ultraGridColumn62.Width = 74;
            ultraGridColumn63.Header.VisiblePosition = 7;
            ultraGridColumn63.Width = 78;
            ultraGridColumn64.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn64.Header.Caption = "IVA";
            ultraGridColumn64.Header.VisiblePosition = 8;
            ultraGridColumn64.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn64.Width = 133;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn56,
            ultraGridColumn57,
            ultraGridColumn58,
            ultraGridColumn59,
            ultraGridColumn60,
            ultraGridColumn61,
            ultraGridColumn62,
            ultraGridColumn63,
            ultraGridColumn64});
            appearance58.FontData.BoldAsString = "True";
            appearance58.FontData.SizeInPoints = 11F;
            appearance58.TextHAlignAsString = "Left";
            ultraGridBand3.Header.Appearance = appearance58;
            ultraGridBand3.Header.Caption = "Renglones del Molde de Factura";
            ultraGridBand3.HeaderVisible = true;
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.clientesUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.clientesUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.clientesUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance32.BackColor = System.Drawing.SystemColors.Window;
            this.clientesUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance32;
            appearance33.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance33.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance33.ForeColor = System.Drawing.SystemColors.WindowText;
            this.clientesUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance33;
            this.clientesUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.clientesUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.clientesUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.clientesUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.clientesUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.clientesUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.clientesUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance34.BackColor = System.Drawing.Color.Transparent;
            this.clientesUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance34;
            appearance39.BackColor = System.Drawing.SystemColors.Control;
            appearance39.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.clientesUltraGrid.DisplayLayout.Override.CellAppearance = appearance39;
            this.clientesUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance51.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance51.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance51.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance51.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.clientesUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance51;
            this.clientesUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance52.ForeColor = System.Drawing.Color.Red;
            this.clientesUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance52;
            this.clientesUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance53.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.clientesUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance53;
            appearance54.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance54.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance54.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.clientesUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance54;
            appearance55.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance55.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.clientesUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance55;
            this.clientesUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.clientesUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.clientesUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.clientesUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.clientesUltraGrid.Location = new System.Drawing.Point(0, -1);
            this.clientesUltraGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clientesUltraGrid.Name = "clientesUltraGrid";
            this.clientesUltraGrid.Size = new System.Drawing.Size(988, 614);
            this.clientesUltraGrid.TabIndex = 2;
            this.clientesUltraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.ClientesUltraGridInitializeRow);
            this.clientesUltraGrid.AfterEnterEditMode += new System.EventHandler(this.ClientesUltraGridAfterEnterEditMode);
            this.clientesUltraGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.ClientesUltraGridCellChange);
            this.clientesUltraGrid.BeforeRowDeactivate += new System.ComponentModel.CancelEventHandler(this.ClientesUltraGridBeforeRowDeactivate);
            this.clientesUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clientesUltraGrid_KeyDown);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.dsRenglonesDeFactura;
            // 
            // dsRenglonesDeFactura
            // 
            this.dsRenglonesDeFactura.DataSetName = "DsRenglonesDeFactura";
            this.dsRenglonesDeFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownPlanes
            // 
            this.ultraDropDownPlanes.DataSource = this.planesBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPlanes.DisplayLayout.Appearance = appearance1;
            ultraGridBand4.ColHeadersVisible = false;
            ultraGridColumn65.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn65.Header.VisiblePosition = 0;
            ultraGridColumn65.Hidden = true;
            ultraGridColumn65.Width = 48;
            ultraGridColumn66.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn66.Header.VisiblePosition = 1;
            ultraGridColumn66.Width = 231;
            ultraGridColumn67.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn67.Header.VisiblePosition = 2;
            ultraGridColumn67.Hidden = true;
            ultraGridColumn67.Width = 40;
            ultraGridColumn68.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn68.Header.VisiblePosition = 3;
            ultraGridColumn68.Hidden = true;
            ultraGridColumn68.Width = 58;
            ultraGridColumn69.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn69.Header.VisiblePosition = 4;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn65,
            ultraGridColumn66,
            ultraGridColumn67,
            ultraGridColumn68,
            ultraGridColumn69});
            this.ultraDropDownPlanes.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.ultraDropDownPlanes.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPlanes.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPlanes.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPlanes.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPlanes.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPlanes.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPlanes.DisplayLayout.Override.CellAppearance = appearance5;
            this.ultraDropDownPlanes.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPlanes.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.ultraDropDownPlanes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPlanes.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.ultraDropDownPlanes.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPlanes.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPlanes.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPlanes.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.ultraDropDownPlanes.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPlanes.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPlanes.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPlanes.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPlanes.DisplayMember = "Nombre";
            this.ultraDropDownPlanes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownPlanes.Location = new System.Drawing.Point(36, 139);
            this.ultraDropDownPlanes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ultraDropDownPlanes.Name = "ultraDropDownPlanes";
            this.ultraDropDownPlanes.Size = new System.Drawing.Size(317, 42);
            this.ultraDropDownPlanes.TabIndex = 31;
            this.ultraDropDownPlanes.ValueMember = "idPlan";
            this.ultraDropDownPlanes.Visible = false;
            this.ultraDropDownPlanes.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownPlanesFilterRow);
            // 
            // planesBindingSource
            // 
            this.planesBindingSource.DataMember = "Planes";
            this.planesBindingSource.DataSource = this.dsPlanes1;
            // 
            // dsPlanes1
            // 
            this.dsPlanes1.DataSetName = "DsPlanes";
            this.dsPlanes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownTandasDeFacturacion
            // 
            this.ultraDropDownTandasDeFacturacion.DataSource = this.tandasDeFacturacionBindingSource;
            appearance11.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Appearance = appearance11;
            ultraGridBand5.ColHeadersVisible = false;
            ultraGridColumn43.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn43.Header.VisiblePosition = 0;
            ultraGridColumn43.Hidden = true;
            ultraGridColumn44.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn44.Header.VisiblePosition = 1;
            ultraGridColumn44.Width = 231;
            ultraGridColumn45.Header.VisiblePosition = 2;
            ultraGridColumn45.Hidden = true;
            ultraGridBand5.Columns.AddRange(new object[] {
            ultraGridColumn43,
            ultraGridColumn44,
            ultraGridColumn45});
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.BandsSerializer.Add(ultraGridBand5);
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.MaxBandDepth = 5;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.ActiveCellAppearance = appearance12;
            appearance13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance13.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.ActiveRowAppearance = appearance13;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance14.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.CardAreaAppearance = appearance14;
            appearance15.BackColor = System.Drawing.SystemColors.Control;
            appearance15.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.CellAppearance = appearance15;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance16.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance16.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.HeaderAppearance = appearance16;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance17.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.RowSelectorAppearance = appearance17;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.SelectedCellAppearance = appearance18;
            appearance19.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance19.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.SelectedRowAppearance = appearance19;
            appearance20.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance20.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance20;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTandasDeFacturacion.DisplayMember = "Nombre";
            this.ultraDropDownTandasDeFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownTandasDeFacturacion.Location = new System.Drawing.Point(36, 188);
            this.ultraDropDownTandasDeFacturacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ultraDropDownTandasDeFacturacion.Name = "ultraDropDownTandasDeFacturacion";
            this.ultraDropDownTandasDeFacturacion.Size = new System.Drawing.Size(317, 42);
            this.ultraDropDownTandasDeFacturacion.TabIndex = 32;
            this.ultraDropDownTandasDeFacturacion.ValueMember = "idTandaDeFacturacion";
            this.ultraDropDownTandasDeFacturacion.Visible = false;
            // 
            // tandasDeFacturacionBindingSource
            // 
            this.tandasDeFacturacionBindingSource.DataMember = "TandasDeFacturacion";
            this.tandasDeFacturacionBindingSource.DataSource = this.dsTandasDeFacturacion;
            // 
            // dsTandasDeFacturacion
            // 
            this.dsTandasDeFacturacion.DataSetName = "DsTandasDeFacturacion";
            this.dsTandasDeFacturacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownContratos
            // 
            this.ultraDropDownContratos.DataSource = this.contratosRenglonFPBindingSource;
            appearance21.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownContratos.DisplayLayout.Appearance = appearance21;
            ultraGridBand6.ColHeadersVisible = false;
            ultraGridColumn70.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn70.Header.VisiblePosition = 0;
            ultraGridColumn70.Hidden = true;
            ultraGridColumn71.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn71.Header.VisiblePosition = 1;
            ultraGridColumn71.Width = 150;
            ultraGridColumn72.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn72.Header.VisiblePosition = 2;
            ultraGridColumn72.Hidden = true;
            ultraGridColumn73.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn73.Header.VisiblePosition = 3;
            ultraGridColumn73.Width = 50;
            ultraGridColumn74.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn74.Header.VisiblePosition = 4;
            ultraGridColumn74.Hidden = true;
            ultraGridBand6.Columns.AddRange(new object[] {
            ultraGridColumn70,
            ultraGridColumn71,
            ultraGridColumn72,
            ultraGridColumn73,
            ultraGridColumn74});
            this.ultraDropDownContratos.DisplayLayout.BandsSerializer.Add(ultraGridBand6);
            this.ultraDropDownContratos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownContratos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownContratos.DisplayLayout.MaxBandDepth = 5;
            appearance22.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownContratos.DisplayLayout.Override.ActiveCellAppearance = appearance22;
            appearance23.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance23.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance23.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownContratos.DisplayLayout.Override.ActiveRowAppearance = appearance23;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance24.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownContratos.DisplayLayout.Override.CardAreaAppearance = appearance24;
            appearance25.BackColor = System.Drawing.SystemColors.Control;
            appearance25.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownContratos.DisplayLayout.Override.CellAppearance = appearance25;
            this.ultraDropDownContratos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance26.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance26.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance26.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownContratos.DisplayLayout.Override.HeaderAppearance = appearance26;
            this.ultraDropDownContratos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance27.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownContratos.DisplayLayout.Override.RowSelectorAppearance = appearance27;
            this.ultraDropDownContratos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownContratos.DisplayLayout.Override.SelectedCellAppearance = appearance28;
            appearance29.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance29.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownContratos.DisplayLayout.Override.SelectedRowAppearance = appearance29;
            appearance30.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance30.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownContratos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance30;
            this.ultraDropDownContratos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownContratos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownContratos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownContratos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownContratos.DisplayMember = "Nombre";
            this.ultraDropDownContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownContratos.Location = new System.Drawing.Point(36, 238);
            this.ultraDropDownContratos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ultraDropDownContratos.Name = "ultraDropDownContratos";
            this.ultraDropDownContratos.Size = new System.Drawing.Size(317, 42);
            this.ultraDropDownContratos.TabIndex = 33;
            this.ultraDropDownContratos.ValueMember = "idContrato";
            this.ultraDropDownContratos.Visible = false;
            this.ultraDropDownContratos.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.UltraDropDownContratosInitializeRow);
            this.ultraDropDownContratos.RowSelected += new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(this.UltraDropDownContratosRowSelected);
            this.ultraDropDownContratos.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownContratosFilterRow);
            // 
            // contratosRenglonFPBindingSource
            // 
            this.contratosRenglonFPBindingSource.DataMember = "ContratosRenglonFP";
            this.contratosRenglonFPBindingSource.DataSource = this.dsContratosLista;
            // 
            // dsContratosLista
            // 
            this.dsContratosLista.DataSetName = "DsContratosLista";
            this.dsContratosLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonContraer
            // 
            this.buttonContraer.Location = new System.Drawing.Point(17, 20);
            this.buttonContraer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonContraer.Name = "buttonContraer";
            this.buttonContraer.Size = new System.Drawing.Size(121, 28);
            this.buttonContraer.TabIndex = 3;
            this.buttonContraer.Text = "Contraer Todo";
            this.buttonContraer.UseVisualStyleBackColor = true;
            this.buttonContraer.Click += new System.EventHandler(this.ButtonContraerClick);
            // 
            // buttonExpander
            // 
            this.buttonExpander.Location = new System.Drawing.Point(147, 20);
            this.buttonExpander.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExpander.Name = "buttonExpander";
            this.buttonExpander.Size = new System.Drawing.Size(120, 28);
            this.buttonExpander.TabIndex = 4;
            this.buttonExpander.Text = "Expandir Todo";
            this.buttonExpander.UseVisualStyleBackColor = true;
            this.buttonExpander.Click += new System.EventHandler(this.ButtonExpanderClick);
            // 
            // dsClientes
            // 
            this.dsClientes.DataSetName = "DsClientes";
            this.dsClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsPorcentajeIVA
            // 
            this.dsPorcentajeIVA.DataSetName = "DsPorcentajeIVA";
            this.dsPorcentajeIVA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // porcentajeIVABindingSource
            // 
            this.porcentajeIVABindingSource.DataMember = "PorcentajeIVA";
            this.porcentajeIVABindingSource.DataSource = this.dsPorcentajeIVA;
            // 
            // ultraDropDownPorcentajeIVA
            // 
            this.ultraDropDownPorcentajeIVA.DataSource = this.porcentajeIVABindingSource;
            appearance124.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance124.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance124.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Appearance = appearance124;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand7.ColHeadersVisible = false;
            ultraGridColumn75.Header.VisiblePosition = 0;
            ultraGridColumn75.Hidden = true;
            ultraGridColumn75.Width = 54;
            ultraGridColumn76.Header.VisiblePosition = 1;
            ultraGridColumn76.Hidden = true;
            ultraGridColumn76.Width = 45;
            ultraGridColumn77.Header.VisiblePosition = 2;
            ultraGridColumn77.Width = 227;
            ultraGridColumn78.Header.VisiblePosition = 3;
            ultraGridColumn78.Hidden = true;
            ultraGridColumn78.Width = 27;
            ultraGridColumn79.Header.VisiblePosition = 4;
            ultraGridColumn79.Hidden = true;
            ultraGridColumn79.Width = 47;
            ultraGridBand7.Columns.AddRange(new object[] {
            ultraGridColumn75,
            ultraGridColumn76,
            ultraGridColumn77,
            ultraGridColumn78,
            ultraGridColumn79});
            this.ultraDropDownPorcentajeIVA.DisplayLayout.BandsSerializer.Add(ultraGridBand7);
            this.ultraDropDownPorcentajeIVA.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.MaxBandDepth = 5;
            appearance125.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.ActiveCellAppearance = appearance125;
            appearance126.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance126.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance126.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance126.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.ActiveRowAppearance = appearance126;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance127.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.CardAreaAppearance = appearance127;
            appearance128.BackColor = System.Drawing.SystemColors.Control;
            appearance128.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance128.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.CellAppearance = appearance128;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance129.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance129.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance129.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance129.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance129.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.HeaderAppearance = appearance129;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance130.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.RowSelectorAppearance = appearance130;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance131.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.SelectedCellAppearance = appearance131;
            appearance132.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance132.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance132.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.SelectedRowAppearance = appearance132;
            appearance133.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance133.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance133;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPorcentajeIVA.DisplayMember = "Descripcion";
            this.ultraDropDownPorcentajeIVA.DropDownWidth = 250;
            this.ultraDropDownPorcentajeIVA.Location = new System.Drawing.Point(36, 287);
            this.ultraDropDownPorcentajeIVA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ultraDropDownPorcentajeIVA.Name = "ultraDropDownPorcentajeIVA";
            this.ultraDropDownPorcentajeIVA.Size = new System.Drawing.Size(317, 43);
            this.ultraDropDownPorcentajeIVA.TabIndex = 60;
            this.ultraDropDownPorcentajeIVA.ValueMember = "idPorcentajeIVA";
            this.ultraDropDownPorcentajeIVA.Visible = false;
            // 
            // dsCategoriasIVA
            // 
            this.dsCategoriasIVA.DataSetName = "DsCategoriasIVA";
            this.dsCategoriasIVA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriasIVABindingSource
            // 
            this.categoriasIVABindingSource.DataMember = "CategoriasIVA";
            this.categoriasIVABindingSource.DataSource = this.dsCategoriasIVA;
            // 
            // ultraDropDownCategoriasIVA
            // 
            this.ultraDropDownCategoriasIVA.DataSource = this.categoriasIVABindingSource;
            appearance41.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance41.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance41.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Appearance = appearance41;
            ultraGridBand8.ColHeadersVisible = false;
            ultraGridColumn80.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn80.Header.VisiblePosition = 0;
            ultraGridColumn80.Hidden = true;
            ultraGridColumn81.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn81.Header.VisiblePosition = 1;
            ultraGridColumn82.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn82.Header.VisiblePosition = 2;
            ultraGridColumn82.Hidden = true;
            ultraGridColumn83.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn83.Header.VisiblePosition = 3;
            ultraGridColumn83.Hidden = true;
            ultraGridColumn84.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn84.Header.VisiblePosition = 4;
            ultraGridColumn84.Hidden = true;
            ultraGridColumn85.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn85.Header.VisiblePosition = 5;
            ultraGridColumn85.Hidden = true;
            ultraGridBand8.Columns.AddRange(new object[] {
            ultraGridColumn80,
            ultraGridColumn81,
            ultraGridColumn82,
            ultraGridColumn83,
            ultraGridColumn84,
            ultraGridColumn85});
            ultraGridBand8.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand8.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownCategoriasIVA.DisplayLayout.BandsSerializer.Add(ultraGridBand8);
            this.ultraDropDownCategoriasIVA.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCategoriasIVA.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCategoriasIVA.DisplayLayout.MaxBandDepth = 5;
            appearance42.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.ActiveCellAppearance = appearance42;
            appearance43.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance43.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance43.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance43.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.ActiveRowAppearance = appearance43;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance44.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.CardAreaAppearance = appearance44;
            appearance45.BackColor = System.Drawing.SystemColors.Control;
            appearance45.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.CellAppearance = appearance45;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance46.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance46.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance46.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance46.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.HeaderAppearance = appearance46;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance47.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.RowSelectorAppearance = appearance47;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance48.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.SelectedCellAppearance = appearance48;
            appearance49.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance49.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.SelectedRowAppearance = appearance49;
            appearance50.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance50.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance50;
            this.ultraDropDownCategoriasIVA.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCategoriasIVA.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCategoriasIVA.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCategoriasIVA.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCategoriasIVA.DisplayMember = "Nombre";
            this.ultraDropDownCategoriasIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownCategoriasIVA.Location = new System.Drawing.Point(36, 337);
            this.ultraDropDownCategoriasIVA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ultraDropDownCategoriasIVA.Name = "ultraDropDownCategoriasIVA";
            this.ultraDropDownCategoriasIVA.Size = new System.Drawing.Size(317, 42);
            this.ultraDropDownCategoriasIVA.TabIndex = 61;
            this.ultraDropDownCategoriasIVA.ValueMember = "idCategoriaIVA";
            this.ultraDropDownCategoriasIVA.Visible = false;
            // 
            // FormRenglonesFP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(991, 660);
            this.Controls.Add(this.clientesUltraGrid);
            this.Controls.Add(this.ultraDropDownPlanes);
            this.Controls.Add(this.ultraDropDownTandasDeFacturacion);
            this.Controls.Add(this.ultraDropDownContratos);
            this.Controls.Add(this.ultraDropDownPorcentajeIVA);
            this.Controls.Add(this.ultraDropDownCategoriasIVA);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MinimumSize = new System.Drawing.Size(471, 230);
            this.Name = "FormRenglonesFP";
            this.Text = "Facturas pro forma";
            this.Load += new System.EventHandler(this.FormRenglonesFPLoad);
            this.Controls.SetChildIndex(this.ultraDropDownCategoriasIVA, 0);
            this.Controls.SetChildIndex(this.ultraDropDownPorcentajeIVA, 0);
            this.Controls.SetChildIndex(this.ultraDropDownContratos, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTandasDeFacturacion, 0);
            this.Controls.SetChildIndex(this.ultraDropDownPlanes, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.clientesUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientesUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRenglonesDeFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPlanes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTandasDeFacturacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tandasDeFacturacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTandasDeFacturacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownContratos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosRenglonFPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratosLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPorcentajeIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentajeIVABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPorcentajeIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCategoriasIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasIVABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCategoriasIVA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WS.DsRenglonesDeFactura dsRenglonesDeFactura;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid clientesUltraGrid;
        private WS.DsTandasDeFacturacion dsTandasDeFacturacion;
        private System.Windows.Forms.BindingSource tandasDeFacturacionBindingSource;
        private WS.DsPlanes dsPlanes1;
        private System.Windows.Forms.BindingSource planesBindingSource;
        private WS.DsContratosLista dsContratosLista;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownPlanes;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTandasDeFacturacion;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownContratos;
        private System.Windows.Forms.BindingSource contratosRenglonFPBindingSource;
        private System.Windows.Forms.Button buttonExpander;
        private System.Windows.Forms.Button buttonContraer;
        private Administración.WS.DsClientes dsClientes;
        private WS.DsPorcentajeIVA dsPorcentajeIVA;
        private System.Windows.Forms.BindingSource porcentajeIVABindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownPorcentajeIVA;
        private WS.DsCategoriasIVA dsCategoriasIVA;
        private System.Windows.Forms.BindingSource categoriasIVABindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCategoriasIVA;
    }
}
