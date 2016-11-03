using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALForadev
{
    /// <summary>
    /// Classe statique qui initie la connexion et contient la méthode GetDataSet générique de récupération d'un dataSet.
    /// Cette methode est appelée par les sous méthodes de la classe statique DALMain
    /// </summary>
    public static class DALTools
    {
        static SqlConnection sqlConnex = new SqlConnection(Properties.Settings.Default.connex);

        /// <summary>
        /// Renvoie un dataset selon une procédure stockée en paramètre d'entrée.
        /// Renvoie un dataSet vide ou peuplé ou NULL
        /// </summary>
        /// <param name="nomProcedureStockee"></param>
        /// <param name="listeSqlParam"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string nomProcedureStockee, List<SqlParameter> listeSqlParam)
        {
            // Alternative :
            //using (SqlConnection sqlConnex = new SqlConnection(Properties.Settings.Default.connex)) {}

            using (SqlCommand cmd = new SqlCommand())
            {              
                    sqlConnex.Open();
                    cmd.Connection = sqlConnex;
                    cmd.CommandText = nomProcedureStockee;
                    cmd.CommandType = CommandType.StoredProcedure;

                    foreach (SqlParameter sqlParam in listeSqlParam)
                    {
                        cmd.Parameters.Add(sqlParam);
                    }

                    using (SqlDataAdapter dAdapter = new SqlDataAdapter(cmd))
                    {
                        DataSet dSet = new DataSet();
                        try
                        {
                            dAdapter.Fill(dSet);
                            sqlConnex.Close();
                            return dSet;
                        }
                        catch (SqlException sqlex)
                        {
                            StringBuilder errorMessages = new StringBuilder();

                            for (int i = 0; i < sqlex.Errors.Count; i++)
                            {
                                errorMessages.Append("Index #" + i + "\n" +
                                                     "Message : " + sqlex.Errors[i].Message + "\n" +
                                                     "Méthode : " + sqlex.TargetSite + "\n" +
                                                     "Numéro erreur : " + sqlex.Number + "\n" +
                                                     "Nom ordinateur : " + sqlex.Server + "\n" +
                                                     "Etat : " + sqlex.State + "\n" +
                                                     "Stacktrace : " + sqlex.StackTrace + "\n" +
                                                     "Class : " + sqlex.Class + "\n" +
                                                     "Client Connexion ID : " + sqlex.ClientConnectionId + "\n" +
                                                     "Errors : " + sqlex.Errors + "\n" +
                                                     "Error : " + sqlex.ErrorCode + "\n" +
                                                     "Data : " + sqlex.Data + "\n" +
                                                     //"InnerException : " + sqlex.InnerException + "\n" +
                                                     "Source : " + sqlex.Errors[i].Source + "\n");
                            }

                            //inscription dans le fichier log
                             DALLog.WriteToFile(errorMessages.ToString(), "DALTools");

                            //Console.WriteLine(errorMessages.ToString());
                            return null;
                            // Remonte null en cascade dans toutes les sous méthodes de DALMain qui appellent celle-ci                       
                    }
                }
            }
        }
    }
}
