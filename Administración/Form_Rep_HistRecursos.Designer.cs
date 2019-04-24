namespace Administración
{
    partial class FormRepHistRecursos
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
            this.CR_Hist_Recursos1 = new Administración.CR_Hist_Recursos();
            this.dsHist_Recursos1 = new Administración.DsHist_Recursos();
            ((System.ComponentModel.ISupportInitialize)(this.dsHist_Recursos1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.ReportSource = this.CR_Hist_Recursos1;
            // 
            // dsHist_Recursos1
            // 
            this.dsHist_Recursos1.DataSetName = "DsHist_Recursos";
            this.dsHist_Recursos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepHistRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepHistRecursos";
            this.Text = "Histórico de Recursos";
            this.Load += new System.EventHandler(this.FormRepHistRecursosLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsHist_Recursos1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_Hist_Recursos CR_Hist_Recursos1;
        private DsHist_Recursos dsHist_Recursos1;
    }
}
