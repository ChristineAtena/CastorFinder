using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pollux.Object;
using Pollux.DataBase;

namespace Pollux.UserInterface
{
    public partial class TrouverRDV : Form
    {
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        private List<Visite> calendrier = new List<Visite>();
        public TrouverRDV(Agent agent, Bien bien)
        {
            InitializeComponent();
            labelNom.Text = agent.Prenom;
            monthCalendar.MinDate = bien.DateMiseEnVente;
            calendrier = SqlDataProvider.TrouverListeVisites(agent);
            buttonValider.Enabled = false;
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            foreach (ListViewItem lv in listViewJour.Items)
                lv.SubItems[1].Text = "";
            foreach (Visite v in calendrier)
            {
                if (v.DateHeure.Date == e.Start)
                {
                    listViewJour.Items[v.DateHeure.Hour - 8].SubItems[1].Text = v.Souhait.Client.Nom;
                }
            }
        }

        private void listViewJour_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listViewJour.SelectedItems[0].SubItems[1].Text != "")
                    buttonValider.Enabled = false;
            }
            catch
            {
                buttonValider.Enabled = true;
            }
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            date = new DateTime(monthCalendar.SelectionStart.Year, monthCalendar.SelectionStart.Month, monthCalendar.SelectionStart.Day,listViewJour.SelectedItems[0].Index +8, 0,0);
        }
    }
}
