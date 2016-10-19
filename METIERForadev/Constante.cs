using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METIERForadev
{
    /// <summary>
    /// Classe de traitement des constantes d'erreurs chargées depuis la base de données
    /// </summary>
    public class Constante
    {
        #region Champs et Propriétés

        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _Reference;

        public string Reference
        {
            get { return _Reference; }
            set { _Reference = value; }
        }

        private string _Valeur1;

        public string Valeur1
        {
            get { return _Valeur1; }
            set { _Valeur1 = value; }
        }

        private string _Valeur2;

        public string Valeur2
        {
            get { return _Valeur2; }
            set { _Valeur2 = value; }
        }
        #endregion

        #region Constructeurs

        //Constructeur complet
        public Constante(int id, string reference, string valeur1, string valeur2)
        {
            Id = id;
            Reference = reference;
            Valeur1 = valeur1;
            Valeur2 = valeur2;
        }

        // Constructeur remarquable 

        public Constante(string reference, string valeur1, string valeur2)
        {           
            Reference = reference;
            Valeur1 = valeur1;
            Valeur2 = valeur2;
        }
        #endregion

        #region Methodes
        #endregion

        #region Methodes héritées et substituées

        public override string ToString()
        {
            return Reference;
        }
        #endregion

        #region Methodes à implementer pour les interfaces
        #endregion


    }
}
