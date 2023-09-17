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

        public Carte (int p_valeur, Sorte p_sorte) : base("Nom_Default", "Email_Default")
        {
            this.Valeur = p_valeur;
            this.Sorte = p_sorte;
        }

        public String GetNomRessource()
        {
            String nomRessource = "";

            //switch (this.Valeur)
            //{
            //    case 1:
            //        nomRessource += "As";
            //        break;
            //    case 11:
            //        nomRessource += "Valet";
            //        break;
            //    case 12:
            //        nomRessource += "Dame";
            //        break;
            //    case 13:
            //        nomRessource += "Roi";
            //        break;
            //    default:
            //        nomRessource += this.Valeur;
            //        break;
            //}

            //nomRessource += "_";

            //switch (this.Sorte)
            //{
            //    case Sorte.Coeur:
            //        nomRessource += "Coeur";
            //        break;
            //    case Sorte.Carreau:
            //        nomRessource += "Carreau";
            //        break;
            //    case Sorte.Pique:
            //        nomRessource += "Pique";
            //        break;
            //    case Sorte.Trefle:
            //        nomRessource += "Trefle";
            //        break;
            //}

            return nomRessource;
        }

    }
}
