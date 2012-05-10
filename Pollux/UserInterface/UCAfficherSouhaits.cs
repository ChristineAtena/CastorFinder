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
    public partial class UCAfficherSouhaits : UserControl
    {
        List<Souhait> listeSouhaits;
        public UCAfficherSouhaits(List<Souhait> listeSouhaits)
        {
            this.listeSouhaits = listeSouhaits;
            InitializeComponent();
            remplissageListView();
        }

        private void remplissageListView()
        {
            string prix;
            string surfHab;
            string surfJard;
            string villes;
            foreach (Souhait souhait in listeSouhaits)
            {
                villes = "";
                foreach (Ville ville in souhait.Villes)
                    villes += ville.Nom + ", ";
                prix = (souhait.PrixMax == -1) ? "n/c" : souhait.PrixMax.ToString() + " €";
                surfHab = (souhait.SurfaceHabitableMin == -1) ? "n/c" : souhait.SurfaceHabitableMin.ToString() + " m²";
                surfJard = (souhait.SurfaceJardinMin == -1) ? "n/c" : souhait.SurfaceJardinMin.ToString() + " m²";
                ListViewItem item = new ListViewItem(new String[] { prix, surfHab, surfJard, villes });
                listViewSouhaits.Items.Add(item);
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
