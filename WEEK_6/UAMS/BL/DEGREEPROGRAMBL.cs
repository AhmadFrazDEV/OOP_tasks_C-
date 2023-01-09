using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    class DEGREEPROGRAMBL
    {
        private string DegreeName;
        private float Duration;
        public List<SUBJECTSBL> Subjects;
        private int Seats;
        public DEGREEPROGRAMBL(string DegreeName,float Duration,int Seats)
        {
            this.DegreeName = DegreeName;
            this.Duration = Duration;
            this.Seats = Seats;
            Subjects = new List<SUBJECTSBL>();
        }
        public string getDName()
        {
            return DegreeName;
        }
        public float getDuration()
        {
            return Duration;
        }
        public int getSeats()
        {
            return Seats;
        }
        public void setSeats(int X)
        {
            this.Seats = X;
        }
        public bool isSubjectExists(SUBJECTSBL Subject)
        {
            foreach(SUBJECTSBL Sub in Subjects)
            {
                if(Sub.getSubjectCode() == Subject.getSubjectCode())
                {
                    return true;
                }
            }
            return false;
        }
        public bool addSubject(SUBJECTSBL Sub)
        {
            int CH = calculateCreditHour();
            if(CH + Sub.getCH() <= 20)
            {
                Subjects.Add(Sub);
                return true;
            }
            return false;

        }
        public int calculateCreditHour()
        {
            int Count = 0;
            for(int i=0;i<Subjects.Count;i++)
            {
                Count = Count + Subjects[i].getCH();
            }
            return Count;
        }
    }
}
