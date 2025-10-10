using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class _14_Break_Continue
    {
        static void Main()
        {
            // Break and Continue
            // Break statement is used to jump out of a loop

            for (int i = 0; i<10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            // Continue statement breaks one iteration (in the loop), if a specified condition occurs, and continues with the next iteration in the loop

            for(int i = 0; i<10; i++)
            {
                if(i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }


    }
}
