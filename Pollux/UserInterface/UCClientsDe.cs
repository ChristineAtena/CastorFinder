using System;
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
        }
        #region Chargement des comboBox
        private void loadAgents()
        {
            List<Agent> listeAgents = SqlDataProvider.GetListeAgents();
            foreach (Agent agent in listeAgents)
            {
                comboBoxAgents.Items.Add(agent);
            }
        }
        #endregion

        private void buttonAfficher_Click(object sender, EventArgs e)
        {
            listBoxClients.Items.Clear();
            if (comboBoxAgents.SelectedItem != null)
            {
                List<Client> listeClients = SqlDataProvider.GetListeClients((Agent)comboBoxAgents.SelectedItem);
                foreach (Client c in listeClients)
                {
                    listBoxClients.Items.Add(c);
                }
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            // TODO affichage de la fenetre d'ajout d'une visite


        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
    }
}
