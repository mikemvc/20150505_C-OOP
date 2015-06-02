using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20150526_SystemIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // using System.IO;
            Directory.CreateDirectory(@"C:\test123\test456\test789");
            button1.Text = "OK";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sFolderName = @"C:\test123\test456";
            //if (Directory.Exists(sFolderName))
            //    Directory.Delete(sFolderName);
            
            try
            {
                // do work
                this.Text = "Check point 1";
                Directory.Delete(sFolderName);
                this.Text = "Check point 2";
            }
            catch
            {
                // on error!!!!!
                button2.Text = "Error!";
            }

            this.Text = "Check point 3";
        }

        void doWork(int value)
        {
            try
            {
                if (value == 4)
                    throw new Exception("error");
                listBox1.Items.Add(value);
            }
            catch
            {
                listBox1.Items.Add("ERROR!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 1; i <= 9; i++)
            {
                doWork(i);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s = "notepad";
            s = "http://www.hinet.net";
            s = @"d:\temp\test.txt";
            s = "notepader";
            try
            {
                System.Diagnostics.Process.Start(s);
            }
            catch
            {
                button4.Text = "!";
            }
        }
    }
}
