using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringFormat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 100;
            int y = 200;
            // (100, 200);

            //string result = "";
            //result = "(" + x.ToString() + ", " + y.ToString() + ")";
            //button1.Text = result;
            string result = "";
            // result = string.Format("format", value1, value2, ....)
            result = string.Format("({0}, {1})", x, y);
            button1.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 3;      // "003"
            // int i = 32;  // "032"
            // button2.Text = (i + 1000).ToString().Substring(1, 3);

            button2.Text = string.Format("{0:D3}", i);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 123456;
            // button3.Text = string.Format("{0:C}", i);
            button3.Text = string.Format("{0:N4}", i);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 15;
            // button4.Text = i.ToString();
            button4.Text = i.ToString("x");  // f
        }
    }
}
