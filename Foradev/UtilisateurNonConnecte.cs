using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foradev
{
    public sealed class UtilisateurNonConnecte : Utilisateur
    {

        #region Champs et Propriétés
        #endregion

        #region Constructeurs

        public UtilisateurNonConnecte(string nom, string prenom, string mail, bool role, string pseudo, DateTime dtinscription)
                                 : base(nom, prenom, mail, role, pseudo, dtinscription) { }

        public UtilisateurNonConnecte(string nom, string prenom, string pseudo, DateTime dtinscription)
                         : base(nom, prenom, pseudo, dtinscription) { }
        #endregion

        #region Methodes
        #endregion
        #region Methodes héritées et substituées
        #endregion
        #region Methodes à implementer pour les interfaces
        #endregion


    }
}
