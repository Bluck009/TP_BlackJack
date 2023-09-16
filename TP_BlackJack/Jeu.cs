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
            Joueurs = new List<Joueur>();
            Dealer = new Dealer(0, Sorte.Coeur);
            BrasserCartes();
            DistribuerLesCartes();
        }

        public static void PigerUneCarteJoueur(Joueur joueur)
        {
            Carte carte = PaquetCartes[0];
            joueur.Main.Add(carte);
            PaquetCartes.RemoveAt(0);
        }

        public static void PigerUneCarteDealer()
        {
            Carte carte = PaquetCartes[0];
            Dealer.Main.Add(carte);
            PaquetCartes.RemoveAt(0);
        }

        public static List<Carte> CreerPaquetCartes()
        {
            List<Carte> paquetCartes = new List<Carte>();
            foreach (Sorte sorte in Enum.GetValues(typeof(Sorte)))
            {
                for (int i = 1; i <= 13; i++)
                {
                    paquetCartes.Add(new Carte(i, sorte));
                }
            }
            return paquetCartes;
        }

        //voir pour modifier si besoin avec les méthodes
        //la classe utilitaire GenererSequence() et MelangerNombre()
        public static void BrasserCartes()
        {
            List<Carte> paquetCartesBrasse = new List<Carte>();
            while (PaquetCartes.Count > 0)
            {
                int position = rnd.Next(0, PaquetCartes.Count);
                paquetCartesBrasse.Add(PaquetCartes[position]);
                PaquetCartes.RemoveAt(position);
            }
            PaquetCartes = paquetCartesBrasse;
        }

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
            int position = ObtenirUnePositionAleatoire();
            Joueurs[position] = new Bot("Bot", "");
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
