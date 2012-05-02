﻿using System;
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
        /// A FINIR ! C'est dégueulasse !!
        /// </summary>
        /// <param name="c"></param>
        /// <param name="bien"></param>
        /// <returns></returns>
        static public bool ajouterBienEtClient(Client c, Bien bien)
        {
            bool ajout = false;
            // si connexion
            if (DBConnect())
            {
                string requete;

                //ajout client
                requete = string.Format("INSERT INTO CLIENTS (NOM_C, ADRESSE_C, NUM_V, TEL_C) VALUES (N'{0}',N'{1}',N'{2}',N'{3}')", c.Nom, c.Adresse, c.Ville.Index, c.Telephone);
                OleDbCommand command = new OleDbCommand(requete, connect);
                int rowCount = command.ExecuteNonQuery();
                if (rowCount == 1)
                {
                    c.Index = SqlDataProvider.trouverClient(c.Nom, c.Adresse);  // ajout client effectué
                    //déconnexion
                    connect.Close();

                    DBConnect();
                    //ajout bien
                    requete = string.Format("INSERT INTO BIENS (PRIX_VENTE_B, DATE_MISE_EN_VENTE_B, SURFACE_HAB_B, SURFACE_JARDIN_B, NUM_V, NUM_C) VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')",
                    bien.Prix, bien.DateMiseEnVente, bien.SurfaceHabitable, bien.SurfaceJardin, bien.Ville.Index, bien.Client.Index);
                    command = new OleDbCommand(requete, connect);
                    rowCount = command.ExecuteNonQuery();
                    if (rowCount == 1)
                    {
                        ajout = true;  // ajout effectué
                    }
                    //déconnexion
                    connect.Close();
                }
            }
            return ajout;
        }
    }
}
