namespace Pollux.UserInterface
{
    partial class UCAjouterAgent
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxAjoutAgent = new System.Windows.Forms.GroupBox();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonCreer = new System.Windows.Forms.Button();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBoxAjoutAgent.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAjoutAgent
            // 
            this.groupBoxAjoutAgent.Controls.Add(this.buttonAnnuler);
            this.groupBoxAjoutAgent.Controls.Add(this.buttonCreer);
            this.groupBoxAjoutAgent.Controls.Add(this.textBoxPrenom);
            this.groupBoxAjoutAgent.Controls.Add(this.label19);
            this.groupBoxAjoutAgent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAjoutAgent.Location = new System.Drawing.Point(0, 30);
            this.groupBoxAjoutAgent.Name = "groupBoxAjoutAgent";
            this.groupBoxAjoutAgent.Size = new System.Drawing.Size(496, 249);
            this.groupBoxAjoutAgent.TabIndex = 15;
            this.groupBoxAjoutAgent.TabStop = false;
            this.groupBoxAjoutAgent.Text = "Ajouter un agent";
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnnuler.Location = new System.Drawing.Point(169, 85);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 9;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonCreer
            // 
            this.buttonCreer.Enabled = false;
            this.buttonCreer.Location = new System.Drawing.Point(293, 85);
            this.buttonCreer.Name = "buttonCreer";
            this.buttonCreer.Size = new System.Drawing.Size(75, 23);
            this.buttonCreer.TabIndex = 8;
            this.buttonCreer.Text = "Créer";
            this.buttonCreer.UseVisualStyleBackColor = true;
            this.buttonCreer.Click += new System.EventHandler(this.buttonCreer_Click);
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(125, 59);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(288, 20);
            this.textBoxPrenom.TabIndex = 1;
            this.textBoxPrenom.TextChanged += new System.EventHandler(this.textBoxPrenom_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(36, 62);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Prénom";
            // 
            // UCAjouterAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxAjoutAgent);
            this.Name = "UCAjouterAgent";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Size = new System.Drawing.Size(496, 279);
            this.groupBoxAjoutAgent.ResumeLayout(false);
            this.groupBoxAjoutAgent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAjoutAgent;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonCreer;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label label19;
    }
}
