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
            disableNumericUpDowns();
        }

        #region Chargement des comboBox
        private void loadVilles()
        {
            comboBoxVille.Items.Clear();
            List<Ville> listeVilles = SqlDataProvider.GetListeVilles();
            comboBoxVille.DataSource = listeVilles;
            comboBoxVille.SelectedIndex = -1;
        }
        #endregion

        #region trackBar
        private void trackBarRechBienPrix_Scroll(object sender, EventArgs e)
        {
            numericUpDownBudget.Value = trackBarRechBienPrix.Value;
            numericUpDownBudget.Enabled = true;
        }

        private void trackBarRechBienSurf_Scroll(object sender, EventArgs e)
        {
            numericUpDownSurfHab.Value = trackBarRechBienSurf.Value;
            numericUpDownSurfHab.Enabled = true;
        }

        private void trackBarRechBienJardin_Scroll(object sender, EventArgs e)
        {
            numericUpDownSurfJard.Value = trackBarRechBienJardin.Value;
            numericUpDownSurfJard.Enabled = true;
        }
        #endregion

        #region numericUpDowns
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

        #region Activation bouton Rechercher et controle des checkBox
        private void activationBoutonRechercher()
        {
            if ( checkBoxBudgetMax.Checked ||
                 checkBoxSurfHab.Checked ||
                 checkBoxJardin.Checked ||
                 checkBoxVille.Checked ||
                 checkBoxDate.Checked)
                buttonRechercher.Enabled = true;
            else
                buttonRechercher.Enabled = false;
        }

        private void checkBoxBudgetMax_CheckedChanged(object sender, EventArgs e)
        {
            activationBoutonRechercher();
            // si coche la case, on fixe le budget a son maximum
            if (checkBoxBudgetMax.Checked)
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
            if (checkBoxSurfHab.Checked)
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
            if (checkBoxJardin.Checked)
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
                comboBoxVille.SelectedIndex = -1;
            // si coche la case, on sélectionne la première
            else
            {
                comboBoxVille.SelectedIndex = 0;
            }
        }

        private void checkBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            activationBoutonRechercher();
        }

        private void comboBoxVille_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBoxVille.Checked = (comboBoxVille.SelectedItem != null);
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            checkBoxDate.Checked = true;
        }
        #endregion  

        private void disableNumericUpDowns()
        {
            numericUpDownBudget.Enabled = false;
            numericUpDownSurfHab.Enabled = false;
            numericUpDownSurfJard.Enabled = false;
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Construction d'un bien à partir des paramètres choisis
        /// Appel de la fenetre affichant les biens correspondant 
        /// </summary>
        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            int prix = -1;
            int surfHab = -1;
            int surfJard = -1;
            Ville ville = null;
            Client client = null;
            DateTime date = new DateTime(1,1,1);
            // Récupération des infos des textBox sélectionnées
            if (checkBoxBudgetMax.Checked)
                prix = (int)numericUpDownBudget.Value;
            if (checkBoxSurfHab.Checked)
                surfHab = (int)numericUpDownSurfHab.Value;
            if (checkBoxJardin.Checked)
                surfJard = (int)numericUpDownSurfJard.Value;
            if (checkBoxVille.Checked)
                ville = (Ville)comboBoxVille.SelectedItem;
            if (checkBoxDate.Checked)
                date = dateTimePicker.Value;
            // Construction du bien
            Bien bien = new Bien(prix, date ,surfHab, surfJard, ville, client);
            // Appel de la fenêtre d'affichage du résultat de la recherche
            ((FenetrePrincipale)this.Parent).MdiChild = new UCAfficherBiens(bien);
            ((FenetrePrincipale)this.Parent).init();
            this.Dispose();
        }
    }
}
