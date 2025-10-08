using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_One
{
    internal class _05_Solution
    {
        internal void Factorial()
        {
            int n = 6;
            int factNum = 1;
            while (n > 0)
            {
                factNum *= n;
                n--;
            }
            Console.WriteLine("The factorial of 6 is {0}", factNum);
        }
    }
}
