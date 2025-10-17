using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class _10_Loops
    {
        static void Main()
        {
            // ------ Loop -> can execute a block of code as long as a specified condition is reached.
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
             // ----- Do While Loop -----
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);

            // ---- For Loop -----
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            
            for (i = 0; i<5; i++){
                for(int j = 0; j<5; j++){
                    Console.WriteLine("*");
                }
            }
        }
    }
}
