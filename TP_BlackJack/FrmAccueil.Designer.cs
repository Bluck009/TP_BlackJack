
namespace TP_BlackJack
{
    partial class FrmAccueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblEmail = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lblNom = new System.Windows.Forms.Label();
            txtNom = new System.Windows.Forms.TextBox();
            lblDateNaissance = new System.Windows.Forms.Label();
            txtDateNaissance = new System.Windows.Forms.TextBox();
            btnAjouter = new System.Windows.Forms.Button();
            lblNombreBots = new System.Windows.Forms.Label();
            cmbNombreBots = new System.Windows.Forms.ComboBox();
            btnCommencer = new System.Windows.Forms.Button();
            lblTitreInstruction = new System.Windows.Forms.Label();
            lblInstructions = new System.Windows.Forms.Label();
            lblLesJoueurs = new System.Windows.Forms.Label();
            lblListeJoueurs = new System.Windows.Forms.Label();
            lblAjoutJoueur = new System.Windows.Forms.Label();
            txtListeJoueurs = new System.Windows.Forms.TextBox();
            txtErrorMessage = new System.Windows.Forms.TextBox();
            txtBotErrMsg = new System.Windows.Forms.TextBox();
            txtMsgErrAjouterJoueur = new System.Windows.Forms.TextBox();
            txtListeJoueur = new System.Windows.Forms.RichTextBox();
            txtJoueruChoisi = new System.Windows.Forms.TextBox();
            txtMsgErrChoisirJoueur = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;

            lblEmail.Location = new System.Drawing.Point(395, 255);

