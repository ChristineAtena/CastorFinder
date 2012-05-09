using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pollux.Object
{
        public class Souhait
        {
            private int m_index;
            private int m_prixMax;
            private int m_surfaceHabitableMin;
            private int m_surfaceJardinMin;
            private List<Ville> m_villes;
            private Client m_client;

            #region Propriétés
            public int Index
            {
                get { return m_index; }
                set { m_index = value; }
            }
            public int PrixMax
            {
                get { return m_prixMax; }
                set { m_prixMax = value; }
            }
            public int SurfaceHabitableMin
            {
                get { return m_surfaceHabitableMin; }
                set { m_surfaceHabitableMin = value; }
            }
            public int SurfaceJardinMin
            {
                get { return m_surfaceJardinMin; }
                set { m_surfaceJardinMin = value; }
            }
            public List<Ville> Villes
            {
                get { return m_villes; }
                set { m_villes = value; }
            }
            public Client Client
            {
                get { return m_client; }
                set { m_client = value; }
            }
            #endregion

            public Souhait(int prixMax, int surfaceHab, int surfJard, List<Ville> villes, Client client)
            {
                m_prixMax = prixMax;
                m_surfaceHabitableMin = surfaceHab;
                m_surfaceJardinMin = surfJard;
                m_villes = villes;
                m_client = client;
            }
            /// <summary>
            /// Constructeur de souhait avec index
            /// </summary>
            /// <param name="index">index</param>
            /// <param name="prixMax">prix maximum</param>
            /// <param name="surfaceHab">surface habitable minimum</param>
            /// <param name="surfJard">surface de jardin minimum</param>
            /// <param name="villes">liste de villes</param>
            /// <param name="client">client</param>
            public Souhait(int index, int prixMax, int surfaceHab, int surfJard, List<Ville> villes, Client client)
            {
                m_index = index;
                m_prixMax = prixMax;
                m_surfaceHabitableMin = surfaceHab;
                m_surfaceJardinMin = surfJard;
                m_villes = villes;
                m_client = client;
            }
        }
}
