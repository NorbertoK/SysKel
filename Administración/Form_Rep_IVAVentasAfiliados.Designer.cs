namespace Administración
{
    partial class FormRepIVAVentasAfiliados
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dsRepIVAVentasAfiliados = new Administración.WS.DsRepIVAVentasAfiliados();
            this.crIVAVentas = new Administración.CR_IVAVentas();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepIVAVentasAfiliados)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.DisplayStatusBar = true;
            this.crystalReportViewer1.DisplayToolbar = true;
            this.crystalReportViewer1.ReportSource = this.crIVAVentas;
            // 
            // dsRepIVAVentasAfiliados1
            // 
            this.dsRepIVAVentasAfiliados.DataSetName = "DsRep_IVAVentasAfiliados";
            this.dsRepIVAVentasAfiliados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepIVAVentasAfiliados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepIVAVentasAfiliados";
            this.Text = "IVA Ventas";
            this.Load += new System.EventHandler(this.FormRepIVAVentasAfiliadosLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsRepIVAVentasAfiliados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WS.DsRepIVAVentasAfiliados dsRepIVAVentasAfiliados;
        private CR_IVAVentas crIVAVentas;

    }
}
