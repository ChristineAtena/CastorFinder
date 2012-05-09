namespace Pollux.UserInterface
{
    partial class UCClientsDe
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
            this.groupBoxClientsDe = new System.Windows.Forms.GroupBox();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.comboBoxAgents = new System.Windows.Forms.ComboBox();
            this.listBoxClients = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonAfficher = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.groupBoxClientsDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxClientsDe
            // 
            this.groupBoxClientsDe.Controls.Add(this.buttonAnnuler);
            this.groupBoxClientsDe.Controls.Add(this.comboBoxAgents);
            this.groupBoxClientsDe.Controls.Add(this.listBoxClients);
            this.groupBoxClientsDe.Controls.Add(this.label11);
            this.groupBoxClientsDe.Controls.Add(this.buttonAfficher);
            this.groupBoxClientsDe.Controls.Add(this.buttonAjouter);
            this.groupBoxClientsDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxClientsDe.Location = new System.Drawing.Point(0, 30);
            this.groupBoxClientsDe.Name = "groupBoxClientsDe";
            this.groupBoxClientsDe.Size = new System.Drawing.Size(508, 277);
            this.groupBoxClientsDe.TabIndex = 8;
            this.groupBoxClientsDe.TabStop = false;
            this.groupBoxClientsDe.Text = "Afficher les clients de...";
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnnuler.Location = new System.Drawing.Point(288, 209);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 9;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // comboBoxAgents
            // 
            this.comboBoxAgents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAgents.FormattingEnabled = true;
            this.comboBoxAgents.Location = new System.Drawing.Point(59, 20);
            this.comboBoxAgents.Name = "comboBoxAgents";
            this.comboBoxAgents.Size = new System.Drawing.Size(301, 21);
            this.comboBoxAgents.TabIndex = 9;
            // 
            // listBoxClients
            // 
            this.listBoxClients.FormattingEnabled = true;
            this.listBoxClients.Location = new System.Drawing.Point(15, 55);
            this.listBoxClients.Name = "listBoxClients";
            this.listBoxClients.Size = new System.Drawing.Size(461, 147);
            this.listBoxClients.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Agent :";
            // 
            // buttonAfficher
            // 
            this.buttonAfficher.Location = new System.Drawing.Point(401, 18);
            this.buttonAfficher.Name = "buttonAfficher";
            this.buttonAfficher.Size = new System.Drawing.Size(75, 23);
            this.buttonAfficher.TabIndex = 4;
            this.buttonAfficher.Text = "Afficher";
            this.buttonAfficher.UseVisualStyleBackColor = true;
            this.buttonAfficher.Click += new System.EventHandler(this.buttonAfficher_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(369, 209);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(107, 23);
            this.buttonAjouter.TabIndex = 4;
            this.buttonAjouter.Text = "Ajouter une visite";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // UCClientsDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxClientsDe);
            this.Name = "UCClientsDe";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Size = new System.Drawing.Size(508, 307);
            this.groupBoxClientsDe.ResumeLayout(false);
            this.groupBoxClientsDe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxClientsDe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.ListBox listBoxClients;
        private System.Windows.Forms.Button buttonAfficher;
        private System.Windows.Forms.ComboBox comboBoxAgents;
        private System.Windows.Forms.Button buttonAnnuler;
    }
}
