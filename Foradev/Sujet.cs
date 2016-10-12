using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Foradev
{
    /// <summary>
    /// Classe non dérivable qui hérite de la classe Message
    /// </summary>
    public sealed class Sujet : Message
    {
        #region Champs et Propriétés

        //Association à la classe Rubrique

        public Rubrique _Rubrique { get; set; }

        //Association à la classe Reponse
        private List<Reponse> _Reponse { get; set; }

        private int _IdSujet;
        public int IdSujet
        {
            get { return _IdSujet; }
            set { _IdSujet = value; }
        }

        //public string PseudoUtilisateur
        //{
        //    get { return Utilisateur.Pseudo; }
        //}

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

        //Constructeurs remarquables
        public Sujet(Utilisateur utilisateur, Rubrique rubrique, int idSujet, string titreSujet, string texteMessage) { }

        public Sujet(int idSujet, string titreSujet, string texteMessage) { }

        public Sujet(string titreSujet, string texteMessage) { }

        #endregion

        #region Methodes

        public void PosterMessage()
        {

        }

        public void GetSujetsByRubrique()
        {
            //List<Sujet> listeSujets = DAOPrincipale.GetSujetsByRubrique(cbxListeRubriques.SelectedValue.ToString());
        }

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
