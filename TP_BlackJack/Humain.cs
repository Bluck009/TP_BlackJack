using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_BlackJack
{
    public class Humain
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
                if (value == null)
                    throw new ArgumentNullException("La date de naissance ne peut pas être null");
                dateNaissance = value;
            }
        }

        public Humain(String name, String email, DateTime dateNaissance)
        {
            this.DateNaissance = dateNaissance;
        }
    }
}
