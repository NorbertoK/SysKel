namespace Administración
{
    partial class FormReporteCupones
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crComprobantes1 = new Administración.CR_Comprobantes();
            this.dsReportComprobantes1 = new Administración.WS.DsReportComprobantes();
            this.crComprobantesConResumen1 = new Administración.CR_ComprobantesConResumen();
            this.crComprobantesConResumen31 = new Administración.CR_ComprobantesConResumen3();
            this.crComprobantes31 = new Administración.CR_Comprobantes3();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportComprobantes1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(763, 15);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Visible = false;
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(682, 15);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 485);
            this.panel1.Size = new System.Drawing.Size(853, 49);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(763, 15);
            this.buttonCancelar.Text = "Salir";
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.CachedPageNumberPerDoc = 10;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(853, 494);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dsReportComprobantes1
            // 
            this.dsReportComprobantes1.DataSetName = "DsReportComprobantes";
            this.dsReportComprobantes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormReporteCupones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(852, 533);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FormReporteCupones";
            this.Text = "Cupones";
            this.Load += new System.EventHandler(this.FormReporteCuponesLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.crystalReportViewer1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsReportComprobantes1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private WS.DsReportComprobantes dsReportComprobantes1;
        private CR_Comprobantes crComprobantes1;
        private CR_ComprobantesConResumen crComprobantesConResumen1;
        private CR_ComprobantesConResumen3 crComprobantesConResumen31;
        private CR_Comprobantes3 crComprobantes31;


    }
}
