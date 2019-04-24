namespace Administración
{
    partial class FormRepAumentoAutomatico
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
            this.CR_AumentosAutomaticos1 = new Administración.CR_AumentosAutomaticos();
            this.dsRepAumentosAuto1 = new Administración.WS.DsRepAumentosAuto();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepAumentosAuto1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.ReportSource = this.CR_AumentosAutomaticos1;
            // 
            // dsRepAumentosAuto1
            // 
            this.dsRepAumentosAuto1.DataSetName = "DsRepAumentosAuto";
            this.dsRepAumentosAuto1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepAumentoAutomatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1237, 778);
            this.Name = "FormRepAumentoAutomatico";
            this.Text = "Aumento Automático";
            this.Load += new System.EventHandler(this.Form_Rep_AumentoAutomatico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsRepAumentosAuto1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_AumentosAutomaticos CR_AumentosAutomaticos1;
        private WS.DsRepAumentosAuto dsRepAumentosAuto1;
    }
}
