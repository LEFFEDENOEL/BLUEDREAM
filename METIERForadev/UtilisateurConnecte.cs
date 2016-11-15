using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace METIERForadev
{
    /// <summary>
    /// Classe abstraite UtilisateurConnecte dérivée en classes filles NonModerateur et Moderateur, hérite de Utilisateur
    /// </summary>

    [DataContract]
    [KnownType(typeof(NonModerateur))]
    [KnownType(typeof(Moderateur))]
    public abstract class UtilisateurConnecte : Utilisateur
    {
        #region Champs et Propriétés
        #endregion

        #region Constructeurs

        // Constructeur de base null
        public UtilisateurConnecte() { }

        // Constructeur complet

        public UtilisateurConnecte(int id, string nom, string prenom, string mail, string login, bool role, string pseudo, DateTime dtinscription)
                                   : base(id, nom, prenom, mail, login, role, pseudo, dtinscription) { }

        // Constructeur remarquable
        public UtilisateurConnecte(int id, string nom, string prenom, string pseudo, DateTime dtinscription)
                                   : base(id,nom, prenom, pseudo, dtinscription) { }

        #endregion

        #region Methodes

        abstract public bool PosterMessage(Message message);

        #endregion

        #region Methodes héritées et substituées

        public override string ToString()
        {
            return base.ToString();// TODO par rapport a ToString de Utilisateur mais pas obligé
        }

        #endregion

        #region Methodes à implementer pour les interfaces
        #endregion

    }
}
