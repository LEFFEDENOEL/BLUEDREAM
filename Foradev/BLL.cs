using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Foradev
{
    /// <summary>
    /// Classe de type SERVICE ou CONTROLEUR pour appel des méthodes de la classe DAO
    /// </summary>
    public static class BLL
    {
        /// <summary>
        /// Fonction qui permet le haschage en SHA1 des mots de passe
        /// </summary>
        /// <param name="mdpFromClient"></param>
        /// <returns></returns>
        public static string HashShaMdp(string mdpFromClient)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(mdpFromClient));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }
                return sb.ToString();
            }
        }
        // Autre solution
        //public static string ConvertSHA1(string mdpFromClient)
        //{
        //    SHA1 sha = SHA1.Create();
        //    byte[] data = sha.ComputeHash(Encoding.Default.GetBytes(mdpFromClient));
        //    StringBuilder sb = new StringBuilder();
        //    for (int i = 0; i < data.Length; i++)
        //    {
        //        sb.Append(data[i].ToString("x2"));
        //    }
        //    return sb.ToString();
        //}


        /// <summary>
        /// Méthode d'appel de la méthode qui permet la création d'un utilisateur depuis la classe DAO
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="estModerateur"></param>
        /// <param name="mail"></param>
        /// <param name="empreinteSha"></param>
        /// <param name="pseudo"></param>
        /// <param name="dateInscription"></param>
        /// <returns></returns>

        static public string AjoutUtilisateur(string nom, string prenom, bool estModerateur, string mail, 
                                       string empreinteSha, string pseudo, DateTime dateInscription)
        {
            return DAOPrincipale.AjoutUtilisateur(nom, prenom, estModerateur, mail, empreinteSha, pseudo, dateInscription);
        }

        /// <summary>
        /// Méthode d'appel de la méthode qui permet l'authentification d'un utilisateur et la récupération de son rôle depuis la classe DAO
        /// </summary>
        /// <param name="empreinteSha"></param>
        /// <param name="login"></param>
        /// <returns></returns>
        static public UtilisateurConnecte GetIdentificationUtilisateur(string empreinteSha, string login)
        {
            return DAOPrincipale.GetIdentificationUtilisateur(empreinteSha, login);
        }

        /// <summary>
        /// Méthode d'appel de la liste récupérée par la méthode dans la classe DAO
        /// </summary>
        /// <returns></returns>
        static public List<Rubrique> GetRubriques()
        {
            return DAOPrincipale.GetRubriques();
        }

        /// <summary>
        /// Méthode d'appel de la liste récupérée par la méthode dans la classe DAO
        /// </summary>
        /// <param name="nomRubrique"></param>
        /// <returns></returns>
        static public List<Sujet> GetSujetsByRubrique(string nomRubrique)
        {
            return DAOPrincipale.GetSujetsByRubrique(nomRubrique);
        }

        /// <summary>
        /// Méthode d'appel de la liste récupérée par la méthode dans la classe DAO
        /// </summary>
        /// <param name="titreSujet"></param>
        /// <returns></returns>
        static public List<Reponse> GetReponsesBySujet(string titreSujet)
        {
            return DAOPrincipale.GetReponsesBySujet(titreSujet);
        }

    }
}
