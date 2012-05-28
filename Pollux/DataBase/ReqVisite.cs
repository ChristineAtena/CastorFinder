using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using Pollux.Object;

namespace Pollux.DataBase
{
    static public partial class SqlDataProvider  
    {
        /// <summary>
        /// permet de trouver la liste des visites d'un agent
        /// </summary>
        /// <param name="agent"></param>
        /// <returns></returns>
        static public List<Visite> TrouverListeVisites(Agent agent)
        {
            List<Visite> calendrier = new List<Visite>();
            Souhait souhait;
            Bien bien;
            DateTime date;
            int index;
            if (DBConnect())
            {
                //création de la requête
                string requete = "SELECT VISITES.NUM_V, VISITES.NUM_S, NUM_B, DATE_V"
                                + " FROM VISITES INNER JOIN SOUHAITS ON VISITES.NUM_S = SOUHAITS.NUM_S"
                                + " INNER JOIN CLIENTS ON SOUHAITS.NUM_C = CLIENTS.NUM_C"
                                + " INNER JOIN AGENTS ON CLIENTS.NUM_A = AGENTS.NUM_A"
                                + " WHERE AGENTS.NUM_A = " + agent.Index;
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                // ajout des visites dans la liste
                while (reader.Read())
                {
                    index = reader.GetInt16(0);
                    souhait = TrouverSouhait(reader.GetInt16(1));
                    bien = TrouverBien(reader.GetInt16(2));
                    date = reader.GetDateTime(3);
                    calendrier.Add(new Visite(index, souhait, bien, date));
                }
                // déconnexion
                reader.Close();
                connect.Close();
            }
            return calendrier;
        }

        /// <summary>
        /// Ajout d'une visite dans la base de données
        /// </summary>
        /// <param name="visite">une visite</param>
        /// <returns>retourne vrai si l'ajout a réussit, sinon faux</returns>
        static public bool AjouterVisite(Visite visite)
        {
            bool ajout = false;
            if (DBConnect())
            // si connexion
            {
                string requete = "INSERT INTO VISITES (NUM_S, NUM_B, DATE_V) "
                                +"VALUES (" + visite.Souhait.Index + "," + visite.Bien.Index + ",N'" + visite.DateHeure + "')";
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
    }
}
