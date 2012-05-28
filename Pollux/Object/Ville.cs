using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pollux.DataBase;

namespace Pollux.Object
{
    public class Ville
    {  
        private int m_index;
        private int m_codePostal;
        private string m_nom;

        #region Propriétés
        public int Index
        {
            get { return m_index; }
            set { m_index = value; }
        }
        public int CodePostal
        {
            get { return m_codePostal; }
            set { m_codePostal = value; }
        }
        public string Nom
        {
            get { return m_nom; }
            set { m_nom = value; }
        }
        #endregion

        public Ville(int codePostal, string nom, int index)
        {
            m_codePostal = codePostal;
            m_nom = nom;
            m_index = index;
        }

        public Ville(int codePostal, string nom)
        {
            m_codePostal = codePostal;
            m_nom = nom;
            m_index = SqlDataProvider.TrouverVille(codePostal, nom);
        }
       
        public override string ToString()
        {
            return m_nom + " (" + m_codePostal + ")";
        }
    }
}
