
namespace TP_BlackJack
{
    partial class FrmBlackjack
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnHit = new System.Windows.Forms.Button();
            lblJoueur4 = new System.Windows.Forms.Label();
            lblJoueur3 = new System.Windows.Forms.Label();
            lblJoueur2 = new System.Windows.Forms.Label();
            lblJoueur1 = new System.Windows.Forms.Label();
            lbClassement = new System.Windows.Forms.ListBox();
            lblClassement = new System.Windows.Forms.Label();
            btnDoubler = new System.Windows.Forms.Button();
            btnQuitter = new System.Windows.Forms.Button();
            btnStand = new System.Windows.Forms.Button();
            btnRecommencer = new System.Windows.Forms.Button();
            lblProchainePartie = new System.Windows.Forms.Label();
            lblCompteur = new System.Windows.Forms.Label();
            upAndDownMise = new System.Windows.Forms.NumericUpDown();
            lblChoixMise = new System.Windows.Forms.Label();
            lblActif2 = new System.Windows.Forms.Label();
            lblActif1 = new System.Windows.Forms.Label();
            lblActif3 = new System.Windows.Forms.Label();
            lblGagnantOuPerdant4 = new System.Windows.Forms.Label();
            lblGagnantOuPerdant3 = new System.Windows.Forms.Label();
            lblGagnantOuPerdant2 = new System.Windows.Forms.Label();
            lblGagnantOuPerdant1 = new System.Windows.Forms.Label();
            lblClickHere = new System.Windows.Forms.Label();
            pbBlackjack = new System.Windows.Forms.PictureBox();
            lblActif4 = new System.Windows.Forms.Label();
            timerEntreMains = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)upAndDownMise).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBlackjack).BeginInit();
            SuspendLayout();
            // 
            // btnHit
            // 
            btnHit.BackColor = System.Drawing.Color.DarkRed;
            btnHit.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnHit.ForeColor = System.Drawing.Color.LightYellow;
            btnHit.Location = new System.Drawing.Point(202, 548);
            btnHit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnHit.Name = "btnHit";
            btnHit.Size = new System.Drawing.Size(186, 44);
            btnHit.TabIndex = 10;
            btnHit.Text = "Hit";
            btnHit.UseVisualStyleBackColor = false;
            // 
            // lblJoueur4
            // 
            lblJoueur4.AutoSize = true;
            lblJoueur4.BackColor = System.Drawing.Color.DarkGreen;
            lblJoueur4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblJoueur4.ForeColor = System.Drawing.SystemColors.ControlText;
            lblJoueur4.Location = new System.Drawing.Point(270, 187);
            lblJoueur4.Name = "lblJoueur4";
            lblJoueur4.Size = new System.Drawing.Size(0, 18);
            lblJoueur4.TabIndex = 2;
            // 
            // lblJoueur3
            // 
            lblJoueur3.AutoSize = true;
            lblJoueur3.BackColor = System.Drawing.Color.DarkGreen;
            lblJoueur3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblJoueur3.ForeColor = System.Drawing.SystemColors.ControlText;
            lblJoueur3.Location = new System.Drawing.Point(461, 305);
            lblJoueur3.Name = "lblJoueur3";
            lblJoueur3.Size = new System.Drawing.Size(0, 18);
            lblJoueur3.TabIndex = 3;
            // 
            // lblJoueur2
            // 
            lblJoueur2.AutoSize = true;
            lblJoueur2.BackColor = System.Drawing.Color.DarkGreen;
            lblJoueur2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblJoueur2.ForeColor = System.Drawing.SystemColors.ControlText;
            lblJoueur2.Location = new System.Drawing.Point(730, 308);
            lblJoueur2.Name = "lblJoueur2";
            lblJoueur2.Size = new System.Drawing.Size(0, 18);
            lblJoueur2.TabIndex = 4;
            // 
            // lblJoueur1
            // 
            lblJoueur1.AutoSize = true;
            lblJoueur1.BackColor = System.Drawing.Color.DarkGreen;
            lblJoueur1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblJoueur1.ForeColor = System.Drawing.SystemColors.ControlText;
            lblJoueur1.Location = new System.Drawing.Point(925, 187);
            lblJoueur1.Name = "lblJoueur1";
            lblJoueur1.Size = new System.Drawing.Size(0, 18);
            lblJoueur1.TabIndex = 5;
            // 
            // lbClassement
            // 
            lbClassement.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbClassement.FormattingEnabled = true;
            lbClassement.ItemHeight = 16;
            lbClassement.Location = new System.Drawing.Point(1274, 52);
            lbClassement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            lbClassement.Name = "lbClassement";
            lbClassement.Size = new System.Drawing.Size(186, 148);
            lbClassement.TabIndex = 6;
            // 
            // lblClassement
            // 
            lblClassement.AutoSize = true;
            lblClassement.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblClassement.Location = new System.Drawing.Point(1274, 8);
            lblClassement.Name = "lblClassement";
            lblClassement.Size = new System.Drawing.Size(203, 41);
            lblClassement.TabIndex = 7;
            lblClassement.Text = "Classement";
            // 
            // btnDoubler
            // 
            btnDoubler.BackColor = System.Drawing.Color.DarkRed;
            btnDoubler.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDoubler.ForeColor = System.Drawing.Color.LightYellow;
            btnDoubler.Location = new System.Drawing.Point(897, 548);
            btnDoubler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnDoubler.Name = "btnDoubler";
            btnDoubler.Size = new System.Drawing.Size(179, 44);
            btnDoubler.TabIndex = 11;
            btnDoubler.Text = "Doubler";
            btnDoubler.UseVisualStyleBackColor = false;
            // 
            // btnQuitter
            // 
            btnQuitter.BackColor = System.Drawing.Color.FromArgb(101, 67, 33);
            btnQuitter.Font = new System.Drawing.Font("Cambria", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnQuitter.ForeColor = System.Drawing.Color.White;
            btnQuitter.Location = new System.Drawing.Point(1274, 339);
            btnQuitter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new System.Drawing.Size(186, 34);
            btnQuitter.TabIndex = 12;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = false;
            // 
            // btnStand
            // 
            btnStand.BackColor = System.Drawing.Color.DarkRed;
            btnStand.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnStand.ForeColor = System.Drawing.Color.LightYellow;
            btnStand.Location = new System.Drawing.Point(543, 548);
            btnStand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnStand.Name = "btnStand";
            btnStand.Size = new System.Drawing.Size(186, 44);
            btnStand.TabIndex = 13;
            btnStand.Text = "Stand";
            btnStand.UseVisualStyleBackColor = false;
            // 
            // btnRecommencer
            // 
            btnRecommencer.BackColor = System.Drawing.Color.FromArgb(101, 67, 33);
            btnRecommencer.Font = new System.Drawing.Font("Cambria", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRecommencer.ForeColor = System.Drawing.Color.White;
            btnRecommencer.Location = new System.Drawing.Point(1274, 292);
            btnRecommencer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnRecommencer.Name = "btnRecommencer";
            btnRecommencer.Size = new System.Drawing.Size(186, 34);
            btnRecommencer.TabIndex = 14;
            btnRecommencer.Text = "Recommencer";
            btnRecommencer.UseVisualStyleBackColor = false;
            // 
            // lblProchainePartie
            // 
            lblProchainePartie.BackColor = System.Drawing.Color.DarkGreen;
            lblProchainePartie.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblProchainePartie.Location = new System.Drawing.Point(809, 4);
            lblProchainePartie.Name = "lblProchainePartie";
            lblProchainePartie.Padding = new System.Windows.Forms.Padding(9, 8, 0, 0);
            lblProchainePartie.Size = new System.Drawing.Size(314, 51);
            lblProchainePartie.TabIndex = 15;
            lblProchainePartie.Text = "Prochaine main";
            // 
            // lblCompteur
            // 
            lblCompteur.BackColor = System.Drawing.Color.DarkGreen;
            lblCompteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCompteur.ForeColor = System.Drawing.SystemColors.ButtonFace;
            lblCompteur.Location = new System.Drawing.Point(1120, 4);
            lblCompteur.Name = "lblCompteur";
            lblCompteur.Size = new System.Drawing.Size(90, 51);
            lblCompteur.TabIndex = 16;
            lblCompteur.Text = "10";
            lblCompteur.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // upAndDownMise
            // 
            upAndDownMise.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            upAndDownMise.Location = new System.Drawing.Point(1337, 532);
            upAndDownMise.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            upAndDownMise.Name = "upAndDownMise";
            upAndDownMise.Size = new System.Drawing.Size(136, 62);
            upAndDownMise.TabIndex = 30;
            upAndDownMise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            upAndDownMise.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblChoixMise
            // 
            lblChoixMise.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblChoixMise.Location = new System.Drawing.Point(1253, 484);
            lblChoixMise.Name = "lblChoixMise";
            lblChoixMise.Size = new System.Drawing.Size(272, 38);
            lblChoixMise.TabIndex = 29;
            lblChoixMise.Text = "Choisir votre mise";
            // 
            // lblActif2
            // 
            lblActif2.AutoSize = true;
            lblActif2.BackColor = System.Drawing.Color.Green;
            lblActif2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblActif2.ForeColor = System.Drawing.Color.DarkRed;
            lblActif2.Location = new System.Drawing.Point(753, 334);
            lblActif2.Name = "lblActif2";
            lblActif2.Size = new System.Drawing.Size(42, 15);
            lblActif2.TabIndex = 19;
            lblActif2.Text = "ACTIF";
            lblActif2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActif1
            // 
            lblActif1.AutoSize = true;
            lblActif1.BackColor = System.Drawing.Color.Green;
            lblActif1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblActif1.ForeColor = System.Drawing.Color.DarkRed;
            lblActif1.Location = new System.Drawing.Point(942, 218);
            lblActif1.Name = "lblActif1";
            lblActif1.Size = new System.Drawing.Size(42, 15);
            lblActif1.TabIndex = 21;
            lblActif1.Text = "ACTIF";
            lblActif1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActif3
            // 
            lblActif3.AutoSize = true;
            lblActif3.BackColor = System.Drawing.Color.Green;
            lblActif3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblActif3.ForeColor = System.Drawing.Color.DarkRed;
            lblActif3.Location = new System.Drawing.Point(481, 334);
            lblActif3.Name = "lblActif3";
            lblActif3.Size = new System.Drawing.Size(42, 15);
            lblActif3.TabIndex = 22;
            lblActif3.Text = "ACTIF";
            lblActif3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGagnantOuPerdant4
            // 
            lblGagnantOuPerdant4.AutoSize = true;
            lblGagnantOuPerdant4.BackColor = System.Drawing.Color.Gold;
            lblGagnantOuPerdant4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblGagnantOuPerdant4.Location = new System.Drawing.Point(270, 249);
            lblGagnantOuPerdant4.Name = "lblGagnantOuPerdant4";
            lblGagnantOuPerdant4.Size = new System.Drawing.Size(0, 16);
            lblGagnantOuPerdant4.TabIndex = 23;
            // 
            // lblGagnantOuPerdant3
            // 
            lblGagnantOuPerdant3.AutoSize = true;
            lblGagnantOuPerdant3.BackColor = System.Drawing.Color.Gold;
            lblGagnantOuPerdant3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblGagnantOuPerdant3.Location = new System.Drawing.Point(461, 366);
            lblGagnantOuPerdant3.Name = "lblGagnantOuPerdant3";
            lblGagnantOuPerdant3.Size = new System.Drawing.Size(0, 16);
            lblGagnantOuPerdant3.TabIndex = 24;
            // 
            // lblGagnantOuPerdant2
            // 
            lblGagnantOuPerdant2.AutoSize = true;
            lblGagnantOuPerdant2.BackColor = System.Drawing.Color.Gold;
            lblGagnantOuPerdant2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblGagnantOuPerdant2.Location = new System.Drawing.Point(741, 366);
            lblGagnantOuPerdant2.Name = "lblGagnantOuPerdant2";
            lblGagnantOuPerdant2.Size = new System.Drawing.Size(0, 16);
            lblGagnantOuPerdant2.TabIndex = 25;
            // 
            // lblGagnantOuPerdant1
            // 
            lblGagnantOuPerdant1.AutoSize = true;
            lblGagnantOuPerdant1.BackColor = System.Drawing.Color.Gold;
            lblGagnantOuPerdant1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblGagnantOuPerdant1.Location = new System.Drawing.Point(925, 249);
            lblGagnantOuPerdant1.Name = "lblGagnantOuPerdant1";
            lblGagnantOuPerdant1.Size = new System.Drawing.Size(0, 16);
            lblGagnantOuPerdant1.TabIndex = 26;
            // 
            // lblClickHere
            // 
            lblClickHere.AutoSize = true;
            lblClickHere.BackColor = System.Drawing.Color.DarkGreen;
            lblClickHere.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblClickHere.Location = new System.Drawing.Point(396, 84);
            lblClickHere.Name = "lblClickHere";
            lblClickHere.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            lblClickHere.Size = new System.Drawing.Size(488, 51);
            lblClickHere.TabIndex = 28;
            lblClickHere.Text = "Click here to start playing ...";
            // 
            // pbBlackjack
            // 
            pbBlackjack.BackgroundImage = Properties.Resources.blackjackTable2;
            pbBlackjack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pbBlackjack.Location = new System.Drawing.Point(60, 0);
            pbBlackjack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pbBlackjack.Name = "pbBlackjack";
            pbBlackjack.Size = new System.Drawing.Size(1166, 541);
            pbBlackjack.TabIndex = 0;
            pbBlackjack.TabStop = false;
            // 
            // lblActif4
            // 
            lblActif4.AutoSize = true;
            lblActif4.BackColor = System.Drawing.Color.Green;
            lblActif4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblActif4.ForeColor = System.Drawing.Color.DarkRed;
            lblActif4.Location = new System.Drawing.Point(297, 218);
            lblActif4.Name = "lblActif4";
            lblActif4.Size = new System.Drawing.Size(42, 15);
            lblActif4.TabIndex = 31;
            lblActif4.Text = "ACTIF";
            lblActif4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerEntreMains
            // 
            timerEntreMains.Interval = 600;
            // 
            // FrmBlackjack
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DarkKhaki;
            ClientSize = new System.Drawing.Size(1536, 612);
            Controls.Add(lblGagnantOuPerdant3);
            Controls.Add(lblGagnantOuPerdant2);
            Controls.Add(lblGagnantOuPerdant1);
            Controls.Add(lblJoueur2);
            Controls.Add(lblGagnantOuPerdant4);
            Controls.Add(lblJoueur1);
            Controls.Add(lblProchainePartie);
            Controls.Add(lblActif1);
            Controls.Add(lblJoueur3);
            Controls.Add(lblCompteur);
            Controls.Add(lblJoueur4);
            Controls.Add(lblActif3);
            Controls.Add(lblActif2);
            Controls.Add(lblClickHere);
            Controls.Add(lblActif4);
            Controls.Add(pbBlackjack);
            Controls.Add(btnHit);
            Controls.Add(lblChoixMise);
            Controls.Add(upAndDownMise);
            Controls.Add(btnRecommencer);
            Controls.Add(btnStand);
            Controls.Add(btnQuitter);
            Controls.Add(btnDoubler);
            Controls.Add(lblClassement);
            Controls.Add(lbClassement);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "FrmBlackjack";
            Text = "Blackjack";
            ((System.ComponentModel.ISupportInitialize)upAndDownMise).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBlackjack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Label lblJoueur4;
        private System.Windows.Forms.Label lblJoueur3;
        private System.Windows.Forms.Label lblJoueur2;
        private System.Windows.Forms.Label lblJoueur1;
        private System.Windows.Forms.ListBox lbClassement;
        private System.Windows.Forms.Label lblClassement;
        private System.Windows.Forms.Button btnDoubler;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnRecommencer;
        private System.Windows.Forms.Label lblProchainePartie;
        private System.Windows.Forms.Label lblCompteur;
        private System.Windows.Forms.NumericUpDown upAndDownMise;
        private System.Windows.Forms.Timer timerEntreMains;
        private System.Windows.Forms.Label lblChoixMise;
        private System.Windows.Forms.Label lblActif2;
        private System.Windows.Forms.Label lblActif1;
        private System.Windows.Forms.Label lblActif3;
        private System.Windows.Forms.Label lblGagnantOuPerdant4;
        private System.Windows.Forms.Label lblGagnantOuPerdant3;
        private System.Windows.Forms.Label lblGagnantOuPerdant2;
        private System.Windows.Forms.Label lblGagnantOuPerdant1;
        private System.Windows.Forms.Label lblClickHere;
        private System.Windows.Forms.PictureBox pbBlackjack;
        private System.Windows.Forms.Label lblActif4;
    }
}

