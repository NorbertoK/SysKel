namespace Administración
{
    partial class FormRepFacturadoYCobrado
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
            this.crFacturadoYCobrado1 = new Administración.CR_FacturadoYCobrado();
            this.dsFacturadoYCobrado1 = new Administración.WS.DsFacturadoYCobrado();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturadoYCobrado1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.ReportSource = this.crFacturadoYCobrado1;
            // 
            // dsFacturadoYCobrado1
            // 
            this.dsFacturadoYCobrado1.DataSetName = "DsFacturadoYCobrado";
            this.dsFacturadoYCobrado1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepFacturadoYCobrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepFacturadoYCobrado";
            this.Text = "Facturado y Cobrado";
            this.Load += new System.EventHandler(this.FormFacturadoYCobrado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturadoYCobrado1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_FacturadoYCobrado crFacturadoYCobrado1;
        private WS.DsFacturadoYCobrado dsFacturadoYCobrado1;
    }
}
