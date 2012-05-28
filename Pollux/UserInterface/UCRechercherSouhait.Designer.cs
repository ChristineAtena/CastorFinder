namespace Pollux.UserInterface
{
    partial class UCRechercherSouhait
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
            this.groupBoxRechSouhait = new System.Windows.Forms.GroupBox();
            this.numericUpDownSurfHab = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSurfJard = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBudget = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxVilles = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.checkBoxVille = new System.Windows.Forms.CheckBox();
            this.checkBoxJardin = new System.Windows.Forms.CheckBox();
            this.trackBarSurfJard = new System.Windows.Forms.TrackBar();
            this.checkBoxSurfHab = new System.Windows.Forms.CheckBox();
            this.trackBarSurfHab = new System.Windows.Forms.TrackBar();
            this.checkBoxBudgetMax = new System.Windows.Forms.CheckBox();
            this.trackBarBudget = new System.Windows.Forms.TrackBar();
            this.groupBoxRechSouhait.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSurfHab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSurfJard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBudget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSurfJard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSurfHab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxRechSouhait
            // 
            this.groupBoxRechSouhait.Controls.Add(this.numericUpDownSurfHab);
            this.groupBoxRechSouhait.Controls.Add(this.numericUpDownSurfJard);
            this.groupBoxRechSouhait.Controls.Add(this.numericUpDownBudget);
            this.groupBoxRechSouhait.Controls.Add(this.label13);
            this.groupBoxRechSouhait.Controls.Add(this.comboBoxVilles);
            this.groupBoxRechSouhait.Controls.Add(this.label17);
            this.groupBoxRechSouhait.Controls.Add(this.buttonAnnuler);
            this.groupBoxRechSouhait.Controls.Add(this.label18);
            this.groupBoxRechSouhait.Controls.Add(this.buttonRechercher);
            this.groupBoxRechSouhait.Controls.Add(this.checkBoxVille);
            this.groupBoxRechSouhait.Controls.Add(this.checkBoxJardin);
            this.groupBoxRechSouhait.Controls.Add(this.trackBarSurfJard);
            this.groupBoxRechSouhait.Controls.Add(this.checkBoxSurfHab);
            this.groupBoxRechSouhait.Controls.Add(this.trackBarSurfHab);
            this.groupBoxRechSouhait.Controls.Add(this.checkBoxBudgetMax);
            this.groupBoxRechSouhait.Controls.Add(this.trackBarBudget);
            this.groupBoxRechSouhait.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRechSouhait.Location = new System.Drawing.Point(0, 30);
            this.groupBoxRechSouhait.Name = "groupBoxRechSouhait";
            this.groupBoxRechSouhait.Size = new System.Drawing.Size(488, 241);
            this.groupBoxRechSouhait.TabIndex = 12;
            this.groupBoxRechSouhait.TabStop = false;
            this.groupBoxRechSouhait.Text = "Rechercher un souhait";
            // 
            // numericUpDownSurfHab
            // 
            this.numericUpDownSurfHab.Location = new System.Drawing.Point(314, 70);
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
            this.numericUpDownSurfJard.Location = new System.Drawing.Point(314, 106);
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
            this.numericUpDownBudget.Location = new System.Drawing.Point(314, 34);
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(432, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "m²";
            // 
            // comboBoxVilles
            // 
            this.comboBoxVilles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVilles.FormattingEnabled = true;
            this.comboBoxVilles.Location = new System.Drawing.Point(155, 141);
            this.comboBoxVilles.Name = "comboBoxVilles";
            this.comboBoxVilles.Size = new System.Drawing.Size(271, 21);
            this.comboBoxVilles.TabIndex = 11;
            this.comboBoxVilles.SelectedIndexChanged += new System.EventHandler(this.comboBoxVille_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(432, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "m²";
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnnuler.Location = new System.Drawing.Point(320, 209);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 4;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(432, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "€";
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(401, 209);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(75, 23);
            this.buttonRechercher.TabIndex = 12;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
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
            // trackBarSurfJard
            // 
            this.trackBarSurfJard.Location = new System.Drawing.Point(155, 104);
            this.trackBarSurfJard.Maximum = 10000;
            this.trackBarSurfJard.Name = "trackBarSurfJard";
            this.trackBarSurfJard.Size = new System.Drawing.Size(153, 45);
            this.trackBarSurfJard.TabIndex = 8;
            this.trackBarSurfJard.TickFrequency = 0;
            this.trackBarSurfJard.Scroll += new System.EventHandler(this.trackBarSurfJard_Scroll);
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
            // trackBarSurfHab
            // 
            this.trackBarSurfHab.Location = new System.Drawing.Point(155, 66);
            this.trackBarSurfHab.Maximum = 300;
            this.trackBarSurfHab.Name = "trackBarSurfHab";
            this.trackBarSurfHab.Size = new System.Drawing.Size(153, 45);
            this.trackBarSurfHab.TabIndex = 5;
            this.trackBarSurfHab.TickFrequency = 0;
            this.trackBarSurfHab.Scroll += new System.EventHandler(this.trackBarSurfHab_Scroll);
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
            // trackBarBudget
            // 
            this.trackBarBudget.Location = new System.Drawing.Point(155, 32);
            this.trackBarBudget.Maximum = 1000000;
            this.trackBarBudget.Name = "trackBarBudget";
            this.trackBarBudget.Size = new System.Drawing.Size(153, 45);
            this.trackBarBudget.TabIndex = 2;
            this.trackBarBudget.TickFrequency = 0;
            this.trackBarBudget.Scroll += new System.EventHandler(this.trackBarBudget_Scroll);
            // 
            // UCRechercherSouhait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxRechSouhait);
            this.Name = "UCRechercherSouhait";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Size = new System.Drawing.Size(488, 271);
            this.groupBoxRechSouhait.ResumeLayout(false);
            this.groupBoxRechSouhait.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSurfHab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSurfJard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBudget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSurfJard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSurfHab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBudget)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRechSouhait;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.CheckBox checkBoxVille;
        private System.Windows.Forms.CheckBox checkBoxJardin;
        private System.Windows.Forms.CheckBox checkBoxSurfHab;
        private System.Windows.Forms.CheckBox checkBoxBudgetMax;
        private System.Windows.Forms.ComboBox comboBoxVilles;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TrackBar trackBarSurfJard;
        private System.Windows.Forms.TrackBar trackBarSurfHab;
        private System.Windows.Forms.TrackBar trackBarBudget;
        private System.Windows.Forms.NumericUpDown numericUpDownSurfHab;
        private System.Windows.Forms.NumericUpDown numericUpDownSurfJard;
        private System.Windows.Forms.NumericUpDown numericUpDownBudget;
    }
}
