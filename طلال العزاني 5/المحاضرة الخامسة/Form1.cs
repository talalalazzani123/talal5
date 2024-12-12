using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace المحاضرة_الخامسة
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.BackColor = Color.Yellow;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.BackColor = Color.Green;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label2.BackColor = Color.Black;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Yellow;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Pink;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible= true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int s = 0;
            bool f = false;
            textBox1.Text = null;
            if(checkBox1.Checked==true)
            {
                s += Convert.ToInt32(checkBox1.Text);
                f = true;
            }
            if (checkBox2.Checked == true)
            {
                s += Convert.ToInt32(checkBox2.Text);
                f = true;
            }
            if (checkBox3.Checked == true)
            {
                s += Convert.ToInt32(checkBox3.Text);
                f = true;
            }
            if (checkBox4.Checked == true)
            {
                s += Convert.ToInt32(checkBox4.Text);
                f = true;
            }
            textBox1.Text = s.ToString();
        }
    }
}
