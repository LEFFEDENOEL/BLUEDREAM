using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using METIERForadev;


namespace WcfForadev
{
   
    [ServiceContract]
    public interface IServiceForadev
    {
        #region CREATE

        [OperationContract]
        [WebInvoke(Method = "POST",
                   UriTemplate = "/AjoutReponse",
                   BodyStyle = WebMessageBodyStyle.WrappedRequest,
                   ResponseFormat = WebMessageFormat.Json)]
        int? AjoutReponse(string idSujet, string idUtilisateur, string texteReponse, string dateReponse);

        #endregion

        #region RETRIEVE

        /// <summary>
        /// Renvoie la liste des rubriques du forum
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebGet(UriTemplate = "/Rubriques",
                ResponseFormat = WebMessageFormat.Json)]
        List<Rubrique> GetRubriques();

        /// <summary>
        /// Renvoie le dictionnaire des constantes
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebGet(UriTemplate = "/Constantes",
                ResponseFormat = WebMessageFormat.Xml)]
        Dictionary<string, Constante> GetConstantes();

        /// <summary>
        /// Renvoie la liste des sujets par rubrique en paramètre d'entrée
        /// </summary>
        /// <param name="nomRubrique"></param>
        /// <returns></returns>
        [OperationContract]
        [WebGet(UriTemplate = "/Sujet/{nomRubrique}",
                ResponseFormat = WebMessageFormat.Json)]
        List<Sujet> GetSujetsByRubrique(string nomRubrique);

        /// <summary>
        /// Renvoie la liste des réponses par titre de sujet en paramètre d'entrée
        /// </summary>
        /// <param name="titreSujet"></param>
        /// <returns></returns>
        [OperationContract]
        [WebGet(UriTemplate = "/Reponse/{titreSujet}",
                ResponseFormat = WebMessageFormat.Json)]
        List<Reponse> GetReponsesBySujet(string titreSujet);
        #endregion

        #region UPDATE

        /// <summary>
        /// Modifie un titre de sujet
        /// </summary>
        /// <param name="idSujet"></param>
        /// <param name="TitreSujet"></param>
        /// <returns></returns>
        [OperationContract]
        [WebGet(UriTemplate = "/ModifierTitreSujet/{idSujet}/{titreSujet}",
                ResponseFormat = WebMessageFormat.Json)]
        int? ModifierTitreSujet(string idSujet, string TitreSujet);

        /// <summary>
        /// Modifie une description sujet
        /// </summary>
        /// <param name="idSujet"></param>
        /// <param name="descSujet"></param>
        /// <returns></returns>
        [OperationContract]
        [WebGet(UriTemplate = "/ModifierDescriptionSujet/{idSujet}/{descSujet}",
                ResponseFormat = WebMessageFormat.Json)]
        int? ModifierDescriptionSujet(string idSujet, string descSujet);
        #endregion

        #region DELETE

        /// <summary>
        /// Supprime une réponse en fonction de son identifiant
        /// </summary>
        /// <param name="idReponse"></param>
        /// <returns></returns>
        [OperationContract]
        [WebGet(UriTemplate = "/SupprimerReponse/{idReponse}",
                ResponseFormat = WebMessageFormat.Json)]
        int? SupprimerReponse(string idReponse);

        /// <summary>
        /// Supprime un sujet et les réponses en cascade
        /// </summary>
        /// <param name="idReponse"></param>
        /// <returns></returns>
        [OperationContract]
        [WebGet(UriTemplate = "/SupprimerSujet/{idSujet}",
                ResponseFormat = WebMessageFormat.Json)]
        int? SupprimerSujet(string idSujet);
        #endregion
    }
}
