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
    public partial class UCAjouterClient : UserControl
    {
       
        public UCAjouterClient()
        {
            InitializeComponent();
            loadAgents();
            loadVilles();
            comboBoxAgents.SelectedIndex = 0;
        }

        #region Chargement des comboBox
        private void loadAgents()
        {
            comboBoxAgents.Items.Clear();
            List<Agent> listeAgents = SqlDataProvider.GetListeAgents();
            foreach (Agent agent in listeAgents)
            {
                comboBoxAgents.Items.Add(agent);
            }
        }
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

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // TEST pas au point pour la création
        // A FINIR
        private void buttonCreer_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text != "" && textBoxAdresse.Text != "" && textBoxTelephone.Text != "" && comboBoxVilles.SelectedItem != null)
            {
                Client client = SqlDataProvider.ClientExiste(textBoxNom.Text, (Ville)comboBoxVilles.SelectedItem);
                // si client existe, on bascule directement sur UCAjouterBien avec ce client
                if (client != null)
                {
                    // limite rajouter un truc pour choisir entre continuer ou modifier les infos client saisies ?
                    MessageBox.Show("Attention, ce client existe déjà.", "Alerte", MessageBoxButtons.YesNoCancel);
                }
                else
                {
                    client = new Client(textBoxNom.Text, textBoxAdresse.Text, textBoxTelephone.Text, ((Ville)comboBoxVilles.SelectedItem).Index);
                }

                if (radioButtonBien.Checked)
                {
                    this.Hide();
                    UserControl ajouterBien = new UCAjouterBien(client);
                    ajouterBien.Parent = Application.OpenForms["FenetrePrincipale"];
                    ajouterBien.Dock = DockStyle.Fill;
                    ajouterBien.Show();
                }
                else
                {
                    // vérification si ce client a déjà un agent assigné dans le cas où il existe déjà
                    client.Agent = (Agent)comboBoxAgents.SelectedItem;

                    this.Hide();
                    UserControl ajouterSouhait = new UCAjouterSouhait(client);
                    ajouterSouhait.Parent = Application.OpenForms["FenetrePrincipale"];
                    ajouterSouhait.Dock = DockStyle.Fill;
                    ajouterSouhait.Show();
                }
            }
        }
        
         


        private void buttonAjoutVille_Click(object sender, EventArgs e)
        {
            Form Ville = new FormVilles();
            if (Ville.ShowDialog() == DialogResult.OK)
            {
                loadVilles();
            }
        }

        private void radioButtonSouhait_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSouhait.Checked)
            {
                comboBoxAgents.Enabled = true;
            }
            else
            {
                comboBoxAgents.Enabled = false;
            }
        }

        #region Activation bouton Créer
        private void activationBoutonCreer()
        {
            if (textBoxNom.Text != "" && textBoxAdresse.Text != "" && textBoxTelephone.Text != "" && comboBoxVilles.SelectedItem != null)
                buttonCreer.Enabled = true;
            else
                buttonCreer.Enabled = false;
        }
        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            activationBoutonCreer();
        }
        private void textBoxAdresse_TextChanged(object sender, EventArgs e)
        {
            activationBoutonCreer();
        }
        private void comboBoxVilles_SelectedIndexChanged(object sender, EventArgs e)
        {
            activationBoutonCreer();
        }
        private void textBoxTelephone_TextChanged(object sender, EventArgs e)
        {
            activationBoutonCreer();
        }
        #endregion
    }
}
