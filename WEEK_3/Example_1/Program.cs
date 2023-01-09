using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example_1.BL;

namespace Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 Student = new Class1();
            Console.WriteLine("Name is " + Student.name);
            Console.WriteLine("Password is " + Student.password);
            Console.WriteLine("Age is " + Student.age);
            Console.ReadLine();
            
        }
    }
}
