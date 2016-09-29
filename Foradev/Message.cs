using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foradev
{
    public abstract class Message
    {

        #region Champs et Propriétés
        protected Utilisateur Utilisateur { get; set; }

        private DateTime _DateMessage;
        public DateTime DateMessage
        {
            get { return _DateMessage; }

            set { _DateMessage = value; }
        }

        private string _TextMessage;
        public string TextMessage
        {
            get { return _TextMessage; }

            set { _TextMessage = value; }
        }


        #endregion

        #region Constructeurs

        //Constructeur par défaut
        public Message() { }
        
        //Constructeur complet
        public Message(Utilisateur utilisateur, DateTime datemessage, string textmessage)
        {
            _DateMessage = datemessage;
            _TextMessage = textmessage;
        }
        #endregion

        #region Methodes
        #endregion

        #region Methodes héritées et substituées

        public override string ToString()
        {
            return "Utilisateur : " + Utilisateur.Nom + "Date du message : " + DateMessage + "Texte du message : " + TextMessage;
        }
        #endregion

        #region Methodes à implementer pour les interfaces
        #endregion


    }
}
