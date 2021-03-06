﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Pollux.DataBase;
using Pollux.Object;

namespace Pollux.UserInterface
{
    public partial class UCClientsDe : UserControl
    {
        public UCClientsDe()
        {
            InitializeComponent();
            loadAgents();
            buttonAfficherSouhaits.Enabled = false;
        }
        #region Chargement des comboBox
        private void loadAgents()
        {
            List<Agent> listeAgents = SqlDataProvider.GetListeAgents();
            comboBoxAgents.DataSource = listeAgents;
        }
        #endregion

        #region Activation boutons Afficher et Afficher souhaits
        private void comboBoxAgents_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxClients.Items.Clear();
            buttonAfficherSouhaits.Enabled = false;
            listBoxClients.Items.Clear();
            List<Client> listeClients = SqlDataProvider.GetListeClients((Agent)comboBoxAgents.SelectedItem);
            foreach (Client c in listeClients)
            {
                listBoxClients.Items.Add(c);
            }
        }

        private void listBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxClients.SelectedItem != null)
                buttonAfficherSouhaits.Enabled = true;
        }
        #endregion


        /// <summary>
        /// Appel de la fenetre affichant les souhaits du client sélectionné
        /// </summary>
        private void buttonAfficherSouhaits_Click(object sender, EventArgs e)
        {
            if (listBoxClients.SelectedItem != null)
            {
                Client client = (Client)listBoxClients.SelectedItem;
                ((FenetrePrincipale)this.Parent).MdiChild = new UCSouhaitsDe(client);
                ((FenetrePrincipale)this.Parent).init();
                this.Dispose();
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
