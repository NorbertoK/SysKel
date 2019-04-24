namespace Administración
{
    partial class FormReporteNdeC
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
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn1 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("idReporte");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn2 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre");
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton2 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            this.ultraDataSourceReportes = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.ultraCalendarComboDesde = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.ultraCalendarComboHasta = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.ultraLabelDesde = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabelHasta = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabelInclusive = new Infragistics.Win.Misc.UltraLabel();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarComboDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarComboHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraDataSourceReportes
            // 
            this.ultraDataSourceReportes.Band.Columns.AddRange(new object[] {
            ultraDataColumn1,
            ultraDataColumn2});
            this.ultraDataSourceReportes.Rows.AddRange(new object[] {
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("idReporte")),
                        ((object)("LocCod")),
                        ((object)("Nombre")),
                        ((object)("Por Localidad y Código"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("idReporte")),
                        ((object)("CodLoc")),
                        ((object)("Nombre")),
                        ((object)("Por Código y Localidad"))})});
            // 
            // ultraCalendarComboDesde
            // 
            this.ultraCalendarComboDesde.BackColor = System.Drawing.SystemColors.Window;
            dateButton1.Caption = "Hoy";
            this.ultraCalendarComboDesde.DateButtons.Add(dateButton1);
            this.ultraCalendarComboDesde.Location = new System.Drawing.Point(57, 12);
            this.ultraCalendarComboDesde.Name = "ultraCalendarComboDesde";
            this.ultraCalendarComboDesde.NonAutoSizeHeight = 21;
            this.ultraCalendarComboDesde.Size = new System.Drawing.Size(87, 21);
            this.ultraCalendarComboDesde.TabIndex = 1;
            // 
            // ultraCalendarComboHasta
            // 
            this.ultraCalendarComboHasta.BackColor = System.Drawing.SystemColors.Window;
            dateButton2.Caption = "Hoy";
            this.ultraCalendarComboHasta.DateButtons.Add(dateButton2);
            this.ultraCalendarComboHasta.Location = new System.Drawing.Point(57, 39);
            this.ultraCalendarComboHasta.Name = "ultraCalendarComboHasta";
            this.ultraCalendarComboHasta.NonAutoSizeHeight = 21;
            this.ultraCalendarComboHasta.Size = new System.Drawing.Size(87, 21);
            this.ultraCalendarComboHasta.TabIndex = 2;
            // 
            // ultraLabelDesde
            // 
            this.ultraLabelDesde.Location = new System.Drawing.Point(14, 15);
            this.ultraLabelDesde.Name = "ultraLabelDesde";
            this.ultraLabelDesde.Size = new System.Drawing.Size(37, 14);
            this.ultraLabelDesde.TabIndex = 3;
            this.ultraLabelDesde.Text = "Desde";
            // 
            // ultraLabelHasta
            // 
            this.ultraLabelHasta.Location = new System.Drawing.Point(17, 42);
            this.ultraLabelHasta.Name = "ultraLabelHasta";
            this.ultraLabelHasta.Size = new System.Drawing.Size(34, 14);
            this.ultraLabelHasta.TabIndex = 4;
            this.ultraLabelHasta.Text = "Hasta";
            // 
            // ultraLabelInclusive
            // 
            this.ultraLabelInclusive.Location = new System.Drawing.Point(150, 42);
            this.ultraLabelInclusive.Name = "ultraLabelInclusive";
            this.ultraLabelInclusive.Size = new System.Drawing.Size(48, 14);
            this.ultraLabelInclusive.TabIndex = 5;
            this.ultraLabelInclusive.Text = "inclusive";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(45, 74);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelarClick);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(126, 74);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 7;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // FormReporteNdeC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 107);
            this.ControlBox = false;
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.ultraLabelInclusive);
            this.Controls.Add(this.ultraLabelHasta);
            this.Controls.Add(this.ultraLabelDesde);
            this.Controls.Add(this.ultraCalendarComboHasta);
            this.Controls.Add(this.ultraCalendarComboDesde);
            this.Name = "FormReporteNdeC";
            this.Text = "Listado Notas de Crédito";
            this.Load += new System.EventHandler(this.FormEstPrestLoad);
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarComboDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarComboHasta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSourceReportes;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo ultraCalendarComboDesde;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo ultraCalendarComboHasta;
        private Infragistics.Win.Misc.UltraLabel ultraLabelDesde;
        private Infragistics.Win.Misc.UltraLabel ultraLabelHasta;
        private Infragistics.Win.Misc.UltraLabel ultraLabelInclusive;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
    }
}