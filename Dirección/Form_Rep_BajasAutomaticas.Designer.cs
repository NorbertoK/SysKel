namespace Dirección
{
    partial class FormRepBajasAutomaticas
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crBajasAutomaticas1 = new Dirección.CR_BajasAutomaticas();
            this.dsRepBajasAutomaticas1 = new Dirección.WS.DsRepBajasAutomaticas();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepBajasAutomaticas1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.ReportSource = this.crBajasAutomaticas1;
            // 
            // dsRepBajasAutomaticas1
            // 
            this.dsRepBajasAutomaticas1.DataSetName = "DsRepBajasAutomaticas";
            this.dsRepBajasAutomaticas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepBajasRecientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepBajasRecientes";
            this.Text = "Bajas Automáticas";
            this.Load += new System.EventHandler(this.FormRepBajasRecientesLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsRepBajasAutomaticas1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_BajasAutomaticas crBajasAutomaticas1;
        private WS.DsRepBajasAutomaticas dsRepBajasAutomaticas1;
    }
}
