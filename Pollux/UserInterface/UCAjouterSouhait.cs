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
            listBoxVilles.SelectedItem = null;
            buttonAjouter.Enabled = false;
            disableNumericUpDowns();
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
            disableNumericUpDowns();
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
            listBoxVilles.DataSource = listeVilles;
        }
        #endregion

        #region TrackBars
        private void trackBarAjoutSouhaitsBudget_Scroll(object sender, EventArgs e)
        {
            numericUpDownBudget.Value = trackBarAjoutSouhaitsBudget.Value;
            checkBoxBudgetMax.Checked = true;
        }

        private void trackBarAjoutSouhaitSurfHab_Scroll(object sender, EventArgs e)
        {
            numericUpDownSurfHab.Value = trackBarAjoutSouhaitSurfHab.Value;
            checkBoxSurfHab.Checked = true;
        }

        private void trackBarAjoutSouhaitJardin_Scroll(object sender, EventArgs e)
        {
            numericUpDownSurfJard.Value = trackBarAjoutSouhaitJardin.Value;
            checkBoxJardin.Checked = true;
        }
        #endregion

        #region numericUpDown
        private void numericUpDownBudget_ValueChanged(object sender, EventArgs e)
        {
            trackBarAjoutSouhaitsBudget.Value = (int)numericUpDownBudget.Value;
        }

        private void numericUpDownSurfHab_ValueChanged(object sender, EventArgs e)
        {
            trackBarAjoutSouhaitSurfHab.Value = (int)numericUpDownSurfHab.Value;
        }

        private void numericUpDownSurfJard_ValueChanged(object sender, EventArgs e)
        {
            trackBarAjoutSouhaitJardin.Value = (int)numericUpDownSurfJard.Value;
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
            if (checkBoxBudgetMax.Checked)
            {
                numericUpDownBudget.Value = trackBarAjoutSouhaitsBudget.Maximum;
                numericUpDownBudget.Enabled = true;
            }
            else // si décoche la case, on remet à zéro
            {
                numericUpDownBudget.Value = 0;
                trackBarAjoutSouhaitsBudget.Value = 0;
                numericUpDownBudget.Enabled = false;
            }
        }
        private void checkBoxSurfHab_CheckedChanged(object sender, EventArgs e)
        {
            activationBoutonCreer();
            // si coche la case, on fixe la surf Hab à son minimum
            if (checkBoxSurfHab.Checked)
            {
                numericUpDownSurfHab.Value = trackBarAjoutSouhaitSurfHab.Minimum;
                numericUpDownSurfHab.Enabled = true;
            }
            else // si décoche la case, on remet à zéro
            {
                numericUpDownSurfHab.Value = 0;
                trackBarAjoutSouhaitSurfHab.Value = 0;
                numericUpDownSurfHab.Enabled = false;
            }
        }
        private void checkBoxJardin_CheckedChanged(object sender, EventArgs e)
        {
            activationBoutonCreer();
            // si coche la case, on fixe la surf du jardin à son minimum
            if (checkBoxJardin.Checked)
            {
                numericUpDownSurfJard.Value = trackBarAjoutSouhaitJardin.Minimum;
                numericUpDownSurfJard.Enabled = true;
            }
            else // si décoche la case, on remet à zéro
            {
                numericUpDownSurfJard.Value = 0;
                trackBarAjoutSouhaitJardin.Value = 0;
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
            if (comboBoxAcheteur.Enabled || comboBoxAgent.SelectedIndex != -1)  // client déjà présent en base + agent selectionné
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
