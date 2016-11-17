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

        public int? ModifierTitreSujet(string idSujet, string titreSujet)
        {
            int idSujetInt;
            if (int.TryParse(idSujet, out idSujetInt)) return DALMain.ModifierTitreSujet(idSujetInt, titreSujet);
            return null;
        }

      
        public int? ModifierDescriptionSujet(string idSujet, string descSujet)
        {
            int idSujetInt;
            if (int.TryParse(idSujet, out idSujetInt)) return DALMain.ModifierDescriptionSujet(idSujetInt, descSujet);
            return null;
        }
        #endregion

        #region DELETE

        public int? SupprimerReponse(string idReponse)
        {
            int idReponseInt;
            if (int.TryParse(idReponse, out idReponseInt)) return DALMain.SupprimerReponse(idReponseInt);
            return null;
        }

        public int? SupprimerSujet(string idSujet)
        {
            int idSujetInt;
            if (int.TryParse(idSujet, out idSujetInt)) return DALMain.SupprimerSujet(idSujetInt);
            return null;
        }
        #endregion
    }
}
