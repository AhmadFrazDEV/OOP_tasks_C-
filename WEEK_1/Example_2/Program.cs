using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example2
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            Console.Write("Enter length of sqaure: ");
            length = int.Parse(Console.ReadLine());
            int area = length * length;
            Console.WriteLine("total area of square is " + area);
            Console.Read();

        }
    }
}
