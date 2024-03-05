using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        static void Main()
        {
            Die die1 = new Die();
            Die die2 = new Die();
            Die die3 = new Die();

            Console.WriteLine("Die 1:");
            int number1 = die1.GetRandomNumber();
            die1.DieRollValue();

            Console.WriteLine("Die 2:");
            int number2 = die2.GetRandomNumber();
            die2.DieRollValue();

            Console.WriteLine("Die 3:");
            int number3 = die3.GetRandomNumber();
            die3.DieRollValue();

            int sum = number1 + number2 + number3;
            Console.WriteLine($"Total Sum of Dice: {sum}");

            Testing.Test(number1, number2, number3, sum);
        }
    }
}
