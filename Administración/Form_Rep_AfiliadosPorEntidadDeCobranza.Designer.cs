namespace Administración
{
    partial class FormRepAfiliadosPorEntidadDeCobranza
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crAfiliadosPorEntidadDeCobranza1 = new Administración.CR_AfiliadosPorEntidadDeCobranza();
            this.dsRepAfiliadosPorEntidadDeCobranza1 = new Administración.WS.DsRepAfiliadosPorEntidadDeCobranza();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepAfiliadosPorEntidadDeCobranza1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.ReportSource = this.crAfiliadosPorEntidadDeCobranza1;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dsRepAfiliadosPorEntidadDeCobranza1
            // 
            this.dsRepAfiliadosPorEntidadDeCobranza1.DataSetName = "DsRepAfiliadosPorEntidadDeCobranza";
            this.dsRepAfiliadosPorEntidadDeCobranza1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepAfiliadosPorEntidadDeCobranza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepAfiliadosPorEntidadDeCobranza";
            this.Text = "Afiliados por Entidad de Cobranza";
            this.Load += new System.EventHandler(this.FormRepAfiliadosPorEntidadDeCobranzaLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsRepAfiliadosPorEntidadDeCobranza1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_AfiliadosPorEntidadDeCobranza crAfiliadosPorEntidadDeCobranza1;
        private WS.DsRepAfiliadosPorEntidadDeCobranza dsRepAfiliadosPorEntidadDeCobranza1;
    }
}
