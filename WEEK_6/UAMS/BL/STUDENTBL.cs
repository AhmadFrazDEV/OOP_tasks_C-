using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.DL;
using UAMS.UI;

namespace UAMS.BL
{
    class STUDENTBL
    {
        private string Name;
        private int Age;
        private float Fsc;
        private float Ecat;
        private float Merit;
        public List<DEGREEPROGRAMBL> Prferance;
        public List<SUBJECTSBL> EnrollSubjects;
        public DEGREEPROGRAMBL RegisterDegree;
        public STUDENTBL(string Name,int Age,float Fsc,float Ecat,List<DEGREEPROGRAMBL> Preferance)
        {
            this.Name = Name;
            this.Age = Age;
            this.Fsc = Fsc;
            this.Ecat = Ecat;
            this.Prferance = Preferance;
            this.EnrollSubjects = new List<SUBJECTSBL>();
        }
        public float getMerit()
        {
            return Merit;
        }
        public string getName()
        {
            return Name;
        }
        public int getAge()
        {
            return Age;
        }
        public float getFsc()
        {
            return Fsc;
        }
        public float getEcat()
        {
            return Ecat;
        }
        public void calculateMerit()
        {
            this.Merit=(((this.Fsc/1100)*0.45F) + ((this.Ecat/400)*0.55F)*100);
        }
        public bool registerSubjects(SUBJECTSBL Sub)
        {
            int CH = getCreditHour();
            if(RegisterDegree != null && RegisterDegree.isSubjectExists(Sub) && CH+Sub.getCH() <= 20)
            {
                EnrollSubjects.Add(Sub);
                return true;
            }
            return false;
        }
        public int getCreditHour()
        {
            int Hour = 0;
            foreach(SUBJECTSBL Sub in EnrollSubjects)
            {
                Hour = Hour + Sub.getCH();
            }
            return Hour;
        }
        public float calculateSubjectFee()
        {
            float Fee = 0F;
            if(RegisterDegree != null)
            {
                foreach (SUBJECTSBL sub in EnrollSubjects)
                {
                    Fee = Fee + sub.getFee();
                }
            }
            return Fee;
        }
    }
}
