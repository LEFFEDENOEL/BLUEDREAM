using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foradev
{
    public sealed class Sujet : Message
    {

        #region Champs et Propriétés

        private Rubrique _Rubrique { get; set; }
        private List<Reponse> _Reponse { get; set; }

        #endregion

        #region Constructeurs

        public Sujet(Utilisateur utilisateur, DateTime datemessage, string textmessage) : base(utilisateur, datemessage, textmessage) { }

        #endregion

        #region Methodes
        #endregion

        #region Methodes héritées et substituées
        #endregion

        #region Methodes à implementer pour les interfaces
        #endregion

    }
}
