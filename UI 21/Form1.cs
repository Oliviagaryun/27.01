using ADOX;
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
using static UI_21.Frm_Game;

namespace UI_21
{

    public partial class Frm_Game : Form
    {

        Game game;
        public Player player;
        public Dealer dealer;
        public Deck deck;
        public int bet;

        public Frm_Game(Player player1, int Bet)
        {


            InitializeComponent();
            
            //NEW INSTANCE OF DEALER 
            //NOT dealer = dealer
            dealer = new Dealer();
            player = player1;
            deck = new Deck();
            game = new Game();
            bet = Bet;
        }

        private void Btn_Return_Click(object sender, EventArgs e)
        {

            this.Hide();
            Frm_Betting form1 = new Frm_Betting();// take to betting form 
            form1.ShowDialog();
            this.Close();
        }

        private void btn_stand(object sender, EventArgs e)
        {
            
            // game to continue. show dealers hidden card and determine winner 
            //Class1.DetermineWinner();
            
           
        }
        public bool returnResult()
            {
            return game.DetermineWinner(player, dealer);// returns true or false.
        }


        private void lbl_TotalBet_Click(object sender, EventArgs e)
        {  
            lbl_TotalBet.Text = "$" + Convert.ToString(bet);

            //string Bet = Frm_Betting.Bet.ToString();
            // lbl_TotalBet.Text = "$" + Bet;
        }
        

        

        
        private void Btn_Hit_Click(object sender, EventArgs e)
        {
            
            game.Hit();
            // call function hit 

        }

        private void lbl_PlayerTotal(object sender, EventArgs e)
        {
            //made another temp player, you can remove this once you make a public player that all these functions can access
            Player TEMPplayer = new Player();
            
            //converted the total to string so it can be put in lbl_cardVal.text
            lbl_cardVal.Text = Convert.ToString(TEMPplayer.GetTotal());
        }

        private void BackofCard(object sender, EventArgs e)
        {

        }

        private void Pb_DealtCard1_Click(object sender, EventArgs e)
        {
            
          
        }

        private void Frm_Game_Load(object sender, EventArgs e)
        {

        }

        private void btn_hint_Click(object sender, EventArgs e) // this needs to be tested 
        {
            frm_hint form1 = new frm_hint(player);// take to hint form 
            form1.ShowDialog();
            this.Close();
        }

        private void Pb_DealtCard2_Click(object sender, EventArgs e)
        {
            SetPictureBoxes();
        }

        private void Pb_DealtCard3_Click(object sender, EventArgs e)
        {
            SetPictureBoxes();
        }

        private void Pb_DealtCard4_Click(object sender, EventArgs e)
        {
            SetPictureBoxes();
        }

        private void Pb_DealtCard5_Click(object sender, EventArgs e)
        {
            SetPictureBoxes();
        }

        private void Pb_Dealer_DealtCard5_Click(object sender, EventArgs e)
        {
            SetPictureBoxes();
        }

        public string GetCardImagePath(Card chosencard) 
        {
            string cardpath = "";

            foreach (var CardImage in game.deck.CardImages)
            {
                if (CardImage.Key.Equals(chosencard))
                {
                    cardpath = CardImage.Value;
                    break;
                }
            }

            return cardpath;

        }

        //testmethod
        public void SetPictureBoxes() 
        {
            //iterate through all elements on the form, if it is a picture box, adds a random picture
            foreach(Control c in this.Controls) 
            {
                if(c is PictureBox) 
                {
                    Random random = new Random();
                    int x = random.Next(1, 50);
                    Card RandCard = game.deck.Cards[x];
                    PictureBox Card = c as PictureBox;

                    Card.Image = Image.FromFile(GetCardImagePath(RandCard));

                    for (int i = 0; i < player.Hand.Length; i++)
                    {
                        // Access the element at index i in the array
                        int element = player.Hand[i];

                        // Do something with the element

                        Image cardImage = player.Hand[i].Image;
                    }


                }
            }
            
        }

        private void Pb_Dealer_DealtCard1_Click(object sender, EventArgs e)
        {
            SetPictureBoxes();
        }

        private void Pb_Dealer_DealtCard4_Click(object sender, EventArgs e)
        {
            SetPictureBoxes();
        }

        private void Pb_Dealer_DealtCard3_Click(object sender, EventArgs e)
        {
            SetPictureBoxes();
        }

        private void Pb_Dealer_DealtCard2_Click(object sender, EventArgs e)
        {
            SetPictureBoxes();
        }
    }
}
