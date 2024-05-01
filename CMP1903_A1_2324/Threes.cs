using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Threes
    {
        public void PlayThrees()
        {
            int player1Points = 0;
            int player2Points = 0;
            int currentPlayer = 1;
            int winner = 0;

            // This checks the players havent exceeded the total points needed to win the game
            while (player1Points < 20 && player2Points < 20)
            {
                // This prompts the players whose turn it is
                // Shows the players how many points they have after their turn
                Console.WriteLine($"It is Player {currentPlayer}'s turn. Press Enter to roll the dice.");

                int pointsEarned = TakeTurn();

                if (currentPlayer == 1)
                {
                    player1Points += pointsEarned;
                    Console.WriteLine($"Player 1 has {player1Points} points");
                }
                else
                {
                    player2Points += pointsEarned;
                    Console.WriteLine($"Player 2 has {player2Points} points");
                }

                currentPlayer = currentPlayer == 1 ? 2 : 1;
            }

            // Determines the winner
            if (player1Points >= 20)
                winner = 1;
            else
                winner = 2;

            // Display the winner using the Statistics class
            Statistics stats = new Statistics();
            stats.DisplayWinner(winner);
        }
        // Checks for 3/4/5 of a kind and gives the equivalent points
        // Checks for 2 of a kind and asks for user input for rerolls or end of the turn
        // Ends the players turn if they did not roll a 2/3/4/5 of a kind
        private int TakeTurn()
        {
            int pointsEarned = 0;
            Die[] dice = new Die[5];
            for (int i = 0; i < 5; i++)
            {
                dice[i] = new Die();
                Console.WriteLine($"Die {i + 1}: {dice[i].GetRandomNumber()}");
            }

            if (threeOfAKind(dice))
            {
                Console.WriteLine("You have three of a kind. You get 3 points.");
                pointsEarned += 3;
            }
            else if (fourOfAKind(dice))
            {
                Console.WriteLine("You have four of a kind. You get 6 points.");
                pointsEarned += 6;
            }
            else if (fiveOfAKind(dice))
            {
                Console.WriteLine("You have five of a kind. You get 12 points.");
                pointsEarned += 12;
            }
            else if (twoOfAKind(dice))
            {
                Console.WriteLine("You have two of a kind, Reroll (R) or End turn (E)?");
                string choice = Console.ReadLine().ToLower();

                if (choice == "r")
                {
                    Console.WriteLine("You chose to Reroll");
                    return TakeTurn();
                }
            }
            else
            {
                Console.WriteLine("You have nothing. Your turn is Over.");
            }

            return pointsEarned;
        }
        // Checks if there are two die of the same value
        private bool twoOfAKind(Die[] dice)
        {
            foreach (var die in dice)
            {
                int count = 0;
                foreach (var d in dice)
                {
                    if (d.GetRandomNumber() == die.GetRandomNumber())
                        count = count + 1;
                }
                if (count >= 2)
                    return true;
            }
            return false;
        }
        // Checks if there are three die of the same value
        private bool threeOfAKind(Die[] dice)
        {
            foreach (var die in dice)
            {
                int count = 0;
                foreach (var d in dice)
                {
                    if (d.GetRandomNumber() == die.GetRandomNumber())
                        count = count + 1;
                }
                if (count >= 3)
                    return true;
            }
            return false;
        }
        // Checks if there are four die of the same value
        private bool fourOfAKind(Die[] dice)
        {
            foreach (var die in dice)
            {
                int count = 0;
                foreach (var d in dice)
                {
                    if (d.GetRandomNumber() == die.GetRandomNumber())
                        count = count + 1;
                }
                if (count >= 4)
                    return true;
            }
            return false;
        }
        // Checks if there are five die of the same value
        private bool fiveOfAKind(Die[] dice)
        {
            foreach (var die in dice)
            {
                int count = 0;
                foreach (var d in dice)
                {
                    if (d.GetRandomNumber() == die.GetRandomNumber())
                        count = count + 1;
                }
                if (count >= 5)
                    return true;
            }
            return false;
        }
    }
}