using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string[] fileList = Directory.GetFiles(@"d:\temp", "*.txt", SearchOption.AllDirectories);
            //for (int i = 0; i < fileList.Length; i++)
            //{
            //    string sFilename = fileList[i];
            //    listBox1.Items.Add(sFilename);
            //}
            
            foreach (string sFilename in fileList)
            {
                listBox1.Items.Add(sFilename);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Process[] progList = System.Diagnostics.Process.GetProcesses();
            foreach (Process p in progList)
            {
                if (p.ProcessName == "notepad")
                    p.Kill();
                listBox1.Items.Add(p.ProcessName);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string s = "ABC中文字";
            // byte[] buffer = System.Text.Encoding.ASCII.GetBytes(s);  // ABC???
            // byte[] buffer = System.Text.Encoding.Unicode.GetBytes(s);
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(s);
            // System.Text.Encoding encoder = System.Text.Encoding.GetEncoding("Big5");
            // byte[] buffer = encoder.GetBytes(s);

            FileStream fs = new FileStream(@"c:\temp\test.txt", FileMode.Create);
            fs.Write(buffer, 0, buffer.Length);
            fs.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"c:\temp\test.txt", FileMode.Open);

            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, (int)fs.Length);
            fs.Close();

            string s = System.Text.Encoding.UTF8.GetString(buffer);
            button8.Text = s;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string s = "ABC中文字";
            StreamWriter w = new StreamWriter(@"c:\temp\test.txt", false);
            w.Write(s);
            w.Close();

            StreamReader r = new StreamReader(@"c:\temp\test.txt");
            string s2 = r.ReadToEnd();
            r.Close();

            button9.Text = s2;
        }
    }
}
