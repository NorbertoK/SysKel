namespace Administración
{
    partial class FormRepDeudoresExcel
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crDeudoresExcel1 = new Administración.CR_DeudoresExcel();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.ReportSource = this.crDeudoresExcel1;
            // 
            // FormRepDeudoresExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepDeudoresExcel";
            this.Text = "Deudores (para exportar a Excel como Sólo Datos)";
            this.Load += new System.EventHandler(this.FormRepDeudoresExcelLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private CR_DeudoresExcel crDeudoresExcel1;
    }
}
