using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_2.UI
{
    class CUSTOMERVIEW
    {
        public static char Customermenu()
        {
            Console.WriteLine("1. View All Products");
            Console.WriteLine("2. Buy The Products");
            Console.WriteLine("3. Generate Invoice");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Your Option");
            char option = char.Parse(Console.ReadLine());
            return option;
        }
        
    }
}
