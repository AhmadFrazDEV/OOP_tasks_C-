using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using login.Bl;

namespace login
{
    class Program
    {
        static int index=0;
        static char menu()
        {
            Console.WriteLine("1. Add Student ");
            Console.WriteLine("2. View Student ");
            Console.WriteLine("3. Top Student ");
            Console.WriteLine("4. Exit ");
            Console.WriteLine("Your Option ");
            char option = char.Parse(Console.ReadLine());
            return option;
        }
        static void Main(string[] args)
        {
            List<Class1> student = new List<Class1>();
            while(true)
            {
                char option = menu();
                if(option == '1')
                {
                    student.Add(addstudent());
                }
                else if(option == '2')
                {
                    viewstudent(student);
                }
                else if(option == '3')
                {
                    topstudent(student);
                }
                else if (option == '4')
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        static void topstudent(List<Class1> student)
        {
            Class1 st1;
            for(int i=0;i<student.Count;i++)
            {
                for(int y=0;y<student.Count-1;y++)
                {
                    if(student[y].gpa < student[y+1].gpa)
                    {
                        st1 = student[y + 1];
                        student[y + 1] = student[y];
                        student[y] = st1;
                    }
                }
            }
            if (student.Count > 3)
            {
                Console.WriteLine("Top Three Student ");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Name       {0}       GPA     {1}     Department    {2}    ROLL_NUMBER     {3}    Hostelize    {4}  ", student[i].name, student[i].gpa, student[i].department, student[i].Roll_Number, student[i].Hostilze);

                }

            }
            else
            {
                Console.WriteLine("Student are less than 3");
                Console.WriteLine("Top Three Student ");
                for (int i = 0; i < student.Count; i++)
                {
                    Console.WriteLine("Name       {0}       GPA     {1}     Department    {2}    ROLL_NUMBER     {3}    Hostelize    {4}  ", student[i].name, student[i].gpa, student[i].department, student[i].Roll_Number, student[i].Hostilze);

                }
            }
           
        }
        static void viewstudent(List<Class1> Student)
        {
            
            for(int i=0;i<Student.Count; i++)
            {
                Console.WriteLine("Name       {0}       GPA     {1}     Department    {2}    ROLL_NUMBER     {3}    Hostelize    {4}  ", Student[i].name, Student[i].gpa, Student[i].department, Student[i].Roll_Number, Student[i].Hostilze);

            }
        }
        static Class1 addstudent()
        {
            Class1 student = new Class1();
            Console.WriteLine("Enter Name of Student ");
            student.name = Console.ReadLine();
            Console.WriteLine("Enter Department Name ");
            student.department = Console.ReadLine();
            Console.WriteLine("Enter Gpa ");
            student.gpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Student is Hostelize Yes || No");
            student.Hostilze = Console.ReadLine();
            Console.WriteLine("Enter Roll Number Of student");
            student.Roll_Number = int.Parse(Console.ReadLine());
            return student;
        }
    }
}
