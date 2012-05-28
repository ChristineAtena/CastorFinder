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
        }

        #region Chargement des comboBox
        private void loadAgents()
        {
            List<Agent> listeAgents = SqlDataProvider.GetListeAgents();
            comboBoxAgents.DataSource = listeAgents;
        }
        private void loadVilles()
        {
            List<Ville> listeVilles = SqlDataProvider.GetListeVilles();
            comboBoxVilles.DataSource = listeVilles;
        }
        #endregion

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonCreer_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text != "" && textBoxAdresse.Text != "" && textBoxTelephone.Text != "" && comboBoxVilles.SelectedItem != null)
            {
                Client client = SqlDataProvider.ClientExiste(textBoxNom.Text, (Ville)comboBoxVilles.SelectedItem);
                // si le client existe déjà
                if (client != null)
                {
                    MessageBox.Show("Ce client existe déjà.", "Attention", MessageBoxButtons.OK);
                    if (radioButtonBien.Checked)
                    {
                        ((FenetrePrincipale)this.Parent).MdiChild = new UCAjouterBien(client);
                        ((FenetrePrincipale)this.Parent).init();
                        this.Dispose();
                    }
                    else
                    {
                        ((FenetrePrincipale)this.Parent).MdiChild = new UCAjouterSouhait(client);
                        ((FenetrePrincipale)this.Parent).init();
                        this.Dispose();
                    }
                }
                else  // si le client n'existe pas déjà en base
                {
                    client = new Client(textBoxNom.Text, textBoxAdresse.Text, textBoxTelephone.Text, ((Ville)comboBoxVilles.SelectedItem).Index);
                    if (radioButtonBien.Checked)
                    {
                        ((FenetrePrincipale)this.Parent).MdiChild = new UCAjouterBien(client);
                        ((FenetrePrincipale)this.Parent).init();
                        this.Dispose();
                    }
                    else
                    {
                        client.Agent = (Agent)comboBoxAgents.SelectedItem;

                        ((FenetrePrincipale)this.Parent).MdiChild = new UCAjouterSouhait(client);
                        ((FenetrePrincipale)this.Parent).init();
                        this.Dispose();
                    }
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
            if (textBoxNom.Text != "" && 
                textBoxAdresse.Text != "" && 
                textBoxTelephone.Text != "" && 
                comboBoxVilles.SelectedItem != null)
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
