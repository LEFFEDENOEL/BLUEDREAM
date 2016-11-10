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
    }
}
