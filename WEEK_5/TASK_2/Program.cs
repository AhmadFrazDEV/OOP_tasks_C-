using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK_2.BL;
using TASK_2.UI;
using TASK_2.DL;

namespace TASK_2
{
    class Program
    {
        public static string PPath = "Product.txt";
        public static string UPath = "User.txt";
        static void Main(string[] args)
        {
            SAVING.readData(PPath);
            LOGINDL.loadLoginDataFromFIle(UPath);
            while(true)
            {
                Console.ReadLine();
                Console.Clear();
                char option = LOGINUI.loginmenu();
                if(option == '1')
                {
                    LoginCLass Muser;
                    Muser = PRODUCTUI.SignUp(PPath);
                    LOGINDL.AddUserIntoList(Muser);
                }
                else if(option == '2')
                {
                    while(true)
                    {
                        Console.ReadLine();
                        Console.Clear();
                        char Option = LOGINUI.Menu();
                        if(Option == '1')
                        {
                            bool Checker = LOGINDL.IsAdmin();
                            if (Checker == true)
                            {
                                Admin();
                            }
                            
                        }
                        else if (Option == '2')
                        {
                            bool Checker1 = LOGINDL.IsCustomer();
                            if (Checker1 == true)
                            {
                                Customer();
                            }
                        }
                        else if (Option == '3')
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    
                }
                else if(option  == '3')
                {
                    break;
                }
                else
                {
                    continue;
                }
            }

        }
        static void Customer()
        {
            float Tax=0;
            while(true)
            {
                Console.ReadKey();
                Console.Clear();
                char option = CUSTOMERVIEW.Customermenu();
                if(option == '1')
                {
                    PRODUCTMENU.ViewAllProducts();
                }
                else if(option == '2')
                {
                    Tax=Tax+SAVING.BuyProducts();
                   
                }
                else if(option == '3')
                {
                    Console.WriteLine("Total Invoice Apply on Your Product is " + Tax);
                }
                else if(option == '4')
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        static void Admin()
        {
            while(true)
            {
                Console.ReadLine();
                Console.Clear();
                char option = PRODUCTMENU.menu();
                if(option == '1')
                {

                    PRODUCT Item = PRODUCTUI.AddProduct(PPath);
                    SAVING.AddDataIntoList(Item);     
                }
                else if(option == '2')
                {
                    PRODUCTMENU.ViewAllProducts();
                }
                else if(option == '3')
                {
                    PRODUCTMENU.HighestPrice();
                }
                else if(option == '4')
                {
                    float result=SAVING.TaxCalculater();
                    Console.WriteLine("Total tax of All product is " + result);
                }
                else if(option == '5')
                {
                    SAVING.Threshold();
                }
                else if(option == '6')
                {
                    break;
                }
                else
                {
                    continue;
                }

            }
        }
        
    }
}
