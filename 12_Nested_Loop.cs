using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class _12_Nested_Loop
    {
        static void Main()
        {
            // Outer Loop
            for (int i = 1; i <= 2; ++i)
            {

                Console.WriteLine("Outer: " + i);

                // Inner Loop
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine("Inner: " + j);
                }
            }

        }
    }
}
