using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Sevens
    {
        public void PlaySevens()
        {
            int player1Points = 0;
            int player2Points = 0;
            int currentPlayer = 1;
            int winner = 0;

            // This checks the players haven't exceeded the total points needed to win the game
            while (player1Points < 50 && player2Points < 50)
            {
                // This prompts the players whose turn it is
                // Also shows the players how many points they both have after every turn
                Console.WriteLine($"Player {currentPlayer}'s turn:");
                TakeTurn(ref player1Points, ref player2Points, ref currentPlayer);
                Console.WriteLine($"Player 1 has {player1Points} Points");
                Console.WriteLine($"Player 2 has {player2Points} Points");
                currentPlayer = currentPlayer == 1 ? 2 : 1;
            }

            // Determines the winner
            if (player1Points >= 50)
                winner = 1;
            else if (player2Points >= 50)
                winner = 2;

            // Display the winner using the Statistics class
            Statistics stats = new Statistics();
            stats.DisplayWinner(winner);
        }

        // This is the method for the player's turn
        // Creates die and assigns a random number each turn
        // Prints the number of each die to the user
        // Performs checks for 7s, doubles and roll total
        private void TakeTurn(ref int player1Points, ref int player2Points, ref int currentPlayer)
        {
            Die die1 = new Die();
            Die die2 = new Die();

            Console.WriteLine($"Player {currentPlayer}, press Enter to roll the dice.");
            Console.ReadLine();

            int roll1 = die1.GetRandomNumber();
            int roll2 = die2.GetRandomNumber();

            Console.WriteLine($"Die 1: {roll1}");
            Console.WriteLine($"Die 2: {roll2}");

            // This checks if the player has rolled a combined total of 7 and ends the turn if true
            if (roll1 + roll2 == 7)
            {
                Console.WriteLine("Total is 7. Turn ends.");
                return;
            }

            // This checks if the player has rolled a double and adds the rolls together and x2 and adds to their points if true.
            if (roll1 == roll2)
            {
                Console.WriteLine("Double! Points doubled.");
                if (currentPlayer == 1)
                    player1Points += (roll1 + roll2) * 2;
                else
                    player2Points += (roll1 + roll2) * 2;
            }
            // This adds the rolls combined total to the player's point count.
            else
            {
                if (currentPlayer == 1)
                    player1Points += roll1 + roll2;
                else
                    player2Points += roll1 + roll2;
            }
        }
    }
}
