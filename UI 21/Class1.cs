using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_21
{
    internal class Game
    {
        public class Card
        {
            private string face; // ace -> K
            private string suit; // hearts,clubs,diamonds,spades
            private string location; //location of the card image

            public Card(string cardFace, string cardSuit, string Location)
            {// constructor 
                this.face = cardFace;
                this.suit = cardSuit;
                this.location = Location;
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
                string path = "/Users/Olivi/Desktop/UI 21/UI 21/bin/Debug/net6.0-windows/zh/Cards";
                List<Card> deck = new List<Card>();
                currentCard = 0;
                
                //Made a loop to loop through each file in my image folder of cards
                foreach(string image in Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories)) 
                {
                    string filename = Path.GetFileName(image);
                    string[] SplitFilenameThing = filename.Split("_of_");
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

        }
    }
}

