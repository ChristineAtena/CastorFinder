namespace Pollux.UserInterface
{
    partial class APropos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APropos));
            this.panelCastor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.texte = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // panelCastor
            // 
            this.panelCastor.BackgroundImage = global::Pollux.Properties.Resources.castor;
            this.panelCastor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelCastor.Location = new System.Drawing.Point(12, 12);
            this.panelCastor.Name = "panelCastor";
            this.panelCastor.Size = new System.Drawing.Size(277, 185);
            this.panelCastor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Castor Finder";
            // 
            // texte
            // 
            this.texte.AutoSize = true;
            this.texte.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.texte.LinkColor = System.Drawing.Color.Blue;
            this.texte.Location = new System.Drawing.Point(295, 47);
            this.texte.Name = "texte";
            this.texte.Size = new System.Drawing.Size(209, 156);
            this.texte.TabIndex = 2;
            this.texte.Text = "3.7.2c\r\n\r\nCastor Finder est conçu par l\'équipe Castor\r\n\r\nComposée de :\r\nJulien Be" +
    "llue\r\nOlivier Defossez\r\nChristine Delpech\r\nMarie-Noëlle Ripoll de Marti\r\n\r\nIUT I" +
    "nformatique Bordeaux 1,\r\n2011-2012";
            this.texte.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.texte_LinkClicked);
            // 
            // APropos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 203);
            this.Controls.Add(this.texte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelCastor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "APropos";
            this.Text = "À propos de Castor Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCastor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel texte;
    }
}