namespace Pollux.UserInterface
{
    partial class UCAjouterVisite
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
            this.groupBoxAjoutVisite = new System.Windows.Forms.GroupBox();
            this.buttonRDV = new System.Windows.Forms.Button();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonCréer = new System.Windows.Forms.Button();
            this.dateTimePickerHeure = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.comboBoxBiens = new System.Windows.Forms.ComboBox();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBoxAjoutVisite.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAjoutVisite
            // 
            this.groupBoxAjoutVisite.Controls.Add(this.buttonRDV);
            this.groupBoxAjoutVisite.Controls.Add(this.textBoxTelephone);
            this.groupBoxAjoutVisite.Controls.Add(this.buttonAnnuler);
            this.groupBoxAjoutVisite.Controls.Add(this.buttonCréer);
            this.groupBoxAjoutVisite.Controls.Add(this.dateTimePickerHeure);
            this.groupBoxAjoutVisite.Controls.Add(this.dateTimePickerDate);
            this.groupBoxAjoutVisite.Controls.Add(this.label28);
            this.groupBoxAjoutVisite.Controls.Add(this.label27);
            this.groupBoxAjoutVisite.Controls.Add(this.comboBoxBiens);
            this.groupBoxAjoutVisite.Controls.Add(this.comboBoxClients);
            this.groupBoxAjoutVisite.Controls.Add(this.label1);
            this.groupBoxAjoutVisite.Controls.Add(this.label29);
            this.groupBoxAjoutVisite.Controls.Add(this.label25);
            this.groupBoxAjoutVisite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAjoutVisite.Location = new System.Drawing.Point(0, 30);
            this.groupBoxAjoutVisite.Name = "groupBoxAjoutVisite";
            this.groupBoxAjoutVisite.Size = new System.Drawing.Size(530, 238);
            this.groupBoxAjoutVisite.TabIndex = 2;
            this.groupBoxAjoutVisite.TabStop = false;
            this.groupBoxAjoutVisite.Text = "Ajouter une visite";
            // 
            // buttonRDV
            // 
            this.buttonRDV.Enabled = false;
            this.buttonRDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRDV.Location = new System.Drawing.Point(148, 126);
            this.buttonRDV.Name = "buttonRDV";
            this.buttonRDV.Size = new System.Drawing.Size(201, 30);
            this.buttonRDV.TabIndex = 6;
            this.buttonRDV.Text = "&Trouver un rendez-vous";
            this.buttonRDV.UseVisualStyleBackColor = true;
            this.buttonRDV.Click += new System.EventHandler(this.buttonRDV_Click);
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Enabled = false;
            this.textBoxTelephone.Location = new System.Drawing.Point(148, 57);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(201, 20);
            this.textBoxTelephone.TabIndex = 5;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnnuler.Location = new System.Drawing.Point(401, 170);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 3;
            this.buttonAnnuler.Text = "&Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonCréer
            // 
            this.buttonCréer.Enabled = false;
            this.buttonCréer.Location = new System.Drawing.Point(401, 199);
            this.buttonCréer.Name = "buttonCréer";
            this.buttonCréer.Size = new System.Drawing.Size(75, 23);
            this.buttonCréer.TabIndex = 3;
            this.buttonCréer.Text = "&Créer";
            this.buttonCréer.UseVisualStyleBackColor = true;
            this.buttonCréer.Click += new System.EventHandler(this.buttonCréer_Click);
            // 
            // dateTimePickerHeure
            // 
            this.dateTimePickerHeure.CustomFormat = "HH : mm";
            this.dateTimePickerHeure.Enabled = false;
            this.dateTimePickerHeure.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHeure.Location = new System.Drawing.Point(148, 201);
            this.dateTimePickerHeure.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerHeure.Name = "dateTimePickerHeure";
            this.dateTimePickerHeure.ShowUpDown = true;
            this.dateTimePickerHeure.Size = new System.Drawing.Size(61, 20);
            this.dateTimePickerHeure.TabIndex = 2;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Enabled = false;
            this.dateTimePickerDate.Location = new System.Drawing.Point(148, 169);
            this.dateTimePickerDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(201, 20);
            this.dateTimePickerDate.TabIndex = 2;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(15, 201);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(42, 13);
            this.label28.TabIndex = 0;
            this.label28.Text = "Heure :";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(15, 173);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(36, 13);
            this.label27.TabIndex = 0;
            this.label27.Text = "Date :";
            // 
            // comboBoxBiens
            // 
            this.comboBoxBiens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBiens.FormattingEnabled = true;
            this.comboBoxBiens.Location = new System.Drawing.Point(148, 93);
            this.comboBoxBiens.Name = "comboBoxBiens";
            this.comboBoxBiens.Size = new System.Drawing.Size(201, 21);
            this.comboBoxBiens.TabIndex = 1;
            this.comboBoxBiens.SelectedIndexChanged += new System.EventHandler(this.comboBoxBiens_SelectedIndexChanged);
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(148, 23);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(201, 21);
            this.comboBoxClients.TabIndex = 1;
            this.comboBoxClients.SelectedIndexChanged += new System.EventHandler(this.comboBoxClients_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "n° du bien (propriétaire)";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(15, 57);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(64, 13);
            this.label29.TabIndex = 0;
            this.label29.Text = "Téléphone :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(15, 26);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(39, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "Client :";
            // 
            // UCAjouterVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxAjoutVisite);
            this.Name = "UCAjouterVisite";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Size = new System.Drawing.Size(530, 268);
            this.groupBoxAjoutVisite.ResumeLayout(false);
            this.groupBoxAjoutVisite.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAjoutVisite;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonCréer;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox comboBoxBiens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRDV;
        private System.Windows.Forms.DateTimePicker dateTimePickerHeure;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label28;
    }
}
