﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foradev
{
    public sealed class Sujet : Message
    {
        #region Champs et Propriétés

        private int _IdSujet;
        public int IdSujet
        {
            get { return _IdSujet; }
            set { _IdSujet = value; }
        }

        public string PseudoUtilisateur
        {
            get { return base.Utilisateur.Pseudo; }
        }

        public Rubrique _Rubrique { get; set; }

        private List<Reponse> _Reponse { get; set; }

        private string _TitreSujet;
        public string TitreSujet
        {
            get { return _TitreSujet; }
            set { _TitreSujet = value; }
        }

        #endregion

        #region Constructeurs

        //Constructeur complet
        public Sujet(Utilisateur utilisateur, DateTime dateMessage, Rubrique rubrique, int idSujet, string titreSujet, string texteMessage)
                     : base(utilisateur, dateMessage, texteMessage) {
            TitreSujet = titreSujet;
            _Rubrique = rubrique;
            IdSujet = idSujet;
        }

        //ESSAI AUTRES CONSTRUCTEURS

        //public Sujet(Utilisateur utilisateur, Rubrique rubrique, int idSujet, string titreSujet, string texteMessage) { }

        //public Sujet(int idSujet, string titreSujet, string texteMessage) { }

        //public Sujet(string titreSujet, string texteMessage) { }

        #endregion

        #region Methodes
        #endregion

        #region Methodes héritées et substituées

        public override string ToString()
        {
            return base.DateMessage.ToString() + TitreSujet + TexteMessage;
        }
        #endregion

        #region Methodes à implementer pour les interfaces
        #endregion

    }
}
