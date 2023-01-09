using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version_3.Classes
{
    class Class1
    {
        public string name;
        public string fathername;
        public string studentrollnumber;
        public string studentcnic;
        public string studentcourse;
        public string studentpassword;
        public string studentbankid;
        public string studentsection;
        public float studentmarks;

        public void changepassword(List<Class1> student, int i)
        {
            string changer;
            Console.WriteLine("Enter forget || change for changing the password ");
            changer = Console.ReadLine();
            if (changer == "forget" || changer == "change")
            {
                Console.WriteLine("Enter CNIC number and name ");
                string name, phone;
                name = Console.ReadLine();
                phone = Console.ReadLine();
                if (name == student[i].name && phone == student[i].studentcnic)
                {
                    Console.WriteLine("Enter New Password ");
                    student[i].studentpassword = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You Enter Wrong Value Please Try Again");
                }

            }
        }



        public Class1 (string name,string father_name,string studentrollnumber,string studentcnic,string studentcourse,string studentpassword,string section, string bankid, float marks)
        {
            this.name = name;
            fathername=father_name;
            this.studentrollnumber = studentrollnumber;
            this.studentcnic = studentcnic;
            this.studentcourse = studentcourse;
            this.studentpassword =studentpassword;
            studentbankid = bankid;
            studentsection =section;
            studentmarks =marks;    
        }
        public Class1()
        {

        }

        public string teachername;
        public string teacherpost;
        public string teachersubject;
        public string teacherpassword;
        public string teachercnic;
        public string teacherphone;
        public string teacherid;
        public int teachersalary;

        public Class1(string name, string post, string cnic, string id, string password, string subject, string phone, int salary)
        {
            teachername = name;
            teacherpost = post;
            teacherid = id;
            teachercnic = cnic;
            teacherpassword = password;
            teachersalary = salary;
            teachersubject = subject;
            teacherphone = phone;
            Console.WriteLine("Data Added");
        }



        public void displayRecord(List<Class1> student, List<Class1> Teacher)
        {
            for (int i = 0; i < student.Count; i++)
            {
                Class1 studenttemp = new Class1();
                for (int y = 0; y < student.Count - 1; y++)
                {
                    if (student[y].studentmarks < student[y + 1].studentmarks)
                    {
                        studenttemp = student[y + 1];
                        student[y + 1] = student[y];
                        student[y] = studenttemp;
                    }
                }
            }
            Class1 TeacherTemp = new Class1();
            for (int i = 0; i < Teacher.Count; i++)
            {
                for (int y = 0; y < Teacher.Count - 1; y++)
                {
                    if (Teacher[y].teachersalary < Teacher[y + 1].teachersalary)
                    {
                        TeacherTemp = Teacher[y + 1];
                        Teacher[y + 1] = Teacher[y];
                        Teacher[y] = TeacherTemp;
                    }
                }
            }
            ConsoleColor recentForegroundColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("-------------------------------Student Record-----------------------------------------------");
            Console.WriteLine("                                                                                            ");
            Console.ForegroundColor = recentForegroundColor;
            for (int i = 0; i < student.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine("|Record of {0} Student is  |", i + 1);
                Console.WriteLine("|__________________________|");
                Console.WriteLine("|Name                    | " + student[i].name);
                Console.WriteLine("|Father Name             | " + student[i].fathername);
                Console.WriteLine("|Section                 | " + student[i].studentsection);
                Console.WriteLine("|Student CNIC            | " + student[i].studentcnic);
                Console.WriteLine("|Password                | " + student[i].studentpassword);
                Console.WriteLine("|Bank ID                 | " + student[i].studentbankid);
                Console.WriteLine("|Course                  | " + student[i].studentcourse);
                Console.WriteLine("|Roll NUmber             | " + student[i].studentrollnumber);
                Console.WriteLine("|Marks In Matric         | " + student[i].studentmarks);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("End of Record of Student {0}", i + 1);
                Console.WriteLine("________________________________");
                Console.ForegroundColor = recentForegroundColor;
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("--------------------------------Teacher Record------------------------------------------------");
            Console.WriteLine();
            Console.ForegroundColor = recentForegroundColor;
            for (int i = 0; i < Teacher.Count; i++)
            {
                Console.WriteLine("Record of {0} Teacher is |", i + 1);
                Console.WriteLine("Name                     |" + Teacher[i].teachername);
                Console.WriteLine("Password is              |" + Teacher[i].teacherpassword);
                Console.WriteLine("Phone Number             |" + Teacher[i].teacherphone);
                Console.WriteLine("Post is                  |" + Teacher[i].teacherpost);
                Console.WriteLine("Subject He/She teach     |" + Teacher[i].teachersubject);
                Console.WriteLine("Salary is                |" + Teacher[i].teachersalary);
                Console.WriteLine("CNIC is                  |" + Teacher[i].teachercnic);
                Console.WriteLine("ID is                    |" + Teacher[i].teacherid);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("End of Record of Teacher {0}", i + 1);
                Console.WriteLine("___________________________________");
                Console.ForegroundColor = recentForegroundColor;
            }
        }

        public void removestudent(List<Class1> student)
        {
            string password;
            Console.WriteLine("Enter Roll Number Of student If you Want to Remove");
            password = Console.ReadLine();
            for (int i = 0; i < student.Count; i++)
            {
                if (password == student[i].studentpassword)
                {
                    student.RemoveAt(i);
                    ConsoleColor recentForegroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Student Has Been Removed Successfully");
                    Console.ForegroundColor = recentForegroundColor;
                }
            }
        }
        public void removeteacher(List<Class1> teacher)
        {
            string id;
            Console.WriteLine("Enter ID of Teacher If you Want to Remove");
            id = Console.ReadLine();
            for (int i = 0; i < teacher.Count; i++)
            {
                if (id == teacher[i].teacherid)
                {
                    teacher.RemoveAt(i);
                    ConsoleColor recentForegroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Teacher Has Been Removed Successfully");
                    Console.ForegroundColor = recentForegroundColor;

                }
            }
        }



        public float urdu;
        public float math;
        public float physics;
        public float English;
        public float total;
        public float percentage;

        public Class1 (float English,float Urdu,float Math,float Physics,float Total,float Percentage)
        {
            this.English = English;
            urdu = Urdu;
            math = Math;
            physics = Physics;
            total = Total;
            percentage = Percentage;
        }


    }
}
