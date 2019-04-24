namespace Administración
{
    partial class FormReporteRemesa
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
            this.remesaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReportRemesa1 = new Administración.WS.DsReportRemesa();
            this.comprobantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crRemesa1 = new Administración.CR_Remesa();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remesaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportRemesa1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(839, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Visible = false;
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(758, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 584);
            this.panel1.Size = new System.Drawing.Size(929, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(839, 16);
            this.buttonCancelar.Text = "Salir";
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // remesaBindingSource
            // 
            this.remesaBindingSource.DataMember = "Remesa";
            this.remesaBindingSource.DataSource = this.dsReportRemesa1;
            // 
            // dsReportRemesa1
            // 
            this.dsReportRemesa1.DataSetName = "DsReportRemesa";
            this.dsReportRemesa1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comprobantesBindingSource
            // 
            this.comprobantesBindingSource.DataMember = "Comprobantes";
            this.comprobantesBindingSource.DataSource = this.dsReportRemesa1;
            // 
            // valoresBindingSource
            // 
            this.valoresBindingSource.DataMember = "Valores";
            this.valoresBindingSource.DataSource = this.dsReportRemesa1;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(-3, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.crRemesa1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(929, 594);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FormReporteRemesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FormReporteRemesa";
            this.Text = "Remesa";
            this.Load += new System.EventHandler(this.FormReporteRemesaLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.crystalReportViewer1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.remesaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportRemesa1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource remesaBindingSource;
        private WS.DsReportRemesa dsReportRemesa1;
        private System.Windows.Forms.BindingSource comprobantesBindingSource;
        private System.Windows.Forms.BindingSource valoresBindingSource;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CR_Remesa crRemesa1;
    }
}
