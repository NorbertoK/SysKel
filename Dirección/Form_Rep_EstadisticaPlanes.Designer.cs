namespace Dirección
{
    partial class FormRepEstadisticaPlanes
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
            this.cr_EstadisticaPlanes1 = new Dirección.CR_EstadisticaPlanes();
            this.dsEstadisticaPlanes1 = new Dirección.WS.DsEstadisticaPlanes();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstadisticaPlanes1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.crystalReportViewer1.ReportSource = this.cr_EstadisticaPlanes1;
            // 
            // dsEstadisticaPlanes1
            // 
            this.dsEstadisticaPlanes1.DataSetName = "DsEstadisticaPlanes";
            this.dsEstadisticaPlanes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepEstadisticaPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepEstadisticaPlanes";
            this.Text = "Constitución de los Planes";
            this.Load += new System.EventHandler(this.FormRepEstadisticaPlanesLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsEstadisticaPlanes1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_EstadisticaPlanes cr_EstadisticaPlanes1;
        private Dirección.WS.DsEstadisticaPlanes dsEstadisticaPlanes1;
    }
}
