namespace Administración
{
    partial class FormRepFacturadoClientes
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
            this.crFacturadoClientes = new Administración.CR_FacturadoClientes();
            this.dsFacturadoClientes = new Administración.DsFacturadoClientes();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturadoClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.ReportSource = this.crFacturadoClientes;
            // 
            // dsFacturadoClientes
            // 
            this.dsFacturadoClientes.DataSetName = "DsFacturadoClientes";
            this.dsFacturadoClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepFacturadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepFacturadoClientes";
            this.Load += new System.EventHandler(this.FormRepFacturadoClientesLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturadoClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_FacturadoClientes crFacturadoClientes;
        private DsFacturadoClientes dsFacturadoClientes;
    }
}
