using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1=new int[3];
            Console.Write("enter 3 number :");
            for(int i=0;i<3;i++)
            {
                num1[i] = int.Parse(Console.ReadLine());
            }
            int largest = num1[0];
            for(int i=0;i<3;i++)
            {
                if(largest < num1[i])
                {
                    largest = num1[i];
                }
            }
            Console.Write("largest number is {0} ", largest);
            Console.Read();
        }
    }
}
