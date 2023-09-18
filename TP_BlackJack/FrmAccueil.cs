using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP_BlackJack
{
    public partial class FrmAccueil : Form
    {
        public const int MIN_AGE = 18;
        private List<Joueur> joueursChoisis;
        private List<Joueur> tousLesJoueurs;

        public List<Joueur> JoueursChoisis
        {
            get { return joueursChoisis; }
            set { joueursChoisis = value; }
        }

        public List<Joueur> TousLesJoueurs
        {
            get { return tousLesJoueurs; }
            set { tousLesJoueurs = value; }
        }
        public FrmAccueil()
        {
            InitializeComponent();
            this.JoueursChoisis = new List<Joueur>();
            this.TousLesJoueurs = new List<Joueur>();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now; // doit ajouter validation de date
            date = date.AddYears(-18);
            if (Utilitaire.ValiderEmail(txtEmail.Text) && Utilitaire.ValiderChaineObligatoire(txtNom.Text))
            {
                txtErrorMessage.Text = String.Empty;
                Joueur joueur = new Humain(txtNom.Text, txtEmail.Text, date);
                this.TousLesJoueurs.Add(joueur);
                txtListeJoueur.AppendText(joueur.Nom + "\r\n");
                return;
            }
            txtErrorMessage.Text = "Email ou nom invalide. ";

        }
        private void btnCommencer_Click(object sender, EventArgs e)
        {
            int countDown = 4;

            if (Utilitaire.ValiderChaineObligatoire(cmbNombreBots.Text))
            {
                txtBotErrMsg.Text = String.Empty;
                countDown--;
            }
            else
            {
                txtBotErrMsg.Text = "Vous devez choisir le nombre de bot(s). ";
            }
            if (cmbNombreBots.Text != "")
            {
                if (this.TousLesJoueurs.Count > int.Parse(cmbNombreBots.Text))
                {
                    txtMsgErrAjouterJoueur.Text = String.Empty;
                    countDown--;
                }
                else
                {
                    txtMsgErrAjouterJoueur.Text = "Vous devez céer plus de joueurs! ";
                }
            }
            if (this.TousLesJoueurs.Count != 0)
            {
                txtMsgErrAjouterJoueur.Text = String.Empty;
                countDown--;
            }
            else
            {
                txtMsgErrAjouterJoueur.Text = "Vous devez céer au moins un joueurs! ";
            }

            if (this.JoueursChoisis.Count != 0)
            {
                txtMsgErrChoisirJoueur.Text = String.Empty;
                countDown--;
            }
            else
            {
                txtMsgErrChoisirJoueur.Text = "Vous devez choisir un joueur. ";
            }

            if (countDown == 0)
            {
                //Random random = new Random();
                int nbBotToAdd = int.Parse(cmbNombreBots.Text);
                for (int bot = 1; bot <= nbBotToAdd; bot++)
                {
                    this.JoueursChoisis.Add(this.TousLesJoueurs[bot]); // reste random a faire
                }

                FrmBlackjack black = new FrmBlackjack();
                black.ShowDialog();
            }

        }
        private void FrmAccueil_Load(object sender, EventArgs e)
        {
            for (int nbBot = 0; nbBot < 4; nbBot++)
            {
                cmbNombreBots.Items.Add(nbBot.ToString());
            }
        }

        private void txtListeJoueur_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.TousLesJoueurs.Count != 0)
            {
                int p = txtListeJoueur.GetCharIndexFromPosition(e.Location);
                int line = txtListeJoueur.GetLineFromCharIndex(p);
                txtListeJoueur.SelectionStart = txtListeJoueur.Text[line];
                txtListeJoueur.SelectionLength = txtListeJoueur.Text[line];
                Joueur joueurSelection = this.TousLesJoueurs[line];
                if (this.joueursChoisis.Count != 0)
                {
                    this.joueursChoisis[0] = joueurSelection;
                }
                else
                {
                    this.JoueursChoisis.Add(joueurSelection);
                }
                txtJoueruChoisi.Text = this.JoueursChoisis[0].Nom; // juste pour valider
            }
        }

    }
}
