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
    public partial class UCAjouterBien : UserControl
    {
        private Client client;  // UTILE ?? pas l'impression
        public UCAjouterBien()
        {
            InitializeComponent();
            loadClients();
            loadVilles();
            buttonAjouter.Enabled = false;
        }
        public UCAjouterBien(Client c, bool clientExiste)
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
        }
        #region Chargement des comboBox
        private void loadClients()
        {
            comboBoxProprietaire.Items.Clear();
            List<Client> listeClient = SqlDataProvider.GetListeClients();
            comboBoxProprietaire.DataSource = listeClient;
        }
        private void loadVilles()
        {
            comboBoxVille.Items.Clear();
            List<Ville> listeVilles = SqlDataProvider.GetListeVilles();
            /*
            foreach (Ville ville in listeVilles)
            {
                comboBoxVille.Items.Add(ville);
            }
            */
            comboBoxVille.DataSource = listeVilles;
        }
        #endregion

        #region Trackbars
        private void trackBarAjoutBienPrix_Scroll(object sender, EventArgs e)
        {
            numericUpDownBudget.Value = trackBarAjoutBienPrix.Value;
        }

        private void trackBarAjoutBienSurfHab_Scroll(object sender, EventArgs e)
        {
            numericUpDownSurfHab.Value = trackBarAjoutBienSurfHab.Value;
        }

        private void trackBarAjoutBienJardin_Scroll(object sender, EventArgs e)
        {
            numericUpDownSurfJard.Value = trackBarAjoutBienJardin.Value;
        } 
        #endregion

        #region numericUpDowns
        private void numericUpDownBudget_ValueChanged(object sender, EventArgs e)
        {
            trackBarAjoutBienPrix.Value = (int)numericUpDownBudget.Value;
            activationBoutonCreer();
        }

        private void numericUpDownSurfHab_ValueChanged(object sender, EventArgs e)
        {
            trackBarAjoutBienSurfHab.Value = (int)numericUpDownSurfHab.Value;
            activationBoutonCreer();
        }

        private void numericUpDownSurfJard_ValueChanged(object sender, EventArgs e)
        {
            trackBarAjoutBienJardin.Value = (int)numericUpDownSurfJard.Value;
            activationBoutonCreer();
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
