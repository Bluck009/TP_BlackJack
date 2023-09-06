using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_BlackJack
{
    public abstract class Joueur
    {
        String nom;
        String email;
        int argent;
        int valeurMisee;
        int positionTable;
        List<Carte> main;

        public String Nom
        {
            get { return nom; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Le nom ne peut pas être vide, nulle ou contenir des espaces");
                }
                nom = value;
            }
        }
    }

}
