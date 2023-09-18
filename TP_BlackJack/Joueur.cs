using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TP_BlackJack
{
    public abstract class Joueur : IComparable<Joueur>
    {
        private const int MONTANT_INITIAL = 100;
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
<<<<<<< HEAD
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Le nom ne peut pas être vide, nul ou contenir des espaces");
                }
=======
                //if (String.IsNullOrWhiteSpace(value))
                //{
                //    throw new ArgumentException("Le nom ne peut pas être vide, nulle ou contenir des espaces");
                //}
>>>>>>> luc
                nom = value;
            }
        }

        public String Email
        {
            get { return email; }
            set
            {
                //if (String.IsNullOrWhiteSpace(value))
                //{
                //    throw new ArgumentException("Le courriel ne peut pas être vide, nulle ou contenir des espaces");
                //}
                email = value;
            }
        }
        public int Argent
        {
            get { return argent; }
            set
            {
                //if (value < 0)
                //{
                //    throw new ArgumentOutOfRangeException("Pas d'argent, pas de jeu !");
                //}
                argent = value;
            }
        }
        public int ValeurMisee
        {
            get { return valeurMisee; }
<<<<<<< HEAD
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("La mise ne peut pas être négative");
                }
=======
            set {
                //if (value < 0)
                //{
                //    throw new ArgumentOutOfRangeException("La mise ne peut pas être négative");
                //}
>>>>>>> luc
                valeurMisee = value;
            }
        }
        public int PositionTable
        {
            get { return positionTable; }
<<<<<<< HEAD
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("La position à la table ne peut pas être négative");
                }
                positionTable = value;
            }
=======
            set 
            { 
                //if (value < 0)
                //{
                //    throw new ArgumentOutOfRangeException("La position à la table ne peut pas être négative");
                //}
                positionTable = value; }
>>>>>>> luc
        }

        public List<Carte> Main
        {
            get { return main; }
<<<<<<< HEAD
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("La main ne peut pas être null");
                }
                main = value;
            }
=======
            set 
            {   
                //if (value == null)
                //{
                //    throw new ArgumentNullException("La main ne peut pas être null");
                //}
                main = value; }
>>>>>>> luc
        }

        public Joueur(String p_nom, String p_email)
        {
            this.Nom = p_nom;
            this.Email = p_email;
            this.Argent = MONTANT_INITIAL;
        }

        public int CalculerNombreDePoints()
        {
<<<<<<< HEAD
            int nbPoint = 0;
            bool asPresent = false;

            foreach (Carte carte in main)
            {
                if (carte.Valeur == 1)
=======
            int nombrePoint = 0;
            bool asPresent = false;

            foreach(Carte carte in main)
            {
                if(carte.Valeur == 1)
>>>>>>> luc
                {
                    asPresent = true;
                }

                if (carte.Valeur > 10)
                {
                    carte.Valeur = 10;
                }

<<<<<<< HEAD
                nbPoint += carte.Valeur;
            }

            if (asPresent && nbPoint <= 11)
            {
                nbPoint += 10;
            }

            return nbPoint;
=======
                nombrePoint += carte.Valeur;
            }

            if(asPresent && nombrePoint <= 11)
            {
                nombrePoint += 10;
            }
            
            return nombrePoint;
>>>>>>> luc
        }

        public void Doubler()
        {
<<<<<<< HEAD
            this.ValeurMisee = this.ValeurMisee * 2;
=======
            valeurMisee *= 2;             
>>>>>>> luc
        }

        public virtual int CompareTo(Joueur p_joueur)
        {
            return this.Argent.CompareTo(p_joueur.Argent);
        }

        public override string ToString()
        {
            return this.Nom;
        }

        public override bool Equals(object obj)
        {
            var joueur2 = obj as Joueur;
            if (joueur2 is not null && this.argent == joueur2.argent)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Joueur left, Joueur right)
        {
            if (ReferenceEquals(left, null))
            {
                return ReferenceEquals(right, null);
            }
            return left.Equals(right);
        }

        public static bool operator !=(Joueur left, Joueur right)
        {
            return !(left == right);
        }

        public static bool operator <(Joueur left, Joueur right)
        {
            return ReferenceEquals(left, null) ? !ReferenceEquals(right, null) : left.CompareTo(right) < 0;
        }

        public static bool operator <=(Joueur left, Joueur right)
        {
            return ReferenceEquals(left, null) || left.CompareTo(right) <= 0;
        }

        public static bool operator >(Joueur left, Joueur right)
        {
            return !ReferenceEquals(left, null) && left.CompareTo(right) > 0;
        }

        public static bool operator >=(Joueur left, Joueur right)
        {
            return ReferenceEquals(left, null) ? ReferenceEquals(right, null) : left.CompareTo(right) >= 0;
        }
    }

}
