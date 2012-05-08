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

        static public List<Souhait> GetListeSouhaits(Souhait souhait)
        {
            List<Souhait> listeSouhaits = null;
            // TODO retourne la liste des biens correspondant au bien fournit en paramètre
            // voir si en paramètres c'est mieux ça ou chaque attribut


            return listeSouhaits;
        }

        
    }
}
