using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            DateTime date = DateTime.Now;
            date = date.AddYears(-18);
            if (Utilitaire.ValiderEmail(txtEmail.Text) && Utilitaire.ValiderChaineObligatoire(txtNom.Text))
            {
                txtErrorMessage.Text = String.Empty;
                Joueur joueur = new Humain(txtNom.Text, txtEmail.Text, date);
                this.TousLesJoueurs.Add(joueur);
                txtListeJoueurs.AppendText(joueur.Nom + "\r\n");
                return;
            }
            txtErrorMessage.Text = "Email ou nom invalide. ";

        }
        private void btnCommencer_Click(object sender, EventArgs e)
        {
            if (Utilitaire.ValiderChaineObligatoire(cmbNombreBots.Text))
            {
                txtBotErrMsg.Text = String.Empty;
                return;
            }
            txtBotErrMsg.Text = "Vous devez choisir le nombre de bot(s). ";
            if (Utilitaire.ValiderChaineObligatoire(txtListeJoueurs.Text))
            {
                txtMsgErrAjouterJoueur.Text = String.Empty;
                return;
            }
            txtMsgErrAjouterJoueur.Text = "Vous devez céer plus de joueurs! ";
        }
        private void FrmAccueil_Load(object sender, EventArgs e)
        {
            for (int nbBot = 0; nbBot < 4; nbBot++)
            {
                cmbNombreBots.Items.Add(nbBot.ToString());
            }

            //FrmBlackjack black = new FrmBlackjack();
            //black.ShowDialog();
        }
    }
}
