using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20150519_HomeworkReview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 8;
            // string s = Convert.ToString(x, 10);
            string s = Convert.ToString(x, 8);  // 0, 1, ... 7, 10
            // string s = Convert.ToString(x, 7);
            button1.Text = s;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int source = 9;
            string result = "";

            while (source > 0)
            {
                int x = source % 7;
                result = x.ToString() + result;
                source = source / 7;
            }

            button2.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int source = 9;
            // source = source / 7;
            // button3.Text = source.ToString();
            double d = source / 7f;
            button3.Text = d.ToString();

            // To any base:
            // http://stackoverflow.com/questions/923771/
        }
    }
}
