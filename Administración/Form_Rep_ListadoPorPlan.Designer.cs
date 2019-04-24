namespace Administración
{
    partial class FormRepListadoPorPlan
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crListadoPorPlan = new Administración.CR_ListadoPorPlan();
            this.dsRepListadoPorPlan = new Administración.WS.DsRepListadoPorPlan();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepListadoPorPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.ReportSource = this.crListadoPorPlan;
            // 
            // dsRepListadoPorPlan1
            // 
            this.dsRepListadoPorPlan.DataSetName = "DsRepListadoPorPlan";
            this.dsRepListadoPorPlan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepListadoPorPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepListadoPorPlan";
            this.Text = "Listado por Plan";
            this.Load += new System.EventHandler(this.FormRepListadoPorPlanLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsRepListadoPorPlan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_ListadoPorPlan crListadoPorPlan;
        private WS.DsRepListadoPorPlan dsRepListadoPorPlan;
    }
}
