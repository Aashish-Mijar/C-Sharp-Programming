using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_One
{
    internal class _03_Solution
    {
        internal void oddEvenDiff()
        {
            int[] numbers = { 3, 7, 2, 8, 5, 10 };
            int i;
            int sumEven = 0;
            int sumOdd = 0;
            for ( i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumEven += numbers[i];

                }
                else
                {
                    sumOdd += numbers[i];
                }
                //Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("The sum of Even numbers present in array is: " + sumEven);
            Console.WriteLine("The sum of Odd numbers present in array is: " + sumOdd);
        }
    }
}
