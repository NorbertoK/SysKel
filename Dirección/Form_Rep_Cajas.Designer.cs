namespace Dirección
{
    partial class FormRepCajas
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crCajas1 = new Dirección.CR_Cajas();
            this.dsCajas1 = new Dirección.WS.DsCajas();
            ((System.ComponentModel.ISupportInitialize)(this.dsCajas1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.ReportSource = this.crCajas1;
            // 
            // dsCajas1
            // 
            this.dsCajas1.DataSetName = "DsCajas";
            this.dsCajas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepCajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepCajas";
            this.Text = "Cajas";
            this.Load += new System.EventHandler(this.FormRepCajasLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsCajas1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_Cajas crCajas1;
        private WS.DsCajas dsCajas1;
    }
}
