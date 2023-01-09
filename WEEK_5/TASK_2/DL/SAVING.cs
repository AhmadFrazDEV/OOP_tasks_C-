using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK_2.UI;
using TASK_2.BL;
using System.IO;

namespace TASK_2.DL
{
    class SAVING
    {
        public static List<PRODUCT> STOCK = new List<PRODUCT>();
        
        public static void readData(string Path)
        {
            StreamReader SLine = new StreamReader(Path);
            string Record;
            if(File.Exists(Path))
            {
                while((Record = SLine.ReadLine())!=null)
                {
                    string[] SplitRecord = Record.Split(',');
                    string Name = SplitRecord[0];
                    string Category = SplitRecord[1];
                    int Price = int.Parse(SplitRecord[2]);
                    int Quantity = int.Parse(SplitRecord[3]);
                    PRODUCT Item = new PRODUCT(Name, Category, Price, Quantity);
                    AddDataIntoList(Item);
                }
                SLine.Close();
                Console.WriteLine("Data Loaded ");
            }
        }
        public static void storeData(string Path,PRODUCT Item)
        {
            StreamWriter SLine = new StreamWriter(Path, true);
            SLine.WriteLine(Item.getName() + "," + Item.getCategory() + "," + Item.getPrice() + "," + Item.getQuantity());
            SLine.Flush();
            SLine.Close();
        }
        public static void AddDataIntoList(PRODUCT Data)
        {
            STOCK.Add(Data);
        }
        public static float TaxCalculater()
        {
            float result = 0;
            float tax = 0;
            for(int i=0;i<STOCK.Count;i++)
            {
                if (STOCK[i].getCategory() == "GROCERY")
                {
                    tax = (STOCK[i].getPrice() * 10) / 100;
                    tax = tax * STOCK[i].getQuantity();
                    
                }
                else if (STOCK[i].getCategory() == "FURIT")
                {
                    tax = (STOCK[i].getPrice() * 5) / 100;
                    tax = tax * STOCK[i].getQuantity();
                }
                else
                {
                    tax = (STOCK[i].getPrice() * 15) / 100;
                    tax = tax * STOCK[i].getQuantity();
                }
                result = result + tax;
            }
            return result;
        }
        public static void Threshold()
        {
            for(int i=0;i<STOCK.Count;i++)
            {
                if(STOCK[i].getQuantity() < 10)
                {
                    Console.WriteLine("The Qunatity Of the {0} is less than Threshold", STOCK[i].getName());
                    string option;
                    Console.WriteLine("Enter Yes if You want to order Products ");
                    option = Console.ReadLine();
                    if(option == "Yes")
                    {
                        int Quantity;
                        Console.WriteLine("How Many Qunatity You Want to Order " + STOCK[i].getName());
                        Quantity = int.Parse(Console.ReadLine());
                        int Result = STOCK[i].getQuantity() + Quantity;
                        STOCK[i].setQuantity(Result);
                    }
                }
            }
        }
        public static float TaxInvoice(PRODUCT Name,float Quantity)
        {
            float Tax = 0;
            if (Name.getCategory() == "GROCERY")
            {
                float result = Name.getPrice() * Quantity;
                Tax = (result * 10) / 100;
            }
            else if (Name.getCategory() == "FURIT")
            {
                float result = Name.getPrice() * Quantity;
                Tax = (result * 5) / 100;
            }
            else
            {
                float result = Name.getPrice() * Quantity;
                Tax = (result * 15) / 100;
            }
            return Tax;
        }
        public static float BuyProducts()
        {
            string Name;
            int Quantity;
            float Price=0;
            float Tax=0;
            int Ord = 0;
            Console.WriteLine("How Many product you want to buy : ");
            Ord = int.Parse(Console.ReadLine());
            for (int o = 0; o < Ord; o++)
            {
                Console.WriteLine("Enter Product Name ");
                Name = Console.ReadLine();
                for (int i = 0; i < STOCK.Count; i++)
                {
                    if (Name == STOCK[i].getName())
                    {
                        Console.WriteLine("How Many Quantity you want to buy ");
                        Quantity = int.Parse(Console.ReadLine());
                        if (Quantity <= STOCK[i].getQuantity())
                        {
                            int Result = STOCK[i].getQuantity() - Quantity;
                            STOCK[i].setQuantity(Result);
                            Price = Quantity * STOCK[i].getPrice();
                            Console.WriteLine("Price is " + Price);
                            Tax = TaxInvoice(STOCK[i], Quantity);
                            Price = Price + Tax;
                        }
                    }
                }
            }
            return Price;
        }
    }
}
