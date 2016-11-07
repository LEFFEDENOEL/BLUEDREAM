using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using METIERForadev;

namespace DALForadev
{
    /// <summary>
    /// Classe statique qui contient toutes les méthodes de constitution d'objets SQL. 
    /// qui appellent la méthode générique GetDataSet dans la classe statique DALTools
    /// </summary>
    public static class DALMain 
    {
        #region CRUD : RETRIEVE

        /// <summary>
        /// Appel méthode générique GetDataSet dans la classe statique DALTools.
        /// Renvoie GetDataSet vide ou peuplé ou NULL si exception SQL
        /// </summary>
        /// <param name="nomProcedureStockee"></param>
        /// <param name="listeSqlParam"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string nomProcedureStockee, List<SqlParameter> listeSqlParam)
        {
            return DALTools.GetDataSet(nomProcedureStockee, listeSqlParam);
        }


        /// <summary>
        /// Renvoie objet utilisateurConnecte ou objet utilisateurConnecte NULL si utilisateur inconnu ou NULL si exception SQL
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
                if (dSet == null) return null;

                if (dSet.Tables[0].Rows.Count == 0) return new NonModerateur();

                DataRow dRow = dSet.Tables[0].Rows[0];
                bool role = ((bool)dRow["EST_MODERATEUR"] == true);
  
                if (role) return new Moderateur ((int)dRow["ID_UTILISATEUR"],
                                                 dRow["NOM_UTILISATEUR"].ToString(),
                                                 dRow["PRENOM_UTILISATEUR"].ToString(),
                                                 dRow["MAIL_UTILISATEUR"].ToString(),
                                                 dRow["LOGIN_UTILISATEUR"].ToString(),
                                                 role,
                                                 dRow["PSEUDO_UTILISATEUR"].ToString(),
                                                (DateTime)dRow["DATE_INSCRIPTION"]);

