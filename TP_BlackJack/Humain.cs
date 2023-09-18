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
<<<<<<< HEAD
                if (value == null)
                {
                    throw new ArgumentNullException("La date de naissance ne peut pas être null");
                }
                if (DateTime.Now.Year - value.Year < 18 || 
                    (DateTime.Now.Year - value.Year == 18 && DateTime.Now.DayOfYear < value.DayOfYear))
                {
                    throw new ArgumentOutOfRangeException("Le joueur doit avoir 18 ans ou plus.");
                } 
                dateNaissance = value;
            }
        }

        public Humain(String p_nom, String p_email, DateTime dateNaissance) : base(p_nom, p_email)
=======
                //if (value is not null)
                    dateNaissance = value;
                //else
                    //throw new ArgumentNullException("La date de naissance ne peut pas être null");
            }
        }

        public Humain(String name, String email, DateTime dateNaissance) : base (name, email)
>>>>>>> luc
        {
            this.DateNaissance = dateNaissance;
        }
    }
}
