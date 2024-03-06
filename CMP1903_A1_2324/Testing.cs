using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Testing
    {
        // Verifying the random numbers and the sum are in the correct range
        public static void Test(int number1, int number2, int number3, int sum)
        {
            Debug.Assert(number1 >= 1 && number1 <= 6, "Die 1 value out of range");
            Debug.Assert(number2 >= 1 && number2 <= 6, "Die 2 value out of range");
            Debug.Assert(number3 >= 1 && number3 <= 6, "Die 3 value out of range");
            Debug.Assert(sum >= 3 && sum <= 18, "Total sum out of range");
        }
    }
}