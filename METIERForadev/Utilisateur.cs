using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace METIERForadev
{
    /// <summary>
    /// Classe abstraite Utilisateur dérivée en classes filles UtilisateurNonConnecte et UtilisateurConnecte
    /// </summary>
    [DataContract]
    [KnownType(typeof(UtilisateurConnecte))]
    [KnownType(typeof(UtilisateurNonConnecte))]
    public abstract class Utilisateur
    {
        #region Champs et Propriétés

        protected int _Id;

        [DataMember]
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        protected string _Nom;

        [DataMember]
        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value;}
        }

        protected string _Prenom;

        [DataMember]
        public string Prenom
        {
            get { return _Prenom; }

            set { _Prenom = value; }
        }

        protected string _Mail;

        [DataMember]
        public string Mail
        {
            get { return _Mail; }

            set { _Mail = value; }
        }

        protected string _Login;

        [DataMember]
        public string Login
        {
            get { return _Login; }
            set { _Login = value; }
        }
        protected bool _Role;

        [DataMember]
        public bool Role
        {
            get { return _Role; }

            set { _Role = value; }
        }

        protected string _Pseudo;

        [DataMember]
        public string Pseudo
        {
            get { return _Pseudo; }

            set { _Pseudo = value; }
        }

        protected DateTime _DateInscription;

        [DataMember]
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

        protected Utilisateur(int id, string nom, string prenom, string mail, string login, bool role, string pseudo, DateTime dtinscription)
        {
            Id = id;  Nom = nom; Prenom = prenom; Mail = mail; Login = login; Role = role; Pseudo = pseudo; DateInscription = dtinscription;
        }

        //Constructeur remarquable
        protected Utilisateur(int id, string nom, string prenom, string pseudo, DateTime dtinscription)
        {
            Id = id; Nom = nom; Prenom = prenom; Pseudo = pseudo; DateInscription = dtinscription;
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
            return Pseudo;
        }
        #endregion

        #region Methodes à implementer pour les interfaces
        #endregion

    }
}
