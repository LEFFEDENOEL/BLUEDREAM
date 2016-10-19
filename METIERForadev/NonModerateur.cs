using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METIERForadev
{
    /// <summary>
    /// Classe NonModerateur non dérivable, hérite de UtilisateurConnecte
    /// </summary>
    public sealed class NonModerateur : UtilisateurConnecte
    {
        #region Champs et Propriétés
        #endregion

        #region Constructeurs

        // Constructeur par défaut null
        public NonModerateur() { }

        // Constructeur complet
        public NonModerateur(int id, string nom, string prenom, string mail, string login, bool role, string pseudo, DateTime dtinscription)
                             : base(id, nom, prenom, mail, login, role, pseudo, dtinscription) { }

        // Constructeur remarquable
        public NonModerateur(int id, string nom, string prenom, string pseudo, DateTime dtinscription)
                             : base(id, nom, prenom, pseudo, dtinscription) { }
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
