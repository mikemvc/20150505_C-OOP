using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loopDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 將listBox1 新增一個Item
            string sUserKeyin = textBox1.Text;
            listBox1.Items.Add(sUserKeyin);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 設定listBox1的第一個元素為AAA
            //listBox1.Items[0] = "AAA";

            // 移除ListBox1中的C元素
            //listBox1.Items.Remove("C");

            //移除listBox1的第一個元素 (索引index從0開始)
            if (listBox1.Items.Count > 0) listBox1.Items.RemoveAt(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // for的變數i也可以設定在外面，但是不建議這麼做
            //int i = 1;
            //for (i = 1; i <= 9; i++)
            //{

            //}
            //button3.Text = i.ToString();

            for (int i = 1; i <= 9; i++)
            {
                if (i == 4)
                    continue;
                listBox1.Items.Add(i);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i <= 9)
            {
                if (i == 4)
                {
                    i++;
                    continue;
                }
                //if (i == 4)
                //    break;
                listBox1.Items.Add(i);
                i += 1; // i++;
            }
            listBox1.Items.Add("End");

            #region 示範
            //int employeeMonthlySalary = 80000;
            //employeeMonthlySalary = employeeMonthlySalary + 10000;
            //employeeMonthlySalary += 10000;
            #endregion
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int result = 0;
            int i = 1;
            while (i <= 10)
            {
                result = result + i;  // 0 + 1 + 2 + 3 + ...
                i++;
            }
            button5.Text = result.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int result = 0;
            int i = 0;
            while (i < 10)
            {
                i++;
                result = result + i;  // 0 + 1 + 2 + 3 + ...
            }
            button6.Text = result.ToString();
        }
    }
}
