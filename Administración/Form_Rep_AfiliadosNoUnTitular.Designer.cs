namespace Administración
{
    partial class FormRepAfiliadosNoUnTitular
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crAfiliadosNoUnTitular1 = new Administración.CR_AfiliadosNoUnTitular();
            this.dsRepNoUnTitular1 = new Administración.WS.DsRepNoUnTitular();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepNoUnTitular1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.ReportSource = this.crAfiliadosNoUnTitular1;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dsRepNoUnTitular1
            // 
            this.dsRepNoUnTitular1.DataSetName = "DsRepNoUnTitular";
            this.dsRepNoUnTitular1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepAfiliadosNoUnTitular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepAfiliadosNoUnTitular";
            this.Text = "Afiliados No Un Titular";
            this.Load += new System.EventHandler(this.FormRepAfiliadosNoUnTitularLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsRepNoUnTitular1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_AfiliadosNoUnTitular crAfiliadosNoUnTitular1;
        private WS.DsRepNoUnTitular dsRepNoUnTitular1;
    }
}
