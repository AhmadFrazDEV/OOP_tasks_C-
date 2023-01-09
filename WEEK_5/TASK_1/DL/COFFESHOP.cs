using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.BL;

namespace Task_1.DL
{
    class COFFESHOP
    {
        public static List<MenuItems> Menu = new List<MenuItems>();
        public static List<string> Orders = new List<string>();
        public static void readData(string Path)
        {
            StreamReader Shop = new StreamReader(Path);
            string Record;
            if(File.Exists(Path))
            {
                while((Record = Shop.ReadLine()) != null)
                {
                    string[] SplitRecord = Record.Split(',');
                    string Name = SplitRecord[0];
                    string Type = SplitRecord[1];
                    int Price = int.Parse(SplitRecord[2]);
                    MenuItems Menu1 = new MenuItems(Name, Type, Price);
                    AddItemsintoList(Menu1);
                }
                Shop.Close();
                Console.WriteLine("Data Loaded Successfully");
            }
        }
        public static void storeData(string Path,MenuItems Menu1)
        {
            StreamWriter SLine = new StreamWriter(Path, true);
            SLine.WriteLine(Menu1.getName() + "," + Menu1.getType() + "," + Menu1.getPrice());
            SLine.Flush();
            SLine.Close();
        }
        public static void AddItemsintoList(MenuItems ItemDetails)
        {
            Menu.Add(ItemDetails);
        }
        public static void AddOrder(List<string> Order)
        {
            Orders.AddRange(Order);
        }
        public static void fulfillOrder()
        {
            for (int i = 0; i < Orders.Count; i++)
            {
                Console.WriteLine("The {0} is Ready", Orders[i]);
                Orders.RemoveAt(i);
            }
            if (Orders.Count == 0)
            {
                Console.WriteLine("All Orders Have been fulfilled");
            }
        }
        public static List<string> listOrders()
        {
            return Orders;
        }
        public static string cheapestItem()
        {
            MenuItems Temp;
            for (int i = 0; i < Menu.Count; i++)
            {
                for (int y = 0; y < Menu.Count - 1; y++)
                {
                    if (Menu[y].getPrice() > Menu[y + 1].getPrice())
                    {
                        Temp = Menu[y];
                        Menu[y] = Menu[y + 1];
                        Menu[y + 1] = Temp;
                    }
                }
            }
            return Menu[0].getName();
        }
        public static List<string> drinkOnly()
        {
            List<string> Temp = new List<string>();
            for (int i = 0; i < Menu.Count; i++)
            {
                if (Menu[i].getType() == "DRINK")
                {
                    Temp.Add(Menu[i].getName());
                }
            }
            return Temp;
        }
        public static List<string> foodOnly()
        {
            List<string> Temp = new List<string>();
            for (int i = 0; i < Menu.Count; i++)
            {
                if (Menu[i].getType() == "FOOD")
                {
                    Temp.Add(Menu[i].getName());
                }
            }
            return Temp;
        }

        public static void viewOrderList()
        {
            for(int i=0;i<Orders.Count;i++)
            {
                Console.WriteLine("Product Name is " + Orders[i] );
            }
        }
        public static float totalPayableAmount()
        {
            float Amount = 0F;
            for(int i=0;i<Orders.Count;i++)
            {
                for(int y=0;y<Menu.Count;y++)
                {
                    if(Orders[i] == Menu[y].getName())
                    {
                        Amount = Amount + Menu[y].getPrice();
                    }
                }
            }
            return Amount;
        }
    }
}
