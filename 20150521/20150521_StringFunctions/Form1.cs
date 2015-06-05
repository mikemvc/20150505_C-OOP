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

        private void button2_Click(object sender, EventArgs e)
        {
            //                0 1 2 3 4 5
            string sFormal = "零壹貳參肆伍...";
            int iNum = 3;
            button2.Text = sFormal.Substring(iNum, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // yyyyMMddnnnn  201505210003
            int iTh = 3;

            // button3.Text = String.Format("{0:D4}", iTh);

            button3.Text = (iTh + 10000).ToString().Substring(1, 4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //                    1         2         3
            //          01234567890123456789012345678901234567890
            string s = "123ABC123abc1234ABCxxx";
            int iPosition = s.IndexOf("ABC");// 3
            // iPosition = s.IndexOf("ABC", iPosition + 1); // 16
            // iPosition = s.IndexOf("ABC", iPosition + 1, StringComparison.OrdinalIgnoreCase);  // 9
            iPosition = s.IndexOf("ABCD"); // -1 ==> not found
            button4.Text = iPosition.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string s = "123ABC123abc1234ABCxxx";
            // button5.Text = s.Replace("ABC", "-");
            button5.Text = s.Replace("ABC", "");
        }
    }
}
