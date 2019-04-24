namespace Dirección
{
    partial class FormRepEstadoDeLaCobranza
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crEstadoDeLaCobranza1 = new Dirección.CR_EstadoDeLaCobranza();
            this.dsEstadoDeLaCobranza1 = new Dirección.WS.DsEstadoDeLaCobranza();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstadoDeLaCobranza1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.DisplayStatusBar = true;
            this.crystalReportViewer1.DisplayToolbar = true;
            this.crystalReportViewer1.Location = new System.Drawing.Point(-4, 0);
            this.crystalReportViewer1.ReportSource = this.crEstadoDeLaCobranza1;
            // 
            // dsEstadoDeLaCobranza1
            // 
            this.dsEstadoDeLaCobranza1.DataSetName = "DsEstadoDeLaCobranza";
            this.dsEstadoDeLaCobranza1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepEstadoDeLaCobranza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepEstadoDeLaCobranza";
            this.Text = "Estado de la Cobranza";
            this.Load += new System.EventHandler(this.FormRepEstadoDeLaCobranzaLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsEstadoDeLaCobranza1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_EstadoDeLaCobranza crEstadoDeLaCobranza1;
        private WS.DsEstadoDeLaCobranza dsEstadoDeLaCobranza1;
    }
}
