namespace Administración
{
    partial class FormRepCambioDeCobrador
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dsRepCambioDeCobrador1 = new Administración.WS.DsRepCambioDeCobrador();
            this.crCambioCobrador1 = new Administración.CR_CambioCobrador();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepCambioDeCobrador1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.ReportSource = this.crCambioCobrador1;
            // 
            // dsRepCambioDeCobrador1
            // 
            this.dsRepCambioDeCobrador1.DataSetName = "DsRep_CambioDeCobrador";
            this.dsRepCambioDeCobrador1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepCambioDeCobrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepCambioDeCobrador";
            this.Text = "Cambio de Cobrador";
            this.Load += new System.EventHandler(this.FormRepCambioDeCobradorLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsRepCambioDeCobrador1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WS.DsRepCambioDeCobrador dsRepCambioDeCobrador1;
        private CR_CambioCobrador crCambioCobrador1;
    }
}
