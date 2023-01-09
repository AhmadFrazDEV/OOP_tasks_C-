using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1.BL
{
    class mypoint
    {
        private int X;
        private int Y;
        public int getX()
        {
            return X;
        }
        public int getY()
        {
            return Y;
        }
        public void setX(int X)
        {
            this.X = X;
        }
        public void setY(int Y)
        {
            this.Y = Y;
        }
        public void setXY(int X,int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public double distanceWithCords(int x,int y)
        {
            double result = Math.Sqrt(Math.Pow((X - x), 2) + Math.Pow((Y - y), 2));
            return result;
        }
        public double distanceWithObject(mypoint Y)
        {
            double result = Math.Sqrt(Math.Pow((Y.X - X), 2) + Math.Pow((Y.Y - this.Y), 2));
            return result;
        }
        public double distanceFromZero()
        {
            double result = Math.Sqrt(Math.Pow((this.X - 0), 2) + Math.Pow((this.Y - 0), 2));
            return result;
        }


    }
}
