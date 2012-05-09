using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pollux.Object
{
    public class Bien
    {
        private int m_prix;
        private DateTime m_dateMiseEnVente;
        private int m_surfaceHabitable;
        private int m_surfaceJardin;
        private Ville m_ville;
        private Client m_client;
        private int m_index;

        #region Propriétés
        public int Index
        {
            get { return m_index; }
            set { m_index = value; }
        }
        public int Prix
        {
            get { return m_prix; }
            set { m_prix = value; }
        }
        public DateTime DateMiseEnVente
        {
            get { return m_dateMiseEnVente; }
            set { m_dateMiseEnVente = value; }
        }
        public int SurfaceHabitable
        {
            get { return m_surfaceHabitable; }
            set { m_surfaceHabitable = value; }
        }
        public int SurfaceJardin
        {
            get { return m_surfaceJardin; }
            set { m_surfaceJardin = value; }
        }
        public Ville Ville
        {
            get { return m_ville; }
            set { m_ville = value; }
        }
        public Client Client
        {
            get { return m_client; }
            set { m_client = value; }
        }
        #endregion
        /// <summary>
        /// Constructeur sans index
        /// </summary>
        /// <param name="prix"></param>
        /// <param name="dateMiseEnVente"></param>
        /// <param name="surfaceHabitable"></param>
        /// <param name="surfaceJardin"></param>
        /// <param name="ville"></param>
        /// <param name="client"></param>
        public Bien(int prix, DateTime dateMiseEnVente, int surfaceHabitable, int surfaceJardin, Ville ville, Client client)
        {
            m_prix = prix;
            m_dateMiseEnVente = dateMiseEnVente;
            m_surfaceHabitable = surfaceHabitable;
            m_surfaceJardin = surfaceJardin;
            m_ville = ville;
            m_client = client;
        }
        /// <summary>
        /// Constructeur avec index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="prix"></param>
        /// <param name="dateMiseEnVente"></param>
        /// <param name="surfaceHabitable"></param>
        /// <param name="surfaceJardin"></param>
        /// <param name="ville"></param>
        /// <param name="client"></param>
        public Bien(int index, int prix, DateTime dateMiseEnVente, int surfaceHabitable, int surfaceJardin, Ville ville, Client client)
        {
            m_index = index;
            m_prix = prix;
            m_dateMiseEnVente = dateMiseEnVente;
            m_surfaceHabitable = surfaceHabitable;
            m_surfaceJardin = surfaceJardin;
            m_ville = ville;
            m_client = client;
        }
    }
}
