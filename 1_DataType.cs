using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class _1_DataType
    {
        internal void DataType()
        {
            // Instead of using datatype for each we can use 'var'
            byte number = 9;  // var number
            int count = 10; // var count
            float totalPrice = 20.94f;   // var totalPrice
            char character = 'A';    // var character
            string firstName = "Aashish"; // var string
            bool isWorking = true;  // bool

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
        }
    }
}
