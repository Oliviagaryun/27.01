using ADOX;
using Microsoft.VisualBasic.Logging;
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

        public int playercardcount;
        public int dealercardcount;

        public int[] playerlocations = new int[]{363, 389, 413};
        public int[] dealerlocations = new int[] {385, 411, 437, 462 };


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

            playercardcount = game.player.Hand.Count();
            dealercardcount = game.dealer.Hand.Count();

            
            SetUp();
        }

        public void Stand() 
        {
            game.stand();

            for(int i = 1; i < game.dealer.Hand.Count(); i++) 
            {
                Card dealercard = game.dealer.Hand[i];
                PictureBox newcardpic = new PictureBox();
                newcardpic.SizeMode = PictureBoxSizeMode.StretchImage;
                newcardpic.Width = 97;
                newcardpic.Height = 162;
                newcardpic.Location = new Point(dealerlocations[i - 1], 3);
                newcardpic.Image = Image.FromFile(GetCardImagePath(dealercard));
                this.Controls.Add(newcardpic);

            }

            //game.DetermineWinner();
        }

        public void SetUp()  
        {
            game.deck.Shuffle();

            game.CardSetUp();
            //Set two cards for player
            Card plyrcard1 = game.player.Hand[0];
            PictureBox newcardpic = new PictureBox();
            newcardpic.SizeMode = PictureBoxSizeMode.StretchImage;
            newcardpic.Width = 97;
            newcardpic.Height = 162;
            newcardpic.Location = new Point(310, 292);
            newcardpic.Image = Image.FromFile(GetCardImagePath(plyrcard1));
            this.Controls.Add(newcardpic);

            Card plyrcard2 = game.player.Hand[1];
            PictureBox newcardpic1 = new PictureBox();
            newcardpic1.SizeMode = PictureBoxSizeMode.StretchImage;
            newcardpic1.Width = 97;
            newcardpic1.Height = 162;
            newcardpic1.Location = new Point(310 + 26, 292);
            newcardpic1.Image = Image.FromFile(GetCardImagePath(plyrcard2));
            this.Controls.Add(newcardpic1);


            //set one card for dealer
            Card dealercard1 = game.dealer.Hand[0];
            PictureBox newcardpic2 = new PictureBox();
            newcardpic2.SizeMode = PictureBoxSizeMode.StretchImage;
            newcardpic2.Width = 97;
            newcardpic2.Height = 162;
            newcardpic2.Location = new Point(359, 3);
            newcardpic2.Image = Image.FromFile(GetCardImagePath(dealercard1));
            this.Controls.Add(newcardpic2);
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
            Stand();
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

            //update player card deck
            if(game.player.Hand.Count() - 2 > playercardcount) 
            {
                int loc = playerlocations[playercardcount];
                Card playercard = game.player.Hand[playercardcount];
                PictureBox newcardpic = new PictureBox();
                newcardpic.SizeMode= PictureBoxSizeMode.StretchImage;
                newcardpic.Width = 97;
                newcardpic.Height = 162;
                newcardpic.Location = new Point(loc, 292);
                newcardpic.Image = Image.FromFile(GetCardImagePath(playercard));
                this.Controls.Add(newcardpic);
                playercardcount++;
            }

            //update dealer card eck

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

                    //for (int i = 0; i < player.Hand.Length; i++)
                    //{
                    //    // Access the element at index i in the array
                    //    int element = player.Hand[i];

                    //    // Do something with the element

                    //    Image cardImage = player.Hand[i].Image;
                    //}


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
