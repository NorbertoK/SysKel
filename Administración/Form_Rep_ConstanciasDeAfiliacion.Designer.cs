namespace Administración
{
    partial class FormRepConstanciasDeAfiliacion
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crConstanciasAfiliacion1 = new Administración.CR_ConstanciasAfiliacion();
            this.dsRepConstanciasAfiliacion1 = new Administración.WS.DsRepConstanciasAfiliacion();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepConstanciasAfiliacion1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.DisplayStatusBar = true;
            this.crystalReportViewer1.DisplayToolbar = true;
            this.crystalReportViewer1.ReportSource = this.crConstanciasAfiliacion1;
            // 
            // dsRepConstanciasAfiliacion1
            // 
            this.dsRepConstanciasAfiliacion1.DataSetName = "DsRepConstanciasAfiliacion";
            this.dsRepConstanciasAfiliacion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepConstanciasDeAfiliacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepConstanciasDeAfiliacion";
            this.Text = "Constancias de Afiliación";
            this.Load += new System.EventHandler(this.FormRepConstanciasDeAfiliacionLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsRepConstanciasAfiliacion1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_ConstanciasAfiliacion crConstanciasAfiliacion1;
        private WS.DsRepConstanciasAfiliacion dsRepConstanciasAfiliacion1;
    }
}
