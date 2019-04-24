namespace Cabina
{
    partial class FormRepImprimirPrestacion
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crImprimirPrestacion1 = new Cabina.CR_ImprimirPrestacion();
            this.dsImprimirPrestacion1 = new Cabina.WS.DsImprimirPrestacion();
            ((System.ComponentModel.ISupportInitialize)(this.dsImprimirPrestacion1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.ReportSource = this.crImprimirPrestacion1;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dsImprimirPrestacion1
            // 
            this.dsImprimirPrestacion1.DataSetName = "DsImprimirPrestacion";
            this.dsImprimirPrestacion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepImprimirPrestacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepImprimirPrestacion";
            this.Text = "Imprimir Prestación";
            this.Load += new System.EventHandler(this.FormRepImprimirPrestacionLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsImprimirPrestacion1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_ImprimirPrestacion crImprimirPrestacion1;
        private WS.DsImprimirPrestacion dsImprimirPrestacion1;
    }
}
