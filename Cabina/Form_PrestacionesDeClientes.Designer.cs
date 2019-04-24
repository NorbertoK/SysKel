namespace Cabina
{
    partial class FormPrestacionesDeClientes
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
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton2 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.Appearance appearance207 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ClientesLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCategoriaIva");
            Infragistics.Win.Appearance appearance208 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance209 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance210 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance211 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance212 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance213 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance214 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance215 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance216 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance217 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance218 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance219 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance220 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance221 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance222 = new Infragistics.Win.Appearance();
            this.ultraLabelInclusive = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabelHasta = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabelDesde = new Infragistics.Win.Misc.UltraLabel();
            this.ultraCalendarCombo2 = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.ultraCalendarCombo1 = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.ultraComboClientes = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.clientesListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsClientesLista = new Cabina.WS.DsClientesLista();
            this.ultraLabelCliente = new Infragistics.Win.Misc.UltraLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarCombo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarCombo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientesLista)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Enabled = true;
            this.buttonAceptar.Location = new System.Drawing.Point(446, 20);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(338, 20);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Size = new System.Drawing.Size(566, 62);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(338, 20);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // ultraLabelInclusive
            // 
            this.ultraLabelInclusive.Location = new System.Drawing.Point(318, 17);
            this.ultraLabelInclusive.Margin = new System.Windows.Forms.Padding(4);
            this.ultraLabelInclusive.Name = "ultraLabelInclusive";
            this.ultraLabelInclusive.Size = new System.Drawing.Size(68, 17);
            this.ultraLabelInclusive.TabIndex = 9;
            this.ultraLabelInclusive.Text = "inclusive.";
            // 
            // ultraLabelHasta
            // 
            this.ultraLabelHasta.Location = new System.Drawing.Point(172, 17);
            this.ultraLabelHasta.Margin = new System.Windows.Forms.Padding(4);
            this.ultraLabelHasta.Name = "ultraLabelHasta";
            this.ultraLabelHasta.Size = new System.Drawing.Size(17, 17);
            this.ultraLabelHasta.TabIndex = 8;
            this.ultraLabelHasta.Text = "al";
            // 
            // ultraLabelDesde
            // 
            this.ultraLabelDesde.Location = new System.Drawing.Point(12, 17);
            this.ultraLabelDesde.Margin = new System.Windows.Forms.Padding(4);
            this.ultraLabelDesde.Name = "ultraLabelDesde";
            this.ultraLabelDesde.Size = new System.Drawing.Size(28, 17);
            this.ultraLabelDesde.TabIndex = 6;
            this.ultraLabelDesde.Text = "Del";
            // 
            // ultraCalendarCombo2
            // 
            this.ultraCalendarCombo2.DateButtons.Add(dateButton1);
            this.ultraCalendarCombo2.Location = new System.Drawing.Point(197, 13);
            this.ultraCalendarCombo2.Margin = new System.Windows.Forms.Padding(4);
            this.ultraCalendarCombo2.Name = "ultraCalendarCombo2";
            this.ultraCalendarCombo2.NonAutoSizeHeight = 21;
            this.ultraCalendarCombo2.Size = new System.Drawing.Size(113, 25);
            this.ultraCalendarCombo2.TabIndex = 7;
            this.ultraCalendarCombo2.Value = new System.DateTime(2007, 7, 23, 0, 0, 0, 0);
            // 
            // ultraCalendarCombo1
            // 
            this.ultraCalendarCombo1.DateButtons.Add(dateButton2);
            this.ultraCalendarCombo1.Location = new System.Drawing.Point(50, 13);
            this.ultraCalendarCombo1.Margin = new System.Windows.Forms.Padding(4);
            this.ultraCalendarCombo1.Name = "ultraCalendarCombo1";
            this.ultraCalendarCombo1.NonAutoSizeHeight = 21;
            this.ultraCalendarCombo1.Size = new System.Drawing.Size(113, 25);
            this.ultraCalendarCombo1.TabIndex = 5;
            this.ultraCalendarCombo1.Value = new System.DateTime(2007, 7, 23, 0, 0, 0, 0);
            // 
            // ultraComboClientes
            // 
            this.ultraComboClientes.AllowNull = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboClientes.DataSource = this.clientesListaBindingSource;
            appearance207.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance207.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance207.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraComboClientes.DisplayLayout.Appearance = appearance207;
            this.ultraComboClientes.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand1.ColHeadersVisible = false;
            ultraGridColumn4.Header.VisiblePosition = 0;
            ultraGridColumn4.Hidden = true;
            ultraGridColumn4.Width = 180;
            ultraGridColumn5.Header.VisiblePosition = 1;
            ultraGridColumn5.Width = 449;
            ultraGridColumn6.Header.VisiblePosition = 2;
            ultraGridColumn6.Hidden = true;
            ultraGridColumn6.Width = 80;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6});
            this.ultraComboClientes.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraComboClientes.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraComboClientes.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance208.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance208.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance208.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance208.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraComboClientes.DisplayLayout.GroupByBox.Appearance = appearance208;
            appearance209.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraComboClientes.DisplayLayout.GroupByBox.BandLabelAppearance = appearance209;
            this.ultraComboClientes.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraComboClientes.DisplayLayout.GroupByBox.Hidden = true;
            appearance210.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance210.BackColor2 = System.Drawing.SystemColors.Control;
            appearance210.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance210.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraComboClientes.DisplayLayout.GroupByBox.PromptAppearance = appearance210;
            this.ultraComboClientes.DisplayLayout.InterBandSpacing = 10;
            this.ultraComboClientes.DisplayLayout.MaxBandDepth = 5;
            this.ultraComboClientes.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraComboClientes.DisplayLayout.MaxRowScrollRegions = 1;
            appearance211.BackColor = System.Drawing.SystemColors.Window;
            this.ultraComboClientes.DisplayLayout.Override.ActiveCellAppearance = appearance211;
            appearance212.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance212.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance212.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance212.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraComboClientes.DisplayLayout.Override.ActiveRowAppearance = appearance212;
            this.ultraComboClientes.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraComboClientes.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboClientes.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboClientes.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraComboClientes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboClientes.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraComboClientes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboClientes.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraComboClientes.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance213.BackColor = System.Drawing.Color.Transparent;
            this.ultraComboClientes.DisplayLayout.Override.CardAreaAppearance = appearance213;
            appearance214.BackColor = System.Drawing.SystemColors.Control;
            appearance214.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance214.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboClientes.DisplayLayout.Override.CellAppearance = appearance214;
            this.ultraComboClientes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraComboClientes.DisplayLayout.Override.CellPadding = 0;
            this.ultraComboClientes.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance215.BackColor = System.Drawing.SystemColors.Control;
            appearance215.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance215.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance215.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance215.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraComboClientes.DisplayLayout.Override.GroupByRowAppearance = appearance215;
            appearance216.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance216.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance216.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance216.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance216.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraComboClientes.DisplayLayout.Override.HeaderAppearance = appearance216;
            this.ultraComboClientes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraComboClientes.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance217.BackColor = System.Drawing.SystemColors.Window;
            appearance217.BorderColor = System.Drawing.Color.Silver;
            this.ultraComboClientes.DisplayLayout.Override.RowAppearance = appearance217;
            appearance218.ForeColor = System.Drawing.Color.Red;
            this.ultraComboClientes.DisplayLayout.Override.RowSelectorAppearance = appearance218;
            this.ultraComboClientes.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboClientes.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance219.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraComboClientes.DisplayLayout.Override.SelectedCellAppearance = appearance219;
            appearance220.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance220.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance220.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboClientes.DisplayLayout.Override.SelectedRowAppearance = appearance220;
            appearance221.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraComboClientes.DisplayLayout.Override.TemplateAddRowAppearance = appearance221;
            appearance222.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance222.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraComboClientes.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance222;
            this.ultraComboClientes.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraComboClientes.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraComboClientes.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraComboClientes.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraComboClientes.DisplayLayout.UseFixedHeaders = true;
            this.ultraComboClientes.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraComboClientes.DisplayMember = "NombreCompleto";
            this.ultraComboClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraComboClientes.LimitToList = true;
            this.ultraComboClientes.Location = new System.Drawing.Point(74, 46);
            this.ultraComboClientes.Margin = new System.Windows.Forms.Padding(4);
            this.ultraComboClientes.Name = "ultraComboClientes";
            this.ultraComboClientes.Size = new System.Drawing.Size(472, 26);
            this.ultraComboClientes.TabIndex = 69;
            this.ultraComboClientes.ValueMember = "idCliente";
            // 
            // clientesListaBindingSource
            // 
            this.clientesListaBindingSource.DataMember = "ClientesLista";
            this.clientesListaBindingSource.DataSource = this.dsClientesLista;
            // 
            // dsClientesLista
            // 
            this.dsClientesLista.DataSetName = "DsClientesLista";
            this.dsClientesLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraLabelCliente
            // 
            this.ultraLabelCliente.Location = new System.Drawing.Point(10, 51);
            this.ultraLabelCliente.Margin = new System.Windows.Forms.Padding(4);
            this.ultraLabelCliente.Name = "ultraLabelCliente";
            this.ultraLabelCliente.Size = new System.Drawing.Size(53, 17);
            this.ultraLabelCliente.TabIndex = 68;
            this.ultraLabelCliente.Text = "Cliente";
            // 
            // FormPrestacionesDeClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(564, 149);
            this.Controls.Add(this.ultraComboClientes);
            this.Controls.Add(this.ultraLabelCliente);
            this.Controls.Add(this.ultraLabelInclusive);
            this.Controls.Add(this.ultraLabelHasta);
            this.Controls.Add(this.ultraLabelDesde);
            this.Controls.Add(this.ultraCalendarCombo2);
            this.Controls.Add(this.ultraCalendarCombo1);
            this.Name = "FormPrestacionesDeClientes";
            this.Text = "Prestacones de un Cliente";
            this.Load += new System.EventHandler(this.Form_PrestacionesDeClientes_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraCalendarCombo1, 0);
            this.Controls.SetChildIndex(this.ultraCalendarCombo2, 0);
            this.Controls.SetChildIndex(this.ultraLabelDesde, 0);
            this.Controls.SetChildIndex(this.ultraLabelHasta, 0);
            this.Controls.SetChildIndex(this.ultraLabelInclusive, 0);
            this.Controls.SetChildIndex(this.ultraLabelCliente, 0);
            this.Controls.SetChildIndex(this.ultraComboClientes, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarCombo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarCombo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientesLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.Misc.UltraLabel ultraLabelInclusive;
        private Infragistics.Win.Misc.UltraLabel ultraLabelHasta;
        private Infragistics.Win.Misc.UltraLabel ultraLabelDesde;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo ultraCalendarCombo2;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo ultraCalendarCombo1;
        private Infragistics.Win.UltraWinGrid.UltraCombo ultraComboClientes;
        private Infragistics.Win.Misc.UltraLabel ultraLabelCliente;
        private System.Windows.Forms.BindingSource clientesListaBindingSource;
        private WS.DsClientesLista dsClientesLista;
    }
}