            lblEmail.Location = new System.Drawing.Point(396, 255);

            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(53, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email :";

            //lblEmail.Click += lblEmail_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(454, 255);

            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(455, 255);

            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(186, 27);
            txtEmail.TabIndex = 1;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new System.Drawing.Point(396, 298);
            lblNom.Name = "lblNom";
            lblNom.Size = new System.Drawing.Size(45, 20);
            lblNom.TabIndex = 2;
            lblNom.Text = "Nom:";
            // 
            // txtNom
            // 
            txtNom.Location = new System.Drawing.Point(455, 298);
            txtNom.Name = "txtNom";
            txtNom.Size = new System.Drawing.Size(186, 27);
            txtNom.TabIndex = 3;

            //txtNom.TextChanged += txtNom_TextChanged;

            // 
            // lblDateNaissance
            // 
            lblDateNaissance.AutoSize = true;
            lblDateNaissance.Location = new System.Drawing.Point(396, 340);
            lblDateNaissance.Name = "lblDateNaissance";
            lblDateNaissance.Size = new System.Drawing.Size(111, 20);
            lblDateNaissance.TabIndex = 4;
            lblDateNaissance.Text = "Date naissance:";
            // 
            // txtDateNaissance
            // 
            txtDateNaissance.Location = new System.Drawing.Point(513, 340);
            txtDateNaissance.Name = "txtDateNaissance";
            txtDateNaissance.Size = new System.Drawing.Size(128, 27);
            txtDateNaissance.TabIndex = 5;

            //txtDateNaissance.TextChanged += txtDateNaissance_TextChanged;

            // 
            // btnAjouter
            // 
            btnAjouter.Location = new System.Drawing.Point(677, 321);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new System.Drawing.Size(94, 29);
            btnAjouter.TabIndex = 6;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // lblNombreBots
            // 
            lblNombreBots.AutoSize = true;
            lblNombreBots.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNombreBots.Location = new System.Drawing.Point(395, 428);
            lblNombreBots.Name = "lblNombreBots";
            lblNombreBots.Size = new System.Drawing.Size(179, 28);
            lblNombreBots.TabIndex = 7;
            lblNombreBots.Text = "Nombre de bot(s)";
            // 
            // cmbNombreBots
            // 
            cmbNombreBots.BackColor = System.Drawing.SystemColors.ScrollBar;
            cmbNombreBots.FormattingEnabled = true;
            cmbNombreBots.Location = new System.Drawing.Point(580, 428);
            cmbNombreBots.Name = "cmbNombreBots";
            cmbNombreBots.Size = new System.Drawing.Size(151, 28);
            cmbNombreBots.TabIndex = 8;
            // 
            // btnCommencer
            // 
            btnCommencer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCommencer.Location = new System.Drawing.Point(396, 507);
            btnCommencer.Name = "btnCommencer";
            btnCommencer.Size = new System.Drawing.Size(339, 56);
            btnCommencer.TabIndex = 9;
            btnCommencer.Text = "Commencer la partie";
            btnCommencer.UseVisualStyleBackColor = true;
            btnCommencer.Click += btnCommencer_Click;
            // 
            // lblTitreInstruction
            // 
            lblTitreInstruction.AutoSize = true;
            lblTitreInstruction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitreInstruction.Location = new System.Drawing.Point(247, 9);
            lblTitreInstruction.Name = "lblTitreInstruction";
            lblTitreInstruction.Size = new System.Drawing.Size(300, 28);
            lblTitreInstruction.TabIndex = 10;
            lblTitreInstruction.Text = "Jeu de Blackjack - Instructions";
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Location = new System.Drawing.Point(56, 56);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new System.Drawing.Size(540, 60);
            lblInstructions.TabIndex = 11;
            lblInstructions.Text = "1- Une partie peut contenir 1 à 4 joueurs (Création possible de joueur au besoin)\r\n2- Sélectionnez votre joueur et inscrire le nombre de bot(s)\r\n3- Débutez la partie";
            // 
            // lblLesJoueurs
            // 
            lblLesJoueurs.AutoSize = true;
            lblLesJoueurs.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            lblLesJoueurs.Location = new System.Drawing.Point(301, 116);
            lblLesJoueurs.Name = "lblLesJoueurs";
            lblLesJoueurs.Size = new System.Drawing.Size(174, 41);
            lblLesJoueurs.TabIndex = 12;
            lblLesJoueurs.Text = "Les joueurs";
            // 
            // lblListeJoueurs
            // 
            lblListeJoueurs.AutoSize = true;
            lblListeJoueurs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblListeJoueurs.Location = new System.Drawing.Point(102, 213);
            lblListeJoueurs.Name = "lblListeJoueurs";
            lblListeJoueurs.Size = new System.Drawing.Size(130, 28);
            lblListeJoueurs.TabIndex = 13;
            lblListeJoueurs.Text = "Votre joueur";
            // 
            // lblAjoutJoueur
            // 
            lblAjoutJoueur.AutoSize = true;
            lblAjoutJoueur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblAjoutJoueur.Location = new System.Drawing.Point(396, 213);
            lblAjoutJoueur.Name = "lblAjoutJoueur";
            lblAjoutJoueur.Size = new System.Drawing.Size(267, 28);
            lblAjoutJoueur.TabIndex = 14;
            lblAjoutJoueur.Text = "Ajouter un nouveau joueur";
            // 

            // txtListeJoueurs
            // 
            txtListeJoueurs.Location = new System.Drawing.Point(56, 255);
            txtListeJoueurs.Multiline = true;
            txtListeJoueurs.Name = "txtListeJoueurs";
            txtListeJoueurs.Size = new System.Drawing.Size(280, 174);
            txtListeJoueurs.TabIndex = 15;
            // 

            // txtErrorMessage
            // 
            //txtErrorMessage.BackColor = System.Drawing.SystemColors.Control;
            //txtErrorMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            //txtErrorMessage.ForeColor = System.Drawing.Color.DarkRed;
            //txtErrorMessage.ImeMode = System.Windows.Forms.ImeMode.Off;
            //txtErrorMessage.Location = new System.Drawing.Point(396, 384);
            //txtErrorMessage.Multiline = true;
            //txtErrorMessage.Name = "txtErrorMessage";
            //txtErrorMessage.ReadOnly = true;
            //txtErrorMessage.Size = new System.Drawing.Size(335, 27);
            //txtErrorMessage.TabIndex = 16;
            // 

            // txtBotErrMsg
            // 
            //txtBotErrMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            //txtBotErrMsg.ForeColor = System.Drawing.Color.Navy;
            //txtBotErrMsg.Location = new System.Drawing.Point(400, 474);
            //txtBotErrMsg.Multiline = true;
            //txtBotErrMsg.Name = "txtBotErrMsg";
            //txtBotErrMsg.ReadOnly = true;
            //txtBotErrMsg.Size = new System.Drawing.Size(335, 27);
            //txtBotErrMsg.TabIndex = 17;
            // 

            // txtMsgErrAjouterJoueur
            // 
            //txtMsgErrAjouterJoueur.BackColor = System.Drawing.SystemColors.Control;
            //txtMsgErrAjouterJoueur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            //txtMsgErrAjouterJoueur.ForeColor = System.Drawing.Color.DarkRed;
            //txtMsgErrAjouterJoueur.ImeMode = System.Windows.Forms.ImeMode.Off;
            //txtMsgErrAjouterJoueur.Location = new System.Drawing.Point(395, 172);
            //txtMsgErrAjouterJoueur.Multiline = true;
            //txtMsgErrAjouterJoueur.Name = "txtMsgErrAjouterJoueur";
            //txtMsgErrAjouterJoueur.ReadOnly = true;
            //txtMsgErrAjouterJoueur.Size = new System.Drawing.Size(335, 27);
            //txtMsgErrAjouterJoueur.TabIndex = 18;

            // 
            // txtListeJoueur
            // 
            txtListeJoueur.Location = new System.Drawing.Point(56, 267);
            txtListeJoueur.Name = "txtListeJoueur";
            txtListeJoueur.Size = new System.Drawing.Size(253, 189);
            txtListeJoueur.TabIndex = 19;
            txtListeJoueur.Text = "";
            //txtListeJoueur.MouseClick += txtListeJoueur_MouseClick;
            // 
            // txtJoueruChoisi
            // 
            txtJoueruChoisi.Location = new System.Drawing.Point(78, 509);
            txtJoueruChoisi.Name = "txtJoueruChoisi";
            txtJoueruChoisi.Size = new System.Drawing.Size(175, 27);
            txtJoueruChoisi.TabIndex = 20;
            // 
            // txtMsgErrChoisirJoueur
            // 
            txtMsgErrChoisirJoueur.BackColor = System.Drawing.SystemColors.Control;
            txtMsgErrChoisirJoueur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtMsgErrChoisirJoueur.ForeColor = System.Drawing.Color.DarkRed;
            txtMsgErrChoisirJoueur.ImeMode = System.Windows.Forms.ImeMode.Off;
            txtMsgErrChoisirJoueur.Location = new System.Drawing.Point(54, 183);
            txtMsgErrChoisirJoueur.Multiline = true;
            txtMsgErrChoisirJoueur.Name = "txtMsgErrChoisirJoueur";
            txtMsgErrChoisirJoueur.ReadOnly = true;
            txtMsgErrChoisirJoueur.Size = new System.Drawing.Size(255, 27);
            txtMsgErrChoisirJoueur.TabIndex = 21;
            // 
            // txtBotErrMsg
            // 
            //txtBotErrMsg.BackColor = System.Drawing.SystemColors.Control;
            //txtBotErrMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            //txtBotErrMsg.ForeColor = System.Drawing.Color.DarkRed;
            //txtBotErrMsg.ImeMode = System.Windows.Forms.ImeMode.Off;
            //txtBotErrMsg.Location = new System.Drawing.Point(396, 474);
            //txtBotErrMsg.Multiline = true;
            //txtBotErrMsg.Name = "txtBotErrMsg";
            //txtBotErrMsg.ReadOnly = true;
            //txtBotErrMsg.Size = new System.Drawing.Size(339, 27);
            //txtBotErrMsg.TabIndex = 22;

            // 
            // FrmAccueil
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 587);

