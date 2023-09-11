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
            if (PaquetCartes.Count == 0)
                throw new InvalidOperationException("Le paquet de cartes est vide");
            else if (PaquetCartes.Count > 0)
            {
                joueur.AjouterCarte(PaquetCartes[0]);
                PaquetCartes.RemoveAt(0);
            }
        }

        public void PigerUneCarteDealer()
        {
            if (PaquetCartes.Count == 0)
                throw new InvalidOperationException("Le paquet de cartes est vide");
            else if (PaquetCartes.Count > 0)
            {
                Dealer.AjouterCarte(PaquetCartes[0]);
                PaquetCartes.RemoveAt(0);
            }
        }


        public List<Carte> CreerPaquetCartes()
        {
            List<Carte> paquetCartes = new List<Carte>();
            foreach (Couleur couleur in Enum.GetValues(typeof(Couleur)))
            {
                foreach (Valeur valeur in Enum.GetValues(typeof(Valeur)))
                {
                    paquetCartes.Add(new Carte(couleur, valeur));
                }
            }
            return paquetCartes;
        }

        public void BrasserCartes()
        {
            int carteBrassees = PaquetCartes.Count;
            while (carteBrassees > 1)
            {
                carteBrassees--;
                int carteAleatoire = rnd.Next(carteBrassees + 1);
                Carte value = PaquetCartes[carteAleatoire];
                PaquetCartes[carteAleatoire] = PaquetCartes[carteBrassees];
                PaquetCartes[carteBrassees] = value;
            }
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
            int nombreAleatoire = rnd.Next(1, 4);
            switch (nombreAleatoire)
            {
                case 1:
                    Joueurs.Add(new Bot1());
                    break;
                case 2:
                    Joueurs.Add(new Bot2());
                    break;
                case 3:
                    Joueurs.Add(new Bot3());
                    break;
            }
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
