namespace Pollux.UserInterface
{
    partial class UCAjouterBien
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
            this.groupBoxAjoutBien = new System.Windows.Forms.GroupBox();
            this.numericUpDownSurfJard = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSurfHab = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBudget = new System.Windows.Forms.NumericUpDown();
            this.dateMiseEnVente = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.buttonAjoutVille = new System.Windows.Forms.Button();
            this.comboBoxVille = new System.Windows.Forms.ComboBox();
            this.comboBoxProprietaire = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBarAjoutBienJardin = new System.Windows.Forms.TrackBar();
            this.trackBarAjoutBienSurfHab = new System.Windows.Forms.TrackBar();
            this.trackBarAjoutBienPrix = new System.Windows.Forms.TrackBar();
            this.groupBoxAjoutBien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSurfJard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSurfHab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBudget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAjoutBienJardin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAjoutBienSurfHab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAjoutBienPrix)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAjoutBien
            // 
            this.groupBoxAjoutBien.Controls.Add(this.numericUpDownSurfJard);
            this.groupBoxAjoutBien.Controls.Add(this.numericUpDownSurfHab);
            this.groupBoxAjoutBien.Controls.Add(this.numericUpDownBudget);
            this.groupBoxAjoutBien.Controls.Add(this.dateMiseEnVente);
            this.groupBoxAjoutBien.Controls.Add(this.label27);
            this.groupBoxAjoutBien.Controls.Add(this.buttonAjoutVille);
            this.groupBoxAjoutBien.Controls.Add(this.comboBoxVille);
            this.groupBoxAjoutBien.Controls.Add(this.comboBoxProprietaire);
            this.groupBoxAjoutBien.Controls.Add(this.label10);
            this.groupBoxAjoutBien.Controls.Add(this.label9);
            this.groupBoxAjoutBien.Controls.Add(this.label8);
            this.groupBoxAjoutBien.Controls.Add(this.label11);
            this.groupBoxAjoutBien.Controls.Add(this.label7);
            this.groupBoxAjoutBien.Controls.Add(this.buttonAnnuler);
            this.groupBoxAjoutBien.Controls.Add(this.buttonAjouter);
            this.groupBoxAjoutBien.Controls.Add(this.label4);
            this.groupBoxAjoutBien.Controls.Add(this.label5);
            this.groupBoxAjoutBien.Controls.Add(this.label6);
            this.groupBoxAjoutBien.Controls.Add(this.trackBarAjoutBienJardin);
            this.groupBoxAjoutBien.Controls.Add(this.trackBarAjoutBienSurfHab);
            this.groupBoxAjoutBien.Controls.Add(this.trackBarAjoutBienPrix);
            this.groupBoxAjoutBien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAjoutBien.Location = new System.Drawing.Point(0, 30);
            this.groupBoxAjoutBien.Name = "groupBoxAjoutBien";
            this.groupBoxAjoutBien.Size = new System.Drawing.Size(497, 225);
            this.groupBoxAjoutBien.TabIndex = 7;
            this.groupBoxAjoutBien.TabStop = false;
            this.groupBoxAjoutBien.Text = "Ajouter un bien";
            // 
            // numericUpDownSurfJard
            // 
            this.numericUpDownSurfJard.Location = new System.Drawing.Point(268, 120);
            this.numericUpDownSurfJard.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownSurfJard.Name = "numericUpDownSurfJard";
            this.numericUpDownSurfJard.Size = new System.Drawing.Size(107, 20);
            this.numericUpDownSurfJard.TabIndex = 26;
            this.numericUpDownSurfJard.ValueChanged += new System.EventHandler(this.numericUpDownSurfJard_ValueChanged);
            // 
            // numericUpDownSurfHab
            // 
            this.numericUpDownSurfHab.Location = new System.Drawing.Point(268, 84);
            this.numericUpDownSurfHab.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownSurfHab.Name = "numericUpDownSurfHab";
            this.numericUpDownSurfHab.Size = new System.Drawing.Size(107, 20);
            this.numericUpDownSurfHab.TabIndex = 26;
            this.numericUpDownSurfHab.ValueChanged += new System.EventHandler(this.numericUpDownSurfHab_ValueChanged);
            // 
            // numericUpDownBudget
            // 
            this.numericUpDownBudget.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownBudget.Location = new System.Drawing.Point(268, 48);
            this.numericUpDownBudget.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownBudget.Name = "numericUpDownBudget";
            this.numericUpDownBudget.Size = new System.Drawing.Size(107, 20);
            this.numericUpDownBudget.TabIndex = 26;
            this.numericUpDownBudget.ValueChanged += new System.EventHandler(this.numericUpDownBudget_ValueChanged);
            this.numericUpDownBudget.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDownBudget_KeyUp);
            // 
            // dateMiseEnVente
            // 
            this.dateMiseEnVente.Location = new System.Drawing.Point(104, 183);
            this.dateMiseEnVente.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateMiseEnVente.Name = "dateMiseEnVente";
            this.dateMiseEnVente.Size = new System.Drawing.Size(169, 20);
            this.dateMiseEnVente.TabIndex = 25;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(12, 189);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(81, 13);
            this.label27.TabIndex = 24;
            this.label27.Text = "Date de vente :";
            // 
            // buttonAjoutVille
            // 
            this.buttonAjoutVille.Location = new System.Drawing.Point(264, 154);
            this.buttonAjoutVille.Name = "buttonAjoutVille";
            this.buttonAjoutVille.Size = new System.Drawing.Size(111, 23);
            this.buttonAjoutVille.TabIndex = 23;
            this.buttonAjoutVille.Text = "Ajouter une ville";
            this.buttonAjoutVille.UseVisualStyleBackColor = true;
            this.buttonAjoutVille.Click += new System.EventHandler(this.buttonAjoutVille_Click);
            // 
            // comboBoxVille
            // 
            this.comboBoxVille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVille.FormattingEnabled = true;
            this.comboBoxVille.Location = new System.Drawing.Point(104, 156);
            this.comboBoxVille.Name = "comboBoxVille";
            this.comboBoxVille.Size = new System.Drawing.Size(153, 21);
            this.comboBoxVille.TabIndex = 8;
            // 
            // comboBoxProprietaire
            // 
            this.comboBoxProprietaire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProprietaire.FormattingEnabled = true;
            this.comboBoxProprietaire.Location = new System.Drawing.Point(104, 20);
            this.comboBoxProprietaire.Name = "comboBoxProprietaire";
            this.comboBoxProprietaire.Size = new System.Drawing.Size(271, 21);
            this.comboBoxProprietaire.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Ville :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Surface du jardin :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Surface habitable :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Propriétaire :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Prix :";
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnnuler.Location = new System.Drawing.Point(324, 188);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 4;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(404, 188);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(75, 23);
            this.buttonAjouter.TabIndex = 4;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "m²";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "m²";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "€";
            // 
            // trackBarAjoutBienJardin
            // 
            this.trackBarAjoutBienJardin.Location = new System.Drawing.Point(104, 119);
            this.trackBarAjoutBienJardin.Maximum = 10000;
            this.trackBarAjoutBienJardin.Name = "trackBarAjoutBienJardin";
            this.trackBarAjoutBienJardin.Size = new System.Drawing.Size(153, 45);
            this.trackBarAjoutBienJardin.TabIndex = 1;
            this.trackBarAjoutBienJardin.TickFrequency = 0;
            this.trackBarAjoutBienJardin.Scroll += new System.EventHandler(this.trackBarAjoutBienJardin_Scroll);
            // 
            // trackBarAjoutBienSurfHab
            // 
            this.trackBarAjoutBienSurfHab.Location = new System.Drawing.Point(104, 83);
            this.trackBarAjoutBienSurfHab.Maximum = 300;
            this.trackBarAjoutBienSurfHab.Name = "trackBarAjoutBienSurfHab";
            this.trackBarAjoutBienSurfHab.Size = new System.Drawing.Size(153, 45);
            this.trackBarAjoutBienSurfHab.TabIndex = 1;
            this.trackBarAjoutBienSurfHab.TickFrequency = 0;
            this.trackBarAjoutBienSurfHab.Scroll += new System.EventHandler(this.trackBarAjoutBienSurfHab_Scroll);
            // 
            // trackBarAjoutBienPrix
            // 
            this.trackBarAjoutBienPrix.Location = new System.Drawing.Point(104, 47);
            this.trackBarAjoutBienPrix.Maximum = 1000000;
            this.trackBarAjoutBienPrix.Name = "trackBarAjoutBienPrix";
            this.trackBarAjoutBienPrix.Size = new System.Drawing.Size(153, 45);
            this.trackBarAjoutBienPrix.TabIndex = 1;
            this.trackBarAjoutBienPrix.TickFrequency = 0;
            this.trackBarAjoutBienPrix.Scroll += new System.EventHandler(this.trackBarAjoutBienPrix_Scroll);
            // 
            // UCAjouterBien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxAjoutBien);
            this.Name = "UCAjouterBien";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Size = new System.Drawing.Size(497, 255);
            this.groupBoxAjoutBien.ResumeLayout(false);
            this.groupBoxAjoutBien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSurfJard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSurfHab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBudget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAjoutBienJardin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAjoutBienSurfHab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAjoutBienPrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAjoutBien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBarAjoutBienJardin;
        private System.Windows.Forms.TrackBar trackBarAjoutBienSurfHab;
        private System.Windows.Forms.TrackBar trackBarAjoutBienPrix;
        private System.Windows.Forms.ComboBox comboBoxProprietaire;
        private System.Windows.Forms.ComboBox comboBoxVille;
        private System.Windows.Forms.Button buttonAjoutVille;
        private System.Windows.Forms.DateTimePicker dateMiseEnVente;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.NumericUpDown numericUpDownSurfJard;
        private System.Windows.Forms.NumericUpDown numericUpDownSurfHab;
        private System.Windows.Forms.NumericUpDown numericUpDownBudget;
    }
}
