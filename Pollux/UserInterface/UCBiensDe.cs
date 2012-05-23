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
        #region Chargement comboBox
        private void loadClients()
        {
            comboBoxClients.Items.Clear();
            List<Client> listeClient = SqlDataProvider.GetListeVendeurs();
            comboBoxClients.DataSource = listeClient;
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
        #endregion

        /// <summary>
        /// Evenement de remplissage de la liste des biens du client sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewBiens.Items.Clear();
            buttonRechercher.Enabled = false;
            string prix;
            string surfHab;
            string surfJard;
            string ville;
            string date;
            listViewBiens.Items.Clear();
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
