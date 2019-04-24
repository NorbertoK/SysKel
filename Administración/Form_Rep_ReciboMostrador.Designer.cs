namespace Administración
{
    partial class FormRepReciboMostrador
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
            this.CR_ReciboMostrador1 = new Administración.CR_ReciboMostrador();
            this.dsReportRemesa1 = new Administración.DsReportRemesa();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportRemesa1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.ReportSource = this.CR_ReciboMostrador1;
            // 
            // dsReportRemesa1
            // 
            this.dsReportRemesa1.DataSetName = "DsReportRemesa";
            this.dsReportRemesa1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepReciboMostrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepReciboMostrador";
            this.Text = "Recibo Mostrador";
            this.Load += new System.EventHandler(this.FormRepReciboMostrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsReportRemesa1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_ReciboMostrador CR_ReciboMostrador1;
        private DsReportRemesa dsReportRemesa1;
    }
}
