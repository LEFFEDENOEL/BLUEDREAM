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
        #endregion

        #region Methodes
        #endregion

        #region Methodes héritées et substituées

        public override bool PosterMessage(Message Message)
        {
            return true;
        }
        #endregion

        #region Methodes à implementer pour les interfaces
        #endregion
      
    }
}
