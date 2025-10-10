using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class _3_TakingInput
    {
        internal void inputs() {
            // Console.WriteLine("Enter username");
            // string userName = Console.ReadLine();
            // Console.WriteLine("Username is:" + userName);

            int a, b, sum;
            Console.WriteLine("Enter number one: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number two: ");
            b = Convert.ToInt32(Console.ReadLine());

            sum = a + b;
            
            Console.WriteLine("The value of a is {0} and b is {1}", a, b);
            Console.WriteLine("The sum of a and b is :" + sum);


        }
    }
}
