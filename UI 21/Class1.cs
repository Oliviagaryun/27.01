using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Office.Interop.Excel; // to read and write into excel file 


namespace UI_21
{
    class Card
    {
        public string Rank { get; set; }
        public string Suit { get; set; }
        public int Value { get; set; }

        public Card(string rank, string suit, int value)
        {
            Rank = rank;
            Suit = suit;
            Value = value;
        }
    }

    class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();
            string[] suits = { "Hearts", "Diamonds", "Spades", "Clubs" };
            string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            int[] values = { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };
            string path = "cards/Playing Cards/PNG-cards-1.3";
            foreach (string image in Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories))
            {
                string filename = Path.GetFileNameWithoutExtension(image);
                string[] SplitFilenameThing = new string[2];
                //had to compensate for the red joker
                if (filename != "red_joker") { SplitFilenameThing = filename.Split("_of_"); } else { SplitFilenameThing = filename.Split("_"); }

                string tempface = SplitFilenameThing[0];
                string tempCard = SplitFilenameThing[1];
                Card card = new Card(tempface, tempCard, image);
                Cards.Add(card);



                for (int i = 0; i < suits.Length; i++)
                {
                    for (int j = 0; j < ranks.Length; j++)
                    {
                        Card cards = new Card(ranks[j], suits[i], values[j]);
                        Cards.Add(card);
                    }
                }
            }

            public void Shuffle()
            {
                List<Card> newDeck = new List<Card>();
                Random random = new Random();
                while (Cards.Count > 0)
                {
                    int index = random.Next(Cards.Count);
                    newDeck.Add(Cards[index]);
                    Cards.RemoveAt(index);
                }
                Cards = newDeck;
            }
        }

        class Player
        {
            public List<Card> Hand { get; set; }

            public Player()
            {
                Hand = new List<Card>();
            }

            public void Draw(Deck deck)
            {
                Hand.Add(deck.Cards[0]);
                deck.Cards.RemoveAt(0);
            }

            public int GetTotal()
            {
                int total = 0;
                foreach (var card in Hand)
                {
                    total += card.Value;
                }
                return total;
            }
        }

        class Dealer
        {
            public List<Card> Hand { get; set; }

            public Dealer()
            {
                Hand = new List<Card>();
            }

            public void Draw(Deck deck)
            {
                Hand.Add(deck.Cards[0]);
                deck.Cards.RemoveAt(0);
            }

            public int GetTotal()
            {
                int total = 0;
                foreach (var card in Hand)
                {
                    total += card.Value;
                }
                return total;
            }
        }

        class Game
        {// Create instances of the deck, player, and dealer classes
            public Deck Deck { get; set; }
            public Player Player { get; set; }
            public Dealer Dealer { get; set; }
            public int Bet { get; set; }

            public Game()
            {
                Deck = new Deck();
                Player = new Player();
                Dealer = new Dealer();
            }

            public void Setup()
            {
                Shuffle(Card);

                //Console.WriteLine("Enter your bet: ");
                //Bet = Convert.ToInt32(Console.ReadLine());

                // Draw two cards for the player and two cards for the dealer
                Player.Draw(Deck);
                Player.Draw(Deck);

                Dealer.Draw(Deck);
                Dealer.Draw(Deck);

                // Display the player's cards
                Console.WriteLine("Your cards are: ");
                foreach (var card in Player.Hand)
                {
                    Console.WriteLine(card.Rank + " of " + card.Suit);
                }
                Console.WriteLine("Your total is: " + Player.GetTotal());

                // Display the dealer's first card and one hidden card
                Console.WriteLine("Dealer's cards are: ");
                Console.WriteLine(Dealer.Hand[0].Rank + " of " + Dealer.Hand[0].Suit);
                Console.WriteLine("Hidden card");
                /*
                while (Player.GetTotal() < 21)
                {
                    Console.WriteLine("Do you want to hit or stand?");
                    string action = Console.ReadLine().ToLower();
                    if (action == "hit")
                    {
                        Player.Draw(Deck);
                        Console.WriteLine("Your cards are: ");
                        foreach (var card in Player.Hand)
                        {
                            Console.WriteLine(card.Rank + " of " + card.Suit);
                        }
                        Console.WriteLine("Your total is: " + Player.GetTotal());
                    }
                    else if (action == "stand")
                    {
                        break;
                    }
                }
            }
                */
            }

            public void Hit()
            {
                Player.Draw(Deck);
                Console.WriteLine("Your cards are: ");
                foreach (var card in Player.Hand)
                {
                    Console.WriteLine(card.Rank + " of " + card.Suit);
                    // call corresponding image 

                }
                Console.WriteLine("Your total is: " + Player.GetTotal());
            }


            public void DetermineWinner()
            {
                bool win = false;
                Console.WriteLine("Dealer's cards are: ");
                foreach (var card in Dealer.Hand)
                {
                    Console.WriteLine(card.Rank + " of " + card.Suit);
                }
                Console.WriteLine("Dealer's total is: " + Dealer.GetTotal());

                if (Player.GetTotal() > 21)
                {
                    Console.WriteLine("You lose!");
                    // bool win is false 

                }
                else if (Dealer.GetTotal() > 21)
                {
                    Console.WriteLine("Dealer busts! You win!");
                    Console.WriteLine("You win " + (Bet * 2) + " chips.");
                    win = true;
                }
                else if (Dealer.GetTotal() < Player.GetTotal())
                {
                    Console.WriteLine("You win!");
                    Console.WriteLine("You win " + (Bet * 2) + " chips.");
                    win = true;
                }
                else
                {
                    Console.WriteLine("You lose!");
                    // bool win is false 
                }

            }

        }

    }


}
/* SEUN: idk where this should go. 
 this should create a new excel file which will record the data of each game 
Excel.Application excelApp = new Excel.Application();

// create a new workbook
Excel.Workbook workbook = excelApp.Workbooks.Add();
//first sheet
Excel.Worksheet worksheet = workbook.Sheets[1];
 int row = 1
// headers 
worksheet.Cells[row, 1] = "Player Name";
worksheet.Cells[row, 2] = "Player Total";
worksheet.Cells[row, 3] = "Dealer Total";
worksheet.Cells[row1, 4] = "Win";
 int row++; 

// write the data to subsequent rows ( idk if this would work ) 
worksheet.Cells[row, 1] = playerName;
worksheet.Cells[row, 2] = Player.GetTotal();
worksheet.Cells[row, 3] = Dealer.GetTotal();
worksheet.Cells[row, 4] = win;

// save the workbook
workbook.SaveAs("BlackjackHands.xlsx");

// close the workbook and Excel application
workbook.Close();
excelApp.Quit();
*/