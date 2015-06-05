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
    }
}
