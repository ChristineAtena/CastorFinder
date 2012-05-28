using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pollux.Object;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Pollux.DataBase
{
    static public partial class SqlDataProvider  
    {
        /// <summary>
        /// Obtient la liste des villes en base
        /// </summary>
        /// <returns>la liste des villes</returns>
        static public List<Ville> GetListeVilles()
        {
            List<Ville> listeVilles = new List<Ville>();
            int codePostal;
            string nomVille;
            int index;
            if (DBConnect())
            {
                string requete = "SELECT CODE_POSTAL_V, NOM_V, NUM_V FROM VILLES ORDER BY NOM_V";
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                // ajout des villes dans la liste
                while (reader.Read())
                {
                    codePostal = reader.GetInt32(0);
                    nomVille = reader.GetString(1);
                    index = reader.GetInt16(2);
                    listeVilles.Add(new Ville(codePostal, nomVille, index));
                }
                // déconnexion
                reader.Close();
                connect.Close();
            }
            return listeVilles;
        }

        /// <summary>
        /// Ajout d'une ville dans la base
        /// </summary>
        /// <param name="ville">Ville à ajouter</param>
        /// <returns>true si l'ajout a marché, false sinon</returns>
        static public bool AjouterVille(Ville ville)
        {
            bool ajout = false;
            if (DBConnect())
            // si connexion
            {
                string requete = string.Format("INSERT INTO VILLES (NOM_V, CODE_POSTAL_V) VALUES (N'{0}',N'{1}')", ville.Nom.Replace("'", "''"), ville.CodePostal);
                OleDbCommand command = new OleDbCommand(requete, connect);
                int rowCount = command.ExecuteNonQuery();  
                if (rowCount == 1)
                    ajout = true;  // ajout effectué
                else
                    ajout = false; // ajout non effectué
                // déconnexion
                connect.Close();
            }
            return ajout;
        }

        /// <summary>
        /// Retrouver une ville à partir de son index
        /// </summary>
        /// <param name="index">index de la ville à trouver</param>
        /// <returns>Ville</returns>
        static public Ville TrouverVille(int index)
        {
            Ville ville = null;
            if (DBConnect())
            {
                string requete = "SELECT CODE_POSTAL_V, NOM_V FROM VILLES WHERE NUM_V = " + index;
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int cp = reader.GetInt32(0);
                    string nom = reader.GetString(1);
                    ville = new Ville(cp, nom, index);
                }
                //Deconnexion
                reader.Close();
                connect.Close();
            }
            return ville;
        }

        /// <summary>
        /// trouver l'index correspondant à un couple (code postal, nom de ville)
        /// </summary>
        /// <param name="codePostal">Code postal</param>
        /// <param name="nom">Nom de la ville</param>
        /// <returns>index</returns>
        static public int TrouverVille(int codePostal, string nom)
        {
            int index = -1;
            if (DBConnect())
            {
                string requete = string.Format("SELECT NUM_V FROM VILLES WHERE NOM_V = N'{0}' AND CODE_POSTAL_V = N'{1}'", nom.Replace("'", "''"), codePostal);
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    index = reader.GetInt16(0);
                }
                reader.Close();
                connect.Close();
            }
            return index;
        }

        /// <summary>
        /// Vérification si la ville passée en paramètre est déjà dans la base
        /// </summary>
        /// <param name="villeRecherchee">Ville à vérifier</param>
        /// <returns>true si elle existe, false sinon</returns>
        static public bool VerificationPresenceVille(Ville villeRecherchee)
        {
            bool presente = false;
            List<Ville> listeVilles = GetListeVilles();
            foreach (Ville ville in listeVilles)
                if (ville.Nom == villeRecherchee.Nom && ville.CodePostal == villeRecherchee.CodePostal)
                    presente = true;
            return presente;
        }
    }
}
