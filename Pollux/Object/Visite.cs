using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pollux.Object
{
    public class Visite
    {
        private DateTime m_dateHeure;
        private Souhait m_souhait;
        private Bien m_bien;
        private int m_index;

        #region Propriétés
        public Souhait Souhait
        {
            get { return m_souhait; }
            set { m_souhait = value; }
        }
        public DateTime DateHeure
        {
            get { return m_dateHeure; }
            set { m_dateHeure = value; }
        }
        public Bien Bien
        {
            get { return m_bien; }
            set { m_bien = value; }
        }
        #endregion

        public Visite(int index, Souhait souhait, Bien bien, DateTime date)
        {
            m_index = index;
            m_souhait = souhait;
            m_bien = bien;
            m_dateHeure = date;
        }
    }
}
