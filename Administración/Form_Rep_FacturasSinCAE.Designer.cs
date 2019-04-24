namespace Administración
{
    partial class FormRepFacturasSinCAE
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
            this.CR_FacturasSinCAE1 = new Administración.CR_FacturasSinCAE();
            this.dsFacturasSinCAE1 = new Administración.DsFacturasSinCAE();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturasSinCAE1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.ReportSource = this.CR_FacturasSinCAE1;
            // 
            // dsFacturasSinCAE1
            // 
            this.dsFacturasSinCAE1.DataSetName = "DsFacturasSinCAE";
            this.dsFacturasSinCAE1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepFacturasSinCAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepFacturasSinCAE";
            this.Text = "Facturas sin CAE";
            this.Load += new System.EventHandler(this.FormRepFacturasSinCAE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturasSinCAE1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_FacturasSinCAE CR_FacturasSinCAE1;
        private DsFacturasSinCAE dsFacturasSinCAE1;
    }
}
