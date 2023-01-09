using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Version_3.Classes;

namespace Version_3
{
    class Program
    {
         static char mainmenu()
        {
            Console.WriteLine("1.admin menu");
            Console.WriteLine("2.user");
            Console.WriteLine("3. exit");
            Console.WriteLine("your option");
            char option;
            option = char.Parse(Console.ReadLine());
            return option;
        }
        static char usermenu()
        {
            Console.WriteLine("1.teacher user");
            Console.WriteLine("2. student user");
            Console.WriteLine("3. exit");
            Console.WriteLine("your option");
            char option;
            option = char.Parse(Console.ReadLine());
            return option;

        }
        static void Main(string[] args)
        {
            List<Class1> result = new List<Class1>();
            List<Class1> studentdata = new List<Class1>();
            List<Class1> teacherdata = new List<Class1>();
            load(studentdata, teacherdata, result);
            while(true)
            {
                char option = mainmenu();
                if(option == '1')
                {
                    admin(studentdata,teacherdata);
                }
                else if (option == '2')
                {
                    char ch = usermenu();
                    if (ch == '1')
                    {
                        teachermenu(teacherdata,studentdata,result);
                    }
                    else if (ch == '2')
                    {
                        studentmenu(studentdata,result);
                    }
                    else if (ch == '3')
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (option == '3')
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            store(studentdata, teacherdata, result);
        }
        static void load(List<Class1> student, List<Class1> teacher, List<Class1> result)
        {
            
            string Tpath= "D:\\S_2\\PD\\WEEK_3\\Version_3\\bin\\Debug\\teacher.txt";
            string Spath= "D:\\S_2\\PD\\WEEK_3\\Version_3\\bin\\Debug\\student.txt";
            string Rpath= "D:\\S_2\\PD\\WEEK_3\\Version_3\\bin\\Debug\\result.txt";
            if (File.Exists(Spath))
            {
                StreamReader Sfile = new StreamReader(Spath);
                string record;
                while ((record = Sfile.ReadLine()) != null)
                {
                    Class1 Sdata = new Class1();
                    Sdata.name = parserecord(record, 0);
                    Sdata.fathername = parserecord(record, 1);
                    Sdata.studentrollnumber = parserecord(record, 2);
                    Sdata.studentcnic = parserecord(record, 3);
                    Sdata.studentcourse = parserecord(record, 4);
                    Sdata.studentpassword = parserecord(record, 5);
                    Sdata.studentbankid = parserecord(record, 6);
                    Sdata.studentsection = parserecord(record, 7);
                    Sdata.studentmarks = float.Parse(parserecord(record, 8));
                    student.Add(Sdata);
                }
                Sfile.Close();
            }

            if (File.Exists(Tpath))
            {
                StreamReader Tfile = new StreamReader(Tpath);
                string record;
                while ((record = Tfile.ReadLine()) != null)
                {
                    Class1 Tdata = new Class1();
                    Tdata.teachername = parserecord(record, 0);
                    Tdata.teacherpost = parserecord(record, 1);
                    Tdata.teachersubject = parserecord(record, 2);
                    Tdata.teacherpassword = parserecord(record, 3);
                    Tdata.teachercnic = parserecord(record, 4);
                    Tdata.teacherphone = parserecord(record, 5);
                    Tdata.teacherid = parserecord(record, 6);
                    Tdata.teachersalary = int.Parse(parserecord(record, 7));
                    teacher.Add(Tdata);
                }
                Tfile.Close();
            }

            if (File.Exists(Rpath))
            {

                StreamReader Rfile = new StreamReader(Rpath);
                string record;
                while ((record = Rfile.ReadLine()) != null)
                {
                    Class1 Rdata = new Class1();
                    Rdata.name = parserecord(record, 0);
                    Rdata.urdu = float.Parse(parserecord(record, 1));
                    Rdata.math = float.Parse(parserecord(record, 2));
                    Rdata.physics = float.Parse(parserecord(record, 3));
                    Rdata.English = float.Parse( parserecord(record, 4));
                    Rdata.total = float.Parse(parserecord(record, 5));
                    Rdata.percentage = float.Parse(parserecord(record, 6));
                    result.Add(Rdata);
                }
                Rfile.Close();
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
        static void store(List<Class1> student, List<Class1> Teacher, List<Class1> result)
        {
            string path = "student.txt";
            StreamWriter Filevariable = new StreamWriter(path);
            for (int i = 0; i < student.Count; i++)
            {
                Filevariable.Write(student[i].name);
                Filevariable.Write(",");
                Filevariable.Write(student[i].fathername);
                Filevariable.Write(",");
                Filevariable.Write(student[i].studentrollnumber);
                Filevariable.Write(",");
                Filevariable.Write(student[i].studentcnic);
                Filevariable.Write(",");
                Filevariable.Write(student[i].studentcourse);
                Filevariable.Write(",");
                Filevariable.Write(student[i].studentpassword);
                Filevariable.Write(",");
                Filevariable.Write(student[i].studentbankid);
                Filevariable.Write(",");
                Filevariable.Write(student[i].studentsection);
                Filevariable.Write(",");
                Filevariable.WriteLine(student[i].studentmarks);
            }
            Filevariable.Flush();
            Filevariable.Close();

            string teacherPath = "teacher.txt";
            StreamWriter TeacherFile = new StreamWriter(teacherPath);
            for (int i = 0; i < Teacher.Count; i++)
            {
                TeacherFile.Write(Teacher[i].teachername);
                TeacherFile.Write(",");
                TeacherFile.Write(Teacher[i].teacherpost);
                TeacherFile.Write(",");
                TeacherFile.Write(Teacher[i].teachersubject);
                TeacherFile.Write(",");
                TeacherFile.Write(Teacher[i].teacherpassword);
                TeacherFile.Write(",");
                TeacherFile.Write(Teacher[i].teachercnic);
                TeacherFile.Write(",");
                TeacherFile.Write(Teacher[i].teacherphone);
                TeacherFile.Write(",");
                TeacherFile.Write(Teacher[i].teacherid);
                TeacherFile.Write(",");
                TeacherFile.WriteLine(Teacher[i].teachersalary);
            }
            TeacherFile.Flush();
            TeacherFile.Close();

            string resultpath = "result.txt";
            StreamWriter ResultFile = new StreamWriter(resultpath);
            for (int i = 0; i < result.Count; i++)
            {
                ResultFile.Write(result[i].name);
                ResultFile.Write(",");
                ResultFile.Write(result[i].urdu);
                ResultFile.Write(",");
                ResultFile.Write(result[i].math);
                ResultFile.Write(",");
                ResultFile.Write(result[i].physics);
                ResultFile.Write(",");
                ResultFile.Write(result[i].English);
                ResultFile.Write(",");
                ResultFile.Write(result[i].total);
                ResultFile.Write(",");
                ResultFile.WriteLine(result[i].percentage);
            }
            ResultFile.Flush();
            ResultFile.Close();
        }
        static void studentmenu(List<Class1> student,List<Class1> result)
        {
            Class1 StudentData = new Class1();
            string password;
            string loginname;
            Console.WriteLine("Enter Login Name");
            loginname = Console.ReadLine();
            Console.WriteLine("Enter Login Password");
            password = Console.ReadLine();
            for(int i=0;i<student.Count;i++)
            {
                if(loginname == student[i].name && password == student[i].studentpassword)
                {
                    ConsoleColor recentForegroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your login Welcome ");
                    Console.ForegroundColor = recentForegroundColor;
                    while(true)
                    {
                        char option = studentfeature();
                        if(option == '1')
                        {
                            checkResult(result,i);
                        }
                        else if(option == '2')
                        {
                            PersonalInformation(student, i);
                        }
                        else if(option == '3')
                        {
                            StudentData.changepassword(student, i);
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
            }
        }
        
        static void PersonalInformation(List<Class1> student,int i)
        {
            Console.WriteLine("Name         "+ student[i].name);
            Console.WriteLine("Father Name  " + student[i].fathername);
            Console.WriteLine("Section      " + student[i].studentsection);
            Console.WriteLine("Student CNIC " + student[i].studentcnic);
            Console.WriteLine("Password     " + student[i].studentpassword);
            Console.WriteLine("Bank ID      " + student[i].studentbankid);
            Console.WriteLine("Course       " + student[i].studentcourse);
            Console.WriteLine("Roll NUmber  " + student[i].studentrollnumber);
            Console.WriteLine("Marks In Matric " + student[i].studentmarks);

        }
        static void checkResult(List<Class1> result,int i)
        {
            Console.WriteLine("Name                  Urdu                   MAth                   Physics                English                 Total                 Percentage");
            Console.WriteLine(result[i].name + "                   " + result[i].urdu + "                     " + result[i].math + "                     " + result[i].physics +"                      "+result[i].English + "                     "+result[i].total + "                    "+result[i].percentage);
        }
        static char studentfeature()
        {
            Console.WriteLine("1.check result");
            Console.WriteLine("2.personal information");
            Console.WriteLine("3.change password");
            Console.WriteLine("4.exit");
            Console.WriteLine("your option");
            char option;
            option = char.Parse(Console.ReadLine());
            return option;
        }
        static void teachermenu( List<Class1> Teacher,List<Class1> student, List<Class1> result)
        {
            string name;
            Console.WriteLine("Enter Login Name");
            name = Console.ReadLine();
            string id;
            Console.WriteLine("Enter Login Password");
            id = Console.ReadLine();
            for (int i=0;i<Teacher.Count;i++)
            {
                Console.WriteLine("id is " + Teacher[i].teacherid);
                if (name == Teacher[i].teachername && id== Teacher[i].teacherid)
                {
                    ConsoleColor recentForegroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your login Welcome ");
                    Console.ForegroundColor = recentForegroundColor;
                    while(true)
                    {
                        char option = teacherfeature();
                        if(option == '1')
                        {
                            if (student.Count > result.Count)
                            {
                                float English, Urdu, Math, Physics;
                                float Total, Percentage;
                                Console.WriteLine("Enter English Marks of student 1 to 100");
                                English = float.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Urdu Marks of student 1 to 100");
                                Urdu = float.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Math Marks of student 1 to 100");
                                Math = float.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Physics Marks of student 1 to 100");
                                Physics = float.Parse(Console.ReadLine());
                                Total = Urdu + Physics + Math + English;
                                Percentage = Total * 100 / 400;
                                Class1 Result = new Class1(English, Urdu, Math, Physics, Total, Percentage);
                                result.Add(Result);
                            }
                            else
                            {
                                Console.WriteLine("You can not add result bescause number of student are less");
                            }
                        }
                        else if(option == '2')
                        {
                            
                                viewresult(result,student);
                            
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

                }
            }
        }

        static void viewresult(List<Class1> result,List<Class1> student)
        {
            Class1 temp = new Class1();
            for (int i = 0; i < result.Count; i++)
            {
                for (int x = 0; x < result.Count - 1; x++)
                {
                    if (result[x].percentage < result[x + 1].percentage)
                    {
                        temp = result[x + 1];
                        result[x + 1] = result[x];
                        result[x] = temp;
                    }
                }
            }
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine("Record of {0} Student is ", i + 1);
                Console.WriteLine("Name      " + student[i].name);
                Console.WriteLine("Urdu      " + result[i].urdu);
                Console.WriteLine("Math      " + result[i].math);
                Console.WriteLine("Physics   " + result[i].physics);
                Console.WriteLine("English   " + result[i].English);
                Console.WriteLine("Total     " + result[i].total);
                Console.WriteLine("Percenatge " + result[i].percentage);
                ConsoleColor recentForegroundColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("______________________________________________ ");
                Console.ForegroundColor = recentForegroundColor;
                Console.WriteLine();
            }
        }
        static char teacherfeature()
        {
            Console.WriteLine("1.add result");
            Console.WriteLine("2.view  result");
            Console.WriteLine("3.exit");
            Console.WriteLine("your option");
            char option;
            option = char.Parse(Console.ReadLine());
            return option;
        }
        static char adminmenu()
        {
            Console.WriteLine("1.add student");
            Console.WriteLine("2.add teacher");
            Console.WriteLine("3.display data");
            Console.WriteLine("4.remove student");
            Console.WriteLine("5.remove teacher");
            Console.WriteLine("6.exit");
            Console.WriteLine("your option");
            char option;
            option = char.Parse(Console.ReadLine());
            return option;
        }
        static void admin(List<Class1> studentType,List<Class1> TeacherType)
        {
            Class1 Data = new Class1();
            string name;
            string password;
            Console.WriteLine("Enter login name ");
            name = Console.ReadLine();
            Console.WriteLine("Enter login Password ");
            password = Console.ReadLine();
            if(name == "admin"  && password == "123@")
            {
                ConsoleColor recentForegroundColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Welcome your login : ");
                Console.ForegroundColor = recentForegroundColor;
                Console.WriteLine();
                while(true)
                {
                    char option = adminmenu();
                    if(option == '1')
                    {
                        string Sname, fathername, studentrollnumber, studentcnic, studentcourse, studentpassword,studentsection, studentbankid;
                        float studentmarks;
                        Console.WriteLine("Enter name of student ");
                        Sname = Console.ReadLine();
                        Console.WriteLine("Enter father name ");
                        fathername = Console.ReadLine();
                        Console.WriteLine("Enter Student Roll_Number");
                        studentrollnumber = Console.ReadLine();
                        Console.WriteLine("Enter Student CNIC ");
                        studentcnic = Console.ReadLine();
                        Console.WriteLine("Enter Student Course ");
                        studentcourse = Console.ReadLine();
                        Console.WriteLine("Enter Student Password ");
                        studentpassword = Console.ReadLine();
                        Console.WriteLine("Enter Student Bankid ");
                        studentbankid = Console.ReadLine();
                        Console.WriteLine("Enter Student Section ");
                        studentsection = Console.ReadLine();
                        Console.WriteLine("Enter Student Marks ");
                        studentmarks = float.Parse(Console.ReadLine());
                        Class1 Studentdata = new Class1(Sname, fathername, studentrollnumber, studentcnic, studentcourse, studentpassword, studentsection, studentbankid, studentmarks);
                        studentType.Add(Studentdata);
                    }
                    else if(option == '2')
                    {
                        string teachername, teacherpost, teachercnic,teacherid,teacherpassword,teachersubject,teacherphone;
                        int teachersalary;
                        Console.WriteLine("Enter Teacher name");
                        teachername = Console.ReadLine();
                        Console.WriteLine("Enter Teacher Post");
                        teacherpost = Console.ReadLine();
                        Console.WriteLine("Enter Teacher CNIC");
                        teachercnic = Console.ReadLine();
                        Console.WriteLine("Enter Teacher ID");
                        teacherid = Console.ReadLine();
                        Console.WriteLine("Enter Teacher PassWord ");
                        teacherpassword = Console.ReadLine();
                        Console.WriteLine("Enter Teacher Subject HE/SHE Teach ");
                        teachersubject = Console.ReadLine();
                        Console.WriteLine("Enter Teacher Phone_Number ");
                        teacherphone = Console.ReadLine();
                        Console.WriteLine("Enter Teacher Salary ");
                        teachersalary = int.Parse(Console.ReadLine());

                        Class1 TeacherData = new Class1(teachername, teacherpost, teachercnic, teacherid, teacherpassword, teachersubject, teacherphone, teachersalary);

                        TeacherType.Add(TeacherData);
                    }
                    else if(option == '3')
                    {
                        Data.displayRecord(studentType,TeacherType);
                    }
                    else if(option == '4')
                    {
                        Data.removestudent(studentType);
                    }
                    else if(option == '5')
                    {
                        Data.removeteacher(TeacherType);
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
}
