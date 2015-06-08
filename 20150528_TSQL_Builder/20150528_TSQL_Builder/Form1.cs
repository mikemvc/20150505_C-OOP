using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20150528_TSQL_Builder
{
    public partial class Form1 : Form
    {
        public string connection
        {
            get;
            set;
        }

        public Form1()
        {
            InitializeComponent();
            connection = tbQuery.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = tbConnection.Text;
            LoadTable();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            connection = tbConnection.Text;
            LoadTable();
        }

        #region 自訂方法
        void LoadTable()
        {
            SqlConnection conn = new SqlConnection(connection);
            string sql = "SELECT * FROM INFORMATION_SCHEMA.Tables";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = null;
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);
                checkedListBoxTable.Items.Clear();
                foreach (DataRow d in dt.Rows)
                {
                    checkedListBoxTable.Items.Add(d["TABLE_NAME"]);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
                if (dr != null)
                    dr.Close();
            }
        }
        void LoadCoulmns(string table)
        {
            SqlConnection conn = new SqlConnection(connection);
            string sql = "SELECT * FROM INFORMATION_SCHEMA.Columns Where Table_Name = @TableName";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("TableName", table);
            SqlDataReader dr = null;
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);
                checkedListBoxColumn.Items.Clear();
                foreach (DataRow d in dt.Rows)
                {
                    checkedListBoxColumn.Items.Add(d["COLUMN_NAME"]);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
                if (dr != null)
                    dr.Close();
            }
        }
        #endregion

        // 讀取資料表的欄位事件
        private void btnColumsn_Click(object sender, EventArgs e)
        {
            if (checkedListBoxTable.CheckedItems.Count != 1)
            {
                MessageBox.Show("只能選取單一資料表");
                return;
            }
            string table = checkedListBoxTable.CheckedItems[0].ToString();
            LoadCoulmns(table);
        }

        #region SQL的CRUD語法
        // 產生新增的SQL語法
        private void btnCreate_Click(object sender, EventArgs e)
        {
            tbQuery.Text = "";
            if (checkedListBoxTable.CheckedItems.Count != 1 ||
                checkedListBoxColumn.CheckedItems.Count < 1)
            {
                MessageBox.Show("請至少選取一個資料表及一個欄位，謝謝！");
                return;
            }
            string table = checkedListBoxTable.CheckedItems[0].ToString();
            string columns = "";
            string parameters = "";
            foreach (var item in checkedListBoxColumn.CheckedItems)
            {
                if (columns.Length > 0)
                {
                    columns += ",";
                    parameters += ",";
                }
                columns += item.ToString();
                parameters += "@" + item.ToString();
            }
            string sql = string.Format("INSERT INTO {0} \n({1}) \nVALUES({2})",
                                        table,
                                        columns,
                                        parameters);
            tbQuery.Text = sql;


        }
        // 產生查詢的SQL語法
        private void btnRead_Click(object sender, EventArgs e)
        {
            tbQuery.Text = "";
            if (checkedListBoxTable.CheckedItems.Count != 1 ||
                checkedListBoxColumn.CheckedItems.Count < 1)
            {
                MessageBox.Show("請至少選取一個資料表及一個欄位，謝謝！");
                return;
            }
            string table = checkedListBoxTable.CheckedItems[0].ToString();
            string columns = "";
            foreach (var item in checkedListBoxColumn.CheckedItems)
            {
                if (columns.Length > 0)
                {
                    columns += ",";
                }
                columns += item.ToString();
            }
            string sql = string.Format("SELECT {0} FROM {1}",
                                        columns,
                                        table);
            tbQuery.Text = sql;
        }
        // 產生更新的SQL語法
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tbQuery.Text = "";
            if (checkedListBoxTable.CheckedItems.Count != 1 ||
                checkedListBoxColumn.CheckedItems.Count < 1)
            {
                MessageBox.Show("請至少選取一個資料表及一個欄位，謝謝！");
                return;
            }
            string pk = "";
            string table = checkedListBoxTable.CheckedItems[0].ToString();
            string columnsAndparameters = "";
            #region 取得主鍵以及欄位
            SqlConnection conn = new SqlConnection(connection);
            string sql1 = string.Format("EXEC sp_pkeys @table_name = N'{0}'", table);
            SqlCommand cmd = new SqlCommand(sql1, conn);
            SqlDataReader dr = null;
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);
                pk = dt.Rows[0]["COLUMN_NAME"].ToString();
                dt = null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                if (dr != null)
                    dr.Close();
            }
            // 取得欄位資料
            foreach (var item in checkedListBoxColumn.CheckedItems)
            {
                if (columnsAndparameters.Length > 0)
                {
                    columnsAndparameters += ",";
                }
                columnsAndparameters += item.ToString() + " = @" + item.ToString();
            }
            #endregion

            string sql = string.Format("UPDATE {0} SET {1} WHERE {2} = @{2}",
                                    table,
                                    columnsAndparameters,
                                    pk);
            tbQuery.Text = sql;

        }
        // 產生刪除的SQL語法
        private void btnDelete_Click(object sender, EventArgs e)
        {
            tbQuery.Text = "";
            if (checkedListBoxTable.CheckedItems.Count != 1)
            {
                MessageBox.Show("請至少選取一個資料表，謝謝！");
                return;
            }
            string pk = "";
            string table = checkedListBoxTable.CheckedItems[0].ToString();

            #region 取得主鍵
            SqlConnection conn = new SqlConnection(connection);
            string sql1 = string.Format("EXEC sp_pkeys @table_name = N'{0}'", table);
            SqlCommand cmd = new SqlCommand(sql1, conn);
            SqlDataReader dr = null;
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);
                pk = dt.Rows[0]["COLUMN_NAME"].ToString();
                dt = null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                if (dr != null)
                    dr.Close();
            }
            #endregion

            string sql = string.Format("DELETE {0} WHERE {1} = @{1}",
                                    table,
                                    pk);
            tbQuery.Text = sql;
        }
        #endregion

        // 選取所有欄位
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxColumn.Items.Count - 1; i++)
            {
                checkedListBoxColumn.SetItemChecked(i, true);
            }
        }
        // 取消選取所有欄位
        private void btnCancelAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxColumn.Items.Count - 1; i++)
            {
                checkedListBoxColumn.SetItemChecked(i, false);
            }
        }
    }
}
