namespace Administración
{
    partial class FormReporteListadoCuponesClientes
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dsZonas1 = new Administración.WS.DsZonas();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crListadoComprobantesClientes1 = new Administración.CR_ListadoComprobantesClientes();
            this.dsCobradores = new Administración.WS.DsEmpleadosLista();
            this.dsComprobantesDeFacturas1 = new Administración.WS.DsComprobantesDeFacturas();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsZonas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCobradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComprobantesDeFacturas1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(760, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Visible = false;
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(679, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 503);
            this.panel1.Size = new System.Drawing.Size(850, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(760, 16);
            this.buttonCancelar.Text = "Salir";
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // dsZonas1
            // 
            this.dsZonas1.DataSetName = "DsZonas";
            this.dsZonas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.crListadoComprobantesClientes1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(850, 513);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dsCobradores
            // 
            this.dsCobradores.DataSetName = "DsEmpleadosLista";
            this.dsCobradores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsComprobantesDeFacturas1
            // 
            this.dsComprobantesDeFacturas1.DataSetName = "DsComprobantesDeFacturas";
            this.dsComprobantesDeFacturas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormReporteListadoCuponesClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(849, 551);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FormReporteListadoCuponesClientes";
            this.Text = "Listado de Comprobantes de Clientes";
            this.Load += new System.EventHandler(this.FormReporteListadoCuponesLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.crystalReportViewer1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsZonas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCobradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComprobantesDeFacturas1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WS.DsZonas dsZonas1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private WS.DsEmpleadosLista dsCobradores;
        private CR_ListadoComprobantesClientes crListadoComprobantesClientes1;
        private WS.DsComprobantesDeFacturas dsComprobantesDeFacturas1;
    }
}
