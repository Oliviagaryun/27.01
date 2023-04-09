using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_21
{
    public partial class frm_hint : Form
    {
        Player player;
        public frm_hint(Player p1)
        {
            player = p1;
            InitializeComponent();
        }

        private void Hint_TextChanged(object sender, EventArgs e)
        {
            double winRate = Blackjack_Data.ReadBlackJackData(player);
            Console.WriteLine("Win rate:", winRate );
        }

        private void frm_hint_Load(object sender, EventArgs e)
        {

        }
    }
}
