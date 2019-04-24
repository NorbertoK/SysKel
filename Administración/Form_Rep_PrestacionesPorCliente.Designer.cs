namespace Administración
{
    partial class FormRepPrestacionesPorCliente
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
            this.CR_ResumenPrestacionesPorCliente1 = new Administración.CR_ResumenPrestacionesPorCliente();
            this.cR_ResumenPrestacionesPorClienteSoloDomicilios1 = new Administración.CR_ResumenPrestacionesPorClienteSoloDomicilios();
            this.dsRepResumenPrestacionesPorCliente1 = new Administración.WS.DsRepResumenPrestacionesPorCliente();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepResumenPrestacionesPorCliente1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.ReportSource = this.CR_ResumenPrestacionesPorCliente1;
            // 
            // dsRepResumenPrestacionesPorCliente1
            // 
            this.dsRepResumenPrestacionesPorCliente1.DataSetName = "DsRepResumenPrestacionesPorCliente";
            this.dsRepResumenPrestacionesPorCliente1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepPrestacionesPorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepPrestacionesPorCliente";
            this.Text = "Pacientes por Cliente";
            this.Load += new System.EventHandler(this.FormRepPrestacionesPorClienteLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsRepResumenPrestacionesPorCliente1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_ResumenPrestacionesPorCliente CR_ResumenPrestacionesPorCliente1;
        private CR_ResumenPrestacionesPorClienteSoloDomicilios cR_ResumenPrestacionesPorClienteSoloDomicilios1;
        private WS.DsRepResumenPrestacionesPorCliente dsRepResumenPrestacionesPorCliente1;
    }
}
