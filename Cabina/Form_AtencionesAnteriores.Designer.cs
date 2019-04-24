using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    partial class FormAtencionesAnteriores
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("AtencionesAnteriores", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDeBusqueda");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaYHora");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Paciente", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Edad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Motivos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TiempoDeLlegada");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Medico");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Diagnosticos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Medicamentos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("LugarDeInternacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe");
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
            this.dsAtencionesAnteriores = new Cabina.WS.DsAtencionesAnteriores();
            this.atencionesAnterioresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atencionesAnterioresUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsAtencionesAnteriores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencionesAnterioresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencionesAnterioresUltraGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(741, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Visible = false;
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(660, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 484);
            this.panel1.Size = new System.Drawing.Size(831, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(741, 16);
            this.buttonCancelar.Text = "Salir";
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // dsAtencionesAnteriores
            // 
            this.dsAtencionesAnteriores.DataSetName = "DsAtencionesAnteriores";
            this.dsAtencionesAnteriores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // atencionesAnterioresBindingSource
            // 
            this.atencionesAnterioresBindingSource.DataMember = "AtencionesAnteriores";
            this.atencionesAnterioresBindingSource.DataSource = this.dsAtencionesAnteriores;
            // 
            // atencionesAnterioresUltraGrid
            // 
            this.atencionesAnterioresUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.atencionesAnterioresUltraGrid.DataSource = this.atencionesAnterioresBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.atencionesAnterioresUltraGrid.DisplayLayout.Appearance = appearance1;
            this.atencionesAnterioresUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand1.CardSettings.AutoFit = true;
            ultraGridBand1.CardSettings.CardScrollbars = Infragistics.Win.UltraWinGrid.CardScrollbars.None;
            ultraGridBand1.CardSettings.ShowCaption = false;
            ultraGridBand1.CardSettings.Style = Infragistics.Win.UltraWinGrid.CardStyle.StandardLabels;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn1.Header.Caption = "Tipo de Búsqueda";
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn1.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn1.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn1.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn1.Width = 67;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn2.Header.Caption = "Fecha y Hora";
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn2.MaskInput = "dd/mm/yyyy hh:mm";
            ultraGridColumn2.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn2.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(105, 0);
            ultraGridColumn2.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn2.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn2.Width = 54;
            ultraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn3.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(175, 0);
            ultraGridColumn3.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(71, 0);
            ultraGridColumn3.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn3.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn3.Width = 65;
            ultraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn4.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(65, 0);
            ultraGridColumn4.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(122, 0);
            ultraGridColumn4.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn4.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn4.Width = 70;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn5.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(330, 0);
            ultraGridColumn5.RowLayoutColumnInfo.SpanX = 5;
            ultraGridColumn5.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn5.Width = 68;
            ultraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn6.Header.Caption = "Tiempo de Llegada";
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridColumn6.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn6.MaskInput = "hh:mm:ss";
            ultraGridColumn6.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn6.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(65, 0);
            ultraGridColumn6.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(122, 0);
            ultraGridColumn6.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn6.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn6.Width = 64;
            ultraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn7.Header.Caption = "Médico";
            ultraGridColumn7.Header.VisiblePosition = 6;
            ultraGridColumn7.RowLayoutColumnInfo.OriginX = 7;
            ultraGridColumn7.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(130, 0);
            ultraGridColumn7.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(51, 0);
            ultraGridColumn7.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn7.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn7.Width = 55;
            ultraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn8.Header.Caption = "Diagnósticos";
            ultraGridColumn8.Header.VisiblePosition = 7;
            ultraGridColumn8.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn8.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn8.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(603, 0);
            ultraGridColumn8.RowLayoutColumnInfo.SpanX = 9;
            ultraGridColumn8.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn8.Width = 58;
            ultraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn9.Header.VisiblePosition = 8;
            ultraGridColumn9.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn9.RowLayoutColumnInfo.OriginY = 6;
            ultraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(330, 0);
            ultraGridColumn9.RowLayoutColumnInfo.SpanX = 5;
            ultraGridColumn9.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn9.Width = 59;
            ultraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn10.Header.Caption = "Lugar De Internación";
            ultraGridColumn10.Header.VisiblePosition = 9;
            ultraGridColumn10.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn10.RowLayoutColumnInfo.OriginY = 6;
            ultraGridColumn10.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(277, 0);
            ultraGridColumn10.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(122, 0);
            ultraGridColumn10.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn10.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn10.Width = 76;
            ultraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance2.TextHAlignAsString = "Right";
            ultraGridColumn11.CellAppearance = appearance2;
            ultraGridColumn11.Header.VisiblePosition = 10;
            ultraGridColumn11.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn11.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn11.RowLayoutColumnInfo.OriginX = 7;
            ultraGridColumn11.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn11.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(130, 0);
            ultraGridColumn11.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(53, 0);
            ultraGridColumn11.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn11.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn11.Width = 49;
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
            ultraGridColumn11});
            ultraGridBand1.Override.RowSpacingAfter = 5;
            ultraGridBand1.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.Left;
            ultraGridBand1.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.atencionesAnterioresUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.atencionesAnterioresUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.atencionesAnterioresUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.atencionesAnterioresUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance3.BackColor = System.Drawing.SystemColors.Window;
            this.atencionesAnterioresUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance3;
            appearance4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance4.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.atencionesAnterioresUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance4;
            this.atencionesAnterioresUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.atencionesAnterioresUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.atencionesAnterioresUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.atencionesAnterioresUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.atencionesAnterioresUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.atencionesAnterioresUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.atencionesAnterioresUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance5.BackColor = System.Drawing.Color.Transparent;
            this.atencionesAnterioresUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.Control;
            appearance6.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.atencionesAnterioresUltraGrid.DisplayLayout.Override.CellAppearance = appearance6;
            this.atencionesAnterioresUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance7.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance7.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.atencionesAnterioresUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance7;
            this.atencionesAnterioresUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance8.ForeColor = System.Drawing.Color.Red;
            this.atencionesAnterioresUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance8;
            this.atencionesAnterioresUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.atencionesAnterioresUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance10.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.atencionesAnterioresUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance10;
            appearance11.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.atencionesAnterioresUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance11;
            this.atencionesAnterioresUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.atencionesAnterioresUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.atencionesAnterioresUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.atencionesAnterioresUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.atencionesAnterioresUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atencionesAnterioresUltraGrid.Location = new System.Drawing.Point(0, -1);
            this.atencionesAnterioresUltraGrid.Name = "atencionesAnterioresUltraGrid";
            this.atencionesAnterioresUltraGrid.Size = new System.Drawing.Size(831, 495);
            this.atencionesAnterioresUltraGrid.TabIndex = 2;
            this.atencionesAnterioresUltraGrid.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.AtencionesAnterioresUltraGridInitializeLayout);
            this.atencionesAnterioresUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.atencionesAnterioresUltraGrid_KeyDown);
            // 
            // FormAtencionesAnteriores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(830, 532);
            this.Controls.Add(this.atencionesAnterioresUltraGrid);
            this.Name = "FormAtencionesAnteriores";
            this.Text = "Atenciones Anteriores";
            this.Load += new System.EventHandler(this.FormAtencionesAnterioresLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.atencionesAnterioresUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsAtencionesAnteriores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencionesAnterioresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencionesAnterioresUltraGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WS.DsAtencionesAnteriores dsAtencionesAnteriores;
        private System.Windows.Forms.BindingSource atencionesAnterioresBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid atencionesAnterioresUltraGrid;
    }
}
