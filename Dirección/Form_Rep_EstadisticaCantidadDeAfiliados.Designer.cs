namespace Dirección
{
    partial class FormRepEstadisticaCantidadDeAfiliados
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
            this.crEstadisticaCantidadDeAfiliados1 = new Dirección.CR_EstadisticaCantidadDeAfiliados();
            this.dsEstadisticaCantidadDeAfiliados1 = new Dirección.WS.DsEstadisticaCantidadDeAfiliados();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstadisticaCantidadDeAfiliados1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.crystalReportViewer1.ReportSource = this.crEstadisticaCantidadDeAfiliados1;
            // 
            // dsEstadisticaCantidadDeAfiliados1
            // 
            this.dsEstadisticaCantidadDeAfiliados1.DataSetName = "DsEstadisticaCantidadDeAfiliados";
            this.dsEstadisticaCantidadDeAfiliados1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepEstadisticaCantidadDeAfiliados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepEstadisticaCantidadDeAfiliados";
            this.Text = "Estadística Cantidad de Afiliados";
            this.Load += new System.EventHandler(this.FormRepEstadisticaCantidadDeAfiliadosLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsEstadisticaCantidadDeAfiliados1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_EstadisticaCantidadDeAfiliados crEstadisticaCantidadDeAfiliados1;
        private Dirección.WS.DsEstadisticaCantidadDeAfiliados dsEstadisticaCantidadDeAfiliados1;
    }
}
