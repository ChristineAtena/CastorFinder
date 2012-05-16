using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pollux.Object;
using Pollux.DataBase;

namespace Pollux.UserInterface
{
    public partial class UCSouhaitsDe : UserControl
    {
        public UCSouhaitsDe()
        {
            InitializeComponent();
            loadClients();
        }

        public UCSouhaitsDe(Client client)
        {
            InitializeComponent();
            comboBoxClients.Items.Add(client);
            comboBoxClients.SelectedItem = client;
            comboBoxClients.Enabled = false;
            afficherSouhaits();
        }

        #region Chargement des comboBox
        private void loadClients()
        {
            comboBoxClients.Items.Clear();
            List<Client> listeClient = SqlDataProvider.GetListeAcheteurs();
            foreach (Client proprietaire in listeClient)
            {
                comboBoxClients.Items.Add(proprietaire);
            }
        }
        #endregion

        private void buttonAfficher_Click(object sender, EventArgs e)
        {
            afficherSouhaits();
        }

        private void afficherSouhaits()
        {
            string prix;
            string surfHab;
            string surfJard;
            string villes;
            listViewSouhaits.Items.Clear();
            if (comboBoxClients.SelectedItem != null)
            {
                List<Souhait> listeSouhaits = SqlDataProvider.GetListeSouhaits((Client)comboBoxClients.SelectedItem);
                foreach (Souhait souhait in listeSouhaits)
                {
                    villes = "";
                    foreach (Ville ville in souhait.Villes)
                        villes += ville.Nom + ", ";
                    prix = (souhait.PrixMax == -1) ? "n/c" : souhait.PrixMax.ToString() + " €";
                    surfHab = (souhait.SurfaceHabitableMin == -1) ? "n/c" : souhait.SurfaceHabitableMin.ToString() + " m²";
                    surfJard = (souhait.SurfaceJardinMin == -1) ? "n/c" : souhait.SurfaceJardinMin.ToString() + " m²";
                    ListViewItem item = new ListViewItem(new String[] { prix, surfHab, surfJard, villes });
                    item.Tag = souhait;
                    listViewSouhaits.Items.Add(item);
                }
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            Souhait souhait = (Souhait)listViewSouhaits.SelectedItems[0].Tag;
            ((FenetrePrincipale)this.Parent).MdiChild = new UCAfficherBiens(souhait);
            ((FenetrePrincipale)this.Parent).init();
            this.Dispose();
        }
    }
}

