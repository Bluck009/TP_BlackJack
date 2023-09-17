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

        }
      
        public void Jouer()
        {

        }

        public void GenereMiseAleatoire()
        {
            
            Random rnd = new Random();
            int mise = rnd.Next(1, 10); // retirer cash apres avoir perdu
            this.ValeurMisee = mise;
            
        }
    }
}
