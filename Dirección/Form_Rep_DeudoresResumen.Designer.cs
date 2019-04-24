namespace Dirección
{
    partial class FormRepDeudoresResumen
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crDeudoresResumen1 = new Dirección.CR_DeudoresResumen();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.ReportSource = this.crDeudoresResumen1;
            // 
            // FormRepDeudoresResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepDeudoresResumen";
            this.Text = "Deudores (Resumen)";
            this.Load += new System.EventHandler(this.FormRepDeudoresResumenLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private CR_DeudoresResumen crDeudoresResumen1;
    }
}
