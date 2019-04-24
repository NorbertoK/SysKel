namespace Administración
{
    partial class FormRepEstPrestLocalidadCodigo
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crEstPrestLocalidadCodigo1 = new Administración.CR_EstPrest_LocalidadCodigo();
            this.dsRepPrestCodigoLocalidad1 = new Administración.WS.DsRepPrestCodigoLocalidad();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepPrestCodigoLocalidad1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.ReportSource = this.crEstPrestLocalidadCodigo1;
            // 
            // dsRepPrestCodigoLocalidad1
            // 
            this.dsRepPrestCodigoLocalidad1.DataSetName = "DsRep_PrestCodigoLocalidad";
            this.dsRepPrestCodigoLocalidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepEstPrestLocalidadCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepEstPrestLocalidadCodigo";
            this.Text = "Estadística de Prestaciones: por Localidad y Código";
            this.Load += new System.EventHandler(this.FormRepEstPrestLocalidadCodigoLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsRepPrestCodigoLocalidad1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_EstPrest_LocalidadCodigo crEstPrestLocalidadCodigo1;
        private WS.DsRepPrestCodigoLocalidad dsRepPrestCodigoLocalidad1;
    }
}
