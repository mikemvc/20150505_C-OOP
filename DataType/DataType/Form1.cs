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
        public class TPoint
        {
            public int X;
            public int Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Value Type

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

        private void button2_Click(object sender, EventArgs e)
        {
            // Reference Type
            TPoint p1 = new TPoint { X = 100, Y = 200 };
            p1.X = 201;
            TPoint p2;
            p2 = p1;
            p2.X = 101;
            button2.Text = p1.X.ToString();

            int x = 100;
            int y;
            y = x;
            y = 200;
            button1.Text = x.ToString();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            int x = 0;

            x = 3;

            x = (int)4.1;  // 4
            x = (int)5.999;  // 5

            // VB:
            // Dim x as Integer
            // C#:
            // int x;
            // int or Integer => System.Int32
            x = Convert.ToInt32(6.4);  // 6
            x = Convert.ToInt32(7.5);  // 8
            x = Convert.ToInt32(18.5);  // 18
            // 四捨六入五成雙
            // 1234-5-6789

            double y = Math.Round(18.5, 0, MidpointRounding.AwayFromZero);

            button3.Text = y.ToString();
        }
    }
}
