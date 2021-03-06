﻿namespace Pollux.UserInterface
{
    partial class UCSouhaitsDe
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
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.groupBoxSouhaitsDe = new System.Windows.Forms.GroupBox();
            this.listViewSouhaits = new System.Windows.Forms.ListView();
            this.budget = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surfaceHabitable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surfaceJardin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.villes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label11 = new System.Windows.Forms.Label();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.groupBoxSouhaitsDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnnuler.Location = new System.Drawing.Point(201, 209);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 4;
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
            this.comboBoxClients.Size = new System.Drawing.Size(233, 21);
            this.comboBoxClients.TabIndex = 1;
            this.comboBoxClients.SelectedIndexChanged += new System.EventHandler(this.comboBoxClients_SelectedIndexChanged);
            // 
            // groupBoxSouhaitsDe
            // 
            this.groupBoxSouhaitsDe.Controls.Add(this.listViewSouhaits);
            this.groupBoxSouhaitsDe.Controls.Add(this.buttonAnnuler);
            this.groupBoxSouhaitsDe.Controls.Add(this.comboBoxClients);
            this.groupBoxSouhaitsDe.Controls.Add(this.label11);
            this.groupBoxSouhaitsDe.Controls.Add(this.buttonRechercher);
            this.groupBoxSouhaitsDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSouhaitsDe.Location = new System.Drawing.Point(0, 30);
            this.groupBoxSouhaitsDe.Name = "groupBoxSouhaitsDe";
            this.groupBoxSouhaitsDe.Size = new System.Drawing.Size(518, 276);
            this.groupBoxSouhaitsDe.TabIndex = 9;
            this.groupBoxSouhaitsDe.TabStop = false;
            this.groupBoxSouhaitsDe.Text = "Afficher les souhaits de...";
            // 
            // listViewSouhaits
            // 
            this.listViewSouhaits.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.budget,
            this.surfaceHabitable,
            this.surfaceJardin,
            this.villes});
            this.listViewSouhaits.FullRowSelect = true;
            this.listViewSouhaits.Location = new System.Drawing.Point(15, 55);
            this.listViewSouhaits.MultiSelect = false;
            this.listViewSouhaits.Name = "listViewSouhaits";
            this.listViewSouhaits.Size = new System.Drawing.Size(461, 147);
            this.listViewSouhaits.TabIndex = 2;
            this.listViewSouhaits.UseCompatibleStateImageBehavior = false;
            this.listViewSouhaits.View = System.Windows.Forms.View.Details;
            this.listViewSouhaits.SelectedIndexChanged += new System.EventHandler(this.listViewSouhaits_SelectedIndexChanged);
            // 
            // budget
            // 
            this.budget.Text = "Budget Maximal";
            this.budget.Width = 102;
            // 
            // surfaceHabitable
            // 
            this.surfaceHabitable.Text = "Surf. hab. min.";
            this.surfaceHabitable.Width = 82;
            // 
            // surfaceJardin
            // 
            this.surfaceJardin.Text = "Surf. jard. min.";
            this.surfaceJardin.Width = 79;
            // 
            // villes
            // 
            this.villes.Text = "Villes";
            this.villes.Width = 187;
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
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(282, 209);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(194, 23);
            this.buttonRechercher.TabIndex = 3;
            this.buttonRechercher.Text = "Rechercher les biens correspondants";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // UCSouhaitsDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxSouhaitsDe);
            this.Name = "UCSouhaitsDe";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Size = new System.Drawing.Size(518, 306);
            this.groupBoxSouhaitsDe.ResumeLayout(false);
            this.groupBoxSouhaitsDe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.GroupBox groupBoxSouhaitsDe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.ListView listViewSouhaits;
        private System.Windows.Forms.ColumnHeader budget;
        private System.Windows.Forms.ColumnHeader surfaceHabitable;
        private System.Windows.Forms.ColumnHeader surfaceJardin;
        private System.Windows.Forms.ColumnHeader villes;

    }
}
