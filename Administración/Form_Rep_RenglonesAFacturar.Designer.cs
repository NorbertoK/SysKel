namespace Administración
{
    partial class FormRepRenglonesAFacturar
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dsRepRenglonesAFacturar1 = new Administración.WS.DsRepRenglonesAFacturar();
            this.crRenglonesAFacturar1 = new Administración.CR_RenglonesAFacturar();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepRenglonesAFacturar1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.DisplayStatusBar = true;
            this.crystalReportViewer1.DisplayToolbar = true;
            this.crystalReportViewer1.ReportSource = this.crRenglonesAFacturar1;
            // 
            // dsRepRenglonesAFacturar1
            // 
            this.dsRepRenglonesAFacturar1.DataSetName = "DsRepRenglonesAFacturar";
            this.dsRepRenglonesAFacturar1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepRenglonesAFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepRenglonesAFacturar";
            this.Text = "Renglones a Facturar";
            this.Load += new System.EventHandler(this.FormRepRenglonesAFacturarLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsRepRenglonesAFacturar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WS.DsRepRenglonesAFacturar dsRepRenglonesAFacturar1;
        private CR_RenglonesAFacturar crRenglonesAFacturar1;
    }
}
