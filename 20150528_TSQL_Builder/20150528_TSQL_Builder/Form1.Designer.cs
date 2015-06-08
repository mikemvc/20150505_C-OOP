namespace _20150528_TSQL_Builder
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelAll = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnColumsn = new System.Windows.Forms.Button();
            this.checkedListBoxTable = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnection = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbConnection = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBoxColumn = new System.Windows.Forms.CheckedListBox();
            this.tbQuery = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(344, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 27);
            this.label5.TabIndex = 34;
            this.label5.Text = "1.請修改連線字串，並讀取資料表";
            // 
            // btnCancelAll
            // 
            this.btnCancelAll.Location = new System.Drawing.Point(77, 280);
            this.btnCancelAll.Name = "btnCancelAll";
            this.btnCancelAll.Size = new System.Drawing.Size(118, 30);
            this.btnCancelAll.TabIndex = 33;
            this.btnCancelAll.Text = "全部取消";
            this.btnCancelAll.UseVisualStyleBackColor = true;
            this.btnCancelAll.Click += new System.EventHandler(this.btnCancelAll_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(22, 279);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(49, 30);
            this.btnSelectAll.TabIndex = 32;
            this.btnSelectAll.Text = "全選";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "4.請選擇要產生的語法";
            // 
            // btnColumsn
            // 
            this.btnColumsn.Location = new System.Drawing.Point(204, 243);
            this.btnColumsn.Name = "btnColumsn";
            this.btnColumsn.Size = new System.Drawing.Size(118, 30);
            this.btnColumsn.TabIndex = 30;
            this.btnColumsn.Text = "讀取欄位";
            this.btnColumsn.UseVisualStyleBackColor = true;
            this.btnColumsn.Click += new System.EventHandler(this.btnColumsn_Click);
            // 
            // checkedListBoxTable
            // 
            this.checkedListBoxTable.FormattingEnabled = true;
            this.checkedListBoxTable.Items.AddRange(new object[] {
            "Table1",
            "Table2",
            "Table3",
            "Table4",
            "Table5",
            "Table6"});
            this.checkedListBoxTable.Location = new System.Drawing.Point(22, 34);
            this.checkedListBoxTable.Margin = new System.Windows.Forms.Padding(5);
            this.checkedListBoxTable.Name = "checkedListBoxTable";
            this.checkedListBoxTable.Size = new System.Drawing.Size(300, 196);
            this.checkedListBoxTable.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(18, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "2.請選擇要輸出的資料表";
            // 
            // btnConnection
            // 
            this.btnConnection.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConnection.Location = new System.Drawing.Point(701, 9);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(161, 52);
            this.btnConnection.TabIndex = 27;
            this.btnConnection.Text = "讀取";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(947, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 36);
            this.label2.TabIndex = 26;
            this.label2.Text = "連線字串";
            // 
            // tbConnection
            // 
            this.tbConnection.Location = new System.Drawing.Point(348, 75);
            this.tbConnection.Multiline = true;
            this.tbConnection.Name = "tbConnection";
            this.tbConnection.Size = new System.Drawing.Size(723, 63);
            this.tbConnection.TabIndex = 25;
            this.tbConnection.Text = "Data Source=192.168.1.41;Initial Catalog=CERMS;Persist Security Info=True;User ID" +
    "=sa;Password=12345678";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(953, 160);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 52);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(817, 160);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 52);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(683, 160);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(118, 52);
            this.btnRead.TabIndex = 22;
            this.btnRead.Text = "查詢";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(559, 160);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(118, 52);
            this.btnCreate.TabIndex = 21;
            this.btnCreate.Text = "新增";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(18, 248);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "3.請選擇要輸出的欄位";
            // 
            // checkedListBoxColumn
            // 
            this.checkedListBoxColumn.FormattingEnabled = true;
            this.checkedListBoxColumn.Items.AddRange(new object[] {
            "Columns1",
            "Columns2",
            "Columns3",
            "Columns4",
            "Columns5",
            "Columns6"});
            this.checkedListBoxColumn.Location = new System.Drawing.Point(22, 317);
            this.checkedListBoxColumn.Margin = new System.Windows.Forms.Padding(5);
            this.checkedListBoxColumn.Name = "checkedListBoxColumn";
            this.checkedListBoxColumn.Size = new System.Drawing.Size(300, 292);
            this.checkedListBoxColumn.TabIndex = 19;
            // 
            // tbQuery
            // 
            this.tbQuery.Location = new System.Drawing.Point(348, 220);
            this.tbQuery.Margin = new System.Windows.Forms.Padding(5);
            this.tbQuery.Multiline = true;
            this.tbQuery.Name = "tbQuery";
            this.tbQuery.Size = new System.Drawing.Size(723, 389);
            this.tbQuery.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 619);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelAll);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnColumsn);
            this.Controls.Add(this.checkedListBoxTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbConnection);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxColumn);
            this.Controls.Add(this.tbQuery);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelAll;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnColumsn;
        private System.Windows.Forms.CheckedListBox checkedListBoxTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbConnection;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBoxColumn;
        private System.Windows.Forms.TextBox tbQuery;
    }
}

