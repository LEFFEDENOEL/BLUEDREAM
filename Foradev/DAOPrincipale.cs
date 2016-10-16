using Foradev;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foradev
{
    /// <summary>
    /// Classe d'accés aux données CRUD
    /// </summary>
    public static class DAOPrincipale
    {
        #region CRUD : Retrieve

        static SqlConnection sqlConnex = new SqlConnection(Properties.Settings.Default.connex);

        /// <summary>
        /// Renvoit un dataset selon une procédure stockée en paramètre d'entrée
        /// </summary>
        /// <param name="nomProcedureStockee"></param>
        /// <param name="listeSqlParam"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string nomProcedureStockee, List<SqlParameter> listeSqlParam)
        {
            //using (SqlConnection sqlConnex = new SqlConnection(Properties.Settings.Default.connex))
            //{
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
                //}
            }
        }

        //static private T? RecupereScalaire<T>(string nomProcedureStockee, List<SqlParameter> lSP, string nomParametreEnSortie) where T : struct
        //{
        //    using (SqlConnection sqlConnex = new SqlConnection(Properties.Settings.Default.connex))
        //    {

        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            cmd.Connection = sC;
        //            cmd.CommandText = nomProcedureStockee;
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            foreach (SqlParameter sP in lSP)
        //            {
        //                cmd.Parameters.Add(sP);
        //            }

        //            T? resultat;
        //            sC.Open();
        //            cmd.ExecuteNonQuery();
        //            object o = cmd.Parameters[nomParametreEnSortie].Value;
        //            resultat = (T?)o;
        //            sC.Close();
        //            return resultat;
        //        }
        //    }
        //}

        /// <summary>
        /// Renvoit le rôle de l'utilisateur après son authentification ou null si echec de l'authentification
        /// <param name="empreinteSha"></param>
        /// <param name="login"></param>
        /// </summary>
        /// <returns></returns>
        public static UtilisateurConnecte GetIdentificationUtilisateur(string empreinteSha, string login)
        {
            List<SqlParameter> listeSqlParam = new List<SqlParameter>();
            listeSqlParam.Add(new SqlParameter("EMPREINTESHA", empreinteSha));
            listeSqlParam.Add(new SqlParameter("LOGIN", login));

            using (DataSet dSet = GetDataSet("GETIDENTIFICATIONUTILISATEUR", listeSqlParam))
            {
                if (dSet.Tables[0].Rows.Count == 0) return null;

                DataRow dRow = dSet.Tables[0].Rows[0];
                bool role = ((bool)dRow["EST_MODERATEUR"] == true);
  
                if (role) return new Moderateur ((int)dRow["ID_UTILISATEUR"],
                                                 dRow["NOM_UTILISATEUR"].ToString(),
                                                 dRow["PRENOM_UTILISATEUR"].ToString(),
                                                 dRow["MAIL_UTILISATEUR"].ToString(),
                                                 role,
                                                 dRow["PSEUDO_UTILISATEUR"].ToString(),
                                                (DateTime)dRow["DATE_INSCRIPTION"]);

                return new NonModerateur ((int)dRow["ID_UTILISATEUR"],
                                          dRow["NOM_UTILISATEUR"].ToString(),
                                          dRow["PRENOM_UTILISATEUR"].ToString(),
                                          dRow["MAIL_UTILISATEUR"].ToString(),
                                          role,
                                          dRow["PSEUDO_UTILISATEUR"].ToString(),
                                         (DateTime)dRow["DATE_INSCRIPTION"]);
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

                DataRow dRow = dSet.Tables[0].Rows[0];

                return new Rubrique((int)dRow["ID_RUBRIQUE"], dRow["NOM_RUBRIQUE"].ToString());
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

                DataRow dRow = dSet.Tables[0].Rows[0];

                return new UtilisateurNonConnecte((int)dRow["ID_UTILISATEUR"],
                                                  dRow["NOM_UTILISATEUR"].ToString(), 
                                                  dRow["PRENOM_UTILISATEUR"].ToString(), 
                                                  dRow["PSEUDO_UTILISATEUR"].ToString(), 
                                                  (DateTime)dRow["DATE_INSCRIPTION"]);
            }
        }

        /// <summary>
        /// Renvoit le type complet "Sujet"
        /// </summary>
        /// <param name="idSujet"></param>
        /// <returns></returns>
        public static Sujet BuildSujetByIdSujet(int idSujet)
        {            
            List<SqlParameter> listeSqlParam = new List<SqlParameter>();
            listeSqlParam.Add(new SqlParameter("IDSUJET", idSujet));
            using (DataSet dSet = GetDataSet("BUILDSUJETBYIDSUJET", listeSqlParam))
            {
                if (dSet.Tables[0].Rows.Count == 0) return null;

                DataRow dRow = dSet.Tables[0].Rows[0];

                return new Sujet (BuildUtilisateurByNomUtilisateur(dRow["ID_UTILISATEUR"].ToString()),
                                 (DateTime)dRow["DATE_CREATION"],
                                 BuildRubriqueByNomRubrique(dRow["ID_RUBRIQUE"].ToString()),
                                 (int)dRow["ID_SUJET"],
                                 dRow["TITRE_SUJET"].ToString(), 
                                 dRow["DESCRIPTION_SUJET"].ToString()
                                 );
            }
        }

        /// <summary>
        /// Renvoit une liste de tous les sujets postés par rubrique
        /// Appel des sous méthodes de renvoi de types BuildRubriqueByNomRubrique et BuildUtilisateurByNomUtilisateur
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
                                              dRow["DESCSUJET"].ToString())
                                              );
                }
                return listeSujets;
            }
        }

        /// <summary>
        /// Renvoit une liste de toutes les réponses postées par titre de sujet
        /// Appel des sous methodes de renvoi de types BuildUtilisateurByNom et BuildSujetByIdSujet
        /// </summary>
        /// <param name="titreSujet"></param>
        /// <returns></returns>
        public static List<Reponse> GetReponsesBySujet(string titreSujet)
        {
            List<SqlParameter> listeSqlParam = new List<SqlParameter>();

            listeSqlParam.Add(new SqlParameter("TITRESUJET", titreSujet));
            using (DataSet dSet = GetDataSet("GETREPONSESBYSUJET", listeSqlParam))
            {
                List<Reponse> listeReponses = new List<Reponse>();

                foreach (DataRow dRow in dSet.Tables[0].Rows)
                {                   
                    Sujet s = BuildSujetByIdSujet((int)dRow["ID_SUJET"]);
                    listeReponses.Add(new Reponse (BuildUtilisateurByNomUtilisateur(dRow["NOM_UTILISATEUR"].ToString()),
                                                  (DateTime)dRow["DATE_REPONSE"],
                                                  dRow["TEXTE_REPONSE"].ToString(),
                                                  (int)dRow["ID_REPONSE"],
                                                  BuildSujetByIdSujet((int)dRow["ID_SUJET"]))
                                                  );
                }
                return listeReponses;
            }
        }
        #endregion

        #region CRUD : Create

        /// <summary>
        /// Methode qui ajoute un utilisateur dans la BDD
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="estModerateur"></param>
        /// <param name="mail"></param>
        /// <param name="empreinteSha"></param>
        /// <param name="pseudo"></param>
        /// <param name="dateCreationCompte"></param>
        /// <returns></returns>
        public static string AjoutUtilisateur (string nom, string prenom, bool estModerateur, 
                                               string mail, string empreinteSha, string pseudo, 
                                               DateTime dateCreationCompte)
        {
            List<SqlParameter> listeSqlParam = new List<SqlParameter>();

            listeSqlParam.Add(new SqlParameter("NOM", nom));
            listeSqlParam.Add(new SqlParameter("PRENOM", prenom));
            listeSqlParam.Add(new SqlParameter("ESTMODERATEUR", estModerateur));
            listeSqlParam.Add(new SqlParameter("MAIL", mail));
            listeSqlParam.Add(new SqlParameter("EMPREINTESHA", empreinteSha));
            listeSqlParam.Add(new SqlParameter("PSEUDO", pseudo));
            listeSqlParam.Add(new SqlParameter("DATECREATIONCOMPTE", dateCreationCompte));

            GetDataSet("CREATEUTILISATEUR", listeSqlParam);

            return GetLogin(pseudo);        
        }

        /// <summary>
        /// Methode qui permet de récupérer le login calculé par la BDD pour affichage à l'utilisateur
        /// </summary>
        /// <param name="pseudo"></param>
        /// <returns>STRING Login</returns>
        public static string GetLogin(string pseudo)
        {
            List<SqlParameter> listeSqlParam = new List<SqlParameter>();

            listeSqlParam.Add(new SqlParameter("PSEUDO", pseudo));
            DataSet dSet = GetDataSet("GETLOGIN", listeSqlParam);

            DataRow dRow = dSet.Tables[0].Rows[0];
            string login = dRow["LOGIN_UTILISATEUR"].ToString();

            return login;        
        }

        /// <summary>
        /// Méthode qui ajoute un sujet
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <param name="idRubrique"></param>
        /// <param name="titreSujet"></param>
        /// <param name="descriptionSujet"></param>
        /// <param name="dateCreationSujet"></param>
        /// <returns>INT Identifiant Sujet ou NULL</returns>
        public static int? AjoutSujet (int idUtilisateur, int idRubrique, string titreSujet, 
                                       string descriptionSujet, DateTime dateCreationSujet)
        {
            List<SqlParameter> listeSqlParam = new List<SqlParameter>();

            listeSqlParam.Add(new SqlParameter("IDUTILISATEUR", idUtilisateur));
            listeSqlParam.Add(new SqlParameter("IDRUBRIQUE", idRubrique));
            listeSqlParam.Add(new SqlParameter("TITRESUJET", titreSujet));
            listeSqlParam.Add(new SqlParameter("DESCRIPTIONSUJET", descriptionSujet));
            listeSqlParam.Add(new SqlParameter("DATECREATIONSUJET", dateCreationSujet));

            DataSet dSet = GetDataSet("CREATESUJET", listeSqlParam);   
            if (dSet != null)
            {
                DataRow dRow = dSet.Tables[0].Rows[0];
                return  (int.Parse(dRow["ID_SUJET"].ToString()));
            }
            return null;
        }

        /// <summary>
        /// Méthode qui ajoute une réponse selon un sujet
        /// </summary>
        /// <param name="idSujet"></param>
        /// <param name="idUtilisateur"></param>
        /// <param name="texteReponse"></param>
        /// <param name="dateReponse"></param>
        /// <returns>INT Identifiant Réponse ou NULL</returns>
        public static int? AjoutReponse(int idSujet, int idUtilisateur, string texteReponse, DateTime dateReponse)
        {
            List<SqlParameter> listeSqlParam = new List<SqlParameter>();

            listeSqlParam.Add(new SqlParameter("IDSUJET", idSujet));
            listeSqlParam.Add(new SqlParameter("IDUTILISATEUR", idUtilisateur));
            listeSqlParam.Add(new SqlParameter("TEXTEREPONSE", texteReponse));
            listeSqlParam.Add(new SqlParameter("DATEREPONSE", dateReponse));

            DataSet dSet = GetDataSet("CREATEREPONSE", listeSqlParam);

            if (dSet != null)
            {
                DataRow dRow = dSet.Tables[0].Rows[0];
                return (int.Parse(dRow["ID_REPONSE"].ToString()));
            }
            return null;
        }
        #endregion

        #region CRUD : Update
        #endregion

        #region CRUD : Delete

        /// <summary>
        /// Méthode de suppression d'un sujet et réponses correspondantes en cascade
        /// </summary>
        /// <param name="idSujet"></param>
        /// <returns>INT Identifiant Sujet supprimé ou NULL</returns>
        public static int? SupprimerSujet (int idSujet)
        {
            List<SqlParameter> listeSqlParam = new List<SqlParameter>();

            listeSqlParam.Add(new SqlParameter("IDSUJET", idSujet));

            DataSet dSet = GetDataSet("DELETESUJET", listeSqlParam);

            if (dSet != null)
            {
                DataRow dRow = dSet.Tables[0].Rows[0];
                //TODO Possibilité de DELETE EN CASCADE SupprimerReponse(idSujet);
                return (int.Parse(dRow["ID_SUJET"].ToString()));
            }
            return null;
            
        }

        /// <summary>
        /// Méthode de suppression d'une réponse
        /// </summary>
        /// <param name="idReponse"></param>
        /// <returns>INT Identifiant réponse supprimée ou NULL</returns>
        public static int? SupprimerReponse (int idReponse)
        {
            List<SqlParameter> listeSqlParam = new List<SqlParameter>();

            listeSqlParam.Add(new SqlParameter("IDREPONSE", idReponse));

            DataSet dSet = GetDataSet("DELETEREPONSE", listeSqlParam);

            if (dSet != null)
            {
                DataRow dRow = dSet.Tables[0].Rows[0];
                return (int.Parse(dRow["ID_REPONSE"].ToString()));
            }
            return null;
        }

        /// <summary>
        /// Méthode de modification du titre d'un sujet
        /// </summary>
        /// <param name="idSujet"></param>
        /// <param name="titreSujet"></param>
        /// <returns>INT Identifiant sujet modifié ou NULL</returns>
        public static int? ModifierTitreSujet(int idSujet, string titreSujet)
        {
            List<SqlParameter> listeSqlParam = new List<SqlParameter>();

            listeSqlParam.Add(new SqlParameter("IDSUJET", idSujet));
            listeSqlParam.Add(new SqlParameter("TITRESUJET", titreSujet));

            DataSet dSet = GetDataSet("UPDATESUJETTITRE", listeSqlParam);

            if (dSet != null)
            {
                DataRow dRow = dSet.Tables[0].Rows[0];
                return (int.Parse(dRow["ID_SUJET"].ToString()));
            }
            return null;
        }

        /// <summary>
        /// Méthode de modification de la description d'un sujet
        /// </summary>
        /// <param name="idSujet"></param>
        /// <param name="descSujet"></param>
        /// <returns>INT Identifiant sujet modifié ou NULL</returns>
        public static int? ModifierDescriptionSujet(int idSujet, string descSujet)
        {
            List<SqlParameter> listeSqlParam = new List<SqlParameter>();

            listeSqlParam.Add(new SqlParameter("IDSUJET", idSujet));
            listeSqlParam.Add(new SqlParameter("DESCRIPTIONSUJET", descSujet));

            DataSet dSet = GetDataSet("UPDATESUJETDESCRIPTION", listeSqlParam);

            if (dSet != null)
            {
                DataRow dRow = dSet.Tables[0].Rows[0];
                return (int.Parse(dRow["ID_SUJET"].ToString()));
            }
            return null;
        }
        #endregion


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
