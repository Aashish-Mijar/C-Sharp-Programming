using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_One
{
    internal class _01_Solution
    {
       internal void swapNbr() {

            int a = 8, b = 3;
            Console.WriteLine("The value of a: {0} and b: {1} before swapping.", a, b);

            // Swapping logic without third variable
            a = a + b;
            b = a - b;
            a = a - b;

            // Next method
            //a = a ^ b;
            //b = a ^ b;
            //a = a ^ b;

            Console.WriteLine("The value of a: {0} and b: {1} after swapping.", a, b);
        }
    }
}
