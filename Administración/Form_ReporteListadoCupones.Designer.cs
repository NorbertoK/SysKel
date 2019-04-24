namespace Administración
{
    partial class FormReporteListadoCupones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.components = new System.ComponentModel.Container();
            this.comprobantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReportComprobantes1 = new Administración.WS.DsReportComprobantes();
            this.dsTiposDeCobranza1 = new Administración.WS.DsTiposDeCobranza();
            this.dsEntidadesDeCobranza1 = new Administración.WS.DsEntidadesDeCobranza();
            this.dsZonas1 = new Administración.WS.DsZonas();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crListadoComprobantes1 = new Administración.CR_ListadoComprobantes();
            this.dsCobradores = new Administración.WS.DsEmpleadosLista();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprobantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportComprobantes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeCobranza1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEntidadesDeCobranza1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZonas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCobradores)).BeginInit();
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
            // comprobantesBindingSource
            // 
            this.comprobantesBindingSource.DataMember = "Comprobantes";
            this.comprobantesBindingSource.DataSource = this.dsReportComprobantes1;
            // 
            // dsReportComprobantes1
            // 
            this.dsReportComprobantes1.DataSetName = "DsReportComprobantes";
            this.dsReportComprobantes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsTiposDeCobranza1
            // 
            this.dsTiposDeCobranza1.DataSetName = "DsTiposDeCobranza";
            this.dsTiposDeCobranza1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsEntidadesDeCobranza1
            // 
            this.dsEntidadesDeCobranza1.DataSetName = "DsEntidadesDeCobranza";
            this.dsEntidadesDeCobranza1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.crystalReportViewer1.ReportSource = this.crListadoComprobantes1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(850, 513);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dsCobradores
            // 
            this.dsCobradores.DataSetName = "DsEmpleadosLista";
            this.dsCobradores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormReporteListadoCupones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(849, 551);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FormReporteListadoCupones";
            this.Text = "Listado de Comprobantes";
            this.Load += new System.EventHandler(this.FormReporteListadoCuponesLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.crystalReportViewer1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comprobantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportComprobantes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeCobranza1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEntidadesDeCobranza1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZonas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCobradores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource comprobantesBindingSource;
        private WS.DsReportComprobantes dsReportComprobantes1;
        private WS.DsTiposDeCobranza dsTiposDeCobranza1;
        private WS.DsEntidadesDeCobranza dsEntidadesDeCobranza1;
        private WS.DsZonas dsZonas1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CR_ListadoComprobantes crListadoComprobantes1;
        private WS.DsEmpleadosLista dsCobradores;
    }
}
