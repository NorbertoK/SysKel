namespace Dirección
{
    partial class FormRepEstPrestLocalidadMotivoCodigo
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crEstPrestLocalidadMotivoCodigo1 = new Dirección.CR_EstPrest_LocalidadMotivoCodigo();
            this.dsRepPrestLocalidadMotivoCodigo1 = new Dirección.WS.DsRepPrestLocalidadMotivoCodigo();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepPrestLocalidadMotivoCodigo1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.ReportSource = this.crEstPrestLocalidadMotivoCodigo1;
            // 
            // dsRepPrestLocalidadMotivoCodigo1
            // 
            this.dsRepPrestLocalidadMotivoCodigo1.DataSetName = "DsRepPrestLocalidadMotivoCodigo";
            this.dsRepPrestLocalidadMotivoCodigo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepEstPrestLocalidadMotivoCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepEstPrestLocalidadMotivoCodigo";
            this.Text = "Estadística de Localidad, Motivo de Llamado y Código";
            this.Load += new System.EventHandler(this.FormRepEstPrestLocalidadMotivoCodigoLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsRepPrestLocalidadMotivoCodigo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_EstPrest_LocalidadMotivoCodigo crEstPrestLocalidadMotivoCodigo1;
        private Dirección.WS.DsRepPrestLocalidadMotivoCodigo dsRepPrestLocalidadMotivoCodigo1;
    }
}
