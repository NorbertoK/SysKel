namespace Administración
{
    partial class FormRepRetiro
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dsReporteRetiro1 = new Administración.WS.DsReporteRetiro();
            this.crRetiro1 = new Administración.CR_Retiro();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteRetiro1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.ReportSource = this.crRetiro1;
            // 
            // dsReporteRetiro1
            // 
            this.dsReporteRetiro1.DataSetName = "DsReporteRetiro";
            this.dsReporteRetiro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepRetiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepRetiro";
            this.Text = "Reporte de Retiro";
            this.Load += new System.EventHandler(this.FormRepRetiroLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteRetiro1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WS.DsReporteRetiro dsReporteRetiro1;
        private CR_Retiro crRetiro1;
    }
}
