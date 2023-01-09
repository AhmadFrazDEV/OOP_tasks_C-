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
    public partial class PRODUCTS : Form
    {
        public PRODUCTS()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 Temp = new Form1();
            this.Hide();
            Temp.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PRODUCTS_Load(object sender, EventArgs e)
        {

        }
    }
}
