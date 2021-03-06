﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace METIERForadev
{
    /// <summary>
    /// Classe non dérivable qui hérite de la classe Message
    /// </summary>
    [DataContract]
    public sealed class Sujet : Message
    {
        #region Champs et Propriétés

        //Association à la classe Rubrique
        [DataMember]
        public Rubrique Rubrique { get; set; }

        //Association à la classe Reponse
        [DataMember]
        private List<Reponse> _Reponse { get; set; }

        private int _IdSujet;

        [DataMember]
        public int IdSujet
        {
            get { return _IdSujet; }
            set { _IdSujet = value; }
        }
      
        private string _TitreSujet;

        [DataMember]
        public string TitreSujet
        {
            get { return _TitreSujet; }
            set { _TitreSujet = value; }
        }
        #endregion

        #region Constructeurs

        // Constructeur par défaut
        public Sujet() { }

        // Constructeur complet
        public Sujet (Utilisateur utilisateur, DateTime dateMessage, Rubrique rubrique, int idSujet, string titreSujet, string texteMessage)
                     : base(utilisateur, dateMessage, texteMessage) {

            TitreSujet = titreSujet;
            Rubrique = rubrique;
            IdSujet = idSujet;
        }

        // Constructeurs remarquables
        public Sujet(Utilisateur utilisateur, Rubrique rubrique, int idSujet, string titreSujet, string texteMessage) { }

        public Sujet(int idSujet, string titreSujet, string texteMessage) { }

        public Sujet(string titreSujet, string texteMessage) { }
        #endregion

        #region Methodes
        #endregion

        #region Methodes héritées et substituées

        public override string ToString()
        {
            return TitreSujet;
        }
        #endregion

        #region Methodes à implementer pour les interfaces
        #endregion

    }
}
