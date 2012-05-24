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
    public partial class AgendaAgent : Form
    {
        private List<Visite> calendrier = new List<Visite>();
        public AgendaAgent()
        {
            InitializeComponent();
            loadAgents();
        }
        private void loadAgents()
        {
            comboBoxAgents.Items.Clear();
            List<Agent> listeAgents = SqlDataProvider.GetListeAgents();
            comboBoxAgents.DataSource = listeAgents;
        }

        private void chargerAgenda(Agent agent)
        {
            calendrier = SqlDataProvider.TrouverListeVisites(agent);
            RemplissageCalendrierDuJour(DateTime.Now);
            //on enlève tout le gras du jambon
            monthCalendar.RemoveAllBoldedDates();
            //on met en gras les date où il y a des rendez-vous
            foreach (Visite v in calendrier)
            {
                monthCalendar.AddBoldedDate(v.DateHeure.Date);
            }
            monthCalendar.SelectionStart = DateTime.Now; //et on sélectionne la date du jour, sinon c'est bizarre
            monthCalendar.UpdateBoldedDates();
        }

        private void buttonAfficher_Click(object sender, EventArgs e)
        {
            chargerAgenda((Agent)comboBoxAgents.SelectedItem);
        }

        private void RemplissageCalendrierDuJour(DateTime date)
        {
            // Initialisation subItem correspondant au client à ""
            foreach (ListViewItem lv in listViewJour.Items)
                lv.SubItems[1].Text = "";
            // Remplissage de la listView avec les noms des clients qui ont un rendez-vous ce jour là
            foreach (Visite v in calendrier)
            {
                if (v.DateHeure.Date == date.Date)
                {
                    listViewJour.Items[v.DateHeure.Hour - 8].SubItems[1].Text = v.Souhait.Client.Nom;
                    listViewJour.Items[v.DateHeure.Hour - 8].Tag = v;
                }
            }
        }

        // Modification du calendrier du jour en fonction du jour sélectionné
        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            RemplissageCalendrierDuJour(e.Start);
        }

        private void listViewJour_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listViewJour.SelectedItems[0].SubItems[1].Text != "")
                {
                    textBoxNumBien.Text = ((Visite)listViewJour.SelectedItems[0].Tag).Bien.Index.ToString();
                    textBoxNomProprio.Text = ((Visite)listViewJour.SelectedItems[0].Tag).Bien.Client.Nom;
                }
            }
            catch
            {
                textBoxNumBien.Text = "";
                textBoxNomProprio.Text = "";
            }
        }
    }
}
