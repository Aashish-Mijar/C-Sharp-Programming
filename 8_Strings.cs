using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class _8_Strings
    {
        static void Main()
        {
            //string greet = "Hey coders, You are great!";
            //Console.WriteLine(greet);


            // ----Finding length of string----
            string txt1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //Console.WriteLine("The length of the txt string is : "+txt1.Length);

            // -----other methods-----
            string txt2 = "Hey hackerss!";
            //Console.WriteLine(txt2.ToUpper());
            //Console.WriteLine(txt2.ToLower());

            // ----- String Concatenation----
            string firstName = "Aashish";
            string lastName = " Mijar";
            string fName = firstName + lastName;
            //Console.WriteLine("The name of person is: " + fName);

            // ------Concat()
            string fullName = string.Concat(firstName, lastName);
            //Console.WriteLine(fullName);

            // -----Adding numbers----
            string x = "10";
            string y = "20";
            string z = x + y;
            //Console.WriteLine(z);

            // -----String Interpolation----
            string name = $"My full name is: {firstName} {lastName}";
            //Console.WriteLine(name);

            //----Accessing Letters in Strings---
            Console.WriteLine(firstName[0]);
            Console.WriteLine(firstName[1]);

            // -----Accessing index in Strings----
            Console.WriteLine(firstName.IndexOf('s'));

            // ------SubString from String-----
            string myName = "Aashish Mijar";

            int charPos = myName.IndexOf("M");
            string lName = myName.Substring(charPos);
            Console.WriteLine(lName);

            //------ Special Characters------
            /* \' ---- Single quote
             \" ------ Double quote
            \\ -------- Backslash 
            \n ------ New Line
            \t ------ Tab
            \b ------ Backspace   */

            string sent1 = "We are the so-called \"Vikings\" from the north.\n";
            string sent2 = "It\'s alright.\n";
            string sent3 = "The character \'\\' is called backslash";
            string sent4 = "The tab is used by '\t'";

            Console.WriteLine(sent1 + sent2 + sent3);
        }
    }
}
