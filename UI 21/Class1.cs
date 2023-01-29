using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static UI_21.Game;

namespace UI_21
{
    internal class Game
    {
        public class Card
        {
            private string face; // ace -> K
            private string suit; // hearts,clubs,diamonds,spades
            private string location; //location of the card image
            private int Value;

            public Card(string cardFace, string cardSuit, string Location)
            {// constructor 
                this.face = cardFace;
                this.suit = cardSuit;
                this.location = Location;
                this.Value = 0;
                /*switch (cardFace)
                {
                    case "Ace":
                        this.value = 11;
                        break;
                    case "Jack":
                    case "Queen":
                    case "King":
                        this.value = 10;
                        break;
                    default:
                        this.value = int.Parse(cardFace);
                        break;
                }
            }
            public int value
            {
                get { return this.value; }
                set { this.value = value; }
            }
                */
            }
        }
        public class Deck
        {
            private Card[] deck;
            private int currentCard;

            private int totalCards = 52;
            private Random RanNum = new Random();

            public Deck()
            {
                string[] face = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
                string[] suit = { "hearts", "clubs", "Diamonds", "spades" };
                string path = "cards/Playing Cards/PNG-cards-1.3";
                List<Card> deck = new List<Card>();
                currentCard = 0;

                //Made a loop to loop through each file in my image folder of cards
                foreach (string image in Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories))
                {
                    string filename = Path.GetFileNameWithoutExtension(image);
                    string[] SplitFilenameThing = new string[2];
                    //had to compensate for the red joker
                    if (filename != "red_joker") { SplitFilenameThing = filename.Split("_of_"); } else { SplitFilenameThing = filename.Split("_"); }

                    string tempface = SplitFilenameThing[0];
                    string tempCard = SplitFilenameThing[1];
                    Card card = new Card(tempface, tempCard, image);
                    deck.Add(card);

                }
                // deck.Add(new Card(face[count % 11], suit[count / 13]);
                Shuffle(deck);
                //deck.Remove(someCard);
                //deck.ForEach(card => Console.WriteLine(card.ToString()));
                // deck location starts a 0 

            }

            public void Shuffle(List<Card> deck)
            {
                Random rng = new Random();
                for (int i = 0; i < deck.Count; i++)
                {
                    int randomIndex = rng.Next(deck.Count);
                    Card temp = deck[i];
                    deck[i] = deck[randomIndex];
                    deck[randomIndex] = temp;
                }
            }
            public void Deal(Player player, Dealer dealer)
            {
                player.Cards.Add(deck[currentCard]);
                currentCard++;
                player.Cards.Add(deck[currentCard]);
                currentCard++;
                dealer.Cards.Add(deck[currentCard]);
                currentCard++;

                // need to give cards their totals and add to int
            }
            public void Hit(Player player, Dealer dealer)
            {
                player.Cards.Add(deck[currentCard]);
                currentCard++;

            }
            public void Stand(Player player, Dealer dealer)
            {
                // if dealers card total  <17
                dealer.Cards.Add(deck[currentCard]);
                currentCard++;

            }
            public void DetermineWinner(Player player, Dealer dealer)
            {
                int playerTotal = 0;
                int dealerTotal = 0;

                foreach (Card card in player.Cards)
                {
                    playerTotal += card.Value;
                }
                foreach (Card card in dealer.Cards)
                {
                    dealerTotal += card.Value;
                }

                if (playerTotal > 21)
                {
                    Console.WriteLine("Player busts, dealer wins.");
                    Bank = Bank - bet;
                }
                else if (dealerTotal > 21)
                {
                    Console.WriteLine("Dealer busts, player wins.");
                    Bank = Bank + bet * 2;
                }
                else if (dealerTotal > playerTotal)
                {
                    Console.WriteLine("Dealer wins.");
                    Bank = Bank - bet;
                }
                else if (playerTotal > dealerTotal)
                {
                    Console.WriteLine("Player wins.");
                    Bank = Bank + bet * 2;
                }
                else
                {
                    Console.WriteLine("Draw.");

                }
            }
            private int Bank = 1500;
            private int bet = 0;

            public void Bet(int bet)
            {
                if (bet <= Bank)
                {
                    Bank -= bet;
                }
                else
                {
                    Console.WriteLine("Insufficient funds. Please enter a lower bet amount.");
                }
            }
        }

        public class Player
        {
            public List<Card> Cards { get; set; }

            public Player()
            {
                Cards = new List<Card>();
            }
        }
        public class Dealer
        {
            public List<Card> Cards { get; set; }

            public Dealer()
            {
                Cards = new List<Card>();
            }
        }
    }
}



