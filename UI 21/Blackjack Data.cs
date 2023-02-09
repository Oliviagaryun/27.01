using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace UI_21
{
    internal class Blackjack_Data
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

       
        class Program
        {
            static void Main(string[] args)
            {
                DataTable blackjackData = ReadDataFromExcel("blkjckhands.xlsx");
                int numberOfSimulations = 10000;
                int numberOfWins = 0;

                for (int i = 0; i < numberOfSimulations; i++)
                {
                    int playerScore = 0;
                    int dealerScore = 0;
                    bool playerBusted = false;

                    // Player's turn
                    while (playerScore < 17)
                    {
                        int cardValue = GetRandomCardValue(blackjackData);
                        playerScore += cardValue;
                        if (playerScore > 21)
                        {
                            playerBusted = true;
                            break;
                        }
                    }

                    // Dealer's turn
                    if (!playerBusted)
                    {
                        while (dealerScore < 17)
                        {
                            int cardValue = GetRandomCardValue(blackjackData);
                            dealerScore += cardValue;
                        }

                        if (dealerScore > 21 || playerScore > dealerScore)
                        {
                            numberOfWins++;
                        }
                    }
                }

                Console.WriteLine("Number of Wins: " + numberOfWins);
                Console.WriteLine("Winning Percentage: " + ((double)numberOfWins / numberOfSimulations * 100) + "%");

                Console.ReadLine();
            }

            private static int GetRandomCardValue(DataTable blackjackData)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, blackjackData.Rows.Count - 1);
                int cardValue = Convert.ToInt32(blackjackData.Rows[randomIndex]["Value"]);
                return cardValue;
            }

            private static DataTable ReadDataFromExcel(string fileName)
            {
                DataTable dataTable = new DataTable();
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileName);
                Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                Excel.Range xlRange = xlWorksheet.UsedRange;

                int rowCount = xlRange.Rows.Count;
                int colCount = xlRange.Columns.Count;

                // Add columns to the DataTable
                for (int i = 1; i <= colCount; i++)
                {
                    dataTable.Columns.Add(xlRange.Cells[1, i].Value2.ToString());
                }

                // Add rows to the DataTable
                for (int i = 2; i <= rowCount; i++)
                {
                    DataRow dataRow = dataTable.NewRow();
                    for (int j = 1; j <= colCount; j++)
                    {
                        dataRow[j - 1] = xlRange.Cells[i, j].Value2;
                    }
                    dataTable.Rows.Add(dataRow);
                }
                xlWorkbook.Close();
                xlApp.Quit();

                return dataTable;
            }
        }


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
}


