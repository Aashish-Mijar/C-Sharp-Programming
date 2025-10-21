using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class _23_NamedArgs2
    {
        static void DisplayInfo(string name, int age){
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
        }
        static void Main(){
            // Using named arguments
            DisplayInfo(name: "Aashish", age:21);
        }
       
            
    }
}
