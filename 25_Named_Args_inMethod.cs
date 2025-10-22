using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class _25_Named_Args_inMethod
    {
        static void CreateStudent(string name, int age, string course, double gpa, string city){
            Console.WriteLIne($"Name: {name}, Age:{age}, Course: {course}, GPA: {gpa}, City:{city}");
        }
      
            
    }
}
