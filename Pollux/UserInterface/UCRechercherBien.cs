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
    public partial class UCRechercherBien : UserControl
    {
        public UCRechercherBien()
        {
            InitializeComponent();
            loadVilles();
        }

        #region Chargement des comboBox
        private void loadVilles()
        {
            comboBoxVilles.Items.Clear();
            List<Ville> listeVilles = SqlDataProvider.GetListeVilles();
            foreach (Ville ville in listeVilles)
            {
                comboBoxVilles.Items.Add(string.Format("{0} ({1})", ville.Nom, ville.CodePostal));
            }
        }
        #endregion

        #region trackBar
        private void trackBarRechBienPrix_Scroll(object sender, EventArgs e)
        {
            textBoxRechBienPrix.Text = trackBarRechBienPrix.Value.ToString();
        }

        private void trackBarRechBienSurf_Scroll(object sender, EventArgs e)
        {
            textBoxRechBienSurf.Text = trackBarRechBienSurf.Value.ToString();
        }

        private void trackBarRechBienJardin_Scroll(object sender, EventArgs e)
        {
            textBoxRechBienJardin.Text = trackBarRechBienJardin.Value.ToString();
        }
        #endregion


        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonAjoutVille_Click(object sender, EventArgs e)
        {
            Form Ville = new FormVilles();
            if (Ville.ShowDialog() == DialogResult.OK)
            {
                loadVilles();
            }
        }

        private void buttonRechBien_Click(object sender, EventArgs e)
        {
            int prix = -1;
            int surfHab = -1;
            int surfJard = -1;
            Ville ville = null;
            Client client = null;
            DateTime date = new DateTime(1,1,1);
            if (checkBoxBudgetMax.Checked)
                prix = int.Parse(textBoxRechBienPrix.Text);
            if (checkBoxSurfHab.Checked)
                surfHab = int.Parse(textBoxRechBienSurf.Text);
            if (checkBoxJardin.Checked)
                surfJard = int.Parse(textBoxRechBienJardin.Text);
            if (checkBoxVille.Checked)
                ville = (Ville)comboBoxVilles.SelectedItem;
            if (checkBoxDate.Checked)
                date = dateTimePicker.Value;
            Bien bien = new Bien(prix, date ,surfHab, surfJard, ville, client);
            ((FenetrePrincipale)this.Parent).MdiChild = new UCAfficherBiens(bien);
            ((FenetrePrincipale)this.Parent).init();
            this.Dispose();
        }
    }
}
