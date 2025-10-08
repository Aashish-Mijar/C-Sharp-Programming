using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_One
{
    internal class _06_Solution
    {
        internal void multiplicationTable()
        {
            int n = 5;
            int i;
            for(i = 10; i > 0; i--)
            {
                int multiply = n * i; 
                Console.WriteLine("{0} x {1} = {2}", n, i, multiply);
            }
        }
    }
}
