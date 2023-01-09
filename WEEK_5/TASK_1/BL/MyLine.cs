using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1.BL
{
    class MyLine
    {
        mypoint Begin;
        mypoint end;
        public MyLine(mypoint point1,mypoint point2)
        {
            this.Begin = point1;
            this.end = point2;
        }
        public mypoint getBegin()
        {
            return Begin;
        }
        public void setBegin(mypoint begin)
        {
            this.Begin = begin;
        }
        public mypoint getEnd()
        {
            return end;
        }
        public void setEnd(mypoint end)
        {
            this.end = end;
        }
        public double getGradient()
        {
            double result =Math.Abs( (end.getY() - Begin.getY()) / (end.getX() - Begin.getX()));
            return result;
        }
    }
}
