namespace Cabina
{
    partial class FormRepInformeAsistencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CR_InformeAsistencia1 = new Cabina.CR_InformeAsistencia();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.ReportSource = this.CR_InformeAsistencia1;
            // 
            // FormRepInformeAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepInformeAsistencia";
            this.Text = "Informe de Asistencia Médica";
            this.Load += new System.EventHandler(this.FormRepInformeAsistenciaLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private CR_InformeAsistencia CR_InformeAsistencia1;
    }
}
