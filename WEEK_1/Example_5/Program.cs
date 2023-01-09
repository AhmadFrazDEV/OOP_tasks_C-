using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number,mul=1;
            Console.Write("Enter a Number ");
            number = int.Parse(Console.ReadLine());
            while(number != 0)
            {
                mul = mul * number;
                Console.Write("enter number :");
                number = int.Parse(Console.ReadLine());
            }
            Console.Write("total Multiplication is {0} ", mul);
            Console.Read();
        }
    }
}
