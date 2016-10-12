﻿using Foradev;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormForadev
{
    public partial class AccueilForum : Form
    {
        UtilisateurConnecte uConnect;

        public AccueilForum()
        {
            InitializeComponent();
            VisibiliteComposantsUtilisateurNonConnecte();

            //Appel de la liste dans la classe BLL récupérée par la classe DAO
            List<Rubrique> listeRubriques = BLL.GetRubriques();
           
            //Alimentation du bindingsource avec la liste créé par la méthode GetRubriques()
            BindingSource bsRubriques = new BindingSource();
            bsRubriques.DataSource = listeRubriques;

            //Affectation de la combobox Rubriques
            cbxListeRubriques.DataSource = bsRubriques.DataSource;
            cbxListeRubriques.DataSource = listeRubriques;
            cbxListeRubriques.DisplayMember = "NOM_RUBRIQUE";
            cbxListeRubriques.ValueMember = "ID_RUBRIQUE";
        }

        #region Methodes

        /// <summary>
        /// Methode de gestion de visibilité des composants pour un utilisateur non connecté
        /// </summary>
        public void VisibiliteComposantsUtilisateurNonConnecte()
        {
            flpSujetsInf.Visible = false;
            flpReponses.Visible = false;
            flpChangePass.Visible = false;
            btnSupprimerReponse.Visible = false;
        }

        /// <summary>
        /// Methode de gestion de visibilité des composants pour un utilisateur non modérateur connecté
        /// </summary>
        public void VisibiliteComposantsUtilisateurNonModerateurConnecte()
        {
            flpSujetsInf.Visible = true;
            flpReponses.Visible = true;
            btnModifierSujet.Visible = false;
            btnSupprimerSujet.Visible = false;
        }

        /// <summary>
        /// Méthode de gestion de visibilité des composants pour un utilisateur qui se logue ou s'inscrit
        /// </summary>
        public void VisibiliteComposantsLoginInscription()
        {
            flpIdentification.Visible = false;
            flpInscription.Visible = false;
            lblInfoPasseInscription.Visible = false;
            lblInfoNouveauPasse.Visible = false;
            btnChangePass.Visible = true;
        }

        /// <summary>
        /// Méthode de gestion de visibilité des composants pour un utilisateur modérateur connecté
        /// </summary>
        public void VisibiliteComposantsUtilisateurModerateurConnecte()
        {
            flpSujetsInf.Visible = true;
            flpReponses.Visible = true;
            btnModifierSujet.Visible = true;
            btnSupprimerSujet.Visible = true;
            btnSupprimerSujet.Visible = true;
        }
        #endregion

        #region Evènements

        /// <summary>
        /// Méthode qui charge le datagridview Sujets sur sélection combobox Rubriques
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxListeRubriques_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Appel de la liste dans la classe BLL récupérée par la classe DAO               
            List<Sujet> listeSujets = BLL.GetSujetsByRubrique(cbxListeRubriques.SelectedValue.ToString());

            //Alimentation du bindingsource avec la liste créé
            BindingSource bsSujets = new BindingSource();

            //Affectation et paramétrage du datagridview         
            bsSujets.DataSource = listeSujets;
            dgvSujets.DataSource = bsSujets.DataSource;

            dgvSujets.Columns[0].Visible = false;
            dgvSujets.Columns[1].Visible = false;
            dgvSujets.Columns[2].HeaderText = "Titre";
            dgvSujets.Columns[2].Width = 125;
            dgvSujets.Columns[3].HeaderText = "Pseuso";
            dgvSujets.Columns[3].Width = 100;
            dgvSujets.Columns[4].HeaderText = "Date";
            dgvSujets.Columns[4].Width = 100;
            dgvSujets.Columns[5].HeaderText = "Texte";
        }

        /// <summary>
        /// Méthode qui charge le datagridview dgvReponses sur double click row dans datagridview dgvSujets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSujets_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ////Récupération du contenu de la cellule "titreSujet" de la ligne courante du datagridview dvgSujets
            string titreSujet = dgvSujets.CurrentRow.Cells[2].Value.ToString();

            //Appel de la liste dans la classe BLL récupérée par la classe DAO 
            List<Reponse> listeReponses = BLL.GetReponsesBySujet(titreSujet);

            //Alimentation du bindingsource avec la liste créé
            BindingSource bsReponses = new BindingSource();

            //Affectation et paramétrage du datagridview         
            bsReponses.DataSource = listeReponses;
            dgvReponses.DataSource = bsReponses.DataSource;

            dgvReponses.Columns[0].Visible = false;
            dgvReponses.Columns[1].HeaderText = "Titre";
            dgvReponses.Columns[1].Width = 125;
            dgvReponses.Columns[2].HeaderText = "Pseudo";
            dgvReponses.Columns[2].Width = 100;
            dgvReponses.Columns[3].HeaderText = "Date";
            dgvReponses.Columns[3].Width = 100;
            dgvReponses.Columns[4].HeaderText = "Texte réponse";
        }

        /// <summary>
        /// Auhentifie l'utilisateur (déchiffrement du mot de passe en BDD), et renvoit son rôle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string mdpFromClient = txtbMdp.Text;
            string empreinteSha = BLL.HashShaMdp(mdpFromClient);

            string login = txtbLogin.Text;

            uConnect = BLL.GetIdentificationUtilisateur(empreinteSha, login);

            if (uConnect.Role) VisibiliteComposantsUtilisateurModerateurConnecte();
            else
            {
                VisibiliteComposantsUtilisateurNonModerateurConnecte();
            }

            VisibiliteComposantsLoginInscription();
        }

        /// <summary>
        /// Methode qui envoit le formulaire d'inscription dans la BDD et renvoit le login calculé par la BDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidInscription_Click(object sender, EventArgs e)
        {
            string nom = txtbNom.Text;
            string prenom = txtbPrenom.Text;
            bool estModerateur = false;
            string mail = txtbMail.Text;
            string empreinteSha = BLL.HashShaMdp(txtbInscriptionPasse.Text);
            string pseudo = txtbPseudo.Text;
            DateTime dateInscription = System.DateTime.Now;

            string login = BLL.AjoutUtilisateur(nom, prenom, estModerateur, mail, empreinteSha, pseudo, dateInscription);

            VisibiliteComposantsLoginInscription();

            lblInscriptionOk.Visible = true;
            lblInscriptionOk.Text = lblInscriptionOk.Text + login;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            flpChangePass.Visible = true;
            lblInfoNouveauPasse.Visible = true;
        }

        private void btnAjoutSujet_Click(object sender, EventArgs e)
        {           
            int idUtilisateur = uConnect.Id;
            int idRubrique = Int32.Parse(cbxListeRubriques.SelectedValue.ToString());
            //string titreSujet = dgvSujets.CurrentRow.Cells[2].Value.ToString();
            string titreSujet = txtbTitreSujet.Text;
            string descriptionSujet = txtbTexteSujet.Text;
            DateTime dateCreationSujet = System.DateTime.Now;

            BLL.AjoutSujet(idUtilisateur, idRubrique, titreSujet, descriptionSujet, dateCreationSujet);
        }

        private void btnPosterReponse_Click(object sender, EventArgs e)
        {
            int IdUtilisateur = uConnect.Id;
            int IdSujet = Int32.Parse(dgvSujets.CurrentRow.Cells[2].Value.ToString());
            string texteReponse = txtbTexteReponse.Text;
            DateTime dateReponse = System.DateTime.Now;
        }
        #endregion

        public static void AjoutSujet(int idUtilisateur, int idRubrique, string titreSujet,
                               string descriptionSujet, DateTime dateCreationSujet)
        {
            List<SqlParameter> listeSqlParam = new List<SqlParameter>();

            listeSqlParam.Add(new SqlParameter("IDUTILISATEUR", idUtilisateur));
            listeSqlParam.Add(new SqlParameter("IDRUBRIQUE", idRubrique));
            listeSqlParam.Add(new SqlParameter("TITRESUJET", titreSujet));
            listeSqlParam.Add(new SqlParameter("DESCRIPTIONSUJET", descriptionSujet));
            listeSqlParam.Add(new SqlParameter("DATECREATIONSUJET", dateCreationSujet));

            GetDataSet("CREATESUJET", listeSqlParam);
        }
    }
}
