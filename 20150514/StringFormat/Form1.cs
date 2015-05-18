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
    }
}
