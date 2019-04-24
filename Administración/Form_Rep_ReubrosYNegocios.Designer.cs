namespace Administración
{
    partial class FormRepReubrosYNegocios
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
            this.CR_RubrosYNegocios1 = new Administración.CR_RubrosYNegocios();
            this.dsReporteRubrosNegocios1 = new Administración.DsReporteRubrosNegocios();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteRubrosNegocios1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.ReportSource = this.CR_RubrosYNegocios1;
            // 
            // dsReporteRubrosNegocios1
            // 
            this.dsReporteRubrosNegocios1.DataSetName = "DsReporteRubrosNegocios";
            this.dsReporteRubrosNegocios1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepReubrosYNegocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepReubrosYNegocios";
            this.Text = "Rubros y Negocios";
            this.Load += new System.EventHandler(this.FormRepReubrosYNegociosLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteRubrosNegocios1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_RubrosYNegocios CR_RubrosYNegocios1;
        private DsReporteRubrosNegocios dsReporteRubrosNegocios1;
    }
}
