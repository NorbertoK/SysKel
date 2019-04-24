using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    partial class FormABCPlanesPropios
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Planes", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPlan");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormABCPlanesPropios));
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuota");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PadronExterno");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProteccion", -1, "ultraDropDownProtecciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CuotaAdherente");
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Protecciones", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProteccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Detalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            this.planesUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.planesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPlanesPropios = new Administración.WS.DsPlanesPropios();
            this.ultraDropDownProtecciones = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.proteccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProtecciones = new Administración.WS.DsProtecciones();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planesUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanesPropios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownProtecciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proteccionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProtecciones)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(393, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(312, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 447);
            this.panel1.Size = new System.Drawing.Size(483, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(231, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // planesUltraGrid
            // 
            this.planesUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.planesUltraGrid.DataSource = this.planesBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.planesUltraGrid.DisplayLayout.Appearance = appearance1;
            this.planesUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 48;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 122;
            ultraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Width = 53;
            ultraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn4.DefaultCellValue = ((object)(resources.GetObject("ultraGridColumn4.DefaultCellValue")));
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.Hidden = true;
            ultraGridColumn4.Width = 71;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            appearance2.TextHAlignAsString = "Right";
            ultraGridColumn5.CellAppearance = appearance2;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn5.Width = 75;
            ultraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn6.DefaultCellValue = "True";
            ultraGridColumn6.Header.VisiblePosition = 6;
            ultraGridColumn6.Width = 51;
            ultraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn7.DefaultCellValue = "False";
            ultraGridColumn7.Header.VisiblePosition = 7;
            ultraGridColumn7.Hidden = true;
            ultraGridColumn7.Width = 71;
            ultraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn8.Header.Caption = "Protección";
            ultraGridColumn8.Header.VisiblePosition = 8;
            ultraGridColumn8.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn8.Width = 61;
            ultraGridColumn9.Header.VisiblePosition = 5;
            ultraGridColumn9.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn9.Width = 100;
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
            this.planesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.planesUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.planesUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.planesUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance3.BackColor = System.Drawing.SystemColors.Window;
            this.planesUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance3;
            appearance4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance4.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.planesUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance4;
            this.planesUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.planesUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.planesUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.planesUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.planesUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.planesUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.planesUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance5.BackColor = System.Drawing.Color.Transparent;
            this.planesUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.Control;
            appearance6.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.planesUltraGrid.DisplayLayout.Override.CellAppearance = appearance6;
            this.planesUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance7.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance7.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.planesUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance7;
            this.planesUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance8.ForeColor = System.Drawing.Color.Red;
            this.planesUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance8;
            this.planesUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.planesUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance10.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.planesUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance10;
            appearance21.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.planesUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance21;
            this.planesUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.planesUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.planesUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.planesUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.planesUltraGrid.Location = new System.Drawing.Point(0, -2);
            this.planesUltraGrid.Name = "planesUltraGrid";
            this.planesUltraGrid.Size = new System.Drawing.Size(483, 459);
            this.planesUltraGrid.TabIndex = 2;
            this.planesUltraGrid.AfterEnterEditMode += new System.EventHandler(this.PlanesUltraGridAfterEnterEditMode);
            this.planesUltraGrid.AfterRowsDeleted += new System.EventHandler(this.PlanesUltraGridAfterRowsDeleted);
            this.planesUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.planesUltraGrid_KeyDown);
            // 
            // planesBindingSource
            // 
            this.planesBindingSource.DataMember = "Planes";
            this.planesBindingSource.DataSource = this.dsPlanesPropios;
            // 
            // dsPlanesPropios
            // 
            this.dsPlanesPropios.DataSetName = "DsPlanesPropios";
            this.dsPlanesPropios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownProtecciones
            // 
            this.ultraDropDownProtecciones.DataSource = this.proteccionesBindingSource;
            appearance11.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownProtecciones.DisplayLayout.Appearance = appearance11;
            this.ultraDropDownProtecciones.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn10.Header.VisiblePosition = 0;
            ultraGridColumn10.Hidden = true;
            ultraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn11.Header.VisiblePosition = 1;
            ultraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn12.Header.VisiblePosition = 2;
            ultraGridColumn12.Hidden = true;
            ultraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn13.Header.VisiblePosition = 3;
            ultraGridColumn13.Hidden = true;
            ultraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn14.Header.VisiblePosition = 4;
            ultraGridColumn14.Hidden = true;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12,
            ultraGridColumn13,
            ultraGridColumn14});
            ultraGridBand2.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand2.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownProtecciones.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.ultraDropDownProtecciones.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownProtecciones.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownProtecciones.DisplayLayout.MaxBandDepth = 5;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownProtecciones.DisplayLayout.Override.ActiveCellAppearance = appearance12;
            appearance13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance13.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownProtecciones.DisplayLayout.Override.ActiveRowAppearance = appearance13;
            this.ultraDropDownProtecciones.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownProtecciones.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownProtecciones.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownProtecciones.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownProtecciones.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownProtecciones.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownProtecciones.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance14.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownProtecciones.DisplayLayout.Override.CardAreaAppearance = appearance14;
            appearance15.BackColor = System.Drawing.SystemColors.Control;
            appearance15.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownProtecciones.DisplayLayout.Override.CellAppearance = appearance15;
            this.ultraDropDownProtecciones.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance16.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance16.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownProtecciones.DisplayLayout.Override.HeaderAppearance = appearance16;
            this.ultraDropDownProtecciones.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance17.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownProtecciones.DisplayLayout.Override.RowSelectorAppearance = appearance17;
            this.ultraDropDownProtecciones.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownProtecciones.DisplayLayout.Override.SelectedCellAppearance = appearance18;
            appearance19.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance19.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownProtecciones.DisplayLayout.Override.SelectedRowAppearance = appearance19;
            appearance20.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance20.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownProtecciones.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance20;
            this.ultraDropDownProtecciones.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownProtecciones.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownProtecciones.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownProtecciones.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownProtecciones.DisplayMember = "Nombre";
            this.ultraDropDownProtecciones.DropDownWidth = 0;
            this.ultraDropDownProtecciones.Location = new System.Drawing.Point(57, 141);
            this.ultraDropDownProtecciones.Name = "ultraDropDownProtecciones";
            this.ultraDropDownProtecciones.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownProtecciones.TabIndex = 12;
            this.ultraDropDownProtecciones.ValueMember = "idProteccion";
            this.ultraDropDownProtecciones.Visible = false;
            // 
            // proteccionesBindingSource
            // 
            this.proteccionesBindingSource.DataMember = "Protecciones";
            this.proteccionesBindingSource.DataSource = this.dsProtecciones;
            // 
            // dsProtecciones
            // 
            this.dsProtecciones.DataSetName = "DsProtecciones";
            this.dsProtecciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormABCPlanesPropios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(482, 495);
            this.Controls.Add(this.planesUltraGrid);
            this.Controls.Add(this.ultraDropDownProtecciones);
            this.Name = "FormABCPlanesPropios";
            this.Text = "Planes Propios";
            this.Load += new System.EventHandler(this.FormABCPlanesPropiosLoad);
            this.Controls.SetChildIndex(this.ultraDropDownProtecciones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.planesUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.planesUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanesPropios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownProtecciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proteccionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProtecciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid planesUltraGrid;
        private System.Windows.Forms.BindingSource planesBindingSource;
        private WS.DsPlanesPropios dsPlanesPropios;
        private WS.DsProtecciones dsProtecciones;
        private System.Windows.Forms.BindingSource proteccionesBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownProtecciones;
    }
}
