namespace Administración
{
    partial class FormRepBancoMacro
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
            this.CR_BancoMacro1 = new Administración.CR_BancoMacro();
            this.dsReporteMacro1 = new Administración.DsReporteMacro();
            this.dsReporteNaranja1 = new Administración.WS.DsReporteNaranja();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteMacro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteNaranja1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.ReportSource = this.CR_BancoMacro1;
            // 
            // dsReporteMacro1
            // 
            this.dsReporteMacro1.DataSetName = "DsReporteMacro";
            this.dsReporteMacro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsReporteNaranja1
            // 
            this.dsReporteNaranja1.DataSetName = "DsReporteNaranja";
            this.dsReporteNaranja1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepBancoMacro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepBancoMacro";
            this.Text = "Banco Macro";
            this.Load += new System.EventHandler(this.FormRepBancoMacroLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteMacro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteNaranja1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_BancoMacro CR_BancoMacro1;
        private DsReporteMacro dsReporteMacro1;
        private WS.DsReporteNaranja dsReporteNaranja1;
    }
}
