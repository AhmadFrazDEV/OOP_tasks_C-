using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK_2.DL;
using TASK_2.BL;

namespace TASK_2.UI
{
    class PRODUCTMENU
    {
        public static char menu()
        {
            Console.WriteLine("1. Add Products");
            Console.WriteLine("2. View All Products");
            Console.WriteLine("3. Find Products with Highest Unit Price");
            Console.WriteLine("4. View Sales Tax of All Products");
            Console.WriteLine("5. Products to be Orders");
            Console.WriteLine("6. Exit");
            Console.WriteLine("Your Option");
            char option = char.Parse(Console.ReadLine());
            return option;
        }
        public static void ViewAllProducts()
        {
            Console.WriteLine("Name\t\tCategory\t\tPrice\t\tQuantity");
            for (int i = 0; i < SAVING.STOCK.Count; i++)
            {
                Console.WriteLine(SAVING.STOCK[i].getName() + "\t\t\t" + SAVING.STOCK[i].getCategory() + "\t\t\t" + SAVING.STOCK[i].getPrice() + "\t\t\t" + SAVING.STOCK[i].getQuantity());

            }
        }
        public static void HighestPrice()
        {
            for (int i = 0; i < SAVING.STOCK.Count; i++)
            {
                for (int y = 0; y < SAVING.STOCK.Count - 1; y++)
                {
                    if (SAVING.STOCK[y].getPrice() < SAVING.STOCK[y + 1].getPrice())
                    {
                        PRODUCT temp = new PRODUCT();
                        temp = SAVING.STOCK[y];
                        SAVING.STOCK[y] = SAVING.STOCK[y + 1];
                        SAVING.STOCK[y + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Product with highest Price is ");
            Console.WriteLine();
            Console.WriteLine(SAVING.STOCK[0].getName() + "\t\t\t" + SAVING.STOCK[0].getCategory() + "\t\t\t" + SAVING.STOCK[0].getPrice() + "\t\t\t" + SAVING.STOCK[0].getQuantity());
        }
    }
   
}
