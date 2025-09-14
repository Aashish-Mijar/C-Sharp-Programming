using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class _1_Arithmetic
    {
        static void Main()
        {
            int a, b;
            Console.WriteLine("Enter a and b: ");
            a= Convert.ToInt32(Console.ReadLine());
            b= Convert.ToInt32(Console.ReadLine());

            // Addition
            int sum = a + b;

            // Subtraction
            int subt = a - b;

            // Multiplication
            int mul = a * b;

            // Division
            int div = a / b;

            // Modulus
            int mod = a % b;

            // Increment
            int incre = a++;

            // Decrement
            int decre = a--;

            Console.WriteLine(sum);
        }
    }
}
