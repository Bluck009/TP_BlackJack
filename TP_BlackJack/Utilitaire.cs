using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace TP_BlackJack
{
    public class Utilitaire
    {
        public static bool ValiderChaineObligatoire(String p_chaine)
        {
            bool chaineOk = true;
            if (String.IsNullOrWhiteSpace(p_chaine))
            {
                chaineOk = false;
            }
            return chaineOk;
        }

        public static bool ValiderEmail(String p_email)
        {
            try
            {
                MailAddress m = new MailAddress(p_email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
