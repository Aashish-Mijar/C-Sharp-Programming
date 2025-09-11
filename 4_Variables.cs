using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class _4_Variables
    {
        // Global Variable  Decalared under calss
       static int y = 100;

    internal void variables()
        {
              // Local variable
            int y = 4;
            Console.WriteLine("The value of y is " + y);
            y = 6;
            Console.WriteLine("The value of y is " + y);
            Console.WriteLine("The value of y is " + _4_Variables.y);

        }
    }
}
