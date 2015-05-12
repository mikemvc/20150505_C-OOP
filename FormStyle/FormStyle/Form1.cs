﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormStyle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 視窗大小變更事件
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                //this.Visible = false;
                this.Hide();
                
            }
        }

        // 點擊icon兩次事件
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("test");
            //this.Visible = true;
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }
    }
}
