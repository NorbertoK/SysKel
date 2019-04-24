namespace Administración
{
    partial class FormRepInformeVentas
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crInformeVentas = new Administración.CR_InformeVentas();
            this.dsInformeVentas = new Administración.WS.DsInformeVentas();
            ((System.ComponentModel.ISupportInitialize)(this.dsInformeVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.DisplayStatusBar = true;
            this.crystalReportViewer1.DisplayToolbar = true;
            this.crystalReportViewer1.ReportSource = this.crInformeVentas;
            // 
            // ds_InformeVentas1
            // 
            this.dsInformeVentas.DataSetName = "DsInformeVentas";
            this.dsInformeVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepInformeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepInformeVentas";
            this.Text = "Informe de Ventas";
            this.Load += new System.EventHandler(this.FormRepInformeVentasLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsInformeVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_InformeVentas crInformeVentas;
        private WS.DsInformeVentas dsInformeVentas;
    }
}
