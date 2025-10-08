using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_One
{
    internal class _07_Solution
    {
        internal void SecondLargestNum()
        {
            int[] numbers = { 12, 35, 7, 10, 29 };

            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            //Console.WriteLine(largest);
            //Console.WriteLine(secondLargest);

            foreach(int num in numbers)
            {
                if (num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }
                else if(num > secondLargest && num != largest)
                {
                    secondLargest = num;
                }
            }
           
            Console.WriteLine("Second Largest Number = " + secondLargest);

        }
    }
}
