namespace Dirección
{
    partial class FormRepCaja
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crCaja1 = new Dirección.CR_Caja();
            this.dsCaja1 = new Dirección.WS.DsCaja();
            ((System.ComponentModel.ISupportInitialize)(this.dsCaja1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.ReportSource = this.crCaja1;
            // 
            // dsCaja1
            // 
            this.dsCaja1.DataSetName = "DsCaja";
            this.dsCaja1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepCaja";
            this.Text = "Caja";
            this.Load += new System.EventHandler(this.FormRepCajaLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsCaja1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_Caja crCaja1;
        private WS.DsCaja dsCaja1;
    }
}
