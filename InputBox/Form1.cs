using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 按鈕點擊事件
        private void button1_Click(object sender, EventArgs e)
        {
            // 引用VB的方法
            button1.Text = Microsoft.VisualBasic.Interaction.
                InputBox("Please keyin a number:", "Asking", "75");
        }
    }
}
