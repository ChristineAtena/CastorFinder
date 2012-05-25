using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Pollux.Object;
using Pollux.DataBase;

namespace Pollux.UserInterface
{
    public partial class UCRechercherSouhait : UserControl
    {
        public UCRechercherSouhait()
        {
            InitializeComponent();
            loadVilles();
            disableNumericUpDowns();
        }

        #region Chargement des comboBox
        private void loadVilles()
        {
            comboBoxVilles.Items.Clear();
            List<Ville> listeVilles = SqlDataProvider.GetListeVilles();
            comboBoxVilles.DataSource = listeVilles;
            comboBoxVilles.SelectedIndex = -1;
        }
        #endregion

        #region TrackBars
        private void trackBarRechBienPrix_Scroll(object sender, EventArgs e)
        {
            numericUpDownBudget.Value = trackBarRechBienPrix.Value;
            checkBoxBudgetMax.Checked = true;
        }
        private void trackBarRechBienSurf_Scroll(object sender, EventArgs e)
        {
            numericUpDownSurfHab.Value = trackBarRechBienSurf.Value;
            checkBoxSurfHab.Checked = true;
        }
        private void trackBarRechBienJardin_Scroll(object sender, EventArgs e)
        {
            numericUpDownSurfJard.Value = trackBarRechBienJardin.Value;
            checkBoxJardin.Checked = true;
        }
        #endregion

        #region numericUpDown
        private void numericUpDownBudget_ValueChanged(object sender, EventArgs e)
        {
            trackBarRechBienPrix.Value = (int)numericUpDownBudget.Value;
        }
        private void numericUpDownSurfHab_ValueChanged(object sender, EventArgs e)
        {
            trackBarRechBienSurf.Value = (int)numericUpDownSurfHab.Value;
        }

        private void numericUpDownSurfJard_ValueChanged(object sender, EventArgs e)
        {
            trackBarRechBienJardin.Value = (int)numericUpDownSurfJard.Value;
        }
        #endregion

        private void disableNumericUpDowns()
        {
            numericUpDownBudget.Enabled = false;
            numericUpDownSurfHab.Enabled = false;
            numericUpDownSurfJard.Enabled = false;
        }

        #region Activation bouton Rechercher et controle des checkBox
        private void activationBoutonRechercher()
        {
            if (checkBoxBudgetMax.Checked ||
                 checkBoxSurfHab.Checked ||
                 checkBoxJardin.Checked ||
                 checkBoxVille.Checked)
                buttonRechercher.Enabled = true;
            else
                buttonRechercher.Enabled = false;
        }

        private void checkBoxBudgetMax_CheckedChanged(object sender, EventArgs e)
        {
            activationBoutonRechercher();
            // si coche la case, on fixe le budget a son maximum
            if (checkBoxBudgetMax.Checked == true)
            {
                numericUpDownBudget.Value = trackBarRechBienPrix.Maximum;
                numericUpDownBudget.Enabled = true;
            }
            else // si décoche la case, on remet à zéro
            {
                numericUpDownBudget.Value = 0;
                trackBarRechBienPrix.Value = 0;
                numericUpDownBudget.Enabled = false;
            }
        }

        private void checkBoxSurfHab_CheckedChanged(object sender, EventArgs e)
        {
            activationBoutonRechercher();
            // si coche la case, on fixe la surf Hab à son minimum
            if (checkBoxSurfHab.Checked == true)
            {
                numericUpDownSurfHab.Value = trackBarRechBienSurf.Minimum;
                numericUpDownSurfHab.Enabled = true;
            }
            else // si décoche la case, on remet à zéro
            {
                numericUpDownSurfHab.Value = 0;
                trackBarRechBienSurf.Value = 0;
                numericUpDownSurfHab.Enabled = false;
            }
        }

        private void checkBoxJardin_CheckedChanged(object sender, EventArgs e)
        {
            activationBoutonRechercher();
            // si coche la case, on fixe la surf du jardin à son minimum
            if (checkBoxJardin.Checked == true)
            {
                numericUpDownSurfJard.Value = trackBarRechBienJardin.Minimum;
                numericUpDownSurfJard.Enabled = true;
            }
            else // si décoche la case, on remet à zéro
            {
                numericUpDownSurfJard.Value = 0;
                trackBarRechBienJardin.Value = 0;
                numericUpDownSurfJard.Enabled = false;
            }
        }

        private void checkBoxVilles_CheckedChanged(object sender, EventArgs e)
        {
            activationBoutonRechercher();
            // si décoche la case, la sélection supprimée
            if (checkBoxVille.Checked == false)
                comboBoxVilles.SelectedIndex = -1;
            // si coche la case, on sélectionne la première
            else
            {
                comboBoxVilles.SelectedIndex = 0;
            }
        }

        private void comboBoxVille_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBoxVille.Checked = (comboBoxVilles.SelectedItem != null);
        }
        #endregion  


        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Construction d'un souhait à partir des paramètres choisis
        /// Appel de la fenetre affichant les souhaits correspondant 
        /// </summary>
        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            int prix = -1;
            int surfHab = -1;
            int surfJard = -1;
            List<Ville> villes = new List<Ville>();
            Client client = null;
            // Récupération des infos des textBox sélectionnées
            if (checkBoxBudgetMax.Checked)
                prix = (int)numericUpDownBudget.Value;
            if (checkBoxSurfHab.Checked)
                surfHab = (int)numericUpDownSurfHab.Value;
            if (checkBoxJardin.Checked)
                surfJard = (int)numericUpDownSurfJard.Value;
            if (checkBoxVille.Checked)
                villes.Add((Ville)comboBoxVilles.SelectedItem);
            // Construction du souhait
            Souhait souhait = new Souhait(prix, surfHab, surfJard, villes, client);
            // Appel de la fenêtre d'affichage du résultat de la recherche
            ((FenetrePrincipale)this.Parent).MdiChild = new UCAfficherSouhaits(souhait);
            ((FenetrePrincipale)this.Parent).init();
            this.Dispose();
        }
    }
}
