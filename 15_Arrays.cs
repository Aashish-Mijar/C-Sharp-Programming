using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class _15_Arrays
    {
        static void Main()
        {
            // Arrays - Used to store multiple values in a single variable

            // String array
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //Console.WriteLine(cars[0]);

            // integer array
            int[] myNum = { 10, 20, 40, 50 };
            //Console.WriteLine(myNum[0]);

            // creating an array and adding value later
            string[] fruits = new string[5];
            fruits = new string[] {"apple", "banana", "guava", "pineapple", "mangosten" };
            //Console.WriteLine(fruits[3]);   // This will print single value


            // To print all the values inside the array, loop is needed
            for(int i=0; i<fruits.Length; i++)
            {
                //Console.WriteLine(fruits[i]);
            }

            // Using foreach loop
            foreach(string fruit in fruits)
            {
                //Console.WriteLine(fruit); 
            }


            // Sorting of Arrays
            Array.Sort(fruits);
            foreach(string fruit in fruits)
            {
                //Console.WriteLine(fruit);
            }

            // Finding Min, Max, and sum in array using linq
            Console.WriteLine(myNum.Min());
            Console.WriteLine(myNum.Max());
            Console.WriteLine(myNum.Sum()); ;

        }
    }
}
