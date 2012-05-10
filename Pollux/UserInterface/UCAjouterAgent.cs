using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pollux.DataBase;

namespace Pollux.UserInterface
{
    public partial class UCAjouterAgent : UserControl
    {
        public UCAjouterAgent()
        {
            InitializeComponent();
            buttonCreer.Enabled = false;
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonCreer_Click(object sender, EventArgs e)
        {
            if (SqlDataProvider.AjouterAgent(textBoxPrenom.Text))
            {
                MessageBox.Show("ajout OK", "coolos");
                this.Hide();
            }
            else
            {
                MessageBox.Show("ajout KO", "Prénom de l'agent déjà existant ?");
            }
        }

        private void textBoxPrenom_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPrenom.Text != "")
                buttonCreer.Enabled = true;
            else
                buttonCreer.Enabled = false;
        }
    }
}
