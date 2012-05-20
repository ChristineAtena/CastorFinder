﻿using System;
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
        private List<Visite> calendrier = new List<Visite>();
        private DateTime date;

        #region Propriétés
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        #endregion

        public TrouverRDV(Agent agent, Bien bien)
        {
            InitializeComponent();
            labelNom.Text = agent.Prenom;
            monthCalendar.MinDate = bien.DateMiseEnVente.Date;
            calendrier = SqlDataProvider.TrouverListeVisites(agent);
            buttonValider.Enabled = false;
            // remplissage du calendrier avec les rendez-vous du jour
            RemplissageCalendrierDuJour(DateTime.Now);
        }

        /// <summary>
        /// Remplissage de la listViewJour avec les rendez-vous prévus 
        /// pour le jour fourni en paramètre
        /// </summary>
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
                }
            }
        }

        // Modification du calendrier du jour en fonction du jour sélectionné
        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            RemplissageCalendrierDuJour(e.Start);
        }

        // Activation du bouton Valider si la plage horaire sélectionnée est libre
        private void listViewJour_SelectedIndexChanged(object sender, EventArgs e)
        {
          /*   if (listViewJour.SelectedItems.Count == 0)
                 buttonValider.Enabled = false;
             else if (listViewJour.SelectedItems[0].SubItems[1].Text != "") 
                     buttonValider.Enabled = true;
                  else
                     buttonValider.Enabled = false;
           */
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
            date = new DateTime(monthCalendar.SelectionStart.Year, 
                                monthCalendar.SelectionStart.Month, 
                                monthCalendar.SelectionStart.Day,
                                listViewJour.SelectedItems[0].Index+8, 0,0);
        }
    }
}
