using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_21;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static UI_21.Game;

namespace UI_21
{

    public partial class Frm_Game : Form
    {

        Game game;
        public Player player;
        public Dealer dealer;

        public Frm_Game(Player player1)
        {


            InitializeComponent();
            dealer = dealer;
            player = player1;
        }

        private void Btn_Return_Click(object sender, EventArgs e)
        {

            this.Hide();
            Frm_Betting form1 = new Frm_Betting();
            form1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            Game game = new Game();


           
        }
        public bool returnResult()
            {
            return game.DetermineWinner(player, dealer);// returns true or false.
        }


        private void lbl_TotalBet_Click(object sender, EventArgs e)
        {
            //lbl_TotalBet.Text = "$" + Bet.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // give  a hint 

        }

        
        private void Btn_Hit_Click(object sender, EventArgs e)
        {
            Game G1 = new Game();
            G1.Hit();
            // call function hit 

        }

        private void label2_Click(object sender, EventArgs e)
        {
            //made another temp player, you can remove this once you make a public player that all these functions can access
            Player TEMPplayer = new Player();
            
            //converted the total to string so it can be put in lbl_cardVal.text
            lbl_cardVal.Text = Convert.ToString(TEMPplayer.GetTotal());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Pb_DealtCard1_Click(object sender, EventArgs e)
        {

        }
    }
}
