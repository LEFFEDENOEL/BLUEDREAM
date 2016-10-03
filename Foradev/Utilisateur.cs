using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foradev
{
    public abstract class Utilisateur
    {

        #region Champs et Propriétés

        protected string _Nom;
        public string Nom
        {
            get { return _Nom; }

            set { _Nom = value;}
        }

        protected string _Prenom;
        public string Prenom
        {
            get { return _Prenom; }

            set { _Prenom = value; }
        }

        protected string _Mail;
        public string Mail
        {
            get { return _Mail; }

            set { _Mail = value; }
        }

        protected bool _Role;
        public bool Role
        {
            get { return _Role; }

            set { _Role = value; }
        }

        protected string _Pseudo;
        public string Pseudo
        {
            get { return _Pseudo; }

            set { _Pseudo = value; }
        }

        protected DateTime _DateInscription;
        public DateTime DateInscription
        {
            get { return _DateInscription; }

            set { _DateInscription = value; }
        }

        #endregion

        #region Constructeurs

        //Constructeur par défaut
        protected Utilisateur (){ }

        //Constructeur complet

        protected Utilisateur(string nom, string prenom, string mail, bool role, string pseudo, DateTime dtinscription)
        {
            Nom = nom; Prenom = prenom; Mail = mail; Role = role; Pseudo = pseudo; DateInscription = dtinscription;
        }

        //Constructeur remarquable
        protected Utilisateur(string nom, string prenom, string pseudo, DateTime dtinscription)
        {
            Nom = nom; Prenom = prenom; Pseudo = pseudo; DateInscription = dtinscription;
        }
        #endregion

        #region Methodes
        
        public static bool Identification(string login, string motdepasse)
        {
            //TODO
            return true;
        }
        public static bool ChangePass(string motdepasse, string newmotdepasse)
        {
            //TODO
            return true;
        }

        #endregion

        #region Methodes héritées et substituées

        public override string ToString()
        {
            return "Nom : " + Nom + "Prénom : " + Prenom + "Adresse mail : " + Mail + "Role : " + Role
                    + "Pseudo : " + Pseudo + "Date d'inscription : " + DateInscription;
        }
        #endregion

        #region Methodes à implementer pour les interfaces
        #endregion

    }
}
