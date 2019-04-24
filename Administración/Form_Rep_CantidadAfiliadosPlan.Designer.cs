namespace Administración
{
    partial class FormRepCantidadAfiliadosPlan
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crCantidadAfiliadosPlan1 = new Administración.CR_CantidadAfiliadosPlan();
            this.dsRepCantidadAfiliadosPlan1 = new Administración.DsRepCantidadAfiliadosPlan();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepCantidadAfiliadosPlan1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.ReportSource = this.crCantidadAfiliadosPlan1;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(844, 602);
            // 
            // dsRepCantidadAfiliadosPlan1
            // 
            this.dsRepCantidadAfiliadosPlan1.DataSetName = "DsRepCantidadAfiliadosPlan";
            this.dsRepCantidadAfiliadosPlan1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepCantidadAfiliadosPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(931, 633);
            this.Name = "FormRepCantidadAfiliadosPlan";
            this.Text = "Cantidad de Afiliados por Plan";
            this.Load += new System.EventHandler(this.FormRepCantidadAfiliadosPlanLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsRepCantidadAfiliadosPlan1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_CantidadAfiliadosPlan crCantidadAfiliadosPlan1;
        private DsRepCantidadAfiliadosPlan dsRepCantidadAfiliadosPlan1;
    }
}