                return new NonModerateur ((int)dRow["ID_UTILISATEUR"],
                                          dRow["NOM_UTILISATEUR"].ToString(),
                                          dRow["PRENOM_UTILISATEUR"].ToString(),
                                          dRow["MAIL_UTILISATEUR"].ToString(),
                                          dRow["LOGIN_UTILISATEUR"].ToString(),
                                          role,
                                          dRow["PSEUDO_UTILISATEUR"].ToString(),
                                         (DateTime)dRow["DATE_INSCRIPTION"]);
            }
        }

        /// <summary>
        /// Renvoie un objet liste des rubriques ou NULL si exception SQL
        /// </summary>
        /// <returns></returns>
        public static List<Rubrique> GetRubriques()
        {
            using (DataSet dSet = GetDataSet("GETRUBRIQUE", new List<SqlParameter>()))
            {
                if (dSet == null) return null;

                List<Rubrique> listeRubriques = new List<Rubrique>();

                foreach (DataRow dRow in dSet.Tables[0].Rows)
                {
                    listeRubriques.Add(new Rubrique(Int32.Parse(dRow["ID_RUBRIQUE"].ToString()), dRow["NOM_RUBRIQUE"].ToString()));
                }
                return listeRubriques;
            }
        }

        /// <summary>
        /// Renvoie le type complet "Rubrique" ou NULL
        /// </summary>
        /// <param name="nomRubrique"></param>
        /// <returns></returns>
        public static Rubrique BuildRubriqueByNomRubrique(string nomRubrique)
        {
            List<SqlParameter> listeSqlParam = new List<SqlParameter>();

            listeSqlParam.Add(new SqlParameter("NOMRUBRIQUE", nomRubrique));

            using (DataSet dSet = GetDataSet("BUILDRUBRIQUEBYNOMRUBRIQUE", listeSqlParam))
            {
                if (dSet == null) return null;

                if (dSet.Tables[0].Rows.Count == 0) return null;

                DataRow dRow = dSet.Tables[0].Rows[0];

                return new Rubrique((int)dRow["ID_RUBRIQUE"], dRow["NOM_RUBRIQUE"].ToString());
            }
        }

        /// <summary>
        /// Renvoie le type complet "Utilisateur" ou NULL
        /// </summary>
        /// <param name="nomUtilisateur"></param>
        /// <returns></returns>
        public static Utilisateur BuildUtilisateurByNomUtilisateur(string nomUtilisateur)
        {
            List<SqlParameter> listeSqlParam = new List<SqlParameter>();

            listeSqlParam.Add(new SqlParameter("NOMUTILISATEUR", nomUtilisateur));

            using (DataSet dSet = GetDataSet("BUILDUTILISATEURBYNOMUTILISATEUR", listeSqlParam))
            {
                if (dSet == null) return null;

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
        /// Renvoie le type complet "Sujet" ou NULL
        /// </summary>
        /// <param name="idSujet"></param>
        /// <returns></returns>
        public static Sujet BuildSujetByIdSujet(int idSujet)
        {            
            List<SqlParameter> listeSqlParam = new List<SqlParameter>();

            listeSqlParam.Add(new SqlParameter("IDSUJET", idSujet));

            using (DataSet dSet = GetDataSet("BUILDSUJETBYIDSUJET", listeSqlParam))
            {
                if (dSet == null) return null;

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
        /// Renvoie un objet liste de tous les sujets postés par rubrique ou NULL si exception SQL.
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
                if (dSet == null) return null;

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
        /// Renvoie un objet liste de toutes les réponses postées par titre de sujet ou NULL si exception SQL.
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
                if (dSet == null) return null;

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

        /// <summary>
        /// Méthode de construction d'un dictionnaire de constantes depuis la base de données.
        /// Renvoie les valeurs des constantes ou NULL si exception SQL
        /// </summary>
        /// <returns>Renvoie un dictionnaire avec une clé STRING, et 2 valeurs STRING</returns>
        public static Dictionary<string, Constante> GetConstantes()
        {
            using (DataSet dSet = GetDataSet("GETCONSTANTES", new List<SqlParameter>()))
            {
                if (dSet == null) return null;

                Dictionary<string, Constante> dictionnaireConstantes = new Dictionary<string, Constante>();

                foreach (DataRow dRow in dSet.Tables[0].Rows)
                {
                    Constante cte = new Constante(dRow["REFERENCE"].ToString(),
                                                  dRow["VALEUR1"].ToString(),
                                                  dRow["VALEUR2"].ToString());

                    dictionnaireConstantes.Add(cte.Reference, cte);

                }
                return dictionnaireConstantes;
            }
        }

        // Autre possibilité GETCONSTANTES avec liste typée

        //public static List<Constante> GetConstantes()
        //{
        //    using (DataSet dSet = GetDataSet("GETCONSTANTES", new List<SqlParameter>()))
        //    {
        //        List<Constante> listeConstantes = new List<Constante>();

        //        foreach (DataRow dRow in dSet.Tables[0].Rows)
        //        {
        //            listeConstantes.Add(new Constante(Int32.Parse(dRow["ID_REFERENCE"].ToString()), 
        //                                              dRow["REFERENCE"].ToString(), 
        //                                              dRow["VALEUR"].ToString()));
        //        }
        //        return listeConstantes;
        //    }
        //}
        #endregion

        #region CRUD : CREATE

        /// <summary>
        /// Methode qui ajoute un utilisateur dans la BDD et renvoie son login.
        /// Renvoie null s'il y a une exception sql
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="estModerateur"></param>
        /// <param name="mail"></param>
        /// <param name="empreinteSha"></param>
        /// <param name="pseudo"></param>
        /// <param name="dateCreationCompte"></param>
        /// <returns></returns>
        public static string AjoutUtilisateur(string nom, string prenom, bool estModerateur,
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

            using (DataSet dSet = GetDataSet("CREATEUTILISATEUR", listeSqlParam))
            {
                if (dSet == null) return null;                     
                return GetLogin(pseudo);
            }
        }

        /// <summary>
        /// Methode qui permet de récupérer le login calculé par la BDD pour affichage à l'utilisateur.
        /// Renvoie NULL s'il y a une exception sql.
        /// Le pseudo doit exister en base
        /// </summary>
        /// <param name="pseudo"></param>
        /// <returns></returns>
        public static string GetLogin(string pseudo)
        {
            List<SqlParameter> listeSqlParam = new List<SqlParameter>();

            listeSqlParam.Add(new SqlParameter("PSEUDO", pseudo));

            using (DataSet dSet = GetDataSet("GETLOGIN", listeSqlParam))
            {
                if (dSet == null) return null;

                DataRow dRow = dSet.Tables[0].Rows[0];
                string login = dRow["LOGIN_UTILISATEUR"].ToString();

                return login;
            }         
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
        /// <returns></returns>
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
        /// Méthode qui ajoute une réponse selon un sujet.
        /// Renvoie identifiant réponse ou NULL si exception SQL
        /// </summary>
        /// <param name="idSujet"></param>
        /// <param name="idUtilisateur"></param>
        /// <param name="texteReponse"></param>
        /// <param name="dateReponse"></param>
        /// <returns></returns>
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

        #region CRUD : UPDATE

        /// <summary>
        /// Méthode de changement du mot de passe pour n'importe quel utilisateur loggé.
        /// Renvoie identifiant utilisateur si ok, NULL si exception SQL
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <param name="login"></param>
        /// <param name="empreinteSha"></param>
        /// <returns></returns>
        static public int? ChangePass(int idUtilisateur, string login, string empreinteSha)
        {
            List<SqlParameter> listeSqlParam = new List<SqlParameter>();

            listeSqlParam.Add(new SqlParameter("IDUTILISATEUR", idUtilisateur));
            listeSqlParam.Add(new SqlParameter("LOGIN", login));
            listeSqlParam.Add(new SqlParameter("NOUVEAUMDPSHA", empreinteSha));

            DataSet dSet = GetDataSet("CHANGEPASS", listeSqlParam);

            if (dSet != null)
            {
                DataRow dRow = dSet.Tables[0].Rows[0];
                return (int.Parse(dRow["ID_UTILISATEUR"].ToString()));
            }
            return null;
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
        /// Méthode de modification de la description d'un sujet.
        /// Renvoie identifiant du sujet modifié ou NULL si exception SQL
        /// </summary>
        /// <param name="idSujet"></param>
        /// <param name="descSujet"></param>
        /// <returns></returns>
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

        #region CRUD : DELETE

        /// <summary>
        /// Méthode de suppression d'un sujet et réponses correspondantes en cascade. "on delete cascade" dans SQL.
        /// Renvoie identifiant sujet supprimé ou NULL si exception SQL
        /// </summary>
        /// <param name="idSujet"></param>
        /// <returns></returns>
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
        /// Méthode de suppression d'une réponse.
        /// Renvoie identifiant réponse supprimée ou NULL si exception SQL
        /// </summary>
        /// <param name="idReponse"></param>
        /// <returns></returns>
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
        #endregion
    }
}
