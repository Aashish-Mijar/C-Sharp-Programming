using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_One
{
    internal class _04_Solution
    {
        internal void reverseNum()
        {
            int num = 4321;
            int revNum = 0;
            int sumDigit = 0;

            while (num > 0) {
                int remainder = num % 10;
                revNum = (revNum * 10) + remainder;
                sumDigit += remainder;
                num = num / 10;
            }
            //Console.WriteLine(revNum);
            Console.WriteLine("The sum of Digit is: {0} ",sumDigit);
            Console.WriteLine("The reverse number is: {0}", revNum);  
        }
    }
}
