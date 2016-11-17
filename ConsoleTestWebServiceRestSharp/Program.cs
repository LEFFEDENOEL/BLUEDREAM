using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace ConsoleTestWebServiceRestSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test du Get sans paramètre du WebServiceREST en local ok !

            //var client = new RestClient("http://localhost:5000");
            ////JsonDeserializer jD = new JsonDeserializer();
            //var request = new RestRequest("ServiceRESTLink4dev.svc/Rubriques", Method.GET);

            //var reponse = client.Execute(request);
            //List<Rubrique> lR2 = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Rubrique>>(reponse.Content);

            //foreach (Rubrique r in lR2)
            //{
            //    Console.WriteLine(r);
            //}
            //Console.ReadKey();

            // Test du Get sans paramètre du WebServiceREST ok !

            //var client = new RestClient(urlService);
            ////JsonDeserializer jD = new JsonDeserializer();
            //var request = new RestRequest("Rubriques", Method.GET);

            //var reponse = client.Execute(request);
            //List<Rubrique> lR2 = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Rubrique>>(reponse.Content);

            //foreach (Rubrique r in lR2)
            //{
            //    Console.WriteLine(r);
            //}
            //Console.ReadKey();

            //// Test du Get avec paramètre du WebServiceREST

            //var client = new RestClient(urlService);
            //var request = new RestRequest("GetSujetsByIdRubrique/ty", Method.GET);

            //var reponse = client.Execute(request);
            //List<Sujet> lS = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Sujet>>(reponse.Content);
            //if (lS == null) Console.WriteLine("Renvoi de Null");
            //else if (lS.Count == 0) Console.WriteLine("Pas de sujet dans la rubrique");
            //else
            //{
            //    foreach (Sujet s in lS)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}
            //Console.ReadKey();

            // Test du Post avec paramètres passé dans le corps de la requête

            var client = new RestClient(urlService);
            var request = new RestRequest("MAJSujet", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(new { idSujet = "1", nouveauTitreSujet = "ttt ?", nouvelleDescriptionSujet = "ddd ?" });

            var reponse = client.Execute(request);

            bool? b;

            if (reponse.StatusCode != System.Net.HttpStatusCode.OK) b = null;
            else b = Newtonsoft.Json.JsonConvert.DeserializeObject<bool?>(reponse.Content);
            if (b == null) Console.WriteLine("Renvoi de Null");
            else Console.WriteLine(b);

            Console.ReadKey();


            // Test de url.encode

            //var hSU = new HttpUtility();

            //Console.WriteLine(HttpUtility.UrlEncode("localhost:5000/ServiceRESTLink4dev.svc/CreateCompteUtilisateur/l/m/p/m/false/n/p/2012-03-19T07:22Z"));

            //Console.ReadKey();

            //SimpleJson.



            // Test du Post du WebServiceREST avec paramètres

            //var client = new RestClient("http://localhost:5000");
            //JsonDeserializer jD = new JsonDeserializer();

            //var url = System.Net.WebUtility.UrlEncode(String.Format("ServiceRESTLink4dev.svc/CreateCompteUtilisateur/{0}/{1}/{2}/{3}/{4}/{5}/{6}/{7}","l","m","p","m","false","n","p", "2012-03-19T07:22Z"));

            //var url = String.Format("ServiceRESTLink4dev.svc/CreateCompteUtilisateur/{0}/{1}/{2}/{3}/{4}/{5}/{6}/{7}", "l", "m", "p", "m", "false", "n", "p", "2012-03-19T07:22Z");
            //var request = new RestRequest("ServiceRESTLink4dev.svc/CreateCompteUtilisateur/{login}/{mDPSH}/{pseudo}/{mail}/{estModerateur}/{nom}/{prenom}/{dateCreationCompte}", Method.POST);
            //request.AddUrlSegment("login", "l"); //login}/{mDPSH}/{pseudo}/{mail}/{estModerateur}/{nom}/{prenom}/{dateCreationCompte
            //request.AddUrlSegment("mDPSH", "m");
            //request.AddUrlSegment("pseudo", "p");
            //request.AddUrlSegment("mail", "m");
            //request.AddUrlSegment("estModerateur", "false");
            //request.AddUrlSegment("nom", "n");
            //request.AddUrlSegment("prenom", "p");
            //request.AddUrlSegment("dateCreationCompte", "2012-03-19T07:22Z"); // Une valeur potentiellement dangereuse a été détectée ... (:) <-

            //var url = "ServiceRESTLink4dev.svc/CreateCompteUtilisateur";
            //var request = new RestRequest(url, Method.POST);

            //request.RequestFormat = DataFormat.Json;
            ////http://www.hanselman.com/blog/ExperimentsInWackinessAllowingPercentsAnglebracketsAndOtherNaughtyThingsInTheASPNETIISRequestURL.aspx


            //request.AddUrlSegment("login", "l"); //login}/{mDPSH}/{pseudo}/{mail}/{estModerateur}/{nom}/{prenom}/{dateCreationCompte
            //request.AddUrlSegment("mDPSH", "m");
            //request.AddUrlSegment("pseudo", "p");
            //request.AddUrlSegment("mail", "m");
            //request.AddUrlSegment("estModerateur", "false");
            //request.AddUrlSegment("nom", "n");
            //request.AddUrlSegment("prenom", "p");
            //request.AddUrlSegment("dateCreationCompte", "2012-03-19T07:22Z");

            ////System.Net.WebUtility.UrlEncode()

            //var reponse = client.Execute(request);

            //Console.WriteLine(reponse.StatusDescription);
            ////int? i = Newtonsoft.Json.JsonConvert.DeserializeObject<int?>(reponse.Content);


            ////if (i == null) Console.WriteLine("i=null");
            ////else Console.WriteLine(i);

            //Console.ReadKey();
        }
    }
}
