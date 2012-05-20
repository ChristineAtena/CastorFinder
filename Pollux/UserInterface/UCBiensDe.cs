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
    public partial class UCBiensDe : UserControl
    {
        public UCBiensDe()
        {
            InitializeComponent();
            loadClients();
            buttonRechercher.Enabled = false;
        }
        #region Chargement des comboBox
        private void loadClients()
        {
            comboBoxClients.Items.Clear();
            List<Client> listeClient = SqlDataProvider.GetListeVendeurs();
            foreach (Client client in listeClient)
            {
                comboBoxClients.Items.Add(client);
            }
        }
        #endregion

        #region Activation bouton Rechercher les correspondances
        private void listViewBiens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBiens.SelectedItems.Count != 0)
                buttonRechercher.Enabled = true;
            else 
                buttonRechercher.Enabled = false;
        }

        private void comboBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewBiens.Items.Clear();
            buttonRechercher.Enabled = false;
        }
        #endregion

        /// <summary>
        /// Affichage dans la listView des biens correspondant au client sélectionné
        /// </summary>
        private void buttonAfficher_Click(object sender, EventArgs e)
        {
            string prix;
            string surfHab;
            string surfJard;
            string ville;
            string date;
            listViewBiens.Items.Clear();
            if (comboBoxClients.SelectedItem != null)
            {
                List<Bien> listeBiens = SqlDataProvider.GetListeBiens((Client)comboBoxClients.SelectedItem);
                foreach (Bien bien in listeBiens)
                {
                    ville = bien.Ville.Nom;
                    prix = bien.Prix.ToString() + " €";
                    surfHab = bien.SurfaceHabitable.ToString() + " m²";
                    surfJard = bien.SurfaceJardin.ToString() + " m²";
                    date = bien.DateMiseEnVente.ToShortDateString();
                    ListViewItem item = new ListViewItem(new String[] { prix, surfHab, surfJard, ville, date });
                    item.Tag = bien;
                    listViewBiens.Items.Add(item);
                }
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Appel de la fenetre affichant les souhaits correspondant au bien sélectionné
        /// </summary>
        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            Bien bien = (Bien)listViewBiens.SelectedItems[0].Tag;
            ((FenetrePrincipale)this.Parent).MdiChild = new UCAfficherSouhaits(bien);
            ((FenetrePrincipale)this.Parent).init();
            this.Dispose();
        }


    }
}
