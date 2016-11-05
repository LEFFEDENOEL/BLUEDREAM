using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using METIERForadev;
using DALForadev;
using System.Text.RegularExpressions;

namespace BLLForadev
{
    /// <summary>
    /// Classe statique de type SERVICE ou CONTROLEUR pour appel des méthodes de la classe statique DALMain
    /// </summary>
    public static class BLLMain
    {
        #region Gestion de la sécurité - mot de passe-

        // Déclaration constante expression rationnelle si pas en base de données
        //static private readonly string EXPRESSION_RATIONNELLE = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#\\$%\\^&\\*])(?=.{12,})";

        /// <summary>
        /// Méthode REGEX qui vérifie les impératifs de sécurité du mot de passe.
        /// Expression régulière chargée dans un dictionnaire depuis la base de données.
        /// </summary>
        /// <param name="mdpFromClient"></param>
        /// <returns>TRUE si le mot de passe rempli les conditions, FALSE si conditions non remplie</returns>
        static public bool validRegex(string mdpFromClient)
        {
            Constante EXPRESSION_RATIONNELLE;
            Dictionary<string, Constante> dictionnaireConstantes;
            dictionnaireConstantes = GetConstantes();
            dictionnaireConstantes.TryGetValue("EXPRESSION_RATIONNELLE", out EXPRESSION_RATIONNELLE);
            Regex rgx = new Regex(EXPRESSION_RATIONNELLE.Valeur1);
            return rgx.IsMatch(mdpFromClient);
        }

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
        /// Méthode qui permet le changement du mot de passe.
        /// Renvoie identifiant utilisateur si ok ou NULL si exception SQL
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
        /// Renvoie objet utilisateurConnecte ou objet utilisateurConnecte NULL si utilisateur inconnu ou NULL si exception SQL
        /// </summary>
        /// <param name="empreinteSha"></param>
        /// <param name="login"></param>
        /// <returns></returns>
        static public UtilisateurConnecte GetIdentificationUtilisateur(string empreinteSha, string login)
        {
            return DALMain.GetIdentificationUtilisateur(empreinteSha, login);
        }
        #endregion

        #region Autres méthodes

        /// <summary>
        /// Méthode qui permet la création d'un utilisateur.
        /// Renvoie le login de l'utilisateur ou NULL si exception SQL      
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
        /// Méthode d'appel de construction du dictionnaire de constantes erreur depuis la base de données.
        /// Renvoie les valeurs des constantes ou NULL si exception SQL
        /// </summary>
        /// <returns></returns>
        static public Dictionary<string, Constante> GetConstantes()
        {
                return DALMain.GetConstantes();
        }

        /// <summary>
        /// Renvoie un objet liste des rubriques ou NULL si exception SQL
        /// </summary>
        /// <returns></returns>
        static public List<Rubrique> GetRubriques()
        {
            return DALMain.GetRubriques();
        }

        /// <summary>
        /// Renvoie un objet liste de tous les sujets postés par rubrique ou NULL.
        /// </summary>
        /// <param name="nomRubrique"></param>
        /// <returns></returns>
        static public List<Sujet> GetSujetsByRubrique(string nomRubrique)
        {
            return DALMain.GetSujetsByRubrique(nomRubrique);
        }

        /// <summary>
        /// Renvoie un objet liste de toutes les réponses postées par titre de sujet ou NULL si exception SQL.
        /// </summary>
        /// <param name="titreSujet"></param>
        /// <returns></returns>
        static public List<Reponse> GetReponsesBySujet(string titreSujet)
        {
            return DALMain.GetReponsesBySujet(titreSujet);
        }

        /// <summary>
        /// Méthode qui ajoute un sujet et renvoie l'identifiant sujet.
        /// Renvoie NULL si exception SQL
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
        /// Méthode qui ajoute une réponse selon un sujet.
        /// Renvoie identifiant réponse ou NULL si exception SQL
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
        /// Méthode de suppression d'un sujet et réponses correspondantes en cascade. "on delete cascade" dans SQL.
        /// Renvoie identifiant sujet supprimé ou NULL si exception SQL
        /// </summary>
        /// <param name="idSujet"></param>
        /// <returns></returns>
        public static int? SupprimerSujet (int idSujet)
        {
            return DALMain.SupprimerSujet(idSujet);
        }

        /// <summary>
        /// Méthode de suppression d'une réponse.
        /// Renvoie identifiant réponse supprimée ou NULL si exception SQL
        /// </summary>
        /// <param name="idReponse"></param>
        /// <returns></returns>
        public static int? SupprimerReponse(int idReponse)
        {
            return DALMain.SupprimerReponse(idReponse);
        }

        /// <summary>
        /// Méthode de modification du titre d'un sujet.
        /// Renvoie identifiant sujet modifié ou NULL si exception SQL
        /// </summary>
        /// <param name="idSujet"></param>
        /// <param name="titreSujet"></param>
        /// <returns></returns>
        public static int? ModifierTitreSujet(int idSujet, string titreSujet)
        {
            return DALMain.ModifierTitreSujet(idSujet, titreSujet);
        }

        /// <summary>
        /// Méthode de modification de la description d'un sujet.
        /// Renvoie identifiant du sujet modifié ou NULL si exception SQL
        /// </summary>
        /// <param name="idSujet"></param>
        /// <param name="descSujet"></param>
        /// <returns></returns>
        public static int? ModifierDescriptionSujet(int idSujet, string descSujet)
        {
            return DALMain.ModifierDescriptionSujet(idSujet, descSujet);
        }
        #endregion
    }
}
