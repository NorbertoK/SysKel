namespace Administración
{
    partial class FormProviDireccionesSinZona
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crProviDireccionesSinZona1 = new Administración.CR_Provi_DireccionesSinZona();
            this.dsProviDireccionesSinZona1 = new Administración.WS.DsProviDireccionesSinZona();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsProviDireccionesSinZona1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(693, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Visible = false;
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(612, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 368);
            this.panel1.Size = new System.Drawing.Size(783, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(693, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, -1);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.crProviDireccionesSinZona1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(783, 379);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dsProviDireccionesSinZona1
            // 
            this.dsProviDireccionesSinZona1.DataSetName = "DsProviDireccionesSinZona";
            this.dsProviDireccionesSinZona1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormProviDireccionesSinZona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(782, 416);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FormProviDireccionesSinZona";
            this.Text = "Direcciones sin Zona";
            this.Load += new System.EventHandler(this.FormProviDireccionesSinZonaLoad);
            this.Controls.SetChildIndex(this.crystalReportViewer1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsProviDireccionesSinZona1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CR_Provi_DireccionesSinZona crProviDireccionesSinZona1;
        private WS.DsProviDireccionesSinZona dsProviDireccionesSinZona1;
    }
}
