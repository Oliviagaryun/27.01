using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using OfficeOpenXml;
using System.IO;

namespace UI_21
{
    public class Blackjack_Data
    {
        /*private List<int> cards = new List<int>(); // data reads up to 5 cards
        private List<int> Dealcard = new List<int>();
        private int plySumCards;
        private int plySumDealCards;
        private string blkjck;
        private string winloss;
        private string plybustbeat;
        private string dlbustbeat;
        private int ply2SumCards;
        private int plyWinAmt;
        private int DlWinAmt;
      */
    }

    public class BlackjackData_Program
    {
        public static void ReadBlackJackData()
        {
            string filePath = "blkjckhands.csv";

            try
            {
                int totalHands = 0;
                int sumofcards = 0;
                int totalWins = 0;

                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] values = line.Split(',');

                    // Parse the values into variables
                    string hand = values[0];
                    string result = values[1];

                    totalHands++;

                    if (result == "win")
                    {
                        totalWins++;
                    }
                }

                // Calculate the win rate
                double winRate = (double)totalWins / (double)totalHands;

                Console.WriteLine("Total hands: {0}", totalHands);
                Console.WriteLine("Total wins: {0}", totalWins);
                Console.WriteLine("Win rate: {0:P2}", winRate);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}



/*
        class CardGames
        {
            int PlayerID;
            //int[] playerCards;
            //int[] dealerCards;
            bool Blackjack;
            bool Win;
            bool plyrBust;
            bool dealerBust;

        }
        class Dealer
        {
            int GameID;
            //int[] dealerCards;
        }
    }
}
*/


