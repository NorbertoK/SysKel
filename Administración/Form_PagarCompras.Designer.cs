namespace Administración
{
    partial class FormPagarCompras
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Proveedores", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RazonSocial");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreFantasia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CUIT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRubro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCategoriaIva");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresosBrutos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_NegociosDelProveedor_Proveedores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Direcciones_Proveedores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Emails_Proveedores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Contactos_Proveedores");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_NegociosDelProveedor_Proveedores", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocioDelProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Porcentaje");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Direcciones_Proveedores", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn21 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Real");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn22 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn23 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn24 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn25 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Piso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn26 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Departamento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn27 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle1");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn28 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle2");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn29 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idZona");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn30 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn31 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn32 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn33 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn34 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK__Telefonos__idDir__4850AF91");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK__Telefonos__idDir__4850AF91", 2);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn35 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn36 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn37 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Emails_Proveedores", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn38 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmail");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn39 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Email");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn40 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Contactos_Proveedores", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn41 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn42 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn43 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn44 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn45 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Telefonos_Contactos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn46 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Emails_Contactos");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand7 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Telefonos_Contactos", 5);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn47 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn48 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn49 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand8 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Emails_Contactos", 5);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn50 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmail");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn51 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Email");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn52 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand9 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ComprasImpagas", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn53 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCompra");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn54 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Comprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn55 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn56 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn57 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo");
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn58 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn59 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca", 0);
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            this.proveedoresUltraCombo = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProveedores = new Administración.WS.DsProveedores();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.comprasImpagasUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.comprasImpagasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsComprasImpagas = new Administración.WS.DsComprasImpagas();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresUltraCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasImpagasUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasImpagasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComprasImpagas)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(541, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(206, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 348);
            this.panel1.Size = new System.Drawing.Size(631, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(460, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // proveedoresUltraCombo
            // 
            this.proveedoresUltraCombo.DataSource = this.proveedoresBindingSource;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Hidden = true;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Hidden = true;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.Hidden = true;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.Hidden = true;
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridColumn7.Header.VisiblePosition = 6;
            ultraGridColumn7.Hidden = true;
            ultraGridColumn8.Header.VisiblePosition = 7;
            ultraGridColumn8.Hidden = true;
            ultraGridColumn9.Header.VisiblePosition = 8;
            ultraGridColumn9.Hidden = true;
            ultraGridColumn10.Header.VisiblePosition = 9;
            ultraGridColumn10.Hidden = true;
            ultraGridColumn11.Header.VisiblePosition = 10;
            ultraGridColumn11.Hidden = true;
            ultraGridColumn12.Header.VisiblePosition = 11;
            ultraGridColumn13.Header.VisiblePosition = 12;
            ultraGridColumn14.Header.VisiblePosition = 13;
            ultraGridColumn15.Header.VisiblePosition = 14;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8,
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12,
            ultraGridColumn13,
            ultraGridColumn14,
            ultraGridColumn15});
            ultraGridBand1.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal;
            ultraGridBand1.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            ultraGridColumn16.Header.VisiblePosition = 0;
            ultraGridColumn17.Header.VisiblePosition = 1;
            ultraGridColumn18.Header.VisiblePosition = 2;
            ultraGridColumn19.Header.VisiblePosition = 3;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn16,
            ultraGridColumn17,
            ultraGridColumn18,
            ultraGridColumn19});
            ultraGridColumn20.Header.VisiblePosition = 0;
            ultraGridColumn21.Header.VisiblePosition = 1;
            ultraGridColumn22.Header.VisiblePosition = 2;
            ultraGridColumn23.Header.VisiblePosition = 3;
            ultraGridColumn24.Header.VisiblePosition = 4;
            ultraGridColumn25.Header.VisiblePosition = 5;
            ultraGridColumn26.Header.VisiblePosition = 6;
            ultraGridColumn27.Header.VisiblePosition = 7;
            ultraGridColumn28.Header.VisiblePosition = 8;
            ultraGridColumn29.Header.VisiblePosition = 9;
            ultraGridColumn30.Header.VisiblePosition = 10;
            ultraGridColumn31.Header.VisiblePosition = 11;
            ultraGridColumn32.Header.VisiblePosition = 12;
            ultraGridColumn33.Header.VisiblePosition = 13;
            ultraGridColumn34.Header.VisiblePosition = 14;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn20,
            ultraGridColumn21,
            ultraGridColumn22,
            ultraGridColumn23,
            ultraGridColumn24,
            ultraGridColumn25,
            ultraGridColumn26,
            ultraGridColumn27,
            ultraGridColumn28,
            ultraGridColumn29,
            ultraGridColumn30,
            ultraGridColumn31,
            ultraGridColumn32,
            ultraGridColumn33,
            ultraGridColumn34});
            ultraGridColumn35.Header.VisiblePosition = 0;
            ultraGridColumn36.Header.VisiblePosition = 1;
            ultraGridColumn37.Header.VisiblePosition = 2;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn35,
            ultraGridColumn36,
            ultraGridColumn37});
            ultraGridColumn38.Header.VisiblePosition = 0;
            ultraGridColumn39.Header.VisiblePosition = 1;
            ultraGridColumn40.Header.VisiblePosition = 2;
            ultraGridBand5.Columns.AddRange(new object[] {
            ultraGridColumn38,
            ultraGridColumn39,
            ultraGridColumn40});
            ultraGridColumn41.Header.VisiblePosition = 0;
            ultraGridColumn42.Header.VisiblePosition = 1;
            ultraGridColumn43.Header.VisiblePosition = 2;
            ultraGridColumn44.Header.VisiblePosition = 3;
            ultraGridColumn45.Header.VisiblePosition = 4;
            ultraGridColumn46.Header.VisiblePosition = 5;
            ultraGridBand6.Columns.AddRange(new object[] {
            ultraGridColumn41,
            ultraGridColumn42,
            ultraGridColumn43,
            ultraGridColumn44,
            ultraGridColumn45,
            ultraGridColumn46});
            ultraGridColumn47.Header.VisiblePosition = 0;
            ultraGridColumn48.Header.VisiblePosition = 1;
            ultraGridColumn49.Header.VisiblePosition = 2;
            ultraGridBand7.Columns.AddRange(new object[] {
            ultraGridColumn47,
            ultraGridColumn48,
            ultraGridColumn49});
            ultraGridColumn50.Header.VisiblePosition = 0;
            ultraGridColumn51.Header.VisiblePosition = 1;
            ultraGridColumn52.Header.VisiblePosition = 2;
            ultraGridBand8.Columns.AddRange(new object[] {
            ultraGridColumn50,
            ultraGridColumn51,
            ultraGridColumn52});
            this.proveedoresUltraCombo.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.proveedoresUltraCombo.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.proveedoresUltraCombo.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.proveedoresUltraCombo.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.proveedoresUltraCombo.DisplayLayout.BandsSerializer.Add(ultraGridBand5);
            this.proveedoresUltraCombo.DisplayLayout.BandsSerializer.Add(ultraGridBand6);
            this.proveedoresUltraCombo.DisplayLayout.BandsSerializer.Add(ultraGridBand7);
            this.proveedoresUltraCombo.DisplayLayout.BandsSerializer.Add(ultraGridBand8);
            this.proveedoresUltraCombo.DisplayMember = "NombreCompleto";
            this.proveedoresUltraCombo.Location = new System.Drawing.Point(74, 12);
            this.proveedoresUltraCombo.Name = "proveedoresUltraCombo";
            this.proveedoresUltraCombo.Size = new System.Drawing.Size(456, 22);
            this.proveedoresUltraCombo.TabIndex = 2;
            this.proveedoresUltraCombo.ValueMember = "idProveedor";
            this.proveedoresUltraCombo.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.proveedoresUltraCombo_BeforeDropDown);
            this.proveedoresUltraCombo.ValueChanged += new System.EventHandler(this.ProveedoresUltraComboValueChanged);
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.dsProveedores;
            // 
            // dsProveedores
            // 
            this.dsProveedores.DataSetName = "DsProveedores";
            this.dsProveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.AutoSize = true;
            this.ultraLabel1.Location = new System.Drawing.Point(12, 16);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(56, 14);
            this.ultraLabel1.TabIndex = 3;
            this.ultraLabel1.Text = "Proveedor";
            // 
            // comprasImpagasUltraGrid
            // 
            this.comprasImpagasUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comprasImpagasUltraGrid.DataSource = this.comprasImpagasBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.comprasImpagasUltraGrid.DisplayLayout.Appearance = appearance1;
            ultraGridColumn53.Header.VisiblePosition = 0;
            ultraGridColumn53.Hidden = true;
            ultraGridColumn54.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn54.Header.Caption = "Factura";
            ultraGridColumn54.Header.VisiblePosition = 2;
            ultraGridColumn54.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn54.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn54.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn54.MaskInput = "####-########";
            ultraGridColumn54.Width = 85;
            appearance2.TextHAlignAsString = "Center";
            ultraGridColumn55.CellAppearance = appearance2;
            ultraGridColumn55.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn55.Header.VisiblePosition = 3;
            ultraGridColumn55.Width = 69;
            appearance3.TextHAlignAsString = "Right";
            ultraGridColumn56.CellAppearance = appearance3;
            ultraGridColumn56.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn56.Header.VisiblePosition = 5;
            ultraGridColumn56.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            appearance4.TextHAlignAsString = "Right";
            ultraGridColumn57.CellAppearance = appearance4;
            ultraGridColumn57.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn57.Header.VisiblePosition = 6;
            ultraGridColumn57.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn58.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn58.Header.VisiblePosition = 4;
            ultraGridColumn58.Width = 238;
            ultraGridColumn59.DataType = typeof(bool);
            ultraGridColumn59.DefaultCellValue = false;
            ultraGridColumn59.Header.VisiblePosition = 1;
            ultraGridColumn59.Width = 34;
            ultraGridBand9.Columns.AddRange(new object[] {
            ultraGridColumn53,
            ultraGridColumn54,
            ultraGridColumn55,
            ultraGridColumn56,
            ultraGridColumn57,
            ultraGridColumn58,
            ultraGridColumn59});
            ultraGridBand9.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            ultraGridBand9.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.comprasImpagasUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand9);
            this.comprasImpagasUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.comprasImpagasUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.comprasImpagasUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance5.BackColor = System.Drawing.SystemColors.Window;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance6;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance7.BackColor = System.Drawing.Color.Transparent;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance7;
            appearance8.BackColor = System.Drawing.SystemColors.Control;
            appearance8.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.CellAppearance = appearance8;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance9.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance9;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance10.ForeColor = System.Drawing.Color.Red;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance10;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance14;
            appearance15.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance15.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance15;
            appearance16.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance16.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance16;
            this.comprasImpagasUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comprasImpagasUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.comprasImpagasUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.comprasImpagasUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.comprasImpagasUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comprasImpagasUltraGrid.Location = new System.Drawing.Point(0, 73);
            this.comprasImpagasUltraGrid.Name = "comprasImpagasUltraGrid";
            this.comprasImpagasUltraGrid.Size = new System.Drawing.Size(628, 285);
            this.comprasImpagasUltraGrid.TabIndex = 3;
            this.comprasImpagasUltraGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.ComprasImpagasUltraGridCellChange);
            this.comprasImpagasUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comprasImpagasUltraGrid_KeyDown);
            // 
            // comprasImpagasBindingSource
            // 
            this.comprasImpagasBindingSource.DataMember = "ComprasImpagas";
            this.comprasImpagasBindingSource.DataSource = this.dsComprasImpagas;
            // 
            // dsComprasImpagas
            // 
            this.dsComprasImpagas.DataSetName = "DsComprasImpagas";
            this.dsComprasImpagas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensaje.ForeColor = System.Drawing.Color.Red;
            this.labelMensaje.Location = new System.Drawing.Point(12, 46);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(161, 13);
            this.labelMensaje.TabIndex = 9;
            this.labelMensaje.Text = "No hay compras con saldo.";
            this.labelMensaje.Visible = false;
            // 
            // FormPagarCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(630, 396);
            this.Controls.Add(this.labelMensaje);
            this.Controls.Add(this.comprasImpagasUltraGrid);
            this.Controls.Add(this.ultraLabel1);
            this.Controls.Add(this.proveedoresUltraCombo);
            this.Name = "FormPagarCompras";
            this.Text = "Pagar Compras";
            this.Load += new System.EventHandler(this.FormPagarComprasLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.proveedoresUltraCombo, 0);
            this.Controls.SetChildIndex(this.ultraLabel1, 0);
            this.Controls.SetChildIndex(this.comprasImpagasUltraGrid, 0);
            this.Controls.SetChildIndex(this.labelMensaje, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresUltraCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasImpagasUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasImpagasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComprasImpagas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WS.DsProveedores dsProveedores;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraCombo proveedoresUltraCombo;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private WS.DsComprasImpagas dsComprasImpagas;
        private System.Windows.Forms.BindingSource comprasImpagasBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid comprasImpagasUltraGrid;
        private System.Windows.Forms.Label labelMensaje;
    }
}
