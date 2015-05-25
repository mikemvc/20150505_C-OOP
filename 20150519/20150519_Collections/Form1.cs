using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20150519_Collections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList bag = new ArrayList();
            bag.Add(100);
            bag.Add("Chien");
            bag.Add(65.2);

            button1.Text = bag.Count.ToString();  // 3
            button1.Text = bag[1].ToString();  // Chien

            //bag.Remove("Chien");
            int iFoundIdex = bag.IndexOf("Chien");  // 1, -1 if NOT FOUND
            button1.Text = iFoundIdex.ToString();

            if (iFoundIdex > 0)
            {
                bag.RemoveAt(iFoundIdex);
            }
            button1.Text = bag[1].ToString();
        }
    }
}
