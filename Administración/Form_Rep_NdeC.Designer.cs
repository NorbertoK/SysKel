namespace Administración
{
    partial class FormRepNdeC
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dsRepNdeC = new Administración.WS.DsRepNdeC();
            this.crListaNdeC = new Administración.CR_ListaNdeC();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepNdeC)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.ReportSource = this.crListaNdeC;
            this.crystalReportViewer1.Load += new System.EventHandler(this.CrystalReportViewer1Load);
            // 
            // dsRepNdeC
            // 
            this.dsRepNdeC.DataSetName = "DsRepNdeC";
            this.dsRepNdeC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepNdeC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepNdeC";
            this.Text = "Notas de Crédito";
            ((System.ComponentModel.ISupportInitialize)(this.dsRepNdeC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_ListaNdeC crListaNdeC;
        private WS.DsRepNdeC dsRepNdeC;
    }
}
