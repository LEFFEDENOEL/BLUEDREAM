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
using METIERForadev;
using BLLForadev;

namespace WinFormForadev
{
    public partial class AccueilForum : Form
    {
        UtilisateurConnecte uConnect;
        Dictionary<string, Constante> dictionnaireConstantes;

        public AccueilForum()
        {
            InitializeComponent();

            // Chargement du profil d'accès aux composants graphiques, par défaut utilisateur non connecté
            VisibiliteComposantsUtilisateurNonConnecte();

            // Chargement depuis la BDD, d'un dictionnaire des valeurs de constantes erreur
            dictionnaireConstantes = BLLMain.GetConstantes();

            //Appel de la liste dans la classe BLL récupérée par la classe DAO
            List<Rubrique> listeRubriques = BLLMain.GetRubriques();
           
            //Alimentation du bindingsource avec la liste créé par la méthode GetRubriques()
            BindingSource bsRubriques = new BindingSource();
            bsRubriques.DataSource = listeRubriques;

            //Affectation de la combobox Rubriques
            cbxListeRubriques.DataSource = bsRubriques.DataSource;
            cbxListeRubriques.DataSource = listeRubriques;
            cbxListeRubriques.DisplayMember = "Nom";
            cbxListeRubriques.ValueMember = "Id";          
        }

        #region Methodes

        /// <summary>
        /// Methode VOID de chargement du datagridview Sujets
        /// </summary>
        private void LoadSujet()
        {
            //Appel de la liste dans la classe BLL récupérée par la classe DAO               
            List<Sujet> listeSujets = BLLMain.GetSujetsByRubrique(cbxListeRubriques.SelectedItem.ToString());

            //Alimentation du bindingsource avec la liste créé
            BindingSource bsSujets = new BindingSource();

            //Affectation et paramétrage du datagridview         
            bsSujets.DataSource = listeSujets;
            dgvSujets.DataSource = bsSujets.DataSource;

            dgvSujets.Columns[0].Visible = false;
            dgvSujets.Columns[1].Visible = false;
            dgvSujets.Columns[2].HeaderText = "Titre";
            dgvSujets.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSujets.Columns[3].HeaderText = "Pseuso";
            dgvSujets.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSujets.Columns[4].HeaderText = "Date";
            dgvSujets.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSujets.Columns[5].HeaderText = "Texte";
        }

        /// <summary>
        /// Méthode VOID de chargement du datagridview Réponses
        /// </summary>
        private void LoadReponse()
        {
            //Récupération du contenu de la cellule "titreSujet" de la ligne courante du datagridview dvgSujets
            string titreSujet = dgvSujets.CurrentRow.Cells[2].Value.ToString();
            //Appel de la liste dans la classe BLL récupérée par la classe DAO 
            List<Reponse> listeReponses = BLLMain.GetReponsesBySujet(titreSujet);

            //Alimentation du bindingsource avec la liste créé
            BindingSource bsReponses = new BindingSource();

            //Affectation et paramétrage du datagridview         
            bsReponses.DataSource = listeReponses;
            dgvReponses.DataSource = bsReponses.DataSource;

            dgvReponses.Columns[0].Visible = false;
            dgvReponses.Columns[1].HeaderText = "Titre";
            dgvReponses.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReponses.Columns[2].HeaderText = "Pseudo";
            dgvReponses.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReponses.Columns[3].HeaderText = "Date";
            dgvReponses.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReponses.Columns[4].HeaderText = "Texte réponse";
        }

        /// <summary>
        /// Methode de gestion de visibilité des composants pour un utilisateur non connecté
        /// </summary>
        public void VisibiliteComposantsUtilisateurNonConnecte()
        {
            flpSujets.Visible = false;
            flpReponses.Visible = false;
            flpModerateur.Visible = false;
            flpChangePass.Visible = false;
            btnSupprimerReponse.Visible = false;
        }

        /// <summary>
        /// Methode de gestion de visibilité des composants pour un utilisateur non modérateur connecté
        /// </summary>
        public void VisibiliteComposantsUtilisateurNonModerateurConnecte()
        {
            flpSujets.Visible = true;
            flpReponses.Visible = true;
            flpModerateur.Visible = false;
            btnModifierDescriptionSujet.Visible = false;
            btnSupprimerSujet.Visible = false;
            btnModifierTitreSujet.Visible = false;
            btnSupprimerReponse.Visible = false;
            VisibiliteComposantsLoginInscription();
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
            lblInfosLogin.Visible = false;
            lblInfoMdp.Visible = false;
            btnChangePass.Visible = true;
        }

        /// <summary>
        /// Méthode de gestion de visibilité des composants pour un utilisateur modérateur connecté
        /// </summary>
        public void VisibiliteComposantsUtilisateurModerateurConnecte()
        {
            flpSujets.Visible = true;
            flpReponses.Visible = true;
            flpModerateur.Visible = true;
            btnSupprimerReponse.Visible = true;
            VisibiliteComposantsLoginInscription();
        }

