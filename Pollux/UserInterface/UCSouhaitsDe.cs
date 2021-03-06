﻿using System;
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
            buttonRechercher.Enabled = false;
        }
        /// <summary>
        /// Constructeur en venant de la liste de clients
        /// </summary>
        /// <param name="client">Client qui a été selectionné</param>
        public UCSouhaitsDe(Client client)
        {
            InitializeComponent();
            comboBoxClients.Items.Add(client);
            comboBoxClients.SelectedItem = client;
            comboBoxClients.Enabled = false;
            buttonRechercher.Enabled = false;
        }

        #region Chargement des comboBox
        private void loadClients()
        {
            comboBoxClients.Items.Clear();
            List<Client> listeClient = SqlDataProvider.GetListeAcheteurs();
            comboBoxClients.DataSource = listeClient;
        }
        #endregion

        #region Activation bouton Rechercher les correspondances
        private void listViewSouhaits_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (listViewSouhaits.SelectedItems.Count != 0)
                buttonRechercher.Enabled = true;
            else
                buttonRechercher.Enabled = false;
        }

        private void comboBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewSouhaits.Items.Clear();
            buttonRechercher.Enabled = false;
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
        #endregion

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Appel de la fenetre affichant les biens correspondant au souhait sélectionné
        /// </summary>
        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            Souhait souhait = (Souhait)listViewSouhaits.SelectedItems[0].Tag;
            ((FenetrePrincipale)this.Parent).MdiChild = new UCAfficherBiens(souhait);
            ((FenetrePrincipale)this.Parent).init();
            this.Dispose();
        }
    }
}

