using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    partial class FormBuscarDireccionYAfiliado
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("BuscarTelefono", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAfiliado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLugar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DireccionCompleta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("nPlan", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPlan");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPaciente");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            this.buttonDireccion = new System.Windows.Forms.Button();
            this.buttonDireccionYAfiliado = new System.Windows.Forms.Button();
            this.buttonAfiliado = new System.Windows.Forms.Button();
            this.buttonNingun = new System.Windows.Forms.Button();
            this.buscarTelefonoUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.buscarTelefonoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCabBuscarTelefono = new Cabina.WS.DsCabBuscarTelefono();
            this.buttonContrato = new System.Windows.Forms.Button();
            this.buttonContratoYDireccion = new System.Windows.Forms.Button();
            this.buttonPaciente = new System.Windows.Forms.Button();
            this.buttonPacienteYDireccion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.buscarTelefonoUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarTelefonoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCabBuscarTelefono)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDireccion
            // 
            this.buttonDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDireccion.Location = new System.Drawing.Point(715, 526);
            this.buttonDireccion.Name = "buttonDireccion";
            this.buttonDireccion.Size = new System.Drawing.Size(121, 23);
            this.buttonDireccion.TabIndex = 8;
            this.buttonDireccion.Text = "Usar sólo la Dirección";
            this.buttonDireccion.UseVisualStyleBackColor = true;
            this.buttonDireccion.Click += new System.EventHandler(this.ButtonDireccionClick);
            // 
            // buttonDireccionYAfiliado
            // 
            this.buttonDireccionYAfiliado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDireccionYAfiliado.Location = new System.Drawing.Point(842, 526);
            this.buttonDireccionYAfiliado.Name = "buttonDireccionYAfiliado";
            this.buttonDireccionYAfiliado.Size = new System.Drawing.Size(138, 23);
            this.buttonDireccionYAfiliado.TabIndex = 7;
            this.buttonDireccionYAfiliado.Text = "Usar Afiliado y Dirección";
            this.buttonDireccionYAfiliado.UseVisualStyleBackColor = true;
            this.buttonDireccionYAfiliado.Click += new System.EventHandler(this.ButtonDireccionYAfiliadoClick);
            // 
            // buttonAfiliado
            // 
            this.buttonAfiliado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAfiliado.Location = new System.Drawing.Point(591, 526);
            this.buttonAfiliado.Name = "buttonAfiliado";
            this.buttonAfiliado.Size = new System.Drawing.Size(118, 23);
            this.buttonAfiliado.TabIndex = 9;
            this.buttonAfiliado.Text = "Usar sólo el Afiliado";
            this.buttonAfiliado.UseVisualStyleBackColor = true;
            this.buttonAfiliado.Click += new System.EventHandler(this.ButtonAfiliadoClick);
            // 
            // buttonNingun
            // 
            this.buttonNingun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNingun.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonNingun.Location = new System.Drawing.Point(460, 526);
            this.buttonNingun.Name = "buttonNingun";
            this.buttonNingun.Size = new System.Drawing.Size(125, 23);
            this.buttonNingun.TabIndex = 10;
            this.buttonNingun.Text = "No usar datos de aquí";
            this.buttonNingun.UseVisualStyleBackColor = true;
            this.buttonNingun.Click += new System.EventHandler(this.ButtonNingunClick);
            // 
            // buscarTelefonoUltraGrid
            // 
            this.buscarTelefonoUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buscarTelefonoUltraGrid.DataSource = this.buscarTelefonoBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.buscarTelefonoUltraGrid.DisplayLayout.Appearance = appearance1;
            this.buscarTelefonoUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 56;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Hidden = true;
            ultraGridColumn2.Width = 81;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Hidden = true;
            ultraGridColumn3.Width = 76;
            ultraGridColumn4.Header.Caption = "Dirección";
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn4.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(246, 0);
            ultraGridColumn4.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn4.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn4.Width = 212;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn5.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(237, 0);
            ultraGridColumn5.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn5.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn5.Width = 185;
            ultraGridColumn6.Header.Caption = "Plan ó Contrato";
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridColumn6.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn6.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(144, 0);
            ultraGridColumn6.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn6.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn6.Width = 178;
            ultraGridColumn7.Header.VisiblePosition = 6;
            ultraGridColumn7.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn7.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(73, 0);
            ultraGridColumn7.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn7.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn7.Width = 201;
            ultraGridColumn8.Header.VisiblePosition = 7;
            ultraGridColumn8.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn8.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn8.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(249, 0);
            ultraGridColumn8.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn8.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn8.Width = 183;
            ultraGridColumn9.Header.VisiblePosition = 8;
            ultraGridColumn9.Hidden = true;
            ultraGridColumn10.Header.VisiblePosition = 9;
            ultraGridColumn10.Hidden = true;
            ultraGridColumn11.Header.VisiblePosition = 10;
            ultraGridColumn11.Hidden = true;
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
            ultraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.buscarTelefonoUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.buscarTelefonoUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.buscarTelefonoUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.buscarTelefonoUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.buscarTelefonoUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buscarTelefonoUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.buscarTelefonoUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.buscarTelefonoUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.buscarTelefonoUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.buscarTelefonoUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.buscarTelefonoUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.buscarTelefonoUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.buscarTelefonoUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.buscarTelefonoUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.buscarTelefonoUltraGrid.DisplayLayout.Override.CellAppearance = appearance5;
            this.buscarTelefonoUltraGrid.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.buscarTelefonoUltraGrid.DisplayLayout.Override.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            this.buscarTelefonoUltraGrid.DisplayLayout.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            this.buscarTelefonoUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.buscarTelefonoUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.buscarTelefonoUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.buscarTelefonoUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.buscarTelefonoUltraGrid.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Free;
            this.buscarTelefonoUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.buscarTelefonoUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.buscarTelefonoUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.buscarTelefonoUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.buscarTelefonoUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buscarTelefonoUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.buscarTelefonoUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.buscarTelefonoUltraGrid.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.buscarTelefonoUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.buscarTelefonoUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarTelefonoUltraGrid.Location = new System.Drawing.Point(-2, 1);
            this.buscarTelefonoUltraGrid.Name = "buscarTelefonoUltraGrid";
            this.buscarTelefonoUltraGrid.Size = new System.Drawing.Size(994, 519);
            this.buscarTelefonoUltraGrid.TabIndex = 4;
            this.buscarTelefonoUltraGrid.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.BuscarTelefonoUltraGridInitializeLayout);
            this.buscarTelefonoUltraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.BuscarTelefonoUltraGridInitializeRow);
            this.buscarTelefonoUltraGrid.AfterEnterEditMode += new System.EventHandler(this.buscarTelefonoUltraGrid_AfterEnterEditMode);
            this.buscarTelefonoUltraGrid.AfterRowActivate += new System.EventHandler(this.BuscarTelefonoUltraGridAfterRowActivate);
            this.buscarTelefonoUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buscarTelefonoUltraGrid_KeyDown);
            // 
            // buscarTelefonoBindingSource
            // 
            this.buscarTelefonoBindingSource.DataMember = "BuscarTelefono";
            this.buscarTelefonoBindingSource.DataSource = this.dsCabBuscarTelefono;
            // 
            // dsCabBuscarTelefono
            // 
            this.dsCabBuscarTelefono.DataSetName = "Dscab_BuscarTelefono";
            this.dsCabBuscarTelefono.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonContrato
            // 
            this.buttonContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonContrato.Location = new System.Drawing.Point(591, 526);
            this.buttonContrato.Name = "buttonContrato";
            this.buttonContrato.Size = new System.Drawing.Size(118, 23);
            this.buttonContrato.TabIndex = 11;
            this.buttonContrato.Text = "Usar sólo el Contrato";
            this.buttonContrato.UseVisualStyleBackColor = true;
            this.buttonContrato.Click += new System.EventHandler(this.ButtonContratoClick);
            // 
            // buttonContratoYDireccion
            // 
            this.buttonContratoYDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonContratoYDireccion.Location = new System.Drawing.Point(842, 526);
            this.buttonContratoYDireccion.Name = "buttonContratoYDireccion";
            this.buttonContratoYDireccion.Size = new System.Drawing.Size(138, 23);
            this.buttonContratoYDireccion.TabIndex = 12;
            this.buttonContratoYDireccion.Text = "Usar Contrato y Dirección";
            this.buttonContratoYDireccion.UseVisualStyleBackColor = true;
            this.buttonContratoYDireccion.Click += new System.EventHandler(this.ButtonContratoYDireccionClick);
            // 
            // buttonPaciente
            // 
            this.buttonPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPaciente.Location = new System.Drawing.Point(591, 526);
            this.buttonPaciente.Name = "buttonPaciente";
            this.buttonPaciente.Size = new System.Drawing.Size(118, 23);
            this.buttonPaciente.TabIndex = 13;
            this.buttonPaciente.Text = "Usar sólo el Paciente";
            this.buttonPaciente.UseVisualStyleBackColor = true;
            this.buttonPaciente.Visible = false;
            this.buttonPaciente.Click += new System.EventHandler(this.ButtonPacienteClick);
            // 
            // buttonPacienteYDireccion
            // 
            this.buttonPacienteYDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPacienteYDireccion.Location = new System.Drawing.Point(842, 526);
            this.buttonPacienteYDireccion.Name = "buttonPacienteYDireccion";
            this.buttonPacienteYDireccion.Size = new System.Drawing.Size(138, 23);
            this.buttonPacienteYDireccion.TabIndex = 14;
            this.buttonPacienteYDireccion.Text = "Usar Paciente y Dirección";
            this.buttonPacienteYDireccion.UseVisualStyleBackColor = true;
            this.buttonPacienteYDireccion.Visible = false;
            this.buttonPacienteYDireccion.Click += new System.EventHandler(this.ButtonPacienteYDireccionClick);
            // 
            // FormBuscarDireccionYAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonNingun;
            this.ClientSize = new System.Drawing.Size(992, 561);
            this.ControlBox = false;
            this.Controls.Add(this.buttonPacienteYDireccion);
            this.Controls.Add(this.buttonPaciente);
            this.Controls.Add(this.buttonContratoYDireccion);
            this.Controls.Add(this.buttonContrato);
            this.Controls.Add(this.buttonNingun);
            this.Controls.Add(this.buttonAfiliado);
            this.Controls.Add(this.buttonDireccion);
            this.Controls.Add(this.buttonDireccionYAfiliado);
            this.Controls.Add(this.buscarTelefonoUltraGrid);
            this.Name = "FormBuscarDireccionYAfiliado";
            this.Text = "Buscar Direcciones y Afiliados";
            this.Load += new System.EventHandler(this.FormBuscarDireccionYAfiliadoLoad);
            ((System.ComponentModel.ISupportInitialize)(this.buscarTelefonoUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarTelefonoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCabBuscarTelefono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDireccion;
        private System.Windows.Forms.Button buttonDireccionYAfiliado;
        private System.Windows.Forms.Button buttonAfiliado;
        private System.Windows.Forms.Button buttonNingun;
        private Infragistics.Win.UltraWinGrid.UltraGrid buscarTelefonoUltraGrid;
        private System.Windows.Forms.BindingSource buscarTelefonoBindingSource;
        private WS.DsCabBuscarTelefono dsCabBuscarTelefono;
        private System.Windows.Forms.Button buttonContrato;
        private System.Windows.Forms.Button buttonContratoYDireccion;
        private System.Windows.Forms.Button buttonPaciente;
        private System.Windows.Forms.Button buttonPacienteYDireccion;
    }
}