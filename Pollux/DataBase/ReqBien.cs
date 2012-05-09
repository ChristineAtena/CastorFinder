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

        static public List<Bien> GetListeBiens(Bien bien)
        {
            List<Bien> listeBiens = null;
            // TODO retourne la liste des biens correspondant au bien fournit en paramètre
            // voir si en paramètres c'est mieux ça ou chaque attribut


            return listeBiens;
        }

        /// <summary>
        /// ça marche, c'est cool
        /// </summary>
        /// <param name="client">Client à ajouter</param>
        /// <param name="bien">Bien à ajouter</param>
        /// <returns></returns>
        static public bool ajouterBienEtClient(Client client, Bien bien)
        {
            // si connexion
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
            else
            {
                return false;
            }
        }
    }
}
