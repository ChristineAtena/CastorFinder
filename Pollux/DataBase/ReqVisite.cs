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
        static public List<Visite> TrouverListeVisites(Agent agent)
        {
            List<Visite> calendrier = new List<Visite>();
            Souhait souhait;
            Bien bien;
            DateTime date;
            int index;
            if (DBConnect())
            {
                string requete = "SELECT VISITES.NUM_V, VISITES.NUM_S, NUM_B, DATE_V"
                                + " FROM VISITES INNER JOIN SOUHAITS ON VISITES.NUM_S = SOUHAITS.NUM_S"
                                + " INNER JOIN CLIENTS ON SOUHAITS.NUM_C = CLIENTS.NUM_C"
                                + " INNER JOIN AGENTS ON CLIENTS.NUM_A = AGENTS.NUM_A"
                                + " WHERE AGENTS.NUM_A = " + agent.Index;
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                // ajout des villes dans la liste
                while (reader.Read())
                {
                    index = reader.GetInt16(0);
                    souhait = trouverSouhait(reader.GetInt16(1));
                    bien = trouverBien(reader.GetInt16(2));
                    date = reader.GetDateTime(3);
                    calendrier.Add(new Visite(index, souhait, bien, date));
                }
                // déconnexion
                reader.Close();
                connect.Close();
            }
            return calendrier;
        }
        static public bool AjouterVisite(Visite visite)
        {
            bool ajout = false;
            // TODO ajouter une visite
            // REFLECHIR sur les paramètres qu'il faut


            return ajout;
        }
        
        
    }
}
