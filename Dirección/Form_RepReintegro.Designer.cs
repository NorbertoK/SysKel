namespace Dirección
{
    partial class FormRepReintegro
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crReintegro1 = new Dirección.CR_Reintegro();
            this.dsReporteReintegro1 = new Dirección.WS.DsReporteReintegro();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteReintegro1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.ReportSource = this.crReintegro1;
            // 
            // dsReporteReintegro1
            // 
            this.dsReporteReintegro1.DataSetName = "DsReporteReintegro";
            this.dsReporteReintegro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepReintegro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepReintegro";
            this.Text = "Reporte de Retiro";
            this.Load += new System.EventHandler(this.FormRepReintegroLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteReintegro1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_Reintegro crReintegro1;
        private WS.DsReporteReintegro dsReporteReintegro1;
    }
}
