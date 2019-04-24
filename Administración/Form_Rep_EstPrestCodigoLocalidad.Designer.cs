namespace Administración
{
    partial class FormRepEstPrestCodigoLocalidad
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dsRepPrestCodigoLocalidad1 = new Administración.WS.DsRepPrestCodigoLocalidad();
            this.crEstPrestCodigoLocalidad1 = new Administración.CR_EstPrest_CodigoLocalidad();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepPrestCodigoLocalidad1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.ReportSource = this.crEstPrestCodigoLocalidad1;
            // 
            // dsRepPrestCodigoLocalidad1
            // 
            this.dsRepPrestCodigoLocalidad1.DataSetName = "DsRep_PrestCodigoLocalidad";
            this.dsRepPrestCodigoLocalidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepEstPrestCodigoLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepEstPrestCodigoLocalidad";
            this.Text = "Estadística de Prestaciones: Por código y Localidad";
            this.Load += new System.EventHandler(this.FormRepEstPrestLocalidadCodigoLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsRepPrestCodigoLocalidad1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WS.DsRepPrestCodigoLocalidad dsRepPrestCodigoLocalidad1;
        private CR_EstPrest_CodigoLocalidad crEstPrestCodigoLocalidad1;
    }
}
