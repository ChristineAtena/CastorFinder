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
            this.buttonAjoutVille = new System.Windows.Forms.Button();
            this.comboBoxVilles = new System.Windows.Forms.ComboBox();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonRechBien = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxRechBienJardin = new System.Windows.Forms.TextBox();
            this.textBoxRechBienSurf = new System.Windows.Forms.TextBox();
            this.textBoxRechBienPrix = new System.Windows.Forms.TextBox();
            this.trackBarRechBienJardin = new System.Windows.Forms.TrackBar();
            this.trackBarRechBienSurf = new System.Windows.Forms.TrackBar();
            this.trackBarRechBienPrix = new System.Windows.Forms.TrackBar();
            this.checkBoxVille = new System.Windows.Forms.CheckBox();
            this.checkBoxJardin = new System.Windows.Forms.CheckBox();
            this.checkBoxSurfHab = new System.Windows.Forms.CheckBox();
            this.checkBoxBudgetMax = new System.Windows.Forms.CheckBox();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBoxRechBien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRechBienJardin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRechBienSurf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRechBienPrix)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxRechBien
            // 
            this.groupBoxRechBien.Controls.Add(this.dateTimePicker);
            this.groupBoxRechBien.Controls.Add(this.buttonAjoutVille);
            this.groupBoxRechBien.Controls.Add(this.comboBoxVilles);
            this.groupBoxRechBien.Controls.Add(this.buttonAnnuler);
            this.groupBoxRechBien.Controls.Add(this.buttonRechBien);
            this.groupBoxRechBien.Controls.Add(this.label13);
            this.groupBoxRechBien.Controls.Add(this.label17);
            this.groupBoxRechBien.Controls.Add(this.label18);
            this.groupBoxRechBien.Controls.Add(this.textBoxRechBienJardin);
            this.groupBoxRechBien.Controls.Add(this.textBoxRechBienSurf);
            this.groupBoxRechBien.Controls.Add(this.textBoxRechBienPrix);
            this.groupBoxRechBien.Controls.Add(this.trackBarRechBienJardin);
            this.groupBoxRechBien.Controls.Add(this.trackBarRechBienSurf);
            this.groupBoxRechBien.Controls.Add(this.trackBarRechBienPrix);
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
            // buttonAjoutVille
            // 
            this.buttonAjoutVille.Location = new System.Drawing.Point(314, 139);
            this.buttonAjoutVille.Name = "buttonAjoutVille";
            this.buttonAjoutVille.Size = new System.Drawing.Size(112, 23);
            this.buttonAjoutVille.TabIndex = 23;
            this.buttonAjoutVille.Text = "Ajouter une ville";
            this.buttonAjoutVille.UseVisualStyleBackColor = true;
            this.buttonAjoutVille.Click += new System.EventHandler(this.buttonAjoutVille_Click);
            // 
            // comboBoxVilles
            // 
            this.comboBoxVilles.FormattingEnabled = true;
            this.comboBoxVilles.Location = new System.Drawing.Point(155, 141);
            this.comboBoxVilles.Name = "comboBoxVilles";
            this.comboBoxVilles.Size = new System.Drawing.Size(153, 21);
            this.comboBoxVilles.TabIndex = 5;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnnuler.Location = new System.Drawing.Point(401, 180);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 4;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonRechBien
            // 
            this.buttonRechBien.Location = new System.Drawing.Point(401, 209);
            this.buttonRechBien.Name = "buttonRechBien";
            this.buttonRechBien.Size = new System.Drawing.Size(75, 23);
            this.buttonRechBien.TabIndex = 4;
            this.buttonRechBien.Text = "Rechercher";
            this.buttonRechBien.UseVisualStyleBackColor = true;
            this.buttonRechBien.Click += new System.EventHandler(this.buttonRechBien_Click);
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
            // textBoxRechBienJardin
            // 
            this.textBoxRechBienJardin.Location = new System.Drawing.Point(314, 107);
            this.textBoxRechBienJardin.Name = "textBoxRechBienJardin";
            this.textBoxRechBienJardin.Size = new System.Drawing.Size(112, 20);
            this.textBoxRechBienJardin.TabIndex = 2;
            // 
            // textBoxRechBienSurf
            // 
            this.textBoxRechBienSurf.Location = new System.Drawing.Point(314, 71);
            this.textBoxRechBienSurf.Name = "textBoxRechBienSurf";
            this.textBoxRechBienSurf.Size = new System.Drawing.Size(112, 20);
            this.textBoxRechBienSurf.TabIndex = 2;
            // 
            // textBoxRechBienPrix
            // 
            this.textBoxRechBienPrix.Location = new System.Drawing.Point(314, 35);
            this.textBoxRechBienPrix.Name = "textBoxRechBienPrix";
            this.textBoxRechBienPrix.Size = new System.Drawing.Size(112, 20);
            this.textBoxRechBienPrix.TabIndex = 2;
            // 
            // trackBarRechBienJardin
            // 
            this.trackBarRechBienJardin.Location = new System.Drawing.Point(155, 107);
            this.trackBarRechBienJardin.Maximum = 10000;
            this.trackBarRechBienJardin.Name = "trackBarRechBienJardin";
            this.trackBarRechBienJardin.Size = new System.Drawing.Size(153, 45);
            this.trackBarRechBienJardin.TabIndex = 1;
            this.trackBarRechBienJardin.TickFrequency = 0;
            this.trackBarRechBienJardin.Scroll += new System.EventHandler(this.trackBarRechBienJardin_Scroll);
            // 
            // trackBarRechBienSurf
            // 
            this.trackBarRechBienSurf.Location = new System.Drawing.Point(155, 69);
            this.trackBarRechBienSurf.Maximum = 300;
            this.trackBarRechBienSurf.Name = "trackBarRechBienSurf";
            this.trackBarRechBienSurf.Size = new System.Drawing.Size(153, 45);
            this.trackBarRechBienSurf.TabIndex = 1;
            this.trackBarRechBienSurf.TickFrequency = 0;
            this.trackBarRechBienSurf.Scroll += new System.EventHandler(this.trackBarRechBienSurf_Scroll);
            // 
            // trackBarRechBienPrix
            // 
            this.trackBarRechBienPrix.Location = new System.Drawing.Point(155, 35);
            this.trackBarRechBienPrix.Maximum = 1000000;
            this.trackBarRechBienPrix.Name = "trackBarRechBienPrix";
            this.trackBarRechBienPrix.Size = new System.Drawing.Size(153, 45);
            this.trackBarRechBienPrix.TabIndex = 1;
            this.trackBarRechBienPrix.TickFrequency = 0;
            this.trackBarRechBienPrix.Scroll += new System.EventHandler(this.trackBarRechBienPrix_Scroll);
            // 
            // checkBoxVille
            // 
            this.checkBoxVille.AutoSize = true;
            this.checkBoxVille.Location = new System.Drawing.Point(13, 143);
            this.checkBoxVille.Name = "checkBoxVille";
            this.checkBoxVille.Size = new System.Drawing.Size(56, 17);
            this.checkBoxVille.TabIndex = 0;
            this.checkBoxVille.Text = "Villes :";
            this.checkBoxVille.UseVisualStyleBackColor = true;
            // 
            // checkBoxJardin
            // 
            this.checkBoxJardin.AutoSize = true;
            this.checkBoxJardin.Location = new System.Drawing.Point(13, 107);
            this.checkBoxJardin.Name = "checkBoxJardin";
            this.checkBoxJardin.Size = new System.Drawing.Size(131, 17);
            this.checkBoxJardin.TabIndex = 0;
            this.checkBoxJardin.Text = "Surface de jardin min :";
            this.checkBoxJardin.UseVisualStyleBackColor = true;
            // 
            // checkBoxSurfHab
            // 
            this.checkBoxSurfHab.AutoSize = true;
            this.checkBoxSurfHab.Location = new System.Drawing.Point(13, 71);
            this.checkBoxSurfHab.Name = "checkBoxSurfHab";
            this.checkBoxSurfHab.Size = new System.Drawing.Size(134, 17);
            this.checkBoxSurfHab.TabIndex = 0;
            this.checkBoxSurfHab.Text = "Surface habitable min :";
            this.checkBoxSurfHab.UseVisualStyleBackColor = true;
            // 
            // checkBoxBudgetMax
            // 
            this.checkBoxBudgetMax.AutoSize = true;
            this.checkBoxBudgetMax.Location = new System.Drawing.Point(13, 35);
            this.checkBoxBudgetMax.Name = "checkBoxBudgetMax";
            this.checkBoxBudgetMax.Size = new System.Drawing.Size(88, 17);
            this.checkBoxBudgetMax.TabIndex = 0;
            this.checkBoxBudgetMax.Text = "Budget max :";
            this.checkBoxBudgetMax.UseVisualStyleBackColor = true;
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Location = new System.Drawing.Point(13, 180);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(90, 17);
            this.checkBoxDate.TabIndex = 0;
            this.checkBoxDate.Text = "Date voulue :";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(155, 175);
            this.dateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(162, 20);
            this.dateTimePicker.TabIndex = 24;
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRechBienJardin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRechBienSurf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRechBienPrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRechBien;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonRechBien;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxRechBienJardin;
        private System.Windows.Forms.TextBox textBoxRechBienSurf;
        private System.Windows.Forms.TextBox textBoxRechBienPrix;
        private System.Windows.Forms.TrackBar trackBarRechBienJardin;
        private System.Windows.Forms.TrackBar trackBarRechBienSurf;
        private System.Windows.Forms.TrackBar trackBarRechBienPrix;
        private System.Windows.Forms.CheckBox checkBoxVille;
        private System.Windows.Forms.CheckBox checkBoxJardin;
        private System.Windows.Forms.CheckBox checkBoxSurfHab;
        private System.Windows.Forms.CheckBox checkBoxBudgetMax;
        private System.Windows.Forms.ComboBox comboBoxVilles;
        private System.Windows.Forms.Button buttonAjoutVille;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}
