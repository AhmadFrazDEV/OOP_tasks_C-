using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK_1.BL;

namespace TASK_1.UI
{
    class MENUUI
    {
        public static string menu()
        {
            Console.WriteLine("1. Make a Line");
            Console.WriteLine("2. Update The begin point");
            Console.WriteLine("3. Update the End point");
            Console.WriteLine("4. Show the update point");
            Console.WriteLine("5. Show the end point");
            Console.WriteLine("6. Get the Length of line");
            Console.WriteLine("7. Get the Gradient of the line");
            Console.WriteLine("8. Find the distance of begin point from zero coordinate");
            Console.WriteLine("9. Find the distance of end point from Zero coordinate");
            Console.WriteLine("10. Exit");
            Console.WriteLine("Your Option");
            string option = Console.ReadLine();
            return option;

        }
    }
}
