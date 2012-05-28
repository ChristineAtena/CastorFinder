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
        /// Créé une liste des agents
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Retrouve un agent à partir de son index
        /// </summary>
        /// <param name="index">index de l'agent</param>
        /// <returns>Agent cherché</returns>
        static public Agent TrouverAgent(int index)
        {
            Agent agent = null;
            if (DBConnect())
            {
                string requete = "SELECT PRÉNOM_A FROM AGENTS WHERE NUM_A = " + index;
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())//si il y a un résultat
                {
                    string prenom = reader.GetString(0);
                    agent = new Agent(index, prenom);
                }
                reader.Close();
                connect.Close();
            }
            return agent;
        }

        /// <summary>
        /// Ajoute un agent de base
        /// </summary>
        /// <param name="prenom">Prénom de l'agent</param>
        /// <returns>true si réussite, false sinon</returns>
        static public bool AjouterAgent(string prenom)
        {
            bool ajout = false;
            if (DBConnect())
            // si connexion
            {
                string requete = "IF NOT EXISTS(SELECT PRÉNOM_A FROM AGENTS WHERE PRÉNOM_A = N'" + prenom.Replace("'","''") + "' ) "
                                + "BEGIN "
                                + "INSERT INTO AGENTS (PRÉNOM_A) VALUES (N'" + prenom.Replace("'", "''") + "') "
                                + "END ";
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
