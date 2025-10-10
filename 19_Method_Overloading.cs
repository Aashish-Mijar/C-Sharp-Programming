using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class _19_Method_Overloading
    {
        static int add(int x, int y)
        {
            return x + y;
        }

        static double add(double x, double y)
        {
            return x + y;
        }
        static void Main()
        {
            int resultOne = add(4, 6);
            double resultTwo = add(6.7, 2.4);
            Console.WriteLine("Sum of integers: " + resultOne);
            Console.WriteLine("Sum of double: " + resultTwo);
        }
    }
}
