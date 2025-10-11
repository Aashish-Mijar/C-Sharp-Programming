using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class _7_MathFunction
    {
        static void Main()
        {
            double e = Math.E;
            Console.WriteLine("Math.E: "+e);

            double pi_value = Math.PI;
            Console.WriteLine("Math.PI: "+ pi_value);

            // Absoulte
            Console.WriteLine("Absoulte " + Math.Abs(-3));

            // Sin, Cos, tan
            Console.WriteLine("Sin: {0}, Cos: {1}, Tan: {2} ", Math.Sin(35), Math.Cos(45), Math.Tan(90));

            // Square root
            Console.WriteLine("Square root: {0} ", Math.Sqrt(25));

            // Truncate
            Console.WriteLine("Truncate value: {0}", Math.Truncate(45.8773m));

            


        }

    }
}
