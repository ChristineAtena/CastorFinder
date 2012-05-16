using System;
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
    public partial class UCAfficherBiens : UserControl
    {
        private List<Bien> listeBiens;
        private Souhait souhait = null;

        public UCAfficherBiens(Bien bien)
        {
            InitializeComponent();
            listeBiens = SqlDataProvider.RechercherListeBiens(bien);
            remplissageListView();
        }

        public UCAfficherBiens(Souhait souhait)
        {
            InitializeComponent();
            listeBiens = SqlDataProvider.RechercherListeBiens(souhait);
            remplissageListView();
            //test
            this.souhait = souhait;
            //test
        }

        private void remplissageListView()
        {
            //listViewBiens.Clear();
            string prix;
            string surfHab;
            string surfJard;
            string ville;
            string date;
            foreach (Bien bien in listeBiens)
            {
                ville = bien.Ville.Nom;
                prix = bien.Prix.ToString() + " €";
                surfHab = bien.SurfaceHabitable.ToString() + " m²";
                surfJard = bien.SurfaceJardin.ToString() + " m²";
                date = bien.DateMiseEnVente.ToShortDateString();
                ListViewItem item = new ListViewItem(new String[] { prix, surfHab, surfJard, ville, date });
                item.Tag = bien;
                listViewBiens.Items.Add(item);
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (listViewBiens.SelectedItems.Count != 0)
            {
                if (souhait != null)
                {
                    ((FenetrePrincipale)this.Parent).MdiChild = new UCAjouterVisite(souhait, (Bien)listViewBiens.SelectedItems[0].Tag);
                }
                else
                {
                    ((FenetrePrincipale)this.Parent).MdiChild = new UCAjouterVisite((Bien)listViewBiens.SelectedItems[0].Tag);
                }
                ((FenetrePrincipale)this.Parent).init();
                this.Dispose();
            }
        }
    }
}
