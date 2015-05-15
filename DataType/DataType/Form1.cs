using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 變數宣告
            int x = 100;
            int y;
            y = x;
            y = 200;
            // 兩邊型態要一致，所以x(數字)要轉型為字串
            button1.Text = x.ToString();

            #region 參考用
            //int iLast;
            //iLast = 1;
            //button1.Text = (iLast + 4).ToString();

            //int 薪水;
            //薪水 = 180000;
            //button1.Text = 薪水.ToString();

            // Camel
            // int employeeSalary;
            // int employeeMonthlySalary;
            #endregion
        }
    }
}
