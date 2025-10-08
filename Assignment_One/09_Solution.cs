using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_One
{
    internal class _09_Solution
    {
        internal void palindrome()
        {
            int rows = 5;
            // Outer Loop
            for (int i = 1; i <= rows; i++)
            {
                // Print spaces
                for (int s = 1; s <= rows - i; s++)
                {
                    Console.Write("  ");
                }

                // Print ascending numbers
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                // Print descending numbers
                for (int j = i - 1; j >= 1; j--)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
