using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    partial class FormABCEmpleados
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Empleados", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrestador", -1, "ultraDropDownPrestador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Apellido", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_CargosEmpleados_Empleados");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_CargosEmpleados_Empleados", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCargoEmpleado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCargo", -1, "ultraDropDownCargo");
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Prestadores", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrestador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Cargos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCargo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            this.empleadosUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEmpleados = new Cabina.WS.DsEmpleados();
            this.ultraDropDownPrestador = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.prestadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrestadores = new Cabina.WS.DsPrestadores();
            this.ultraDropDownCargo = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.cargosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCargos = new Cabina.WS.DsCargos();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPrestador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrestadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCargos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(638, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(557, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-4, 408);
            this.panel1.Size = new System.Drawing.Size(728, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(476, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // empleadosUltraGrid
            // 
            this.empleadosUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empleadosUltraGrid.DataSource = this.empleadosBindingSource;
            appearance31.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance31.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.empleadosUltraGrid.DisplayLayout.Appearance = appearance31;
            this.empleadosUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand1.ColHeaderLines = 2;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 58;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn2.Header.VisiblePosition = 3;
            ultraGridColumn2.Width = 211;
            ultraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn3.Header.Caption = "Prestador";
            ultraGridColumn3.Header.VisiblePosition = 1;
            ultraGridColumn3.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn3.Width = 82;
            ultraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn4.DefaultCellValue = "True";
            ultraGridColumn4.Header.VisiblePosition = 5;
            ultraGridColumn4.Width = 72;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.Width = 94;
            ultraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn6.Header.VisiblePosition = 2;
            ultraGridColumn6.Width = 229;
            ultraGridColumn7.Header.VisiblePosition = 6;
            ultraGridColumn7.Hidden = true;
            ultraGridColumn7.Width = 78;
            ultraGridColumn8.Header.VisiblePosition = 7;
            ultraGridColumn8.Hidden = true;
            ultraGridColumn8.Width = 78;
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
            ultraGridBand1.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.True;
            ultraGridBand2.CardSettings.CardScrollbars = Infragistics.Win.UltraWinGrid.CardScrollbars.None;
            ultraGridBand2.CardSettings.ShowCaption = false;
            ultraGridBand2.CardSettings.Width = 100;
            ultraGridBand2.CardView = true;
            ultraGridBand2.ColHeadersVisible = false;
            ultraGridColumn10.Header.VisiblePosition = 0;
            ultraGridColumn10.Hidden = true;
            ultraGridColumn10.Width = 80;
            ultraGridColumn11.Header.VisiblePosition = 1;
            ultraGridColumn11.Hidden = true;
            ultraGridColumn11.Width = 217;
            ultraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn12.Header.VisiblePosition = 2;
            ultraGridColumn12.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn12.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn12.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(320, 0);
            ultraGridColumn12.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(326, 0);
            ultraGridColumn12.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn12.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn12.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn12.Width = 80;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12});
            appearance1.FontData.BoldAsString = "True";
            appearance1.FontData.SizeInPoints = 11F;
            appearance1.TextHAlignAsString = "Left";
            ultraGridBand2.Header.Appearance = appearance1;
            ultraGridBand2.Header.Caption = "Cargos";
            ultraGridBand2.HeaderVisible = true;
            ultraGridBand2.MaxRows = 4;
            ultraGridBand2.MinRows = 1;
            ultraGridBand2.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None;
            ultraGridBand2.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand2.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.empleadosUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.empleadosUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.empleadosUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.empleadosUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.empleadosUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance36.BackColor = System.Drawing.SystemColors.Window;
            this.empleadosUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance36;
            appearance37.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance37.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance37.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance37.ForeColor = System.Drawing.SystemColors.WindowText;
            this.empleadosUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance37;
            this.empleadosUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.empleadosUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.empleadosUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.empleadosUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.empleadosUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.empleadosUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.empleadosUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance38.BackColor = System.Drawing.Color.Transparent;
            this.empleadosUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance38;
            appearance39.BackColor = System.Drawing.SystemColors.Control;
            appearance39.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.empleadosUltraGrid.DisplayLayout.Override.CellAppearance = appearance39;
            this.empleadosUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance40.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance40.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance40.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance40.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance40.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.empleadosUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance40;
            this.empleadosUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance41.ForeColor = System.Drawing.Color.Red;
            this.empleadosUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance41;
            this.empleadosUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance42.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.empleadosUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance42;
            appearance43.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance43.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance43.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.empleadosUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance43;
            appearance44.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance44.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.empleadosUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance44;
            this.empleadosUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.empleadosUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.empleadosUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.empleadosUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.empleadosUltraGrid.Location = new System.Drawing.Point(-4, -3);
            this.empleadosUltraGrid.Name = "empleadosUltraGrid";
            this.empleadosUltraGrid.Size = new System.Drawing.Size(728, 421);
            this.empleadosUltraGrid.TabIndex = 2;
            this.empleadosUltraGrid.AfterEnterEditMode += new System.EventHandler(this.EmpleadosUltraGridAfterEnterEditMode);
            this.empleadosUltraGrid.AfterRowsDeleted += new System.EventHandler(this.EmpleadosUltraGridAfterRowsDeleted);
            this.empleadosUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.empleadosUltraGrid_KeyDown);
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.dsEmpleados;
            // 
            // dsEmpleados
            // 
            this.dsEmpleados.DataSetName = "DsEmpleados";
            this.dsEmpleados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownPrestador
            // 
            this.ultraDropDownPrestador.DataSource = this.prestadoresBindingSource;
            appearance11.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPrestador.DisplayLayout.Appearance = appearance11;
            this.ultraDropDownPrestador.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn13.Header.VisiblePosition = 0;
            ultraGridColumn13.Hidden = true;
            ultraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn14.Header.VisiblePosition = 1;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn13,
            ultraGridColumn14});
            ultraGridBand3.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand3.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownPrestador.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.ultraDropDownPrestador.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPrestador.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPrestador.DisplayLayout.MaxBandDepth = 5;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPrestador.DisplayLayout.Override.ActiveCellAppearance = appearance12;
            appearance13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance13.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPrestador.DisplayLayout.Override.ActiveRowAppearance = appearance13;
            this.ultraDropDownPrestador.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPrestador.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPrestador.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPrestador.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPrestador.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPrestador.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPrestador.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance14.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPrestador.DisplayLayout.Override.CardAreaAppearance = appearance14;
            appearance15.BackColor = System.Drawing.SystemColors.Control;
            appearance15.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPrestador.DisplayLayout.Override.CellAppearance = appearance15;
            this.ultraDropDownPrestador.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance16.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance16.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPrestador.DisplayLayout.Override.HeaderAppearance = appearance16;
            this.ultraDropDownPrestador.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance17.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPrestador.DisplayLayout.Override.RowSelectorAppearance = appearance17;
            this.ultraDropDownPrestador.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPrestador.DisplayLayout.Override.SelectedCellAppearance = appearance18;
            appearance19.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance19.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPrestador.DisplayLayout.Override.SelectedRowAppearance = appearance19;
            appearance20.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance20.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPrestador.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance20;
            this.ultraDropDownPrestador.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPrestador.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPrestador.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPrestador.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPrestador.DisplayMember = "Nombre";
            this.ultraDropDownPrestador.DropDownWidth = 120;
            this.ultraDropDownPrestador.Location = new System.Drawing.Point(12, 111);
            this.ultraDropDownPrestador.Name = "ultraDropDownPrestador";
            this.ultraDropDownPrestador.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownPrestador.TabIndex = 9;
            this.ultraDropDownPrestador.ValueMember = "idPrestador";
            this.ultraDropDownPrestador.Visible = false;
            // 
            // prestadoresBindingSource
            // 
            this.prestadoresBindingSource.DataMember = "Prestadores";
            this.prestadoresBindingSource.DataSource = this.dsPrestadores;
            // 
            // dsPrestadores
            // 
            this.dsPrestadores.DataSetName = "DsPrestadores";
            this.dsPrestadores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownCargo
            // 
            this.ultraDropDownCargo.DataSource = this.cargosBindingSource;
            appearance21.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCargo.DisplayLayout.Appearance = appearance21;
            this.ultraDropDownCargo.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn15.Header.VisiblePosition = 0;
            ultraGridColumn15.Hidden = true;
            ultraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn16.Header.VisiblePosition = 1;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn15,
            ultraGridColumn16});
            ultraGridBand4.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand4.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownCargo.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.ultraDropDownCargo.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCargo.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCargo.DisplayLayout.MaxBandDepth = 5;
            appearance22.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCargo.DisplayLayout.Override.ActiveCellAppearance = appearance22;
            appearance23.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance23.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance23.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCargo.DisplayLayout.Override.ActiveRowAppearance = appearance23;
            this.ultraDropDownCargo.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCargo.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCargo.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCargo.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCargo.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCargo.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCargo.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance24.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCargo.DisplayLayout.Override.CardAreaAppearance = appearance24;
            appearance25.BackColor = System.Drawing.SystemColors.Control;
            appearance25.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCargo.DisplayLayout.Override.CellAppearance = appearance25;
            this.ultraDropDownCargo.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance26.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance26.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance26.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCargo.DisplayLayout.Override.HeaderAppearance = appearance26;
            this.ultraDropDownCargo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance27.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCargo.DisplayLayout.Override.RowSelectorAppearance = appearance27;
            this.ultraDropDownCargo.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCargo.DisplayLayout.Override.SelectedCellAppearance = appearance28;
            appearance29.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance29.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCargo.DisplayLayout.Override.SelectedRowAppearance = appearance29;
            appearance30.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance30.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCargo.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance30;
            this.ultraDropDownCargo.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCargo.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCargo.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCargo.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCargo.DisplayMember = "Nombre";
            this.ultraDropDownCargo.DropDownWidth = 120;
            this.ultraDropDownCargo.Location = new System.Drawing.Point(12, 149);
            this.ultraDropDownCargo.Name = "ultraDropDownCargo";
            this.ultraDropDownCargo.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownCargo.TabIndex = 10;
            this.ultraDropDownCargo.ValueMember = "idCargo";
            this.ultraDropDownCargo.Visible = false;
            this.ultraDropDownCargo.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.ultraDropDownCargo_FilterRow);
            // 
            // cargosBindingSource
            // 
            this.cargosBindingSource.DataMember = "Cargos";
            this.cargosBindingSource.DataSource = this.dsCargos;
            // 
            // dsCargos
            // 
            this.dsCargos.DataSetName = "DsCargos";
            this.dsCargos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormABCEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(724, 457);
            this.Controls.Add(this.empleadosUltraGrid);
            this.Controls.Add(this.ultraDropDownCargo);
            this.Controls.Add(this.ultraDropDownPrestador);
            this.Name = "FormABCEmpleados";
            this.Text = "Empleados";
            this.Activated += new System.EventHandler(this.FormABCEmpleadosActivated);
            this.Load += new System.EventHandler(this.FormABCEmpliadosLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraDropDownPrestador, 0);
            this.Controls.SetChildIndex(this.ultraDropDownCargo, 0);
            this.Controls.SetChildIndex(this.empleadosUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empleadosUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPrestador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrestadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCargos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid empleadosUltraGrid;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private WS.DsEmpleados dsEmpleados;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownPrestador;
        private System.Windows.Forms.BindingSource prestadoresBindingSource;
        private WS.DsPrestadores dsPrestadores;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCargo;
        private System.Windows.Forms.BindingSource cargosBindingSource;
        private WS.DsCargos dsCargos;
    }
}
