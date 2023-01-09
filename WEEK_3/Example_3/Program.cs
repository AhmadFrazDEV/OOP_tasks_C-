using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example_3.Classes;

namespace Example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 Data = new Class1("Ali");
            Console.WriteLine("Default Value Of Name Set by the Constucture is {0} ", Data.name);
            Console.ReadLine();
            
        }
    }
}
