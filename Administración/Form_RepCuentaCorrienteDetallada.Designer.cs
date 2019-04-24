namespace Administración
{
    partial class FormRepCuentaCorrienteDetallada
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
            this.CR_CuentaCorrienteDetallada1 = new Administración.CR_CuentaCorrienteDetallada();
            this.ds_CuentaCorriente1 = new Administración.WS.DsCuentaCorriente();
            this.dsDetalleFacturasCliente1 = new Administración.WS.DsDetalleFacturasCliente();
            ((System.ComponentModel.ISupportInitialize)(this.ds_CuentaCorriente1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetalleFacturasCliente1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.ReportSource = this.CR_CuentaCorrienteDetallada1;
            // 
            // ds_CuentaCorriente1
            // 
            this.ds_CuentaCorriente1.DataSetName = "DsCuentaCorriente";
            this.ds_CuentaCorriente1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsDetalleFacturasCliente1
            // 
            this.dsDetalleFacturasCliente1.DataSetName = "DsDetalleFacturasCliente";
            this.dsDetalleFacturasCliente1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepCuentaCorrienteDetallada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepCuentaCorrienteDetallada";
            this.Text = "Cuenta Corriente Detallada";
            this.Load += new System.EventHandler(this.FormRepCuentaCorrienteDetallada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_CuentaCorriente1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetalleFacturasCliente1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_CuentaCorrienteDetallada CR_CuentaCorrienteDetallada1;
        private WS.DsCuentaCorriente ds_CuentaCorriente1;
        private WS.DsDetalleFacturasCliente dsDetalleFacturasCliente1;
    }
}
