using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pollux.Object
{
        public class Souhait
        {
            private int m_prixMax;
            private int m_surfaceHabitableMin;
            private int m_surfaceJardinMin;
            private List<Ville> m_villes;

            #region Propriétés
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
            #endregion

            public Souhait(int prixMax, int surfaceHab, int surfJard, List<Ville> villes)
            {
                m_prixMax = prixMax;
                m_surfaceHabitableMin = surfaceHab;
                m_surfaceJardinMin = surfJard;
                m_villes = villes;
            }
        }
}
