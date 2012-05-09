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

        static private string ConstructionRequeteAjoutSouhait(Souhait souhait, Client client)
        {
            // 1- Construction des parties de requete en fonction des critères retenus
            string requeteCritereChamps = "NUM_C";
            string requeteCritereValeurs = "";
            string requeteCompCriteres = "";
            // Client
            if (souhait.Client.Index != -1)
            {
                requeteCritereValeurs = souhait.Client.Index.ToString();
                requeteCompCriteres = "NUM_C = " + souhait.Client.Index;
            }
            else
            {
                requeteCritereValeurs = string.Format("(SELECT NUM_C FROM CLIENTS WHERE NOM_C = N'{0}' AND ADRESSE_C = N'{1}')",client.Nom, client.Adresse);
                requeteCompCriteres = "NUM_C = " + requeteCritereValeurs;
            }
            // Prix
            if (souhait.PrixMax != -1)
            {
                requeteCritereChamps += ", BUDGET_MAX_S";
                requeteCritereValeurs += ", " + souhait.PrixMax;
                requeteCompCriteres += " AND BUDGET_MAX_S = " + souhait.PrixMax;
            }
            else
                requeteCompCriteres += " AND BUDGET_MAX_S IS NULL";
            // Surface Habitable
            if (souhait.SurfaceHabitableMin != -1)
            {
                requeteCritereChamps += ", SURFACE_HAB_MIN_S";
                requeteCritereValeurs += ", " + souhait.SurfaceHabitableMin;
                requeteCompCriteres += " AND SURFACE_HAB_MIN_S = " + souhait.SurfaceHabitableMin;
            }
            else
                requeteCompCriteres += " AND SURFACE_HAB_MIN_S IS NULL";
            // Surface du jardin
            if (souhait.SurfaceJardinMin != -1)
            {
                requeteCritereChamps += ", SURFACE_JARDIN_MIN_S";
                requeteCritereValeurs += ", " + souhait.SurfaceJardinMin;
                requeteCompCriteres += " AND SURFACE_JARDIN_MIN_S = " + souhait.SurfaceJardinMin;
            }
            else
                requeteCompCriteres += " AND SURFACE_JARDIN_MIN_S IS NULL";
            // 2- Construction requete pour l'ajout de l'ensemble des villes souhaitées
            string requeteVilles = "";
            if (souhait.Villes != null)
            {
                foreach (Ville ville in souhait.Villes)
                    requeteVilles = requeteVilles + "INSERT INTO VILLES_SOUHAITÉES (NUM_V, NUM_S) VALUES (N'" + ville.Index
                        + "', (SELECT NUM_S FROM SOUHAITS WHERE " + requeteCompCriteres + ")) ";
            }
            // 3- Assemblage des Requetes ajout souhait + villes souhaitées
            string requete = "INSERT INTO SOUHAITS (" + requeteCritereChamps + ") VALUES ("
                            + requeteCritereValeurs + ") " + requeteVilles;
            return requete;
        }

        static public bool AjouterSouhait(Souhait souhait)
        {
            if (DBConnect())
            {
                string requeteAjoutSouhait = ConstructionRequeteAjoutSouhait(souhait, null);
                string requete = "BEGIN TRAN "
                                + requeteAjoutSouhait
                                + "IF (@@ERROR <> 0) BEGIN ROLLBACK TRAN END "
                                + "ELSE BEGIN COMMIT TRAN END";
                OleDbCommand command = new OleDbCommand(requete, connect);
                try
                {
                    OleDbDataReader reader = command.ExecuteReader();
                }
                catch (Exception)
                {
                    connect.Close();
                    return false;
                }
                //déconnexion
                connect.Close();
                return true;
            }
            else // pas de connexion
            {
                return false;
            }
        }

        static public bool ajouterSouhaitEtClient(Client client, Souhait souhait)
        {
            if (DBConnect())
            {
                string requeteAjoutSouhait = ConstructionRequeteAjoutSouhait(souhait, client);
                //  Requete ajout du client + de son souhait
                string requete = string.Format("BEGIN TRAN "
                        + "INSERT INTO CLIENTS (NOM_C, ADRESSE_C, NUM_V, TEL_C, NUM_A) "
                        + "VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}') "
                        + requeteAjoutSouhait
                        + "IF (@@ERROR <> 0) BEGIN ROLLBACK TRAN END "
                        + "ELSE BEGIN COMMIT TRAN END",
                        client.Nom, client.Adresse, client.Ville.Index, client.Telephone, client.Agent.Index);
                OleDbCommand command = new OleDbCommand(requete, connect);
                try
                {
                    OleDbDataReader reader = command.ExecuteReader();
                }
                catch (Exception)
                {
                    connect.Close();
                    return false;
                }
                //déconnexion
                connect.Close();
                return true;
            }
            else // pas de connexion
            {
                return false;
            }
        }

        static private List<Ville> trouverVillesFromIndexSouhait(int indexSouhait)
        {
            List<Ville> listeVilles = new List<Ville>();
            int codePostal;
            string nomVille;
            int index;
            if (DBConnect())
            {
                string requete = "SELECT CODE_POSTAL_V, NOM_V, VILLES.NUM_V FROM VILLES "
                                + "INNER JOIN VILLES_SOUHAITÉES ON VILLES.NUM_V = VILLES_SOUHAITÉES.NUM_V "
                                + "WHERE VILLES_SOUHAITÉES.NUM_S = N'"
                                + indexSouhait + "' ORDER BY NOM_V";
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

        static public List<Souhait> GetListeSouhaits(Client client)
        {
            List<Ville> listeVilles = null;
            List<Souhait> listeSouhaits = new List<Souhait>();
            if (DBConnect())
            {
                string requete = "SELECT NUM_S, BUDGET_MAX_S, SURFACE_HAB_MIN_S, SURFACE_JARDIN_MIN_S FROM SOUHAITS "
                                + " WHERE SOUHAITS.NUM_C = N'"
                                + client.Index
                                + "' ORDER BY NUM_S";
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                // ajout des noms des clients dans la liste
                while (reader.Read())
                {
                    listeVilles = SqlDataProvider.trouverVillesFromIndexSouhait(reader.GetInt16(0));
                    int index = reader.GetInt16(0);
                    int prix = -1;
                    int surfHab = -1;
                    int surfJard = -1;
                    try{
                        prix = reader.GetInt32(1);
                    }catch{}
                    try{
                        surfHab = reader.GetInt16(2);
                    }catch{}
                    try{
                        surfJard = reader.GetInt16(3);
                    }catch{}
                    Souhait souhait = new Souhait(index, prix, surfHab, surfJard, listeVilles, client);
                    listeSouhaits.Add(souhait);
                }
                // déconnexion
                reader.Close();
                connect.Close();
            }
            return listeSouhaits;
        }

        
    }
}
