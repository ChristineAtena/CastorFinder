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
            loadVilles();
        }
        public UCAjouterSouhait(Client c, bool clientExiste)
        {
            InitializeComponent();
            loadClients();
            loadVilles();
            comboBoxAcheteur.SelectedText = c.Nom;
            if (!clientExiste)
                comboBoxAcheteur.Enabled = false;
        }
        #region Chargement des comboBox
        private void loadClients()
        {
            comboBoxAcheteur.Items.Clear();
            List<string> listeClients = SqlDataProvider.GetListeNomClients();
            foreach (string prenom in listeClients)
            {
                comboBoxAcheteur.Items.Add(prenom);
            }
        }
        private void loadVilles()
        {
            listBoxVilles.Items.Clear();
            List<Ville> listeVilles = SqlDataProvider.GetListeVilles();
            foreach (Ville ville in listeVilles)
            {
                listBoxVilles.Items.Add(string.Format("{0} ({1})", ville.Nom, ville.CodePostal));
            }
        }
        #endregion

        #region TrackBars
        private void trackBarAjoutSouhaitsBudget_Scroll(object sender, EventArgs e)
        {
            textBoxAjoutSouhaitsBudget.Text = trackBarAjoutSouhaitsBudget.Value.ToString();
        }

        private void trackBarAjoutSouhaitSurfHab_Scroll(object sender, EventArgs e)
        {
            textBoxAjoutSouhaitSurfHab.Text = trackBarAjoutSouhaitSurfHab.Value.ToString();
        }

        private void trackBarAjoutSouhaitJardin_Scroll(object sender, EventArgs e)
        {
            textBoxAjoutSouhaitJardin.Text = trackBarAjoutSouhaitJardin.Value.ToString();
        }
        #endregion

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


        // A FINIR
        private void buttonAjout_Click(object sender, EventArgs e)
        {
            
            // Récupération des infos
            int prix = -1;
            int surfHab = -1;
            int surfJard = -1;
            List<Ville> villes = null;
            if (checkBoxBudgetMax.Checked)
                prix = int.Parse(textBoxAjoutSouhaitsBudget.Text);
            if (checkBoxSurfHab.Checked)
                surfHab = int.Parse(textBoxAjoutSouhaitSurfHab.Text);
            if (checkBoxJardin.Checked)
                surfJard = int.Parse(textBoxAjoutSouhaitJardin.Text);
            if (checkBoxVilles.Checked)
                villes = listBoxVilles.SelectedItems.Cast<Ville>().ToList();
            // Ajout en base du bien

            Souhait souhait = new Souhait(prix, surfHab, surfJard, villes);
            Client acheteur = (Client)comboBoxAcheteur.SelectedItem;
            if (comboBoxAcheteur.Enabled)
            {
                if (SqlDataProvider.AjouterSouhait(souhait))
                {
                    MessageBox.Show("Ajout du souhait effectué", "Opération réussie");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Ajout du souhait non effectué", "Echec");
                }
            }
            else
            {
                if (SqlDataProvider.ajouterSouhaitEtClient(acheteur, souhait))
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
        #region Activation bouton Ajouter
        private void activationBoutonCreer()
        {
            if (checkBoxBudgetMax.Checked ||
                checkBoxSurfHab.Checked ||
                checkBoxJardin.Checked ||
                checkBoxVilles.Checked)
                buttonAjout.Enabled = true;
            else
                buttonAjout.Enabled = false;
        }
        #endregion
    }
}
