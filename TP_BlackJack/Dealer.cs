using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_BlackJack
{
    public class Dealer : Carte, IJouer
    {
        private bool plusQue21;

        private List<Carte> main;

        public bool PlusQue21
        {
            get { return plusQue21; }
            set { plusQue21 = value; }
        }

        public List<Carte> Main
        {
            get { return main; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("La main du dealer ne peut pas être null");
                main = value;
            }
        }
        
        public Dealer(int p_valeur, Sorte p_sorte) : base(p_valeur, p_sorte)
        {
            this.Main = new List<Carte>();
        }

        public void Jouer()
        {
        }

        public int CalculerNombreDePoints()
        {
            return 0;
        }
    }
}
