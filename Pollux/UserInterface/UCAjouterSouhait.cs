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
    public partial class UCAjouterSouhait : UserControl
    {
        public UCAjouterSouhait()
        {
            InitializeComponent();
            loadClients();
            loadAgents();
            loadVilles();
            buttonAjouter.Enabled = false;
        }
        public UCAjouterSouhait(Client client, bool clientExiste)
        {
            InitializeComponent();
            loadVilles();
            // Chargement comboBox propriétaire avec ce client
            comboBoxAcheteur.Items.Clear();
            comboBoxAcheteur.Items.Add(client);
            comboBoxAcheteur.SelectedItem = client;
            comboBoxAcheteur.Enabled = false;
            if (client.Agent != null)
                comboBoxAgent.SelectedItem = client.Agent;
            else
                comboBoxAgent.SelectedIndex = -1; 
            buttonAjouter.Enabled = false;
        }
        #region Chargement des comboBox
        private void loadAgents()
        {
            comboBoxAgent.Items.Clear();
            List<Agent> listeAgents = SqlDataProvider.GetListeAgents();
            comboBoxAgent.DataSource = listeAgents;
        }
        private void loadClients()
        {
            comboBoxAcheteur.Items.Clear();
            List<Client> listeClient = SqlDataProvider.GetListeClients();
            comboBoxAcheteur.DataSource = listeClient;
        }
        private void loadVilles()
        {
            listBoxVilles.Items.Clear();
            List<Ville> listeVilles = SqlDataProvider.GetListeVilles();
            foreach (Ville ville in listeVilles)
            {
                listBoxVilles.Items.Add(ville);
            }
        }
        #endregion

        #region TrackBars
        private void trackBarAjoutSouhaitsBudget_Scroll(object sender, EventArgs e)
        {
            textBoxAjoutSouhaitsBudget.Text = trackBarAjoutSouhaitsBudget.Value.ToString();
        }

        private void trackBarAjoutSouhaitSurfHab_Scroll(object sender, EventArgs e)
        {
            textBoxAjoutSouhaitSurfHab.Text = trackBarAjoutSouhaitSurfHab.Value.ToString();
        }

        private void trackBarAjoutSouhaitJardin_Scroll(object sender, EventArgs e)
        {
            textBoxAjoutSouhaitJardin.Text = trackBarAjoutSouhaitJardin.Value.ToString();
        }
        #endregion

        #region Zones de texte
        private void textBoxAjoutSouhaitsBudget_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxAjoutSouhaitsBudget.Text))
            {
                try
                {
                    trackBarAjoutSouhaitsBudget.Value = int.Parse(textBoxAjoutSouhaitsBudget.Text);
                    checkBoxBudgetMax.Checked = true;
                }
                catch (Exception)
                {
                    textBoxAjoutSouhaitsBudget.Text = string.Empty;
                    trackBarAjoutSouhaitsBudget.Value = 0;
                    MessageBox.Show(string.Format("Valeur non valide \ndoit être comprise entre {0} et {1}.",
                        trackBarAjoutSouhaitsBudget.Minimum,trackBarAjoutSouhaitsBudget.Maximum), "Attention");
                }
            }
            else
                checkBoxBudgetMax.Checked = false;
        }
        private void textBoxAjoutSouhaitSurfHab_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxAjoutSouhaitSurfHab.Text))
            {
                try
                {
                    trackBarAjoutSouhaitSurfHab.Value = int.Parse(textBoxAjoutSouhaitSurfHab.Text);
                    checkBoxSurfHab.Checked = true;
                }
                catch (Exception)
                {
                    textBoxAjoutSouhaitSurfHab.Text = string.Empty;
                    trackBarAjoutSouhaitSurfHab.Value = 0;
                    MessageBox.Show(string.Format("Valeur non valide \ndoit être comprise entre {0} et {1}.",
                        trackBarAjoutSouhaitSurfHab.Minimum, trackBarAjoutSouhaitSurfHab.Maximum), "Attention");
                }
            }
            else
                checkBoxSurfHab.Checked = false;
        }
        private void textBoxAjoutSouhaitJardin_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxAjoutSouhaitJardin.Text))
            {
                try
                {
                    trackBarAjoutSouhaitJardin.Value = int.Parse(textBoxAjoutSouhaitJardin.Text);
                    checkBoxJardin.Checked = true;
                }
                catch (Exception)
                {
                    textBoxAjoutSouhaitJardin.Text = string.Empty;
                    trackBarAjoutSouhaitJardin.Value = 0;
                    MessageBox.Show(string.Format("Valeur non valide \ndoit être comprise entre {0} et {1}.", 
                        trackBarAjoutSouhaitJardin.Minimum, trackBarAjoutSouhaitJardin.Maximum), "Attention");
                }
            }
            else
                checkBoxJardin.Checked = false;
        }
        #endregion

        #region Activation bouton Ajouter
        private void activationBoutonCreer()
        {
            if (comboBoxAcheteur.SelectedItem != null &&
                (checkBoxBudgetMax.Checked ||
                 checkBoxSurfHab.Checked ||
                 checkBoxJardin.Checked ||
                 checkBoxVilles.Checked))
                buttonAjouter.Enabled = true;
            else
                buttonAjouter.Enabled = false;
        }
        private void comboBoxAcheteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            activationBoutonCreer();
            if (((Client)comboBoxAcheteur.SelectedItem).Agent != null)
            {
                int i = 0;
                foreach (Agent agent in comboBoxAgent.Items)
                {
                    if (agent.Prenom == ((Client)comboBoxAcheteur.SelectedItem).Agent.Prenom)
                    {
                        comboBoxAgent.SelectedIndex = i;
                        comboBoxAgent.Enabled = false;
                        break;
                    }
                    i++;
                }
            }
            else
            {
                comboBoxAgent.SelectedIndex = -1;
                comboBoxAgent.Enabled = true;
            }
        }
        private void checkBoxBudgetMax_CheckedChanged(object sender, EventArgs e)
        {
            activationBoutonCreer();
            // si coche la case, on fixe le budget a son maximum
            if (checkBoxBudgetMax.Checked == true)
                textBoxAjoutSouhaitsBudget.Text = trackBarAjoutSouhaitsBudget.Maximum.ToString();
            else // si décoche la case, on remet à zéro
            {
                textBoxAjoutSouhaitsBudget.Text = string.Empty;
                trackBarAjoutSouhaitsBudget.Value = 0;
            }
        }
        private void checkBoxSurfHab_CheckedChanged(object sender, EventArgs e)
        {
            activationBoutonCreer();
            // si coche la case, on fixe la surf Hab à son minimum
            if (checkBoxSurfHab.Checked == true)
                textBoxAjoutSouhaitSurfHab.Text = trackBarAjoutSouhaitSurfHab.Minimum.ToString();
            else // si décoche la case, on remet à zéro
            {
                textBoxAjoutSouhaitSurfHab.Text = string.Empty;
                trackBarAjoutSouhaitSurfHab.Value = 0;
            }
        }
        private void checkBoxJardin_CheckedChanged(object sender, EventArgs e)
        {
            activationBoutonCreer();
            // si coche la case, on fixe la surf du jardin à son minimum
            if (checkBoxJardin.Checked == true)
                textBoxAjoutSouhaitJardin.Text = trackBarAjoutSouhaitJardin.Minimum.ToString();
            else // si décoche la case, on remet à zéro
            {
                textBoxAjoutSouhaitJardin.Text = string.Empty;
                trackBarAjoutSouhaitJardin.Value = 0;
            }
        }
        private void checkBoxVilles_CheckedChanged(object sender, EventArgs e)
        {
            activationBoutonCreer();
            // si décoche la case, la sélection supprimée
            if (checkBoxVilles.Checked == false)
                listBoxVilles.SelectedItems.Clear();
            // si coche la case, toutes les villes sont sélectionnée
            else if (listBoxVilles.SelectedItems.Count == 0)
            {
                for (int i = 0; i < listBoxVilles.Items.Count; i++)
                    listBoxVilles.SelectedItems.Add(listBoxVilles.Items[i]);
            }
        }
        private void listBoxVilles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxVilles.SelectedItem != null)
                checkBoxVilles.Checked = true;
            else
                checkBoxVilles.Checked = false;
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


        // A FINIR
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            // Récupération des infos
            int prix = -1;
            int surfHab = -1;
            int surfJard = -1;
            List<Ville> villes = null;
            if (checkBoxBudgetMax.Checked)
                prix = int.Parse(textBoxAjoutSouhaitsBudget.Text);
            if (checkBoxSurfHab.Checked)
                surfHab = int.Parse(textBoxAjoutSouhaitSurfHab.Text);
            if (checkBoxJardin.Checked)
                surfJard = int.Parse(textBoxAjoutSouhaitJardin.Text);
            if (checkBoxVilles.Checked)
                villes = listBoxVilles.SelectedItems.Cast<Ville>().ToList();
            // Ajout en base du souhait
            Client acheteur = (Client)comboBoxAcheteur.SelectedItem;
            Souhait souhait = new Souhait(prix, surfHab, surfJard, villes, acheteur);       
            if (comboBoxAcheteur.Enabled)  // client déjà présent en base
            {
                if (SqlDataProvider.AjouterSouhait(souhait))
                {
                    MessageBox.Show("Ajout du souhait effectué", "Opération réussie");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Ajout du souhait non effectué", "Echec");
                }
            }
            else  // client non présent en base : ajout souhait et client
            {
                if (SqlDataProvider.AjouterSouhaitEtClient(acheteur, souhait))
                {
                    MessageBox.Show("Ajout du souhait et du client effectué", "Opération réussie");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Echec de l'ajout du souhait\net du client.", "Opération échouée");
                    this.Dispose();
                }
            }
        }

    }
}
