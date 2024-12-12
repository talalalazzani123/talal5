using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace المحاضرة_الخامسة
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Thread threadgo;
        bool stopMoving = false; 
        bool moveRight = true; 

        private void button3_Click(object sender, EventArgs e)
        {
            stopMoving = false; 
            threadgo = new Thread(go);
            threadgo.Start();
        }

        void go()
        {
            while (!stopMoving) 
            {
                Invoke((Action)(() =>
                { 
                    if (moveRight) 
                    {
                        button1.Left += 10;
                        if (button1.Left >= this.Width - button1.Width - 50)
                            moveRight = false; 
                    }
                    else 
                    {
                        button1.Left -= 10;
                        if (button1.Left <= 0)
                            moveRight = true; 
                    }
                }));
                Thread.Sleep(100);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stopMoving = false; 
            threadgo = new Thread(goDown);
            threadgo.Start();
        }

        void goDown()
        {
            while (!stopMoving) 
            {
                Invoke((Action)(() =>
                {
                    if (button2.Top < this.Height - button2.Height - 50)
                    {
                        button2.Top += 10; 
                    }
                    else
                    {
                        stopMoving = true; 
                    }
                }));
                Thread.Sleep(1000); 
            }
        }



        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopMoving = true; 
            if (threadgo != null)
                threadgo.Abort();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            stopMoving = true;
        }
    }
}
