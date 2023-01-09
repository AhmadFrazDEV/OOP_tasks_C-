using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, sum = 0;
            do
            {
                Console.Write("enter number :");
                number = int.Parse(Console.ReadLine());
                sum = sum + number;
            }
            while (number != 0);
            Console.Write("total sum  is {0} ", sum);
            Console.Read();
        }
    }
}
