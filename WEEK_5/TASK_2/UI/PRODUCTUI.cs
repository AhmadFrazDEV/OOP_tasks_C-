using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK_2.BL;
using TASK_2.DL;

namespace TASK_2.UI
{
    class PRODUCTUI
    {
        public static PRODUCT AddProduct(string Path)
        {
            Console.WriteLine("Enter Name Of Products");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Category Of Products (Grocery,furit,other)");
            string Category = Console.ReadLine();
            Category = Category.ToUpper();
            Console.WriteLine("Enter Price Of Products");
            float Price = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Quantity of this Product");
            int Qunatity = int.Parse(Console.ReadLine());
            PRODUCT Item = new PRODUCT(Name, Category, Price, Qunatity);
            SAVING.storeData(Path, Item);
            return Item;
        }

        public static LoginCLass SignUp(string Path)
        {
            string Name, Password, Role;
            Console.WriteLine("Enter Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Password");
            Password = Console.ReadLine();
            Console.WriteLine("Enter Role if Admin or NA");
            Role = Console.ReadLine();
            Role = Role.ToUpper();
            LoginCLass Data = new LoginCLass(Name,Password,Role);
            LOGINDL.AddUserIntoList(Data);
            LOGINDL.storeData(Path, Data);
            return Data;
        }
    }
}
