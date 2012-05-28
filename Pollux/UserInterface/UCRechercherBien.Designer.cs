namespace Pollux.UserInterface
{
    partial class UCRechercherBien
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
            this.groupBoxRechBien = new System.Windows.Forms.GroupBox();
            this.numericUpDownSurfHab = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSurfJard = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBudget = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxVille = new System.Windows.Forms.ComboBox();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.trackBarSurfJard = new System.Windows.Forms.TrackBar();
            this.trackBarSurfHab = new System.Windows.Forms.TrackBar();
            this.trackBarBudget = new System.Windows.Forms.TrackBar();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.checkBoxVille = new System.Windows.Forms.CheckBox();
            this.checkBoxJardin = new System.Windows.Forms.CheckBox();
            this.checkBoxSurfHab = new System.Windows.Forms.CheckBox();
            this.checkBoxBudgetMax = new System.Windows.Forms.CheckBox();
            this.groupBoxRechBien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSurfHab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSurfJard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBudget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSurfJard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSurfHab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxRechBien
            // 
            this.groupBoxRechBien.Controls.Add(this.numericUpDownSurfHab);
            this.groupBoxRechBien.Controls.Add(this.numericUpDownSurfJard);
            this.groupBoxRechBien.Controls.Add(this.numericUpDownBudget);
            this.groupBoxRechBien.Controls.Add(this.dateTimePicker);
            this.groupBoxRechBien.Controls.Add(this.comboBoxVille);
            this.groupBoxRechBien.Controls.Add(this.buttonAnnuler);
            this.groupBoxRechBien.Controls.Add(this.buttonRechercher);
            this.groupBoxRechBien.Controls.Add(this.label13);
            this.groupBoxRechBien.Controls.Add(this.label17);
            this.groupBoxRechBien.Controls.Add(this.label18);
            this.groupBoxRechBien.Controls.Add(this.trackBarSurfJard);
            this.groupBoxRechBien.Controls.Add(this.trackBarSurfHab);
            this.groupBoxRechBien.Controls.Add(this.trackBarBudget);
            this.groupBoxRechBien.Controls.Add(this.checkBoxDate);
            this.groupBoxRechBien.Controls.Add(this.checkBoxVille);
            this.groupBoxRechBien.Controls.Add(this.checkBoxJardin);
            this.groupBoxRechBien.Controls.Add(this.checkBoxSurfHab);
            this.groupBoxRechBien.Controls.Add(this.checkBoxBudgetMax);
            this.groupBoxRechBien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRechBien.Location = new System.Drawing.Point(0, 30);
            this.groupBoxRechBien.Name = "groupBoxRechBien";
            this.groupBoxRechBien.Size = new System.Drawing.Size(525, 269);
            this.groupBoxRechBien.TabIndex = 13;
            this.groupBoxRechBien.TabStop = false;
            this.groupBoxRechBien.Text = "Rechercher un bien";
            // 
            // numericUpDownSurfHab
            // 
            this.numericUpDownSurfHab.Location = new System.Drawing.Point(314, 72);
            this.numericUpDownSurfHab.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownSurfHab.Name = "numericUpDownSurfHab";
            this.numericUpDownSurfHab.Size = new System.Drawing.Size(107, 20);
            this.numericUpDownSurfHab.TabIndex = 6;
            this.numericUpDownSurfHab.ValueChanged += new System.EventHandler(this.numericUpDownSurfHab_ValueChanged);
            this.numericUpDownSurfHab.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDownSurfHab_KeyUp);
            // 
            // numericUpDownSurfJard
            // 
            this.numericUpDownSurfJard.Location = new System.Drawing.Point(314, 108);
            this.numericUpDownSurfJard.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownSurfJard.Name = "numericUpDownSurfJard";
            this.numericUpDownSurfJard.Size = new System.Drawing.Size(107, 20);
            this.numericUpDownSurfJard.TabIndex = 9;
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
            this.numericUpDownBudget.Location = new System.Drawing.Point(314, 36);
            this.numericUpDownBudget.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownBudget.Name = "numericUpDownBudget";
            this.numericUpDownBudget.Size = new System.Drawing.Size(107, 20);
            this.numericUpDownBudget.TabIndex = 3;
            this.numericUpDownBudget.ValueChanged += new System.EventHandler(this.numericUpDownBudget_ValueChanged);
            this.numericUpDownBudget.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDownBudget_KeyUp);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(155, 175);
            this.dateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(162, 20);
            this.dateTimePicker.TabIndex = 13;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // comboBoxVille
            // 
            this.comboBoxVille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVille.FormattingEnabled = true;
            this.comboBoxVille.Location = new System.Drawing.Point(155, 141);
            this.comboBoxVille.Name = "comboBoxVille";
            this.comboBoxVille.Size = new System.Drawing.Size(271, 21);
            this.comboBoxVille.TabIndex = 11;
            this.comboBoxVille.SelectedIndexChanged += new System.EventHandler(this.comboBoxVille_SelectedIndexChanged);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnnuler.Location = new System.Drawing.Point(320, 209);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 15;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(401, 209);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(75, 23);
            this.buttonRechercher.TabIndex = 14;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(432, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "m²";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(432, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "m²";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(432, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "€";
            // 
            // trackBarSurfJard
            // 
            this.trackBarSurfJard.Location = new System.Drawing.Point(155, 107);
            this.trackBarSurfJard.Maximum = 10000;
            this.trackBarSurfJard.Name = "trackBarSurfJard";
            this.trackBarSurfJard.Size = new System.Drawing.Size(153, 45);
            this.trackBarSurfJard.TabIndex = 8;
            this.trackBarSurfJard.TickFrequency = 0;
            this.trackBarSurfJard.Scroll += new System.EventHandler(this.trackBarSurfJard_Scroll);
            // 
            // trackBarSurfHab
            // 
            this.trackBarSurfHab.Location = new System.Drawing.Point(155, 69);
            this.trackBarSurfHab.Maximum = 300;
            this.trackBarSurfHab.Name = "trackBarSurfHab";
            this.trackBarSurfHab.Size = new System.Drawing.Size(153, 45);
            this.trackBarSurfHab.TabIndex = 5;
            this.trackBarSurfHab.TickFrequency = 0;
            this.trackBarSurfHab.Scroll += new System.EventHandler(this.trackBarSurfHab_Scroll);
            // 
            // trackBarBudget
            // 
            this.trackBarBudget.Location = new System.Drawing.Point(155, 35);
            this.trackBarBudget.Maximum = 1000000;
            this.trackBarBudget.Name = "trackBarBudget";
            this.trackBarBudget.Size = new System.Drawing.Size(153, 45);
            this.trackBarBudget.TabIndex = 2;
            this.trackBarBudget.TickFrequency = 0;
            this.trackBarBudget.Scroll += new System.EventHandler(this.trackBarBudget_Scroll);
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Location = new System.Drawing.Point(13, 180);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(90, 17);
            this.checkBoxDate.TabIndex = 12;
            this.checkBoxDate.Text = "Date voulue :";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            this.checkBoxDate.CheckedChanged += new System.EventHandler(this.checkBoxDate_CheckedChanged);
            // 
            // checkBoxVille
            // 
            this.checkBoxVille.AutoSize = true;
            this.checkBoxVille.Location = new System.Drawing.Point(13, 143);
            this.checkBoxVille.Name = "checkBoxVille";
            this.checkBoxVille.Size = new System.Drawing.Size(51, 17);
            this.checkBoxVille.TabIndex = 10;
            this.checkBoxVille.Text = "Ville :";
            this.checkBoxVille.UseVisualStyleBackColor = true;
            this.checkBoxVille.CheckedChanged += new System.EventHandler(this.checkBoxVilles_CheckedChanged);
            // 
            // checkBoxJardin
            // 
            this.checkBoxJardin.AutoSize = true;
            this.checkBoxJardin.Location = new System.Drawing.Point(13, 107);
            this.checkBoxJardin.Name = "checkBoxJardin";
            this.checkBoxJardin.Size = new System.Drawing.Size(131, 17);
            this.checkBoxJardin.TabIndex = 7;
            this.checkBoxJardin.Text = "Surface de jardin min :";
            this.checkBoxJardin.UseVisualStyleBackColor = true;
            this.checkBoxJardin.CheckedChanged += new System.EventHandler(this.checkBoxJardin_CheckedChanged);
            // 
            // checkBoxSurfHab
            // 
            this.checkBoxSurfHab.AutoSize = true;
            this.checkBoxSurfHab.Location = new System.Drawing.Point(13, 71);
            this.checkBoxSurfHab.Name = "checkBoxSurfHab";
            this.checkBoxSurfHab.Size = new System.Drawing.Size(134, 17);
            this.checkBoxSurfHab.TabIndex = 4;
            this.checkBoxSurfHab.Text = "Surface habitable min :";
            this.checkBoxSurfHab.UseVisualStyleBackColor = true;
            this.checkBoxSurfHab.CheckedChanged += new System.EventHandler(this.checkBoxSurfHab_CheckedChanged);
            // 
            // checkBoxBudgetMax
            // 
            this.checkBoxBudgetMax.AutoSize = true;
            this.checkBoxBudgetMax.Location = new System.Drawing.Point(13, 35);
            this.checkBoxBudgetMax.Name = "checkBoxBudgetMax";
            this.checkBoxBudgetMax.Size = new System.Drawing.Size(88, 17);
            this.checkBoxBudgetMax.TabIndex = 1;
            this.checkBoxBudgetMax.Text = "Budget max :";
            this.checkBoxBudgetMax.UseVisualStyleBackColor = true;
            this.checkBoxBudgetMax.CheckedChanged += new System.EventHandler(this.checkBoxBudgetMax_CheckedChanged);
            // 
            // UCRechercherBien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxRechBien);
            this.Name = "UCRechercherBien";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Size = new System.Drawing.Size(525, 299);
            this.groupBoxRechBien.ResumeLayout(false);
            this.groupBoxRechBien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSurfHab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSurfJard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBudget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSurfJard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSurfHab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBudget)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRechBien;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TrackBar trackBarSurfJard;
        private System.Windows.Forms.TrackBar trackBarSurfHab;
        private System.Windows.Forms.TrackBar trackBarBudget;
        private System.Windows.Forms.CheckBox checkBoxVille;
        private System.Windows.Forms.CheckBox checkBoxJardin;
        private System.Windows.Forms.CheckBox checkBoxSurfHab;
        private System.Windows.Forms.CheckBox checkBoxBudgetMax;
        private System.Windows.Forms.ComboBox comboBoxVille;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.NumericUpDown numericUpDownSurfHab;
        private System.Windows.Forms.NumericUpDown numericUpDownSurfJard;
        private System.Windows.Forms.NumericUpDown numericUpDownBudget;
    }
}
