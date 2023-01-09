using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.UI
{
    class MENUUI
    {
        public static void header()
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("                  UAMS                   ");
            Console.WriteLine("*****************************************");
        }
        public static void clearScreen()
        {
            Console.WriteLine("Press Any Key to Continue");
            Console.ReadLine();
            Console.Clear();
        }
        public static char menu()
        {
            header();
            Console.WriteLine("1. AddStudent");
            Console.WriteLine("2. Add Degree Program");
            Console.WriteLine("3. Generate Merit");
            Console.WriteLine("4. view Register Student");
            Console.WriteLine("5. View Student of specific Program");
            Console.WriteLine("6. Register Subject for Specific Student");
            Console.WriteLine("7. Calculate fee For all Register Student");
            Console.WriteLine("8. Exit");
            Console.WriteLine("Your Option");
            char option = char.Parse(Console.ReadLine());
            return option;
        }
    }
}
