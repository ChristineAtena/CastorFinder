namespace Pollux.UserInterface
{
    partial class UCAfficherBiens
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
            this.groupBoxBiens = new System.Windows.Forms.GroupBox();
            this.listViewBiens = new System.Windows.Forms.ListView();
            this.budget = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surfaceHabitable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surfaceJardin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.villes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.groupBoxBiens.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBiens
            // 
            this.groupBoxBiens.Controls.Add(this.buttonAnnuler);
            this.groupBoxBiens.Controls.Add(this.buttonAjouter);
            this.groupBoxBiens.Controls.Add(this.listViewBiens);
            this.groupBoxBiens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBiens.Location = new System.Drawing.Point(0, 30);
            this.groupBoxBiens.Name = "groupBoxBiens";
            this.groupBoxBiens.Size = new System.Drawing.Size(508, 277);
            this.groupBoxBiens.TabIndex = 11;
            this.groupBoxBiens.TabStop = false;
            this.groupBoxBiens.Text = "Biens trouvés";
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
            this.listViewBiens.Location = new System.Drawing.Point(15, 19);
            this.listViewBiens.Name = "listViewBiens";
            this.listViewBiens.Size = new System.Drawing.Size(461, 183);
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
            this.buttonAnnuler.Location = new System.Drawing.Point(288, 208);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 12;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(369, 208);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(107, 23);
            this.buttonAjouter.TabIndex = 11;
            this.buttonAjouter.Text = "Ajouter une visite";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            // 
            // UCAfficherBiens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxBiens);
            this.Name = "UCAfficherBiens";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Size = new System.Drawing.Size(508, 307);
            this.groupBoxBiens.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBiens;
        private System.Windows.Forms.ListView listViewBiens;
        private System.Windows.Forms.ColumnHeader budget;
        private System.Windows.Forms.ColumnHeader surfaceHabitable;
        private System.Windows.Forms.ColumnHeader surfaceJardin;
        private System.Windows.Forms.ColumnHeader villes;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonAjouter;
    }
}
