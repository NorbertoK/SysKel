namespace Administración
{
    partial class FormRepDeudores
    {
 
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crDeudores = new Administración.CR_Deudores();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.ReportSource = this.crDeudores;
            // 
            // FormRepDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepDeudores";
            this.Text = "Deudores";
            this.Load += new System.EventHandler(this.FormRepDeudoresLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private CR_Deudores crDeudores;
    }
}
