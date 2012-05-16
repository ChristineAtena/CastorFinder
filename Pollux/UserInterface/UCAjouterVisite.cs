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
        DateTime date;
        public UCAjouterVisite()
        {
            InitializeComponent();
            buttonRDV.Enabled = false;
            loadClients();
            loadBiens();
        }

        public UCAjouterVisite(Souhait souhait)
        {
            InitializeComponent();
            textBoxTelephone.Text = souhait.Client.Telephone;
            comboBoxClients.Items.Add(souhait.Client);
            comboBoxClients.SelectedItem = souhait.Client;
            comboBoxClients.Enabled = false;
            loadBiens();
            buttonRDV.Enabled = false;
        }

        public UCAjouterVisite(Bien bien)
        {
            InitializeComponent();
            loadClients();
            comboBoxBiens.Items.Add(bien);
            comboBoxBiens.SelectedItem = bien;
            comboBoxBiens.Enabled = false;
            buttonRDV.Enabled = false;
        }

        public UCAjouterVisite(Souhait souhait, Bien bien)
        {
            InitializeComponent();
            textBoxTelephone.Text = souhait.Client.Telephone;

            comboBoxClients.Items.Clear();
            comboBoxClients.Items.Add(souhait.Client);
            comboBoxClients.SelectedItem = souhait.Client;
            comboBoxClients.Enabled = false;

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
            foreach (Client acheteur in listeClient)
            {
                comboBoxClients.Items.Add(acheteur);
            }
        }
        private void loadBiens()
        {
            comboBoxBiens.Items.Clear();
            List<Bien> listeBiens = SqlDataProvider.GetListeBiens();
            foreach (Bien bien in listeBiens)
            {
                comboBoxBiens.Items.Add(bien);
            }
        }
        #endregion

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxTelephone.Text = ((Client)comboBoxClients.SelectedItem).Telephone;
            if (comboBoxBiens.SelectedItem != null)
            {
                buttonRDV.Enabled = true;
            }
        }

        private void buttonRDV_Click(object sender, EventArgs e)
        {
            TrouverRDV rdv = new TrouverRDV(((Client)comboBoxClients.SelectedItem).Agent, (Bien)comboBoxBiens.SelectedItem);
            if (rdv.ShowDialog() == DialogResult.OK)
                date = rdv.Date;
        }

        private void comboBoxBiens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxClients.SelectedItem != null)
            {
                buttonRDV.Enabled = true;
            }
        }
    }
}
