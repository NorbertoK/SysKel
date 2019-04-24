namespace Administración
{
    partial class FormRepDatosPrestaciones
    {
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crDatosPrestaciones1 = new Administración.CR_DatosPrestaciones();
            this.dsDatosPrestaciones1 = new Administración.WS.DsDatosPrestaciones();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosPrestaciones1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.ReportSource = this.crDatosPrestaciones1;
            // 
            // dsDatosPrestaciones1
            // 
            this.dsDatosPrestaciones1.DataSetName = "DsDatosPrestaciones";
            this.dsDatosPrestaciones1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepDatosPrestaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepDatosPrestaciones";
            this.Text = "Datos de las Prestaciones";
            this.Load += new System.EventHandler(this.FomRepDatosPrestacionesLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosPrestaciones1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_DatosPrestaciones crDatosPrestaciones1;
        private WS.DsDatosPrestaciones dsDatosPrestaciones1;
    }
}
