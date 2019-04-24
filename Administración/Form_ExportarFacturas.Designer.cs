namespace Administración
{
    partial class FormExportarFacturas
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
            this.dsExportarImpresionFacturas = new Administración.WS.DsExportarImpresionFacturas();
            this.ultraLabelAviso = new Infragistics.Win.Misc.UltraLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsExportarImpresionFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Visible = false;
            // 
            // buttonAplicar
            // 
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 82);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(176, 16);
            this.buttonCancelar.Text = "Cerrar";
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            this.buttonCancelar.Visible = false;
            // 
            // dsExportarImpresionFacturas
            // 
            this.dsExportarImpresionFacturas.DataSetName = "DsExportarImpresionFacturas";
            this.dsExportarImpresionFacturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraLabelAviso
            // 
            this.ultraLabelAviso.AutoSize = true;
            this.ultraLabelAviso.Location = new System.Drawing.Point(24, 22);
            this.ultraLabelAviso.Name = "ultraLabelAviso";
            this.ultraLabelAviso.Size = new System.Drawing.Size(0, 0);
            this.ultraLabelAviso.TabIndex = 1;
            // 
            // FormExportarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(265, 130);
            this.Controls.Add(this.ultraLabelAviso);
            this.Name = "FormExportarFacturas";
            this.Text = "Exportar Facturas";
            this.Shown += new System.EventHandler(this.FormExportarFacturas_Shown);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraLabelAviso, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsExportarImpresionFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WS.DsExportarImpresionFacturas dsExportarImpresionFacturas;
        private Infragistics.Win.Misc.UltraLabel ultraLabelAviso;
    }
}
