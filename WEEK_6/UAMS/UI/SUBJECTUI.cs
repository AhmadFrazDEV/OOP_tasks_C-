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
    class SUBJECTUI
    {
        public static SUBJECTSBL takeInput()
        {
            string Code;
            string Type;
            int CH;
            int Fee;
            Console.WriteLine("Enter Subject Code");
            Code = Console.ReadLine();
            Console.WriteLine("Enter Subject Type");
            Type = Console.ReadLine();
            Console.WriteLine("Enter Credit Hour of This Subject");
            CH = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Subject Fee");
            Fee = int.Parse(Console.ReadLine());
            SUBJECTSBL Subject = new SUBJECTSBL(Code, Type, CH, Fee);
            return Subject;
        }
        public static void viewSubject(STUDENTBL Student)
        {
            if(Student.RegisterDegree!= null)
            {
                Console.WriteLine("SUbject Code\t CreditHour \t Subject Type");
                foreach(SUBJECTSBL sub in Student.RegisterDegree.Subjects)
                {
                    Console.WriteLine(sub.getSubjectCode() + " \t " + sub.getCH() + "\t" + sub.getSubjectType());
                }
            }
        }
        public static void registerSubject(STUDENTBL s)
        {
            Console.WriteLine("Enter how many subject you want to register");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter the Subject Code");
                string code = Console.ReadLine();
                bool Flag = false;
                foreach (SUBJECTSBL sub in s.RegisterDegree.Subjects)
                {
                    if (code == sub.getSubjectCode() && !(s.EnrollSubjects.Contains(sub))) ;
                    {
                        s.registerSubjects(sub);
                        Flag = true;
                        break;
                    }
                }
                if (Flag == false)
                {
                    Console.WriteLine("Enter valid Course");
                    i--;
                }
            }
        }

    }
}
