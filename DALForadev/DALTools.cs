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
        /// Renvoit un dataset selon une procédure stockée en paramètre d'entrée
        /// </summary>
        /// <param name="nomProcedureStockee"></param>
        /// <param name="listeSqlParam"></param>
        /// <returns>Renvoit un dataSet vide ou peuplé ou NULL</returns>
        public static DataSet GetDataSet(string nomProcedureStockee, List<SqlParameter> listeSqlParam)
        {
            // Alternative :
            //using (SqlConnection sqlConnex = new SqlConnection(Properties.Settings.Default.connex)) {}

            using (SqlCommand cmd = new SqlCommand())
            {
                try
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
                        dAdapter.Fill(dSet);
                        sqlConnex.Close();
                        return dSet;
                    }
                }
                catch (Exception)
                {
                    return null;
                    // Remonte null en cascade dans toutes les sous méthodes de DALMain qui appellent celle-ci                       
                }
            }
        }
    }
}
