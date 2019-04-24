using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    partial class FormCambioDeCobrador
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("CambiosDeCobrador", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCambioDeCobrador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCobrador1", -1, "ultraDropDownCobradores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCobrador2", -1, "ultraDropDownCobradores", 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Motivo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idZona", -1, "ultraDropDownZonas");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idGrabador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CambiarFuturo");
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_ComprobantesCambioDeCobrador_CambiosDeCobrador");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_ComprobantesCambioDeCobrador_CambiosDeCobrador", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idComprobantesCambioDeCobrador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCambioDeCobrador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe", 0);
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings1 = new Infragistics.Win.UltraWinGrid.SummarySettings("SumComprobantes", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "Importe", 0, false, "FK_ComprobantesCambioDeCobrador_CambiosDeCobrador", 1, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "Importe", 0, false);
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EmpleadosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance129 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Zonas", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn21 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idZona");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn22 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn23 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn24 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn25 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCobrador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn26 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPuntoDeVenta");
            Infragistics.Win.Appearance appearance130 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance131 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance132 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance133 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance134 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance135 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance136 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance137 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance138 = new Infragistics.Win.Appearance();
            this.dsCambiosDeCobrador = new Administración.WS.DsCambiosDeCobrador();
            this.cambiosDeCobradorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cambiosDeCobradorUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraDropDownCobradores = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.cobradoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEmpleadosLista1 = new Administración.WS.DsEmpleadosLista();
            this.ultraLabelMensaje = new Infragistics.Win.Misc.UltraLabel();
            this.dsZonas = new Administración.WS.DsZonas();
            this.zonasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraDropDownZonas = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCambiosDeCobrador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cambiosDeCobradorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cambiosDeCobradorUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCobradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobradoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleadosLista1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownZonas)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(216, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(135, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ultraLabelMensaje);
            this.panel1.Location = new System.Drawing.Point(0, 410);
            this.panel1.Size = new System.Drawing.Size(306, 50);
            this.panel1.Controls.SetChildIndex(this.buttonAplicar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAceptar, 0);
            this.panel1.Controls.SetChildIndex(this.ultraLabelMensaje, 0);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(135, 15);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // dsCambiosDeCobrador
            // 
            this.dsCambiosDeCobrador.DataSetName = "DsCambiosDeCobrador";
            this.dsCambiosDeCobrador.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cambiosDeCobradorBindingSource
            // 
            this.cambiosDeCobradorBindingSource.DataMember = "CambiosDeCobrador";
            this.cambiosDeCobradorBindingSource.DataSource = this.dsCambiosDeCobrador;
            // 
            // cambiosDeCobradorUltraGrid
            // 
            this.cambiosDeCobradorUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cambiosDeCobradorUltraGrid.DataSource = this.cambiosDeCobradorBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.cambiosDeCobradorUltraGrid.DisplayLayout.Appearance = appearance1;
            this.cambiosDeCobradorUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 67;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance2.TextHAlignAsString = "Center";
            ultraGridColumn2.CellAppearance = appearance2;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Hidden = true;
            ultraGridColumn2.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn2.MaskInput = "dd/mm/yyyy";
            ultraGridColumn2.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn2.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(125, 0);
            ultraGridColumn2.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(125, 0);
            ultraGridColumn2.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn2.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn2.Width = 75;
            ultraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn3.Header.Caption = "De Cobrador";
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.NullText = "Sin Cobrador";
            ultraGridColumn3.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn3.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(225, 0);
            ultraGridColumn3.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn3.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn3.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn3.Width = 110;
            ultraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn4.Header.Caption = "A Cobrador";
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn4.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(225, 0);
            ultraGridColumn4.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn4.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn4.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn4.Width = 110;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn5.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn5.RowLayoutColumnInfo.OriginY = 6;
            ultraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(304, 31);
            ultraGridColumn5.RowLayoutColumnInfo.SpanX = 6;
            ultraGridColumn5.RowLayoutColumnInfo.SpanY = 4;
            ultraGridColumn5.Width = 134;
            ultraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn6.Header.Caption = "Zona";
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridColumn6.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn6.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn6.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn6.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn7.Header.VisiblePosition = 6;
            ultraGridColumn7.Hidden = true;
            ultraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            appearance3.TextHAlignAsString = "Center";
            ultraGridColumn8.CellAppearance = appearance3;
            ultraGridColumn8.DefaultCellValue = "False";
            ultraGridColumn8.Header.Caption = "Cambiar Futuro";
            ultraGridColumn8.Header.VisiblePosition = 7;
            ultraGridColumn8.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn8.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn8.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(110, 0);
            ultraGridColumn8.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(110, 0);
            ultraGridColumn8.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn8.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn9.Header.VisiblePosition = 8;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8,
            ultraGridColumn9});
            ultraGridBand1.MaxRows = 1;
            ultraGridBand1.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn10.Header.VisiblePosition = 0;
            ultraGridColumn10.Hidden = true;
            ultraGridColumn10.Width = 84;
            ultraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn11.Header.VisiblePosition = 1;
            ultraGridColumn11.Hidden = true;
            ultraGridColumn11.Width = 60;
            ultraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn12.Header.Caption = "Referencia";
            ultraGridColumn12.Header.VisiblePosition = 2;
            ultraGridColumn12.Width = 134;
            ultraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn13.DataType = typeof(decimal);
            ultraGridColumn13.Header.VisiblePosition = 3;
            ultraGridColumn13.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn13.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn13.Width = 113;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12,
            ultraGridColumn13});
            summarySettings1.DisplayFormat = "Total = {0:c}";
            summarySettings1.GroupBySummaryValueAppearance = appearance4;
            ultraGridBand2.Summaries.AddRange(new Infragistics.Win.UltraWinGrid.SummarySettings[] {
            summarySettings1});
            ultraGridBand2.SummaryFooterCaption = "";
            this.cambiosDeCobradorUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.cambiosDeCobradorUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.cambiosDeCobradorUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.cambiosDeCobradorUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.cambiosDeCobradorUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance5.BackColor = System.Drawing.SystemColors.Window;
            this.cambiosDeCobradorUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cambiosDeCobradorUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance6;
            this.cambiosDeCobradorUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.cambiosDeCobradorUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.cambiosDeCobradorUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.cambiosDeCobradorUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.cambiosDeCobradorUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.cambiosDeCobradorUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.cambiosDeCobradorUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance7.BackColor = System.Drawing.Color.Transparent;
            this.cambiosDeCobradorUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance7;
            appearance8.BackColor = System.Drawing.SystemColors.Control;
            appearance8.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.cambiosDeCobradorUltraGrid.DisplayLayout.Override.CellAppearance = appearance8;
            this.cambiosDeCobradorUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance9.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.cambiosDeCobradorUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance9;
            this.cambiosDeCobradorUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance10.ForeColor = System.Drawing.Color.Red;
            this.cambiosDeCobradorUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance10;
            this.cambiosDeCobradorUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.cambiosDeCobradorUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance11;
            appearance12.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance12.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.cambiosDeCobradorUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance12;
            appearance13.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance13.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.cambiosDeCobradorUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance13;
            this.cambiosDeCobradorUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cambiosDeCobradorUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.cambiosDeCobradorUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.cambiosDeCobradorUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.cambiosDeCobradorUltraGrid.Location = new System.Drawing.Point(0, -1);
            this.cambiosDeCobradorUltraGrid.Name = "cambiosDeCobradorUltraGrid";
            this.cambiosDeCobradorUltraGrid.Size = new System.Drawing.Size(306, 421);
            this.cambiosDeCobradorUltraGrid.TabIndex = 2;
            this.cambiosDeCobradorUltraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.CambiosDeCobradorUltraGridInitializeRow);
            this.cambiosDeCobradorUltraGrid.AfterEnterEditMode += new System.EventHandler(this.cambiosDeCobradorUltraGrid_AfterEnterEditMode);
            this.cambiosDeCobradorUltraGrid.AfterRowExpanded += new Infragistics.Win.UltraWinGrid.RowEventHandler(this.CambiosDeCobradorUltraGridAfterRowExpanded);
            this.cambiosDeCobradorUltraGrid.CellListSelect += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.CambiosDeCobradorUltraGridCellListSelect);
            this.cambiosDeCobradorUltraGrid.BeforeCellDeactivate += new System.ComponentModel.CancelEventHandler(this.CambiosDeCobradorUltraGridBeforeCellDeactivate);
            this.cambiosDeCobradorUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cambiosDeCobradorUltraGrid_KeyDown);
            // 
            // ultraDropDownCobradores
            // 
            this.ultraDropDownCobradores.DataSource = this.cobradoresBindingSource;
            appearance14.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCobradores.DisplayLayout.Appearance = appearance14;
            this.ultraDropDownCobradores.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand3.ColHeadersVisible = false;
            ultraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn14.Header.VisiblePosition = 0;
            ultraGridColumn14.Hidden = true;
            ultraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn15.Header.VisiblePosition = 1;
            ultraGridColumn15.Hidden = true;
            ultraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn16.Header.VisiblePosition = 2;
            ultraGridColumn16.Hidden = true;
            ultraGridColumn17.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn17.Header.VisiblePosition = 3;
            ultraGridColumn17.Hidden = true;
            ultraGridColumn18.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn18.Header.VisiblePosition = 4;
            ultraGridColumn19.Header.VisiblePosition = 6;
            ultraGridColumn19.Hidden = true;
            ultraGridColumn20.Header.VisiblePosition = 5;
            ultraGridColumn20.Hidden = true;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn14,
            ultraGridColumn15,
            ultraGridColumn16,
            ultraGridColumn17,
            ultraGridColumn18,
            ultraGridColumn19,
            ultraGridColumn20});
            ultraGridBand3.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand3.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownCobradores.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.ultraDropDownCobradores.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCobradores.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCobradores.DisplayLayout.MaxBandDepth = 5;
            appearance15.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCobradores.DisplayLayout.Override.ActiveCellAppearance = appearance15;
            appearance16.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance16.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance16.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCobradores.DisplayLayout.Override.ActiveRowAppearance = appearance16;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance17.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCobradores.DisplayLayout.Override.CardAreaAppearance = appearance17;
            appearance18.BackColor = System.Drawing.SystemColors.Control;
            appearance18.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCobradores.DisplayLayout.Override.CellAppearance = appearance18;
            this.ultraDropDownCobradores.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance19.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance19.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance19.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCobradores.DisplayLayout.Override.HeaderAppearance = appearance19;
            this.ultraDropDownCobradores.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance20.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCobradores.DisplayLayout.Override.RowSelectorAppearance = appearance20;
            this.ultraDropDownCobradores.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCobradores.DisplayLayout.Override.SelectedCellAppearance = appearance21;
            appearance22.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance22.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCobradores.DisplayLayout.Override.SelectedRowAppearance = appearance22;
            appearance23.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance23.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCobradores.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance23;
            this.ultraDropDownCobradores.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCobradores.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCobradores.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCobradores.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCobradores.DisplayMember = "ApelNomb";
            this.ultraDropDownCobradores.DropDownWidth = 250;
            this.ultraDropDownCobradores.Location = new System.Drawing.Point(0, 273);
            this.ultraDropDownCobradores.Name = "ultraDropDownCobradores";
            this.ultraDropDownCobradores.Size = new System.Drawing.Size(238, 33);
            this.ultraDropDownCobradores.TabIndex = 21;
            this.ultraDropDownCobradores.ValueMember = "idEmpleado";
            this.ultraDropDownCobradores.Visible = false;
            this.ultraDropDownCobradores.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownCobradoresFilterRow);
            // 
            // cobradoresBindingSource
            // 
            this.cobradoresBindingSource.DataMember = "EmpleadosLista";
            this.cobradoresBindingSource.DataSource = this.dsEmpleadosLista1;
            // 
            // dsEmpleadosLista1
            // 
            this.dsEmpleadosLista1.DataSetName = "DsEmpleadosLista";
            this.dsEmpleadosLista1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraLabelMensaje
            // 
            this.ultraLabelMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ultraLabelMensaje.Location = new System.Drawing.Point(108, 20);
            this.ultraLabelMensaje.Name = "ultraLabelMensaje";
            this.ultraLabelMensaje.Size = new System.Drawing.Size(51, 14);
            this.ultraLabelMensaje.TabIndex = 5;
            this.ultraLabelMensaje.Text = "Espere...";
            this.ultraLabelMensaje.Visible = false;
            // 
            // dsZonas
            // 
            this.dsZonas.DataSetName = "DsZonas";
            this.dsZonas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zonasBindingSource
            // 
            this.zonasBindingSource.DataMember = "Zonas";
            this.zonasBindingSource.DataSource = this.dsZonas;
            // 
            // ultraDropDownZonas
            // 
            this.ultraDropDownZonas.DataSource = this.zonasBindingSource;
            appearance129.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance129.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance129.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownZonas.DisplayLayout.Appearance = appearance129;
            ultraGridBand4.ColHeadersVisible = false;
            ultraGridColumn21.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn21.Header.VisiblePosition = 0;
            ultraGridColumn21.Hidden = true;
            ultraGridColumn22.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn22.Header.VisiblePosition = 1;
            ultraGridColumn23.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn23.Header.VisiblePosition = 2;
            ultraGridColumn23.Hidden = true;
            ultraGridColumn24.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn24.Header.VisiblePosition = 3;
            ultraGridColumn24.Hidden = true;
            ultraGridColumn25.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn25.Header.VisiblePosition = 4;
            ultraGridColumn25.Hidden = true;
            ultraGridColumn26.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn26.Header.VisiblePosition = 5;
            ultraGridColumn26.Hidden = true;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn21,
            ultraGridColumn22,
            ultraGridColumn23,
            ultraGridColumn24,
            ultraGridColumn25,
            ultraGridColumn26});
            ultraGridBand4.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand4.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownZonas.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.ultraDropDownZonas.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownZonas.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownZonas.DisplayLayout.MaxBandDepth = 5;
            appearance130.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownZonas.DisplayLayout.Override.ActiveCellAppearance = appearance130;
            appearance131.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance131.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance131.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance131.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownZonas.DisplayLayout.Override.ActiveRowAppearance = appearance131;
            this.ultraDropDownZonas.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownZonas.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownZonas.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownZonas.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownZonas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownZonas.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownZonas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance132.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownZonas.DisplayLayout.Override.CardAreaAppearance = appearance132;
            appearance133.BackColor = System.Drawing.SystemColors.Control;
            appearance133.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance133.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownZonas.DisplayLayout.Override.CellAppearance = appearance133;
            this.ultraDropDownZonas.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance134.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance134.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance134.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance134.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance134.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownZonas.DisplayLayout.Override.HeaderAppearance = appearance134;
            this.ultraDropDownZonas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance135.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownZonas.DisplayLayout.Override.RowSelectorAppearance = appearance135;
            this.ultraDropDownZonas.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance136.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownZonas.DisplayLayout.Override.SelectedCellAppearance = appearance136;
            appearance137.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance137.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance137.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownZonas.DisplayLayout.Override.SelectedRowAppearance = appearance137;
            appearance138.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance138.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownZonas.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance138;
            this.ultraDropDownZonas.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownZonas.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownZonas.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownZonas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownZonas.DisplayMember = "Nombre";
            this.ultraDropDownZonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownZonas.Location = new System.Drawing.Point(0, 233);
            this.ultraDropDownZonas.Name = "ultraDropDownZonas";
            this.ultraDropDownZonas.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownZonas.TabIndex = 22;
            this.ultraDropDownZonas.ValueMember = "idZona";
            this.ultraDropDownZonas.Visible = false;
            this.ultraDropDownZonas.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownZonasFilterRow);
            // 
            // FormCambioDeCobrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(305, 458);
            this.Controls.Add(this.cambiosDeCobradorUltraGrid);
            this.Controls.Add(this.ultraDropDownZonas);
            this.Controls.Add(this.ultraDropDownCobradores);
            this.Name = "FormCambioDeCobrador";
            this.Text = "Cambio de Cobrador";
            this.Activated += new System.EventHandler(this.FormCambioDeCobradorActivated);
            this.Controls.SetChildIndex(this.ultraDropDownCobradores, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraDropDownZonas, 0);
            this.Controls.SetChildIndex(this.cambiosDeCobradorUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsCambiosDeCobrador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cambiosDeCobradorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cambiosDeCobradorUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCobradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobradoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleadosLista1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownZonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WS.DsCambiosDeCobrador dsCambiosDeCobrador;
        private System.Windows.Forms.BindingSource cambiosDeCobradorBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid cambiosDeCobradorUltraGrid;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCobradores;
        private System.Windows.Forms.BindingSource cobradoresBindingSource;
        private Infragistics.Win.Misc.UltraLabel ultraLabelMensaje;
        private WS.DsEmpleadosLista dsEmpleadosLista1;
        private Administración.WS.DsZonas dsZonas;
        private System.Windows.Forms.BindingSource zonasBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownZonas;
    }
}
