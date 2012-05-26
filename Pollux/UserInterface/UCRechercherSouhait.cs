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
using System.Configuration;

namespace Pollux.UserInterface
{
    public partial class UCRechercherSouhait : UserControl
    {
        public UCRechercherSouhait()
        {
            InitializeComponent();
            loadVilles();
            disableNumericUpDowns();
            InitialisationParametres();
        }

        private void InitialisationParametres()
        {
            // Budget
            trackBarBudget.Maximum = Convert.ToInt32(ConfigurationManager.AppSettings["MaxBudget"]);
            trackBarBudget.Minimum = Convert.ToInt32(ConfigurationManager.AppSettings["MinBudget"]);
            trackBarBudget.LargeChange = Convert.ToInt32(ConfigurationManager.AppSettings["PasBudget"]);
            numericUpDownBudget.Maximum = Convert.ToDecimal(ConfigurationManager.AppSettings["MaxBudget"]);
            numericUpDownBudget.Minimum = Convert.ToDecimal(ConfigurationManager.AppSettings["MinBudget"]);
            numericUpDownBudget.Increment = Convert.ToDecimal(ConfigurationManager.AppSettings["PasBudget"]);
            // Surface Habitable
            trackBarSurfHab.Maximum = Convert.ToInt32(ConfigurationManager.AppSettings["MaxSurfHab"]);
            trackBarSurfHab.Minimum = Convert.ToInt32(ConfigurationManager.AppSettings["MinSurfHab"]);
            trackBarSurfHab.LargeChange = Convert.ToInt32(ConfigurationManager.AppSettings["PasSurfHab"]);
            numericUpDownSurfHab.Maximum = Convert.ToDecimal(ConfigurationManager.AppSettings["MaxSurfHab"]);
            numericUpDownSurfHab.Minimum = Convert.ToDecimal(ConfigurationManager.AppSettings["MinSurfHab"]);
            numericUpDownSurfHab.Increment = Convert.ToDecimal(ConfigurationManager.AppSettings["PasSurfHab"]);
            //Surface Jardin
            trackBarSurfJard.Maximum = Convert.ToInt32(ConfigurationManager.AppSettings["MaxSurfJard"]);
            trackBarSurfJard.Minimum = Convert.ToInt32(ConfigurationManager.AppSettings["MinSurfJard"]);
            trackBarSurfJard.LargeChange = Convert.ToInt32(ConfigurationManager.AppSettings["PasSurfJard"]);
            numericUpDownSurfJard.Maximum = Convert.ToDecimal(ConfigurationManager.AppSettings["MaxSurfJard"]);
            numericUpDownSurfJard.Minimum = Convert.ToDecimal(ConfigurationManager.AppSettings["MinSurfJard"]);
            numericUpDownSurfJard.Increment = Convert.ToDecimal(ConfigurationManager.AppSettings["PasSurfJard"]);
        }

        #region Chargement des comboBox
        private void loadVilles()
        {
            List<Ville> listeVilles = SqlDataProvider.GetListeVilles();
            comboBoxVilles.DataSource = listeVilles;
            comboBoxVilles.SelectedIndex = -1;
        }
        #endregion

        #region TrackBars
        private void trackBarBudget_Scroll(object sender, EventArgs e)
        {
            numericUpDownBudget.Value = trackBarBudget.Value;
            checkBoxBudgetMax.Checked = true;
        }
        private void trackBarSurfHab_Scroll(object sender, EventArgs e)
        {
            numericUpDownSurfHab.Value = trackBarSurfHab.Value;
            checkBoxSurfHab.Checked = true;
        }
        private void trackBarSurfJard_Scroll(object sender, EventArgs e)
        {
            numericUpDownSurfJard.Value = trackBarSurfJard.Value;
            checkBoxJardin.Checked = true;
        }
        #endregion

        #region numericUpDown
        private void numericUpDownBudget_ValueChanged(object sender, EventArgs e)
        {
            trackBarBudget.Value = (int)numericUpDownBudget.Value;
        }
        private void numericUpDownSurfHab_ValueChanged(object sender, EventArgs e)
        {
            trackBarSurfHab.Value = (int)numericUpDownSurfHab.Value;
        }

        private void numericUpDownSurfJard_ValueChanged(object sender, EventArgs e)
        {
            trackBarSurfJard.Value = (int)numericUpDownSurfJard.Value;
        }

        private void numericUpDownBudget_KeyUp(object sender, KeyEventArgs e)
        {
            trackBarBudget.Value = (int)numericUpDownBudget.Value;
        }

        private void numericUpDownSurfHab_KeyUp(object sender, KeyEventArgs e)
        {
            trackBarSurfHab.Value = (int)numericUpDownSurfHab.Value;
        }

        private void numericUpDownSurfJard_KeyUp(object sender, KeyEventArgs e)
        {
            trackBarSurfJard.Value = (int)numericUpDownSurfJard.Value;
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
                numericUpDownBudget.Value = trackBarBudget.Maximum;
                numericUpDownBudget.Enabled = true;
            }
            else // si décoche la case, on remet à zéro
            {
                numericUpDownBudget.Value = 0;
                trackBarBudget.Value = 0;
                numericUpDownBudget.Enabled = false;
            }
        }

        private void checkBoxSurfHab_CheckedChanged(object sender, EventArgs e)
        {
            activationBoutonRechercher();
            // si coche la case, on fixe la surf Hab à son minimum
            if (checkBoxSurfHab.Checked == true)
            {
                numericUpDownSurfHab.Value = trackBarSurfHab.Minimum;
                numericUpDownSurfHab.Enabled = true;
            }
            else // si décoche la case, on remet à zéro
            {
                numericUpDownSurfHab.Value = 0;
                trackBarSurfHab.Value = 0;
                numericUpDownSurfHab.Enabled = false;
            }
        }

        private void checkBoxJardin_CheckedChanged(object sender, EventArgs e)
        {
            activationBoutonRechercher();
            // si coche la case, on fixe la surf du jardin à son minimum
            if (checkBoxJardin.Checked == true)
            {
                numericUpDownSurfJard.Value = trackBarSurfJard.Minimum;
                numericUpDownSurfJard.Enabled = true;
            }
            else // si décoche la case, on remet à zéro
            {
                numericUpDownSurfJard.Value = 0;
                trackBarSurfJard.Value = 0;
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
