namespace Cabina
{
    partial class FormRepCaja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CR_Caja1 = new Cabina.CR_Caja();
            this.ds_Caja1 = new Cabina.WS.DsCaja();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Caja1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.ReportSource = this.CR_Caja1;
            // 
            // ds_Caja1
            // 
            this.ds_Caja1.DataSetName = "DsCaja";
            this.ds_Caja1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepCaja";
            this.Text = "Caja";
            this.Load += new System.EventHandler(this.FormRepCajaLoad);
            ((System.ComponentModel.ISupportInitialize)(this.ds_Caja1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_Caja CR_Caja1;
        private Cabina.WS.DsCaja ds_Caja1;
    }
}
