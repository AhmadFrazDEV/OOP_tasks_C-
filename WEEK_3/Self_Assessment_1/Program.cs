using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Self_Assessment_1.Classes;

namespace Self_Assessment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, password;
            Console.WriteLine("Enter Name ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Password ");
            password = Console.ReadLine();
            Class1 Data = new Class1(name,password);
            Console.ReadLine();
        }
    }
}
