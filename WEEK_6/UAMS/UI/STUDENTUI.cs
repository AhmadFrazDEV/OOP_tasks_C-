using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using UAMS.DL;
using UAMS.UI;

namespace UAMS.UI
{
    class STUDENTUI
    {
        public static STUDENTBL takeInputForStudent()
        {
            string name;
            int age;
            float fscmarks;
            float ecat;
            List<DEGREEPROGRAMBL> preferance1 = new List<DEGREEPROGRAMBL>();
            Console.WriteLine("Enter Name ");
            name = Console.ReadLine();
            Console.WriteLine("ENter Age ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("ENter Fsc Marks");
            fscmarks = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ecat marks ");
            ecat = float.Parse(Console.ReadLine());
            Console.WriteLine("Available Degree Program");
            DEGREEUI.viewAllProgram();
            Console.WriteLine("Enter How many prefeance you want to enter");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter Degree Name ");
                string Degname = Console.ReadLine();
                bool flag = false;
                foreach (DEGREEPROGRAMBL dp in DEGREEPROGRAMDL.ProgramList)
                {
                    if (Degname == dp.getDName() && !(preferance1.Contains(dp)))
                    {
                        preferance1.Add(dp);
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("Enter Valid Degree Program");
                    i--;
                }
            }
            STUDENTBL s = new STUDENTBL(name, age, fscmarks, ecat, preferance1);
            return s;
        }
        public static void Calculatefeeforall()
        {
            foreach (STUDENTBL s in STUDENTDL.StudentList)
            {
                if (s.RegisterDegree != null)
                {
                    Console.WriteLine(s.getName() + " has " + s.calculateSubjectFee() + " fees");
                }
            }
        }
        public static void printStudent()
        {
            foreach (STUDENTBL s in STUDENTDL.StudentList)
            {
                if (s.RegisterDegree != null)
                {
                    Console.WriteLine(s.getName() + " Got Admission in " + s.RegisterDegree.getDName());

                }
                else
                {
                    Console.WriteLine(s.getName() + " not Got Admission");
                }
            }
        }
        public static void viewRegisterStudent()
        {
            Console.WriteLine("Name \t Fsc \t Ecat \t Age");
            foreach (STUDENTBL s in STUDENTDL.StudentList)
            {
                if (s.RegisterDegree != null)
                {
                    Console.WriteLine(s.getName() + "\t" + s.getFsc() + "\t" + s.getEcat() + "\t" + s.getAge());

                }
            }
        }
        public static void viewStudentDegree(string Degname)
        {
            Console.WriteLine("Name \t Fsc \t Ecat \t Age");
            foreach (STUDENTBL s in STUDENTDL.StudentList)
            {
                if (s.RegisterDegree != null)
                {
                    if (Degname == s.RegisterDegree.getDName())
                    {
                        Console.WriteLine(s.getName() + "\t" + s.getFsc() + "\t" + s.getEcat() + "\t" + s.getAge());
                    }
                }
            }
        }
        public static void viewSubject(STUDENTBL s)
        {
            if (s.RegisterDegree != null)
            {
                Console.WriteLine("Suject Code \t Subject type");
                foreach (SUBJECTSBL sub in s.RegisterDegree.Subjects)
                {
                    Console.WriteLine(sub.getSubjectCode() + " \t \t" + sub.getSubjectType());
                }
            }

        }

    }
}
