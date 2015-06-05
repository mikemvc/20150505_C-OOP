using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20150521_MyPassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random dice = new Random(1);
            for (int i = 1; i <= 9; i++)
            {
                listBox1.Items.Add(dice.Next(0, 10));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int iSeed;
            if (!int.TryParse(txtSeed.Text, out iSeed))
            {
                button2.Text = "Pleaes keyin a number.";
                return;
            }

            Random dice = new Random(iSeed);
            int iHowmanyLine = 8;
            int iHowmanyColumn = 10;

            for (int iLine = 1; iLine <= iHowmanyLine; iLine++)
            {
                string sLine = "";
                for (int iCol = 1; iCol <= iHowmanyColumn; iCol++)
                {
                    int iDice = dice.Next(0, 10);
                    sLine += iDice.ToString();
                }
                listBox1.Items.Add(sLine);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int iSeed;
            if (!int.TryParse(txtSeed.Text, out iSeed))
            {
                button2.Text = "Pleaes keyin a number.";
                return;
            }


            Random dice = new Random(iSeed);
            int iHowmanyLine = 8;
            int iHowmanyColumn = 10;
            string sPool = "0123456789a88888888888bcdefghijkmnpqrstuvwxyz";
            //              0123456789012345678901234567890123456789
            //                        1         2         3    
            for (int iLine = 1; iLine <= iHowmanyLine; iLine++)
            {
                string sLine = "";
                for (int iCol = 1; iCol <= iHowmanyColumn; iCol++)
                {
                    int iDice = dice.Next(0, sPool.Length);
                    sLine += sPool.Substring(iDice, 1);
                }
                listBox1.Items.Add(sLine);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sPool = "0123456789a88888888888bcdefghijkmnpqrstuvwxyz";
            Random dice = new Random(100);

            // int iDice = dice.Next(0, sPool.Length);  // 0..44
            //listBox1.Items.Add(sPool.Length); // 45
            //listBox1.Items.Add(iDice);  // 43
            //listBox1.Items.Add(sPool.Substring(iDice, 1));
            string sLine = "";
            for (int iColumn = 1; iColumn <= 10; iColumn++)
            {
                int iDice = dice.Next(0, sPool.Length);
                sLine = sLine + sPool.Substring(iDice, 1);
            }

            button4.Text = sLine;
        }
    }
}
