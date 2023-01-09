using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Clock_Type
{
    class Class1
    {
        public int hour;
        public int sec;
        public int mint;
        public Class1(int hour,int mint,int sec)
        {
            this.hour = hour;
            this.mint = mint;
            this.sec = sec;
        }
        public void SecondIncrement(int hour,int mint,int sec)
        {
            int temp = hour;
            int temp2 = mint;
            if (hour > 12)
            {
                temp = hour - 12;
                if (temp < 0)
                {
                    temp = temp * -1;
                }
            }
            if (mint > 60)
            {
                temp2 = mint - 60;
                if (temp < 0)
                {
                    temp2 = temp2 * -1;
                }
            }
            this.hour = temp;
            this.mint = temp2;
            this.sec = sec + 1;
        }
        public void MintueIncrement(int hour, int mint, int sec)
        {
            int temp = hour;
            int temp2 = mint;
            if (hour > 12)
            {
                temp = hour - 12;
                if (temp < 0)
                {
                    temp = temp * -1;
                }
            }
            if (mint > 60)
            {
                temp2 = mint - 60;
                if (temp2 < 0)
                {
                    temp2 = temp2 * -1;
                }
            }
            this.hour = temp;
            this.mint = temp2+1;
            this.sec = sec;
        }
        public void HourIncrement(int hour, int mint, int sec)
        {
            int temp = hour;
            int temp2 = mint;
            if (hour > 12)
            {
                temp = hour - 12;
                if(temp < 0)
                {
                    temp = temp * -1;
                }
            }
            if (mint > 60)
            {
                temp2 = mint - 60;
                if (temp < 0)
                {
                    temp2 = temp2 * -1;
                }
            }
            this.hour = temp+1;
            this.mint = temp2;
            this.sec = sec;
        }



    }
}
