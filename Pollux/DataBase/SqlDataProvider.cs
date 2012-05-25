using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using Pollux.UserInterface;

namespace Pollux.DataBase
{
    static public partial class SqlDataProvider
    {
        static public OleDbConnection connect;

        static public bool DBConnect()
        {
            bool reussi = false;
            while (!reussi)
            {
                try
                {
                    connect = new OleDbConnection(@"Provider=SQLOLEDB;Data Source=" + FenetrePrincipale.AdresseBaseDeDonnees + ";Integrated Security=SSPI;Initial Catalog=CASTORFINDER;Connect Timeout=1");
                    connect.Open();
                    if (connect.State == ConnectionState.Open)
                        reussi = true;
                }
                catch (Exception)
                {
                    DialogResult resultat = MessageBox.Show("Echec de connexion à la base de données\nChanger l'adresse de connexion ?",
                                "Erreur",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (resultat == DialogResult.OK)
                    {
                        ConnexionBDD connexion = new ConnexionBDD( FenetrePrincipale.AdresseBaseDeDonnees );
                        connexion.ShowDialog();
                        if (connexion.DialogResult == DialogResult.OK)
                        {
                            FenetrePrincipale.AdresseBaseDeDonnees = connexion.Adresse;
                        }
                        else
                            break;
                    }
                    else
                        break;
                }
            }
            return reussi;
        }
    }
}
