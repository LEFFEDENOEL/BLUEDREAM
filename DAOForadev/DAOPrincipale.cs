using Foradev;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
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

        public static DataSet GetDataSet(string nomProcedureStockee, List<SqlParameter> listeSqlParam)
        {
            using (SqlConnection sqlConnex = new SqlConnection(Properties.Settings.Default.connex))
            {
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
                        //TODO
                         throw;
                        //return MessageBox.Show(ERRORCONNEXBASE, "Connexion base de données");
                    }
                    
                }
            }
        }

        public static List<Rubrique> GetRubriques()
        {
            using (DataSet dSet = GetDataSet("GETRUBRIQUE", new List<SqlParameter>()))
            {
                List<Rubrique> listeRubriques = new List<Rubrique>();

                foreach (DataRow dRow in dSet.Tables[0].Rows)
                {
                    listeRubriques.Add(new Rubrique(Int32.Parse(dRow["ID_RUBRIQUE"].ToString()), dRow["NOM_RUBRIQUE"].ToString()));
                }
                return listeRubriques;
            }
        }

        public static Rubrique BuildRubriqueByNomRubrique(string nomRubrique)
        {
            List<SqlParameter> listeSqlParam = new List<SqlParameter>();
            listeSqlParam.Add(new SqlParameter("NOMRUBRIQUE", nomRubrique));
            using (DataSet dSet = GetDataSet("BUILDRUBRIQUEBYNOMRUBRIQUE", listeSqlParam))
            {
                if (dSet.Tables[0].Rows.Count == 0) return null;

                DataRow dR = dSet.Tables[0].Rows[0];

                return new Rubrique((int)dR["ID_RUBRIQUE"], dR["NOM_RUBRIQUE"].ToString());
            }
        }

        public static Utilisateur BuildUtilisateurByNomUtilisateur(string nomUtilisateur)
        {
            List<SqlParameter> listeSqlParam = new List<SqlParameter>();
            listeSqlParam.Add(new SqlParameter("NOMUTILISATEUR", nomUtilisateur));
            using (DataSet dSet = GetDataSet("BUILDUTILISATEURBYNOMUTILISATEUR", listeSqlParam))
            {
                if (dSet.Tables[0].Rows.Count == 0) return null;

                DataRow dR = dSet.Tables[0].Rows[0];

                return new UtilisateurNonConnecte(dR["NOM"].ToString(), dR["PRENOM"].ToString(), dR["PSEUDO"].ToString(), (DateTime)dR["DATE"]);
            }
        }



        public static List<Sujet> GetSujetsByRubrique(string nomRubrique)
        {
            List<SqlParameter> listeSqlParam = new List<SqlParameter>();
            listeSqlParam.Add(new SqlParameter("NOMRUBRIQUE", nomRubrique));
            using (DataSet dSet = GetDataSet("GETSUJETSBYRUBRIQUE", listeSqlParam))
            {
                List<Sujet> listeSujets = new List<Sujet>();

                foreach (DataRow dRow in dSet.Tables[0].Rows)
                {
                    listeSujets.Add(new Sujet(BuildUtilisateurByNomUtilisateur(dRow["PSEUDO"].ToString()),
                                                (DateTime)dRow["DTESUJET"],
                                                BuildRubriqueByNomRubrique(dRow["NOMRUBRIQUE"].ToString()),
                                                (int)dRow["IDSUJET"],
                                                dRow["TITRESUJET"].ToString(),
                                                dRow["DESCSUJET"].ToString()));
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
