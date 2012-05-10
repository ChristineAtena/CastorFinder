using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Pollux.DataBase;
using Pollux.UserInterface;

namespace Pollux
{       
    public partial class FenetrePrincipale : Form
    {
        private UserControl mdiChild;

        public UserControl MdiChild
        {
            get { return mdiChild; }
            set { mdiChild = value; }
        }

        public OleDbConnection connect;

        public FenetrePrincipale()
        {
            InitializeComponent();
            // Connexion
            if (SqlDataProvider.DBConnect())
                toolStripStatusLabel.Text = "Connexion à la base de données réussie"; 
            else
                toolStripStatusLabel.Text = "Attention : impossible de se connecter à la base de données";
        }
        #region Fenetres
        public void init()
        {
            mdiChild.Parent = this;
            mdiChild.Dock = DockStyle.Fill;
            mdiChild.Show();
        }
        public void fermer()
        {
            if (mdiChild != null)
            {
                //mdiChild = null;
                mdiChild.Parent = null;
            }
        }
        private void souhaitsDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            mdiChild = new UCSouhaitsDe();
            init();
        }
        private void nouveauClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            mdiChild = new UCAjouterClient();
            init();
        }
        private void bienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            mdiChild = new UCRechercherBien();
            init();
        }
        private void souhaitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            mdiChild = new UCRechercherSouhait();
            init();
        }

        private void souhaitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            mdiChild = new UCAjouterSouhait();
            init();
        }

        private void bienToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fermer();
            mdiChild = new UCAjouterBien();
            init();
        }

        private void nouvelleVisitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            mdiChild = new UCAjouterVisite();
            init();
        }
        private void clientsDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fermer();
            mdiChild = new UCClientsDe();
            init();
        }
        private void biensDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            mdiChild = new UCBiensDe();
            init();
        }
        private void agentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            mdiChild = new UCAjouterAgent();
            init();
        }
        #endregion

    }
}
