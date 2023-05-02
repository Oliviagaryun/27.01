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

        private int x; // the target x 
        private int y; // the target y 
        private int dx; // the change in x 
        private int dy; // the change in y 

        public List<PictureBox> pictureBoxes = new List<PictureBox>();
        public List<System.Windows.Forms.Timer> Timers = new List<System.Windows.Forms.Timer>();


        public int playercardcount;
        public int dealercardcount;

        public int[] playerlocations = new int[] { 363, 389, 413 };
        public int[] dealerlocations = new int[] { 385, 411, 437, 462 };

        public bool result;
        private System.Windows.Forms.Timer timer;
        private PictureBox lastPictureBox;

        bool start;


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
            lbl_TotalBet.Text = "Bet: " + "$" + Convert.ToString(bet);


            

            start = false;

          

            
        }
       


        public PictureBox AnimateLastPictureBox(int x, int y)
        {
            // find the last picturebox in the list of controls
            lastPictureBox = pictureBoxes.Last();


            // set the initial location of the picturebox to (164, 41)
            lastPictureBox.Location = new System.Drawing.Point(164, 41);

            Timers.Add(new System.Windows.Forms.Timer());
            Timers.Last().Interval = 10;
            Timers.Last().Tick += new EventHandler(timer_Tick);

           

            // set the target location of the picturebox to (x, y)
            this.x = x;
            this.y = y;

            // calculate the change in x and y per tick based on the distance and duration
            // assuming the duration is 1000 milliseconds
            int distanceX = x - 164;
            int distanceY = y - 41;
            int duration = 1000;
            dx = distanceX / (duration / Timers.Last().Interval);
            dy = distanceY / (duration / Timers.Last().Interval);

            



            // return the final picturebox with the new location
            return lastPictureBox;
        }
         // a method that handles the timer tick event
        private void timer_Tick(object sender, EventArgs e)
        {
            // get the current location of the picturebox
            int currentX = lastPictureBox.Location.X;
            int currentY = lastPictureBox.Location.Y;

            // check if the picturebox has reached the target location or not
            if (currentX == x && currentY == y)
            {
                // stop the timer and exit
                Timers.Last().Stop();
                Timers.RemoveAt(Timers.Count - 1);
                return;
            }

            // update the location of the picturebox by adding dx and dy
            currentX += dx;
            currentY += dy;

            // make sure the location does not exceed the target location
            if (dx > 0 && currentX > x || dx < 0 && currentX < x)
            {
                currentX = x;
            }

            if (dy > 0 && currentY > y || dy < 0 && currentY < y)
            {
                currentY = y;
            }

            // set the new location of the picturebox
            lastPictureBox.Location = new System.Drawing.Point(currentX, currentY);
        }




        public void Stand()
        {
            game.stand();

            for (int i = 1; i < game.dealer.Hand.Count(); i++)
            {
                Card dealercard = game.dealer.Hand[i];
                PictureBox newcardpic = new PictureBox();
                newcardpic.SizeMode = PictureBoxSizeMode.StretchImage;
                newcardpic.Width = 97;
                newcardpic.Height = 162;
                newcardpic.Location = new Point(164, 41);
                newcardpic.Image = Image.FromFile(GetCardImagePath(dealercard));

                pictureBoxes.Add(newcardpic);
                pictureBoxes.Last().BringToFront();
                this.Controls.Add(pictureBoxes.Last());
                pictureBoxes[pictureBoxes.Count() - 1] = AnimateLastPictureBox(dealerlocations[i - 1], 3);
                
                

            }

            LBL_DealerTotal.Text = "Dealer: " + Convert.ToString(game.dealer.GetTotal());

            bool win = game.DetermineWinner(game.player, game.dealer);
            if (win)
            {
                Frm_win_msg winner = new Frm_win_msg();
                winner.ShowDialog();
                result = win;
                Frm_Betting betting = new Frm_Betting(result, bet);
                betting.ShowDialog();
                this.Close();
            }
            else
            {
                Frm_lose_msg loser = new Frm_lose_msg();
                loser.ShowDialog();
                result = win;
                Frm_Betting betting = new Frm_Betting(result, bet);
                betting.ShowDialog();
                this.Close();

            }
        }

        public void AddCardToForm(PictureBox card, int x, int y)
        {
            pictureBoxes.Add(card);
            pictureBoxes.Last().BringToFront();
            this.Controls.Add(pictureBoxes.Last());
            pictureBoxes[pictureBoxes.Count() - 1] = AnimateLastPictureBox(x, y);

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
            newcardpic.Location = new Point(164, 41);
            newcardpic.Image = Image.FromFile(GetCardImagePath(plyrcard1));
            AddCardToForm(newcardpic, 310, 292);

            Timers.Last().Start();

            



            Card plyrcard2 = game.player.Hand[1];
            PictureBox newcardpic1 = new PictureBox();
            newcardpic1.SizeMode = PictureBoxSizeMode.StretchImage;
            newcardpic1.Width = 97;
            newcardpic1.Height = 162;
            newcardpic1.Location = new Point(164, 41);
            newcardpic1.Image = Image.FromFile(GetCardImagePath(plyrcard2));

            AddCardToForm(newcardpic1, 336, 292);
            Timers.Last().Start();




            //set one card for dealer
            Card dealercard1 = game.dealer.Hand[0];
            PictureBox newcardpic2 = new PictureBox();
            newcardpic2.SizeMode = PictureBoxSizeMode.StretchImage;
            newcardpic2.Width = 97;
            newcardpic2.Height = 162;
            newcardpic2.Location = new Point(164, 41);
            newcardpic2.Image = Image.FromFile(GetCardImagePath(dealercard1));

            
            AddCardToForm(newcardpic2, 359, 3);
            Timers.Last().Start();




            lbl_cardVal.Text = Convert.ToString(game.player.GetTotal());
            LBL_DealerTotal.Text = "Dealer: " + Convert.ToString(game.dealer.GetTotal());

            
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


            //string Bet = Frm_Betting.Bet.ToString();
            // lbl_TotalBet.Text = "$" + Bet;
        }





        private void Btn_Hit_Click(object sender, EventArgs e)
        {

            game.Hit();

            // call function hit 

            //update player card deck
            if (game.player.Hand.Count() - 2 > playercardcount)
            {
                int loc = playerlocations[playercardcount];
                Card playercard = game.player.Hand[playercardcount + 2];
                PictureBox newcardpic = new PictureBox();
                newcardpic.SizeMode = PictureBoxSizeMode.StretchImage;
                newcardpic.Width = 97;
                newcardpic.Height = 162;
                newcardpic.Location = new Point(164, 41);
                newcardpic.Image = Image.FromFile(GetCardImagePath(playercard));

                pictureBoxes.Add(newcardpic);
                pictureBoxes.Last().BringToFront();
                this.Controls.Add(pictureBoxes.Last());
                pictureBoxes[pictureBoxes.Count() - 1] = AnimateLastPictureBox(loc, 292);
              
                playercardcount++;
            }
            lbl_cardVal.Text = Convert.ToString(game.player.GetTotal());

            if (game.player.GetTotal() > 21)
            {
                //player loses, dealer wins

                Frm_lose_msg loser = new Frm_lose_msg();
                loser.ShowDialog();
                result = false;
                Frm_Betting betting = new Frm_Betting(result, bet);
                betting.ShowDialog();
                this.Close();

            }



            //update dealer card deck

        }

        private void lbl_PlayerTotal(object sender, EventArgs e)
        {
            //made another temp player, you can remove this once you make a public player that all these functions can access

            //converted the total to string so it can be put in lbl_cardVal.text

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
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox)
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

        private void LBL_DealerTotal_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            SetUp();
            start = true;
        }
    }

}
