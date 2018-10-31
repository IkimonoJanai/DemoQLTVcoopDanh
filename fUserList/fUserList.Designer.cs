namespace DemoQuanLyThuVien
{
    partial class fUserList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fUserList));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "a",
            "as",
            "ab",
            "ac"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("b");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("c");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("x");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("y");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("z");
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvfUserList = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbfUserListType = new System.Windows.Forms.ComboBox();
            this.nbfUserList = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btSavefUserList = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btAddfUserList = new System.Windows.Forms.Button();
            this.txtPassfUserList5 = new System.Windows.Forms.TextBox();
            this.txtDisplayfUserList = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNamefUserList = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.mnfUserListHome = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvfUserList)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbfUserList)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvfUserList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(124, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(775, 288);
            this.panel3.TabIndex = 6;
            // 
            // dtgvfUserList
            // 
            this.dtgvfUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvfUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.DisplayName,
            this.PassWord,
            this.Type,
            this.Delete});
            this.dtgvfUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvfUserList.Location = new System.Drawing.Point(0, 0);
            this.dtgvfUserList.Name = "dtgvfUserList";
            this.dtgvfUserList.Size = new System.Drawing.Size(775, 288);
            this.dtgvfUserList.TabIndex = 0;
            this.dtgvfUserList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvfUserList_CellContentClick);
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Tên đăng nhập";
            this.UserName.Name = "UserName";
            // 
            // DisplayName
            // 
            this.DisplayName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DisplayName.DataPropertyName = "DisplayName";
            this.DisplayName.HeaderText = "Tên hiển thị";
            this.DisplayName.Name = "DisplayName";
            // 
            // PassWord
            // 
            this.PassWord.DataPropertyName = "PassWord";
            this.PassWord.HeaderText = "Mật khẩu";
            this.PassWord.Name = "PassWord";
            this.PassWord.Width = 70;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Chức vự";
            this.Type.Name = "Type";
            this.Type.Width = 40;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Xóa";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 35;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbfUserListType);
            this.panel2.Controls.Add(this.nbfUserList);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btSavefUserList);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btAddfUserList);
            this.panel2.Controls.Add(this.txtPassfUserList5);
            this.panel2.Controls.Add(this.txtDisplayfUserList);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtNamefUserList);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(124, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 132);
            this.panel2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(446, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 159);
            this.label4.TabIndex = 5;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // cbfUserListType
            // 
            this.cbfUserListType.FormattingEnabled = true;
            this.cbfUserListType.Location = new System.Drawing.Point(340, 82);
            this.cbfUserListType.Name = "cbfUserListType";
            this.cbfUserListType.Size = new System.Drawing.Size(108, 21);
            this.cbfUserListType.TabIndex = 4;
            // 
            // nbfUserList
            // 
            this.nbfUserList.Location = new System.Drawing.Point(405, 58);
            this.nbfUserList.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbfUserList.Name = "nbfUserList";
            this.nbfUserList.Size = new System.Drawing.Size(43, 20);
            this.nbfUserList.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(228, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "Làm mới";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(228, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btSavefUserList_Click);
            // 
            // btSavefUserList
            // 
            this.btSavefUserList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btSavefUserList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btSavefUserList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btSavefUserList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSavefUserList.Location = new System.Drawing.Point(154, 58);
            this.btSavefUserList.Name = "btSavefUserList";
            this.btSavefUserList.Size = new System.Drawing.Size(68, 31);
            this.btSavefUserList.TabIndex = 2;
            this.btSavefUserList.Text = "Lưu";
            this.btSavefUserList.UseVisualStyleBackColor = true;
            this.btSavefUserList.Click += new System.EventHandler(this.btSavefUserList_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(80, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Xoá";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btAddfUserList
            // 
            this.btAddfUserList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAddfUserList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btAddfUserList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btAddfUserList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddfUserList.Location = new System.Drawing.Point(6, 58);
            this.btAddfUserList.Name = "btAddfUserList";
            this.btAddfUserList.Size = new System.Drawing.Size(68, 31);
            this.btAddfUserList.TabIndex = 2;
            this.btAddfUserList.Text = "Thêm";
            this.btAddfUserList.UseVisualStyleBackColor = true;
            this.btAddfUserList.Click += new System.EventHandler(this.btAddfUserList_Click);
            // 
            // txtPassfUserList5
            // 
            this.txtPassfUserList5.Location = new System.Drawing.Point(340, 7);
            this.txtPassfUserList5.Name = "txtPassfUserList5";
            this.txtPassfUserList5.Size = new System.Drawing.Size(108, 20);
            this.txtPassfUserList5.TabIndex = 1;
            // 
            // txtDisplayfUserList
            // 
            this.txtDisplayfUserList.Location = new System.Drawing.Point(100, 33);
            this.txtDisplayfUserList.Name = "txtDisplayfUserList";
            this.txtDisplayfUserList.Size = new System.Drawing.Size(348, 20);
            this.txtDisplayfUserList.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(337, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chức vụ";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(277, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mật khẩu";
            // 
            // txtNamefUserList
            // 
            this.txtNamefUserList.Location = new System.Drawing.Point(100, 7);
            this.txtNamefUserList.Name = "txtNamefUserList";
            this.txtNamefUserList.Size = new System.Drawing.Size(160, 20);
            this.txtNamefUserList.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên hiển thị";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 418);
            this.panel1.TabIndex = 8;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewItem1.ToolTipText = "asd";
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(124, 418);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // mnfUserListHome
            // 
            this.mnfUserListHome.BackColor = System.Drawing.Color.White;
            this.mnfUserListHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnfUserListHome.Name = "mnfUserListHome";
            this.mnfUserListHome.Size = new System.Drawing.Size(68, 25);
            this.mnfUserListHome.Text = "Home";
            this.mnfUserListHome.Click += new System.EventHandler(this.mnfUserListHome_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnfUserListHome});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 29);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 447);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fUserList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fUserList";
            this.Load += new System.EventHandler(this.fUserList_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvfUserList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbfUserList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvfUserList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btSavefUserList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btAddfUserList;
        private System.Windows.Forms.TextBox txtPassfUserList5;
        private System.Windows.Forms.TextBox txtDisplayfUserList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNamefUserList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nbfUserList;
        private System.Windows.Forms.ComboBox cbfUserListType;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.ToolStripMenuItem mnfUserListHome;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}