namespace Pollux.UserInterface
{
    partial class UCAfficherSouhaits
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
            this.groupBoxSouhaits = new System.Windows.Forms.GroupBox();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.listViewSouhaits = new System.Windows.Forms.ListView();
            this.budget = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surfaceHabitable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surfaceJardin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxSouhaits.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSouhaits
            // 
            this.groupBoxSouhaits.Controls.Add(this.buttonAnnuler);
            this.groupBoxSouhaits.Controls.Add(this.buttonAjouter);
            this.groupBoxSouhaits.Controls.Add(this.listViewSouhaits);
            this.groupBoxSouhaits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSouhaits.Location = new System.Drawing.Point(0, 30);
            this.groupBoxSouhaits.Name = "groupBoxSouhaits";
            this.groupBoxSouhaits.Size = new System.Drawing.Size(508, 277);
            this.groupBoxSouhaits.TabIndex = 12;
            this.groupBoxSouhaits.TabStop = false;
            this.groupBoxSouhaits.Text = "Souhaits trouvés";
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
            // listViewSouhaits
            // 
            this.listViewSouhaits.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.budget,
            this.surfaceHabitable,
            this.surfaceJardin});
            this.listViewSouhaits.FullRowSelect = true;
            this.listViewSouhaits.Location = new System.Drawing.Point(15, 19);
            this.listViewSouhaits.Name = "listViewSouhaits";
            this.listViewSouhaits.Size = new System.Drawing.Size(461, 183);
            this.listViewSouhaits.TabIndex = 10;
            this.listViewSouhaits.UseCompatibleStateImageBehavior = false;
            this.listViewSouhaits.View = System.Windows.Forms.View.Details;
            // 
            // budget
            // 
            this.budget.Text = "Prix";
            this.budget.Width = 147;
            // 
            // surfaceHabitable
            // 
            this.surfaceHabitable.Text = "Surface habitable";
            this.surfaceHabitable.Width = 141;
            // 
            // surfaceJardin
            // 
            this.surfaceJardin.Text = "Surface de jardin";
            this.surfaceJardin.Width = 147;
            // 
            // UCAfficherSouhaits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxSouhaits);
            this.Name = "UCAfficherSouhaits";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Size = new System.Drawing.Size(508, 307);
            this.groupBoxSouhaits.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSouhaits;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.ListView listViewSouhaits;
        private System.Windows.Forms.ColumnHeader budget;
        private System.Windows.Forms.ColumnHeader surfaceHabitable;
        private System.Windows.Forms.ColumnHeader surfaceJardin;
    }
}
