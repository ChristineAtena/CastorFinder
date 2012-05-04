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
        static public int trouverClient(string nom, string adresse)
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

        static public List<string> GetListeNomClients()
        {
            List<string> listeNomClients = new List<string>() ;
            if (DBConnect())
            {
                string requete = "SELECT NOM_C FROM CLIENTS ORDER BY NOM_C";
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                // ajout des noms des clients dans la liste
                while (reader.Read())
                    listeNomClients.Add(reader.GetString(0));
                // déconnexion
                reader.Close();
                connect.Close();
            }
            return listeNomClients;
        }


        static public List<string> GetListeNomClients(string prenomAgent)
        {
            List<string> listeNomClients = new List<string>();
            if (DBConnect())
            {
                string requete = "SELECT NOM_C FROM CLIENTS INNER JOIN AGENTS ON CLIENTS.NUM_A = AGENTS.NUM_A"
                                + " WHERE AGENTS.PRÉNOM_A = N'"
                                + prenomAgent
                                + "' ORDER BY NOM_C";
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                // ajout des noms des clients dans la liste
                while (reader.Read())
                    listeNomClients.Add(reader.GetString(0));
                // déconnexion
                reader.Close();
                connect.Close();
            }
            return listeNomClients;
        }

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
                // ajout des noms des clients dans la liste
                while (reader.Read())
                {
                    try
                    {
                        agent = SqlDataProvider.trouverAgent(reader.GetInt16(4));
                    }
                    catch(Exception)  { agent = null; }
                    ville = SqlDataProvider.trouverVille(reader.GetInt16(5));
                    client = new Client(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), agent, ville);
                    listeClients.Add(client);
                }
                // déconnexion
                reader.Close();
                connect.Close();
            }
            return listeClients;
        }

        // TODO
        static public Client ClientExiste(string nom, Ville ville)
        {
            Client client = null;
            Agent agent;
            if (DBConnect())
            {
                string requete = "SELECT NUM_C, NOM_C, ADRESSE_C, TEL_C, NUM_A, NUM_V FROM CLIENTS WHERE NOM_C=N'"+nom+"' AND NUM_V=N'"+ville.Index+"'";
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                // ajout des noms des clients dans la liste
                while (reader.Read())
                {
                    try
                    {
                        agent = SqlDataProvider.trouverAgent(reader.GetInt16(4));
                    }
                    catch (Exception) { agent = null; }
                    try
                    {
                        Ville villeC = SqlDataProvider.trouverVille(reader.GetInt16(5));
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
