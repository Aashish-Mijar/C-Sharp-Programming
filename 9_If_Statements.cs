using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class _9_If_Statements
    {
        static void Main()
        {
            int valueOne = 20;
            int valueTwo = 18;
            // ------ If Statements ------
            if(valueOne > valueTwo)
            {
                //Console.WriteLine(" ValueOne is greater than ValueTwo");
            }
            // ------ Else Statements -----
            else  {  
     
                //Console.WriteLine("Value two is greater!");
            }
           
        // ----- If->elseif->else ----
            int time = 23;
            if(time < 12)
            {
                Console.WriteLine("Good Morning!");
            }
            else if(time > 12 && time < 17)
            {
                Console.WriteLine("Good Afternoon!");
            }
            else
            {
                Console.WriteLine("Good Evening!");
            }

            // ----- Short hand if->else (Ternary Operator)
            string result = (time > 18) ? "Good day. " : "Good evening. ";
            Console.WriteLine(result);
        }
    }
}
