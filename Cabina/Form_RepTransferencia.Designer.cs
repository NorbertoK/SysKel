namespace Cabina
{
    partial class FormRepTransferencia
    {
 
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crTransferencia1 = new Cabina.CR_Transferencia();
            this.dsReporteTransferencia1 = new Cabina.WS.DsReporteTransferencia();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteTransferencia1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.DisplayStatusBar = true;
            this.crystalReportViewer1.DisplayToolbar = true;
            this.crystalReportViewer1.ReportSource = this.crTransferencia1;
            // 
            // dsReporteTransferencia1
            // 
            this.dsReporteTransferencia1.DataSetName = "DsReporteTransferencia";
            this.dsReporteTransferencia1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepTransferencia";
            this.Load += new System.EventHandler(this.FormRepTransferenciaLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteTransferencia1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_Transferencia crTransferencia1;
        private WS.DsReporteTransferencia dsReporteTransferencia1;
    }
}
