using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Clock_Type;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour, mintue, second;
            Console.WriteLine("Enter Time in Hour");
            hour = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Time in Mintue");
            mintue = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Time in Second");
            second = int.Parse(Console.ReadLine());
            Class1 time = new Class1(hour, mintue, second);
            Console.WriteLine("{0} {1} {2} ", time.hour, time.mint, time.sec);
            Console.WriteLine("Time After Increment In Second");
            Console.WriteLine("   ");
            time.SecondIncrement(hour, mintue, second);
            Console.WriteLine("{0} {1} {2} ", time.hour, time.mint, time.sec);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Time After Increment In Mintue");
            Console.WriteLine("   ");
            time.MintueIncrement(hour, mintue, second);
            Console.WriteLine("{0} {1} {2} ", time.hour, time.mint, time.sec);
            Console.WriteLine("Time After Increment In Hour");
            Console.WriteLine("   ");
            time.HourIncrement(hour, mintue, second);
            Console.WriteLine("{0} {1} {2} ", time.hour, time.mint, time.sec);
            Console.ReadLine();

        }
    }
}
