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

        public override string ToString()
        {
            return TexteMessage;
        }

        #endregion

        #region Methodes à implementer pour les interfaces
        #endregion


    }
}
