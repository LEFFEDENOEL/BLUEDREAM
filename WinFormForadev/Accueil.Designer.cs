﻿namespace WinFormForadev
{
    partial class AccueilForum
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.gbxMain = new System.Windows.Forms.GroupBox();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tpAccesRubriquesMessages = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbxRubriquesMessagesSup = new System.Windows.Forms.GroupBox();
            this.btnModifierSujet = new System.Windows.Forms.Button();
            this.btnSupprimerSujet = new System.Windows.Forms.Button();
            this.lblListeRubriques = new System.Windows.Forms.Label();
            this.cbxListeRubriques = new System.Windows.Forms.ComboBox();
            this.lblTexteSujet = new System.Windows.Forms.Label();
            this.txtbTitreSujet = new System.Windows.Forms.TextBox();
            this.lblTitreSujetRubriquesMessages = new System.Windows.Forms.Label();
            this.txtbTexteSujet = new System.Windows.Forms.TextBox();
            this.btnAjoutSujet = new System.Windows.Forms.Button();
            this.dgvNewsletterSup = new System.Windows.Forms.DataGridView();
            this.gbxRubriquesMessagesInf = new System.Windows.Forms.GroupBox();
            this.btnSupprimerReponse = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.txtbTexteReponse = new System.Windows.Forms.TextBox();
            this.lblTexteReponse = new System.Windows.Forms.Label();
            this.dgvNewsletterInf = new System.Windows.Forms.DataGridView();
            this.tpConnexion = new System.Windows.Forms.TabPage();
            this.lblInfoMdp = new System.Windows.Forms.Label();
            this.lblInfosLogin = new System.Windows.Forms.Label();
            this.flpIdentification = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtbLogin = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.txtbMdp = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tpInscription = new System.Windows.Forms.TabPage();
            this.lblInfoNouveauPasse = new System.Windows.Forms.Label();
            this.lblInfoPasseInscription = new System.Windows.Forms.Label();
            this.flpInscription = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtbNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtbPrenom = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtbMail = new System.Windows.Forms.TextBox();
            this.lblPseuso = new System.Windows.Forms.Label();
            this.txtbPseudo = new System.Windows.Forms.TextBox();
            this.lblInscriptionPasse = new System.Windows.Forms.Label();
            this.txtbInscriptionPasse = new System.Windows.Forms.TextBox();
            this.btnValidInscription = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbNouveauPasse = new System.Windows.Forms.TextBox();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.txtbConfirmNouveauPasse = new System.Windows.Forms.TextBox();
            this.btValidNouveauPasse = new System.Windows.Forms.Button();
            this.btnPosterReponse = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.gbxMain.SuspendLayout();
            this.tbcMain.SuspendLayout();
            this.tpAccesRubriquesMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbxRubriquesMessagesSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewsletterSup)).BeginInit();
            this.gbxRubriquesMessagesInf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewsletterInf)).BeginInit();
            this.tpConnexion.SuspendLayout();
            this.flpIdentification.SuspendLayout();
            this.tpInscription.SuspendLayout();
            this.flpInscription.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.AutoScroll = true;
            this.tlpMain.AutoSize = true;
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.panelMain, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Size = new System.Drawing.Size(1310, 782);
            this.tlpMain.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.AutoSize = true;
            this.panelMain.Controls.Add(this.gbxMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(3, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1304, 776);
            this.panelMain.TabIndex = 0;
            // 
            // gbxMain
            // 
            this.gbxMain.AutoSize = true;
            this.gbxMain.BackColor = System.Drawing.Color.Silver;
            this.gbxMain.Controls.Add(this.tbcMain);
            this.gbxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMain.Location = new System.Drawing.Point(0, 0);
            this.gbxMain.Name = "gbxMain";
            this.gbxMain.Size = new System.Drawing.Size(1304, 776);
            this.gbxMain.TabIndex = 0;
            this.gbxMain.TabStop = false;
            this.gbxMain.Text = "Navigation  FORADEV";
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tpAccesRubriquesMessages);
            this.tbcMain.Controls.Add(this.tpConnexion);
            this.tbcMain.Controls.Add(this.tpInscription);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcMain.Location = new System.Drawing.Point(3, 40);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(1298, 733);
            this.tbcMain.TabIndex = 0;
            // 
            // tpAccesRubriquesMessages
            // 
            this.tpAccesRubriquesMessages.AutoScroll = true;
            this.tpAccesRubriquesMessages.BackColor = System.Drawing.Color.LightGray;
            this.tpAccesRubriquesMessages.Controls.Add(this.splitContainer1);
            this.tpAccesRubriquesMessages.Location = new System.Drawing.Point(4, 33);
            this.tpAccesRubriquesMessages.Name = "tpAccesRubriquesMessages";
            this.tpAccesRubriquesMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccesRubriquesMessages.Size = new System.Drawing.Size(1290, 696);
            this.tpAccesRubriquesMessages.TabIndex = 0;
            this.tpAccesRubriquesMessages.Text = "Rubriques et messages";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.gbxRubriquesMessagesSup);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.gbxRubriquesMessagesInf);
            this.splitContainer1.Size = new System.Drawing.Size(1284, 690);
            this.splitContainer1.SplitterDistance = 330;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbxRubriquesMessagesSup
            // 
            this.gbxRubriquesMessagesSup.AutoSize = true;
            this.gbxRubriquesMessagesSup.Controls.Add(this.btnModifierSujet);
            this.gbxRubriquesMessagesSup.Controls.Add(this.btnSupprimerSujet);
            this.gbxRubriquesMessagesSup.Controls.Add(this.lblListeRubriques);
            this.gbxRubriquesMessagesSup.Controls.Add(this.cbxListeRubriques);
            this.gbxRubriquesMessagesSup.Controls.Add(this.lblTexteSujet);
            this.gbxRubriquesMessagesSup.Controls.Add(this.txtbTitreSujet);
            this.gbxRubriquesMessagesSup.Controls.Add(this.lblTitreSujetRubriquesMessages);
            this.gbxRubriquesMessagesSup.Controls.Add(this.txtbTexteSujet);
            this.gbxRubriquesMessagesSup.Controls.Add(this.btnAjoutSujet);
            this.gbxRubriquesMessagesSup.Controls.Add(this.dgvNewsletterSup);
            this.gbxRubriquesMessagesSup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxRubriquesMessagesSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRubriquesMessagesSup.Location = new System.Drawing.Point(0, 0);
            this.gbxRubriquesMessagesSup.Name = "gbxRubriquesMessagesSup";
            this.gbxRubriquesMessagesSup.Size = new System.Drawing.Size(1284, 330);
            this.gbxRubriquesMessagesSup.TabIndex = 0;
            this.gbxRubriquesMessagesSup.TabStop = false;
            this.gbxRubriquesMessagesSup.Text = "Derniers sujets postés";
            // 
            // btnModifierSujet
            // 
            this.btnModifierSujet.AutoSize = true;
            this.btnModifierSujet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnModifierSujet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierSujet.Location = new System.Drawing.Point(631, 216);
            this.btnModifierSujet.Name = "btnModifierSujet";
            this.btnModifierSujet.Size = new System.Drawing.Size(650, 37);
            this.btnModifierSujet.TabIndex = 10;
            this.btnModifierSujet.Text = "Cliquez ici pour MODIFIER le sujet selectionné";
            this.btnModifierSujet.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerSujet
            // 
            this.btnSupprimerSujet.AutoSize = true;
            this.btnSupprimerSujet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSupprimerSujet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerSujet.Location = new System.Drawing.Point(631, 253);
            this.btnSupprimerSujet.Name = "btnSupprimerSujet";
            this.btnSupprimerSujet.Size = new System.Drawing.Size(650, 37);
            this.btnSupprimerSujet.TabIndex = 9;
            this.btnSupprimerSujet.Text = "Cliquez ici pour SUPPRIMER le sujet sélectionné";
            this.btnSupprimerSujet.UseVisualStyleBackColor = true;
            // 
            // lblListeRubriques
            // 
            this.lblListeRubriques.AutoSize = true;
            this.lblListeRubriques.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblListeRubriques.Location = new System.Drawing.Point(631, 22);
            this.lblListeRubriques.Name = "lblListeRubriques";
            this.lblListeRubriques.Size = new System.Drawing.Size(401, 20);
            this.lblListeRubriques.TabIndex = 8;
            this.lblListeRubriques.Text = "Liste des rubriques dans le menu déroulant ci-dessous :";
            // 
            // cbxListeRubriques
            // 
            this.cbxListeRubriques.FormattingEnabled = true;
            this.cbxListeRubriques.Location = new System.Drawing.Point(631, 45);
            this.cbxListeRubriques.Name = "cbxListeRubriques";
            this.cbxListeRubriques.Size = new System.Drawing.Size(650, 28);
            this.cbxListeRubriques.TabIndex = 7;
            // 
            // lblTexteSujet
            // 
            this.lblTexteSujet.AutoSize = true;
            this.lblTexteSujet.Location = new System.Drawing.Point(631, 128);
            this.lblTexteSujet.Name = "lblTexteSujet";
            this.lblTexteSujet.Size = new System.Drawing.Size(222, 20);
            this.lblTexteSujet.TabIndex = 6;
            this.lblTexteSujet.Text = "Entrez ci-dessous votre texte :";
            // 
            // txtbTitreSujet
            // 
            this.txtbTitreSujet.Location = new System.Drawing.Point(634, 99);
            this.txtbTitreSujet.Name = "txtbTitreSujet";
            this.txtbTitreSujet.Size = new System.Drawing.Size(650, 26);
            this.txtbTitreSujet.TabIndex = 5;
            // 
            // lblTitreSujetRubriquesMessages
            // 
            this.lblTitreSujetRubriquesMessages.AutoEllipsis = true;
            this.lblTitreSujetRubriquesMessages.AutoSize = true;
            this.lblTitreSujetRubriquesMessages.Location = new System.Drawing.Point(631, 76);
            this.lblTitreSujetRubriquesMessages.Name = "lblTitreSujetRubriquesMessages";
            this.lblTitreSujetRubriquesMessages.Size = new System.Drawing.Size(274, 20);
            this.lblTitreSujetRubriquesMessages.TabIndex = 3;
            this.lblTitreSujetRubriquesMessages.Text = "Entrez ci-dessous votre titre de sujet :";
            // 
            // txtbTexteSujet
            // 
            this.txtbTexteSujet.Location = new System.Drawing.Point(631, 151);
            this.txtbTexteSujet.Multiline = true;
            this.txtbTexteSujet.Name = "txtbTexteSujet";
            this.txtbTexteSujet.Size = new System.Drawing.Size(650, 85);
            this.txtbTexteSujet.TabIndex = 2;
            // 
            // btnAjoutSujet
            // 
            this.btnAjoutSujet.AutoSize = true;
            this.btnAjoutSujet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAjoutSujet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutSujet.Location = new System.Drawing.Point(631, 290);
            this.btnAjoutSujet.Name = "btnAjoutSujet";
            this.btnAjoutSujet.Size = new System.Drawing.Size(650, 37);
            this.btnAjoutSujet.TabIndex = 1;
            this.btnAjoutSujet.Text = "Cliquez ici pour AJOUTER votre sujet";
            this.btnAjoutSujet.UseVisualStyleBackColor = true;
            // 
            // dgvNewsletterSup
            // 
            this.dgvNewsletterSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewsletterSup.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvNewsletterSup.Location = new System.Drawing.Point(3, 22);
            this.dgvNewsletterSup.Name = "dgvNewsletterSup";
            this.dgvNewsletterSup.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvNewsletterSup.Size = new System.Drawing.Size(628, 305);
            this.dgvNewsletterSup.TabIndex = 0;
            // 
            // gbxRubriquesMessagesInf
            // 
            this.gbxRubriquesMessagesInf.AutoSize = true;
            this.gbxRubriquesMessagesInf.Controls.Add(this.btnRefresh);
            this.gbxRubriquesMessagesInf.Controls.Add(this.btnPosterReponse);
            this.gbxRubriquesMessagesInf.Controls.Add(this.btnSupprimerReponse);
            this.gbxRubriquesMessagesInf.Controls.Add(this.btnQuitter);
            this.gbxRubriquesMessagesInf.Controls.Add(this.txtbTexteReponse);
            this.gbxRubriquesMessagesInf.Controls.Add(this.lblTexteReponse);
            this.gbxRubriquesMessagesInf.Controls.Add(this.dgvNewsletterInf);
            this.gbxRubriquesMessagesInf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxRubriquesMessagesInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRubriquesMessagesInf.Location = new System.Drawing.Point(0, 0);
            this.gbxRubriquesMessagesInf.Name = "gbxRubriquesMessagesInf";
            this.gbxRubriquesMessagesInf.Size = new System.Drawing.Size(1284, 356);
            this.gbxRubriquesMessagesInf.TabIndex = 0;
            this.gbxRubriquesMessagesInf.TabStop = false;
            this.gbxRubriquesMessagesInf.Text = "Réponses correspondantes au sujet sélectionné";
            // 
            // btnSupprimerReponse
            // 
            this.btnSupprimerReponse.AutoSize = true;
            this.btnSupprimerReponse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSupprimerReponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerReponse.Location = new System.Drawing.Point(631, 279);
            this.btnSupprimerReponse.Name = "btnSupprimerReponse";
            this.btnSupprimerReponse.Size = new System.Drawing.Size(650, 37);
            this.btnSupprimerReponse.TabIndex = 10;
            this.btnSupprimerReponse.Text = "Cliquez ici pour SUPPRIMER la réponse sélectionnée";
            this.btnSupprimerReponse.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.AutoSize = true;
            this.btnQuitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(631, 316);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(650, 37);
            this.btnQuitter.TabIndex = 9;
            this.btnQuitter.Text = "Cliquez ici pour QUITTER l\'application";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // txtbTexteReponse
            // 
            this.txtbTexteReponse.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtbTexteReponse.Location = new System.Drawing.Point(631, 42);
            this.txtbTexteReponse.Multiline = true;
            this.txtbTexteReponse.Name = "txtbTexteReponse";
            this.txtbTexteReponse.Size = new System.Drawing.Size(650, 85);
            this.txtbTexteReponse.TabIndex = 8;
            // 
            // lblTexteReponse
            // 
            this.lblTexteReponse.AutoSize = true;
            this.lblTexteReponse.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTexteReponse.Location = new System.Drawing.Point(631, 22);
            this.lblTexteReponse.Name = "lblTexteReponse";
            this.lblTexteReponse.Size = new System.Drawing.Size(322, 20);
            this.lblTexteReponse.TabIndex = 7;
            this.lblTexteReponse.Text = "Entrez ci-dessous le texte de votre réponse :";
            // 
            // dgvNewsletterInf
            // 
            this.dgvNewsletterInf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewsletterInf.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvNewsletterInf.Location = new System.Drawing.Point(3, 22);
            this.dgvNewsletterInf.Name = "dgvNewsletterInf";
            this.dgvNewsletterInf.Size = new System.Drawing.Size(628, 331);
            this.dgvNewsletterInf.TabIndex = 0;
            // 
            // tpConnexion
            // 
            this.tpConnexion.AutoScroll = true;
            this.tpConnexion.BackColor = System.Drawing.Color.LightGray;
            this.tpConnexion.Controls.Add(this.lblInfoMdp);
            this.tpConnexion.Controls.Add(this.lblInfosLogin);
            this.tpConnexion.Controls.Add(this.flpIdentification);
            this.tpConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpConnexion.Location = new System.Drawing.Point(4, 33);
            this.tpConnexion.Name = "tpConnexion";
            this.tpConnexion.Padding = new System.Windows.Forms.Padding(3);
            this.tpConnexion.Size = new System.Drawing.Size(1290, 696);
            this.tpConnexion.TabIndex = 6;
            this.tpConnexion.Text = "Connexion";
            // 
            // lblInfoMdp
            // 
            this.lblInfoMdp.AutoSize = true;
            this.lblInfoMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoMdp.Location = new System.Drawing.Point(386, 90);
            this.lblInfoMdp.Name = "lblInfoMdp";
            this.lblInfoMdp.Size = new System.Drawing.Size(872, 18);
            this.lblInfoMdp.TabIndex = 4;
            this.lblInfoMdp.Text = "Rappel : 12 caratères minimum, dont 1 majuscule minimum, 1 minuscule minimum, 1 c" +
    "hiffre minimum, 1 caractère spécial minimum";
            // 
            // lblInfosLogin
            // 
            this.lblInfosLogin.AutoSize = true;
            this.lblInfosLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfosLogin.Location = new System.Drawing.Point(386, 35);
            this.lblInfosLogin.Name = "lblInfosLogin";
            this.lblInfosLogin.Size = new System.Drawing.Size(846, 18);
            this.lblInfosLogin.TabIndex = 3;
            this.lblInfosLogin.Text = "Le login vous a été fourni lors de votre inscription. : votre nom  +  les 4 premi" +
    "ères lettres de votre prénom  +  nombre à 4 chiffres";
            // 
            // flpIdentification
            // 
            this.flpIdentification.AutoScroll = true;
            this.flpIdentification.AutoSize = true;
            this.flpIdentification.BackColor = System.Drawing.Color.DarkGray;
            this.flpIdentification.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpIdentification.Controls.Add(this.lblLogin);
            this.flpIdentification.Controls.Add(this.txtbLogin);
            this.flpIdentification.Controls.Add(this.lblMdp);
            this.flpIdentification.Controls.Add(this.txtbMdp);
            this.flpIdentification.Controls.Add(this.btnConnexion);
            this.flpIdentification.Controls.Add(this.monthCalendar1);
            this.flpIdentification.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpIdentification.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpIdentification.Location = new System.Drawing.Point(3, 3);
            this.flpIdentification.Name = "flpIdentification";
            this.flpIdentification.Size = new System.Drawing.Size(377, 690);
            this.flpIdentification.TabIndex = 1;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(3, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(56, 20);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login :";
            // 
            // txtbLogin
            // 
            this.txtbLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbLogin.Location = new System.Drawing.Point(3, 23);
            this.txtbLogin.Name = "txtbLogin";
            this.txtbLogin.Size = new System.Drawing.Size(367, 29);
            this.txtbLogin.TabIndex = 0;
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdp.Location = new System.Drawing.Point(3, 55);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(114, 20);
            this.lblMdp.TabIndex = 3;
            this.lblMdp.Text = "Mot de Passe :";
            // 
            // txtbMdp
            // 
            this.txtbMdp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbMdp.Location = new System.Drawing.Point(3, 78);
            this.txtbMdp.Name = "txtbMdp";
            this.txtbMdp.PasswordChar = '*';
            this.txtbMdp.Size = new System.Drawing.Size(367, 29);
            this.txtbMdp.TabIndex = 2;
            this.txtbMdp.UseSystemPasswordChar = true;
            // 
            // btnConnexion
            // 
            this.btnConnexion.AutoSize = true;
            this.btnConnexion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.Location = new System.Drawing.Point(3, 113);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(367, 45);
            this.btnConnexion.TabIndex = 4;
            this.btnConnexion.Text = "GO !";
            this.btnConnexion.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthCalendar1.Location = new System.Drawing.Point(9, 170);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // tpInscription
            // 
            this.tpInscription.AutoScroll = true;
            this.tpInscription.BackColor = System.Drawing.Color.LightGray;
            this.tpInscription.Controls.Add(this.lblInfoNouveauPasse);
            this.tpInscription.Controls.Add(this.lblInfoPasseInscription);
            this.tpInscription.Controls.Add(this.flpInscription);
            this.tpInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpInscription.Location = new System.Drawing.Point(4, 33);
            this.tpInscription.Name = "tpInscription";
            this.tpInscription.Padding = new System.Windows.Forms.Padding(3);
            this.tpInscription.Size = new System.Drawing.Size(1290, 696);
            this.tpInscription.TabIndex = 7;
            this.tpInscription.Text = "Inscription";
            // 
            // lblInfoNouveauPasse
            // 
            this.lblInfoNouveauPasse.AutoSize = true;
            this.lblInfoNouveauPasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoNouveauPasse.Location = new System.Drawing.Point(386, 412);
            this.lblInfoNouveauPasse.Name = "lblInfoNouveauPasse";
            this.lblInfoNouveauPasse.Size = new System.Drawing.Size(888, 18);
            this.lblInfoNouveauPasse.TabIndex = 6;
            this.lblInfoNouveauPasse.Text = "Important : 12 caratères minimum, dont 1 majuscule minimum, 1 minuscule minimum, " +
    "1 chiffre minimum, 1 caractère spécial minimum";
            // 
            // lblInfoPasseInscription
            // 
            this.lblInfoPasseInscription.AutoSize = true;
            this.lblInfoPasseInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoPasseInscription.Location = new System.Drawing.Point(386, 259);
            this.lblInfoPasseInscription.Name = "lblInfoPasseInscription";
            this.lblInfoPasseInscription.Size = new System.Drawing.Size(888, 18);
            this.lblInfoPasseInscription.TabIndex = 5;
            this.lblInfoPasseInscription.Text = "Important : 12 caratères minimum, dont 1 majuscule minimum, 1 minuscule minimum, " +
    "1 chiffre minimum, 1 caractère spécial minimum";
            // 
            // flpInscription
            // 
            this.flpInscription.BackColor = System.Drawing.Color.DarkGray;
            this.flpInscription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpInscription.Controls.Add(this.lblNom);
            this.flpInscription.Controls.Add(this.txtbNom);
            this.flpInscription.Controls.Add(this.lblPrenom);
            this.flpInscription.Controls.Add(this.txtbPrenom);
            this.flpInscription.Controls.Add(this.lblMail);
            this.flpInscription.Controls.Add(this.txtbMail);
            this.flpInscription.Controls.Add(this.lblPseuso);
            this.flpInscription.Controls.Add(this.txtbPseudo);
            this.flpInscription.Controls.Add(this.lblInscriptionPasse);
            this.flpInscription.Controls.Add(this.txtbInscriptionPasse);
            this.flpInscription.Controls.Add(this.btnValidInscription);
            this.flpInscription.Controls.Add(this.btnChangePass);
            this.flpInscription.Controls.Add(this.label1);
            this.flpInscription.Controls.Add(this.txtbNouveauPasse);
            this.flpInscription.Controls.Add(this.lblConfirmPass);
            this.flpInscription.Controls.Add(this.txtbConfirmNouveauPasse);
            this.flpInscription.Controls.Add(this.btValidNouveauPasse);
            this.flpInscription.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpInscription.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpInscription.Location = new System.Drawing.Point(3, 3);
            this.flpInscription.Name = "flpInscription";
            this.flpInscription.Size = new System.Drawing.Size(377, 690);
            this.flpInscription.TabIndex = 0;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(3, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(192, 20);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Veuillez entrer votre nom :";
            // 
            // txtbNom
            // 
            this.txtbNom.Location = new System.Drawing.Point(3, 23);
            this.txtbNom.Name = "txtbNom";
            this.txtbNom.Size = new System.Drawing.Size(361, 29);
            this.txtbNom.TabIndex = 1;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(3, 55);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(215, 20);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Veuillez entrer votre prénom :";
            // 
            // txtbPrenom
            // 
            this.txtbPrenom.Location = new System.Drawing.Point(3, 78);
            this.txtbPrenom.Name = "txtbPrenom";
            this.txtbPrenom.Size = new System.Drawing.Size(361, 29);
            this.txtbPrenom.TabIndex = 3;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(3, 110);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(250, 20);
            this.lblMail.TabIndex = 4;
            this.lblMail.Text = "Veuillez entrer votre adresse mail :";
            // 
            // txtbMail
            // 
            this.txtbMail.Location = new System.Drawing.Point(3, 133);
            this.txtbMail.Name = "txtbMail";
            this.txtbMail.Size = new System.Drawing.Size(361, 29);
            this.txtbMail.TabIndex = 5;
            // 
            // lblPseuso
            // 
            this.lblPseuso.AutoSize = true;
            this.lblPseuso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPseuso.Location = new System.Drawing.Point(3, 165);
            this.lblPseuso.Name = "lblPseuso";
            this.lblPseuso.Size = new System.Drawing.Size(214, 20);
            this.lblPseuso.TabIndex = 6;
            this.lblPseuso.Text = "Veuillez entrer votre pseudo :";
            // 
            // txtbPseudo
            // 
            this.txtbPseudo.Location = new System.Drawing.Point(3, 188);
            this.txtbPseudo.Name = "txtbPseudo";
            this.txtbPseudo.Size = new System.Drawing.Size(361, 29);
            this.txtbPseudo.TabIndex = 7;
            // 
            // lblInscriptionPasse
            // 
            this.lblInscriptionPasse.AutoSize = true;
            this.lblInscriptionPasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscriptionPasse.Location = new System.Drawing.Point(3, 220);
            this.lblInscriptionPasse.Name = "lblInscriptionPasse";
            this.lblInscriptionPasse.Size = new System.Drawing.Size(257, 20);
            this.lblInscriptionPasse.TabIndex = 8;
            this.lblInscriptionPasse.Text = "Veuillez entrer votre mot de passe :";
            // 
            // txtbInscriptionPasse
            // 
            this.txtbInscriptionPasse.Location = new System.Drawing.Point(3, 243);
            this.txtbInscriptionPasse.Name = "txtbInscriptionPasse";
            this.txtbInscriptionPasse.Size = new System.Drawing.Size(361, 29);
            this.txtbInscriptionPasse.TabIndex = 9;
            // 
            // btnValidInscription
            // 
            this.btnValidInscription.AutoSize = true;
            this.btnValidInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidInscription.Location = new System.Drawing.Point(3, 278);
            this.btnValidInscription.Name = "btnValidInscription";
            this.btnValidInscription.Size = new System.Drawing.Size(361, 45);
            this.btnValidInscription.TabIndex = 10;
            this.btnValidInscription.Text = "Cliquez ici pour valider";
            this.btnValidInscription.UseVisualStyleBackColor = true;
            // 
            // btnChangePass
            // 
            this.btnChangePass.AutoSize = true;
            this.btnChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.Location = new System.Drawing.Point(3, 329);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(361, 45);
            this.btnChangePass.TabIndex = 11;
            this.btnChangePass.Text = "Cliquez ici pour changer de mot de passe";
            this.btnChangePass.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Veuillez entrer le nouveau mot de passe :";
            // 
            // txtbNouveauPasse
            // 
            this.txtbNouveauPasse.Location = new System.Drawing.Point(3, 400);
            this.txtbNouveauPasse.Name = "txtbNouveauPasse";
            this.txtbNouveauPasse.Size = new System.Drawing.Size(361, 29);
            this.txtbNouveauPasse.TabIndex = 13;
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPass.Location = new System.Drawing.Point(3, 432);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(323, 20);
            this.lblConfirmPass.TabIndex = 14;
            this.lblConfirmPass.Text = "Veuillez confirmer le nouveau mot de passe :";
            // 
            // txtbConfirmNouveauPasse
            // 
            this.txtbConfirmNouveauPasse.Location = new System.Drawing.Point(3, 455);
            this.txtbConfirmNouveauPasse.Name = "txtbConfirmNouveauPasse";
            this.txtbConfirmNouveauPasse.Size = new System.Drawing.Size(361, 29);
            this.txtbConfirmNouveauPasse.TabIndex = 15;
            // 
            // btValidNouveauPasse
            // 
            this.btValidNouveauPasse.AutoSize = true;
            this.btValidNouveauPasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValidNouveauPasse.Location = new System.Drawing.Point(3, 490);
            this.btValidNouveauPasse.Name = "btValidNouveauPasse";
            this.btValidNouveauPasse.Size = new System.Drawing.Size(361, 45);
            this.btValidNouveauPasse.TabIndex = 16;
            this.btValidNouveauPasse.Text = "Cliquez ici pour valider le nouveau mot de passe";
            this.btValidNouveauPasse.UseVisualStyleBackColor = true;
            // 
            // btnPosterReponse
            // 
            this.btnPosterReponse.AutoSize = true;
            this.btnPosterReponse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPosterReponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosterReponse.Location = new System.Drawing.Point(631, 242);
            this.btnPosterReponse.Name = "btnPosterReponse";
            this.btnPosterReponse.Size = new System.Drawing.Size(650, 37);
            this.btnPosterReponse.TabIndex = 11;
            this.btnPosterReponse.Text = "Cliquez ici pour ENVOYER votre réponse ";
            this.btnPosterReponse.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(631, 205);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(650, 37);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Rafraîchir les réponses";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // AccueilForum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1310, 782);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AccueilForum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil Forum";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.gbxMain.ResumeLayout(false);
            this.tbcMain.ResumeLayout(false);
            this.tpAccesRubriquesMessages.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbxRubriquesMessagesSup.ResumeLayout(false);
            this.gbxRubriquesMessagesSup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewsletterSup)).EndInit();
            this.gbxRubriquesMessagesInf.ResumeLayout(false);
            this.gbxRubriquesMessagesInf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewsletterInf)).EndInit();
            this.tpConnexion.ResumeLayout(false);
            this.tpConnexion.PerformLayout();
            this.flpIdentification.ResumeLayout(false);
            this.flpIdentification.PerformLayout();
            this.tpInscription.ResumeLayout(false);
            this.tpInscription.PerformLayout();
            this.flpInscription.ResumeLayout(false);
            this.flpInscription.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox gbxMain;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tpAccesRubriquesMessages;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbxRubriquesMessagesSup;
        private System.Windows.Forms.DataGridView dgvNewsletterSup;
        private System.Windows.Forms.GroupBox gbxRubriquesMessagesInf;
        private System.Windows.Forms.DataGridView dgvNewsletterInf;
        private System.Windows.Forms.TabPage tpConnexion;
        private System.Windows.Forms.Label lblInfoMdp;
        private System.Windows.Forms.Label lblInfosLogin;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.FlowLayoutPanel flpIdentification;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtbLogin;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox txtbMdp;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.TabPage tpInscription;
        private System.Windows.Forms.Label lblTexteSujet;
        private System.Windows.Forms.TextBox txtbTitreSujet;
        private System.Windows.Forms.Label lblTitreSujetRubriquesMessages;
        private System.Windows.Forms.TextBox txtbTexteSujet;
        private System.Windows.Forms.Button btnAjoutSujet;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.TextBox txtbTexteReponse;
        private System.Windows.Forms.Label lblTexteReponse;
        private System.Windows.Forms.Label lblListeRubriques;
        private System.Windows.Forms.ComboBox cbxListeRubriques;
        private System.Windows.Forms.Button btnModifierSujet;
        private System.Windows.Forms.Button btnSupprimerSujet;
        private System.Windows.Forms.Button btnSupprimerReponse;
        private System.Windows.Forms.Label lblInfoPasseInscription;
        private System.Windows.Forms.FlowLayoutPanel flpInscription;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtbNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtbPrenom;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtbMail;
        private System.Windows.Forms.Label lblPseuso;
        private System.Windows.Forms.TextBox txtbPseudo;
        private System.Windows.Forms.Label lblInscriptionPasse;
        private System.Windows.Forms.TextBox txtbInscriptionPasse;
        private System.Windows.Forms.Button btnValidInscription;
        private System.Windows.Forms.Label lblInfoNouveauPasse;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbNouveauPasse;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.TextBox txtbConfirmNouveauPasse;
        private System.Windows.Forms.Button btValidNouveauPasse;
        private System.Windows.Forms.Button btnPosterReponse;
        private System.Windows.Forms.Button btnRefresh;
    }
}

