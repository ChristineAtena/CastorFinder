using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pollux.Object;

namespace Pollux.UserInterface
{
    public partial class UCAfficherBiens : UserControl
    {
        private List<Bien> listeBiens;
        public UCAfficherBiens(List <Bien> listeBiens)
        {
            InitializeComponent();
            this.listeBiens = listeBiens;
            remplissageListView();
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
                listViewBiens.Items.Add(item);
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
