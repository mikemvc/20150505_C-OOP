using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20150521_functions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Add(int x, int y)
        {
            return x + y;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // 使用自建的function
            int answer = Add(1, 2);
            button1.Text = answer.ToString();
        }

        
    }
}
