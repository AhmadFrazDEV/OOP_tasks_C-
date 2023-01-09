using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS_V1.BL
{
    class Subject
    {
        public string code;
        public int Ch;
        public string SubjectType;
        public int SubjectFee;

        public Subject(string code,string type,int Ch,int SubjectFee)
        {
            this.code = code;
            SubjectType = type;
            this.Ch = Ch;
            this.SubjectFee = SubjectFee;
        }
    }
}
