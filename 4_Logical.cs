using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class _4_Logical
    {
        static void Main()
        {
            int x = 23;
            // logical and
            Console.WriteLine(x > 3 && x < 10);

            // logical or
            Console.WriteLine(x < 5 || x < 3);

            // Logical not
            Console.WriteLine(!(x> 3 && x < 10));
        }
    }
}
