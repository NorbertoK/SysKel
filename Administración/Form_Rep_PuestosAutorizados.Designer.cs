namespace Administración
{
    partial class FormRepPuestosAutorizados
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crPuestosAutorizados1 = new Administración.CR_PuestosAutorizados();
            this.dsRepPuestosAutorizados1 = new Administración.WS.DsRepPuestosAutorizados();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepPuestosAutorizados1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.ReportSource = this.crPuestosAutorizados1;
            // 
            // dsRepPuestosAutorizados1
            // 
            this.dsRepPuestosAutorizados1.DataSetName = "DsRep_PuestosAutorizados";
            this.dsRepPuestosAutorizados1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepPuestosAutorizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepPuestosAutorizados";
            this.Text = "Puestos Autorizados";
            this.Load += new System.EventHandler(this.FormRepPuestosAutorizadosLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsRepPuestosAutorizados1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_PuestosAutorizados crPuestosAutorizados1;
        private WS.DsRepPuestosAutorizados dsRepPuestosAutorizados1;
    }
}
