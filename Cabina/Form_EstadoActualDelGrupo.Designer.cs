namespace Cabina
{
    partial class FormEstadoActualDelGrupo
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EstadoAfiliadosDelGrupo", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idGrupo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDoc");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NroDoc");
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("nPlan");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAfiliado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuota");
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Titular");
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings1 = new Infragistics.Win.UltraWinGrid.SummarySettings("SumCuotas", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "Cuota", 7, true, "EstadoAfiliadosDelGrupo", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.Right, "Cuota", 7, true);
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
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            this.ds_EstadoActualDelGrupo = new Cabina.WS.DsEstadoActualDelGrupo();
            this.estadoAfiliadosDelGrupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoAfiliadosDelGrupoUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_EstadoActualDelGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoAfiliadosDelGrupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoAfiliadosDelGrupoUltraGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(613, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Visible = false;
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(532, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 202);
            this.panel1.Size = new System.Drawing.Size(703, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(613, 16);
            this.buttonCancelar.Text = "Salir";
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // ds_EstadoActualDelGrupo
            // 
            this.ds_EstadoActualDelGrupo.DataSetName = "DsEstadoActualDelGrupo";
            this.ds_EstadoActualDelGrupo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estadoAfiliadosDelGrupoBindingSource
            // 
            this.estadoAfiliadosDelGrupoBindingSource.DataMember = "EstadoAfiliadosDelGrupo";
            this.estadoAfiliadosDelGrupoBindingSource.DataSource = this.ds_EstadoActualDelGrupo;
            // 
            // estadoAfiliadosDelGrupoUltraGrid
            // 
            this.estadoAfiliadosDelGrupoUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.estadoAfiliadosDelGrupoUltraGrid.DataSource = this.estadoAfiliadosDelGrupoBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.Appearance = appearance1;
            this.estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn2.Header.VisiblePosition = 2;
            ultraGridColumn2.Width = 183;
            appearance2.TextHAlignAsString = "Center";
            ultraGridColumn3.CellAppearance = appearance2;
            ultraGridColumn3.Header.Caption = "Documento";
            ultraGridColumn3.Header.VisiblePosition = 3;
            ultraGridColumn3.Width = 66;
            appearance3.TextHAlignAsString = "Right";
            ultraGridColumn4.CellAppearance = appearance3;
            ultraGridColumn4.Header.Caption = "Nº de Documento";
            ultraGridColumn4.Header.VisiblePosition = 4;
            ultraGridColumn4.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn4.MaskInput = "{LOC}nnn,nnn,nnn,nnn";
            ultraGridColumn4.Width = 97;
            ultraGridColumn5.Header.Caption = "Plan";
            ultraGridColumn5.Header.VisiblePosition = 5;
            ultraGridColumn5.Width = 118;
            ultraGridColumn6.Header.VisiblePosition = 6;
            ultraGridColumn6.Width = 102;
            ultraGridColumn7.Header.VisiblePosition = 7;
            ultraGridColumn7.Hidden = true;
            appearance4.TextHAlignAsString = "Right";
            ultraGridColumn8.CellAppearance = appearance4;
            ultraGridColumn8.Header.VisiblePosition = 8;
            ultraGridColumn8.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn8.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn8.Width = 70;
            ultraGridColumn9.Header.VisiblePosition = 1;
            ultraGridColumn9.Width = 46;
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
            ultraGridBand1.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            ultraGridBand1.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridBand1.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance5.FontData.BoldAsString = "True";
            appearance5.TextHAlignAsString = "Right";
            summarySettings1.Appearance = appearance5;
            summarySettings1.DisplayFormat = "Total: {0:c}";
            summarySettings1.GroupBySummaryValueAppearance = appearance6;
            ultraGridBand1.Summaries.AddRange(new Infragistics.Win.UltraWinGrid.SummarySettings[] {
            summarySettings1});
            this.estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            this.estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance7;
            appearance8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance8.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance8;
            this.estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance9.BackColor = System.Drawing.Color.Transparent;
            this.estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.Control;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.Override.CellAppearance = appearance10;
            this.estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance11.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance11.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance11;
            this.estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance12.ForeColor = System.Drawing.Color.Red;
            this.estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance12;
            this.estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance13;
            appearance14.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance14.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance14;
            appearance15.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance15.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance15;
            this.estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.estadoAfiliadosDelGrupoUltraGrid.Location = new System.Drawing.Point(0, 12);
            this.estadoAfiliadosDelGrupoUltraGrid.Name = "estadoAfiliadosDelGrupoUltraGrid";
            this.estadoAfiliadosDelGrupoUltraGrid.Size = new System.Drawing.Size(703, 200);
            this.estadoAfiliadosDelGrupoUltraGrid.TabIndex = 2;
            this.estadoAfiliadosDelGrupoUltraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.EstadoAfiliadosDelGrupoUltraGridInitializeRow);
            // 
            // FormEstadoActualDelGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(702, 250);
            this.Controls.Add(this.estadoAfiliadosDelGrupoUltraGrid);
            this.Name = "FormEstadoActualDelGrupo";
            this.Text = "Estado Actual del Grupo";
            this.Load += new System.EventHandler(this.FormEstadoActualDelGrupoLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.estadoAfiliadosDelGrupoUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ds_EstadoActualDelGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoAfiliadosDelGrupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoAfiliadosDelGrupoUltraGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cabina.WS.DsEstadoActualDelGrupo ds_EstadoActualDelGrupo;
        private System.Windows.Forms.BindingSource estadoAfiliadosDelGrupoBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid estadoAfiliadosDelGrupoUltraGrid;
    }
}
