namespace Administración
{
    partial class FormProviRepSinPlan
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crProviSinPlan1 = new Administración.CR_Provi_SinPlan();
            this.dsProviSinPlan1 = new Administración.WS.DsProviSinPlan();
            ((System.ComponentModel.ISupportInitialize)(this.dsProviSinPlan1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.ReportSource = this.crProviSinPlan1;
            // 
            // dsProviSinPlan1
            // 
            this.dsProviSinPlan1.DataSetName = "DsProviSinPlan";
            this.dsProviSinPlan1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormProviRepSinPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormProviRepSinPlan";
            this.Text = "Afiliados sin Plan";
            this.Load += new System.EventHandler(this.FormProviRepSinPlanLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsProviSinPlan1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_Provi_SinPlan crProviSinPlan1;
        private WS.DsProviSinPlan dsProviSinPlan1;
    }
}
