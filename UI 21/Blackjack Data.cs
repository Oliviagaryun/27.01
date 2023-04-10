using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace UI_21
    // TS complete, added descriptive comments 
{
    public class Blackjack_Data
    {
        public static double ReadBlackJackData(Player player)
        {
            // Define the file path for the CSV file containing the blackjack hands
            string filePath = "blkjckhands.csv";

            double winRate = 0.0;

            try
            {
                int totalHands = 0;
                int totalWins = 0;

                // Read all lines from the CSV file
                string[] lines = File.ReadAllLines(filePath);

                // Loop through each line in the CSV file
                foreach (string line in lines)
                {
                    // Split the line by comma to extract the values
                    string[] values = line.Split(',');

                    // Extract the sum of cards and result from the values
                    string sumOfCards = values[7];
                    int sumofcards = int.Parse(sumOfCards);
                    string result = values[15];

                    // Increment the total number of hands
                    totalHands++;

                    // Check if the sum of cards in the hand is the same as the player's total
                    int playerTotal = player.GetTotal();
                    if (sumofcards == playerTotal)
                    {
                        totalHands++;
                    }

                    // Check if the hand was a win
                    if (result == "win")
                    {
                        totalWins++;
                    }
                }

                // Calculate the win rate
                winRate = (double)totalWins / (double)totalHands;
            }
            catch (Exception ex)
            {
                // If an error occurs, print the error message
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            // Return the win rate
            return winRate;
        }
    }
}
