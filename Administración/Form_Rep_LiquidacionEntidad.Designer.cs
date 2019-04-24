namespace Administración
{
    partial class FormRepLiquidacionEntidad
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crLiquidacionEntidad1 = new Administración.CR_LiquidacionEntidad();
            this.dsReportLiquidacionEntidad1 = new Administración.WS.DsReportLiquidacionEntidad();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportLiquidacionEntidad1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Location = new System.Drawing.Point(-2, 0);
            this.crystalReportViewer1.ReportSource = this.crLiquidacionEntidad1;
            // 
            // dsReportLiquidacionEntidad1
            // 
            this.dsReportLiquidacionEntidad1.DataSetName = "DsReportLiquidacionEntidad";
            this.dsReportLiquidacionEntidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepLiquidacionEntidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepLiquidacionEntidad";
            this.Text = "Liquidación de Entidad de Cobranza";
            this.Load += new System.EventHandler(this.FormRepLiquidacionEntidadLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsReportLiquidacionEntidad1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_LiquidacionEntidad crLiquidacionEntidad1;
        private WS.DsReportLiquidacionEntidad dsReportLiquidacionEntidad1;
    }
}
