using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_2.UI
{
    class LOGINUI
    {
        public static char loginmenu()
        {
            Console.WriteLine("1. SignUp");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Your Option");
            char option = char.Parse(Console.ReadLine());
            return option;
        }
        public static char Menu()
        {
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. Customer");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Your Option");
            char option = char.Parse(Console.ReadLine());
            return option;
        }
    }
}
