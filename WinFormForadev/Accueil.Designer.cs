namespace WinFormForadev
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
            this.tpConnexion = new System.Windows.Forms.TabPage();
            this.tpInscription = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbxRubriquesMessagesSup = new System.Windows.Forms.GroupBox();
            this.gbxRubriquesMessagesInf = new System.Windows.Forms.GroupBox();
            this.dgvNewsletterSup = new System.Windows.Forms.DataGridView();
            this.dgvNewsletterInf = new System.Windows.Forms.DataGridView();
            this.txtbLogin = new System.Windows.Forms.TextBox();
            this.flpIdentification = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtbMdp = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblInfosLogin = new System.Windows.Forms.Label();
            this.lblInfoMdp = new System.Windows.Forms.Label();
            this.btnAjoutSujet = new System.Windows.Forms.Button();
            this.txtbTexteSujet = new System.Windows.Forms.TextBox();
            this.lblTitreSujetRubriquesMessages = new System.Windows.Forms.Label();
            this.txtbTitreSujet = new System.Windows.Forms.TextBox();
            this.lblTexteSujet = new System.Windows.Forms.Label();
            this.lblTitreSujet = new System.Windows.Forms.Label();
            this.txtbSujetReponse = new System.Windows.Forms.TextBox();
            this.lblTexteReponse = new System.Windows.Forms.Label();
            this.txtbTexteReponse = new System.Windows.Forms.TextBox();
            this.btnEnvoyerReponse = new System.Windows.Forms.Button();
            this.cbxListeRubriques = new System.Windows.Forms.ComboBox();
            this.lblListeRubriques = new System.Windows.Forms.Label();
            this.btnSupprimerSujet = new System.Windows.Forms.Button();
            this.btnModifierSujet = new System.Windows.Forms.Button();
            this.btnSupprimerReponse = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.gbxMain.SuspendLayout();
            this.tbcMain.SuspendLayout();
            this.tpAccesRubriquesMessages.SuspendLayout();
            this.tpConnexion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbxRubriquesMessagesSup.SuspendLayout();
            this.gbxRubriquesMessagesInf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewsletterSup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewsletterInf)).BeginInit();
            this.flpIdentification.SuspendLayout();
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
            this.tlpMain.Size = new System.Drawing.Size(1294, 803);
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
            this.panelMain.Size = new System.Drawing.Size(1288, 797);
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
            this.gbxMain.Size = new System.Drawing.Size(1288, 797);
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
            this.tbcMain.Size = new System.Drawing.Size(1282, 754);
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
            this.tpAccesRubriquesMessages.Size = new System.Drawing.Size(1274, 717);
            this.tpAccesRubriquesMessages.TabIndex = 0;
            this.tpAccesRubriquesMessages.Text = "Rubriques et messages";
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
            this.tpConnexion.Size = new System.Drawing.Size(1281, 676);
            this.tpConnexion.TabIndex = 6;
            this.tpConnexion.Text = "Connexion";
            // 
            // tpInscription
            // 
            this.tpInscription.AutoScroll = true;
            this.tpInscription.BackColor = System.Drawing.Color.LightGray;
            this.tpInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpInscription.Location = new System.Drawing.Point(4, 33);
            this.tpInscription.Name = "tpInscription";
            this.tpInscription.Padding = new System.Windows.Forms.Padding(3);
            this.tpInscription.Size = new System.Drawing.Size(1281, 676);
            this.tpInscription.TabIndex = 7;
            this.tpInscription.Text = "Inscription";
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
            this.splitContainer1.Size = new System.Drawing.Size(1268, 711);
            this.splitContainer1.SplitterDistance = 391;
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
            this.gbxRubriquesMessagesSup.Size = new System.Drawing.Size(1268, 391);
            this.gbxRubriquesMessagesSup.TabIndex = 0;
            this.gbxRubriquesMessagesSup.TabStop = false;
            this.gbxRubriquesMessagesSup.Text = "Derniers sujets postés";
           
            // 
            // gbxRubriquesMessagesInf
            // 
            this.gbxRubriquesMessagesInf.AutoSize = true;
            this.gbxRubriquesMessagesInf.Controls.Add(this.btnSupprimerReponse);
            this.gbxRubriquesMessagesInf.Controls.Add(this.btnEnvoyerReponse);
            this.gbxRubriquesMessagesInf.Controls.Add(this.txtbTexteReponse);
            this.gbxRubriquesMessagesInf.Controls.Add(this.lblTexteReponse);
            this.gbxRubriquesMessagesInf.Controls.Add(this.txtbSujetReponse);
            this.gbxRubriquesMessagesInf.Controls.Add(this.lblTitreSujet);
            this.gbxRubriquesMessagesInf.Controls.Add(this.dgvNewsletterInf);
            this.gbxRubriquesMessagesInf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxRubriquesMessagesInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRubriquesMessagesInf.Location = new System.Drawing.Point(0, 0);
            this.gbxRubriquesMessagesInf.Name = "gbxRubriquesMessagesInf";
            this.gbxRubriquesMessagesInf.Size = new System.Drawing.Size(1268, 316);
            this.gbxRubriquesMessagesInf.TabIndex = 0;
            this.gbxRubriquesMessagesInf.TabStop = false;
            this.gbxRubriquesMessagesInf.Text = "Réponses correspondantes au sujet sélectionné";
            // 
            // dgvNewsletterSup
            // 
            this.dgvNewsletterSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewsletterSup.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvNewsletterSup.Location = new System.Drawing.Point(3, 22);
            this.dgvNewsletterSup.Name = "dgvNewsletterSup";
            this.dgvNewsletterSup.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvNewsletterSup.Size = new System.Drawing.Size(628, 366);
            this.dgvNewsletterSup.TabIndex = 0;
            // 
            // dgvNewsletterInf
            // 
            this.dgvNewsletterInf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewsletterInf.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvNewsletterInf.Location = new System.Drawing.Point(3, 22);
            this.dgvNewsletterInf.Name = "dgvNewsletterInf";
            this.dgvNewsletterInf.Size = new System.Drawing.Size(628, 291);
            this.dgvNewsletterInf.TabIndex = 0;
            // 
            // txtbLogin
            // 
            this.txtbLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbLogin.Location = new System.Drawing.Point(3, 23);
            this.txtbLogin.Name = "txtbLogin";
            this.txtbLogin.Size = new System.Drawing.Size(367, 29);
            this.txtbLogin.TabIndex = 0;
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
            this.flpIdentification.Size = new System.Drawing.Size(377, 670);
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
            // txtbMdp
            // 
            this.txtbMdp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbMdp.Location = new System.Drawing.Point(3, 78);
            this.txtbMdp.Name = "txtbMdp";
            this.txtbMdp.Size = new System.Drawing.Size(367, 29);
            this.txtbMdp.TabIndex = 2;
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
            // btnConnexion
            // 
            this.btnConnexion.AutoSize = true;
            this.btnConnexion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.Location = new System.Drawing.Point(3, 113);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(367, 34);
            this.btnConnexion.TabIndex = 4;
            this.btnConnexion.Text = "GO !";
            this.btnConnexion.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthCalendar1.Location = new System.Drawing.Point(9, 159);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // lblInfosLogin
            // 
            this.lblInfosLogin.AutoSize = true;
            this.lblInfosLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfosLogin.Location = new System.Drawing.Point(386, 43);
            this.lblInfosLogin.Name = "lblInfosLogin";
            this.lblInfosLogin.Size = new System.Drawing.Size(846, 18);
            this.lblInfosLogin.TabIndex = 3;
            this.lblInfosLogin.Text = "Le login vous a été fourni lors de votre inscription. : votre nom  +  les 4 premi" +
    "ères lettres de votre prénom  +  nombre à 4 chiffres";
            // 
            // lblInfoMdp
            // 
            this.lblInfoMdp.AutoSize = true;
            this.lblInfoMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoMdp.Location = new System.Drawing.Point(386, 98);
            this.lblInfoMdp.Name = "lblInfoMdp";
            this.lblInfoMdp.Size = new System.Drawing.Size(872, 18);
            this.lblInfoMdp.TabIndex = 4;
            this.lblInfoMdp.Text = "Rappel : 12 caratères minimum, dont 1 majuscule minimum, 1 minuscule minimum, 1 c" +
    "hiffre minimum, 1 caractère spécial minimum";
            // 
            // btnAjoutSujet
            // 
            this.btnAjoutSujet.AutoSize = true;
            this.btnAjoutSujet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAjoutSujet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutSujet.Location = new System.Drawing.Point(631, 351);
            this.btnAjoutSujet.Name = "btnAjoutSujet";
            this.btnAjoutSujet.Size = new System.Drawing.Size(634, 37);
            this.btnAjoutSujet.TabIndex = 1;
            this.btnAjoutSujet.Text = "Cliquez ici pour AJOUTER votre sujet";
            this.btnAjoutSujet.UseVisualStyleBackColor = true;
            // 
            // txtbTexteSujet
            // 
            this.txtbTexteSujet.Location = new System.Drawing.Point(631, 210);
            this.txtbTexteSujet.Name = "txtbTexteSujet";
            this.txtbTexteSujet.Size = new System.Drawing.Size(641, 26);
            this.txtbTexteSujet.TabIndex = 2;
            // 
            // lblTitreSujetRubriquesMessages
            // 
            this.lblTitreSujetRubriquesMessages.AutoEllipsis = true;
            this.lblTitreSujetRubriquesMessages.AutoSize = true;
            this.lblTitreSujetRubriquesMessages.Location = new System.Drawing.Point(631, 123);
            this.lblTitreSujetRubriquesMessages.Name = "lblTitreSujetRubriquesMessages";
            this.lblTitreSujetRubriquesMessages.Size = new System.Drawing.Size(274, 20);
            this.lblTitreSujetRubriquesMessages.TabIndex = 3;
            this.lblTitreSujetRubriquesMessages.Text = "Entrez ci-dessous votre titre de sujet :";
            // 
            // txtbTitreSujet
            // 
            this.txtbTitreSujet.Location = new System.Drawing.Point(631, 146);
            this.txtbTitreSujet.Name = "txtbTitreSujet";
            this.txtbTitreSujet.Size = new System.Drawing.Size(641, 26);
            this.txtbTitreSujet.TabIndex = 5;
            // 
            // lblTexteSujet
            // 
            this.lblTexteSujet.AutoSize = true;
            this.lblTexteSujet.Location = new System.Drawing.Point(631, 187);
            this.lblTexteSujet.Name = "lblTexteSujet";
            this.lblTexteSujet.Size = new System.Drawing.Size(222, 20);
            this.lblTexteSujet.TabIndex = 6;
            this.lblTexteSujet.Text = "Entrez ci-dessous votre texte :";
            // 
            // lblTitreSujet
            // 
            this.lblTitreSujet.AutoEllipsis = true;
            this.lblTitreSujet.AutoSize = true;
            this.lblTitreSujet.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitreSujet.Location = new System.Drawing.Point(631, 22);
            this.lblTitreSujet.Name = "lblTitreSujet";
            this.lblTitreSujet.Size = new System.Drawing.Size(420, 20);
            this.lblTitreSujet.TabIndex = 4;
            this.lblTitreSujet.Text = "Entrez ci-dessous le titre du sujet auquel voulez répondre :";
            // 
            // txtbSujetReponse
            // 
            this.txtbSujetReponse.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtbSujetReponse.Location = new System.Drawing.Point(631, 42);
            this.txtbSujetReponse.Name = "txtbSujetReponse";
            this.txtbSujetReponse.Size = new System.Drawing.Size(634, 26);
            this.txtbSujetReponse.TabIndex = 6;
            // 
            // lblTexteReponse
            // 
            this.lblTexteReponse.AutoSize = true;
            this.lblTexteReponse.Location = new System.Drawing.Point(631, 84);
            this.lblTexteReponse.Name = "lblTexteReponse";
            this.lblTexteReponse.Size = new System.Drawing.Size(322, 20);
            this.lblTexteReponse.TabIndex = 7;
            this.lblTexteReponse.Text = "Entrez ci-dessous le texte de votre réponse :";
            // 
            // txtbTexteReponse
            // 
            this.txtbTexteReponse.Location = new System.Drawing.Point(631, 107);
            this.txtbTexteReponse.Name = "txtbTexteReponse";
            this.txtbTexteReponse.Size = new System.Drawing.Size(641, 26);
            this.txtbTexteReponse.TabIndex = 8;
          
            // 
            // btnEnvoyerReponse
            // 
            this.btnEnvoyerReponse.AutoSize = true;
            this.btnEnvoyerReponse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEnvoyerReponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvoyerReponse.Location = new System.Drawing.Point(631, 276);
            this.btnEnvoyerReponse.Name = "btnEnvoyerReponse";
            this.btnEnvoyerReponse.Size = new System.Drawing.Size(634, 37);
            this.btnEnvoyerReponse.TabIndex = 9;
            this.btnEnvoyerReponse.Text = "Cliquez ici pour ENVOYER votre réponse ";
            this.btnEnvoyerReponse.UseVisualStyleBackColor = true;
            // 
            // cbxListeRubriques
            // 
            this.cbxListeRubriques.FormattingEnabled = true;
            this.cbxListeRubriques.Location = new System.Drawing.Point(631, 45);
            this.cbxListeRubriques.Name = "cbxListeRubriques";
            this.cbxListeRubriques.Size = new System.Drawing.Size(641, 28);
            this.cbxListeRubriques.TabIndex = 7;
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
            // btnSupprimerSujet
            // 
            this.btnSupprimerSujet.AutoSize = true;
            this.btnSupprimerSujet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSupprimerSujet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerSujet.Location = new System.Drawing.Point(631, 314);
            this.btnSupprimerSujet.Name = "btnSupprimerSujet";
            this.btnSupprimerSujet.Size = new System.Drawing.Size(634, 37);
            this.btnSupprimerSujet.TabIndex = 9;
            this.btnSupprimerSujet.Text = "Cliquez ici pour SUPPRIMER le sujet sélectionné";
            this.btnSupprimerSujet.UseVisualStyleBackColor = true;
            // 
            // btnModifierSujet
            // 
            this.btnModifierSujet.AutoSize = true;
            this.btnModifierSujet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnModifierSujet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierSujet.Location = new System.Drawing.Point(631, 277);
            this.btnModifierSujet.Name = "btnModifierSujet";
            this.btnModifierSujet.Size = new System.Drawing.Size(634, 37);
            this.btnModifierSujet.TabIndex = 10;
            this.btnModifierSujet.Text = "Cliquez ici pour MODIFIER le sujet selectionné";
            this.btnModifierSujet.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerReponse
            // 
            this.btnSupprimerReponse.AutoSize = true;
            this.btnSupprimerReponse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSupprimerReponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerReponse.Location = new System.Drawing.Point(631, 239);
            this.btnSupprimerReponse.Name = "btnSupprimerReponse";
            this.btnSupprimerReponse.Size = new System.Drawing.Size(634, 37);
            this.btnSupprimerReponse.TabIndex = 10;
            this.btnSupprimerReponse.Text = "Cliquez ici pour SUPPRIMER la réponse sélectionnée";
            this.btnSupprimerReponse.UseVisualStyleBackColor = true;
            // 
            // AccueilForum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1294, 803);
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
            this.tpConnexion.ResumeLayout(false);
            this.tpConnexion.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbxRubriquesMessagesSup.ResumeLayout(false);
            this.gbxRubriquesMessagesSup.PerformLayout();
            this.gbxRubriquesMessagesInf.ResumeLayout(false);
            this.gbxRubriquesMessagesInf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewsletterSup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewsletterInf)).EndInit();
            this.flpIdentification.ResumeLayout(false);
            this.flpIdentification.PerformLayout();
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
        private System.Windows.Forms.Button btnEnvoyerReponse;
        private System.Windows.Forms.TextBox txtbTexteReponse;
        private System.Windows.Forms.Label lblTexteReponse;
        private System.Windows.Forms.TextBox txtbSujetReponse;
        private System.Windows.Forms.Label lblTitreSujet;
        private System.Windows.Forms.Label lblListeRubriques;
        private System.Windows.Forms.ComboBox cbxListeRubriques;
        private System.Windows.Forms.Button btnModifierSujet;
        private System.Windows.Forms.Button btnSupprimerSujet;
        private System.Windows.Forms.Button btnSupprimerReponse;
    }
}

