using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class _13_ForEach_Loop
    {
        static void Main()
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach(string i in cars){
                Console.WriteLine("The value in array is: "+i);
            }
        }
    }
}
