using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel; // to read and write into excel file
using System.IO;


namespace UI_21
// TS complete, added descriptive comments 
{
    public class Card
    {
        // Properties of a card
        public string Rank { get; set; }
        public string Suit { get; set; }
        public int Value { get; set; }

        public Card(string rank, string suit, int value)
        {
            Rank = rank;
            Suit = suit;
            Value = value;
        }

        // Function to check if a card is equal to another one
        public bool Equals(Card otherCard)
        {
            return this.Rank == otherCard.Rank && this.Suit == otherCard.Suit && this.Value == otherCard.Value;
        }



        
    }

    public class Deck
    {
        // List of cards in the deck
        public List<Card> Cards { get; set; }
        // Dictionary that stores the path to the image file for each card
        public Dictionary<Card, string> CardImages = new Dictionary<Card, string>();

        public Deck()
        {
            Cards = new List<Card>();
            // String arrays with the suits, ranks and values of the cards
            string[] suits = { "Hearts", "Diamonds", "Spades", "Clubs" };
            string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };
            string path = "cards/Playing Cards/PNG-cards-1.3";

            //Create a card for each suit and rank and add it to the list of cards
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < ranks.Length; j++)
                {
                    Card card = new Card(ranks[j], suits[i], values[j]);
                    Cards.Add(card);
                }
            }

            // Associate the image file with each card
            foreach (string image in Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories))
            {
                string filename = Path.GetFileNameWithoutExtension(image);
                string[] SplitFilenameThing = new string[2];
                SplitFilenameThing = filename.Split("_");

                string tempRank = SplitFilenameThing[0];
                string tempSuit = SplitFilenameThing[2];

                //for every file, goes through the made list of cards, when it find the right card with the right suit and rank, it adds that card to a dictionary
                foreach (var card in Cards)
                {
                    //checks the rank and suit before adding the card, converts to lower to make sure all the characters are the same
                    if (tempRank.ToLower() == card.Rank.ToLower())
                    {
                        if (tempSuit.ToLower() == card.Suit.ToLower())
                        {
                            CardImages.Add(card, image);

                        }
                    }
                }


            }


        }
        // Shuffle the cards in the deck randomly
        public void Shuffle()
        {
            List<Card> newDeck = new List<Card>();
            //var NewCardImages = new Dictionary<Card, string>();
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
    public class Player
    {
        public List<Card> Hand { get; set; } // List of cards in the player's hand

        public Player()
        {
            Hand = new List<Card>();
        }

        public Deck Draw(Deck deck) // // Draw a card from the deck and add it to the player's hand

        {
            Hand.Add(deck.Cards[0]);
            deck.Cards.RemoveAt(0);
            return deck;
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

    public class Dealer
    {
        public List<Card> Hand { get; set; }

        public Dealer()
        {
            Hand = new List<Card>();
        }

        public Deck Draw(Deck deck)
        {
            Hand.Add(deck.Cards[0]);
            deck.Cards.RemoveAt(0);
            return deck;
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


    public class Game
    {
        //properties
        public Deck deck { get; set; }
        public Player player { get; set; }
        public Dealer dealer { get; set; }
        public int Bet { get; set; }

        public Game() // constructor 
        {
            // Create instances of the deck, player, and dealer classes
            deck = new Deck();
            player = new Player();
            dealer = new Dealer();
        }

        public void stand() 
        {
            //keep drawing till total is greater than 17
            while(dealer.GetTotal() <= 17) 
            {
                deck = dealer.Draw(deck);
            }
        }

        public void Setup()
        {
            // Method to setup the game
            deck = new Deck();
            deck.Shuffle();

            // Draw two cards for the player and two cards for the dealer
            player.Draw(deck);
            player.Draw(deck);

            dealer.Draw(deck);
            dealer.Draw(deck);

            // Display the player's cards
            Console.WriteLine("Your cards are: ");
            foreach (var card in player.Hand)
            {
                Console.WriteLine(card.Rank + " of " + card.Suit);
            }
            Console.WriteLine("Your total is: " + player.GetTotal());

            // Display the dealer's first card and one hidden card
            Console.WriteLine("Dealer's cards are: ");
            Console.WriteLine(dealer.Hand[0].Rank + " of " + dealer.Hand[0].Suit);
            Console.WriteLine("Hidden card");

        }

        public void Hit() //Method to handle a hit from the player 
        {
            //Draw a card for the player
            player.Draw(deck);

            // Display the player's cards and total
            Console.WriteLine("Your cards are: ");
            foreach (var card in player.Hand)
            {
                Console.WriteLine(card.Rank + " of " + card.Suit);
                // call corresponding image 


            }
            Console.WriteLine("Your total is: " + player.GetTotal());
        }

        public void CardSetUp() 
        {
            deck = player.Draw(deck);
            deck = player.Draw(deck);
            deck = dealer.Draw(deck);
        }

        // Method to determine the winner of the game
        public bool DetermineWinner(Player player, Dealer dealer)
        {
            bool win = false; // Set to true if the player wins
                              // Display the dealer's cards and total
            //Console.WriteLine("Dealer's cards are: ");
            //foreach (var card in dealer.Hand) // reveals both dealers cards
            //{
            //    Console.WriteLine(card.Rank + " of " + card.Suit);
            //}
            //Console.WriteLine("Dealer's total is: " + dealer.GetTotal());

            //// Keep drawing cards for the dealer until they have a total of 17 or more
            //while (dealer.GetTotal() < 17)
            //{
            //    dealer.Draw(deck);

            //}

            // Check who won the game
            
            if (dealer.GetTotal() > 21)
            {
                Console.WriteLine("Dealer busts! You win!");
                Console.WriteLine("You win " + (Bet * 2) + " chips.");
                win = true;
                //Application.Run(new Frm_win_msg());
                // Load winner form (UI for winner) using Windows Forms
            }
            else if (dealer.GetTotal() < player.GetTotal())
            {
                Console.WriteLine("You win!");
                Console.WriteLine("You win " + (Bet * 2) + " chips.");
                win = true;

                // Load winner form (UI for winner) using Windows Forms
                //Application.Run(new Frm_win_msg());
            }
            else
            {
                Console.WriteLine("You lose!");
                // Player's total is less than or equal to dealer's total, so the player loses and the bool win remains false 
            }
            return win;
        }

        //creates the BlackJack data
        public void ExportGameData()
        {
            //Declare variables
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range xlRange;

            //Create a new Excel application object and set its visibility to true
            xlApp = new Excel.Application();
            xlApp.Visible = true;

            //Create a new workbook and add a worksheet to it
            xlWorkBook = xlApp.Workbooks.Add();
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            //Create four headers for the first four cells in row 1
            string[] headers = { "Player Name", "Player Total", "Dealer Total", "Win" };

            for (int i = 0; i < headers.Length; i++)
            {
                //Create a cell at row 1 column i+1
                xlRange = (Excel.Range)xlWorkSheet.Cells[1, i + 1];
                //Set the value of the cell to the header text
                xlRange.Value = headers[i];
                //Format the cell as bold and center-aligned
                xlRange.Font.Bold = true;
                xlRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                //Release the range object from memory
                Marshal.ReleaseComObject(xlRange);
                xlRange = null;
            }

            //Save your workbook as BlackjackHands.xlsx in C drive
            xlWorkBook.SaveAs("C:\\BlackjackHands.xlsx");

            //Close your workbook and quit your application
            xlWorkBook.Close();
            xlApp.Quit();







            //// this should create a new excel file which will record the data of each game 
            //Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            //excelApp.Visible = true;
            //Microsoft.Office.Interop.Excel.Range range;

            //// create a new workbook
            //var workbook = excelApp.Workbooks.Add();
            ////first sheet
            //var worksheet = workbook.Worksheets.get_Item(1);
            //int row = 1;
            //range = worksheet.get_Range("A1", "A1");
            //// headers 
            //worksheet.Cells[row, 1] = "Player Name";
            //worksheet.Cells[row, 2] = "Player Total";
            //worksheet.Cells[row, 3] = "Dealer Total";
            //worksheet.Cells[row1, 4] = "Win";
            //int row++; 

            //// write the data to subsequent rows ( idk if this would work ) 
            //worksheet.Cells[row, 1] = playerName;
            //worksheet.Cells[row, 2] = Player.GetTotal();
            //worksheet.Cells[row, 3] = Dealer.GetTotal();
            //worksheet.Cells[row, 4] = win;

            //// save the workbook
            //workbook.SaveAs("BlackjackHands.xlsx");

            //// close the workbook and Excel application
            //workbook.Close();
            //excelApp.Quit();
        }

        //function to add values to the file
        public void AddValues(string name, int playerTotal, int dealerTotal, int win)
        {
            Excel.Application excelApp = new Excel.Application(); //creates an Excel application object
            Excel.Workbook workbook = excelApp.Workbooks.Add("BlackjackHands.xlsx"); //opens an existing workbook at BlackjackHands.xlsx
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets.Item[1]; //accesses the first worksheet in the workbook

            Excel.Range usedRange = worksheet.UsedRange; //gets all used cells in worksheet
            int lastRow = usedRange.Row + usedRange.Rows.Count - 1; //gets row number of last used cell

            int newRow = lastRow + 1; //gets index of new row

            Excel.Range range = (Excel.Range)worksheet.Cells[newRow, 1]; //selects cell of last used row
            range.Value = name;
            range = (Excel.Range)worksheet.Cells[newRow, 2];
            range.Value = playerTotal;
            range = (Excel.Range)(worksheet.Cells[newRow, 3]);
            range.Value = dealerTotal;
            range = (Excel.Range)(worksheet.Cells[newRow, 4]);
            range.Value = win;

            workbook.SaveAs("BlackjackHands.xlsx"); //saves your changes at BlackjackHands.xlsx
            workbook.Close(); //closes your workbook 
            excelApp.Quit(); //quits your Excel application 


        }

    }
}

