using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace UI_21
{
    public class Blackjack_Data
    {
    // attempt to read the excel file and take the necessary data. 
    // i think i was able to read the lines, but am unsure how to split the variables 
    // try and calculate the information for the hints 
    
        public static double ReadBlackJackData()
        {
            string filePath = "blkjckhands.csv";
            double winRate = 0.0;
            try
            {
                int totalHands = 0;
                //int sumofcards = 0;
                int totalWins = 0;

                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] values = line.Split(',');// everytime there is a comma will split the original line 

                    // Parse the values into variables
                    // not sure on these two lines 
                    string hand = values[0];
                    string result = values[1];

                    totalHands++;

                    if (result == "win")
                    {
                        totalWins++;
                    }
                }
                // try and calculate the information for the hints 
                // Calculate the win rate
                winRate = (double)totalWins / (double)totalHands;
                // can do this part in labels. 
                /*Console.WriteLine("Total hands: {0}", totalHands);
                Console.WriteLine("Total wins: {0}", totalWins);
                Console.WriteLine("Win rate: {0:P2}", winRate);
                */
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return winRate; 
        }
    }
}





