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
//DJM
//simple threaded program
namespace ThreadsExample
{
    public partial class Form1 : Form
    {
        Thread newThread;
        Boolean flag = false, running = false;
        public Form1()
        {
            InitializeComponent();
            newThread = new Thread(threadMethod);
            newThread.Start();
            
        }

        public void threadMethod()
        {
            while(true)
            {
                if (running != true) continue;
                if (flag == false)
                {
                    this.button1.BackColor = Color.Red;
                    flag = true;
                } else
                {
                    this.button1.BackColor = Color.Gray;
                    flag = false;
                }
                Thread.Sleep(100);
            }
        }

        private void button1_Click1(object sender, EventArgs e)
        {
            running = !running;
        }
    }
}
