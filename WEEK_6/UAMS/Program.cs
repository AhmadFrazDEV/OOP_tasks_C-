using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using UAMS.DL;
using UAMS.UI;

namespace UAMS
{
    class Program
    {
        static void Main(string[] args)
        {
            string SubjectPath = "Subject.txt";
            string DegreePath = "Degree.txt";
            string StudentPath = "Student.txt";
            if (DEGREEPROGRAMDL.readData(DegreePath))
            {
                Console.WriteLine("Subject Data Loaded Successfully");
            }
            if (STUDENTDL.readFromFile(StudentPath))
            {
                Console.WriteLine("Subject Data Loaded Successfully");
            }
            if (SUBJECTDL.readFromFile(SubjectPath))
            {
                Console.WriteLine("Subject Data Loaded Successfully");
            }
            while (true)
            {
                char option = MENUUI.menu();
                MENUUI.clearScreen();
                if(option == '1')
                {
                    if(DEGREEPROGRAMDL.ProgramList.Count>0)
                    {
                        STUDENTBL Student = STUDENTUI.takeInputForStudent();
                        STUDENTDL.addIntoList(Student);
                        STUDENTDL.Store(StudentPath, Student);
                    }
                }
                else if(option == '2')
                {
                    DEGREEPROGRAMBL Degree = DEGREEUI.addDegree();
                    DEGREEPROGRAMDL.addIntoList(Degree);
                    DEGREEPROGRAMDL.storeIntoFile(DegreePath, Degree);
                }
                else if(option == '3')
                {
                    List<STUDENTBL> SortList = new List<STUDENTBL>();
                    SortList = STUDENTDL.sortStudents();
                    STUDENTDL.giveAdmission(SortList);
                    STUDENTUI.printStudent();
                }
                else if(option == '4')
                {
                    STUDENTUI.viewRegisterStudent();
                }
                else if(option == '5')
                {
                    string Degree;
                    Console.WriteLine("Enter Degree Name: ");
                    Degree = Console.ReadLine();
                    STUDENTUI.viewStudentDegree(Degree);
                }
                else if(option == '6')
                {
                    string Name;
                    Console.WriteLine("Enter Student Name: ");
                    Name = Console.ReadLine();
                    STUDENTBL Student = STUDENTDL.StudentPresent(Name);
                    if(Student != null)
                    {
                        STUDENTUI.viewSubject(Student);
                        STUDENTUI.viewRegisterStudent();
                    }
                }
                else if(option == '7')
                {
                    STUDENTUI.Calculatefeeforall();
                }
                else if(option == '8')
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
