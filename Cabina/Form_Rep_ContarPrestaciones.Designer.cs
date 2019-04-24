namespace Cabina
{
    partial class FormRepContarPrestaciones
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crContadorDePrestaciones1 = new Cabina.CR_ContadorDePrestaciones();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.ReportSource = this.crContadorDePrestaciones1;
            // 
            // FormRepContarPrestaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepContarPrestaciones";
            this.Text = "Contar Pacientes";
            this.Load += new System.EventHandler(this.FormRepContarPrestacionesLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private CR_ContadorDePrestaciones crContadorDePrestaciones1;
    }
}
