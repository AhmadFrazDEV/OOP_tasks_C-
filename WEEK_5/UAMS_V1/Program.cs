using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS_V1.BL;

namespace UAMS_V1
{
    class Program
    {
        static List<Student> studentlist = new List<Student>();
        static List<DegreeProgram> programlist = new List<DegreeProgram>();
        static Student studentPresent(string name)
        {
            foreach (Student s in studentlist)
            {
                if (name == s.Name && s.regDegree != null)
                {
                    return s;
                }
            }
            return null;
        }
        static void Calculatefeeforall()
        {
            foreach (Student s in studentlist)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.Name + " has " + s.calculatefee() + " fees");
                }
            }
        }
        static void registerSubject(Student s)
        {
            Console.WriteLine("Enter how many subject you want to register");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter the Subject Code");
                string code = Console.ReadLine();
                bool Flag = false;
                foreach (Subject sub in s.regDegree.subjects)
                {
                    if (code == sub.code && !(s.Regsubjects.Contains(sub))) ;
                    {
                        s.registerStudentSubject(sub);
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
        static List<Student> sortstudent()
        {
            List<Student> sortedlist = new List<Student>();
            foreach(Student s in studentlist)
            {
                s.calculateMerit();
            }
            sortedlist = studentlist.OrderByDescending(s => s.Merit).ToList();
            return sortedlist;
        }

        static void giveAdmission(List<Student> sortedlist)
        {
            foreach(Student s in sortedlist)
            {
                foreach(DegreeProgram d in s.preference)
                {
                    if(d.seat > 0 && s.regDegree == null)
                    {
                        s.regDegree = d;
                        d.seat--;
                        break;
                    }
                }
            }
        }
        static void printStudent()
        {
            foreach(Student s in studentlist)
            {
                if(s.regDegree != null)
                {
                    Console.WriteLine(s.Name + " Got Admission in " + s.regDegree.Title);

                }
                else
                {
                    Console.WriteLine(s.Name + " not Got Admission");
                }
            }
        }
        static void clearscreen()
        {
            Console.WriteLine("Press any Key TO continue");
            Console.ReadKey();
            Console.Clear();
        }

        static void viewstudentDegree(string Degname)
        {
            Console.WriteLine("Name \t Fsc \t Ecat \t Age");
            foreach(Student s in studentlist)
            {
                if(s.regDegree !=null)
                {
                    if(Degname == s.regDegree.Title)
                    {
                        Console.WriteLine(s.Name + "\t" + s.Fsc + "\t" + s.Ecat + "\t" + s.Age);
                    }
                }
            }
        }
        static void viewRegisterStudent()
        {
            Console.WriteLine("Name \t Fsc \t Ecat \t Age");
            foreach (Student s in studentlist)
            {
                if (s.regDegree != null)
                {
                   Console.WriteLine(s.Name + "\t" + s.Fsc + "\t" + s.Ecat + "\t" + s.Age);
                  
                }
            }
        }
        static void AddIntoDegreeList(DegreeProgram d)
        {
            programlist.Add(d);
        }
        static DegreeProgram takeinputforDegree()
        {
            string Degname;
            float duration;
            int seat;
            Console.WriteLine("Enter Degree Name");
            Degname = Console.ReadLine();
            Console.WriteLine("Enter Degree Duartion");
            duration = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Seat of this Degree");
            seat = int.Parse(Console.ReadLine());

            DegreeProgram Deg = new DegreeProgram(Degname, duration, seat);
            Console.WriteLine("How many Subject to Enter");
            int count = int.Parse(Console.ReadLine());
            for(int x=0;x<count;x++)
            {
                Deg.Addsubject(takeinputforsubject());
            }
            return Deg;

        }
        static Subject takeinputforsubject()
        {
            string code;
            string type;
            int ch;
            int subjectfee;
            Console.WriteLine("Enter Subject Code");
            code = Console.ReadLine();
            Console.WriteLine("Enter Course type");
            type = Console.ReadLine();
            Console.WriteLine("Enter Subject fee");
            subjectfee = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Credit Hour");
            ch = int.Parse(Console.ReadLine());
            Subject sub = new Subject(code, type, ch, subjectfee);
            return sub;
        }
        static void AddintoStudentlist(Student s)
        {
            studentlist.Add(s);
        }
        static Student takeinputforstudent()
        {
            string name;
            int age;
            float fscmarks;
            float ecat;
            List<DegreeProgram> preferance1 = new List<DegreeProgram>();
            Console.WriteLine("Enter Name ");
            name = Console.ReadLine();
            Console.WriteLine("ENter Age ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("ENter Fsc Marks");
            fscmarks = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ecat marks ");
            ecat = float.Parse(Console.ReadLine());
            Console.WriteLine("Available Degree Program");
            viewDegreeProgram();
            Console.WriteLine("Enter How many prefeance you want to enter");
            int count = int.Parse(Console.ReadLine());
            for(int i=0;i<count;i++)
            {
                Console.WriteLine("Enter Degree Name ");
                string Degname = Console.ReadLine();
                bool flag=false;
                foreach(DegreeProgram dp in programlist)
                {
                    if(Degname==dp.Title && !(preferance1.Contains(dp)))
                    {
                        preferance1.Add(dp);
                        flag = true;
                    }
                }
                if(flag == false)
                {
                    Console.WriteLine("Enter Valid Degree Program");
                    i--;
                }

            }
            Student s = new Student(name, age, fscmarks, ecat, preferance1);
            return s;
        }
        static void viewDegreeProgram()
        {
            foreach(DegreeProgram dp in programlist)
            {
                Console.WriteLine(dp.Title);
            }
        }
        static void header()
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("                  UAMS                   ");
            Console.WriteLine("*****************************************");
        }
        static void viewSubject(Student s)
        {
            if(s.regDegree != null)
            {
                Console.WriteLine("Suject Code \t Subject type");
                foreach(Subject sub in s.regDegree.subjects)
                {
                    Console.WriteLine(sub.code + " \t \t" + sub.SubjectType);
                }
            }

        }
        static char menu()
        {
            header();
            Console.WriteLine("1. AddStudent");
            Console.WriteLine("2. Add Degree Program");
            Console.WriteLine("3. Generate Merit");
            Console.WriteLine("4. view Register Student");
            Console.WriteLine("5. View Student of specific Program");
            Console.WriteLine("6. Register Subject for Specific Student");
            Console.WriteLine("7. Calculate fee For all Register Student");
            Console.WriteLine("8. Exit");
            Console.WriteLine("Your Option");
            char option = char.Parse(Console.ReadLine());
            return option;
        }
        static void Main(string[] args)
        {
            while(true)
            {
                char option = menu();
                clearscreen();
                if (option == '1')
                {
                    if (programlist.Count > 0)
                    {
                        Student s = takeinputforstudent();
                        AddintoStudentlist(s);
                    }
                }
                else if (option == '2')
                {
                    DegreeProgram d = takeinputforDegree();
                    AddIntoDegreeList(d);
                }
                else if (option == '3')
                {
                    List<Student> sortedstudent = new List<Student>();
                    sortedstudent = sortstudent();
                    giveAdmission(sortedstudent);
                    printStudent();
                }
                else if (option == '4')
                {
                    viewRegisterStudent();
                }
                else if (option == '5')
                {
                    string name;
                    Console.WriteLine("Enter Degree Name");
                    name = Console.ReadLine();
                    viewstudentDegree(name);
                }
                else if (option == '6')
                {
                    Console.WriteLine("Enter Student Name");
                    string name = Console.ReadLine();
                    Student s = studentPresent(name);
                    if (s != null)
                    {
                        viewSubject(s);
                        registerSubject(s);
                    }
                }
                else if (option == '7')
                {
                    Calculatefeeforall();
                }
                else if (option == '8')
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
