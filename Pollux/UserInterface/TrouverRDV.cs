using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pollux.Object;

namespace Pollux.UserInterface
{
    public partial class TrouverRDV : Form
    {
        public TrouverRDV(Agent agent, Bien bien)
        {
            InitializeComponent();
            labelNom.Text = agent.Prenom;
            monthCalendar.MinDate = bien.DateMiseEnVente;
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
