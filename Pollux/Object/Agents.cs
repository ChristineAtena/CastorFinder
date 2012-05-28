namespace Pollux.Object
{
    public class Agent
    {
        private int m_index;
        private string m_prenom;
        
        #region Propriétés
        public int Index
        {
            get { return m_index; }
            set { m_index = value; }
        }
        public string Prenom
        {
            get { return m_prenom; }
            set { m_prenom = value; }
        }
        #endregion

        /// <summary>
        /// Constructeur d'agent
        /// </summary>
        /// <param name="index">index de l'agent</param>
        /// <param name="prenom">Prénom de l'agent</param>
        public Agent(int index, string prenom)
        {
            m_index = index;
            m_prenom = prenom;
        }

        public override string ToString()
        {
            return m_prenom;
        }
    }
}
