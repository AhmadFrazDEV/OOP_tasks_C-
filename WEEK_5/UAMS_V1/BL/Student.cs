using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS_V1.BL
{
    class Student
    {
        public string Name;
        public int Age;
        public float Fsc;
        public float Ecat;
        public float Merit;
        public List<DegreeProgram> preference;
        public List<Subject> Regsubjects;
        public DegreeProgram regDegree;


        public Student(string Name,int Age,float Fsc,float Ecat,List<DegreeProgram> preference)
        {
            this.Name = Name;
            this.Age = Age;
            this.Fsc = Fsc; ;
            this.Ecat = Ecat;
            this.preference = preference;
            Regsubjects = new List<Subject>();
        }

        public void calculateMerit()
        {
            this.Merit = (((Fsc / 1100) * 0.45F) + ((Ecat / 400) * 0.55F)) * 100;
        }

        public int getCh()
        {
            int count = 0;
            foreach(Subject sub in Regsubjects)
            {
                count = count + sub.Ch;
            }
            return count;
        }

        public float calculatefee()
        {
            float fee = 0;
            if(regDegree != null)
            {
                foreach(Subject sub in Regsubjects)
                {
                    fee = fee + sub.SubjectFee;
                }
            }
            return fee;
        }
        public bool registerStudentSubject(Subject s)
        {
            int stCh = getCh();
            if(regDegree != null && regDegree.isSubjectExits(s) && stCh + s.Ch <= 9 )
            {
                Regsubjects.Add(s);
                return true;
            }
            return false;
        }


    }
}
