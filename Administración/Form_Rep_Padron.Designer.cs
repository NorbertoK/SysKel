namespace Administración
{
    partial class FormRepPadron
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crPadron1 = new Administración.CR_Padron();
            this.dsRepPadron1 = new Administración.WS.DsRepPadron();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepPadron1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.DisplayStatusBar = true;
            this.crystalReportViewer1.DisplayToolbar = true;
            this.crystalReportViewer1.ReportSource = this.crPadron1;
            // 
            // dsRepPadron1
            // 
            this.dsRepPadron1.DataSetName = "DsRepPadron";
            this.dsRepPadron1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepPadron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepPadron";
            this.Text = "Padrón";
            this.Load += new System.EventHandler(this.FormRepPadronLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsRepPadron1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_Padron crPadron1;
        private WS.DsRepPadron dsRepPadron1;
    }
}
