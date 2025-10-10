using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class _16_2D_Array
    {
        static void Main()
        {
            // Multidimensional Arrays -- Arrays of Arrays
            // Declaring and initalizing 2D array
            int[,] numbers = { { 1, 2, 4 }, { 4, 3, 6 } };

            // Accessing 2D Array
            Console.WriteLine(numbers[0,2]);

            // Looping in 2D Array
            //foreach(int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            for (int i = 0; i<numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }

        }
    }
}
