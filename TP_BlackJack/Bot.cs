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
            Random rnd = new Random();
            int choix = rnd.Next(1, 3);
            if (choix == 1)
            {
                this.GenereMiseAleatoire();
            }
            else
            {
                this.ValeurMisee = 0;
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
