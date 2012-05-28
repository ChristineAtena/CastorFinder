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
    public partial class UCAjouterVisite : UserControl
    {
        private Souhait souhait = null;
        private DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0).AddHours(1);
     
        public UCAjouterVisite()
        {
            InitializeComponent();
            dateTimePickerHeure.Value = dateTimePickerDate.Value = date;
            // Chargement de tous les clients acheteurs
            loadClients();
            // Chargement de tous les biens
            loadBiens();
        }

        public UCAjouterVisite(Souhait souhait)
        {
            InitializeComponent();
            dateTimePickerHeure.Value = dateTimePickerDate.Value = date;
            // Fixation du souhait et de l'acheteur concerné
            this.souhait = souhait;
            textBoxTelephone.Text = souhait.Client.Telephone;
            comboBoxClients.Items.Add(souhait.Client);
            comboBoxClients.SelectedItem = souhait.Client;
            comboBoxClients.Enabled = false;
            // Chargement de tous les biens
            loadBiens();
        }

        public UCAjouterVisite(Bien bien)
        {
            InitializeComponent();
            dateTimePickerHeure.Value = date;
            // Chargement de tous les clients acheteurs
            loadClients();
            // Fixation du bien
            comboBoxBiens.Items.Clear();
            comboBoxBiens.Items.Add(bien);
            comboBoxBiens.SelectedItem = bien;
            comboBoxBiens.Enabled = false;
        }

        public UCAjouterVisite(Souhait souhait, Bien bien)
        {
            InitializeComponent();
            dateTimePickerHeure.Value = date;
            textBoxTelephone.Text = souhait.Client.Telephone;
            // Fixation du souhait et de l'acheteur concerné
            this.souhait = souhait;
            comboBoxClients.Items.Clear();
            comboBoxClients.Items.Add(souhait.Client);
            comboBoxClients.SelectedItem = souhait.Client;
            comboBoxClients.Enabled = false;
            // Fixation du bien
            comboBoxBiens.Items.Clear();
            comboBoxBiens.Items.Add(bien);
            comboBoxBiens.SelectedItem = bien;
            comboBoxBiens.Enabled = false;
        }

        #region Chargement des comboBox
        private void loadClients()
        {
            comboBoxClients.Items.Clear();
            List<Client> listeClient = SqlDataProvider.GetListeAcheteurs();
            comboBoxClients.DataSource = listeClient;
        }
        private void loadBiens()
        {
            comboBoxBiens.Items.Clear();
            List<Bien> listeBiens = SqlDataProvider.GetListeBiens();
            comboBoxBiens.DataSource = listeBiens;
        }
        #endregion

        private void comboBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxTelephone.Text = ((Client)comboBoxClients.SelectedItem).Telephone;
            activationBoutonRDV();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Affiche une fenetre avec le calendrier de l'agent pour choisir le jour et l'heure de la visite
        /// </summary>
        private void buttonRDV_Click(object sender, EventArgs e)
        {
            TrouverRDV rdv = new TrouverRDV(((Client)comboBoxClients.SelectedItem).Agent, (Bien)comboBoxBiens.SelectedItem);
            if (rdv.ShowDialog() == DialogResult.OK)
            {
                buttonCréer.Enabled = true;
                date = rdv.Date;
                dateTimePickerDate.Value = date;
                dateTimePickerHeure.Value = date;
            }
        }

        private void buttonCréer_Click(object sender, EventArgs e)
        {
            // Une visite est composée d'un bien, d'un souhait et d'une date
            Bien bien = (Bien)comboBoxBiens.SelectedItem;
            // si le souhait n'a pas été défini lors de l'appel de cette fenetre
            // on fixe le souhait au premier souhait du client sélectionné dans la liste
            if (souhait == null)      
                souhait = (SqlDataProvider.GetListeSouhaits(((Client)comboBoxClients.SelectedItem)))[0];
            Visite visite = new Visite(-1, souhait, bien, date);
            if (SqlDataProvider.AjouterVisite(visite))
            {
                MessageBox.Show("Ajout de la visite effectuée", "Opération réussie");
            }
            else
            {
                MessageBox.Show("Echec de l'ajout de la visite.", "Opération échouée");
            }
            this.Dispose();
        }

        private void comboBoxBiens_SelectedIndexChanged(object sender, EventArgs e)
        {
            activationBoutonRDV();
        }

        private void activationBoutonRDV()
        {
            if (comboBoxClients.SelectedItem != null &&
                comboBoxBiens.SelectedItem != null)
                buttonRDV.Enabled = true;
            else
                buttonRDV.Enabled = false;
        }
    }
}
