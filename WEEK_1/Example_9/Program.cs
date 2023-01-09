using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter Two Number");
            num1=int.Parse(Console.ReadLine());
            num2=int.Parse(Console.ReadLine());
            int totalsum=SumCalculater(num1,num2);
            Console.Write("Total sum is " + totalsum);
            Console.Read();
        }
        static int SumCalculater(int n1,int n2)
        {
            return n1 + n2;
        }
    }
}
