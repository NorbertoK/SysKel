namespace Cabina
{
    partial class FormGenerarTurnos
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
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn1 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Indice");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn2 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre");
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraComboEditorMes = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.ultraDataSourceMes = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.ultraNumericEditorAnyo = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboEditorMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditorAnyo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Enabled = true;
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(14, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 114);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(95, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.AutoSize = true;
            this.ultraLabel1.Location = new System.Drawing.Point(12, 12);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(221, 14);
            this.ultraLabel1.TabIndex = 1;
            this.ultraLabel1.Text = "Se generarán turnos vacíos para el período";
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Location = new System.Drawing.Point(14, 72);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(239, 47);
            this.ultraLabel2.TabIndex = 2;
            this.ultraLabel2.Text = "según la planilla Moldes de Turnos, con excepción de los días que figuren en la t" +
    "abla Feriados.";
            // 
            // ultraComboEditorMes
            // 
            appearance1.TextHAlignAsString = "Right";
            this.ultraComboEditorMes.Appearance = appearance1;
            this.ultraComboEditorMes.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.ultraComboEditorMes.DataMember = "Band 0";
            this.ultraComboEditorMes.DataSource = this.ultraDataSourceMes;
            this.ultraComboEditorMes.DisplayMember = "Nombre";
            this.ultraComboEditorMes.Location = new System.Drawing.Point(48, 38);
            this.ultraComboEditorMes.Name = "ultraComboEditorMes";
            this.ultraComboEditorMes.ShowOverflowIndicator = true;
            this.ultraComboEditorMes.Size = new System.Drawing.Size(76, 21);
            this.ultraComboEditorMes.TabIndex = 3;
            // 
            // ultraDataSourceMes
            // 
            this.ultraDataSourceMes.AllowAdd = false;
            this.ultraDataSourceMes.AllowDelete = false;
            ultraDataColumn1.DataType = typeof(int);
            this.ultraDataSourceMes.Band.Columns.AddRange(new object[] {
            ultraDataColumn1,
            ultraDataColumn2});
            this.ultraDataSourceMes.Rows.AddRange(new object[] {
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Indice")),
                        ((object)(1)),
                        ((object)("Nombre")),
                        ((object)("Enero"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Indice")),
                        ((object)(2)),
                        ((object)("Nombre")),
                        ((object)("Febrero"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Indice")),
                        ((object)(3)),
                        ((object)("Nombre")),
                        ((object)("Marzo"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Indice")),
                        ((object)(4)),
                        ((object)("Nombre")),
                        ((object)("Abril"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Indice")),
                        ((object)(5)),
                        ((object)("Nombre")),
                        ((object)("Mayo"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Indice")),
                        ((object)(6)),
                        ((object)("Nombre")),
                        ((object)("Junio"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Indice")),
                        ((object)(7)),
                        ((object)("Nombre")),
                        ((object)("Julio"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Indice")),
                        ((object)(8)),
                        ((object)("Nombre")),
                        ((object)("Agosto"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Indice")),
                        ((object)(9)),
                        ((object)("Nombre")),
                        ((object)("Septiembre"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Indice")),
                        ((object)(10)),
                        ((object)("Nombre")),
                        ((object)("Octubre"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Indice")),
                        ((object)(11)),
                        ((object)("Nombre")),
                        ((object)("Noviembre"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Indice")),
                        ((object)(12)),
                        ((object)("Nombre")),
                        ((object)("Diciembre"))})});
            // 
            // ultraNumericEditorAnyo
            // 
            this.ultraNumericEditorAnyo.Location = new System.Drawing.Point(153, 38);
            this.ultraNumericEditorAnyo.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw;
            this.ultraNumericEditorAnyo.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw;
            this.ultraNumericEditorAnyo.MaskInput = "nnnnnnnnn";
            this.ultraNumericEditorAnyo.MaxValue = 2099;
            this.ultraNumericEditorAnyo.MinValue = 2012;
            this.ultraNumericEditorAnyo.Name = "ultraNumericEditorAnyo";
            this.ultraNumericEditorAnyo.Size = new System.Drawing.Size(57, 21);
            this.ultraNumericEditorAnyo.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always;
            this.ultraNumericEditorAnyo.TabIndex = 5;
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.AutoSize = true;
            this.ultraLabel3.Location = new System.Drawing.Point(130, 42);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(17, 14);
            this.ultraLabel3.TabIndex = 6;
            this.ultraLabel3.Text = "de";
            // 
            // FormGenerarTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(265, 162);
            this.Controls.Add(this.ultraLabel3);
            this.Controls.Add(this.ultraNumericEditorAnyo);
            this.Controls.Add(this.ultraComboEditorMes);
            this.Controls.Add(this.ultraLabel2);
            this.Controls.Add(this.ultraLabel1);
            this.Name = "FormGenerarTurnos";
            this.Text = "Generr Turnos";
            this.Load += new System.EventHandler(this.FormGenerarTurnosLoad);
            this.Controls.SetChildIndex(this.ultraLabel1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraLabel2, 0);
            this.Controls.SetChildIndex(this.ultraComboEditorMes, 0);
            this.Controls.SetChildIndex(this.ultraNumericEditorAnyo, 0);
            this.Controls.SetChildIndex(this.ultraLabel3, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboEditorMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditorAnyo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor ultraComboEditorMes;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSourceMes;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor ultraNumericEditorAnyo;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
    }
}
