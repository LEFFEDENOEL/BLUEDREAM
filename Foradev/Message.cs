﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foradev
{
    /// <summary>
    /// Classe abstraite Message dérivée en classes filles Sujet et Reponse
    /// </summary>
    public abstract class Message
    {
        #region Champs et Propriétés

        //Association vers classe Utilisateur
        protected Utilisateur Utilisateur { get; set; }

        public string PseudoUtilisateur
        {
            get { return Utilisateur.Pseudo; }
        }

        private DateTime _DateMessage;
        public DateTime DateMessage
        {
            get { return _DateMessage; }
            set { _DateMessage = value; }
        }

        private string _TexteMessage;
        public string TexteMessage
        {
            get { return _TexteMessage; }
            set { _TexteMessage = value; }
        }
        #endregion

        #region Constructeurs

        //Constructeur par défaut
        public Message() { }
        
        //Constructeur complet 
        protected Message(Utilisateur utilisateur, DateTime dateMessage, string texteMessage)
        {
            DateMessage = dateMessage;
            TexteMessage = texteMessage;
            Utilisateur = utilisateur;
        }
        #endregion

        #region Methodes


        #endregion

        #region Methodes héritées et substituées

        // A ENLEVER ??
        //public override string ToString()
        //{
        //    return DateMessage + TexteMessage;
        //}

        #endregion

        #region Methodes à implementer pour les interfaces
        #endregion


    }
}
