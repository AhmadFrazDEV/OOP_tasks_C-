using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGNIN.BL;

namespace SIGNIN
{
    class Program
    {
        static char menu()
        {
            Console.WriteLine("1.Sign up");
            Console.WriteLine("2.Log in");
            Console.WriteLine("3.Exit");
            Console.WriteLine("your option");
            char option;
            option = char.Parse(Console.ReadLine());
            return option;
        }
        static void Main(string[] args)
        {
            List<Class1> login = new List<Class1>();
            load(login);
            while(true)
            {
                char option=menu();
                if(option == '1')
                {
                    login.Add(signup());
                }
                else if(option == '2')
                {
                    signin(login);
                }
                else if(option == '3')
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            store(login);
        }
        static void store(List<Class1> login)
        {
            string path = "datafile.txt";
            StreamWriter Filevariable = new StreamWriter(path);
            for (int i = 0; i < login.Count; i++)
            {
                Filevariable.Write(login[i].name);
                Filevariable.Write(",");
                Filevariable.WriteLine(login[i].password);
            }
            Filevariable.Flush();
            Filevariable.Close();
        }
        static void load(List<Class1> login)
        {
            Class1 log=new Class1();
            string path = "D:\\S_2\\OOP_LAB\\WEEK_2\\SIGNIN\\bin\\Debug\\datafile.txt";
            if (File.Exists(path))
            {
                StreamReader filevariable = new StreamReader(path);
                string record;
                while ((record = filevariable.ReadLine()) != null)
                {
                    log.name= parserecord(record, 0);
                    log.password = parserecord(record, 1);
                    login.Add(log);
                }
                filevariable.Close();
            }
        }
        static string parserecord(string record, int field)
        {
            int commacount = 0;
            string item = "";
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == ',')
                {
                    commacount = commacount + 1;
                }
                else if (commacount == field)
                {
                    item = item + record[i];
                }
            }
            return item;
        }
        static void signin(List<Class1> login)
        {
            string name;
            string password;
            Console.WriteLine("Enter Login Name ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Login Password ");
            password = Console.ReadLine();
            for(int i=0;i<login.Count;i++)
            {
                if(name == login[i].name && password == login[i].password )
                {
                    Console.WriteLine("Welcome Your Login");
                }
            }
        }
        static Class1 signup()
        {
            Class1 login = new Class1();
            Console.WriteLine("ENter name ");
            login.name = Console.ReadLine();
            Console.WriteLine("Enter password");
            login.password = Console.ReadLine();
            return login;
            
        }
    }
}
