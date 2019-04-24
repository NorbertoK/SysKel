namespace Administración
{
    partial class FormRepFacturadoPorEntidad
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crFacturadoPorEntidad1 = new Administración.CR_FacturadoPorEntidad();
            this.dsRepListadoFacturadoPorEntidad1 = new Administración.WS.DsRepListadoFacturadoPorEntidad();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepListadoFacturadoPorEntidad1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.DisplayStatusBar = true;
            this.crystalReportViewer1.DisplayToolbar = true;
            this.crystalReportViewer1.ReportSource = this.crFacturadoPorEntidad1;
            // 
            // dsRepListadoFacturadoPorEntidad1
            // 
            this.dsRepListadoFacturadoPorEntidad1.DataSetName = "DsRep_ListadoFacturadoPorEntidad";
            this.dsRepListadoFacturadoPorEntidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepFacturadoPorEntidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepFacturadoPorEntidad";
            this.Text = "Listado de los Facturado por Entidad de Cobranza";
            this.Load += new System.EventHandler(this.FormRepFacturadoPorEntidadLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsRepListadoFacturadoPorEntidad1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_FacturadoPorEntidad crFacturadoPorEntidad1;
        private WS.DsRepListadoFacturadoPorEntidad dsRepListadoFacturadoPorEntidad1;
    }
}
