using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASK_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int Quantity;
            int.TryParse(textBox3.Text,out Quantity);
            Quantity = Quantity * 20;
            textBox4.Text =""+Quantity;
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "0";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int Quantity;
            int.TryParse(textBox5.Text, out Quantity);
            Quantity = Quantity * 1000;
            textBox6.Text = "" + Quantity;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            textBox5.Text = "0";
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            int Quantity;
            int.TryParse(textBox8.Text, out Quantity);
            Quantity = Quantity * 3000;
            textBox7.Text = "" + Quantity;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            textBox8.Text = "0";
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Price1;
            int.TryParse(textBox4.Text, out Price1);
            int Price2;
            int.TryParse(textBox6.Text, out Price2);
            int Price3;
            int.TryParse(textBox7.Text, out Price3);
            int Total = Price2 + Price1 + Price3;
            textBox10.Text = "" + Total;
            MessageBox.Show("Thanks For Buying Products");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form1 Temp = new Form1();
            this.Hide();
            Temp.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            PRODUCTS Temp = new PRODUCTS();
            this.Hide();
            Temp.Show();
        }
    }
}
