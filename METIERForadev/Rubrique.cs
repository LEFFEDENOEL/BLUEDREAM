using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace METIERForadev
{
    /// <summary>
    /// Classe Rubrique en association avec la classe Sujet
    /// </summary>
    [DataContract]
    public class Rubrique
    {
        #region Champs et Propriétés

        private int _Id;

        [DataMember]
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _Nom;

        [DataMember]
        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }
        #endregion

        #region Constructeurs

        // Constructeur par défaut
        public Rubrique() { }

        // Constructeur complet
        public Rubrique(int idRubrique, string nom)
        {
            Id = idRubrique;
            Nom = nom;
        }
        #endregion

        #region Methodes
        #endregion

        #region Methodes héritées et substituées

        public override string ToString()
        {
            return Nom;
        }
        #endregion

        #region Methodes à implementer pour les interfaces
        #endregion

    }
}
