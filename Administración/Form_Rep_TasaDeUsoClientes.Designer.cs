namespace Administración
{
    partial class FormRepTasaDeUsoClientes
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
            this.crTasaDeUsoClientes = new Administración.CR_TasaDeUsoClientes();
            this.dsTasaDeUsoClientes1 = new Administración.DsTasaDeUsoClientes();
            ((System.ComponentModel.ISupportInitialize)(this.dsTasaDeUsoClientes1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.ReportSource = this.crTasaDeUsoClientes;
            // 
            // dsTasaDeUsoClientes1
            // 
            this.dsTasaDeUsoClientes1.DataSetName = "DsTasaDeUsoClientes";
            this.dsTasaDeUsoClientes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepTasaDeUsoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepTasaDeUsoClientes";
            this.Text = "Tasa de Uso de Clientes";
            this.Load += new System.EventHandler(this.Form_Rep_TasaDeUsoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTasaDeUsoClientes1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_TasaDeUsoClientes crTasaDeUsoClientes;
        private DsTasaDeUsoClientes dsTasaDeUsoClientes1;
    }
}
