namespace Pollux
{
    partial class FenetrePrincipale
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetrePrincipale));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripNouveau = new System.Windows.Forms.ToolStripDropDownButton();
            this.agentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bienToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.souhaitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripRechercher = new System.Windows.Forms.ToolStripDropDownButton();
            this.clientsDeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.biensDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.souhaitsDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.biensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.souhaitsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripVisite = new System.Windows.Forms.ToolStripDropDownButton();
            this.nouvelleVisiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.agendaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.aProposDeCastorFinderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.AllowMerge = false;
            this.toolStripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNouveau,
            this.toolStripSeparator3,
            this.toolStripRechercher,
            this.toolStripSeparator4,
            this.toolStripVisite,
            this.toolStripSeparator6,
            this.toolStripDropDownButton1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripMenu.Size = new System.Drawing.Size(503, 25);
            this.toolStripMenu.TabIndex = 3;
            this.toolStripMenu.Text = "toolStrip2";
            // 
            // toolStripNouveau
            // 
            this.toolStripNouveau.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripNouveau.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agentToolStripMenuItem,
            this.toolStripSeparator2,
            this.clientToolStripMenuItem,
            this.bienToolStripMenuItem2,
            this.souhaitToolStripMenuItem1});
            this.toolStripNouveau.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNouveau.Image")));
            this.toolStripNouveau.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNouveau.Name = "toolStripNouveau";
            this.toolStripNouveau.Size = new System.Drawing.Size(68, 22);
            this.toolStripNouveau.Text = "&Nouveau";
            // 
            // agentToolStripMenuItem
            // 
            this.agentToolStripMenuItem.Name = "agentToolStripMenuItem";
            this.agentToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.agentToolStripMenuItem.Text = "&Agent";
            this.agentToolStripMenuItem.Click += new System.EventHandler(this.agentToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(111, 6);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.clientToolStripMenuItem.Text = "&Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.nouveauClientToolStripMenuItem_Click);
            // 
            // bienToolStripMenuItem2
            // 
            this.bienToolStripMenuItem2.Name = "bienToolStripMenuItem2";
            this.bienToolStripMenuItem2.Size = new System.Drawing.Size(114, 22);
            this.bienToolStripMenuItem2.Text = "&Bien";
            this.bienToolStripMenuItem2.Click += new System.EventHandler(this.bienToolStripMenuItem1_Click);
            // 
            // souhaitToolStripMenuItem1
            // 
            this.souhaitToolStripMenuItem1.Name = "souhaitToolStripMenuItem1";
            this.souhaitToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.souhaitToolStripMenuItem1.Text = "&Souhait";
            this.souhaitToolStripMenuItem1.Click += new System.EventHandler(this.souhaitToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripRechercher
            // 
            this.toolStripRechercher.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripRechercher.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsDeToolStripMenuItem1,
            this.biensDeToolStripMenuItem,
            this.souhaitsDeToolStripMenuItem,
            this.toolStripSeparator1,
            this.biensToolStripMenuItem,
            this.souhaitsToolStripMenuItem1});
            this.toolStripRechercher.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRechercher.Image")));
            this.toolStripRechercher.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRechercher.Name = "toolStripRechercher";
            this.toolStripRechercher.Size = new System.Drawing.Size(79, 22);
            this.toolStripRechercher.Text = "&Rechercher";
            // 
            // clientsDeToolStripMenuItem1
            // 
            this.clientsDeToolStripMenuItem1.Name = "clientsDeToolStripMenuItem1";
            this.clientsDeToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.clientsDeToolStripMenuItem1.Text = "&Clients de...";
            this.clientsDeToolStripMenuItem1.Click += new System.EventHandler(this.clientsDeToolStripMenuItem1_Click);
            // 
            // biensDeToolStripMenuItem
            // 
            this.biensDeToolStripMenuItem.Name = "biensDeToolStripMenuItem";
            this.biensDeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.biensDeToolStripMenuItem.Text = "&Biens de...";
            this.biensDeToolStripMenuItem.Click += new System.EventHandler(this.biensDeToolStripMenuItem_Click);
            // 
            // souhaitsDeToolStripMenuItem
            // 
            this.souhaitsDeToolStripMenuItem.Name = "souhaitsDeToolStripMenuItem";
            this.souhaitsDeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.souhaitsDeToolStripMenuItem.Text = "&Souhaits de...";
            this.souhaitsDeToolStripMenuItem.Click += new System.EventHandler(this.souhaitsDeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // biensToolStripMenuItem
            // 
            this.biensToolStripMenuItem.Name = "biensToolStripMenuItem";
            this.biensToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.biensToolStripMenuItem.Text = "B&iens";
            this.biensToolStripMenuItem.Click += new System.EventHandler(this.bienToolStripMenuItem_Click);
            // 
            // souhaitsToolStripMenuItem1
            // 
            this.souhaitsToolStripMenuItem1.Name = "souhaitsToolStripMenuItem1";
            this.souhaitsToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.souhaitsToolStripMenuItem1.Text = "S&ouhaits";
            this.souhaitsToolStripMenuItem1.Click += new System.EventHandler(this.souhaitsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripVisite
            // 
            this.toolStripVisite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripVisite.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelleVisiteToolStripMenuItem,
            this.toolStripSeparator5,
            this.agendaDeToolStripMenuItem});
            this.toolStripVisite.Image = ((System.Drawing.Image)(resources.GetObject("toolStripVisite.Image")));
            this.toolStripVisite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripVisite.Name = "toolStripVisite";
            this.toolStripVisite.Size = new System.Drawing.Size(48, 22);
            this.toolStripVisite.Text = "&Visite";
            // 
            // nouvelleVisiteToolStripMenuItem
            // 
            this.nouvelleVisiteToolStripMenuItem.Name = "nouvelleVisiteToolStripMenuItem";
            this.nouvelleVisiteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nouvelleVisiteToolStripMenuItem.Text = "&Nouvelle visite";
            this.nouvelleVisiteToolStripMenuItem.Click += new System.EventHandler(this.nouvelleVisitToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // agendaDeToolStripMenuItem
            // 
            this.agendaDeToolStripMenuItem.Name = "agendaDeToolStripMenuItem";
            this.agendaDeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.agendaDeToolStripMenuItem.Text = "&Agenda de...";
            this.agendaDeToolStripMenuItem.Click += new System.EventHandler(this.agendaDeToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposDeCastorFinderToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(16, 22);
            this.toolStripDropDownButton1.Text = "?";
            // 
            // aProposDeCastorFinderToolStripMenuItem
            // 
            this.aProposDeCastorFinderToolStripMenuItem.Name = "aProposDeCastorFinderToolStripMenuItem";
            this.aProposDeCastorFinderToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.aProposDeCastorFinderToolStripMenuItem.Text = "&À propos de Castor Finder";
            this.aProposDeCastorFinderToolStripMenuItem.Click += new System.EventHandler(this.aProposDeCastorFinderToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 278);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(503, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // FenetrePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pollux.Properties.Resources.castor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(503, 300);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStripMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FenetrePrincipale";
            this.Text = "Castor Finder";
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripDropDownButton toolStripNouveau;
        private System.Windows.Forms.ToolStripMenuItem bienToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem souhaitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripRechercher;
        private System.Windows.Forms.ToolStripMenuItem clientsDeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem biensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem souhaitsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton toolStripVisite;
        private System.Windows.Forms.ToolStripMenuItem nouvelleVisiteToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem souhaitsDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biensDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem agentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem agendaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem aProposDeCastorFinderToolStripMenuItem;
    }
}

