using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foradev
{
    public sealed class Moderateur : UtilisateurConnecte
    {

        #region Champs et Propriétés
        #endregion

        #region Constructeurs
        //Constructeur par défaut : base

        //public Moderateur(string nom, string prenom, string mail, bool role, string pseudo, DateTime dtinscription) 
        //                 : base (nom, prenom, mail, role, pseudo, dtinscription) { }
        #endregion

        #region Methodes

        //Methodes spécialisées pour un modérateur
        public void Modifier()
        {
            //TODO
        }
        public void Supprimer()
        {
            //TODO
        }

        #endregion

        #region Methodes héritées et substituées

        public override string ToString()
        {
            return base.ToString();// TODO par rapport a ToString de Utilisateur mais pas obligé
        }
        public override bool PosterMessage(Message Message)
        {
            return true;
        }

        #endregion

        #region Methodes à implementer pour les interfaces
        #endregion

    }
}
