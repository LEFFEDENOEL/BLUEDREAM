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
                ResponseFormat = WebMessageFormat.Xml)]
        List<Reponse> GetReponsesBySujet(string titreSujet);
    }
}
