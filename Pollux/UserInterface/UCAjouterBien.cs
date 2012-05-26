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
    public partial class UCAjouterBien : UserControl
    {
        private Client client;

        public UCAjouterBien()
        {
            InitializeComponent();
            loadClients();
            loadVilles();
            buttonAjouter.Enabled = false;
            InitialisationParametres();
        }

        public UCAjouterBien(Client c)
        {
            client = c;
            InitializeComponent();
            loadVilles();
            // Chargement comboBox propriétaire avec ce client
            comboBoxProprietaire.Items.Clear();
            comboBoxProprietaire.Items.Add(client);
            comboBoxProprietaire.SelectedItem = client;
            comboBoxProprietaire.Enabled = false;
            buttonAjouter.Enabled = false;
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
        private void loadClients()
        {
            List<Client> listeClient = SqlDataProvider.GetListeClients();
            comboBoxProprietaire.DataSource = listeClient;
        }
        private void loadVilles()
        {
            List<Ville> listeVilles = SqlDataProvider.GetListeVilles();
            comboBoxVille.DataSource = listeVilles;
        }
        #endregion

        #region Trackbars
        private void trackBarBudget_Scroll(object sender, EventArgs e)
        {
            numericUpDownBudget.Value = trackBarBudget.Value;
        }

        private void trackBarSurfHab_Scroll(object sender, EventArgs e)
        {
            numericUpDownSurfHab.Value = trackBarSurfHab.Value;
        }

        private void trackBarSurfJard_Scroll(object sender, EventArgs e)
        {
            numericUpDownSurfJard.Value = trackBarSurfJard.Value;
        } 
        #endregion

        #region numericUpDowns
        private void numericUpDownBudget_ValueChanged(object sender, EventArgs e)
        {
            trackBarBudget.Value = (int)numericUpDownBudget.Value;
            activationBoutonCreer();
        }

        private void numericUpDownSurfHab_ValueChanged(object sender, EventArgs e)
        {
            trackBarSurfHab.Value = (int)numericUpDownSurfHab.Value;
            activationBoutonCreer();
        }

        private void numericUpDownSurfJard_ValueChanged(object sender, EventArgs e)
        {
            trackBarSurfJard.Value = (int)numericUpDownSurfJard.Value;
            activationBoutonCreer();
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
        
        private void buttonAjoutVille_Click(object sender, EventArgs e)
        {
            Form Ville = new FormVilles();
            if (Ville.ShowDialog() == DialogResult.OK)
            {
                loadVilles();
            }
        }


        // A FINIR
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            // Récupération des infos
            int prix = (int)numericUpDownBudget.Value;
            int surfHab = (int)numericUpDownSurfHab.Value;
            int surfJard = (int)numericUpDownSurfJard.Value;
            DateTime date = dateMiseEnVente.Value;
            Ville ville = (Ville)comboBoxVille.SelectedItem;
            // Ajout en base du bien
            if (comboBoxProprietaire.Enabled)
            {
                Client proprietaire = (Client)comboBoxProprietaire.SelectedItem;
                Bien bien = new Bien(prix, date, surfHab, surfJard, ville, proprietaire);
                if (SqlDataProvider.AjouterBien(bien))
                {
                    MessageBox.Show("Ajout du bien effectué", "Opération réussie");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Ajout du bien non effectué", "Echec");
                }
            }
            else
            {
                Bien bien = new Bien(prix, date, surfHab, surfJard, ville, client);
                if (SqlDataProvider.AjouterBienEtClient(client, bien))
                {
                        MessageBox.Show("Ajout du bien et du client effectué", "Opération réussie");
                        this.Dispose();
                }
                else
                {
                    MessageBox.Show("Echec de l'ajout du Bien\net du client.", "Opération échouée");
                    this.Dispose();
                }
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void activationBoutonCreer()
        {
            //pas de contrôle sur la taille du jardin : elle peut être à 0.
            if (numericUpDownBudget.Value != 0 &&
                numericUpDownSurfHab.Value != 0)
                buttonAjouter.Enabled = true;
            else
                buttonAjouter.Enabled = false;
        }

    }
}
