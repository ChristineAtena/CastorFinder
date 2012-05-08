﻿namespace Pollux.UserInterface
{
    partial class UCAjouterSouhait
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
            this.groupBoxAjoutSouhaits = new System.Windows.Forms.GroupBox();
            this.listBoxVilles = new System.Windows.Forms.ListBox();
            this.comboBoxAcheteur = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonAddVilles = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAjoutSouhaitJardin = new System.Windows.Forms.TextBox();
            this.textBoxAjoutSouhaitSurfHab = new System.Windows.Forms.TextBox();
            this.textBoxAjoutSouhaitsBudget = new System.Windows.Forms.TextBox();
            this.trackBarAjoutSouhaitJardin = new System.Windows.Forms.TrackBar();
            this.trackBarAjoutSouhaitSurfHab = new System.Windows.Forms.TrackBar();
            this.trackBarAjoutSouhaitsBudget = new System.Windows.Forms.TrackBar();
            this.checkBoxVilles = new System.Windows.Forms.CheckBox();
            this.checkBoxJardin = new System.Windows.Forms.CheckBox();
            this.checkBoxSurfHab = new System.Windows.Forms.CheckBox();
            this.checkBoxBudgetMax = new System.Windows.Forms.CheckBox();
            this.groupBoxAjoutSouhaits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAjoutSouhaitJardin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAjoutSouhaitSurfHab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAjoutSouhaitsBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAjoutSouhaits
            // 
            this.groupBoxAjoutSouhaits.Controls.Add(this.listBoxVilles);
            this.groupBoxAjoutSouhaits.Controls.Add(this.comboBoxAcheteur);
            this.groupBoxAjoutSouhaits.Controls.Add(this.label12);
            this.groupBoxAjoutSouhaits.Controls.Add(this.buttonAddVilles);
            this.groupBoxAjoutSouhaits.Controls.Add(this.buttonAnnuler);
            this.groupBoxAjoutSouhaits.Controls.Add(this.buttonAjouter);
            this.groupBoxAjoutSouhaits.Controls.Add(this.label3);
            this.groupBoxAjoutSouhaits.Controls.Add(this.label2);
            this.groupBoxAjoutSouhaits.Controls.Add(this.label1);
            this.groupBoxAjoutSouhaits.Controls.Add(this.textBoxAjoutSouhaitJardin);
            this.groupBoxAjoutSouhaits.Controls.Add(this.textBoxAjoutSouhaitSurfHab);
            this.groupBoxAjoutSouhaits.Controls.Add(this.textBoxAjoutSouhaitsBudget);
            this.groupBoxAjoutSouhaits.Controls.Add(this.trackBarAjoutSouhaitJardin);
            this.groupBoxAjoutSouhaits.Controls.Add(this.trackBarAjoutSouhaitSurfHab);
            this.groupBoxAjoutSouhaits.Controls.Add(this.trackBarAjoutSouhaitsBudget);
            this.groupBoxAjoutSouhaits.Controls.Add(this.checkBoxVilles);
            this.groupBoxAjoutSouhaits.Controls.Add(this.checkBoxJardin);
            this.groupBoxAjoutSouhaits.Controls.Add(this.checkBoxSurfHab);
            this.groupBoxAjoutSouhaits.Controls.Add(this.checkBoxBudgetMax);
            this.groupBoxAjoutSouhaits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAjoutSouhaits.Location = new System.Drawing.Point(0, 30);
            this.groupBoxAjoutSouhaits.Name = "groupBoxAjoutSouhaits";
            this.groupBoxAjoutSouhaits.Size = new System.Drawing.Size(533, 276);
            this.groupBoxAjoutSouhaits.TabIndex = 2;
            this.groupBoxAjoutSouhaits.TabStop = false;
            this.groupBoxAjoutSouhaits.Text = "Ajouter un souhait";
            // 
            // listBoxVilles
            // 
            this.listBoxVilles.FormattingEnabled = true;
            this.listBoxVilles.Location = new System.Drawing.Point(155, 158);
            this.listBoxVilles.Name = "listBoxVilles";
            this.listBoxVilles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxVilles.Size = new System.Drawing.Size(200, 69);
            this.listBoxVilles.TabIndex = 10;
            this.listBoxVilles.SelectedIndexChanged += new System.EventHandler(this.listBoxVilles_SelectedIndexChanged);
            // 
            // comboBoxAcheteur
            // 
            this.comboBoxAcheteur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAcheteur.FormattingEnabled = true;
            this.comboBoxAcheteur.Location = new System.Drawing.Point(155, 19);
            this.comboBoxAcheteur.Name = "comboBoxAcheteur";
            this.comboBoxAcheteur.Size = new System.Drawing.Size(271, 21);
            this.comboBoxAcheteur.TabIndex = 9;
            this.comboBoxAcheteur.SelectedIndexChanged += new System.EventHandler(this.comboBoxAcheteur_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Client :";
            // 
            // buttonAddVilles
            // 
            this.buttonAddVilles.Location = new System.Drawing.Point(51, 204);
            this.buttonAddVilles.Name = "buttonAddVilles";
            this.buttonAddVilles.Size = new System.Drawing.Size(93, 23);
            this.buttonAddVilles.TabIndex = 4;
            this.buttonAddVilles.Text = "Ajouter une ville";
            this.buttonAddVilles.UseVisualStyleBackColor = true;
            this.buttonAddVilles.Click += new System.EventHandler(this.buttonAddVilles_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnnuler.Location = new System.Drawing.Point(375, 175);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 4;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(375, 204);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(75, 23);
            this.buttonAjouter.TabIndex = 4;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "m²";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "m²";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "€";
            // 
            // textBoxAjoutSouhaitJardin
            // 
            this.textBoxAjoutSouhaitJardin.Location = new System.Drawing.Point(314, 122);
            this.textBoxAjoutSouhaitJardin.Name = "textBoxAjoutSouhaitJardin";
            this.textBoxAjoutSouhaitJardin.Size = new System.Drawing.Size(112, 20);
            this.textBoxAjoutSouhaitJardin.TabIndex = 2;
            this.textBoxAjoutSouhaitJardin.TextChanged += new System.EventHandler(this.textBoxAjoutSouhaitJardin_TextChanged);
            // 
            // textBoxAjoutSouhaitSurfHab
            // 
            this.textBoxAjoutSouhaitSurfHab.Location = new System.Drawing.Point(314, 86);
            this.textBoxAjoutSouhaitSurfHab.Name = "textBoxAjoutSouhaitSurfHab";
            this.textBoxAjoutSouhaitSurfHab.Size = new System.Drawing.Size(112, 20);
            this.textBoxAjoutSouhaitSurfHab.TabIndex = 2;
            this.textBoxAjoutSouhaitSurfHab.TextChanged += new System.EventHandler(this.textBoxAjoutSouhaitSurfHab_TextChanged);
            // 
            // textBoxAjoutSouhaitsBudget
            // 
            this.textBoxAjoutSouhaitsBudget.Location = new System.Drawing.Point(314, 50);
            this.textBoxAjoutSouhaitsBudget.Name = "textBoxAjoutSouhaitsBudget";
            this.textBoxAjoutSouhaitsBudget.Size = new System.Drawing.Size(112, 20);
            this.textBoxAjoutSouhaitsBudget.TabIndex = 2;
            this.textBoxAjoutSouhaitsBudget.TextChanged += new System.EventHandler(this.textBoxAjoutSouhaitsBudget_TextChanged);
            // 
            // trackBarAjoutSouhaitJardin
            // 
            this.trackBarAjoutSouhaitJardin.Location = new System.Drawing.Point(155, 122);
            this.trackBarAjoutSouhaitJardin.Maximum = 10000;
            this.trackBarAjoutSouhaitJardin.Name = "trackBarAjoutSouhaitJardin";
            this.trackBarAjoutSouhaitJardin.Size = new System.Drawing.Size(153, 45);
            this.trackBarAjoutSouhaitJardin.TabIndex = 1;
            this.trackBarAjoutSouhaitJardin.TickFrequency = 0;
            this.trackBarAjoutSouhaitJardin.Scroll += new System.EventHandler(this.trackBarAjoutSouhaitJardin_Scroll);
            // 
            // trackBarAjoutSouhaitSurfHab
            // 
            this.trackBarAjoutSouhaitSurfHab.Location = new System.Drawing.Point(155, 84);
            this.trackBarAjoutSouhaitSurfHab.Maximum = 300;
            this.trackBarAjoutSouhaitSurfHab.Name = "trackBarAjoutSouhaitSurfHab";
            this.trackBarAjoutSouhaitSurfHab.Size = new System.Drawing.Size(153, 45);
            this.trackBarAjoutSouhaitSurfHab.TabIndex = 1;
            this.trackBarAjoutSouhaitSurfHab.TickFrequency = 0;
            this.trackBarAjoutSouhaitSurfHab.Scroll += new System.EventHandler(this.trackBarAjoutSouhaitSurfHab_Scroll);
            // 
            // trackBarAjoutSouhaitsBudget
            // 
            this.trackBarAjoutSouhaitsBudget.Location = new System.Drawing.Point(155, 50);
            this.trackBarAjoutSouhaitsBudget.Maximum = 1000000;
            this.trackBarAjoutSouhaitsBudget.Name = "trackBarAjoutSouhaitsBudget";
            this.trackBarAjoutSouhaitsBudget.Size = new System.Drawing.Size(153, 45);
            this.trackBarAjoutSouhaitsBudget.TabIndex = 1;
            this.trackBarAjoutSouhaitsBudget.TickFrequency = 0;
            this.trackBarAjoutSouhaitsBudget.Scroll += new System.EventHandler(this.trackBarAjoutSouhaitsBudget_Scroll);
            // 
            // checkBoxVilles
            // 
            this.checkBoxVilles.AutoSize = true;
            this.checkBoxVilles.Location = new System.Drawing.Point(13, 158);
            this.checkBoxVilles.Name = "checkBoxVilles";
            this.checkBoxVilles.Size = new System.Drawing.Size(56, 17);
            this.checkBoxVilles.TabIndex = 0;
            this.checkBoxVilles.Text = "Villes :";
            this.checkBoxVilles.UseVisualStyleBackColor = true;
            this.checkBoxVilles.CheckedChanged += new System.EventHandler(this.checkBoxVilles_CheckedChanged);
            // 
            // checkBoxJardin
            // 
            this.checkBoxJardin.AutoSize = true;
            this.checkBoxJardin.Location = new System.Drawing.Point(13, 122);
            this.checkBoxJardin.Name = "checkBoxJardin";
            this.checkBoxJardin.Size = new System.Drawing.Size(131, 17);
            this.checkBoxJardin.TabIndex = 0;
            this.checkBoxJardin.Text = "Surface de jardin min :";
            this.checkBoxJardin.UseVisualStyleBackColor = true;
            this.checkBoxJardin.CheckedChanged += new System.EventHandler(this.checkBoxJardin_CheckedChanged);
            // 
            // checkBoxSurfHab
            // 
            this.checkBoxSurfHab.AutoSize = true;
            this.checkBoxSurfHab.Location = new System.Drawing.Point(13, 86);
            this.checkBoxSurfHab.Name = "checkBoxSurfHab";
            this.checkBoxSurfHab.Size = new System.Drawing.Size(134, 17);
            this.checkBoxSurfHab.TabIndex = 0;
            this.checkBoxSurfHab.Text = "Surface habitable min :";
            this.checkBoxSurfHab.UseVisualStyleBackColor = true;
            this.checkBoxSurfHab.CheckedChanged += new System.EventHandler(this.checkBoxSurfHab_CheckedChanged);
            // 
            // checkBoxBudgetMax
            // 
            this.checkBoxBudgetMax.AutoSize = true;
            this.checkBoxBudgetMax.Location = new System.Drawing.Point(13, 50);
            this.checkBoxBudgetMax.Name = "checkBoxBudgetMax";
            this.checkBoxBudgetMax.Size = new System.Drawing.Size(88, 17);
            this.checkBoxBudgetMax.TabIndex = 0;
            this.checkBoxBudgetMax.Text = "Budget max :";
            this.checkBoxBudgetMax.UseVisualStyleBackColor = true;
            this.checkBoxBudgetMax.CheckedChanged += new System.EventHandler(this.checkBoxBudgetMax_CheckedChanged);
            // 
            // UCAjouterSouhait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxAjoutSouhaits);
            this.Name = "UCAjouterSouhait";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Size = new System.Drawing.Size(533, 306);
            this.groupBoxAjoutSouhaits.ResumeLayout(false);
            this.groupBoxAjoutSouhaits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAjoutSouhaitJardin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAjoutSouhaitSurfHab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAjoutSouhaitsBudget)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAjoutSouhaits;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAjoutSouhaitJardin;
        private System.Windows.Forms.TextBox textBoxAjoutSouhaitSurfHab;
        private System.Windows.Forms.TextBox textBoxAjoutSouhaitsBudget;
        private System.Windows.Forms.TrackBar trackBarAjoutSouhaitJardin;
        private System.Windows.Forms.TrackBar trackBarAjoutSouhaitSurfHab;
        private System.Windows.Forms.TrackBar trackBarAjoutSouhaitsBudget;
        private System.Windows.Forms.CheckBox checkBoxVilles;
        private System.Windows.Forms.CheckBox checkBoxJardin;
        private System.Windows.Forms.CheckBox checkBoxSurfHab;
        private System.Windows.Forms.CheckBox checkBoxBudgetMax;
        private System.Windows.Forms.ComboBox comboBoxAcheteur;
        private System.Windows.Forms.ListBox listBoxVilles;
        private System.Windows.Forms.Button buttonAddVilles;
    }
}
