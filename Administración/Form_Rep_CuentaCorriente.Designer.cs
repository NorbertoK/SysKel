namespace Administración
{
    partial class FormRepCuentaCorriente
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
            this.CR_CuentaCorriente1 = new Administración.CR_CuentaCorriente();
            this.ds_CuentaCorriente1 = new Administración.WS.DsCuentaCorriente();
            ((System.ComponentModel.ISupportInitialize)(this.ds_CuentaCorriente1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.DisplayStatusBar = true;
            this.crystalReportViewer1.DisplayToolbar = true;
            this.crystalReportViewer1.ReportSource = this.CR_CuentaCorriente1;
            // 
            // ds_CuentaCorriente1
            // 
            this.ds_CuentaCorriente1.DataSetName = "DsCuentaCorriente";
            this.ds_CuentaCorriente1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepCuentaCorriente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepCuentaCorriente";
            this.Text = "Cuenta Corriente";
            this.Load += new System.EventHandler(this.FormRepCuentaCorrienteLoad);
            ((System.ComponentModel.ISupportInitialize)(this.ds_CuentaCorriente1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_CuentaCorriente CR_CuentaCorriente1;
        private Administración.WS.DsCuentaCorriente ds_CuentaCorriente1;
    }
}
