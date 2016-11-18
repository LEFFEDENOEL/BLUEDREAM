using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using METIERForadev;
using DALForadev;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace BLLForadev
{
    /// <summary>
    /// Classe statique de type outil qui contient les méthodes relatives à la sécurité du mot de passe
    /// </summary>
    public static class BLLTools
    {
        // Déclaration constante expression rationnelle si pas en base de données
        //static private readonly string EXPRESSION_RATIONNELLE = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#\\$%\\^&\\*])(?=.{12,})";

        /// <summary>
        /// Méthode REGEX qui vérifie les impératifs de sécurité du mot de passe.
        /// Expression régulière chargée dans un dictionnaire depuis la base de données.
        /// </summary>
        /// <param name="mdpFromClient"></param>
        /// <returns>TRUE si le mot de passe rempli les conditions, FALSE si conditions non remplie</returns>
        static public bool ValidRegex(string mdpFromClient)
        {
            Constante EXPRESSION_RATIONNELLE;
            Dictionary<string, Constante> dictionnaireConstantes;
            dictionnaireConstantes = DALMain.GetConstantes();
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
    }
}
