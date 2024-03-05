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
        private void RollDice()
        {
            randomNumber = random.Next(1, 7);
        }
        public int GetRandomNumber()
        {
            return randomNumber;
        }
        public void DieRollValue()
        {
            Console.WriteLine($"Value: {randomNumber}");
        }

    }
}
