namespace Administración
{
    partial class FormReportIVAVentasAfiliados
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
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton2 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            this.ultraCalendarComboDesde = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.ultraCalendarComboHasta = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.puntosDeVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPuntosDeVenta = new Administración.WS.DsPuntosDeVenta();
            this.ultraLabelDesde = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabelHasta = new Infragistics.Win.Misc.UltraLabel();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.ultraNumericEditorUltimaPaginaImpresa = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraLabelUltimaPaginaImpresa = new Infragistics.Win.Misc.UltraLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarComboDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarComboHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntosDeVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPuntosDeVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditorUltimaPaginaImpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraCalendarComboDesde
            // 
            this.ultraCalendarComboDesde.DateButtons.Add(dateButton1);
            this.ultraCalendarComboDesde.Format = "dd/MM/yyyy";
            this.ultraCalendarComboDesde.Location = new System.Drawing.Point(134, 26);
            this.ultraCalendarComboDesde.Name = "ultraCalendarComboDesde";
            this.ultraCalendarComboDesde.NonAutoSizeHeight = 21;
            this.ultraCalendarComboDesde.Size = new System.Drawing.Size(88, 21);
            this.ultraCalendarComboDesde.TabIndex = 3;
            // 
            // ultraCalendarComboHasta
            // 
            this.ultraCalendarComboHasta.DateButtons.Add(dateButton2);
            this.ultraCalendarComboHasta.Format = "dd/MM/yyyy";
            this.ultraCalendarComboHasta.Location = new System.Drawing.Point(134, 53);
            this.ultraCalendarComboHasta.Name = "ultraCalendarComboHasta";
            this.ultraCalendarComboHasta.NonAutoSizeHeight = 21;
            this.ultraCalendarComboHasta.Size = new System.Drawing.Size(88, 21);
            this.ultraCalendarComboHasta.TabIndex = 4;
            // 
            // puntosDeVentaBindingSource
            // 
            this.puntosDeVentaBindingSource.DataMember = "PuntosDeVenta";
            this.puntosDeVentaBindingSource.DataSource = this.dsPuntosDeVenta;
            // 
            // dsPuntosDeVenta
            // 
            this.dsPuntosDeVenta.DataSetName = "DsPuntosDeVenta";
            this.dsPuntosDeVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraLabelDesde
            // 
            this.ultraLabelDesde.Location = new System.Drawing.Point(91, 29);
            this.ultraLabelDesde.Name = "ultraLabelDesde";
            this.ultraLabelDesde.Size = new System.Drawing.Size(37, 14);
            this.ultraLabelDesde.TabIndex = 5;
            this.ultraLabelDesde.Text = "Desde";
            // 
            // ultraLabelHasta
            // 
            this.ultraLabelHasta.Location = new System.Drawing.Point(94, 56);
            this.ultraLabelHasta.Name = "ultraLabelHasta";
            this.ultraLabelHasta.Size = new System.Drawing.Size(34, 14);
            this.ultraLabelHasta.TabIndex = 6;
            this.ultraLabelHasta.Text = "Hasta";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(147, 125);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 8;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(66, 125);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelarClick);
            // 
            // ultraNumericEditorUltimaPaginaImpresa
            // 
            this.ultraNumericEditorUltimaPaginaImpresa.Location = new System.Drawing.Point(134, 80);
            this.ultraNumericEditorUltimaPaginaImpresa.MaskInput = "{LOC}nn,nnn,nnn";
            this.ultraNumericEditorUltimaPaginaImpresa.Name = "ultraNumericEditorUltimaPaginaImpresa";
            this.ultraNumericEditorUltimaPaginaImpresa.Size = new System.Drawing.Size(88, 21);
            this.ultraNumericEditorUltimaPaginaImpresa.TabIndex = 11;
            // 
            // ultraLabelUltimaPaginaImpresa
            // 
            this.ultraLabelUltimaPaginaImpresa.Location = new System.Drawing.Point(9, 84);
            this.ultraLabelUltimaPaginaImpresa.Name = "ultraLabelUltimaPaginaImpresa";
            this.ultraLabelUltimaPaginaImpresa.Size = new System.Drawing.Size(119, 14);
            this.ultraLabelUltimaPaginaImpresa.TabIndex = 12;
            this.ultraLabelUltimaPaginaImpresa.Text = "Última Página Impresa";
            // 
            // FormReportIVAVentasAfiliados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 158);
            this.ControlBox = false;
            this.Controls.Add(this.ultraLabelUltimaPaginaImpresa);
            this.Controls.Add(this.ultraNumericEditorUltimaPaginaImpresa);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.ultraLabelHasta);
            this.Controls.Add(this.ultraLabelDesde);
            this.Controls.Add(this.ultraCalendarComboHasta);
            this.Controls.Add(this.ultraCalendarComboDesde);
            this.Name = "FormReportIVAVentasAfiliados";
            this.Text = "IVA Ventas";
            this.Load += new System.EventHandler(this.FormReportIVAVentasAfiliadosLoad);
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarComboDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarComboHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntosDeVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPuntosDeVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditorUltimaPaginaImpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo ultraCalendarComboDesde;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo ultraCalendarComboHasta;
        private WS.DsPuntosDeVenta dsPuntosDeVenta;
        private System.Windows.Forms.BindingSource puntosDeVentaBindingSource;
        private Infragistics.Win.Misc.UltraLabel ultraLabelDesde;
        private Infragistics.Win.Misc.UltraLabel ultraLabelHasta;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor ultraNumericEditorUltimaPaginaImpresa;
        private Infragistics.Win.Misc.UltraLabel ultraLabelUltimaPaginaImpresa;
    }
}