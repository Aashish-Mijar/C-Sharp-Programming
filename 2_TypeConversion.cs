using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class _2_TypeConversion
    {
        internal void Run()
        {

            int i = 3;
            //byte b = i;  // won't compile

            //Explict type conversion
            byte b = (byte)i;

            float f = 1.0f;
            int fl = (int)f;


            Console.WriteLine(b);
            Console.WriteLine(fl);


            // Non-compatible types
            // string s = "a";
            // int str = (int)s;

            string str = "1";
            int x = Convert.ToInt32(str);
            int j = int.Parse(str);

            Console.WriteLine(j);
        }
    }
}

