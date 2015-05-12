using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure close form?");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure close form?",
                        "Asking",
                        MessageBoxButtons.YesNo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure close form?",
                        "Asking",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);
        }

        // 關閉視窗事件
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Are you sure close form?",
                        "Asking",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);
            if (answer == System.Windows.Forms.DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;

        }
    }
}
