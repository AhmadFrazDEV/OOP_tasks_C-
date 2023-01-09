using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;

namespace UAMS.DL
{
    class DEGREEPROGRAMDL
    {
        public static List<DEGREEPROGRAMBL> ProgramList = new List<DEGREEPROGRAMBL>();
        public static void addIntoList(DEGREEPROGRAMBL Degree)
        {
            ProgramList.Add(Degree);
        }
        public static DEGREEPROGRAMBL isDegreeExists(string Name)
        {
            foreach(DEGREEPROGRAMBL Degree in ProgramList)
            {
                if(Degree.getDName() == Name)
                {
                    return Degree;
                }
            }
            return null;
        }
        public static void storeIntoFile(string Path,DEGREEPROGRAMBL Degree)
        {
            StreamWriter DFile = new StreamWriter(Path,true);
            string SubjectName = "";
            for(int i=0;i<Degree.Subjects.Count-1;i++)
            {
                SubjectName = SubjectName + Degree.Subjects[i].getSubjectType() + ";";
            }
            SubjectName = SubjectName + Degree.Subjects[Degree.Subjects.Count - 1].getSubjectType();
            DFile.WriteLine(Degree.getDName() + "," + Degree.getDuration() + "," + Degree.getSeats() + "," + SubjectName);
            DFile.Flush();
            DFile.Close();
        }
        public static bool readData(string Path)
        {
            StreamReader DFile = new StreamReader(Path);
            string Record;
            if(File.Exists(Path))
            {
                while((Record = DFile.ReadLine()) != null)
                {
                    string[] SplitRecord = Record.Split(',');
                    string DegreeName = SplitRecord[0];
                    float Duration = float.Parse(SplitRecord[1]);
                    int Seats = int.Parse(SplitRecord[2]);
                    string[] SplitForSubject = SplitRecord[3].Split(';');
                    DEGREEPROGRAMBL Degree = new DEGREEPROGRAMBL(DegreeName, Duration, Seats);
                    for(int i=0;i<SplitForSubject.Length;i++)
                    {
                        SUBJECTSBL Subject = SUBJECTDL.isSubjectExists(SplitForSubject[i]);
                        if(Subject != null)
                        {
                            Degree.addSubject(Subject);
                        }
                    }
                    addIntoList(Degree);
                }
                DFile.Close();
                return true;
            }
            return false;            
        }

    }
}
