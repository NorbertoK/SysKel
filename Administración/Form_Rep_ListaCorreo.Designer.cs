namespace Administración
{
    partial class FormRepListaCorreo
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crListaCorreo = new Administración.CR_ListaCorreo();
            this.dsListaCorreo = new Administración.WS.DsListaCorreo();
            ((System.ComponentModel.ISupportInitialize)(this.dsListaCorreo)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.DisplayStatusBar = true;
            this.crystalReportViewer1.DisplayToolbar = true;
            this.crystalReportViewer1.ReportSource = this.crListaCorreo;
            // 
            // dsListaCorreo1
            // 
            this.dsListaCorreo.DataSetName = "DsListaCorreo";
            this.dsListaCorreo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepListaCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepListaCorreo";
            this.Text = "Lista para Correo";
            this.Load += new System.EventHandler(this.FormRepListaCorreoLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsListaCorreo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_ListaCorreo crListaCorreo;
        private WS.DsListaCorreo dsListaCorreo;
    }
}
