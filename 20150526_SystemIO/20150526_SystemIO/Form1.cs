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
    }
}
