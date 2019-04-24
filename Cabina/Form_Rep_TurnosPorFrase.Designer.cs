namespace Cabina
{
    partial class FormRepTurnosPorFrase
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
            this.CR_TurnoPorFrase1 = new Cabina.CR_TurnoPorFrase();
            this.dsTurnosImprimir1 = new Administración.DsTurnosImprimir();
            ((System.ComponentModel.ISupportInitialize)(this.dsTurnosImprimir1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.ReportSource = this.CR_TurnoPorFrase1;
            // 
            // dsTurnosImprimir1
            // 
            this.dsTurnosImprimir1.DataSetName = "DsTurnosImprimir";
            this.dsTurnosImprimir1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepTurnosPorFrase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepTurnosPorFrase";
            this.Text = "Búsqueda de Turnos";
            this.Load += new System.EventHandler(this.FormReportTurnosPorFraseLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsTurnosImprimir1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_TurnoPorFrase CR_TurnoPorFrase1;
        private Administración.DsTurnosImprimir dsTurnosImprimir1;
    }
}
