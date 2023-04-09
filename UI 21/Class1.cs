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
/*
 * player object in lower case
 * make a public player
 * 
 * 
 * create new game whe button bet is pressed 
 * 
 * 
 * button play create new player 
 */

namespace UI_21
{
    public class Card
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

        // create function equal , check wanted card is equal to the dictonary 
        // takes location of the dictionary
    }

    public class Deck
    {
        public List<Card> Cards { get; set; }

        //this dictionary stores the location of every card image to the corresponding card
        public Dictionary<Card, string> CardImages = new Dictionary<Card, string>();

        public Deck()
        {
            var Cards = new List<Card>();
            string[] suits = { "Hearts", "Diamonds", "Spades", "Clubs" };
            string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            int[] values = { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };
            string path = "cards/Playing Cards/PNG-cards-1.3";

            //creates a card based on every suit and rank and adds the card to a list of cards
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < ranks.Length; j++)
                {
                    Card card = new Card(ranks[j], suits[i], values[j]);
                    Cards.Add(card);
                }
            }

            //need to add the correct image to the card
            //this loop iterates through every card image in my folder
            foreach (string image in Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories))
            {
                string filename = Path.GetFileNameWithoutExtension(image);
                string[] SplitFilenameThing = new string[2];
                SplitFilenameThing = filename.Split("_"); 

                string tempRank = SplitFilenameThing[0];
                string tempSuit = SplitFilenameThing[2];

                //for every file, goes through the made list of cards, when it find the right card with the right suit and rank, it adds that card to a dictionary
                foreach(var card in Cards) 
                {
                    //checks the rank and suit before adding the card, converts to lower to make sure all the characters are the same
                    if(tempRank.ToLower() == card.Rank.ToLower()) 
                    {
                        if(tempSuit.ToLower() == card.Suit.ToLower()) 
                        {
                            CardImages.Add(card, image);
                            
                        }
                    }
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
    public class Player
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

    public class Dealer
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

    public class Game
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
            //you probably want to create a public deck clas you can access anywhere
            Deck deck = new Deck();
            deck.Shuffle();

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


        public bool DetermineWinner(Player player, Dealer dealer)
        {
            bool win = false; // set 
            Console.WriteLine("Dealer's cards are: ");
            foreach (var card in dealer.Hand) // reveals both dealers cards
            {
                Console.WriteLine(card.Rank + " of " + card.Suit);
            }
            Console.WriteLine("Dealer's total is: " + dealer.GetTotal());
            
            // this isnt compulsary, not a priority.
            while (dealer.GetTotal() < 17)
            {
                Dealer.Draw(Deck);
               
            }

            if (player.GetTotal() > 21)
            {
                Console.WriteLine("You lose!");
                // bool win is false 

            }
            else if (dealer.GetTotal() > 21)
            {
                Console.WriteLine("Dealer busts! You win!");
                Console.WriteLine("You win " + (Bet * 2) + " chips.");
                win = true;
                Frm_win_msg(); // load winner form (ui for winner) 
            }
            else if (dealer.GetTotal() < player.GetTotal())
            {
                Console.WriteLine("You win!");
                Console.WriteLine("You win " + (Bet * 2) + " chips.");
                win = true;
                Frm_win_msg(); //load winner form(ui for winner)
            }
            else
            {
                Console.WriteLine("You lose!");
                // bool win is false 
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
            xlWorkBook.SaveAs("BlackjackHands.xlsx");

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
