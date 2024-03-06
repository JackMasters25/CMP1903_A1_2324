using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        private static Random random = new Random();
        private int randomNumber;

        public Die()
        {
            RollDice();
        }
        // Generates a random number from 1-6 and assigned to variable randomNumber
        private void RollDice()
        {
            randomNumber = random.Next(1, 7);
        }
        // Random number is returned and stored here
        public int GetRandomNumber()
        {
            return randomNumber;
        }
        // Random number value is printed to the user
        public void DieRollValue()
        {
            Console.WriteLine($"Value: {randomNumber}");
        }

    }
}
