using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace METIERForadev
{
    /// <summary>
    /// Classe Reponse non dérivable, hérite de Message
    /// </summary>
    [DataContract]
    public sealed class Reponse : Message
    {
        #region Champs et Propriétés

        private int _Id;

        [DataMember]
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private Sujet _Sujet;

        [DataMember]
        public Sujet Sujet
        {
            get { return _Sujet; }
            set { _Sujet = value; }
        }

        #endregion

        #region Constructeurs

        // Constructeur par défaut
        public Reponse() { }

        // Constructeur complet
        public Reponse (Utilisateur utilisateur, DateTime dateCreation, string texteMessage, int idReponse, Sujet sujet) 
                       : base(utilisateur, dateCreation, texteMessage)
        {
            Id = idReponse;
            Sujet = sujet;
        }
        #endregion

        #region Methodes
        #endregion

        #region Methodes héritées et substituées

        public override string ToString()
        {
            return TexteMessage;
        }
        #endregion

        #region Methodes à implementer pour les interfaces
        #endregion

    }
}
