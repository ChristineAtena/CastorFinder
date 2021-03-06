﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pollux.Object;
using Pollux.DataBase;

namespace Pollux.UserInterface
{
    public partial class UCAfficherSouhaits : UserControl
    {
        private List<Souhait> listeSouhaits;
        private Bien bien = null;
        
        public UCAfficherSouhaits(Souhait souhait)
        {
            InitializeComponent();
            listeSouhaits = SqlDataProvider.RechercherListeSouhaits(souhait);
            remplissageListView();
            buttonAjouter.Enabled = false;
        }

        public UCAfficherSouhaits(Bien bien)
        {
            InitializeComponent();
            listeSouhaits = SqlDataProvider.RechercherListeSouhaits(bien);
            this.bien = bien;
            remplissageListView();
            buttonAjouter.Enabled = false;
        }

        #region Activation bouton Ajouter une visite
        private void listViewSouhaits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSouhaits.SelectedItems.Count != 0)
                buttonAjouter.Enabled = true;
            else
                buttonAjouter.Enabled = false;
        }
        #endregion

        private void remplissageListView()
        {
            string nomClient;
            string prix;
            string surfHab;
            string surfJard;
            string villes;
            foreach (Souhait souhait in listeSouhaits)
            {
                villes = "";
                foreach (Ville ville in souhait.Villes)
                    villes += ville.Nom + ", ";
                nomClient = souhait.Client.Nom;
                prix = (souhait.PrixMax == -1) ? "n/c" : souhait.PrixMax.ToString() + " €";
                surfHab = (souhait.SurfaceHabitableMin == -1) ? "n/c" : souhait.SurfaceHabitableMin.ToString() + " m²";
                surfJard = (souhait.SurfaceJardinMin == -1) ? "n/c" : souhait.SurfaceJardinMin.ToString() + " m²";
                ListViewItem item = new ListViewItem(new String[] { nomClient, prix, surfHab, surfJard, villes });
                item.Tag = souhait;
                listViewSouhaits.Items.Add(item);
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (listViewSouhaits.SelectedItems.Count != 0)
            {
                if (bien != null)
                {
                    // appel de la fenetre visite avec un bien et un souhait
                    ((FenetrePrincipale)this.Parent).MdiChild = new UCAjouterVisite((Souhait)listViewSouhaits.SelectedItems[0].Tag, bien);
                }
                else
                {
                    // appel de la fenetre visite avec juste un souhait
                    ((FenetrePrincipale)this.Parent).MdiChild = new UCAjouterVisite((Souhait)listViewSouhaits.SelectedItems[0].Tag);
                }
                ((FenetrePrincipale)this.Parent).init();
                this.Dispose();
            }
        }

    }
}
