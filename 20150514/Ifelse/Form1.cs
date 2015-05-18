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
    }
}
