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
        public UCAjouterVisite()
        {
            InitializeComponent();
            loadClients();
        }

        #region Chargement des comboBox
        private void loadClients()
        {
            comboBoxClients.Items.Clear();
            List<Client> listeClient = SqlDataProvider.GetListeClients();
            foreach (Client proprietaire in listeClient)
            {
                comboBoxClients.Items.Add(proprietaire);
            }
        }
        #endregion

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
