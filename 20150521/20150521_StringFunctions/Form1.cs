using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20150521_StringFunctions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string s = "ABC";  // 3
            string s = "ABC中文字";  // 6
            // System.Text.Encoding.UTF8.GetBytes()
            // Sytem.Text.Encoding.GetEncoding("big5")
            int iLength = s.Length;
            button1.Text = iLength.ToString();
        }
    }
}
