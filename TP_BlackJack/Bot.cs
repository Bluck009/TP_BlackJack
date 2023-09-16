using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_BlackJack
{
    public class Bot : Joueur, IJouer
    {
        public Bot(String p_nom, String p_email) : base(p_nom, p_email)
        {
            this.Argent = 5000;
        }
        
        public void Jouer()
        {
            while (this.CalculerNombreDePoints() < 17)
            {
                Jeu.PigerUneCarteJoueur(this);
            }
        }

        public void GenereMiseAleatoire()
        {
            Random rnd = new Random();
            int mise = rnd.Next(10, this.Argent);
            this.ValeurMisee = mise;
        }
    }
}
