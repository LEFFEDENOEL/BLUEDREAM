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

        /// <summary>
        /// Ajout réponse en POST
        /// </summary>
        /// <param name="idSujet"></param>
        /// <param name="idUtilisateur"></param>
        /// <param name="texteReponse"></param>
        /// <param name="dateReponse"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "POST",
                   UriTemplate = "/AjoutReponse",
                   BodyStyle = WebMessageBodyStyle.WrappedRequest,
                   ResponseFormat = WebMessageFormat.Json)]
        int? AjoutReponse(string idSujet, string idUtilisateur, string texteReponse, string dateReponse);


        /// <summary>
        /// Ajout sujet en POST
        /// </summary>
        /// <param name="idSujet"></param>
        /// <param name="idUtilisateur"></param>
        /// <param name="texteReponse"></param>
        /// <param name="dateReponse"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "POST",
                   UriTemplate = "/AjoutSujet",
                   BodyStyle = WebMessageBodyStyle.WrappedRequest,
                   ResponseFormat = WebMessageFormat.Json)]
        int? AjoutSujet(string idUtilisateur, string idRubrique, string titreSujet, string descriptionSujet, string dateCreationSujet);

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
        [WebInvoke(Method = "PUT",
                   UriTemplate = "/ModifierTitreSujet",
                   BodyStyle = WebMessageBodyStyle.WrappedRequest,
                   ResponseFormat = WebMessageFormat.Json)]
        int? ModifierTitreSujet(string idSujet, string titreSujet);


        /// <summary>
        /// Modifie une description sujet
        /// </summary>
        /// <param name="idSujet"></param>
        /// <param name="descSujet"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "PUT",
                   UriTemplate = "/ModifierDescriptionSujet",
                   BodyStyle = WebMessageBodyStyle.WrappedRequest,
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
        [WebInvoke(Method = "DELETE",
                   UriTemplate = "/SupprimerReponse",
                   BodyStyle = WebMessageBodyStyle.WrappedRequest,
                   ResponseFormat = WebMessageFormat.Json)]
        int? SupprimerReponse(string idReponse);


        /// <summary>
        /// Supprime un sujet et les réponses en cascade
        /// </summary>
        /// <param name="idReponse"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "DELETE",
                   UriTemplate = "/SupprimerSujet",
                   BodyStyle = WebMessageBodyStyle.WrappedRequest,
                   ResponseFormat = WebMessageFormat.Json)]
        int? SupprimerSujet(string idSujet);
        #endregion
    }
}
