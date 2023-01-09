using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    class SUBJECTSBL
    {
        private string SubjectCode;
        private string SubjectType;
        private int CreditHour;
        private int SubjectFee;
        public SUBJECTSBL(string SubjectCode,string SubjectType,int CreditHour,int SubjectFee)
        {
            this.SubjectCode = SubjectCode;
            this.SubjectFee = SubjectFee;
            this.SubjectType = SubjectType;
            this.CreditHour = CreditHour;
        }
        public string getSubjectCode()
        {
            return SubjectCode;
        }
        public string getSubjectType()
        {
            return SubjectType;
        }
        public int getCH()
        {
            return CreditHour;
        }
        public int getFee()
        {
            return SubjectFee;
        }

    }
}
