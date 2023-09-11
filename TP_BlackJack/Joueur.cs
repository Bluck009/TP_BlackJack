using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_BlackJack
{
    public abstract class Joueur 
    {
        private String nom;
        private String email;
        private int argent;
        private int valeurMisee;
        private int positionTable;
        private List<Carte> main;

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

        public string Email
        {
            get { return email; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Le courriel ne peut pas être vide, nulle ou contenir des espaces");
                }
                email = value;
            }
        }
        public int Argent
        {
            get { return argent; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("No money, no play!");
                }
                argent = value;
            }
        }
        public int ValeurMisee
        {
            get { return valeurMisee; }
            set {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("La mise ne peut pas être négative");
                }
                valeurMisee = value;
            }
        }
        public int PositionTable
        {
            get { return positionTable; }
            set { positionTable = value; }
        }

        public List<Carte> Main
        {
            get { return main; }
            set { main = value; }
        }
        public Joueur( String p_nom, String p_email)
        {
            this.Nom = p_nom;
            this.Email = p_email;
        }
        public int CalculerNimbreDePoints()
        {
            int nombrePoint = 0;
            return nombrePoint;
        }

        public virtual int CompareTo(Joueur p_joueur)
        {
            int argentDiff = 0;
            return argentDiff;
        }
    }

}
