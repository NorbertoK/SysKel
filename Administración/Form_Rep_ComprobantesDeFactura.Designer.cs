namespace Administración
{
    partial class FormRepComprobantesDeFactura
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crComprobantesDeFacturas1 = new Administración.CR_ComprobantesDeFacturas();
            this.dsComprobantesDeFacturas1 = new Administración.WS.DsComprobantesDeFacturas();
            this.crComprobantesDeFacturasConResumen1 = new Administración.CR_ComprobantesDeFacturasConResumen();
            this.crComprobantesDeFacturas31 = new Administración.CR_ComprobantesDeFacturas3();
            this.crComprobantesDeFacturasConResumen31 = new Administración.CR_ComprobantesDeFacturasConResumen3();
            this.crFacturaA_Clientes = new Administración.CR_FacturaA_Clientes();
            this.crFacturaB_Clientes = new Administración.CR_FacturaB_Clientes();
            ((System.ComponentModel.ISupportInitialize)(this.dsComprobantesDeFacturas1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.ReportSource = this.crFacturaB_Clientes;
            // 
            // dsComprobantesDeFacturas1
            // 
            this.dsComprobantesDeFacturas1.DataSetName = "DsComprobantesDeFacturas";
            this.dsComprobantesDeFacturas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crComprobantesDeFacturasConResumen31
            // 
            this.crComprobantesDeFacturasConResumen31.FileName = "rassdk://C:\\Users\\Norberto Kelijman\\AppData\\Local\\Temp\\temp_2bc4ce86-0a62-405b-a0" +
    "53-1439cbe181fa.rpt";
            // 
            // FormRepComprobantesDeFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepComprobantesDeFactura";
            this.Text = "Comprobantes de Factura";
            this.Load += new System.EventHandler(this.FormRepConstanciasDeAfiliacionLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsComprobantesDeFacturas1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_ComprobantesDeFacturas crComprobantesDeFacturas1;
        private WS.DsComprobantesDeFacturas dsComprobantesDeFacturas1;
        private CR_ComprobantesDeFacturasConResumen crComprobantesDeFacturasConResumen1;
        private CR_ComprobantesDeFacturas3 crComprobantesDeFacturas31;
        private Administración.CR_ComprobantesDeFacturasConResumen3 crComprobantesDeFacturasConResumen31;
        private CR_FacturaA_Clientes crFacturaA_Clientes;
        private CR_FacturaB_Clientes crFacturaB_Clientes;

    }
}
