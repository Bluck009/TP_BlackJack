using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TP_BlackJack
{
    public static class Utilitaire
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

        public static int[] GenererSequence(int p_premiereValeur, int p_derniereValeur)
        {
            int[] tableauValeurs = new int[p_derniereValeur - p_premiereValeur + 1];
            for (int i = 0; i < tableauValeurs.Length; i++)
            {
                tableauValeurs[i] = p_premiereValeur + i;
            }
            return tableauValeurs;
        }

        //public static int[] MelangerNombre(int[] p_nombre)
        //{
        //    Random rnd = new Random();
        //    for (int i = 0; i < p_nombre.Length - 1; i++)
        //    {
        //        int j = rnd.Next(i, p_nombre.Length);
        //        int temp = p_nombre[i];
        //        p_nombre[i] = p_nombre[j];
        //        p_nombre[j] = temp;
        //    }
        //    return p_nombre;
        //}

    }
}
