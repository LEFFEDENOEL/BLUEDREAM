using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using METIERForadev;
using DALForadev;


namespace BLLForadev
{
    /// <summary>
    /// Classe statique de type SERVICE ou CONTROLEUR pour appel des méthodes de la classe statique DALMain
    /// </summary>
    public static class BLLMain
    {
        /// <summary>
        /// Fonction qui permet le haschage en SHA1 des mots de passe.
        /// En entrée string mot de passe client en clair
        /// </summary>
        /// <param name="mdpFromClient"></param>
        /// <returns>String Builder / Mot de passe hasché</returns>
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
        //        sb.Append(data[i].ToString("X2"));
        //    }
        //    return sb.ToString();
        //}

        /// <summary>
        /// Méthode d'appel de la méthode qui permet le changement de mot de passe depuis la classe DALMain
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <param name="login"></param>
        /// <param name="empreinteSha"></param>
        /// <returns></returns>
        static public int? ChangePass(int idUtilisateur, string login, string empreinteSha)
        {
            return DALMain.ChangePass(idUtilisateur, login, empreinteSha);
        }

        /// <summary>
        /// Méthode qui permet la création d'un utilisateur,
        /// renvoie le login de l'utilisateur
        /// renvoie null s'il y a une exception sql
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
            return DALMain.AjoutUtilisateur(nom, prenom, estModerateur, mail, empreinteSha, pseudo, dateInscription);
        }

        /// <summary>
        /// Méthode d'appel de la méthode qui permet l'authentification d'un utilisateur et la récupération de son rôle depuis la classe DAO.
        /// Renvoie la méthode de la classe DALMain
        /// </summary>
        /// <param name="empreinteSha"></param>
        /// <param name="login"></param>
        /// <returns></returns>
        static public UtilisateurConnecte GetIdentificationUtilisateur(string empreinteSha, string login)
        {
            return DALMain.GetIdentificationUtilisateur(empreinteSha, login);

        }

        /// <summary>
        /// Méthode d'appel de construction du dictionnaire de constantes erreur depuis la base de données
        /// </summary>
        /// <returns></returns>
        static public Dictionary<string, Constante> GetConstantes()
        {
                return DALMain.GetConstantes();
        }
        
        /// <summary>
        /// Méthode d'appel de la liste récupérée par la méthode dans la classe DALMain
        /// </summary>
        /// <returns></returns>
        static public List<Rubrique> GetRubriques()
        {
            return DALMain.GetRubriques();
        }

        /// <summary>
        /// Méthode d'appel de la liste récupérée par la méthode dans la classe DALMain
        /// </summary>
        /// <param name="nomRubrique"></param>
        /// <returns></returns>
        static public List<Sujet> GetSujetsByRubrique(string nomRubrique)
        {
            return DALMain.GetSujetsByRubrique(nomRubrique);
        }

        /// <summary>
        /// Méthode d'appel de la liste récupérée par la méthode dans la classe DALMain
        /// </summary>
        /// <param name="titreSujet"></param>
        /// <returns></returns>
        static public List<Reponse> GetReponsesBySujet(string titreSujet)
        {
            return DALMain.GetReponsesBySujet(titreSujet);
        }

        /// <summary>
        /// Méthode d'appel de la méthode dans la classe DALMain qui permet d'ajouter un sujet
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <param name="idRubrique"></param>
        /// <param name="titreSujet"></param>
        /// <param name="descriptionSujet"></param>
        /// <param name="dateCreationSujet"></param>
        /// <returns>Renvoie l'identifiant du sujet en INT ou NULL sur appel méthode dans la classe DALMain</returns>
        public static int? AjoutSujet(int idUtilisateur, int idRubrique, string titreSujet,
                                      string descriptionSujet, DateTime dateCreationSujet)
        {
            return DALMain.AjoutSujet(idUtilisateur, idRubrique, titreSujet, descriptionSujet, dateCreationSujet);
        }

        /// <summary>
        /// Méthode d'appel de la méthode dans la classe DALMain qui permet d'ajouter une réponse
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <param name="idSujet"></param>
        /// <param name="texteReponse"></param>
        /// <param name="dateReponse"></param>
        /// <returns>Renvoie l'identifiant de la réponse en INT ou NULL sur appel méthode dans la classe DALMain</returns>
        public static int? AjoutReponse(int idSujet, int idUtilisateur, string texteReponse, DateTime dateReponse)
        {
            return DALMain.AjoutReponse(idSujet, idUtilisateur, texteReponse, dateReponse);
        }

        /// <summary>
        /// Méthode d'appel de la méthode dans la classe DALMain qui permet à un modérateur de supprimer un sujet
        /// </summary>
        /// <param name="idSujet"></param>
        /// <returns></returns>
        public static int? SupprimerSujet (int idSujet)
        {
            return DALMain.SupprimerSujet(idSujet);
        }

        /// <summary>
        /// Méthode d'appel de la méthode dans la classe DALMain qui permet à un modérateur de supprimer une réponse
        /// </summary>
        /// <param name="idReponse"></param>
        /// <returns></returns>
        public static int? SupprimerReponse(int idReponse)
        {
            return DALMain.SupprimerReponse(idReponse);
        }

        /// <summary>
        /// Méthode d'appel de la méthode dans la classe DALMain qui permet à un modérateur de modifier le titre d'un sujet
        /// </summary>
        /// <param name="idSujet"></param>
        /// <param name="titreSujet"></param>
        /// <returns></returns>
        public static int? ModifierTitreSujet(int idSujet, string titreSujet)
        {
            return DALMain.ModifierTitreSujet(idSujet, titreSujet);
        }

        /// <summary>
        /// Méthode d'appel de la méthode dans la classe DALMain qui permet à un modérateur de modifier la description d'un sujet
        /// </summary>
        /// <param name="idSujet"></param>
        /// <param name="descSujet"></param>
        /// <returns></returns>
        public static int? ModifierDescriptionSujet(int idSujet, string descSujet)
        {
            return DALMain.ModifierDescriptionSujet(idSujet, descSujet);
        }
    }
}
