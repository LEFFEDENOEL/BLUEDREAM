using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using METIERForadev;
using DALForadev;


namespace WcfForadev
{
    public class ServiceForadev : IServiceForadev
    {
        #region CREATE

        /// <summary>
        /// Méthode ajout réponse / Parse des string en entrée dans les types souhaités.
        /// Renvoie NULL si echec
        /// </summary>
        /// <param name="idSujet"></param>
        /// <param name="idUtilisateur"></param>
        /// <param name="texteReponse"></param>
        /// <param name="dateReponse"></param>
        /// <returns></returns>
        public int? AjoutReponse(string idSujet, string idUtilisateur, string texteReponse, string dateReponse)
        {
            int idSujetInt;
            int idUtilisateurInt;
            DateTime dateReponseDate;
            if (int.TryParse(idSujet, out idSujetInt) & int.TryParse(idUtilisateur, out idUtilisateurInt) 
                                                      & DateTime.TryParse(dateReponse, out dateReponseDate))
                return DALMain.AjoutReponse(idSujetInt, idUtilisateurInt, texteReponse, dateReponseDate);
            return null;
        }


        /// <summary>
        /// Méthode ajout sujet / Parse des string en entrée dans les types souhaites.
        /// Revoie NULL si echec
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <param name="idRubrique"></param>
        /// <param name="titreSujet"></param>
        /// <param name="descriptionSujet"></param>
        /// <param name="dateCreationSujet"></param>
        /// <returns></returns>
        public int? AjoutSujet(string idUtilisateur, string idRubrique, string titreSujet, string descriptionSujet, string dateCreationSujet)
        {
            int idUtilisateurInt;
            int idRubriqueInt;
            DateTime dateCreationSujetDate;
            if (int.TryParse(idUtilisateur, out idUtilisateurInt) & int.TryParse(idRubrique, out idRubriqueInt)
                                                      & DateTime.TryParse(dateCreationSujet, out dateCreationSujetDate))
                return DALMain.AjoutSujet(idUtilisateurInt, idRubriqueInt, titreSujet, descriptionSujet, dateCreationSujetDate);
            return null;
        }
        #endregion

        #region RETRIEVE

        public List<Rubrique> GetRubriques()
        {
            return DALMain.GetRubriques();
        }

        public Dictionary<string, Constante> GetConstantes()
        {
            return DALMain.GetConstantes();
        }

        public List<Sujet> GetSujetsByRubrique(string nomRubrique)
        {
            return DALMain.GetSujetsByRubrique(nomRubrique);
        }

        public List<Reponse> GetReponsesBySujet(string titreSujet)
        {
            return DALMain.GetReponsesBySujet(titreSujet);

        }

        #endregion

        #region UPDATE

        /// <summary>
        /// Méthode de mise à jour d'un titre sujet / Parse string en entrée de idSujet dans le type int souhaité.
        /// Renvoie NULL si echec
        /// </summary>
        /// <param name="idSujet"></param>
        /// <param name="titreSujet"></param>
        /// <returns></returns>
        public int? ModifierTitreSujet(string idSujet, string titreSujet)
        {
            int idSujetInt;
            if (int.TryParse(idSujet, out idSujetInt)) return DALMain.ModifierTitreSujet(idSujetInt, titreSujet);
            return null;
        }

        /// <summary>
        /// Méthode de mise à jour d'une description sujet / Parse string en entrée de idSujet dans le type int souhaité
        /// </summary>
        /// <param name="idSujet"></param>
        /// <param name="descSujet"></param>
        /// <returns></returns>
        public int? ModifierDescriptionSujet(string idSujet, string descSujet)
        {
            int idSujetInt;
            if (int.TryParse(idSujet, out idSujetInt)) return DALMain.ModifierDescriptionSujet(idSujetInt, descSujet);
            return null;
        }
        #endregion

        #region DELETE

        /// <summary>
        /// Méthode de suppression d'une réponse / Parse string en entrée de idReponse dans le type int souhaité.
        /// Renvoie NULL si echec
        /// </summary>
        /// <param name="idReponse"></param>
        /// <returns></returns>
        public int? SupprimerReponse(string idReponse)
        {
            int idReponseInt;
            if (int.TryParse(idReponse, out idReponseInt)) return DALMain.SupprimerReponse(idReponseInt);
            return null;
        }

        /// <summary>
        /// Méthode de suppression d'un sujet / Parse string en entrée de idSujet dans le type int souhaité
        /// </summary>
        /// <param name="idSujet"></param>
        /// <returns></returns>
        public int? SupprimerSujet(string idSujet)
        {
            int idSujetInt;
            if (int.TryParse(idSujet, out idSujetInt)) return DALMain.SupprimerSujet(idSujetInt);
            return null;
        }
        #endregion
    }
}
