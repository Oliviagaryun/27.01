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
        public Player player;
        public string text;
        public frm_hint(Player p1)
        {
            player = p1;
            InitializeComponent();


            if(player.GetTotal() < 17) 
            {
                text = "I think you should hit ;)";
            }else if(player.GetTotal() >= 17)
            {
                text = "You should stand! Your win rate: " + Convert.ToString(Blackjack_Data.ReadBlackJackData(player)) + "%";
            }

            txt_hint.Text = text;


        }

        private void Hint_TextChanged(object sender, EventArgs e)
        {
            double winRate = Blackjack_Data.ReadBlackJackData(player);
            Console.WriteLine("Win rate:", winRate );
        }

        private void frm_hint_Load(object sender, EventArgs e)
        {

        }

        private void Pb_yellow_Click(object sender, EventArgs e)
        {

        }
    }
}
