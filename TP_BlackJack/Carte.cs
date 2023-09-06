using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_BlackJack
{
    public class Carte
    {
        private int valeur;
        private Sorte sorte;

        public int Valeur
        {
            get { return valeur; }
            set { valeur = value; }
        }

        public Sorte Sorte
        {
            get { return sorte; }
            set { sorte = value; }
        }

        public Carte (int p_valeur, Sorte p_sorte)
        {
            this.Valeur = p_valeur;
            this.Sorte = p_sorte;
        }

        public String GetNomRessource()
        {
            return "what";
        }
    }
}
