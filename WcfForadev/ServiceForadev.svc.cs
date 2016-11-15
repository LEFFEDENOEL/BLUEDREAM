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
    }
}
