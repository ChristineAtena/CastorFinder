using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using Pollux.UserInterface;
using System.Xml;
using System.Configuration;

namespace Pollux.DataBase
{
    static public partial class SqlDataProvider
    {
        static public OleDbConnection connect;
        static private string m_connectionString;

        /// <summary>
        /// Méthode permettant de tester la connexion à la base de données
        /// et de modifier le fichier de configuration avec la bonne chaine de connexion
        /// A n'appeler qu'une fois à l'ouverture du programme
        /// par la suite on utilise la variable m_connectionString qui contient la chaine de connexion valide
        /// (pour éviter un appel au fichier de config à chaque appel BDD)
        /// </summary>
        static public bool InitialisationConnexion()
        {
            bool ConnexionOK = false;
            bool ConfigModifiee = false;
            // on récupère la clé du fichier de config (le string de connexion)
            m_connectionString = ConfigurationManager.ConnectionStrings["CastorConnexion"].ConnectionString;

            // on tente la connexion
            // si KO on redemande le nom du serveur tant que la connexion échoue
            do
            {
                try
                {
                    connect = new OleDbConnection(m_connectionString);
                    connect.Open();
                    // si la connexion s'ouvre, _connexionString est bon
                    if (connect.State == ConnectionState.Open)
                    {
                        ConnexionOK = true;
                        connect.Close();
                    }
                }
                catch (Exception)
                {
                    // Si la connexion ne s'établit pas
                    DialogResult resultat = MessageBox.Show("Echec de connexion à la base de données\nChanger l'adresse de connexion ?",
                                "Erreur", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (resultat == DialogResult.OK)
                    {
                        // Récupération du nom du serveur
                        string[] split = m_connectionString.Split(new Char[] { '=', ';' });
                        string nomServeur = split[3];
                        // Ouverture d'un formulaire pour renseigner le nom du serveur
                        ConnexionBDD connexion = new ConnexionBDD(nomServeur);
                        connexion.ShowDialog();
                        if (connexion.DialogResult == DialogResult.OK)
                        {
                            // On modifie la chaine de connexion
                            m_connectionString = "Provider=SQLOLEDB;Data Source=" + connexion.Adresse + ";Integrated Security=SSPI;Initial Catalog=CASTORFINDER;Connect Timeout=2";
                            ConfigModifiee = true;
                        }
                        else return false;
                    }
                    else return false;
                }
            }
            while (!ConnexionOK);

            // si la configuration a changé, on la sauvegarde
            if (ConfigModifiee)
            {
                // Ouverture de la config
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                // Modification et enregitrement dans la config
                config.ConnectionStrings.ConnectionStrings["CastorConnexion"].ConnectionString = m_connectionString;
                config.Save(ConfigurationSaveMode.Modified);
                // On force le rechargement en mémoire de la config
                // Utile uniquement si on a besoin de rechercher plus tard la clé modifiée
                // ConfigurationManager.RefreshSection("connectionStrings");
            }
            return true;
        }

        // Vérification que la connexion a bien eu lieu
        static public bool DBConnect()
        {
            try
            {
                connect = new OleDbConnection(m_connectionString);
                connect.Open();
                return (connect.State == ConnectionState.Open);
            }
            catch (Exception)
            {
                MessageBox.Show("Echec connexion BdD", "Attention");
                return false;
            }
        }

    }
}
