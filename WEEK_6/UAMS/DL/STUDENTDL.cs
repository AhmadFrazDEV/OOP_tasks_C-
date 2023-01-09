using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;

namespace UAMS.DL
{
    class STUDENTDL
    {
        public static List<STUDENTBL> StudentList = new List<STUDENTBL>();
        public static void addIntoList(STUDENTBL Subject)
        {
            StudentList.Add(Subject);
        }
        public static STUDENTBL StudentPresent(string Name)
        {
            foreach(STUDENTBL S in StudentList)
            {
                if(Name == S.getName() && S.RegisterDegree != null)
                {
                    return S;
                }
            }
            return null;
        }
        public static List<STUDENTBL> sortStudents()
        {
            List<STUDENTBL> SortedStudent = new List<STUDENTBL>();
            foreach(STUDENTBL Student in StudentList)
            {
                Student.calculateMerit();
            }
            SortedStudent = StudentList.OrderByDescending(Student => Student.getMerit()).ToList();
            return SortedStudent;
        }
        public static void giveAdmission(List<STUDENTBL> SortList)
        {
            foreach(STUDENTBL Student in SortList)
            {
                foreach(DEGREEPROGRAMBL deg in Student.Prferance)
                {
                    if(deg.getSeats() > 0 && Student.RegisterDegree == null)
                    {
                        Student.RegisterDegree = deg;
                        int X = deg.getSeats();
                        X = X - 1;
                        deg.setSeats(X);
                        break;
                    }
                }
            }
        }
        public static void Store(string Path,STUDENTBL Student)
        {
            StreamWriter SFile = new StreamWriter(Path,true);
            string DegreeName = "";
            for(int i=0;i<Student.Prferance.Count-1;i++)
            {
                DegreeName = DegreeName + Student.Prferance[i].getDName() + ";";
            }
            DegreeName = DegreeName + Student.Prferance[Student.Prferance.Count - 1].getDName();
            SFile.WriteLine(Student.getName() + "," + Student.getAge() + "," + Student.getFsc() + "," + Student.getEcat() + "," + DegreeName);
            SFile.Flush();
            SFile.Close();
        }
        public static bool readFromFile(string Path)
        {
            StreamReader SFile = new StreamReader(Path);
            string Record;
            if(File.Exists(Path))
            {
                while((Record = SFile.ReadLine()) != null)
                {
                    string[] SplitReccord = Record.Split(',');
                    string Name = SplitReccord[0];
                    int Age = int.Parse(SplitReccord[1]);
                    float Fsc = float.Parse(SplitReccord[2]);
                    float Ecat = float.Parse(SplitReccord[3]);
                    string[] SplitForPreferance = SplitReccord[4].Split(';');
                    List<DEGREEPROGRAMBL> Preferance = new List<DEGREEPROGRAMBL>();
                    for(int i=0;i<SplitForPreferance.Length;i++)
                    {
                        DEGREEPROGRAMBL D = DEGREEPROGRAMDL.isDegreeExists(SplitForPreferance[i]);
                        if(D!=null)
                        {
                            if(!(Preferance.Contains(D)))
                            {
                                Preferance.Add(D);
                            }
                        }
                    }
                    STUDENTBL Student = new STUDENTBL(Name, Age, Fsc, Ecat, Preferance);
                    StudentList.Add(Student);
                }
                SFile.Close();
                return true;
            }
            return false;
        }
    }
}
