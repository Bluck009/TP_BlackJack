
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
            this.components = new System.ComponentModel.Container();
            this.btnHit = new System.Windows.Forms.Button();
            this.lblJoueur4 = new System.Windows.Forms.Label();
            this.lblJoueur3 = new System.Windows.Forms.Label();
            this.lblJoueur2 = new System.Windows.Forms.Label();
            this.lblJoueur1 = new System.Windows.Forms.Label();
            this.lbClassement = new System.Windows.Forms.ListBox();
            this.lblClassement = new System.Windows.Forms.Label();
            this.btnDoubler = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnRecommencer = new System.Windows.Forms.Button();
            this.lblProchainePartie = new System.Windows.Forms.Label();
            this.lblCompteur = new System.Windows.Forms.Label();
            this.upAndDownMise = new System.Windows.Forms.NumericUpDown();
            this.lblChoixMise = new System.Windows.Forms.Label();
            this.lblActif2 = new System.Windows.Forms.Label();
            this.lblActif1 = new System.Windows.Forms.Label();
            this.lblActif3 = new System.Windows.Forms.Label();
            this.lblGagnantOuPerdant4 = new System.Windows.Forms.Label();
            this.lblGagnantOuPerdant3 = new System.Windows.Forms.Label();
            this.lblGagnantOuPerdant2 = new System.Windows.Forms.Label();
            this.lblGagnantOuPerdant1 = new System.Windows.Forms.Label();
            this.lblClickHere = new System.Windows.Forms.Label();
            this.pbBlackjack = new System.Windows.Forms.PictureBox();
            this.lblActif4 = new System.Windows.Forms.Label();
            this.timerEntreMains = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.upAndDownMise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlackjack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.DarkRed;
            this.btnHit.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHit.ForeColor = System.Drawing.Color.LightYellow;
            this.btnHit.Location = new System.Drawing.Point(231, 730);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(212, 58);
            this.btnHit.TabIndex = 10;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = false;
            // 
            // lblJoueur4
            // 
            this.lblJoueur4.AutoSize = true;
            this.lblJoueur4.BackColor = System.Drawing.Color.DarkGreen;
            this.lblJoueur4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJoueur4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblJoueur4.Location = new System.Drawing.Point(308, 249);
            this.lblJoueur4.Name = "lblJoueur4";
            this.lblJoueur4.Size = new System.Drawing.Size(0, 24);
            this.lblJoueur4.TabIndex = 2;
            // 
            // lblJoueur3
            // 
            this.lblJoueur3.AutoSize = true;
            this.lblJoueur3.BackColor = System.Drawing.Color.DarkGreen;
            this.lblJoueur3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJoueur3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblJoueur3.Location = new System.Drawing.Point(527, 407);
            this.lblJoueur3.Name = "lblJoueur3";
            this.lblJoueur3.Size = new System.Drawing.Size(0, 24);
            this.lblJoueur3.TabIndex = 3;
            // 
            // lblJoueur2
            // 
            this.lblJoueur2.AutoSize = true;
            this.lblJoueur2.BackColor = System.Drawing.Color.DarkGreen;
            this.lblJoueur2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJoueur2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblJoueur2.Location = new System.Drawing.Point(834, 410);
            this.lblJoueur2.Name = "lblJoueur2";
            this.lblJoueur2.Size = new System.Drawing.Size(0, 24);
            this.lblJoueur2.TabIndex = 4;
            // 
            // lblJoueur1
            // 
            this.lblJoueur1.AutoSize = true;
            this.lblJoueur1.BackColor = System.Drawing.Color.DarkGreen;
            this.lblJoueur1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJoueur1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblJoueur1.Location = new System.Drawing.Point(1057, 249);
            this.lblJoueur1.Name = "lblJoueur1";
            this.lblJoueur1.Size = new System.Drawing.Size(0, 24);
            this.lblJoueur1.TabIndex = 5;
            // 
            // lbClassement
            // 
            this.lbClassement.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbClassement.FormattingEnabled = true;
            this.lbClassement.ItemHeight = 20;
            this.lbClassement.Location = new System.Drawing.Point(1456, 69);
            this.lbClassement.Name = "lbClassement";
            this.lbClassement.Size = new System.Drawing.Size(212, 204);
            this.lbClassement.TabIndex = 6;
            // 
            // lblClassement
            // 
            this.lblClassement.AutoSize = true;
            this.lblClassement.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClassement.Location = new System.Drawing.Point(1456, 11);
            this.lblClassement.Name = "lblClassement";
            this.lblClassement.Size = new System.Drawing.Size(253, 52);
            this.lblClassement.TabIndex = 7;
            this.lblClassement.Text = "Classement";
            // 
            // btnDoubler
            // 
            this.btnDoubler.BackColor = System.Drawing.Color.DarkRed;
            this.btnDoubler.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDoubler.ForeColor = System.Drawing.Color.LightYellow;
            this.btnDoubler.Location = new System.Drawing.Point(1025, 730);
            this.btnDoubler.Name = "btnDoubler";
            this.btnDoubler.Size = new System.Drawing.Size(205, 58);
            this.btnDoubler.TabIndex = 11;
            this.btnDoubler.Text = "Doubler";
            this.btnDoubler.UseVisualStyleBackColor = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.btnQuitter.Font = new System.Drawing.Font("Cambria", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(1456, 452);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(212, 45);
            this.btnQuitter.TabIndex = 12;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            // 
            // btnStand
            // 
            this.btnStand.BackColor = System.Drawing.Color.DarkRed;
            this.btnStand.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStand.ForeColor = System.Drawing.Color.LightYellow;
            this.btnStand.Location = new System.Drawing.Point(621, 730);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(212, 58);
            this.btnStand.TabIndex = 13;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = false;
            // 
            // btnRecommencer
            // 
            this.btnRecommencer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.btnRecommencer.Font = new System.Drawing.Font("Cambria", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRecommencer.ForeColor = System.Drawing.Color.White;
            this.btnRecommencer.Location = new System.Drawing.Point(1456, 389);
            this.btnRecommencer.Name = "btnRecommencer";
            this.btnRecommencer.Size = new System.Drawing.Size(212, 45);
            this.btnRecommencer.TabIndex = 14;
            this.btnRecommencer.Text = "Recommencer";
            this.btnRecommencer.UseVisualStyleBackColor = false;
            // 
            // lblProchainePartie
            // 
            this.lblProchainePartie.BackColor = System.Drawing.Color.DarkGreen;
            this.lblProchainePartie.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProchainePartie.Location = new System.Drawing.Point(925, 5);
            this.lblProchainePartie.Name = "lblProchainePartie";
            this.lblProchainePartie.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.lblProchainePartie.Size = new System.Drawing.Size(359, 68);
            this.lblProchainePartie.TabIndex = 15;
            this.lblProchainePartie.Text = "Prochaine main";
            // 
            // lblCompteur
            // 
            this.lblCompteur.BackColor = System.Drawing.Color.DarkGreen;
            this.lblCompteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCompteur.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCompteur.Location = new System.Drawing.Point(1280, 5);
            this.lblCompteur.Name = "lblCompteur";
            this.lblCompteur.Size = new System.Drawing.Size(103, 68);
            this.lblCompteur.TabIndex = 16;
            this.lblCompteur.Text = "10";
            this.lblCompteur.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // upAndDownMise
            // 
            this.upAndDownMise.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.upAndDownMise.Location = new System.Drawing.Point(1528, 710);
            this.upAndDownMise.Name = "upAndDownMise";
            this.upAndDownMise.Size = new System.Drawing.Size(155, 75);
            this.upAndDownMise.TabIndex = 30;
            this.upAndDownMise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.upAndDownMise.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblChoixMise
            // 
            this.lblChoixMise.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChoixMise.Location = new System.Drawing.Point(1432, 646);
            this.lblChoixMise.Name = "lblChoixMise";
            this.lblChoixMise.Size = new System.Drawing.Size(311, 51);
            this.lblChoixMise.TabIndex = 29;
            this.lblChoixMise.Text = "Choisir votre mise";
            // 
            // lblActif2
            // 
            this.lblActif2.AutoSize = true;
            this.lblActif2.BackColor = System.Drawing.Color.Green;
            this.lblActif2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActif2.ForeColor = System.Drawing.Color.DarkRed;
            this.lblActif2.Location = new System.Drawing.Point(861, 445);
            this.lblActif2.Name = "lblActif2";
            this.lblActif2.Size = new System.Drawing.Size(56, 20);
            this.lblActif2.TabIndex = 19;
            this.lblActif2.Text = "ACTIF";
            this.lblActif2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActif1
            // 
            this.lblActif1.AutoSize = true;
            this.lblActif1.BackColor = System.Drawing.Color.Green;
            this.lblActif1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActif1.ForeColor = System.Drawing.Color.DarkRed;
            this.lblActif1.Location = new System.Drawing.Point(1077, 290);
            this.lblActif1.Name = "lblActif1";
            this.lblActif1.Size = new System.Drawing.Size(56, 20);
            this.lblActif1.TabIndex = 21;
            this.lblActif1.Text = "ACTIF";
            this.lblActif1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActif3
            // 
            this.lblActif3.AutoSize = true;
            this.lblActif3.BackColor = System.Drawing.Color.Green;
            this.lblActif3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActif3.ForeColor = System.Drawing.Color.DarkRed;
            this.lblActif3.Location = new System.Drawing.Point(550, 445);
            this.lblActif3.Name = "lblActif3";
            this.lblActif3.Size = new System.Drawing.Size(56, 20);
            this.lblActif3.TabIndex = 22;
            this.lblActif3.Text = "ACTIF";
            this.lblActif3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGagnantOuPerdant4
            // 
            this.lblGagnantOuPerdant4.AutoSize = true;
            this.lblGagnantOuPerdant4.BackColor = System.Drawing.Color.Gold;
            this.lblGagnantOuPerdant4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGagnantOuPerdant4.Location = new System.Drawing.Point(308, 332);
            this.lblGagnantOuPerdant4.Name = "lblGagnantOuPerdant4";
            this.lblGagnantOuPerdant4.Size = new System.Drawing.Size(0, 20);
            this.lblGagnantOuPerdant4.TabIndex = 23;
            // 
            // lblGagnantOuPerdant3
            // 
            this.lblGagnantOuPerdant3.AutoSize = true;
            this.lblGagnantOuPerdant3.BackColor = System.Drawing.Color.Gold;
            this.lblGagnantOuPerdant3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGagnantOuPerdant3.Location = new System.Drawing.Point(527, 488);
            this.lblGagnantOuPerdant3.Name = "lblGagnantOuPerdant3";
            this.lblGagnantOuPerdant3.Size = new System.Drawing.Size(0, 20);
            this.lblGagnantOuPerdant3.TabIndex = 24;
            // 
            // lblGagnantOuPerdant2
            // 
            this.lblGagnantOuPerdant2.AutoSize = true;
            this.lblGagnantOuPerdant2.BackColor = System.Drawing.Color.Gold;
            this.lblGagnantOuPerdant2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGagnantOuPerdant2.Location = new System.Drawing.Point(847, 488);
            this.lblGagnantOuPerdant2.Name = "lblGagnantOuPerdant2";
            this.lblGagnantOuPerdant2.Size = new System.Drawing.Size(0, 20);
            this.lblGagnantOuPerdant2.TabIndex = 25;
            // 
            // lblGagnantOuPerdant1
            // 
            this.lblGagnantOuPerdant1.AutoSize = true;
            this.lblGagnantOuPerdant1.BackColor = System.Drawing.Color.Gold;
            this.lblGagnantOuPerdant1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGagnantOuPerdant1.Location = new System.Drawing.Point(1057, 332);
            this.lblGagnantOuPerdant1.Name = "lblGagnantOuPerdant1";
            this.lblGagnantOuPerdant1.Size = new System.Drawing.Size(0, 20);
            this.lblGagnantOuPerdant1.TabIndex = 26;
            // 
            // lblClickHere
            // 
            this.lblClickHere.AutoSize = true;
            this.lblClickHere.BackColor = System.Drawing.Color.DarkGreen;
            this.lblClickHere.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClickHere.Location = new System.Drawing.Point(453, 112);
            this.lblClickHere.Name = "lblClickHere";
            this.lblClickHere.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblClickHere.Size = new System.Drawing.Size(616, 65);
            this.lblClickHere.TabIndex = 28;
            this.lblClickHere.Text = "Click here to start playing ...";
            // 
            // pbBlackjack
            // 
            this.pbBlackjack.BackgroundImage = global::TP_BlackJack.Properties.Resources.blackjackTable2;
            this.pbBlackjack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBlackjack.Location = new System.Drawing.Point(68, 0);
            this.pbBlackjack.Name = "pbBlackjack";
            this.pbBlackjack.Size = new System.Drawing.Size(1333, 721);
            this.pbBlackjack.TabIndex = 0;
            this.pbBlackjack.TabStop = false;
            // 
            // lblActif4
            // 
            this.lblActif4.AutoSize = true;
            this.lblActif4.BackColor = System.Drawing.Color.Green;
            this.lblActif4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActif4.ForeColor = System.Drawing.Color.DarkRed;
            this.lblActif4.Location = new System.Drawing.Point(339, 290);
            this.lblActif4.Name = "lblActif4";
            this.lblActif4.Size = new System.Drawing.Size(56, 20);
            this.lblActif4.TabIndex = 31;
            this.lblActif4.Text = "ACTIF";
            this.lblActif4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerEntreMains
            // 
            this.timerEntreMains.Interval = 600;
            // 
            // FrmBlackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1755, 816);
            this.Controls.Add(this.lblGagnantOuPerdant3);
            this.Controls.Add(this.lblGagnantOuPerdant2);
            this.Controls.Add(this.lblGagnantOuPerdant1);
            this.Controls.Add(this.lblJoueur2);
            this.Controls.Add(this.lblGagnantOuPerdant4);
            this.Controls.Add(this.lblJoueur1);
            this.Controls.Add(this.lblProchainePartie);
            this.Controls.Add(this.lblActif1);
            this.Controls.Add(this.lblJoueur3);
            this.Controls.Add(this.lblCompteur);
            this.Controls.Add(this.lblJoueur4);
            this.Controls.Add(this.lblActif3);
            this.Controls.Add(this.lblActif2);
            this.Controls.Add(this.lblClickHere);
            this.Controls.Add(this.lblActif4);
            this.Controls.Add(this.pbBlackjack);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.lblChoixMise);
            this.Controls.Add(this.upAndDownMise);
            this.Controls.Add(this.btnRecommencer);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnDoubler);
            this.Controls.Add(this.lblClassement);
            this.Controls.Add(this.lbClassement);
            this.Name = "FrmBlackjack";
            this.Text = "Blackjack";
            ((System.ComponentModel.ISupportInitialize)(this.upAndDownMise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlackjack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

