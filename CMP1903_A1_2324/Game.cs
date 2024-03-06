using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Game
    {
        public void PlayGame()
        {
            // Creating variables that relate to GetRandomNumber method
            Die die1 = new Die();
            Die die2 = new Die();
            Die die3 = new Die();

            // All Dice are assigned their random number from the roll
            // The Dice are assigned to variables number1, number2, and number3
            Console.WriteLine("Die 1:");
            int number1 = die1.GetRandomNumber();
            die1.DieRollValue();

            Console.WriteLine("Die 2:");
            int number2 = die2.GetRandomNumber();
            die2.DieRollValue();

            Console.WriteLine("Die 3:");
            int number3 = die3.GetRandomNumber();
            die3.DieRollValue();

            // Calculates the sum of the three dice/random numbers
            int sum = number1 + number2 + number3;
            Console.WriteLine($"Total Sum of Dice: {sum}");

            Testing.Test(number1, number2, number3, sum);
        }
    }
}
