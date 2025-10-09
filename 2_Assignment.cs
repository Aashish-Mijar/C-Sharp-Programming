using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class _2_Assignment
    {
    static void Main()
        {
            int x, y;
            Console.WriteLine("Enter value for x and y: ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            x += 3;
            Console.WriteLine(x);

            x -= 4;
            Console.WriteLine(y);

            y *= 2;
            Console.WriteLine(x);

            y /= 2;
            Console.WriteLine(y);

            x &= 4;
            Console.WriteLine(x);

            x |= 6;
            Console.WriteLine(y);

            x ^= 3;
            Console.WriteLine(x);

            y >>= 3;
            Console.WriteLine(y);

            x <<= 3;
            Console.WriteLine(x);


        }   
    }
}
