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
            this.numericUpDownSurfHab = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSurfJard = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBudget = new System.Windows.Forms.NumericUpDown();
            this.listBoxVilles = new System.Windows.Forms.ListBox();
            this.comboBoxAgent = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxAcheteur = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonAddVilles = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarSurfJard = new System.Windows.Forms.TrackBar();
            this.trackBarSurfHab = new System.Windows.Forms.TrackBar();
            this.trackBarBudget = new System.Windows.Forms.TrackBar();
            this.checkBoxVilles = new System.Windows.Forms.CheckBox();
            this.checkBoxJardin = new System.Windows.Forms.CheckBox();
            this.checkBoxSurfHab = new System.Windows.Forms.CheckBox();
            this.checkBoxBudgetMax = new System.Windows.Forms.CheckBox();
            this.groupBoxAjoutSouhaits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSurfHab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSurfJard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBudget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSurfJard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSurfHab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAjoutSouhaits
            // 
            this.groupBoxAjoutSouhaits.Controls.Add(this.numericUpDownSurfHab);
            this.groupBoxAjoutSouhaits.Controls.Add(this.numericUpDownSurfJard);
            this.groupBoxAjoutSouhaits.Controls.Add(this.numericUpDownBudget);
            this.groupBoxAjoutSouhaits.Controls.Add(this.listBoxVilles);
            this.groupBoxAjoutSouhaits.Controls.Add(this.comboBoxAgent);
            this.groupBoxAjoutSouhaits.Controls.Add(this.label4);
            this.groupBoxAjoutSouhaits.Controls.Add(this.comboBoxAcheteur);
            this.groupBoxAjoutSouhaits.Controls.Add(this.label12);
            this.groupBoxAjoutSouhaits.Controls.Add(this.buttonAddVilles);
            this.groupBoxAjoutSouhaits.Controls.Add(this.buttonAnnuler);
            this.groupBoxAjoutSouhaits.Controls.Add(this.buttonAjouter);
            this.groupBoxAjoutSouhaits.Controls.Add(this.label3);
            this.groupBoxAjoutSouhaits.Controls.Add(this.label2);
            this.groupBoxAjoutSouhaits.Controls.Add(this.label1);
            this.groupBoxAjoutSouhaits.Controls.Add(this.trackBarSurfJard);
            this.groupBoxAjoutSouhaits.Controls.Add(this.trackBarSurfHab);
            this.groupBoxAjoutSouhaits.Controls.Add(this.trackBarBudget);
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
            // numericUpDownSurfHab
            // 
            this.numericUpDownSurfHab.Location = new System.Drawing.Point(314, 85);
            this.numericUpDownSurfHab.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownSurfHab.Name = "numericUpDownSurfHab";
            this.numericUpDownSurfHab.Size = new System.Drawing.Size(107, 20);
            this.numericUpDownSurfHab.TabIndex = 8;
            this.numericUpDownSurfHab.ValueChanged += new System.EventHandler(this.numericUpDownSurfHab_ValueChanged);
            this.numericUpDownSurfHab.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDownSurfHab_KeyUp);
            // 
            // numericUpDownSurfJard
            // 
            this.numericUpDownSurfJard.Location = new System.Drawing.Point(314, 121);
            this.numericUpDownSurfJard.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownSurfJard.Name = "numericUpDownSurfJard";
            this.numericUpDownSurfJard.Size = new System.Drawing.Size(107, 20);
            this.numericUpDownSurfJard.TabIndex = 11;
            this.numericUpDownSurfJard.ValueChanged += new System.EventHandler(this.numericUpDownSurfJard_ValueChanged);
            this.numericUpDownSurfJard.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDownSurfJard_KeyUp);
            // 
            // numericUpDownBudget
            // 
            this.numericUpDownBudget.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownBudget.Location = new System.Drawing.Point(314, 49);
            this.numericUpDownBudget.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownBudget.Name = "numericUpDownBudget";
            this.numericUpDownBudget.Size = new System.Drawing.Size(107, 20);
            this.numericUpDownBudget.TabIndex = 5;
            this.numericUpDownBudget.ValueChanged += new System.EventHandler(this.numericUpDownBudget_ValueChanged);
            this.numericUpDownBudget.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDownBudget_KeyUp);
            // 
            // listBoxVilles
            // 
            this.listBoxVilles.FormattingEnabled = true;
            this.listBoxVilles.Location = new System.Drawing.Point(155, 158);
            this.listBoxVilles.Name = "listBoxVilles";
            this.listBoxVilles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxVilles.Size = new System.Drawing.Size(200, 69);
            this.listBoxVilles.TabIndex = 13;
            this.listBoxVilles.SelectedIndexChanged += new System.EventHandler(this.listBoxVilles_SelectedIndexChanged);
            // 
            // comboBoxAgent
            // 
            this.comboBoxAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAgent.FormattingEnabled = true;
            this.comboBoxAgent.Location = new System.Drawing.Point(286, 19);
            this.comboBoxAgent.Name = "comboBoxAgent";
            this.comboBoxAgent.Size = new System.Drawing.Size(164, 21);
            this.comboBoxAgent.TabIndex = 2;
            this.comboBoxAgent.SelectedIndexChanged += new System.EventHandler(this.comboBoxAgent_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Agent :";
            // 
            // comboBoxAcheteur
            // 
            this.comboBoxAcheteur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAcheteur.FormattingEnabled = true;
            this.comboBoxAcheteur.Location = new System.Drawing.Point(60, 19);
            this.comboBoxAcheteur.Name = "comboBoxAcheteur";
            this.comboBoxAcheteur.Size = new System.Drawing.Size(164, 21);
            this.comboBoxAcheteur.TabIndex = 1;
            this.comboBoxAcheteur.SelectedIndexChanged += new System.EventHandler(this.comboBoxAcheteur_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 22);
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
            this.buttonAddVilles.TabIndex = 14;
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
            this.buttonAnnuler.TabIndex = 16;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(375, 204);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(75, 23);
            this.buttonAjouter.TabIndex = 15;
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
            // trackBarSurfJard
            // 
            this.trackBarSurfJard.Location = new System.Drawing.Point(155, 122);
            this.trackBarSurfJard.Maximum = 10000;
            this.trackBarSurfJard.Name = "trackBarSurfJard";
            this.trackBarSurfJard.Size = new System.Drawing.Size(153, 45);
            this.trackBarSurfJard.TabIndex = 10;
            this.trackBarSurfJard.TickFrequency = 0;
            this.trackBarSurfJard.Scroll += new System.EventHandler(this.trackBarSurfJard_Scroll);
            // 
            // trackBarSurfHab
            // 
            this.trackBarSurfHab.Location = new System.Drawing.Point(155, 84);
            this.trackBarSurfHab.Maximum = 300;
            this.trackBarSurfHab.Name = "trackBarSurfHab";
            this.trackBarSurfHab.Size = new System.Drawing.Size(153, 45);
            this.trackBarSurfHab.TabIndex = 7;
            this.trackBarSurfHab.TickFrequency = 0;
            this.trackBarSurfHab.Scroll += new System.EventHandler(this.trackBarSurfHab_Scroll);
            // 
            // trackBarBudget
            // 
            this.trackBarBudget.Location = new System.Drawing.Point(155, 50);
            this.trackBarBudget.Maximum = 1000000;
            this.trackBarBudget.Name = "trackBarBudget";
            this.trackBarBudget.Size = new System.Drawing.Size(153, 45);
            this.trackBarBudget.TabIndex = 4;
            this.trackBarBudget.TickFrequency = 0;
            this.trackBarBudget.Scroll += new System.EventHandler(this.trackBarBudget_Scroll);
            // 
            // checkBoxVilles
            // 
            this.checkBoxVilles.AutoSize = true;
            this.checkBoxVilles.Location = new System.Drawing.Point(13, 158);
            this.checkBoxVilles.Name = "checkBoxVilles";
            this.checkBoxVilles.Size = new System.Drawing.Size(56, 17);
            this.checkBoxVilles.TabIndex = 12;
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
            this.checkBoxJardin.TabIndex = 9;
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
            this.checkBoxSurfHab.TabIndex = 6;
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
            this.checkBoxBudgetMax.TabIndex = 3;
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSurfHab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSurfJard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBudget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSurfJard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSurfHab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBudget)).EndInit();
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
        private System.Windows.Forms.TrackBar trackBarSurfJard;
        private System.Windows.Forms.TrackBar trackBarSurfHab;
        private System.Windows.Forms.TrackBar trackBarBudget;
        private System.Windows.Forms.CheckBox checkBoxVilles;
        private System.Windows.Forms.CheckBox checkBoxJardin;
        private System.Windows.Forms.CheckBox checkBoxSurfHab;
        private System.Windows.Forms.CheckBox checkBoxBudgetMax;
        private System.Windows.Forms.ComboBox comboBoxAcheteur;
        private System.Windows.Forms.ListBox listBoxVilles;
        private System.Windows.Forms.Button buttonAddVilles;
        private System.Windows.Forms.ComboBox comboBoxAgent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownBudget;
        private System.Windows.Forms.NumericUpDown numericUpDownSurfHab;
        private System.Windows.Forms.NumericUpDown numericUpDownSurfJard;
    }
}
