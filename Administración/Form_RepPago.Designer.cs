namespace Administración
{
    partial class FormRepPago
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
            this.CR_ReportPago1 = new Administración.CR_ReportPago();
            this.dsReportPago1 = new Administración.DsReportPago();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportPago1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.ReportSource = this.CR_ReportPago1;
            // 
            // dsReportPago1
            // 
            this.dsReportPago1.DataSetName = "DsReportPago";
            this.dsReportPago1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepPago";
            this.Load += new System.EventHandler(this.FormRepPagoLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsReportPago1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_ReportPago CR_ReportPago1;
        private DsReportPago dsReportPago1;
    }
}
