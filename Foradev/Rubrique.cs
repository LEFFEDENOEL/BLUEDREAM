﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foradev
{
    public class Rubrique
    {

        #region Champs et Propriétés

        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _Nom;

        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }

        #endregion

        #region Constructeurs

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
            return "Rubrique : " + Nom;
        }

        #endregion

        #region Methodes à implementer pour les interfaces
        #endregion

    }
}
