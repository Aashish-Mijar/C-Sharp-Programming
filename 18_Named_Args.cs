using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class _18_Named_Args
    {
        // It is possible to send arguments with key: value syntax.
        // The order of the arguments does not matter.
        static void myMethod(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }
       static void Main()
        {
        
            myMethod(child3: "John", child1: "Liam", child2: "Luis");

        }
    }
}
