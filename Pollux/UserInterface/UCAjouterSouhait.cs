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
using System.Configuration;

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
            listBoxVilles.SelectedItem = null;
            buttonAjouter.Enabled = false;
            disableNumericUpDowns();
            InitialisationParametres();
        }
        public UCAjouterSouhait(Client client)
        {
            InitializeComponent();
            loadVilles();
            loadAgents();
            // Chargement comboBox propriétaire avec ce client
            comboBoxAcheteur.Items.Clear();
            comboBoxAcheteur.Items.Add(client);
            comboBoxAcheteur.SelectedItem = client;
            comboBoxAcheteur.Enabled = false;
            if (client.Agent != null)
            {
                comboBoxAgent.SelectedItem = client.Agent;
                comboBoxAgent.Enabled = false;
            }
            else
                comboBoxAgent.SelectedIndex = -1;
            buttonAjouter.Enabled = false;
            disableNumericUpDowns();
            InitialisationParametres();
        }

        private void InitialisationParametres()
        {
            // Budget
            trackBarBudget.Maximum = Convert.ToInt32(ConfigurationManager.AppSettings["MaxBudget"]);
            trackBarBudget.Minimum = Convert.ToInt32(ConfigurationManager.AppSettings["MinBudget"]);
            trackBarBudget.LargeChange = Convert.ToInt32(ConfigurationManager.AppSettings["PasBudget"]);
            numericUpDownBudget.Maximum = Convert.ToDecimal(ConfigurationManager.AppSettings["MaxBudget"]);
            numericUpDownBudget.Minimum = Convert.ToDecimal(ConfigurationManager.AppSettings["MinBudget"]);
            numericUpDownBudget.Increment = Convert.ToDecimal(ConfigurationManager.AppSettings["PasBudget"]);
            // Surface Habitable
            trackBarSurfHab.Maximum = Convert.ToInt32(ConfigurationManager.AppSettings["MaxSurfHab"]);
            trackBarSurfHab.Minimum = Convert.ToInt32(ConfigurationManager.AppSettings["MinSurfHab"]);
            trackBarSurfHab.LargeChange = Convert.ToInt32(ConfigurationManager.AppSettings["PasSurfHab"]);
            numericUpDownSurfHab.Maximum = Convert.ToDecimal(ConfigurationManager.AppSettings["MaxSurfHab"]);
            numericUpDownSurfHab.Minimum = Convert.ToDecimal(ConfigurationManager.AppSettings["MinSurfHab"]);
            numericUpDownSurfHab.Increment = Convert.ToDecimal(ConfigurationManager.AppSettings["PasSurfHab"]);
            //Surface Jardin
            trackBarSurfJard.Maximum = Convert.ToInt32(ConfigurationManager.AppSettings["MaxSurfJard"]);
            trackBarSurfJard.Minimum = Convert.ToInt32(ConfigurationManager.AppSettings["MinSurfJard"]);
            trackBarSurfJard.LargeChange = Convert.ToInt32(ConfigurationManager.AppSettings["PasSurfJard"]);
            numericUpDownSurfJard.Maximum = Convert.ToDecimal(ConfigurationManager.AppSettings["MaxSurfJard"]);
            numericUpDownSurfJard.Minimum = Convert.ToDecimal(ConfigurationManager.AppSettings["MinSurfJard"]);
            numericUpDownSurfJard.Increment = Convert.ToDecimal(ConfigurationManager.AppSettings["PasSurfJard"]);
        }

        #region Chargement des comboBox
        private void loadAgents()
        {
            List<Agent> listeAgents = SqlDataProvider.GetListeAgents();
            comboBoxAgent.DataSource = listeAgents;
            comboBoxAgent.SelectedIndex = -1;    
        }
        private void loadClients()
        {
            List<Client> listeClient = SqlDataProvider.GetListeClients();
            comboBoxAcheteur.DataSource = listeClient;
            comboBoxAcheteur.SelectedIndex = -1;
        }
        private void loadVilles()
        {
            List<Ville> listeVilles = SqlDataProvider.GetListeVilles();
            listBoxVilles.DataSource = listeVilles;
            listBoxVilles.SelectedIndex = -1;
        }
        #endregion

        #region TrackBars
        private void trackBarBudget_Scroll(object sender, EventArgs e)
        {
            numericUpDownBudget.Value = trackBarBudget.Value;
            checkBoxBudgetMax.Checked = true;
        }

        private void trackBarSurfHab_Scroll(object sender, EventArgs e)
        {
            numericUpDownSurfHab.Value = trackBarSurfHab.Value;
            checkBoxSurfHab.Checked = true;
        }

        private void trackBarSurfJard_Scroll(object sender, EventArgs e)
        {
            numericUpDownSurfJard.Value = trackBarSurfJard.Value;
            checkBoxJardin.Checked = true;
        }
        #endregion

        #region numericUpDown
        private void numericUpDownBudget_ValueChanged(object sender, EventArgs e)
        {
            trackBarBudget.Value = (int)numericUpDownBudget.Value;
        }

        private void numericUpDownSurfHab_ValueChanged(object sender, EventArgs e)
        {
            trackBarSurfHab.Value = (int)numericUpDownSurfHab.Value;
        }

        private void numericUpDownSurfJard_ValueChanged(object sender, EventArgs e)
        {
            trackBarSurfJard.Value = (int)numericUpDownSurfJard.Value;
        }
        private void numericUpDownBudget_KeyUp(object sender, KeyEventArgs e)
        {
            trackBarBudget.Value = (int)numericUpDownBudget.Value;
        }

        private void numericUpDownSurfHab_KeyUp(object sender, KeyEventArgs e)
        {
            trackBarSurfHab.Value = (int)numericUpDownSurfHab.Value;
        }

        private void numericUpDownSurfJard_KeyUp(object sender, KeyEventArgs e)
        {
            trackBarSurfJard.Value = (int)numericUpDownSurfJard.Value;
        }
        #endregion

        #region Activation bouton Ajouter
        private void activationBoutonCreer()
        {
            if (comboBoxAcheteur.SelectedItem != null &&
                comboBoxAgent.SelectedIndex != -1 &&
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
            if (comboBoxAcheteur.SelectedIndex != -1 && ((Client)comboBoxAcheteur.SelectedItem).Agent != null)
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

        private void comboBoxAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            activationBoutonCreer();
        }

        private void checkBoxBudgetMax_CheckedChanged(object sender, EventArgs e)
        {
            activationBoutonCreer();
            // si coche la case, on fixe le budget a son maximum
            if (checkBoxBudgetMax.Checked)
            {
                numericUpDownBudget.Value = trackBarBudget.Maximum;
                numericUpDownBudget.Enabled = true;
            }
            else // si décoche la case, on remet à zéro
            {
                numericUpDownBudget.Value = 0;
                trackBarBudget.Value = 0;
                numericUpDownBudget.Enabled = false;
            }
        }
        private void checkBoxSurfHab_CheckedChanged(object sender, EventArgs e)
        {
            activationBoutonCreer();
            // si coche la case, on fixe la surf Hab à son minimum
            if (checkBoxSurfHab.Checked)
            {
                numericUpDownSurfHab.Value = trackBarSurfHab.Minimum;
                numericUpDownSurfHab.Enabled = true;
            }
            else // si décoche la case, on remet à zéro
            {
                numericUpDownSurfHab.Value = 0;
                trackBarSurfHab.Value = 0;
                numericUpDownSurfHab.Enabled = false;
            }
        }
        private void checkBoxJardin_CheckedChanged(object sender, EventArgs e)
        {
            activationBoutonCreer();
            // si coche la case, on fixe la surf du jardin à son minimum
            if (checkBoxJardin.Checked)
            {
                numericUpDownSurfJard.Value = trackBarSurfJard.Minimum;
                numericUpDownSurfJard.Enabled = true;
            }
            else // si décoche la case, on remet à zéro
            {
                numericUpDownSurfJard.Value = 0;
                trackBarSurfJard.Value = 0;
                numericUpDownSurfJard.Enabled = false;
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
        
        private void disableNumericUpDowns()
        {
            numericUpDownBudget.Enabled = false;
            numericUpDownSurfHab.Enabled = false;
            numericUpDownSurfJard.Enabled = false;
        }

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

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            //valeurs par défaut
            int prix = -1;
            int surfHab = -1;
            int surfJard = -1;
            // Récupération des infos
            List<Ville> villes = null;
            if (checkBoxBudgetMax.Checked)
                prix = (int)numericUpDownBudget.Value;
            if (checkBoxSurfHab.Checked)
                surfHab = (int)numericUpDownSurfHab.Value;
            if (checkBoxJardin.Checked)
                surfJard = (int)numericUpDownSurfJard.Value;
            if (checkBoxVilles.Checked)
                villes = listBoxVilles.SelectedItems.Cast<Ville>().ToList();
            // Ajout en base du souhait
            Client acheteur = (Client)comboBoxAcheteur.SelectedItem;
            Souhait souhait = new Souhait(prix, surfHab, surfJard, villes, acheteur);       
            if (comboBoxAcheteur.Enabled)  // client déjà présent en base + agent selectionné
            {
                if (SqlDataProvider.AjouterSouhait(souhait, (Agent)comboBoxAgent.SelectedItem))
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
                if (SqlDataProvider.AjouterSouhaitEtClient(souhait, acheteur))
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
