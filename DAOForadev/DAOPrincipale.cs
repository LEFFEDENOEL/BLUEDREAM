using Foradev;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOForadev
{
    public static class DAOPrincipale
    {
        //static public void ConnectToSql()
        //{
        //    System.Data.SqlClient.SqlConnection connex = new System.Data.SqlClient.SqlConnection();
        //    connex.ConnectionString = "Data Source=176.31.114.215;Initial Catalog=user05;Persist Security Info=True;User ID=user04;Password=456user04";
        //}

        //System.Data.SqlClient.SqlConnection connex = new System.Data.SqlClient.SqlConnection();
        //string connex = "Data Source=176.31.114.215;Initial Catalog=user05;Persist Security Info=True;User ID=user04;Password=456user04";

        public static DataSet RecupereDataSet(string nomProcedureStockee, List<SqlParameter> listeSQLParam)
        {
            string connex = "Data Source=176.31.114.215;Initial Catalog=user04;Persist Security Info=True;User ID=user04;Password=456user04";
            using (SqlConnection sqlConnex = new SqlConnection(connex))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = sqlConnex;
                    cmd.CommandText = nomProcedureStockee;
                    cmd.CommandType = CommandType.StoredProcedure;

                    foreach (SqlParameter sqlParam in listeSQLParam)
                    {
                        cmd.Parameters.Add(sqlParam);
                    }

                    using (SqlDataAdapter dAdapter = new SqlDataAdapter(cmd))
                    {
                        DataSet dSet = new DataSet();
                        dAdapter.Fill(dSet);
                        return dSet;
                    }
                }
            }
        }

        public static List<Rubrique> GetRubriques()
        {
            using (DataSet dSet = RecupereDataSet("GETRUBRIQUE", new List<SqlParameter>()))
            {
                List<Rubrique> listeRubriques = new List<Rubrique>();

                foreach (DataRow dRow in dSet.Tables[0].Rows)
                {
                    listeRubriques.Add(new Rubrique(Int32.Parse(dRow["ID_RUBRIQUE"].ToString()), dRow["NOM_RUBRIQUE"].ToString()));
                }
                return listeRubriques;
            }
        }

        public static List<Sujet> GetSujets()
        {
            using (DataSet dSet = RecupereDataSet("GETSUJET", new List<SqlParameter>()))
            {
                List<Sujet> listeSujets = new List<Sujet>();

                foreach (DataRow dRow in dSet.Tables[0].Rows)
                {
                    //listeSujets.Add(new Sujet(dRow["NOMUTILISATEUR"].ToString()), dRow["DTESUJET"].ToString(), dRow["NOMRUBRIQUE"].ToString(),
                    //               (Int32.Parse(dRow["ID_SUJET"].ToString())), dRow["TITRESUJET"].ToString(), dRow["DESCSUJET"].ToString());

                    //listeSujets.Add(new Sujet(Int32.Parse(dRow["ID_SUJET"].ToString()), dRow["TITRESUJET"].ToString(), dRow["DESCSUJET"].ToString()));
                    listeSujets.Add(new Sujet(dRow["TITRESUJET"].ToString(), dRow["DESCSUJET"].ToString()));
                }
                return listeSujets;
            }
        }



        //TODO

        //public static List<Rubrique> GetConstantes()
        //{
        //    using (DataSet dSet = RecupereDataSet("GETCONSTANTE", new List<SqlParameter>()))
        //    {
        //        List<Rubrique> listeConstantes = new List<Constante>();

        //        foreach (DataRow dRow in dSet.Tables[0].Rows)
        //        {
        //            listeConstantes.Add(new Rubrique(Int32.Parse(dRow["ID_REFERENCE"].ToString()), dRow["REFERENCE"].ToString()), dRow["VALEUR"].ToString()));
        //        }
        //        return listeConstantes;
        //    }
        //}

    }
}
