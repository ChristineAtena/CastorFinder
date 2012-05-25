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
        // Cherche le bien dont l'index est fourni en paramètre et le retourne
        // sinon retourne null
        static private Bien TrouverBien(int index)
        {
            Bien bien = null;
            if (DBConnect())
            {
                string requete = "SELECT * FROM BIENS WHERE NUM_B = " + index;
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())  // si il remonte une ligne, le bien a été trouvé
                {
                    Ville ville = TrouverVille(reader.GetInt16(1));
                    Client client = TrouverClient(reader.GetInt16(2));
                    int prix = reader.GetInt32(3);
                    DateTime date = reader.GetDateTime(4);
                    int surfHab = reader.GetInt16(5);
                    int surfJard = reader.GetInt16(6);
                    bien = new Bien(index, prix, date,surfHab, surfJard, ville, client);
                }
                // déconnexion
                reader.Close();
                connect.Close();
            }
            return bien;
        }


        static public List<Bien> GetListeBiens()
        {
            List<Bien> listeBiens = new List<Bien>();
            Ville ville;
            int index;
            int prix;
            int surfHab;
            int surfJard;
            DateTime date;
            Client client;
            Bien bien;
            if (DBConnect())
            {
                string requete = "SELECT NUM_B, PRIX_VENTE_B, SURFACE_HAB_B, SURFACE_JARDIN_B, "
                                + "DATE_MISE_EN_VENTE_B, VILLES.NUM_V, NOM_V, CODE_POSTAL_V, BIENS.NUM_C "
                                + "FROM BIENS INNER JOIN VILLES ON BIENS.NUM_V = VILLES.NUM_V "
                                + "ORDER BY NUM_B";
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                // ajout des biens dans la liste
                while (reader.Read())
                {
                    index = reader.GetInt16(0);
                    prix = reader.GetInt32(1);
                    surfHab = reader.GetInt16(2);
                    surfJard = reader.GetInt16(3);
                    date = reader.GetDateTime(4);
                    ville = new Ville(reader.GetInt32(7), reader.GetString(6), reader.GetInt16(5));
                    client = SqlDataProvider.TrouverClient(reader.GetInt16(8));
                    bien = new Bien(index, prix, date, surfHab, surfJard, ville, client);
                    listeBiens.Add(bien);
                }
                // déconnexion
                reader.Close();
                connect.Close();
            }
            return listeBiens;
        }


        static public List<Bien> GetListeBiens(Client client)
        {
            List<Bien> listeBiens = new List<Bien>();
            if (DBConnect())
            {
                string requete = "SELECT NUM_B, PRIX_VENTE_B, SURFACE_HAB_B, SURFACE_JARDIN_B, "
                                +"DATE_MISE_EN_VENTE_B, VILLES.NUM_V, NOM_V, CODE_POSTAL_V FROM BIENS "
                                +"INNER JOIN VILLES ON BIENS.NUM_V = VILLES.NUM_V "
                                +"WHERE BIENS.NUM_C = N'"
                                + client.Index
                                +"' ORDER BY NUM_B";
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                // ajout des biens dans la liste
                while (reader.Read())
                {
                    Ville ville = new Ville(reader.GetInt32(7), reader.GetString(6), reader.GetInt16(5));
                    int index = reader.GetInt16(0);
                    int prix = reader.GetInt32(1);
                    int surfHab = reader.GetInt16(2);
                    int surfJard = reader.GetInt16(3);
                    DateTime date = reader.GetDateTime(4);
                    Bien bien = new Bien(index, prix, date, surfHab, surfJard, ville, client);
                    listeBiens.Add(bien);
                }
                // déconnexion
                reader.Close();
                connect.Close();
            }
            return listeBiens;
        }
        /// <summary>
        /// construction de la requête de recherche de bien
        /// </summary>
        /// <param name="bien">bien provisoire</param>
        /// <returns>requete</returns>
        static private string ConstructionRequeteRechercheBien(Bien bien)
        {
            string requetePrix = (bien.Prix != -1) ? " PRIX_VENTE_B < " + bien.Prix : "";
            string requeteSurfHab = (bien.SurfaceHabitable != -1) ? " SURFACE_HAB_B > " + bien.SurfaceHabitable : "";
            string requeteSurfJard = (bien.SurfaceJardin != -1) ? " SURFACE_JARDIN_B > " + bien.SurfaceJardin : "";
            string requeteVille = (bien.Ville != null) ? " NUM_V = " + bien.Ville.Index : "";
            string requeteDate = (bien.DateMiseEnVente.Year != 1) ? " DATE_MISE_EN_VENTE_B < '" + bien.DateMiseEnVente.Day + "/" + bien.DateMiseEnVente.Month + "/" + bien.DateMiseEnVente.Year + "'" : "";
            string requete = "SELECT * FROM BIENS WHERE" + requetePrix;
            if (requetePrix != "" && requeteSurfHab != "")
                requete += " AND ";
            requete += requeteSurfHab;
            if ((requetePrix != "" || requeteSurfHab != "") && requeteSurfJard != "")
                requete += " AND ";
            requete += requeteSurfJard;
            if ((requetePrix != "" || requeteSurfHab != "" || requeteSurfJard != "") && requeteVille != "")
                requete += " AND ";
            requete += requeteVille;
            if ((requetePrix != "" || requeteSurfHab != "" || requeteSurfJard != "" || requeteVille != "") && requeteDate != "")
                requete += " AND ";
            requete += requeteDate;
            return requete;
        }


        static private string ConstructionRequeteRechercheBien(Souhait souhait)
        {
            string requetePrix = (souhait.PrixMax != -1) ? " PRIX_VENTE_B < " + souhait.PrixMax : "";
            string requeteSurfHab = (souhait.SurfaceHabitableMin != -1) ? " SURFACE_HAB_B > " + souhait.SurfaceHabitableMin : "";
            string requeteSurfJard = (souhait.SurfaceJardinMin != -1) ? " SURFACE_JARDIN_B > " + souhait.SurfaceJardinMin : "";
            string requeteVille = (souhait.Villes.Count == 0) ? "":
                 " BIENS.NUM_V IN"
                +"(SELECT VILLES_SOUHAITÉES.NUM_V FROM VILLES_SOUHAITÉES"
	            +" INNER JOIN SOUHAITS ON VILLES_SOUHAITÉES.NUM_S = SOUHAITS.NUM_S"
	            +" WHERE SOUHAITS.NUM_S = " + souhait.Index
                +")";
            string requete = "SELECT * FROM BIENS WHERE" + requetePrix;
            if (requetePrix != "" && requeteSurfHab != "")
                requete += " AND ";
            requete += requeteSurfHab;
            if ((requetePrix != "" || requeteSurfHab != "") && requeteSurfJard != "")
                requete += " AND ";
            requete += requeteSurfJard;
            if ((requetePrix != "" || requeteSurfHab != "" || requeteSurfJard != "") && requeteVille != "")
                requete += " AND ";
            requete += requeteVille;
            return requete;
        }

        static public List<Bien> RechercherListeBiens(Bien bien)
        {
            List<Bien> listeBiens = new List<Bien>();
            if (DBConnect())
            {
                string requete = ConstructionRequeteRechercheBien(bien);
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                // ajout des biens dans la liste
                while (reader.Read())
                {
                    int index = reader.GetInt16(0);
                    Ville ville = SqlDataProvider.TrouverVille(reader.GetInt16(1));
                    Client client = SqlDataProvider.TrouverClient(reader.GetInt16(2));
                    int prix = reader.GetInt32(3);
                    DateTime date = reader.GetDateTime(4);
                    int surfHab = reader.GetInt16(5);
                    int surfJard = reader.GetInt16(6);
                    Bien bienTrouve = new Bien(index, prix, date.Date, surfHab, surfJard, ville, client);
                    listeBiens.Add(bienTrouve);
                }
                // déconnexion
                reader.Close();
                connect.Close();
            }
            return listeBiens;
        }

        static public List<Bien> RechercherListeBiens(Souhait souhait)
        {
            List<Bien> listeBiens = new List<Bien>();
            if (DBConnect())
            {
                string requete = ConstructionRequeteRechercheBien(souhait);
                OleDbCommand command = new OleDbCommand(requete, connect);
                OleDbDataReader reader = command.ExecuteReader();
                // ajout des biens dans la liste
                while (reader.Read())
                {
                    int index = reader.GetInt16(0);
                    Ville ville = SqlDataProvider.TrouverVille(reader.GetInt16(1));
                    Client client = SqlDataProvider.TrouverClient(reader.GetInt16(2));
                    int prix = reader.GetInt32(3);
                    DateTime date = reader.GetDateTime(4);
                    int surfHab = reader.GetInt16(5);
                    int surfJard = reader.GetInt16(6);
                    Bien bienTrouve = new Bien(index, prix, date.Date, surfHab, surfJard, ville, client);
                    listeBiens.Add(bienTrouve);
                }
                // déconnexion
                reader.Close();
                connect.Close();
            }
            return listeBiens;
        }

        // Ajout du bien fournit en paramètre dans la base
        static public bool AjouterBien(Bien bien)
        {
            bool ajout = false;
            // si pas de connexion
            if (!DBConnect())
                ajout = false;
            // si connexion
            else
            {
                string requete = string.Format("INSERT INTO BIENS (PRIX_VENTE_B, DATE_MISE_EN_VENTE_B, SURFACE_HAB_B, SURFACE_JARDIN_B, NUM_V, NUM_C) VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')",
                    bien.Prix, bien.DateMiseEnVente, bien.SurfaceHabitable, bien.SurfaceJardin, bien.Ville.Index, bien.Client.Index);
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

        /// <summary>
        /// Ajoute à la fois le bien et le client ou n'ajoute rien
        /// </summary>
        /// <param name="client">Client à ajouter</param>
        /// <param name="bien">Bien à ajouter</param>
        /// <returns></returns>
        static public bool AjouterBienEtClient(Client client, Bien bien)
        {
            bool ajout = false;
            if (DBConnect())
            {
                string requete = string.Format("BEGIN TRAN "
                                + "INSERT INTO CLIENTS (NOM_C, ADRESSE_C, NUM_V, TEL_C) "
                                + "VALUES (N'{0}',N'{1}',N'{2}',N'{3}') "
                                + "INSERT INTO BIENS (PRIX_VENTE_B, DATE_MISE_EN_VENTE_B, SURFACE_HAB_B, SURFACE_JARDIN_B, NUM_V, NUM_C) "
                                + "VALUES (N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', "
                                + "(SELECT NUM_C FROM CLIENTS WHERE NOM_C = N'{0}' AND ADRESSE_C = N'{1}')) "
                                + "IF (@@ERROR <> 0) BEGIN ROLLBACK TRAN END "
                                + "ELSE BEGIN COMMIT TRAN END",
                                client.Nom, client.Adresse, client.Ville.Index, client.Telephone,
                                bien.Prix, bien.DateMiseEnVente, bien.SurfaceHabitable, bien.SurfaceJardin, bien.Ville.Index);
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
    }
}
