using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class _27_Random
    {
        static void Main(){
      Random rand = new Random();

      int randomNum = rand.Next(1, 11);

      Console.WriteLine("Random number between 1 and 10: "+randomNum);
       
        }
  }
}

