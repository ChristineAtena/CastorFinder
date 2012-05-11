namespace Pollux.UserInterface
{
    partial class UCBiensDe
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
            this.groupBoxBiensDe = new System.Windows.Forms.GroupBox();
            this.listViewBiens = new System.Windows.Forms.ListView();
            this.budget = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surfaceHabitable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surfaceJardin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.villes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonAfficher = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.groupBoxBiensDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBiensDe
            // 
            this.groupBoxBiensDe.Controls.Add(this.listViewBiens);
            this.groupBoxBiensDe.Controls.Add(this.buttonAnnuler);
            this.groupBoxBiensDe.Controls.Add(this.comboBoxClients);
            this.groupBoxBiensDe.Controls.Add(this.label11);
            this.groupBoxBiensDe.Controls.Add(this.buttonAfficher);
            this.groupBoxBiensDe.Controls.Add(this.buttonAjouter);
            this.groupBoxBiensDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBiensDe.Location = new System.Drawing.Point(0, 30);
            this.groupBoxBiensDe.Name = "groupBoxBiensDe";
            this.groupBoxBiensDe.Size = new System.Drawing.Size(518, 276);
            this.groupBoxBiensDe.TabIndex = 10;
            this.groupBoxBiensDe.TabStop = false;
            this.groupBoxBiensDe.Text = "Afficher les biens de...";
            // 
            // listViewBiens
            // 
            this.listViewBiens.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.budget,
            this.surfaceHabitable,
            this.surfaceJardin,
            this.villes,
            this.date});
            this.listViewBiens.FullRowSelect = true;
            this.listViewBiens.Location = new System.Drawing.Point(15, 55);
            this.listViewBiens.Name = "listViewBiens";
            this.listViewBiens.Size = new System.Drawing.Size(461, 147);
            this.listViewBiens.TabIndex = 10;
            this.listViewBiens.UseCompatibleStateImageBehavior = false;
            this.listViewBiens.View = System.Windows.Forms.View.Details;
            // 
            // budget
            // 
            this.budget.Text = "Prix";
            this.budget.Width = 72;
            // 
            // surfaceHabitable
            // 
            this.surfaceHabitable.Text = "Surface habitable";
            this.surfaceHabitable.Width = 95;
            // 
            // surfaceJardin
            // 
            this.surfaceJardin.Text = "Surface de jardin";
            this.surfaceJardin.Width = 92;
            // 
            // villes
            // 
            this.villes.Text = "Ville";
            this.villes.Width = 115;
            // 
            // date
            // 
            this.date.Text = "Date dispo";
            this.date.Width = 82;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnnuler.Location = new System.Drawing.Point(174, 209);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 9;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(59, 20);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(301, 21);
            this.comboBoxClients.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Client :";
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
            this.buttonAjouter.Location = new System.Drawing.Point(255, 209);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(221, 23);
            this.buttonAjouter.TabIndex = 4;
            this.buttonAjouter.Text = "Rechercher les souhaits correspondants";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // UCBiensDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxBiensDe);
            this.Name = "UCBiensDe";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Size = new System.Drawing.Size(518, 306);
            this.groupBoxBiensDe.ResumeLayout(false);
            this.groupBoxBiensDe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBiensDe;
        private System.Windows.Forms.ListView listViewBiens;
        private System.Windows.Forms.ColumnHeader budget;
        private System.Windows.Forms.ColumnHeader surfaceHabitable;
        private System.Windows.Forms.ColumnHeader surfaceJardin;
        private System.Windows.Forms.ColumnHeader villes;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonAfficher;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.ColumnHeader date;
    }
}
