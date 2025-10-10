using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class _17_Method
    {
        // in myMethod() int age = 19 and country = "Nepal" are called default parameter
        static void myMethod(string fname, int age=19, string country="Nepal")
        {
            Console.WriteLine("Hello "+fname + " Mijar");
            Console.WriteLine("You are " + age + " years old.");
            Console.WriteLine("You are from " + country+".");
        }

        // Method that returns values

        static int sumTwoNum(int x, int y)
        {
            return x + y;
        }
        static void Main()
        {
            myMethod("Aashish", 20);
            int result = sumTwoNum(5, 8);
            Console.WriteLine("The sum of two number is: " + result);
        }
    }
}
