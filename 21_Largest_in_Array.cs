using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class _21_Largest_in_Array
    {
        internal void LargestInArray()
        {
            int[] numbers = new int[5];
            Console.WriteLine("Enter 5 numbers: ");

            for (int i = 0; i<5; i++){
                Console.Write($"Number {i+1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
           
        }
    }
}
