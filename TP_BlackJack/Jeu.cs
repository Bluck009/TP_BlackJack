using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_BlackJack
{
    public class Jeu
    {
        private List<Carte> paquetCartes;

        private List<Joueur> joueurs;

        private Dealer dealer;

        private Random rnd = new Random();

        public List<Carte> PaquetCartes
        {
            get { return paquetCartes; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Le paquet de cartes ne peut pas être null");
                paquetCartes = value;
            }
        }

        public List<Joueur> Joueurs
        {
            get { return joueurs; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("La liste de joueurs ne peut pas être null");
                joueurs = value;
            }
        }

        public Dealer Dealer
        {
            get { return dealer; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Le dealer ne peut pas être null");
                dealer = value;
            }
        }

        public Jeu()
        {
            this.PaquetCartes = CreerPaquetCartes();
            this.Joueurs = new List<Joueur>();
            this.Dealer = dealer;
            BrasserCartes();
        }

        public void PigerUneCarteJoueur(Joueur joueur)
        {
            Carte carte = PaquetCartes[0];
            joueur.Main.Add(carte);
            PaquetCartes.RemoveAt(0);
        }

        public void PigerUneCarteDealer()
        {
            Carte carte = PaquetCartes[0];
            Dealer.Main.Add(carte);
            PaquetCartes.RemoveAt(0);
        }

        public List<Carte> CreerPaquetCartes()
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
        public void BrasserCartes() 
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

        public void DistribuerLesCartes()
        {
            foreach (Joueur joueur in Joueurs)
            {
                PigerUneCarteJoueur(joueur);
                PigerUneCarteJoueur(joueur);
            }
            PigerUneCarteDealer();
            PigerUneCarteDealer();
        }

        public void RecommencerPartie()
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

        public void ReinitialiserLesMains()
        {
            foreach (Joueur joueur in Joueurs)
            {
                joueur.Main.Clear();
            }
            Dealer.Main.Clear();
        }

        public void AjouterUnBotAleatoirement()
        {
            int position = ObtenirUnePositionAleatoire();
            Joueurs[position] = new Bot("Bot", "");
        }

        public int ObtenirUnePositionAleatoire()
        {
            return rnd.Next(0, Joueurs.Count);
        }

        public List<int> ObtenirPositionsLibres()
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
