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
    public partial class ConnexionBDD : Form
    {
        private string adresse;
        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        public ConnexionBDD(string adresse)
        {
            this.adresse = adresse;
            InitializeComponent();
            textBoxAdresse.Text = adresse;
            textBoxAdresse.SelectAll();
            this.AcceptButton = buttonOK;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            adresse = textBoxAdresse.Text;
        }
    }
}
