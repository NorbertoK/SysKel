namespace Administración
{
    partial class FormABCMotivosDevolucionCobranza
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("MotivosDevolucionCobranza", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDevolucionCobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            this.ds_MotivosDevolucionCobranza = new Administración.WS.DsMotivosDevolucionCobranza();
            this.motivosDevolucionCobranzaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motivosDevolucionCobranzaUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_MotivosDevolucionCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDevolucionCobranzaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDevolucionCobranzaUltraGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 280);
            // 
            // buttonCancelar
            // 
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // ds_MotivosDevolucionCobranza
            // 
            this.ds_MotivosDevolucionCobranza.DataSetName = "DsMotivosDevolucionCobranza";
            this.ds_MotivosDevolucionCobranza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // motivosDevolucionCobranzaBindingSource
            // 
            this.motivosDevolucionCobranzaBindingSource.DataMember = "MotivosDevolucionCobranza";
            this.motivosDevolucionCobranzaBindingSource.DataSource = this.ds_MotivosDevolucionCobranza;
            // 
            // motivosDevolucionCobranzaUltraGrid
            // 
            this.motivosDevolucionCobranzaUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.motivosDevolucionCobranzaUltraGrid.DataSource = this.motivosDevolucionCobranzaBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.motivosDevolucionCobranzaUltraGrid.DisplayLayout.Appearance = appearance1;
            this.motivosDevolucionCobranzaUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 152;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 245;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2});
            this.motivosDevolucionCobranzaUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.motivosDevolucionCobranzaUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.motivosDevolucionCobranzaUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.motivosDevolucionCobranzaUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.motivosDevolucionCobranzaUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.motivosDevolucionCobranzaUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.motivosDevolucionCobranzaUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.motivosDevolucionCobranzaUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.motivosDevolucionCobranzaUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.motivosDevolucionCobranzaUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.motivosDevolucionCobranzaUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.motivosDevolucionCobranzaUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.motivosDevolucionCobranzaUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.motivosDevolucionCobranzaUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.motivosDevolucionCobranzaUltraGrid.DisplayLayout.Override.CellAppearance = appearance5;
            this.motivosDevolucionCobranzaUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.motivosDevolucionCobranzaUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.motivosDevolucionCobranzaUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.motivosDevolucionCobranzaUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.motivosDevolucionCobranzaUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.motivosDevolucionCobranzaUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.motivosDevolucionCobranzaUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.motivosDevolucionCobranzaUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.motivosDevolucionCobranzaUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.motivosDevolucionCobranzaUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.motivosDevolucionCobranzaUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.motivosDevolucionCobranzaUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.motivosDevolucionCobranzaUltraGrid.Location = new System.Drawing.Point(0, 1);
            this.motivosDevolucionCobranzaUltraGrid.Name = "motivosDevolucionCobranzaUltraGrid";
            this.motivosDevolucionCobranzaUltraGrid.Size = new System.Drawing.Size(266, 289);
            this.motivosDevolucionCobranzaUltraGrid.TabIndex = 2;
            this.motivosDevolucionCobranzaUltraGrid.AfterEnterEditMode += new System.EventHandler(this.MotivosDevolucionCobranzaUltraGridAfterEnterEditMode);
            this.motivosDevolucionCobranzaUltraGrid.AfterRowsDeleted += new System.EventHandler(this.MotivosDevolucionCobranzaUltraGridAfterRowsDeleted);
            this.motivosDevolucionCobranzaUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.motivosDevolucionCobranzaUltraGrid_KeyDown);
            // 
            // FormABCMotivosDevolucionCobranza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(265, 328);
            this.Controls.Add(this.motivosDevolucionCobranzaUltraGrid);
            this.Name = "FormABCMotivosDevolucionCobranza";
            this.Text = "Motivos de Devolución de Cobranza";
            this.Load += new System.EventHandler(this.FormABCMotivosDevolucionCobranzaLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.motivosDevolucionCobranzaUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ds_MotivosDevolucionCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDevolucionCobranzaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDevolucionCobranzaUltraGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Administración.WS.DsMotivosDevolucionCobranza ds_MotivosDevolucionCobranza;
        private System.Windows.Forms.BindingSource motivosDevolucionCobranzaBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid motivosDevolucionCobranzaUltraGrid;
    }
}
