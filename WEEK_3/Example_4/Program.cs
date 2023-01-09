using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example_4.Classes;

namespace Example_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Enter Name ");
            name = Console.ReadLine();
            Class1 StudentData = new Class1(name);
            Console.WriteLine("Name After Passing the Value is " + StudentData.name);
            Console.ReadLine();
        }
    }
}
