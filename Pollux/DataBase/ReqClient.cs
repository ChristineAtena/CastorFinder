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
        static public int TrouverClient(string nom, string adresse)
        {
            int index = -1;
            if (DBConnect())
            {
                string requete = string.Format("SELECT NUM_C FROM CLIENTS WHERE NOM_C = N'{0}' AND ADRESSE_C = N'{1}'", nom, adresse);
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    index = reader.GetInt16(0);
                    // déconnexion
                    connect.Close();
                    break;
                }
            }
            return index;
        }
        /// <summary>
        /// Construire un client à partir de son index
        /// </summary>
        /// <param name="index">son index</param>
        /// <returns>le client construit</returns>
        static public Client TrouverClient(int index)
        {
            int indexAgent;
            Client client = null;
            if (DBConnect())
            {
                string requete = "SELECT * FROM CLIENTS WHERE NUM_C = "+index;
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int indexVille = reader.GetInt16(1);
                    try
                    {
                        indexAgent = reader.GetInt16(2);
                    }
                    catch { indexAgent = -1; }
                    string nom = reader.GetString(3);
                    string adresse = reader.GetString(4);
                    string telephone = reader.GetString(5);
                    // déconnexion
                    connect.Close();
                    client = new Client(index, nom, adresse, telephone, indexAgent, indexVille);
                    break;
                }
            }
            return client;
        }

        /// <summary>
        /// Retourne la liste des clients de l'agent fourni en paramètre
        /// </summary>
        static public List<Client> GetListeClients(Agent agent)
        {
            Client client;
            Ville ville;
            List<Client> listeClients = new List<Client>();
            if (DBConnect())
            {
                string requete = "SELECT NUM_C, NOM_C, ADRESSE_C, TEL_C, NUM_V FROM CLIENTS "
                                + " WHERE CLIENTS.NUM_A = N'"
                                + agent.Index
                                + "' ORDER BY NOM_C";
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                // ajout des noms des clients dans la liste
                while (reader.Read())
                {
                    ville = SqlDataProvider.TrouverVille(reader.GetInt16(4));
                    client = new Client(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), agent, ville);
                    listeClients.Add(client);
                }
                // déconnexion
                reader.Close();
                connect.Close();
            }
            return listeClients;
        }


        /// <summary>
        /// Retourne la liste des vendeurs
        /// </summary>
        /// <returns>liste de vendeurs</returns>
        static public List<Client> GetListeVendeurs()
        {
            Client client;
            Agent agent;
            Ville ville;
            List<Client> listeClients = new List<Client>();
            if (DBConnect())
            {
                string requete = "SELECT CLIENTS.NUM_C, NOM_C, ADRESSE_C, TEL_C, NUM_A, CLIENTS.NUM_V FROM CLIENTS "
                                +"INNER JOIN BIENS ON CLIENTS.NUM_C = BIENS.NUM_C "
                                +"GROUP BY CLIENTS.NUM_C, NOM_C, ADRESSE_C, TEL_C, NUM_A, CLIENTS.NUM_V "
                                +"ORDER BY NOM_C";
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        agent = SqlDataProvider.TrouverAgent(reader.GetInt16(4));
                    }
                    catch (Exception) { agent = null; }
                    ville = SqlDataProvider.TrouverVille(reader.GetInt16(5));
                    client = new Client(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), agent, ville);
                    listeClients.Add(client);
                }
                // déconnexion
                reader.Close();
                connect.Close();
            }
            return listeClients;
        }


        /// <summary>
        /// Retourne la liste des acheteurs
        /// </summary>
        /// <returns>liste de acheteurs</returns>
        static public List<Client> GetListeAcheteurs()
        {
            Client client;
            Agent agent;
            Ville ville;
            List<Client> listeClients = new List<Client>();
            if (DBConnect())
            {
                string requete = "SELECT NUM_C, NOM_C, ADRESSE_C, TEL_C, NUM_A, NUM_V FROM CLIENTS "
                                +"WHERE CLIENTS.NUM_A IS NOT NULL "
                                +"ORDER BY NOM_C";
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        agent = SqlDataProvider.TrouverAgent(reader.GetInt16(4));
                    }
                    catch (Exception) { agent = null; }
                    ville = SqlDataProvider.TrouverVille(reader.GetInt16(5));
                    client = new Client(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), agent, ville);
                    listeClients.Add(client);
                }
                // déconnexion
                reader.Close();
                connect.Close();
            }
            return listeClients;
        }

        /// <summary>
        /// Retourne la liste de tous les clients
        /// </summary>
        static public List<Client> GetListeClients()
        {
            Client client;
            Agent agent;
            Ville ville;
            List<Client> listeClients = new List<Client>() ;
            if (DBConnect())
            {
                string requete = "SELECT NUM_C, NOM_C, ADRESSE_C, TEL_C, NUM_A, NUM_V FROM CLIENTS ORDER BY NOM_C";
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        agent = SqlDataProvider.TrouverAgent(reader.GetInt16(4));
                    }
                    catch(Exception)  { agent = null; }
                    ville = SqlDataProvider.TrouverVille(reader.GetInt16(5));
                    client = new Client(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), agent, ville);
                    listeClients.Add(client);
                }
                // déconnexion
                reader.Close();
                connect.Close();
            }
            return listeClients;
        }

        // Vérifie si un client avec le même nom et même ville est déjà présent en base
        // si oui retourne ce client, sinon retourne null
        static public Client ClientExiste(string nom, Ville ville)
        {
            Client client = null;
            Agent agent;
            if (DBConnect())
            {
                string requete = "SELECT NUM_C, NOM_C, ADRESSE_C, TEL_C, NUM_A, NUM_V FROM CLIENTS WHERE NOM_C=N'"+nom+"' AND NUM_V=N'"+ville.Index+"'";
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        agent = SqlDataProvider.TrouverAgent(reader.GetInt16(4));
                    }
                    catch (Exception) { agent = null; }
                    try
                    {
                        Ville villeC = SqlDataProvider.TrouverVille(reader.GetInt16(5));
                        client = new Client(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), agent, villeC);
                    }
                    catch (Exception) { client = null; }
                }
                // déconnexion
                reader.Close();
                connect.Close();
            }
            return client;
        }
    }
}