            Controls.Add(txtMsgErrAjouterJoueur);
            Controls.Add(txtBotErrMsg);
            Controls.Add(txtErrorMessage);
            Controls.Add(txtListeJoueurs);

            Controls.Add(txtBotErrMsg);
            Controls.Add(txtMsgErrChoisirJoueur);
            Controls.Add(txtJoueruChoisi);
            Controls.Add(txtListeJoueur);
            Controls.Add(txtMsgErrAjouterJoueur);
            Controls.Add(txtErrorMessage);

            Controls.Add(lblAjoutJoueur);
            Controls.Add(lblListeJoueurs);
            Controls.Add(lblLesJoueurs);
            Controls.Add(lblInstructions);
            Controls.Add(lblTitreInstruction);
            Controls.Add(btnCommencer);
            Controls.Add(cmbNombreBots);
            Controls.Add(lblNombreBots);
            Controls.Add(btnAjouter);
            Controls.Add(txtDateNaissance);
            Controls.Add(lblDateNaissance);
            Controls.Add(txtNom);
            Controls.Add(lblNom);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Name = "FrmAccueil";
            Text = "FormAccueil";
            Load += FrmAccueil_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.TextBox txtDateNaissance;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblNombreBots;
        private System.Windows.Forms.ComboBox cmbNombreBots;
        private System.Windows.Forms.Button btnCommencer;
        private System.Windows.Forms.Label lblTitreInstruction;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblLesJoueurs;
        private System.Windows.Forms.Label lblListeJoueurs;
        private System.Windows.Forms.Label lblAjoutJoueur;

        private System.Windows.Forms.TextBox txtListeJoueurs;
        private System.Windows.Forms.TextBox txtErrorMessage;
        private System.Windows.Forms.TextBox txtBotErrMsg;
        private System.Windows.Forms.TextBox txtMsgErrAjouterJoueur;

        //private System.Windows.Forms.TextBox txtErrorMessage;
        //private System.Windows.Forms.TextBox txtMsgErrAjouterJoueur;
        private System.Windows.Forms.RichTextBox txtListeJoueur;
        private System.Windows.Forms.TextBox txtJoueruChoisi;
        private System.Windows.Forms.TextBox txtMsgErrChoisirJoueur;
        //private System.Windows.Forms.TextBox txtBotErrMsg;

    }
}