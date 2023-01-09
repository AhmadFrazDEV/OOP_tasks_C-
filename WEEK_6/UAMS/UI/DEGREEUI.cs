using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using UAMS.UI;
using UAMS.DL;

namespace UAMS.UI
{
    class DEGREEUI
    {
        public static DEGREEPROGRAMBL addDegree()
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

            DEGREEPROGRAMBL Deg = new DEGREEPROGRAMBL(Degname, duration, seat);
            Console.WriteLine("How many Subject to Enter");
            int count = int.Parse(Console.ReadLine());
            for (int x = 0; x < count; x++)
            {
                SUBJECTSBL Subject =SUBJECTUI.takeInput();
                if(Deg.addSubject(Subject))
                {
                    if(!(SUBJECTDL.SubjectList.Contains(Subject)))
                    {
                        SUBJECTDL.addSubjects(Subject);
                        SUBJECTDL.StoreSubject("Subject.txt", Subject);
                    }
                Console.WriteLine("Subject Added Succesfully");
                }
                else
                {
                    Console.WriteLine("Subject Not Added Because Credit Hour is Grater Than 20");
                    x--;
                }
            }
            return Deg;
        }
        public static void viewAllProgram()
        {
            foreach(DEGREEPROGRAMBL deg in DEGREEPROGRAMDL.ProgramList)
            {
                Console.WriteLine(deg.getDName());
            }
        }
    }
}
