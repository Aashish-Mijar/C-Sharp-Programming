using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class _3_Comparison
    {
        static void Main()
        {
            int x = 5;
            int y = 10;

            Console.WriteLine("The equal to {0},{1}: {2} " ,x, y , (x == y));
            Console.WriteLine("Not equal to {0},{1}: {2} ", x, y, (x != y));
            Console.WriteLine("Greater than {0},{1}: {2} ", x,y, (x>y));
            Console.WriteLine("Less that {0},{1}: {2}", x,y, (x < y));
            Console.WriteLine("Greater than or equal to {0},{1}: {2} ", x,y, (x>=y));
            Console.WriteLine("Less than or euqal to {0},{1}: {2} ", x,y, (x<=y));

        }
    }
}
