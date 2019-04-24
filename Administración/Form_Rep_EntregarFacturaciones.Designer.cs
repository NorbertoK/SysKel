namespace Administración
{
    partial class FormRepEntregarFacturaciones
    {
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crEntregarFacturaciones1 = new Administración.CR_EntregarFacturaciones();
            this.dsFacturaciones1 = new Administración.WS.DsFacturaciones();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturaciones1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.ReportSource = this.crEntregarFacturaciones1;
            // 
            // dsFacturaciones1
            // 
            this.dsFacturaciones1.DataSetName = "DsFacturaciones";
            this.dsFacturaciones1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepEntregarFacturaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepEntregarFacturaciones";
            this.Text = "Entregar Facturaciones";
            this.Load += new System.EventHandler(this.FormRepEntregarFacturacionesLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturaciones1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_EntregarFacturaciones crEntregarFacturaciones1;
        private WS.DsFacturaciones dsFacturaciones1;
    }
}
