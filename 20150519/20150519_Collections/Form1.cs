using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Hashtable bag = new Hashtable();
            bag["firstName"] = "Wolfgang";  // bag.Add("firstName", "Wolfgang");
            button2.Text = bag["firstName"].ToString();

            bag["firstName"] = "Richard";
            button2.Text = bag["firstName"].ToString();

            #region 參考用
            // DataTable dt = ds.Tables["Products"];
            // DataRow dr = dt.Rows[0]
            // String sProdName = dr["ProductName"].ToString();
            #endregion
        }

        class TPoint
        {
            public int X;
            public int Y;
        }
        // 1. 滑鼠右鍵點按「參考」, 勾選 System.Web.Extensions.dll
        // 2. using System.Web.Script.Serialization;
        private void button3_Click(object sender, EventArgs e)
        {
            TPoint pt = new TPoint() { X = 100, Y = 200 };
            ArrayList col = new ArrayList();
            col.Add(pt);
            col.Add(new TPoint() { X = 300, Y = 400 });
            col.Add(new TPoint() { X = 500, Y = 600 });

            JavaScriptSerializer encoder = new JavaScriptSerializer();
            string sJson = encoder.Serialize(col);
            textBox1.Text = sJson;

            ArrayList col2 = encoder.Deserialize<ArrayList>(sJson);
            button3.Text = col2[2].GetType().ToString();
            // ???
        }
    }
}
