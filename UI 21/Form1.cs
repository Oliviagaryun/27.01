using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_21;

namespace UI_21
{
    public partial class Frm_Game : Form
    {
        public Frm_Game()
        {
            
            
            InitializeComponent();
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
            //fucntion stand
            // show dealer's hidden card
            // function winner
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
            // function hit
            // deal another card 
           // added to player value 
          
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // show card value
        }
    }
}
