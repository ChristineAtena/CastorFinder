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
    public partial class UCAjouterBien : UserControl, InterfaceFenetre
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
            // pas besoin de rechercher son index on le connait déjà
            //client.Index = SqlDataProvider.trouverClient(client.Nom, client.Adresse);
            buttonAjouter.Enabled = false;
        }
        #region Chargement des comboBox
        private void loadClients()
        {
            comboBoxProprietaire.Items.Clear();
            List<Client> listeClient = SqlDataProvider.GetListeClients();
            foreach (Client proprietaire in listeClient)
            {
                comboBoxProprietaire.Items.Add(proprietaire);
            }
        }
        private void loadVilles()
        {
            comboBoxVille.Items.Clear();
            List<Ville> listeVilles = SqlDataProvider.GetListeVilles();
            foreach (Ville ville in listeVilles)
            {
                comboBoxVille.Items.Add(ville);
            }
        }
        #endregion

        #region Trackbars
        private void trackBarAjoutBienPrix_Scroll(object sender, EventArgs e)
        {
            textBoxAjoutBienPrix.Text = trackBarAjoutBienPrix.Value.ToString();
        }

        private void trackBarAjoutBienSurfHab_Scroll(object sender, EventArgs e)
        {
            textBoxAjoutBienSurfHab.Text = trackBarAjoutBienSurfHab.Value.ToString();
        }

        private void trackBarAjoutBienJardin_Scroll(object sender, EventArgs e)
        {
            textBoxAjoutBienJardin.Text = trackBarAjoutBienJardin.Value.ToString();
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
            int prix = int.Parse(textBoxAjoutBienPrix.Text);
            int surfHab = int.Parse(textBoxAjoutBienSurfHab.Text);
            int surfJard = int.Parse(textBoxAjoutBienJardin.Text);
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
                if (SqlDataProvider.ajouterBienEtClient(client, bien))
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

        #region Activation bouton Créer
        private void activationBoutonCreer()
        {
            if (textBoxAjoutBienPrix.Text != "" &&
                textBoxAjoutBienSurfHab.Text != "" &&
                textBoxAjoutBienJardin.Text != "" &&
                comboBoxVille.SelectedItem != null &&
                comboBoxProprietaire.SelectedItem != null)
                buttonAjouter.Enabled = true;
            else
                buttonAjouter.Enabled = false;
        }
        private void comboBoxProprietaire_SelectedIndexChanged(object sender, EventArgs e)
        {
            activationBoutonCreer();
        }
        private void textBoxAjoutBienPrix_TextChanged(object sender, EventArgs e)
        {
            activationBoutonCreer();
        }
        private void textBoxAjoutBienSurfHab_TextChanged(object sender, EventArgs e)
        {
            activationBoutonCreer();
        }
        private void textBoxAjoutBienJardin_TextChanged(object sender, EventArgs e)
        {
            activationBoutonCreer();
        }
        private void comboBoxVille_SelectedIndexChanged(object sender, EventArgs e)
        {
            activationBoutonCreer();
        }
        #endregion


    }
}