        public void MessageQuitter()
        {
            Constante constanteQuitter;
            dictionnaireConstantes.TryGetValue("QUITTER_CONFIRM", out constanteQuitter);

            if (MessageBox.Show(constanteQuitter.Valeur2, constanteQuitter.Valeur1,
                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button3) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion

        #region Evènements

        /// <summary>
        /// Méthode qui charge le datagridview Sujets sur sélection combobox Rubriques
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxListeRubriques_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Appel méthode de chargement du datagridview "Sujets"
            LoadSujet();
        }

        /// <summary>
        /// Méthode de chargement du datagridview "Réponses" en fonction de la ligne courante du datagrid "Sujets"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSujets_SelectionChanged(object sender, EventArgs e)
        {
            LoadReponse();
        }

        /// <summary>
        /// Auhentifie l'utilisateur (déchiffrement du mot de passe en BDD), et renvoit son rôle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string mdpFromClient = txtbMdp.Text;
            // Appel méthode statique de haschage dans la classe statique BLL
            string empreinteSha = BLLMain.HashShaMdp(mdpFromClient);
            string login = txtbLogin.Text;

            // Appel méthode statique d'authentification dans la classe BLL
            uConnect = BLLMain.GetIdentificationUtilisateur(empreinteSha, login);
         
            // Si rôle est null : connexion à la base a échoué --> appel dictionnaire constantes, msg erreur
            if (uConnect == null)
            {
                Constante constanteEchecConnexion;
                dictionnaireConstantes.TryGetValue("BDD_CONNEXION", out constanteEchecConnexion);
                MessageBox.Show(constanteEchecConnexion.Valeur2, constanteEchecConnexion.Valeur1, 
                                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtbLogin.Clear();
                txtbMdp.Clear();
            }
            // Si id_utilisateur = 0 : utilisateur inconnu dans la base de données --> appel dictionnaire constantes, msg erreur
            else if (uConnect.Id == 0)
            {
                Constante constanteErreurAuthenticication;
                dictionnaireConstantes.TryGetValue("BDD_AUTHENTIFICATION", out constanteErreurAuthenticication);
                MessageBox.Show(constanteErreurAuthenticication.Valeur2, constanteErreurAuthenticication.Valeur1, 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbLogin.Clear();
                txtbMdp.Clear();
            }
            else
            {
                // Suivant le rôle remonté de la BDD, accés aux composants graphiques différencié
                if (uConnect.Role) VisibiliteComposantsUtilisateurModerateurConnecte();
                else VisibiliteComposantsUtilisateurNonModerateurConnecte();
                
                Constante constanteValidLogin;
                dictionnaireConstantes.TryGetValue("PASS_VALIDE", out constanteValidLogin);
                MessageBox.Show(constanteValidLogin.Valeur2, constanteValidLogin.Valeur1 + login, 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //TODO SWITCH CASE TRUE
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
            // Appel méthode statique de haschage dans la classe statique BLL
            string empreinteSha = BLLMain.HashShaMdp(txtbInscriptionPasse.Text);
            string pseudo = txtbPseudo.Text;
            DateTime dateInscription = System.DateTime.Now;

            // Appel méthode statique dans classe statique BLL
            string login = BLLMain.AjoutUtilisateur(nom, prenom, estModerateur, mail, empreinteSha, pseudo, dateInscription);

            if (login == null)
            {
                // Méthode remonte null donc erreur --> dictionnaire constantes, msg validation
                Constante constanteErreur;
                dictionnaireConstantes.TryGetValue("INSCRIPTION_ERROR", out constanteErreur);
                MessageBox.Show(constanteErreur.Valeur2 + login, constanteErreur.Valeur1, 
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            VisibiliteComposantsLoginInscription();

            // Confirmation inscription --> 
            Constante constanteValidInscription;
            dictionnaireConstantes.TryGetValue("INSCRIPTION_VALIDE", out constanteValidInscription);
            MessageBox.Show(constanteValidInscription.Valeur2 + login, constanteValidInscription.Valeur1, 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Méthode de changement de mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btValidNouveauPasse_Click(object sender, EventArgs e)
        {
            if (txtbNouveauPasse.Text == txtbConfirmNouveauPasse.Text) { 

                // Appel méthode statique de haschage dans la classe statique BLL
                string empreinteSha = BLLMain.HashShaMdp(txtbConfirmNouveauPasse.Text);
                int idUtilisateur = uConnect.Id;
                string login = uConnect.Login;

                // Appel méthode statique de changement de mot de passe dans la classe statique BLL
                BLLMain.ChangePass(idUtilisateur, login, empreinteSha);

                flpChangePass.Visible = false;
                lblInfoNouveauPasse.Visible = false;

                // Les mots de passe correspondent --> dictionnaire constantes, msg validation
                Constante constanteValidNvoPass;
                dictionnaireConstantes.TryGetValue("PASS_CHANGE", out constanteValidNvoPass);
                MessageBox.Show(constanteValidNvoPass.Valeur2, constanteValidNvoPass.Valeur1, 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);           
            }
            // Les mots de passe ne correspondent pas --> dictionnaire constantes, msg erreur
            else
            {
                Constante constanteErreurPassMatch;
                dictionnaireConstantes.TryGetValue("PASS_MATCH", out constanteErreurPassMatch);
                MessageBox.Show(constanteErreurPassMatch.Valeur2, constanteErreurPassMatch.Valeur1, 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbNouveauPasse.Clear();
                txtbConfirmNouveauPasse.Clear();
            }         
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            flpChangePass.Visible = true;
            lblInfoNouveauPasse.Visible = true;
        }

        /// <summary>
        /// Méthode qui permet l'ajout d'un sujet par un utilisateur connecté
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjoutSujet_Click(object sender, EventArgs e)
        {           
            int idUtilisateur = uConnect.Id;
            int idRubrique = Int32.Parse(cbxListeRubriques.SelectedValue.ToString());           
            string titreSujet = txtbTitreSujet.Text;
            string descriptionSujet = txtbTexteSujet.Text;
            DateTime dateCreationSujet = System.DateTime.Now;

            // Appel méthode statique dans classe statique BLL
            BLLMain.AjoutSujet(idUtilisateur, idRubrique, titreSujet, descriptionSujet, dateCreationSujet);

            // Rechargement-rafraîchissement du datagridview "Sujets"
            LoadSujet();

            txtbTexteSujet.Clear();
            txtbTitreSujet.Clear();      
        }

        /// <summary>
        /// Méthode qui permet à l'utilisateur connecté de poster une réponse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPosterReponse_Click(object sender, EventArgs e)
        {
            int idUtilisateur = uConnect.Id;
            int idSujet = Int32.Parse(dgvSujets.CurrentRow.Cells[1].Value.ToString());
            string texteReponse = txtbTexteReponse.Text;
            DateTime dateReponse = System.DateTime.Now;

            // Appel méthode statique dans classe statique BLL
            BLLMain.AjoutReponse(idSujet, idUtilisateur, texteReponse, dateReponse);

            // Rechargement-rafraîchissement du datagridview "Réponses"
            LoadReponse();

            txtbTexteReponse.Clear();
        }

        /// <summary>
        /// Méthode qui permet à un modérateur connecté de supprimer un sujet et les réponses en cascade
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerSujet_Click(object sender, EventArgs e)
        {
            int idSujet = Int32.Parse(dgvSujets.CurrentRow.Cells[1].Value.ToString());

            // Appel méthode statique dans classe statique BLL
            BLLMain.SupprimerSujet(idSujet);

            // Rafraîchissement des datagridview "Sujets et Réponses"
            LoadSujet();
            LoadReponse();
        }

        /// <summary>
        /// Méthode qui permet à un modérateur connecté de supprimer une réponse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerReponse_Click(object sender, EventArgs e)
        {
            int idReponse = Int32.Parse(dgvReponses.CurrentRow.Cells[0].Value.ToString());

            // Appel méthode statique dans classe statique BLL
            BLLMain.SupprimerReponse(idReponse);

            // Rechargement-rafraîchissement du datagridview "Réponses"
            LoadReponse();
        }

        /// <summary>
        /// Méthode qui permet à un modérateur connecté de modifier le titre d'un sujet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierTitreSujet_Click(object sender, EventArgs e)
        {
            int idSujet = Int32.Parse(dgvSujets.CurrentRow.Cells[1].Value.ToString());
            string titreSujet = txtbTitreSujet.Text;

            // Appel méthode statique dans classe statique BLL
            BLLMain.ModifierTitreSujet(idSujet, titreSujet);

            // Rechargement-rafraîchissement du datagridview "Sujets"
            LoadSujet();
          
            txtbTitreSujet.Clear();
        }

        /// <summary>
        /// Méthode qui permet à un modérateur connecté de modifier la description d'un sujet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierDescriptionSujet_Click(object sender, EventArgs e)
        {
            int idSujet = Int32.Parse(dgvSujets.CurrentRow.Cells[1].Value.ToString());
            string descSujet = txtbTexteSujet.Text;

            // Appel méthode statique dans classe statique BLL
            BLLMain.ModifierDescriptionSujet(idSujet, descSujet);

            // Rechargement-rafraîchissement du datagridview "Sujets"
            LoadSujet();

            txtbTexteSujet.Clear();           
        }

        /// <summary>
        /// Méthode qui permet un rafraîchissement général des sujets et des réponses
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Constante constante;
            dictionnaireConstantes.TryGetValue("REFRESH_VALIDE", out constante);
            lblRefreshDonnees.Text = constante.Valeur1;
            DateTime dateHeureRefresh = DateTime.Now;
            lblRefreshDonnees.Text = lblRefreshDonnees.Text + dateHeureRefresh;
            LoadSujet();
            LoadReponse();
                     
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            MessageQuitter();
        }

        private void btnQuitterInscription_Click(object sender, EventArgs e)
        {
            MessageQuitter();
        }

        private void btnQuitterConnection_Click(object sender, EventArgs e)
        {
            MessageQuitter();
        }
        #endregion


    }
}
