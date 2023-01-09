using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Version2.BL;

namespace Version2
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
            List<Class3> result = new List<Class3>();
            List<Class1> studentdata = new List<Class1>();
            List<Class2> teacherdata = new List<Class2>();
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
        static void load(List<Class1> student, List<Class2> teacher, List<Class3> result)
        {
            Class1 Sdata = new Class1();
            Class2 Tdata = new Class2();
            Class3 Rdata = new Class3();
            string Tpath= "D:\\S_2\\PD\\WEEK_2\\Version2\\bin\\Debug\\teacher.txt";
            string Spath= "D:\\S_2\\PD\\WEEK_2\\Version2\\bin\\Debug\\student.txt";
            string Rpath= "D:\\S_2\\PD\\WEEK_2\\Version2\\bin\\Debug\\result.txt";
            if (File.Exists(Spath))
            {
                StreamReader Sfile = new StreamReader(Spath);
                string record;
                while ((record = Sfile.ReadLine()) != null)
                {
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
        static void store(List<Class1> student, List<Class2> teacher,List<Class3> result)
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
            for (int i = 0; i < teacher.Count; i++)
            {
                TeacherFile.Write(teacher[i].teachername);
                TeacherFile.Write(",");
                TeacherFile.Write(teacher[i].teacherpost);
                TeacherFile.Write(",");
                TeacherFile.Write(teacher[i].teachersubject);
                TeacherFile.Write(",");
                TeacherFile.Write(teacher[i].teacherpassword);
                TeacherFile.Write(",");
                TeacherFile.Write(teacher[i].teachercnic);
                TeacherFile.Write(",");
                TeacherFile.Write(teacher[i].teacherphone);
                TeacherFile.Write(",");
                TeacherFile.Write(teacher[i].teacherid);
                TeacherFile.Write(",");
                TeacherFile.WriteLine(teacher[i].teachersalary);
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
        static void studentmenu(List<Class1> student,List<Class3> result)
        {
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
                            changepassword(student, i);
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
        static void changepassword(List<Class1> student,int i)
        {
            string changer;
            Console.WriteLine("Enter forget || change for changing the password ");
            changer = Console.ReadLine();
            if(changer== "forget" || changer == "change")
            {
                Console.WriteLine("Enter CNIC number and name ");
                string name, phone;
                name = Console.ReadLine();
                phone = Console.ReadLine();
                if(name == student[i].name && phone == student[i].studentcnic)
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
        static void PersonalInformation(List<Class1> student,int i)
        {
            Console.WriteLine("Name "+ student[i].name);
            Console.WriteLine("Father Name " + student[i].fathername);
            Console.WriteLine("Section " + student[i].studentsection);
            Console.WriteLine("Student CNIC " + student[i].studentcnic);
            Console.WriteLine("Password " + student[i].studentpassword);
            Console.WriteLine("Bank ID " + student[i].studentbankid);
            Console.WriteLine("Course " + student[i].studentcourse);
            Console.WriteLine("Roll NUmber " + student[i].studentrollnumber);
            Console.WriteLine("Marks In Matric " + student[i].studentmarks);

        }
        static void checkResult(List<Class3> result,int i)
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
        static void teachermenu(List<Class2> teacher, List<Class1> student, List<Class3> result)
        {
            
            string name;
            Console.WriteLine("Enter Login Name");
            name = Console.ReadLine();
            string id;
            Console.WriteLine("Enter Login Password");
            id = Console.ReadLine();
            for (int i=0;i<teacher.Count;i++)
            {
                if (name == teacher[i].teachername && id==teacher[i].teacherid)
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
                            result.Add(addresult());
                        }
                        else if(option == '2')
                        {
                            viewresult(result, student);
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
        static void viewresult(List<Class3> result,List<Class1> student)
        {
            Class3 temp = new Class3();
            for(int i=0;i<student.Count;i++)
            {
                result[i].name = student[i].name;
            }
            for(int i=0;i<result.Count;i++)
            {
                for(int x=0;x<result.Count-1;x++)
                {
                    if(result[x].percentage < result[x+1].percentage)
                    {
                        temp = result[x + 1];
                        result[x + 1] = result[x];
                        result[x] = temp;
                    }
                }
            }
            for(int i=0;i<result.Count;i++)
            {
                Console.WriteLine("Record of {0} Student is ", i + 1);
                Console.WriteLine("Name   "+ result[i].name);
                Console.WriteLine("Urdu " + result[i].urdu);
                Console.WriteLine("Math  " + result[i].math);
                Console.WriteLine("Physics " + result[i].physics);
                Console.WriteLine("English  " + result[i].English);
                Console.WriteLine("Total   " + result[i].total);
                Console.WriteLine("Percenatge    " + result[i].percentage);
                ConsoleColor recentForegroundColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("______________________________________________ ");
                Console.ForegroundColor = recentForegroundColor;
                Console.WriteLine();
            }
        }
        static Class3 addresult()
        {
            Class3 data = new Class3();
            Console.WriteLine("Enter English Marks of student 1 to 100");
            data.English = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Urdu Marks of student 1 to 100");
            data.urdu = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Math Marks of student 1 to 100");
            data.math = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Physics Marks of student 1 to 100");
            data.physics = float.Parse(Console.ReadLine());
            data.total = data.urdu + data.physics + data.math + data.English;
            data.percentage = data.total * 100 / 400;
            return data;
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
        static void admin(List<Class1> studentType,List<Class2> teachertype)
        {
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
                        studentType.Add(addstudent());
                    }
                    else if(option == '2')
                    {
                        teachertype.Add(addteacher());
                    }
                    else if(option == '3')
                    {
                        displayRecord(studentType, teachertype);
                    }
                    else if(option == '4')
                    {
                        removestudent(studentType);
                    }
                    else if(option == '5')
                    {
                        removeteacher(teachertype);
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
        static void removestudent(List<Class1> student)
        {
            string password;
            Console.WriteLine("Enter Roll Number Of student If you Want to Remove");
            password = Console.ReadLine();
            for(int i=0;i<student.Count;i++)
            {
                if(password == student[i].studentpassword)
                {
                    student.RemoveAt(i);
                    ConsoleColor recentForegroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Student Has Been Removed Successfully");
                    Console.ForegroundColor = recentForegroundColor;
                }
            }
        }
        static void removeteacher(List<Class2> teacher)
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
        static void displayRecord(List<Class1> student, List<Class2> teacher)
        {
            Class1 studenttemp = new Class1();
            Class2 teachertemp = new Class2();
            for (int i = 0; i < student.Count; i++)
            {
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
            for (int i = 0; i < teacher.Count; i++)
            {
                for (int y = 0; y < teacher.Count - 1; y++)
                {
                    if (teacher[y].teachersalary < teacher[y + 1].teachersalary)
                    {
                        teachertemp = teacher[y + 1];
                        teacher[y + 1] = teacher[y];
                        teacher[y] = teachertemp;
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
                Console.WriteLine("End of Record of Student {0}",i+1);
                Console.WriteLine("________________________________");
                Console.ForegroundColor = recentForegroundColor;
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("--------------------------------Teacher Record------------------------------------------------");
            Console.WriteLine();
            Console.ForegroundColor = recentForegroundColor;
            for(int i=0;i<teacher.Count;i++)
            {
                Console.WriteLine("Record of {0} Teacher is |", i + 1);
                Console.WriteLine("Name                     |"+teacher[i].teachername);
                Console.WriteLine("Password is              |" + teacher[i].teacherpassword);
                Console.WriteLine("Phone Number             |" + teacher[i].teacherphone);
                Console.WriteLine("Post is                  |" + teacher[i].teacherpost);
                Console.WriteLine("Subject He/She teach     |" + teacher[i].teachersubject);
                Console.WriteLine("Salary is                |" + teacher[i].teachersalary);
                Console.WriteLine("CNIC is                  |" + teacher[i].teachercnic);
                Console.WriteLine("ID is                    |" + teacher[i].teacherid);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("End of Record of Teacher {0}", i + 1);
                Console.WriteLine("___________________________________");
                Console.ForegroundColor = recentForegroundColor;
            }
        }
        static Class2 addteacher()
        {
            Class2 teacher = new Class2();
            Console.WriteLine("Enter Teacher name");
            teacher.teachername = Console.ReadLine();
            Console.WriteLine("Enter Teacher Post");
            teacher.teacherpost = Console.ReadLine();
            Console.WriteLine("Enter Teacher CNIC");
            teacher.teachercnic = Console.ReadLine();
            Console.WriteLine("Enter Teacher ID");
            teacher.teacherid = Console.ReadLine();
            Console.WriteLine("Enter Teacher PassWord ");
            teacher.teacherpassword = Console.ReadLine();
            Console.WriteLine("Enter Teacher Subject HE/SHE Teach ");
            teacher.teachersubject = Console.ReadLine();
            Console.WriteLine("Enter Teacher Phone_Number ");
            teacher.teacherphone = Console.ReadLine();
            Console.WriteLine("Enter Teacher Salary ");
            teacher.teachersalary = int.Parse(Console.ReadLine());
            return teacher;
        }
        static Class1 addstudent()
        {
            Class1 student = new Class1();
            Console.WriteLine("Enter name of student ");
            student.name = Console.ReadLine();
            Console.WriteLine("Enter father name ");
            student.fathername = Console.ReadLine();
            Console.WriteLine("Enter Student Roll_Number");
            student.studentrollnumber = Console.ReadLine();
            Console.WriteLine("Enter Student CNIC ");
            student.studentcnic = Console.ReadLine();
            Console.WriteLine("Enter Student Course ");
            student.studentcourse = Console.ReadLine();
            Console.WriteLine("Enter Student Password ");
            student.studentpassword = Console.ReadLine();
            Console.WriteLine("Enter Student Bankid ");
            student.studentbankid = Console.ReadLine();
            Console.WriteLine("Enter Student Section ");
            student.studentsection = Console.ReadLine();
            Console.WriteLine("Enter Student Marks ");
            student.studentmarks = float.Parse(Console.ReadLine());
            return student;
        }
    }
}
