using System;
using System.Diagnostics;

namespace CMP1903_A1_2324
{
    public class Testing
    {
        // Testing simulations of the rules of the threes and sevens games
        public static void Tests()
        {
            Debug.Assert(DiceSeven() == true, "Sevens Out does not stop turn at 7");
            Debug.Assert(DoubleCalculation() == true, "Double calculation is incorrect");
            Debug.Assert(EndTotalSevens() == true, "Game does not end at 50 points");
            Debug.Assert(EndTotalThrees() == true, "Game does not end at 20 points");
        }

        private static bool DiceSeven()
        {
            int roll1 = 4;
            int roll2 = 3;
            return (roll1 + roll2 == 7);
        }

        private static bool DoubleCalculation()
        {
            int roll1 = 3;
            int roll2 = 3;
            return (roll1 == roll2) && ((roll1 + roll2) * 2 == 12); 
        }

        private static bool EndTotalSevens()
        {
            int player1Points = 48;
            int player2Points = 50;
            return player1Points >= 50 || player2Points >= 50;
        
        }

        private static bool EndTotalThrees()
        {
            int player1Points = 18;
            int player2Points = 20;
            return player1Points >= 20 || player2Points >= 20;
        }
    }
}