using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_BlackJack
{
    public class Humain : Joueur
    {
        private bool terminerJouer;

        private DateTime dateNaissance;

        public bool TerminerJouer
        {
            get { return terminerJouer; }
            set { terminerJouer = value; }
        }

        public DateTime DateNaissance
        {
            get { return dateNaissance; }
            set
            {
                //if (value is not null)
                    dateNaissance = value;
                //else
                    //throw new ArgumentNullException("La date de naissance ne peut pas être null");
            }
        }

        public Humain(String name, String email, DateTime dateNaissance) : base (name, email)
        {
            this.DateNaissance = dateNaissance;
        }
    }
}
