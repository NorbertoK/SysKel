namespace Administración
{
    partial class FormTextoNuevaClave
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTextoNuevaClave));
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            this.ultraFormattedLinkLabel1 = new Infragistics.Win.FormattedLinkLabel.UltraFormattedLinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ultraFormattedLinkLabel1
            // 
            this.ultraFormattedLinkLabel1.ActiveLinkAppearance = appearance1;
            this.ultraFormattedLinkLabel1.HotTrackLinkAppearance = appearance2;
            this.ultraFormattedLinkLabel1.LinkAppearance = appearance3;
            this.ultraFormattedLinkLabel1.Location = new System.Drawing.Point(119, 59);
            this.ultraFormattedLinkLabel1.Name = "ultraFormattedLinkLabel1";
            this.ultraFormattedLinkLabel1.Padding = new System.Drawing.Size(0, 0);
            this.ultraFormattedLinkLabel1.Size = new System.Drawing.Size(505, 283);
            this.ultraFormattedLinkLabel1.TabIndex = 0;
            this.ultraFormattedLinkLabel1.TabStop = true;
            this.ultraFormattedLinkLabel1.Value = resources.GetString("ultraFormattedLinkLabel1.Value");
            this.ultraFormattedLinkLabel1.VisitedLinkAppearance = appearance4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Me he notificado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // Form_TextoNuevaClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 442);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ultraFormattedLinkLabel1);
            this.Name = "FormTextoNuevaClave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "La Clave o Contraseña";
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.FormattedLinkLabel.UltraFormattedLinkLabel ultraFormattedLinkLabel1;
        private System.Windows.Forms.Button button1;
    }
}