using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_One
{
    internal class _08_Solution
    {
        internal void vowel_and_const_counter()
        {
            string str = "programming";
            int countVowel = 0;
            int countConsonant = 0;
            foreach (char c in str)
            {
                //Console.WriteLine(c);
                if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    countVowel++;   
                }
                else
                {
                    countConsonant++;
                }
            }

            Console.WriteLine("Vowel count: " + countVowel);
            Console.WriteLine("Consonant count: " + countConsonant);
         }   
    }
}
