using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Game
    {
        internal void PlayGame()
        {
            // Asks user which game they want to play
            Console.WriteLine("Welcome to the Dice game");
            Console.WriteLine("Enter 'S' to play the Sevens Out Game or Enter 'T' to play the Three of a kind Game:");
            string gameChoice = Console.ReadLine().ToUpper();

            // Starts Sevens Out game
            if (gameChoice == "S")
            {
                Console.WriteLine("Welcome to the Sevens Out Game");
                Sevens sevens = new Sevens();
                sevens.PlaySevens();
            }
            // Starts Three of a kind game
            else if (gameChoice == "T")
            {
                Console.WriteLine("Welcome to the Three of a kind Game");
                Threes threes = new Threes();
                threes.PlayThrees();
            }
            // Invalid Choice of gmae
            else
            {
                Console.WriteLine("Invalid choice. Exiting game.");
            }
        }
    }
}
