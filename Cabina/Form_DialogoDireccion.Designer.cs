namespace Cabina
{
    partial class FormDialogoDireccion
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
            Infragistics.Win.ValueListItem valueListItem1 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem2 = new Infragistics.Win.ValueListItem();
            this.ultraOptionSetDirecciones = new Infragistics.Win.UltraWinEditors.UltraOptionSet();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraOptionSetDirecciones)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(211, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(130, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 86);
            this.panel1.Size = new System.Drawing.Size(301, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(49, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            this.buttonCancelar.Visible = false;
            // 
            // ultraOptionSetDirecciones
            // 
            valueListItem1.DataValue = "Origen";
            valueListItem1.DisplayText = "La dirección obtenida es el origen del trayecto.";
            valueListItem2.DataValue = "Destino";
            valueListItem2.DisplayText = "La dirección obtenida es el destino del trayecto.";
            this.ultraOptionSetDirecciones.Items.AddRange(new Infragistics.Win.ValueListItem[] {
            valueListItem1,
            valueListItem2});
            this.ultraOptionSetDirecciones.ItemSpacingVertical = 10;
            this.ultraOptionSetDirecciones.Location = new System.Drawing.Point(18, 12);
            this.ultraOptionSetDirecciones.Name = "ultraOptionSetDirecciones";
            this.ultraOptionSetDirecciones.Size = new System.Drawing.Size(268, 55);
            this.ultraOptionSetDirecciones.TabIndex = 1;
            this.ultraOptionSetDirecciones.ValueChanged += new System.EventHandler(this.UltraOptionSet1ValueChanged);
            // 
            // FormDialogoDireccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(300, 134);
            this.Controls.Add(this.ultraOptionSetDirecciones);
            this.Name = "FormDialogoDireccion";
            this.Text = "Dirección";
            this.Controls.SetChildIndex(this.ultraOptionSetDirecciones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraOptionSetDirecciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinEditors.UltraOptionSet ultraOptionSetDirecciones;
    }
}
