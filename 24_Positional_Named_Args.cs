using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class _24_Positional_Named_Args
    {
        static void CalculateTotal(int price, int quantity, double discount){
            double total = price*quantity*(1-discount);
            Console.WriteLine($"Total Price after discount: {total}");

        }
        static void Main(){
            // Mixing positional (first two ) and named (last one)
            CalculateTotal(500, 2, discount: 0.1);
        }
        
    }
}
