using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class _31_RealLifeExmp
    {
       
       static void Main(){
        object[] data = new object[3];

        data[0] = 10; // int (boxed)
        data[1] = 20.5; // double(boxed)
        data[2] = "C#";  // string (already reference type)

        Console.WriteLine("Stored values: ");
        foreach(var item in data){
            Console.WriteLine(item);
        }
       }
        }
  }


