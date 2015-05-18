using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ifelse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                button1.Text = "Yes";
            else
                button1.Text = "No";

            #region 示範
            // 如果IF有多行敘述，則要用{}大括弧包起來，
            // 只有單行則可以省略

            //int x = -10;            
            //if (x >= 0) {
            //    button1.Text = "Yes";
            //    this.Text = "OK";
            //}
            //else // if (x < 0)
            //    button1.Text = "NO";
            #endregion
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (checkBox1.Checked)
            //    e.Cancel = false;
            //else
            //    e.Cancel = true;

            // 三元表示法
            // (true / false) ? xxx : yyy;
            //e.Cancel = (checkBox1.Checked) ? false : true;

            e.Cancel = !checkBox1.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // sender 是委派涵式所傳遞的對象，此例子中是Button
            (sender as Button).Text = DateTime.Now.ToString();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // 將視窗標題設定為現在的座標
            this.Text = string.Format("({0}, {1})", e.X, e.Y);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 三個if的寫法
            //if (rdoA.Checked)
            //    button5.Text = "A";

            //if (rdoB.Checked)
            //    button5.Text = "B";

            //if (rdoC.Checked)
            //    button5.Text = "C";

            // if else if的寫法
            if (rdoA.Checked)
                button5.Text = "A";
            else if (rdoB.Checked)
                button5.Text = "B";
            else if (rdoC.Checked)
                button5.Text = "C";
            else
                button5.Text = "other";
        }
    }
}
