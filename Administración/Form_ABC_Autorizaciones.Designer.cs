using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    partial class FormABCAutorizaciones
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Autorizaciones", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAutorizacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeAutorizacion", -1, "ultraDropDownTiposDeAutoirzacion", 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo");
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeAutorizacion", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeAutorizacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            this.autorizacionesUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.autorizacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAutorizaciones = new Administración.WS.DsAutorizaciones();
            this.ultraDropDownTiposDeAutoirzacion = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tiposDeAutorizacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTiposDeAutorizacion = new Administración.WS.DsTiposDeAutorizacion();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autorizacionesUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorizacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAutorizaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeAutoirzacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeAutorizacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeAutorizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(615, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(534, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 402);
            this.panel1.Size = new System.Drawing.Size(705, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(453, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // autorizacionesUltraGrid
            // 
            this.autorizacionesUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autorizacionesUltraGrid.DataSource = this.autorizacionesBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.autorizacionesUltraGrid.DisplayLayout.Appearance = appearance1;
            this.autorizacionesUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 78;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn2.Header.Caption = "Descripción";
            ultraGridColumn2.Header.VisiblePosition = 3;
            ultraGridColumn2.Width = 415;
            ultraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn3.Header.Caption = "Tipo de Autorización";
            ultraGridColumn3.Header.VisiblePosition = 1;
            ultraGridColumn3.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn3.Width = 161;
            ultraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn4.Header.Caption = "Código";
            ultraGridColumn4.Header.VisiblePosition = 2;
            ultraGridColumn4.Width = 91;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4});
            this.autorizacionesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.autorizacionesUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.autorizacionesUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.autorizacionesUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.autorizacionesUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.autorizacionesUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.autorizacionesUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.autorizacionesUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.autorizacionesUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.autorizacionesUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.autorizacionesUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.autorizacionesUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.autorizacionesUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.autorizacionesUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.autorizacionesUltraGrid.DisplayLayout.Override.CellAppearance = appearance5;
            this.autorizacionesUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.autorizacionesUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.autorizacionesUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.autorizacionesUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.autorizacionesUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.autorizacionesUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.autorizacionesUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.autorizacionesUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.autorizacionesUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.autorizacionesUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.autorizacionesUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.autorizacionesUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.autorizacionesUltraGrid.Location = new System.Drawing.Point(0, -1);
            this.autorizacionesUltraGrid.Name = "autorizacionesUltraGrid";
            this.autorizacionesUltraGrid.Size = new System.Drawing.Size(705, 413);
            this.autorizacionesUltraGrid.TabIndex = 2;
            this.autorizacionesUltraGrid.AfterEnterEditMode += new System.EventHandler(this.AutorizacionesUltraGridAfterEnterEditMode);
            this.autorizacionesUltraGrid.AfterRowsDeleted += new System.EventHandler(this.AutorizacionesUltraGridAfterRowsDeleted);
            this.autorizacionesUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.autorizacionesUltraGrid_KeyDown);
            // 
            // autorizacionesBindingSource
            // 
            this.autorizacionesBindingSource.DataMember = "Autorizaciones";
            this.autorizacionesBindingSource.DataSource = this.dsAutorizaciones;
            // 
            // dsAutorizaciones
            // 
            this.dsAutorizaciones.DataSetName = "DsAutorizaciones";
            this.dsAutorizaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownTiposDeAutoirzacion
            // 
            this.ultraDropDownTiposDeAutoirzacion.DataSource = this.tiposDeAutorizacionBindingSource;
            appearance11.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTiposDeAutoirzacion.DisplayLayout.Appearance = appearance11;
            this.ultraDropDownTiposDeAutoirzacion.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn5.Header.VisiblePosition = 0;
            ultraGridColumn5.Hidden = true;
            ultraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn6.Header.VisiblePosition = 1;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn5,
            ultraGridColumn6});
            ultraGridBand2.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand2.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownTiposDeAutoirzacion.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.ultraDropDownTiposDeAutoirzacion.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTiposDeAutoirzacion.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTiposDeAutoirzacion.DisplayLayout.MaxBandDepth = 5;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTiposDeAutoirzacion.DisplayLayout.Override.ActiveCellAppearance = appearance12;
            appearance13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance13.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTiposDeAutoirzacion.DisplayLayout.Override.ActiveRowAppearance = appearance13;
            this.ultraDropDownTiposDeAutoirzacion.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTiposDeAutoirzacion.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTiposDeAutoirzacion.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeAutoirzacion.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTiposDeAutoirzacion.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeAutoirzacion.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTiposDeAutoirzacion.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance14.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTiposDeAutoirzacion.DisplayLayout.Override.CardAreaAppearance = appearance14;
            appearance15.BackColor = System.Drawing.SystemColors.Control;
            appearance15.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeAutoirzacion.DisplayLayout.Override.CellAppearance = appearance15;
            this.ultraDropDownTiposDeAutoirzacion.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance16.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance16.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTiposDeAutoirzacion.DisplayLayout.Override.HeaderAppearance = appearance16;
            this.ultraDropDownTiposDeAutoirzacion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance17.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTiposDeAutoirzacion.DisplayLayout.Override.RowSelectorAppearance = appearance17;
            this.ultraDropDownTiposDeAutoirzacion.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTiposDeAutoirzacion.DisplayLayout.Override.SelectedCellAppearance = appearance18;
            appearance19.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance19.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeAutoirzacion.DisplayLayout.Override.SelectedRowAppearance = appearance19;
            appearance20.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance20.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTiposDeAutoirzacion.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance20;
            this.ultraDropDownTiposDeAutoirzacion.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTiposDeAutoirzacion.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTiposDeAutoirzacion.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTiposDeAutoirzacion.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTiposDeAutoirzacion.DisplayMember = "Nombre";
            this.ultraDropDownTiposDeAutoirzacion.DropDownWidth = 250;
            this.ultraDropDownTiposDeAutoirzacion.Location = new System.Drawing.Point(12, 161);
            this.ultraDropDownTiposDeAutoirzacion.Name = "ultraDropDownTiposDeAutoirzacion";
            this.ultraDropDownTiposDeAutoirzacion.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownTiposDeAutoirzacion.TabIndex = 9;
            this.ultraDropDownTiposDeAutoirzacion.ValueMember = "idTipoDeAutorizacion";
            this.ultraDropDownTiposDeAutoirzacion.Visible = false;
            // 
            // tiposDeAutorizacionBindingSource
            // 
            this.tiposDeAutorizacionBindingSource.DataMember = "TiposDeAutorizacion";
            this.tiposDeAutorizacionBindingSource.DataSource = this.dsTiposDeAutorizacion;
            // 
            // dsTiposDeAutorizacion
            // 
            this.dsTiposDeAutorizacion.DataSetName = "DsTiposDeAutorizacion";
            this.dsTiposDeAutorizacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormABCAutorizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.autorizacionesUltraGrid);
            this.Controls.Add(this.ultraDropDownTiposDeAutoirzacion);
            this.Name = "FormABCAutorizaciones";
            this.Text = "Autorizaciones";
            this.Activated += new System.EventHandler(this.FormABCAutorizacionesActivated);
            this.Load += new System.EventHandler(this.FormABCAutorizacionesLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTiposDeAutoirzacion, 0);
            this.Controls.SetChildIndex(this.autorizacionesUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.autorizacionesUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorizacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAutorizaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeAutoirzacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeAutorizacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeAutorizacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WS.DsAutorizaciones dsAutorizaciones;
        private System.Windows.Forms.BindingSource autorizacionesBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid autorizacionesUltraGrid;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTiposDeAutoirzacion;
        private System.Windows.Forms.BindingSource tiposDeAutorizacionBindingSource;
        private WS.DsTiposDeAutorizacion dsTiposDeAutorizacion;
    }
}
