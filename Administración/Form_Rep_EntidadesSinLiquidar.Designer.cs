namespace Administración
{
    partial class FormRepEntidadesSinLiquidar
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
            this.CR_EntidadesSinLiquidar1 = new Administración.CR_EntidadesSinLiquidar();
            this.dsEntidadesSinLiquidar1 = new Administración.WS.DsEntidadesSinLiquidar();
            ((System.ComponentModel.ISupportInitialize)(this.dsEntidadesSinLiquidar1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.crystalReportViewer1.ReportSource = this.CR_EntidadesSinLiquidar1;
            // 
            // dsEntidadesSinLiquidar1
            // 
            this.dsEntidadesSinLiquidar1.DataSetName = "DsEntidadesSinLiquidar";
            this.dsEntidadesSinLiquidar1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepEntidadesSinLiquidar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepEntidadesSinLiquidar";
            this.Text = "Entidades sin Liquidar";
            this.Load += new System.EventHandler(this.FormRepEntidadesSinLiquidarLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsEntidadesSinLiquidar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_EntidadesSinLiquidar CR_EntidadesSinLiquidar1;
        private Administración.WS.DsEntidadesSinLiquidar dsEntidadesSinLiquidar1;
    }
}
