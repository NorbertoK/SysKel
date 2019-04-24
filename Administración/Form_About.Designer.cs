namespace Administración
{
    partial class FormAbout
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelVersion = new System.Windows.Forms.Label();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.ultraFormattedLinkLabelWeb = new Infragistics.Win.FormattedLinkLabel.UltraFormattedLinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLicencia = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Administración.Properties.Resources.logo;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(264, 76);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(64, 13);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "labelVersion";
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(337, 108);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCerrar.TabIndex = 3;
            this.buttonCerrar.Text = "Aceptar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.ButtonCerrarClick);
            // 
            // ultraFormattedLinkLabelWeb
            // 
            this.ultraFormattedLinkLabelWeb.Location = new System.Drawing.Point(264, 11);
            this.ultraFormattedLinkLabelWeb.Name = "ultraFormattedLinkLabelWeb";
            this.ultraFormattedLinkLabelWeb.Size = new System.Drawing.Size(148, 50);
            this.ultraFormattedLinkLabelWeb.TabIndex = 5;
            this.ultraFormattedLinkLabelWeb.TabStop = true;
            this.ultraFormattedLinkLabelWeb.TreatValueAs = Infragistics.Win.FormattedLinkLabel.TreatValueAs.Auto;
            this.ultraFormattedLinkLabelWeb.Value = "<span style=\"font-family:Microsoft Sans Serif;\">Contacto:<br/>Dr. Norberto Kelijm" +
                "an<br/><span style=\"color:Navy;\">kelijman@syskel.com</span></span><br/> ";
            this.ultraFormattedLinkLabelWeb.WrapText = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Módulo Administración";
            // 
            // labelLicencia
            // 
            this.labelLicencia.AutoSize = true;
            this.labelLicencia.Location = new System.Drawing.Point(264, 89);
            this.labelLicencia.Name = "labelLicencia";
            this.labelLicencia.Size = new System.Drawing.Size(69, 13);
            this.labelLicencia.TabIndex = 7;
            this.labelLicencia.Text = "labelLicencia";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(424, 143);
            this.ControlBox = false;
            this.Controls.Add(this.labelLicencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ultraFormattedLinkLabelWeb);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.Text = "Acerca de SysKel";
            this.Load += new System.EventHandler(this.FormAboutLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Button buttonCerrar;
        private Infragistics.Win.FormattedLinkLabel.UltraFormattedLinkLabel ultraFormattedLinkLabelWeb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLicencia;
        private System.Windows.Forms.Timer timer1;
    }
}