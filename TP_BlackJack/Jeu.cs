using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_BlackJack
{
    public static class Jeu
    {
        private static List<Carte> paquetCartes;

        private static List<Joueur> joueurs;

        private static Dealer dealer;

        private static Random rnd = new Random();

        public static List<Carte> PaquetCartes
        {
            get { return paquetCartes; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Le paquet de cartes ne peut pas être null");
                paquetCartes = value;
            }
        }

        public static List<Joueur> Joueurs
        {
            get { return joueurs; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("La liste de joueurs ne peut pas être null");
                joueurs = value;
            }
        }

        public static Dealer Dealer
        {
            get { return dealer; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Le dealer ne peut pas être null");
                dealer = value;
            }
        }

        static Jeu()
        {
            PaquetCartes = CreerPaquetCartes();
            List<Carte>paquetCartes2 = CreerPaquetCartes();
            PaquetCartes.AddRange(paquetCartes2);
            Joueurs = new List<Joueur>();
            Joueurs.Sort();
            Dealer = dealer;
            BrasserCartes();
        }



        public static void PigerUneCarteJoueur(Joueur joueur)
        {
            if (PaquetCartes.Count == 0)
                throw new InvalidOperationException("Le paquet de cartes est vide");
            else if (PaquetCartes.Count > 0)
            {
                //Joueur.AjouterCarte(PaquetCartes[0]);
                PaquetCartes.RemoveAt(0);
            }
        }

        public static void PigerUneCarteDealer()
        {
            if (PaquetCartes.Count == 0)
                throw new InvalidOperationException("Le paquet de cartes est vide");
            else if (PaquetCartes.Count > 0)
            {
                //Dealer.AjouterCarte(PaquetCartes[0]);
                PaquetCartes.RemoveAt(0);
            }
        }


        public static List<Carte> CreerPaquetCartes()
        {
            List<Carte> paquetCartes = new List<Carte>();
            foreach (Sorte sorte in Enum.GetValues(typeof(Sorte)))
            {
                for (int valeurCarte = 1; valeurCarte <= 13; valeurCarte++ )
                {
                    paquetCartes.Add(new Carte(valeurCarte, sorte));
                }
            }
            return paquetCartes;
        }



        public static void BrasserCartes()
        {
            Random random = new Random();
            for (int positionEnCours = 0; positionEnCours < PaquetCartes.Count - 1; positionEnCours++)
            {
                int nouvellePosition = random.Next(positionEnCours, PaquetCartes.Count);
                Carte carteEnCours = PaquetCartes[positionEnCours];
                PaquetCartes[positionEnCours] = PaquetCartes[nouvellePosition];
                PaquetCartes[nouvellePosition] = carteEnCours;
            }
        }
        //int carteBrassees = PaquetCartes.Count;
        //while (carteBrassees > 1)
        //{
        //    carteBrassees--;
        //    int carteAleatoire = rnd.Next(carteBrassees + 1);
        //    Carte value = PaquetCartes[carteAleatoire];
        //    PaquetCartes[carteAleatoire] = PaquetCartes[carteBrassees];
        //    PaquetCartes[carteBrassees] = value;

        //}
    

        public static void DistribuerLesCartes()
        {
            foreach (Joueur joueur in Joueurs)
            {
                PigerUneCarteJoueur(joueur);
                PigerUneCarteJoueur(joueur);
            }
            PigerUneCarteDealer();
            PigerUneCarteDealer();
        }

        public static void RecommencerPartie()
        {
            foreach (Joueur joueur in Joueurs)
            {
                joueur.Main.Clear();
            }
            Dealer.Main.Clear();
            PaquetCartes = CreerPaquetCartes();
            BrasserCartes();
            DistribuerLesCartes();
        }

        public static void ReinitialiserLesMains()
        {
            foreach (Joueur joueur in Joueurs)
            {
                joueur.Main.Clear();
            }
            Dealer.Main.Clear();
        }

        public static void AjouterUnBotAleatoirement()
        {
            int nombreAleatoire = rnd.Next(1, 4);
            switch (nombreAleatoire)
            {
                case 1:
                    //Joueurs.Add(new Bot1());
                    break;
                case 2:
                    //Joueurs.Add(new Bot2());
                    break;
                case 3:
                    //Joueurs.Add(new Bot3());
                    break;
            }
        }

        public static int ObtenirUnePositionAleatoire()
        {
            return rnd.Next(0, Joueurs.Count);
        }

        public static List<int> ObtenirPositionsLibres()
        {
            List<int> positionsLibres = new List<int>();
            for (int i = 0; i < Joueurs.Count; i++)
            {
                if (Joueurs[i] == null)
                    positionsLibres.Add(i);
            }
            return positionsLibres;
        }
    }
}
