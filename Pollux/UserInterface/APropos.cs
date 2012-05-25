using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pollux.UserInterface
{
    public partial class APropos : Form
    {
        public APropos()
        {
            InitializeComponent();
            texte.Links.Add(72, 13, "mailto:julien.bellue@etu.u-bordeaux1.fr");
            texte.Links.Add(87, 16, "mailto:olivier.defossez@etu.u-bordeaux1.fr");
            texte.Links.Add(105, 17, "mailto:christine.delpech@etu.u-bordeaux1.fr");
            texte.Links.Add(124, 28, "mailto:marie-noelle.ripolldemarti@etu.u-bordeaux1.fr");
        }

        private void texte_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString()+"?subject=CastorFinder");
        }
    }
}
