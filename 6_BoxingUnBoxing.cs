using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    // Boxing and Unboxing 
    internal class _6_BoxingUnBoxing
    {
        // Boxing  ---- int to Object
        internal void BoxingFun()
        {
            int a = 10;
            Object obj;
            obj = a;
            Console.WriteLine(obj);
        }

        // Unxboxing ----- object to int
        internal void UnBoxingFun()
        {
            Object obj = 10;
            int a = (int)obj;
            Console.WriteLine(a);
        }
    }
}
