using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Pollux.Object;
using Pollux.DataBase;

namespace Pollux.UserInterface
{
    public partial class FormVilles : Form
    {

        public FormVilles()
        {
            InitializeComponent();
        }

        
        private void boutonAjouter_Click(object sender, EventArgs e)
        {
            int codePostal;
            // si une des cases est vide
            if (textBoxCP.Text == "" || textBoxNom.Text == "")
            {
                MessageBox.Show("Formulaire mal rempli", "Attention");
                return;
            }
            // si code postal n'est pas un chiffre
            if (!int.TryParse(textBoxCP.Text, out codePostal))
            {
                MessageBox.Show("Le code postal doit être un chiffre.","Attention");
                return;
            }
            Ville nouvelleVille = new Ville(codePostal, textBoxNom.Text);
            if (ajoutBdD(nouvelleVille))
            {
                MessageBox.Show("La ville a bien été ajoutée dans la base de données.","Ajout réussit");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Aucune ville n'a été ajoutée.","Erreur");
            }
        }

        private bool ajoutBdD(Ville ville)
        {
            // vérification si la ville est déjà en base (même CP et même nom)
            if (SqlDataProvider.VerificationPresenceVille(ville))
            {
                MessageBox.Show("La ville est déjà dans la base de données","Avertissement");
                return false;
            }
            // si ville n'existe pas déjà
            else
            {
                SqlDataProvider.AjouterVille(ville);
                return true;
            }
        }
    }
}