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

        #region Zones de texte
        private void textBoxRechBienPrix_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxRechBienPrix.Text))
            {
                try
                {
                    trackBarRechBienPrix.Value = int.Parse(textBoxRechBienPrix.Text);
                    checkBoxBudgetMax.Checked = true;
                }
                catch (Exception) // la valeur n'est pas un chiffre ou non comprise dans la gamme de valeur
                {
                    textBoxRechBienPrix.Text = string.Empty;
                    trackBarRechBienPrix.Value = 0;
                    MessageBox.Show(string.Format("Valeur non valide \ndoit être comprise entre {0} et {1}.",
                        trackBarRechBienPrix.Minimum, trackBarRechBienPrix.Maximum), "Attention");
                }
            }
            else
                checkBoxBudgetMax.Checked = false;
        }

        private void textBoxRechBienSurf_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxRechBienSurf.Text))
            {
                try
                {
                    trackBarRechBienSurf.Value = int.Parse(textBoxRechBienSurf.Text);
                    checkBoxSurfHab.Checked = true;
                }
                catch (Exception) // la valeur n'est pas un chiffre ou non comprise dans la gamme de valeur
                {
                    textBoxRechBienSurf.Text = string.Empty;
                    trackBarRechBienSurf.Value = 0;
                    MessageBox.Show(string.Format("Valeur non valide \ndoit être comprise entre {0} et {1}.",
                        trackBarRechBienSurf.Minimum, trackBarRechBienSurf.Maximum), "Attention");
                }
            }
            else
                checkBoxSurfHab.Checked = false;
        }

        private void textBoxRechBienJardin_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxRechBienJardin.Text))
            {
                try
                {
                    trackBarRechBienJardin.Value = int.Parse(textBoxRechBienJardin.Text);
                    checkBoxJardin.Checked = true;
                }
                catch (Exception) // la valeur n'est pas un chiffre ou non comprise dans la gamme de valeur
                {
                    textBoxRechBienJardin.Text = string.Empty;
                    trackBarRechBienJardin.Value = 0;
                    MessageBox.Show(string.Format("Valeur non valide \ndoit être comprise entre {0} et {1}.",
                        trackBarRechBienJardin.Minimum, trackBarRechBienJardin.Maximum), "Attention");
                }
            }
            else
                checkBoxJardin.Checked = false;
        }
        #endregion

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
                textBoxRechBienPrix.Text = trackBarRechBienPrix.Maximum.ToString();
            else // si décoche la case, on remet à zéro
            {
                textBoxRechBienPrix.Text = string.Empty;
                trackBarRechBienPrix.Value = 0;
            }
        }

        private void checkBoxSurfHab_CheckedChanged(object sender, EventArgs e)
        {
            activationBoutonRechercher();
            // si coche la case, on fixe la surf Hab à son minimum
            if (checkBoxSurfHab.Checked == true)
                textBoxRechBienSurf.Text = trackBarRechBienSurf.Minimum.ToString();
            else // si décoche la case, on remet à zéro
            {
                textBoxRechBienSurf.Text = string.Empty;
                trackBarRechBienSurf.Value = 0;
            }
        }

        private void checkBoxJardin_CheckedChanged(object sender, EventArgs e)
        {
            activationBoutonRechercher();
            // si coche la case, on fixe la surf du jardin à son minimum
            if (checkBoxJardin.Checked == true)
                textBoxRechBienJardin.Text = trackBarRechBienJardin.Minimum.ToString();
            else // si décoche la case, on remet à zéro
            {
                textBoxRechBienJardin.Text = string.Empty;
                trackBarRechBienJardin.Value = 0;
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
                prix = int.Parse(textBoxRechBienPrix.Text);
            if (checkBoxSurfHab.Checked)
                surfHab = int.Parse(textBoxRechBienSurf.Text);
            if (checkBoxJardin.Checked)
                surfJard = int.Parse(textBoxRechBienJardin.Text);
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
