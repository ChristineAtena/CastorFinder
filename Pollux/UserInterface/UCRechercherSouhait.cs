using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Pollux.Object;
using Pollux.DataBase;

namespace Pollux.UserInterface
{
    public partial class UCRechercherSouhait : UserControl
    {
        public UCRechercherSouhait()
        {
            InitializeComponent();
            loadVilles();
        }

        #region Chargement des comboBox
        private void loadVilles()
        {
            comboBoxVilles.Items.Clear();
            List<Ville> listeVilles = SqlDataProvider.GetListeVilles();
            foreach (Ville ville in listeVilles)
            {
                comboBoxVilles.Items.Add(ville);
            }
        }
        #endregion

        #region trackBar
        private void trackBarRechBienPrix_Scroll(object sender, EventArgs e)
        {
            textBoxRechBienPrix.Text = trackBarRechBienPrix.Value.ToString();
        }

        private void trackBarRechBienSurf_Scroll(object sender, EventArgs e)
        {
            textBoxRechBienSurf.Text = trackBarRechBienSurf.Value.ToString();
        }

        private void trackBarRechBienJardin_Scroll(object sender, EventArgs e)
        {
            textBoxRechBienJardin.Text = trackBarRechBienJardin.Value.ToString();
        }
        #endregion

        private void buttonAddVilles_Click(object sender, EventArgs e)
        {
            Form Ville = new FormVilles();
            if (Ville.ShowDialog() == DialogResult.OK)
            {
                loadVilles();
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            int prix = -1;
            int surfHab = -1;
            int surfJard = -1;
            List<Ville> villes = new List<Ville>();
            Client client = null;
            if (checkBoxBudgetMax.Checked)
                prix = int.Parse(textBoxRechBienPrix.Text);
            if (checkBoxSurfHab.Checked)
                surfHab = int.Parse(textBoxRechBienSurf.Text);
            if (checkBoxJardin.Checked)
                surfJard = int.Parse(textBoxRechBienJardin.Text);
            if (checkBoxVille.Checked)
                villes.Add((Ville)comboBoxVilles.SelectedItem);

            Souhait souhait = new Souhait(prix, surfHab, surfJard, villes, client);
            List<Souhait> blargh = SqlDataProvider.RechercherListeSouhaits(souhait);
            ((FenetrePrincipale)this.Parent).MdiChild = new UCAfficherSouhaits(blargh);
            ((FenetrePrincipale)this.Parent).init();
            this.Dispose();
        }
    }
}
