namespace Administración
{
    partial class FormRepEstPrestMedicamentosUtilizados
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crEstPrestMedicamentosUtilizados1 = new Administración.CR_EstPrest_MedicamentosUtilizados();
            this.dsRepPrestMedicamentosUtilizados1 = new Administración.WS.DsRepPrestMedicamentosUtilizados();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepPrestMedicamentosUtilizados1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.ReportSource = this.crEstPrestMedicamentosUtilizados1;
            // 
            // dsRepPrestMedicamentosUtilizados1
            // 
            this.dsRepPrestMedicamentosUtilizados1.DataSetName = "DsRepPrestMedicamentosUtilizados";
            this.dsRepPrestMedicamentosUtilizados1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepEstPrestMedicamentosUtilizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepEstPrestMedicamentosUtilizados";
            this.Text = "Medicamentos Utilizados";
            this.Load += new System.EventHandler(this.FormRepEstPrestLocalidadMotivoCodigoLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsRepPrestMedicamentosUtilizados1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_EstPrest_MedicamentosUtilizados crEstPrestMedicamentosUtilizados1;
        private WS.DsRepPrestMedicamentosUtilizados dsRepPrestMedicamentosUtilizados1;
    }
}
