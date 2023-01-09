using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example10
{
    class Program
    {
        static string[] password = new string[5];
        static string[] name = new string[5];
        static int count = 0;
        static void Main(string[] args)
        {
            load();
            while (true)
            {
                int option = menu();
                if (option == 1)
                {
                    signup();
                }
                else if (option == 2)
                {
                    login();
                }
                else if (option == 3)
                {
                    break;
                }
                else
                {
                    continue;
                }

            }
            store();
        }
        //--------------------------------------menu of login system------------------------
        static int menu()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1.sign up");
            Console.WriteLine("2.login up");
            Console.WriteLine("3.exit ");
            int option = 0;
            Console.WriteLine("your option ");
            option = int.Parse(Console.ReadLine());
            return option;

        }
        //---------------------------------------signup option-------------------------------
        static void signup()
        {
            Console.WriteLine("enter name");
            name[count] = Console.ReadLine();
            Console.WriteLine("enter password");
            password[count] = Console.ReadLine();
            count = count + 1;
        }
        //--------------------------------------login function-------------------------------
        static void login()
        {
            string loginname;
            string loginpassword;
            Console.Write("enter name ");
            loginname = Console.ReadLine();
            Console.Write("enter password ");
            loginpassword = Console.ReadLine();
            for (int i = 0; i <= count; i++)
            {

                if (loginname == name[i] && loginpassword == password[i])
                {
                    ConsoleColor recentForegroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("your login : ");
                    Console.ForegroundColor = recentForegroundColor;

                }
            }

        }
        //------------------------------------store function---------------------
        static void store()
        {
            string path = "datafile.txt";
            StreamWriter Filevariable = new StreamWriter(path);
            for (int i = 0; i < count; i++)
            {
                Filevariable.Write(name[i]);
                Filevariable.Write(",");
                Filevariable.WriteLine(password[i]);
            }
            Filevariable.Flush();
            Filevariable.Close();
        }
        //--------------------------------load function---------------------------
        static void load()
        {
            string path = "D:\\S_2\\OOP_LAB\\WEEK_1\\Example10\\bin\\Debug\\datafile.txt";
            if(File.Exists(path))
            {
                StreamReader filevariable = new StreamReader(path);
                string record;
                while ((record = filevariable.ReadLine()) != null)
                {
                    name[count] = parserecord(record, 0);
                    password[count] = parserecord(record, 1);
                    count++;
                }
                filevariable.Close();
            }
        }
        static string parserecord(string record, int field)
        {
            int commacount = 0;
            string item = "";
            for(int i=0;i<record.Length;i++)
            {
                if(record[i] == ',')
                {
                    commacount = commacount + 1;
                }
                else if(commacount == field)
                {
                    item = item + record[i];
                }
            }
            return item;
        }
    }
}
