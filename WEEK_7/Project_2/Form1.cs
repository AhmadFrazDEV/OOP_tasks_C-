using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Form1 : Form
    {
        char Character;
        int Number1 = 0, Number2 = 0;
        float Result = 0;
        bool checker = false;
        public Form1()
        {
            InitializeComponent();
            textBox2.Text = "0";
        }
        private void label1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        string temp = "";
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "";
            }
            if(checker == false)
            {
                temp =temp + button6.Text;
                /*int.TryParse(button6.Text, out Number1);*/
                if(Character == '+')
                {
                    Number1 = int.Parse(temp);
                    checker = true;
                }
                textBox2.Text = textBox2.Text + Number1;
            }
            else
            {
                int.TryParse(button6.Text, out Number2);
                textBox2.Text = textBox2.Text + Number2;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
                char.TryParse(button12.Text, out Character);
                textBox2.Text = textBox2.Text + Character;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "";
            }
            if(Number1 == 0)
            {
                int.TryParse(button5.Text, out Number1);
                textBox2.Text = textBox2.Text + Number1;
            }
            else
            {
                int.TryParse(button5.Text, out Number2);
                textBox2.Text = textBox2.Text + Number2;
            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            char.TryParse(button13.Text, out Character);
            textBox2.Text = textBox2.Text + Character;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "";
            }
            if (Number1 == 0)
            {
                int.TryParse(button1.Text, out Number1);
                textBox2.Text = textBox2.Text + Number1;
            }
            else
            {
                int.TryParse(button1.Text, out Number2);
                textBox2.Text = textBox2.Text + Number2;
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "";
            }
            if (Number1 == 0)
            {
                int.TryParse(button4.Text, out Number1);
                textBox2.Text = textBox2.Text + Number1;
            }
            else
            {
                int.TryParse(button4.Text, out Number2);
                textBox2.Text = textBox2.Text + Number2;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "";
            }
            if (Number1 == 0)
            {
                int.TryParse(button2.Text, out Number1);
                textBox2.Text = textBox2.Text + Number1;
            }
            else
            {
                int.TryParse(button2.Text, out Number2);
                textBox2.Text = textBox2.Text + Number2;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "";
            }
            if(Number1 == 0)
            {
                int.TryParse(button9.Text, out Number1);
                textBox2.Text = textBox2.Text + Number1;
            }
            else
            {
                int.TryParse(button9.Text, out Number2);
                textBox2.Text = textBox2.Text + Number2;
            }
          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "";
            }
            if (Number1 == 0)
            {
                int.TryParse(button7.Text, out Number1);
                textBox2.Text = textBox2.Text + Number1;
            }
            else
            {
                int.TryParse(button7.Text, out Number2);
                textBox2.Text = textBox2.Text + Number2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "";
            }
            if (Number1 == 0)
            {
                int.TryParse(button3.Text, out Number1);
                textBox2.Text = textBox2.Text + Number1;
            }
            else
            {
                int.TryParse(button3.Text, out Number2);
                textBox2.Text = textBox2.Text + Number2;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "";
            }
            if (Number1 == 0)
            {
                int.TryParse(button10.Text, out Number1);
                textBox2.Text = textBox2.Text + Number1;
            }
            else
            {
                int.TryParse(button10.Text, out Number2);
                textBox2.Text = textBox2.Text + Number2;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "";
            }
            if (Number1 == 0)
            {
                int.TryParse(button8.Text, out Number1);
                textBox2.Text = textBox2.Text + Number1;
            }
            else
            {
                int.TryParse(button8.Text, out Number2);
                textBox2.Text = textBox2.Text + Number2;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            char number;
            char.TryParse(button11.Text, out number);
            textBox2.Text = textBox2.Text + number;
        }

        private void button15_Click(object sender, EventArgs e)
        {

            char.TryParse(button15.Text, out Character);
            textBox2.Text = textBox2.Text + Character;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            char.TryParse(button14.Text, out Character);
            textBox2.Text = textBox2.Text + Character;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int length = textBox2.Text.Length;
            textBox2.Text = textBox2.Text.Remove(length - 1);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Number2 = 0;
            Number1 = 0;
            Result  = 0;
            textBox2.Text = "0";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if(Character == '+')
            {
                Result =Result + Number1 + Number2;
            }
            else if(Character=='-')
            {
                float Temp = Result;
                Result = Math.Abs(Number2 - Number1);
                Result = Math.Abs(Result - Temp);
            }
            else if(Character == '/')
            {
                if (Number2 == 0)
                    Number2 = 1;
                Result =(Result/ Number1 )/ Number2;

            }
            else
            {
                if (Result == 0)
                    Result = 1;
                if(Number1 == 0)
                {
                    Number1 = 1;
                }
                if(Number2 == 0)
                {
                    Number2 = 1;
                }
                Result = Number2 * Number1 * Result;

            }
            Number2 = 0;
            Number1 = 0;
            textBox2.Text = "";
            textBox2.Text = "" + Result;
        }
        
    }
}
