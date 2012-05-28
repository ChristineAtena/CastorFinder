using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pollux.DataBase;

namespace Pollux.Object
{
    public class Client
    {
        private int m_index = -1;
        private string m_nom;
        private string m_adresse;
        private string m_telephone;
        private Agent m_agent = null;
        private Ville m_ville;

        #region Propriétés
        public int Index
        {
            get { return m_index; }
            set { m_index = value; }
        }
        public string Nom
        {
            get { return m_nom; }
            set { m_nom = value; }
        }
        public string Adresse
        {
            get { return m_adresse; }
            set { m_adresse = value; }
        }
        public string Telephone
        {
            get { return m_telephone; }
            set { m_telephone = value; }
        }        
        public Agent Agent
        {
            get { return m_agent; }
            set { m_agent = value; }
        }
        public Ville Ville
        {
            get { return m_ville; }
            set { m_ville = value; }
        }
        #endregion

        #region constructeurs Client avec index
        /// <summary>
        /// Constructeur avec les index des villes et des agents
        /// </summary>
        /// <param name="index">index du client</param>
        /// <param name="nom">nom du client</param>
        /// <param name="adresse">adresse du client</param>
        /// <param name="telephone">n° de téléphone du client</param>
        /// <param name="index_agent">index de l'agent</param>
        /// <param name="index_ville">index de la ville</param>
        public Client(int index, string nom, string adresse, string telephone, int index_agent, int index_ville)
        {
            m_index = index;
            m_nom = nom;
            m_adresse = adresse;
            m_telephone = telephone;
            m_agent = SqlDataProvider.TrouverAgent(index_agent);
            m_ville = SqlDataProvider.TrouverVille(index_ville);
        }

        /// <summary>
        /// Constructeur avec la ville et l'agent
        /// </summary>
        /// <param name="index">index du client</param>
        /// <param name="nom">nom du client</param>
        /// <param name="adresse">adresse du client</param>
        /// <param name="telephone">n° de téléphone du client</param>
        /// <param name="agent">agent assigné</param>
        /// <param name="ville">ville</param>
        public Client(int index, string nom, string adresse, string telephone, Agent agent, Ville ville)
        {
            m_index = index;
            m_nom = nom;
            m_adresse = adresse;
            m_telephone = telephone;
            m_agent = agent;
            m_ville = ville;
        }
        #endregion
        #region Constructeurs Clients sans index
        /// <summary>
        /// Constructeur sans index, avec les index de l'agent de la ville
        /// </summary>
        /// <param name="nom">nom du client</param>
        /// <param name="adresse">adresse du client</param>
        /// <param name="telephone">n° de téléphone du client</param>
        /// <param name="index_agent">index de son agent</param>
        /// <param name="index_ville">index de sa ville</param>
        public Client(string nom, string adresse, string telephone, int index_agent, int index_ville)
        {
            m_nom = nom;
            m_adresse = adresse;
            m_telephone = telephone;
            m_agent = SqlDataProvider.TrouverAgent(index_agent);
            m_ville = SqlDataProvider.TrouverVille(index_ville);
        }

        /// <summary>
        /// Constructeur sans index, avec l'index de la ville
        /// </summary>
        /// <param name="nom">nom du client</param>
        /// <param name="adresse">adresse du client</param>
        /// <param name="telephone">n° de téléphone du client</param>
        /// <param name="index_ville">index de sa ville</param>
        public Client(string nom, string adresse, string telephone, int index_ville)
        {
            m_nom = nom;
            m_adresse = adresse;
            m_telephone = telephone;
            m_ville = SqlDataProvider.TrouverVille(index_ville);
        }

        /// <summary>
        /// Constructeur sans index, avec une ville et un agent
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="adresse"></param>
        /// <param name="telephone"></param>
        /// <param name="agent"></param>
        /// <param name="ville"></param>
        public Client(string nom, string adresse, string telephone, Agent agent, Ville ville)
        {
            m_nom = nom;
            m_adresse = adresse;
            m_telephone = telephone;
            m_agent = agent;
            m_ville = ville;
        }
        #endregion

        public override string ToString()
        {
            return m_nom ;
        }
    }
}
