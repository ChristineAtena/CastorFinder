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

        static public List<Agent> GetListeAgents()
        {
            List<Agent> listeAgents = new List<Agent>();
            if (DBConnect())
            {
                string requete = "SELECT NUM_A, PRÉNOM_A FROM AGENTS ORDER BY PRÉNOM_A";
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                // ajout des prénoms des agents dans la liste
                while (reader.Read())
                {
                    listeAgents.Add(new Agent(reader.GetInt16(0), reader.GetString(1)));
                }
                // déconnexion
                reader.Close();
                connect.Close();
            }
            return listeAgents;
        }

        // Retrouver un agent à partir de son index
        static public Agent TrouverAgent(int index)
        {
            Agent agent = null;
            if (DBConnect())
            {
                string requete = "SELECT PRÉNOM_A FROM AGENTS WHERE NUM_A = " + index;
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string prenom = reader.GetString(0);
                    agent = new Agent(index, prenom);
                }
                reader.Close();
                connect.Close();
            }
            return agent;
        }

        static public bool AjouterAgent(string prenom)
        {
            bool ajout = false;
            if (DBConnect())
            // si connexion
            {
                string requete = "if not exists(select PRÉNOM_A from AGENTS where PRÉNOM_A = N'" + prenom + "' ) "
                                + "begin "
	                            + "INSERT INTO AGENTS (PRÉNOM_A) VALUES (N'" + prenom + "') "
                                + "end ";
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
