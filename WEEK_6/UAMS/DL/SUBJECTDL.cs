using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;

namespace UAMS.DL
{
    class SUBJECTDL
    {
        public static List<SUBJECTSBL> SubjectList = new List<SUBJECTSBL>();
        public static void addSubjects(SUBJECTSBL Subject)
        {
            SubjectList.Add(Subject);
        }
        public static bool readFromFile(string Path)
        {
            StreamReader subject = new StreamReader(Path);
            string Record;
            if(File.Exists(Path))
            {
                while((Record = subject.ReadLine()) != null)
                {
                    string[] SplitRecord = Record.Split(',');
                    string Code = SplitRecord[0];
                    string Type = SplitRecord[1];
                    int CreditHour = int.Parse(SplitRecord[2]);
                    int SubjectFee = int.Parse(SplitRecord[3]);
                    SUBJECTSBL Sub = new SUBJECTSBL(Code, Type, CreditHour, SubjectFee);
                    addSubjects(Sub);
                }
                subject.Close();
                return true;
            }
            else
            return false;
        }
        public static void StoreSubject(string Path,SUBJECTSBL Subject)
        {
            StreamWriter SFile = new StreamWriter(Path,true);
            SFile.WriteLine(Subject.getSubjectCode() + "," + Subject.getSubjectType() + "," + Subject.getCH() + "," + Subject.getFee());
            SFile.Flush();
            SFile.Close();
        }
        public static SUBJECTSBL isSubjectExists(string Type)
        {
            foreach(SUBJECTSBL Sub in SubjectList)
            {
                if(Sub.getSubjectType() == Type)
                {
                    return Sub;
                }
            }
            return null;
        }
    }
}
