namespace Administración
{
    partial class FormRepHistRenglonesFacturaModelo
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
            this.CR_Hist_RenglonesFacturaProforma1 = new Administración.CR_Hist_RenglonesFacturaProforma();
            this.dsHist_RenglonesFacturaProforma1 = new Administración.DsHist_RenglonesFacturaProforma();
            ((System.ComponentModel.ISupportInitialize)(this.dsHist_RenglonesFacturaProforma1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.ReportSource = this.CR_Hist_RenglonesFacturaProforma1;
            this.crystalReportViewer1.Load += new System.EventHandler(this.CrystalReportViewer1Load);
            // 
            // dsHist_RenglonesFacturaProforma1
            // 
            this.dsHist_RenglonesFacturaProforma1.DataSetName = "DsHist_RenglonesFacturaProforma";
            this.dsHist_RenglonesFacturaProforma1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepHistRenglonesFacturaModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepHistRenglonesFacturaModelo";
            this.Text = "Histórico de los Renglones de Factura Modelo";
            ((System.ComponentModel.ISupportInitialize)(this.dsHist_RenglonesFacturaProforma1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_Hist_RenglonesFacturaProforma CR_Hist_RenglonesFacturaProforma1;
        private DsHist_RenglonesFacturaProforma dsHist_RenglonesFacturaProforma1;
    }
}
