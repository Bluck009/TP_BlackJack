using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_BlackJack.Properties;

namespace TP_BlackJack
{
    public partial class FrmBlackjack : Form
    {
        private Graphics graphics;
        private readonly Point[] POSITIONS_CARTE = { new Point(455, 35), new Point(730, 280), new Point(563, 410) };

        public Graphics Graphics
        {
            get { return graphics; }
            set { graphics = value; }
        }

        public FrmBlackjack()
        {
            InitializeComponent();
        }


    }
}
