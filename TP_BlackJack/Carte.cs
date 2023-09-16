using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_BlackJack
{
    public class Carte : Joueur
    {
        private int valeur;
        private Sorte sorte;

        public int Valeur
        {
            get { return valeur; }
            set 
            {
                if (value < 1 || value > 13)
                    throw new ArgumentException("La valeur de la carte doit être comprise entre 1 et 13");

                valeur = value; 
            }
        }

        public Sorte Sorte
        {
            get { return sorte; }
            set 
            { 
                if (value == null)
                    throw new ArgumentNullException("La sorte de la carte ne peut pas être null");
                
                sorte = value; }
        }

        public Carte (int p_valeur, Sorte p_sorte)
        {
            this.Valeur = p_valeur;
            this.Sorte = p_sorte;
        }

        public String GetNomRessource()
        {
            return "";
        }
    }
}
