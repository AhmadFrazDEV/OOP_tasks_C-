using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example3
{
    class Program
    {
        static void Main(string[] args)
        {
            int marks;
            Console.Write("Enter Marks ");
            marks=int.Parse(Console.ReadLine());
            if(marks > 50)
            {
                Console.Write("Your Number is {0} and your passed :", marks);
            }
            else
            {
                Console.Write("Your Number is {0} and your fail :", marks);
            }
            Console.Read();
        }
    }
}
