using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Foradev
{
    /// <summary>
    /// Classe statique Compute qui effectue des traitements particuliers pour Winform
    /// </summary>
    public static class Compute
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
    }
}
