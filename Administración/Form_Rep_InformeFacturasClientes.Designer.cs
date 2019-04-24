namespace Administración
{
    partial class FormRepInformeFacturasClientes
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crInformeFacturasDeClientes1 = new Administración.CR_InformeFacturasDeClientes();
            this.dsRepFacturasDeClientes1 = new Administración.WS.DsRepFacturasDeClientes();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepFacturasDeClientes1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.DisplayStatusBar = true;
            this.crystalReportViewer1.DisplayToolbar = true;
            this.crystalReportViewer1.ReportSource = this.crInformeFacturasDeClientes1;
            // 
            // dsRepFacturasDeClientes1
            // 
            this.dsRepFacturasDeClientes1.DataSetName = "DsRepFacturasDeClientes";
            this.dsRepFacturasDeClientes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepInformeFacturasClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepInformeFacturasClientes";
            this.Text = "Informe de Facturas de Clientes";
            this.Load += new System.EventHandler(this.FormRepInformeFacturasClientesLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsRepFacturasDeClientes1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_InformeFacturasDeClientes crInformeFacturasDeClientes1;
        private WS.DsRepFacturasDeClientes dsRepFacturasDeClientes1;
    }
}
