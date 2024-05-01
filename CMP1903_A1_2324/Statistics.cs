using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Statistics
    {
        // Determines the winner
        public void DisplayWinner(int winner)
        {
            if (winner == 0)
                Console.WriteLine("No winner!");
            else
                Console.WriteLine($"Player {winner} wins!");
        }
    }
}
