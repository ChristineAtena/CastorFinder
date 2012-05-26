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
        // Cherche le souhait dont l'index est fourni en paramètre et le retourne
        // sinon retourne null
        static private Souhait TrouverSouhait (int index)
        {
            Souhait souhait = null;
            if (DBConnect())
            {
                string requete = "SELECT * FROM SOUHAITS WHERE NUM_S = " + index;
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())  // si il remonte une ligne, le souhait a été trouvé
                {
                    Client client = TrouverClient(reader.GetInt16(1));
                    int budget = !DBNull.Value.Equals(reader[2]) ? reader.GetInt32(2) : -1;
                    int surfHab = !DBNull.Value.Equals(reader[3]) ? reader.GetInt16(3) : -1;
                    int surfJard = !DBNull.Value.Equals(reader[4]) ? reader.GetInt16(4) : -1;
                    souhait = new Souhait(index, budget, surfHab, surfJard, TrouverVillesFromIndexSouhait(index), client);
                }
                // déconnexion
                reader.Close();
                connect.Close();
            }
            return souhait;
        }

     /*   static private string ConstructionRequeteAjoutSouhait(Souhait souhait, Client client)
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
        */

        // Construction requête pour l'insertion d'un souhait en base
        static private string ConstructionRequeteAjoutSouhait(Souhait souhait)
        {
            // Construction partie 'VALUES'
            string requeteValues = Convert.ToString(souhait.Client.Index);
            requeteValues += (souhait.PrixMax != -1) ? ", " + souhait.PrixMax : ", NULL";
            requeteValues += (souhait.SurfaceHabitableMin != -1) ? ", " + souhait.SurfaceHabitableMin : ", NULL";
            requeteValues += (souhait.SurfaceJardinMin != -1) ? ", " + souhait.SurfaceJardinMin : ", NULL";
            // Construction requete insertion d'un souhait
            // @vSouhaitId = variable permettant de récupérer l'identifiant du souhait inséré
            string requete = "declare @vSouhaitId smallint "
                        + "INSERT INTO SOUHAITS (NUM_C, BUDGET_MAX_S, SURFACE_HAB_MIN_S, SURFACE_JARDIN_MIN_S) "
                        + "VALUES (" + requeteValues + ") "
                        + "set @vSouhaitId  = @@IDENTITY ";
            return requete;
        }

        // Construction requête pour l'insertion des villes souhaitées
        // /!\ on ne connait pas l'index du souhait 
        // car son ajout sera effectué en même temps que celui des villes souhaitées
        static private string ConstructionRequeteAjoutVillesSouhaitees(Souhait souhait)
        {
            // construction d'une requête INSERT pour chaque ville souhaitée
            string requeteVilles = "";
            if (souhait.Villes != null)
            {
                foreach (Ville ville in souhait.Villes)
                    requeteVilles = requeteVilles + " INSERT INTO VILLES_SOUHAITÉES (NUM_V, NUM_S) "
                        + "VALUES (" + ville.Index + ", @vSouhaitId) ";
            }
            return requeteVilles;
        }

        /// <summary>
        /// Ajoute à la fois le souhait et les villes souhaitées 
        /// dans les tables correspondantes ou n'ajoute rien si l'une des insertions échoue
        /// 
        /// J'ai pas bien pris le temps de lire comme ça marchait, ça, mais ça à l'air vraiment con :
        /// on connait le client, vu qu'il est spécifié, alors pourquoi on galère à retrouver son
        /// numéro dans la BdD ?
        /// C'est peut-être idiot comme remarque, mais j'ai plus trop le courage de déchiffrer
        /// la construction de la requete =)
        /// 
        /// Courage !
        /// ==> ça m'a l'air pas mal maintenant.. bcp plus clair
        /// 
        /// </summary>
        static public bool AjouterSouhait(Souhait souhait, Agent agent)
        {
            bool ajout = false;
            if (DBConnect())
            {
                string requeteAjoutSouhait = ConstructionRequeteAjoutSouhait(souhait);
                string requeteAjoutVillesSouhaitees = ConstructionRequeteAjoutVillesSouhaitees(souhait);
                string requeteMAJAgent = "";
                if (agent != null)
                    requeteMAJAgent = " UPDATE CLIENTS SET NUM_A=" + agent.Index + " WHERE NUM_C=" + souhait.Client.Index;
                string requete = "BEGIN TRAN "
                                + requeteAjoutSouhait
                                + requeteAjoutVillesSouhaitees
                                + requeteMAJAgent
                                + " IF (@@ERROR <> 0) BEGIN ROLLBACK TRAN END "
                                + "ELSE BEGIN COMMIT TRAN END";
                OleDbCommand command = new OleDbCommand(requete, connect);
                try
                {
                    OleDbDataReader reader = command.ExecuteReader();
                    ajout = true;
                    reader.Close();
                }
                catch { }
                //déconnexion
                connect.Close();
            }
            return ajout;   
        }


        // Construction requête pour l'insertion d'un client et de son souhait en base
        static private string ConstructionRequeteAjoutSouhaitEtClient(Souhait souhait, Client client)
        {
            // construction partie 'VALUES'
            string requeteValues = "@vClientId";
            requeteValues += (souhait.PrixMax != -1) ? ", " + souhait.PrixMax : ", NULL";
            requeteValues += (souhait.SurfaceHabitableMin != -1) ? ", " + souhait.SurfaceHabitableMin : ", NULL";
            requeteValues += (souhait.SurfaceJardinMin != -1) ? ", " + souhait.SurfaceJardinMin :", NULL";
            // construction requete insertion client
            // @vClientId = variable permettant de récupérer l'identifiant du client inséré
            string requete = "declare @vClientId smallint "
                        + "INSERT INTO CLIENTS (NOM_C, ADRESSE_C, NUM_V, TEL_C, NUM_A) "
                        + "VALUES (N'" + client.Nom + "', N'" + client.Adresse + "', " + client.Ville.Index
                        + ", N'" + client.Telephone + "', " + client.Agent.Index + ") "
                        + "set @vClientId  = @@IDENTITY ";
            // construction requete insertion souhait
            // @vSouhaitId = variable permettant de récupérer l'identifiant du souhait inséré
            requete += "declare @vSouhaitId smallint "
                        + "INSERT INTO SOUHAITS (NUM_C, BUDGET_MAX_S, SURFACE_HAB_MIN_S, SURFACE_JARDIN_MIN_S) "
                        + "VALUES (" + requeteValues + ") "
                        + "set @vSouhaitId  = @@IDENTITY ";
            return requete;
        }

        /// <summary>
        /// Ajoute à la fois le client, son souhait et les villes souhaitées 
        /// dans les tables correspondantes ou n'ajoute rien si l'une des insertions échoue
        /// </summary>
        static public bool AjouterSouhaitEtClient(Souhait souhait, Client client)
        {
            bool ajout = false;
            if (DBConnect())
            {
                string requeteAjoutSouhaitEtClient = ConstructionRequeteAjoutSouhaitEtClient(souhait, client);
                string requeteAjoutVillesSouhaitees = ConstructionRequeteAjoutVillesSouhaitees(souhait);
                //  Requete ajout du client + de son souhait
                string requete = "BEGIN TRAN "
                        + requeteAjoutSouhaitEtClient
                        + requeteAjoutVillesSouhaitees
                        + " IF (@@ERROR <> 0) BEGIN ROLLBACK TRAN END "
                        + "ELSE BEGIN COMMIT TRAN END";
                OleDbCommand command = new OleDbCommand(requete, connect);
                try
                {
                    OleDbDataReader reader = command.ExecuteReader();
                    ajout = true;
                    reader.Close();
                }
                catch { }
                //déconnexion     
                connect.Close();
            }
            return ajout;
        }

        static private List<Ville> TrouverVillesFromIndexSouhait(int indexSouhait)
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
                    listeVilles = SqlDataProvider.TrouverVillesFromIndexSouhait(reader.GetInt16(0));
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


        //TODO : quand un souhait ne spécifie pas de ville, il doit être séléctionné sur un filtre ville.
        static private string ConstructionRequeteRechercheSouhait(Souhait souhait)
        {
            string requetePrix = (souhait.PrixMax != -1) ? " (BUDGET_MAX_S > " + souhait.PrixMax + " OR BUDGET_MAX_S IS NULL)" : "(BUDGET_MAX_S > -1 OR BUDGET_MAX_S IS NULL)";
            string requeteSurfHab = (souhait.SurfaceHabitableMin != -1) ? " (SURFACE_HAB_MIN_S < " + souhait.SurfaceHabitableMin + " OR SURFACE_HAB_MIN_S IS NULL)" : "(SURFACE_HAB_MIN_S > -1 OR SURFACE_HAB_MIN_S IS NULL)";
            string requeteSurfJard = (souhait.SurfaceJardinMin != -1) ? " (SURFACE_JARDIN_MIN_S < " + souhait.SurfaceJardinMin + " OR SURFACE_JARDIN_MIN_S IS NULL)" : "(SURFACE_JARDIN_MIN_S > -1 OR SURFACE_JARDIN_MIN_S IS NULL)";
            string requeteVille = (souhait.Villes.Count != 0) ? " (VILLES_SOUHAITÉES.NUM_V = " + souhait.Villes[0].Index + " OR VILLES_SOUHAITÉES.NUM_V IS NULL)" : "";
            string requete = "SELECT SOUHAITS.NUM_S, SOUHAITS.NUM_C, BUDGET_MAX_S, SURFACE_HAB_MIN_S, SURFACE_JARDIN_MIN_S "
                            + "FROM SOUHAITS LEFT OUTER JOIN VILLES_SOUHAITÉES ON SOUHAITS.NUM_S = VILLES_SOUHAITÉES.NUM_S ";
            string criteres = requetePrix;
            criteres += " AND ";
            criteres += requeteSurfHab;
            criteres += " AND ";
            criteres += requeteSurfJard;
            if (requeteVille != "")
                criteres += " AND " + requeteVille;
            requete += " WHERE " + criteres 
                + " GROUP BY SOUHAITS.NUM_S, SOUHAITS.NUM_C, BUDGET_MAX_S, SURFACE_HAB_MIN_S, SURFACE_JARDIN_MIN_S "
                + " ORDER BY SOUHAITS.NUM_C";
            return requete;
        }

        static private string ConstructionRequeteRechercheSouhait(Bien bien)
        {
            string requetePrix = " (BUDGET_MAX_S > " + bien.Prix + " OR BUDGET_MAX_S IS NULL) ";
            string requeteSurfHab = " (SURFACE_HAB_MIN_S < " + bien.SurfaceHabitable + " OR SURFACE_HAB_MIN_S IS NULL) ";
            string requeteSurfJard = " (SURFACE_JARDIN_MIN_S < " + bien.SurfaceJardin + " OR SURFACE_JARDIN_MIN_S IS NULL) ";
            string requeteVille = " (VILLES_SOUHAITÉES.NUM_V = " + bien.Ville.Index + " OR VILLES_SOUHAITÉES.NUM_V IS NULL) ";
            string requete = "SELECT SOUHAITS.NUM_S, SOUHAITS.NUM_C, BUDGET_MAX_S, SURFACE_HAB_MIN_S, SURFACE_JARDIN_MIN_S "
                            + "FROM SOUHAITS LEFT OUTER JOIN VILLES_SOUHAITÉES ON SOUHAITS.NUM_S = VILLES_SOUHAITÉES.NUM_S ";
            string criteres = requetePrix;
            criteres += " AND ";
            criteres += requeteSurfHab;
            criteres += " AND ";
            criteres += requeteSurfJard;
            if (requeteVille != "")
                criteres += " AND " + requeteVille;
            requete += " WHERE " + criteres
                + " GROUP BY SOUHAITS.NUM_S, SOUHAITS.NUM_C, BUDGET_MAX_S, SURFACE_HAB_MIN_S, SURFACE_JARDIN_MIN_S "
                + " ORDER BY SOUHAITS.NUM_C";
            return requete;
        }

        static public List<Souhait> RechercherListeSouhaits(Souhait souhait)
        {
            int prix = -1;
            int surfHab = -1;
            int surfJard = -1;
            List<Souhait> listeSouhaits = new List<Souhait>();
            if (DBConnect())
            {
                string requete = ConstructionRequeteRechercheSouhait(souhait);
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    List<Ville> villes = souhait.Villes;
                    int index = reader.GetInt16(0);
                    Client client = TrouverClient(reader.GetInt16(1));
                    try
                    {
                        prix = reader.GetInt32(2);
                    }
                    catch
                    {
                        prix = -1;
                    }
                    try
                    {
                        surfHab = reader.GetInt16(3);
                    }
                    catch 
                    {
                        surfHab = -1;
                    }
                    try
                    {
                        surfJard = reader.GetInt16(4);
                    }
                    catch
                    {
                        surfJard = -1;
                    }
                    Souhait souhaitTrouve = new Souhait(index, prix, surfHab, surfJard, villes, client);
                    listeSouhaits.Add(souhaitTrouve);
                }
                // déconnexion
                reader.Close();
                connect.Close();
            }
            return listeSouhaits;
        }

        static public List<Souhait> RechercherListeSouhaits(Bien bien)
        {
            int prix = -1;
            int surfHab = -1;
            int surfJard = -1;
            List<Ville> villes = new List<Ville>();
            List<Souhait> listeSouhaits = new List<Souhait>();
            if (DBConnect())
            {
                string requete = ConstructionRequeteRechercheSouhait(bien);
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                // ajout des souhaits dans la liste
                while (reader.Read())
                {
                    villes.Clear();
                    villes.Add(bien.Ville);
                    int index = reader.GetInt16(0);
                    Client client = TrouverClient(reader.GetInt16(1));
                    try
                    {
                        prix = reader.GetInt32(2);
                    }
                    catch
                    {
                        prix = -1;
                    }
                    try
                    {
                        surfHab = reader.GetInt16(3);
                    }
                    catch
                    {
                        surfHab = -1;
                    }
                    try
                    {
                        surfJard = reader.GetInt16(4);
                    }
                    catch
                    {
                        surfJard = -1;
                    }
                    Souhait souhaitTrouve = new Souhait(index, prix, surfHab, surfJard, villes, client);
                    listeSouhaits.Add(souhaitTrouve);
                }
                // déconnexion
                reader.Close();
                connect.Close();
            }
            return listeSouhaits;
        }

    }
}
