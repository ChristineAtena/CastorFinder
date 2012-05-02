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
        Client client;
        public UCAjouterBien()
        {
            InitializeComponent();
            loadClients();
            loadVilles();
        }
        public UCAjouterBien(Client c)
        {
            InitializeComponent();
            loadClients();
            loadVilles();
            comboBoxProprietaire.SelectedText = c.ToString(); 
            comboBoxProprietaire.Enabled = false;
            client = c;
            client.Index = SqlDataProvider.trouverClient(client.Nom, client.Adresse);
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
                    this.Hide();
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
                        this.Hide();
                }
                else
                {
                    MessageBox.Show("Echec de l'ajout du Bien\net du client.", "Opération échouée");
                    this.Hide();
                }
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
