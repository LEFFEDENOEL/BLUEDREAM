using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALForadev
{
    /// <summary>
    /// Classe statique Logger qui contient une méthode pour écrire les exceptions SQL dans un fichier
    /// </summary>
    public static class DALLog
    {
        /// <summary>
        /// Méthode de création d'un répertoire et d'un fichier des logs exceptions SQL
        /// </summary>
        /// <param name="errorMessage"></param>
        /// <param name="nomClasse"></param>
        public static void WriteToFile(string errorMessage, string nomClasse)
        {
            DateTime nowDate = DateTime.Now;
            string shortDate = String.Format("{0:yyyy-MM-dd}", nowDate);
            string fichierlogs = string.Format("{0}.log", shortDate);

            // Création du nom de fichier .log
            fichierlogs = fichierlogs.Replace("/", "-");

            // Récupération chemin complet, application PC
            string rootPath = Path.GetFullPath("./Data/Log/");
            // Chemin complet pour une application serveur
            //System.Web.HttpContext.Current.Server.MapPath("~/Data/Log/");

            string fullFilename = string.Format(@"{0}{1}", rootPath, fichierlogs);

            // Vérification des dossiers Data & Log
            if (!Directory.Exists(rootPath))
            {
                // Création du dossier
                Directory.CreateDirectory(rootPath);
            }
            // Vérification du fichier
            if (!System.IO.File.Exists(fullFilename))
            {
                // Création du fichier log du jour
                System.IO.FileStream f = System.IO.File.Create(fullFilename);
                f.Close();
            }

            using (StreamWriter writer = new StreamWriter(fullFilename, true))
            {
                // Ecriture dans le fichier log du jour
                writer.WriteLine(string.Format(
                                       "[{0} ON {1}] : {2}",
                                       DateTime.Now,
                                       nomClasse,
                                       errorMessage));
            }
        }
    }
}
