namespace Administración
{
    partial class FormBajasAutomaticas
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            this.ultraDateTimeEditorPeriodo = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ultraLabelPeriodo = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabelMensaje = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabelMeses = new Infragistics.Win.Misc.UltraLabel();
            this.dsParametros1 = new Administración.WS.DsParametros();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParametros1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Enabled = true;
            this.buttonAceptar.Location = new System.Drawing.Point(253, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Enabled = true;
            this.buttonAplicar.Location = new System.Drawing.Point(253, 16);
            this.buttonAplicar.Text = "Salir";
            this.toolTip1.SetToolTip(this.buttonAplicar, "Cerrar esta ventana.");
            this.buttonAplicar.Visible = false;
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 140);
            this.panel1.Size = new System.Drawing.Size(343, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(172, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // ultraDateTimeEditorPeriodo
            // 
            this.ultraDateTimeEditorPeriodo.Location = new System.Drawing.Point(143, 12);
            this.ultraDateTimeEditorPeriodo.MaskInput = "{LOC}mm/yyyy";
            this.ultraDateTimeEditorPeriodo.Name = "ultraDateTimeEditorPeriodo";
            this.ultraDateTimeEditorPeriodo.Size = new System.Drawing.Size(77, 21);
            this.ultraDateTimeEditorPeriodo.TabIndex = 1;
            // 
            // ultraLabelPeriodo
            // 
            appearance1.TextHAlignAsString = "Left";
            this.ultraLabelPeriodo.Appearance = appearance1;
            this.ultraLabelPeriodo.Location = new System.Drawing.Point(12, 16);
            this.ultraLabelPeriodo.Name = "ultraLabelPeriodo";
            this.ultraLabelPeriodo.Size = new System.Drawing.Size(125, 14);
            this.ultraLabelPeriodo.TabIndex = 2;
            this.ultraLabelPeriodo.Text = "Último Período Cobrado";
            // 
            // ultraLabelMensaje
            // 
            appearance3.TextHAlignAsString = "Center";
            this.ultraLabelMensaje.Appearance = appearance3;
            this.ultraLabelMensaje.Location = new System.Drawing.Point(32, 112);
            this.ultraLabelMensaje.Name = "ultraLabelMensaje";
            this.ultraLabelMensaje.Size = new System.Drawing.Size(279, 22);
            this.ultraLabelMensaje.TabIndex = 12;
            // 
            // ultraLabelMeses
            // 
            this.ultraLabelMeses.Location = new System.Drawing.Point(20, 39);
            this.ultraLabelMeses.Name = "ultraLabelMeses";
            this.ultraLabelMeses.Size = new System.Drawing.Size(308, 52);
            this.ultraLabelMeses.TabIndex = 13;
            // 
            // dsParametros1
            // 
            this.dsParametros1.DataSetName = "DsParametros";
            this.dsParametros1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormBajasAutomaticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(342, 188);
            this.Controls.Add(this.ultraLabelMeses);
            this.Controls.Add(this.ultraDateTimeEditorPeriodo);
            this.Controls.Add(this.ultraLabelMensaje);
            this.Controls.Add(this.ultraLabelPeriodo);
            this.MinimumSize = new System.Drawing.Size(350, 147);
            this.Name = "FormBajasAutomaticas";
            this.Text = "Bajas Automáticas";
            this.Load += new System.EventHandler(this.FormBajasAutomaticasLoad);
            this.Controls.SetChildIndex(this.ultraLabelPeriodo, 0);
            this.Controls.SetChildIndex(this.ultraLabelMensaje, 0);
            this.Controls.SetChildIndex(this.ultraDateTimeEditorPeriodo, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraLabelMeses, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParametros1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditorPeriodo;
        private Infragistics.Win.Misc.UltraLabel ultraLabelPeriodo;
        private Infragistics.Win.Misc.UltraLabel ultraLabelMensaje;
        private Infragistics.Win.Misc.UltraLabel ultraLabelMeses;
        private Administración.WS.DsParametros dsParametros1;
    }
}
