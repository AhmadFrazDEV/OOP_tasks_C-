using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK_2.BL;

namespace TASK_2.DL
{
    class LOGINDL
    {
        public static List<LoginCLass> Data = new List<LoginCLass>();
        public static void AddUserIntoList(LoginCLass User)
        {
            Data.Add(User);
        }
        public static void loadLoginDataFromFIle(string Path)
        {
            StreamReader ULine = new StreamReader(Path);
            string Record;
            if(File.Exists(Path))
            {
                while((Record = ULine.ReadLine())!=null)
                {
                    string[] SplitRecord = Record.Split(',');
                    string Name = SplitRecord[0];
                    string Role = SplitRecord[2];
                    string Password = SplitRecord[1];
                    LoginCLass Temp = new LoginCLass(Name, Password, Role);
                    Data.Add(Temp);
                }
                ULine.Close();
                Console.WriteLine("Data Loaded Successfully ");
            }
        }
        public static void storeData(string Path,LoginCLass Temp)
        {
            StreamWriter Writer = new StreamWriter(Path, true);
            Writer.WriteLine(Temp.getName() + "," + Temp.getPassword() + "," + Temp.getRole());
            Writer.Flush();
            Writer.Close();
        }
        public static bool IsAdmin()
        {
            Console.WriteLine("Enter Login Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Login Password");
            string Password = Console.ReadLine();
            for(int i=0;i<Data.Count;i++)
            {
                if(Name == Data[i].getName() && Password == Data[i].getPassword())
                {
                    if (Data[i].getRole() == "ADMIN") 
                    return true;
                }
            }
            return false;
        }
        public static bool IsCustomer()
        {
            Console.WriteLine("Enter Login Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Login Password");
            string Password = Console.ReadLine();
            for (int i = 0; i < Data.Count; i++)
            {
                if (Name == Data[i].getName() && Password == Data[i].getPassword())
                {
                    if (Data[i].getRole() == "NA") 
                    return true;
                }
            }
            return false;
        }
    }
}
