using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foradev
{
    public sealed class Ordinaire : UtilisateurConnecte
    {

        #region Champs et Propriétés
        #endregion

        #region Constructeurs

        public Ordinaire(string nom, string prenom, string mail, bool role, string pseudo, DateTime dtinscription)
                         : base(nom, prenom, mail, role, pseudo, dtinscription) { }

        public Ordinaire(string nom, string prenom, string pseudo, DateTime dtinscription)
                         : base(nom, prenom, pseudo, dtinscription) { }
        #endregion

        #region Methodes
        #endregion

        #region Methodes héritées et substituées

        public override bool PosterMessage(Message Message)
        {
            return true;
        }

        public override string ToString()
        {
            return base.ToString();// TODO par rapport a ToString de Utilisateur mais pas obligé
        }

        #endregion

        #region Methodes à implementer pour les interfaces
        #endregion

    }
}
