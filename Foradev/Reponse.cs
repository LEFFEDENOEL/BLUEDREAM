using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foradev
{
    public sealed class Reponse : Message
    {
        #region Champs et Propriétés

        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private Sujet _Sujet;

        public Sujet Sujet
        {
            get { return _Sujet; }
            set { _Sujet = value; }
        }
        public string PseudoUtilisateur
        {
            get { return Utilisateur.Pseudo; }
        }

        #endregion

        #region Constructeurs
        public Reponse(Utilisateur utilisateur, DateTime dateCreation, string texteMessage, int idReponse, Sujet sujet) 
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
