using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS_V1.BL
{
    class DegreeProgram
    {
        public string Title;
        public float Duration;
        public List<Subject> subjects;
        public int seat;

        public DegreeProgram(string Title,float Duration,int seat)
        {
            this.Title = Title;
            this.Duration = Duration;
            this.seat = seat;
            subjects = new List<Subject>();
        }

        public int CalculateCH()
        {
            int count = 0;
            for(int x=0;x<subjects.Count;x++)
            {
                count = count + subjects[x].Ch;
            }
            return count;
        }

        public bool Addsubject(Subject S)
        {
            int CH = CalculateCH();
            if(CH+S.Ch<=20)
            {
                subjects.Add(S);
                return true;
            }
            return false;
        }
        public bool isSubjectExits(Subject sub)
        {
            foreach(Subject s in subjects)
            {
                if(s.code==sub.code)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
