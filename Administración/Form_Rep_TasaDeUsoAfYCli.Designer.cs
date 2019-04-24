namespace Administración
{
    partial class FormRepTasaDeUsoAfYCli
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
            this.crTasaDeUsoAfYCli1 = new Administración.CR_TasaDeUsoAfYCli();
            this.dsTasaDeUsoAfYCli1 = new Administración.DsTasaDeUsoAfYCli();
            ((System.ComponentModel.ISupportInitialize)(this.dsTasaDeUsoAfYCli1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.ReportSource = this.crTasaDeUsoAfYCli1;
            // 
            // dsTasaDeUsoAfYCli1
            // 
            this.dsTasaDeUsoAfYCli1.DataSetName = "DsTasaDeUsoAfYCli";
            this.dsTasaDeUsoAfYCli1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepTasaDeUsoAfYCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepTasaDeUsoAfYCli";
            this.Text = "Tasa de Uso Afiliados y Clientes";
            this.Load += new System.EventHandler(this.FormRepTasaDeUsoAfYCli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTasaDeUsoAfYCli1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_TasaDeUsoAfYCli crTasaDeUsoAfYCli1;
        private DsTasaDeUsoAfYCli dsTasaDeUsoAfYCli1;
    }
}
