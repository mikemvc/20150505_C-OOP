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

        //void ShowStar(int iHowMany, string sWhat = "*") {
        //    string sStar = "";
        //    for (int i = 1; i <= iHowMany; i++) {
        //        sStar += sWhat;
        //    }
        //    MessageBox.Show(sStar);
        //}

        // Overloading
        void ShowStar()
        {
            ShowStar(3, "*");
        }

        void ShowStar(int iHowMany)
        {
            ShowStar(iHowMany, "*");
        }

        //void ShowStar(int iHowMany, string sWhat) {
        //    string sStar = "";
        //    for (int i = 1; i <= iHowMany; i++) {
        //        sStar += sWhat;
        //    }
        //    MessageBox.Show(sStar);
        //}

        //void ShowStar(int iHowMany, string sWhat) {
        //    if (iHowMany > 0) {
        //        if (iHowMany <= 20) {
        //            string sStar = "";
        //            for (int i = 1; i <= iHowMany; i++) {
        //                sStar += sWhat;
        //            }
        //            MessageBox.Show(sStar);
        //        }
        //        else
        //            MessageBox.Show("iHowMany <= 20 please.");
        //    }
        //    else
        //        MessageBox.Show("iHowMany > 0 please.");
        //}
        
        void ShowStar(int iHowMany, string sWhat)
        {
            if (iHowMany > 20)
            {
                MessageBox.Show("iHowMany <= 20 please.");
                return;
            }
            if (iHowMany <= 0)
            {
                MessageBox.Show("iHowMany > 0 please.");
                return;
            }
            if (iHowMany == 4)
            {
                MessageBox.Show("iHowMany != 4 please.");
                return;
            }

            string sStar = "";
            for (int i = 1; i <= iHowMany; i++)
            {
                sStar += sWhat;
            }
            MessageBox.Show(sStar);

            // finally..
        }

        // Overloading...
        private void button2_Click(object sender, EventArgs e)
        {
            // ShowStar(5, "%");
            // ShowStar(5);
            // ShowStar();

            int iCount = 3;
            ShowStar(iCount);
        }

        // void Test(int iHowMany) {  iHowMany = 3
        // void Test(ref int iHowMany) { iHowMany = (at)iCount; iHowMany->
        void Test(ref int iHowMany)
        {
            MessageBox.Show(iHowMany.ToString());
            // ...
            iHowMany = 6;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int iCount = 3;
            Test(ref iCount);
            button3.Text = iCount.ToString();
        }

        void Foo(out int iTest)
        {
            // MessageBox.Show(iTest.ToString()); // Compiler Error
            iTest = 6;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int iCount = 3;
            Foo(out iCount);
            button4.Text = iCount.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // string sUserKeyin = textBox1.Text;
            // int iTest = Convert.ToInt32(sUserKeyin);
            // int iTest = (int)sUserKeyin;

            int iTest;
            if (int.TryParse(textBox1.Text, out iTest))
                button5.Text = iTest.ToString();
            else
                button5.Text = "Wrong format";
        }
    }
}
