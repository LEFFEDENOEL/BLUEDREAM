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
    /// <summary>
    /// Classe d'accés aux données
    /// </summary>
    public static class DAOPrincipale
    {
        /// <summary>
        /// Renvoit un dataset selon une procédure stockée en paramètre d'entrée
        /// </summary>
        /// <param name="nomProcedureStockee"></param>
        /// <param name="listeSqlParam"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Renvoit la liste intégrale des rubriques
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Renvoit le type complet "Rubrique"
        /// </summary>
        /// <param name="nomRubrique"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Renvoit le type complet "Utilisateur"
        /// </summary>
        /// <param name="nomUtilisateur"></param>
        /// <returns></returns>
        public static Utilisateur BuildUtilisateurByNomUtilisateur(string nomUtilisateur)
        {
            List<SqlParameter> listeSqlParam = new List<SqlParameter>();
            listeSqlParam.Add(new SqlParameter("NOMUTILISATEUR", nomUtilisateur));
            using (DataSet dSet = GetDataSet("BUILDUTILISATEURBYNOMUTILISATEUR", listeSqlParam))
            {
                if (dSet.Tables[0].Rows.Count == 0) return null;

                DataRow dR = dSet.Tables[0].Rows[0];

                return new UtilisateurNonConnecte(dR["NOM_UTILISATEUR"].ToString(), dR["PRENOM_UTILISATEUR"].ToString(), 
                                                  dR["PSEUDO_UTILISATEUR"].ToString(), (DateTime)dR["DATE_INSCRIPTION"]);
            }
        }

        /// <summary>
        /// Renvoit tous les sujets postés par rubrique.
        /// Appel des 2 sous méthodes BuildRubriqueByNomRubrique et BuildUtilisateurByNomUtilisateur
        /// </summary>
        /// <param name="nomRubrique"></param>
        /// <returns></returns>
        public static List<Sujet> GetSujetsByRubrique(string nomRubrique)
        {
            List<SqlParameter> listeSqlParam = new List<SqlParameter>();
            listeSqlParam.Add(new SqlParameter("NOMRUBRIQUE", nomRubrique));
            using (DataSet dSet = GetDataSet("GETSUJETSBYRUBRIQUE", listeSqlParam))
            {
                List<Sujet> listeSujets = new List<Sujet>();

                foreach (DataRow dRow in dSet.Tables[0].Rows)
                {
                    listeSujets.Add(new Sujet(BuildUtilisateurByNomUtilisateur(dRow["NOMUTILISATEUR"].ToString()),
                                             (DateTime)dRow["DTESUJET"],
                                              BuildRubriqueByNomRubrique(dRow["NOMRUBRIQUE"].ToString()),
                                              (int)dRow["IDSUJET"],
                                              dRow["TITRESUJET"].ToString(),
                                              dRow["DESCSUJET"].ToString()));
                }
                return listeSujets;
            }
        }

        //public static List<Sujet> GetReponsesBySujet(string titreSujet)
        //{
        //    List<SqlParameter> listeSqlParam = new List<SqlParameter>();
        //    listeSqlParam.Add(new SqlParameter("TITRESUJET", titreSujet));
        //    using (DataSet dSet = GetDataSet("GETREPONSESBYSUJET", listeSqlParam))
        //    {
        //        List<Sujet> listeSujets = new List<Sujet>();

        //        foreach (DataRow dRow in dSet.Tables[0].Rows)
        //        {
        //            listeSujets.Add(new Reponse(BuildUtilisateurByNomUtilisateur(dRow["NOM_UTILISATEUR"].ToString()),
        //                                       (BuildUtilisateurByNomUtilisateur(dRow["PSEUDO_UTILISATEUR"].ToString())),
        //                                       (DateTime)dRow["DATE_REPONSE"],
        //                                        dRow["TEXTE_REPONSE"].ToString()));
                                          
        //        }
        //        return listeSujets;
        //    }
        //}


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
