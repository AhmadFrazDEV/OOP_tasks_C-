using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example8
{
    class Program
    {
        static void Main(string[] args)
        {
            int age,price,unit;
            Console.Write("Enter age ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter price of washing machine ");
            price = int.Parse(Console.ReadLine());
            Console.Write("how many toy she sold ");
            unit = int.Parse(Console.ReadLine());
            int toycount=0, pricecount=0;
            int saving = 0;
            for(int i=1;i<=age;i++)
            {
                if(i%2 == 0)
                {
                    pricecount=pricecount+1;
                    saving = saving + pricecount*(10);
                }
                else
                {
                    toycount=toycount+1;
                }
            }
            int toyprice = toycount * unit;
            int totalsaving = saving + toyprice - pricecount;
            if (totalsaving > price)
            {
                Console.WriteLine("yes!");
                totalsaving = totalsaving - price;
                Console.Write("remaining is {0}", totalsaving);
            }
            else
            {
                Console.WriteLine("No!");
                totalsaving = totalsaving - price;
                Console.Write("remaining is {0}", totalsaving);
            }
            Console.Read();
            

        }
    }
}
