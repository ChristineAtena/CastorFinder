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

        // Ajout d'une ville dans la base
        static public bool SaveVille(Ville ville)
        {
            bool ajout = false;
            if (DBConnect())
            // si connexion
            {
                string requete = string.Format("INSERT INTO VILLES (NOM_V, CODE_POSTAL_V) VALUES (N'{0}',N'{1}')", ville.Nom, ville.CodePostal);
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

        // Retrouver une ville à partir de son index
        static public Ville trouverVille(int index)
        {
            if (DBConnect())
            {
                string requete = "SELECT CODE_POSTAL_V, NOM_V FROM VILLES WHERE NUM_V = " + index;
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int cp = reader.GetInt32(0);
                    string nom = reader.GetString(1);
                    Ville ville = new Ville(cp, nom, index);
                    return ville;
                }
                reader.Close();
                connect.Close();
            }
            return null;
        }
        static public int trouverVille(int codePostal, string nom)
        {
            int index = -1;
            if (DBConnect())
            {
                string requete = string.Format("SELECT NUM_V FROM VILLES WHERE NOM_V = N'{0}' AND CODE_POSTAL_V = N'{1}'", nom, codePostal);
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    index = reader.GetInt16(0);
                }
                reader.Close();
                connect.Close();
            }
            return index;
        }

        // Vérification si la ville passée en paramètre est déjà dans la base
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
