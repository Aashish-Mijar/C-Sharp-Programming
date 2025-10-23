using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class _26_MathFun
    {
        static void Main(){
            double num = 9.67;

            double a = 5;
            double b = 6;

            Console.WriteLine("Number: "+ num);
            Console.WriteLine("Round: "+Math.Round(num)); 
            Console.WriteLine("Floor: "+Math.Floor(num));
            Console.WriteLine("Celiling: "+Math.Ceiling(num));
            Console.WriteLine("Power "+ Math.Pow(a, b));
            Console.WriteLine("Square root: "+ Math.Sqrt(35));
        }
       
        }
  }

