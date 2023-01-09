using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SA_1.Classes;

namespace SA_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 StudentData = new Class1("Ali","123@",12,980);
            Console.WriteLine("Name is " + StudentData.name);
            Console.WriteLine("Password is " + StudentData.password);
            Console.WriteLine("Age is " + StudentData.age);
            Console.WriteLine("Marks is " + StudentData.marks);
            Console.ReadLine();
        }
    }
}
