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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvfUserList = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Change = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nbfUserList = new System.Windows.Forms.NumericUpDown();
            this.btSavefUserList = new System.Windows.Forms.Button();
            this.btChangefUserList = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btAddfUserList = new System.Windows.Forms.Button();
            this.txtTypefUserList5 = new System.Windows.Forms.TextBox();
            this.txtPassfUserList5 = new System.Windows.Forms.TextBox();
            this.txtDisplayfUserList = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNamefUserList = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnfUserListHome = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvfUserList)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbfUserList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvfUserList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(124, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(573, 225);
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
            this.Delete,
            this.Change});
            this.dtgvfUserList.Location = new System.Drawing.Point(12, 17);
            this.dtgvfUserList.Name = "dtgvfUserList";
            this.dtgvfUserList.Size = new System.Drawing.Size(519, 171);
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
            // Change
            // 
            this.Change.HeaderText = "Sửa";
            this.Change.Name = "Change";
            this.Change.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Change.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Change.Width = 35;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nbfUserList);
            this.panel2.Controls.Add(this.btSavefUserList);
            this.panel2.Controls.Add(this.btChangefUserList);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btAddfUserList);
            this.panel2.Controls.Add(this.txtTypefUserList5);
            this.panel2.Controls.Add(this.txtPassfUserList5);
            this.panel2.Controls.Add(this.txtDisplayfUserList);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtNamefUserList);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(124, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 105);
            this.panel2.TabIndex = 7;
            // 
            // nbfUserList
            // 
            this.nbfUserList.Location = new System.Drawing.Point(507, 34);
            this.nbfUserList.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbfUserList.Name = "nbfUserList";
            this.nbfUserList.Size = new System.Drawing.Size(43, 20);
            this.nbfUserList.TabIndex = 3;
            // 
            // btSavefUserList
            // 
            this.btSavefUserList.Location = new System.Drawing.Point(234, 71);
            this.btSavefUserList.Name = "btSavefUserList";
            this.btSavefUserList.Size = new System.Drawing.Size(68, 31);
            this.btSavefUserList.TabIndex = 2;
            this.btSavefUserList.Text = "Lưu";
            this.btSavefUserList.UseVisualStyleBackColor = true;
            this.btSavefUserList.Click += new System.EventHandler(this.btSavefUserList_Click);
            // 
            // btChangefUserList
            // 
            this.btChangefUserList.Location = new System.Drawing.Point(160, 71);
            this.btChangefUserList.Name = "btChangefUserList";
            this.btChangefUserList.Size = new System.Drawing.Size(68, 31);
            this.btChangefUserList.TabIndex = 2;
            this.btChangefUserList.Text = "Sửa";
            this.btChangefUserList.UseVisualStyleBackColor = true;
            this.btChangefUserList.Click += new System.EventHandler(this.btChangefUserList_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "***";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btAddfUserList
            // 
            this.btAddfUserList.Location = new System.Drawing.Point(12, 71);
            this.btAddfUserList.Name = "btAddfUserList";
            this.btAddfUserList.Size = new System.Drawing.Size(68, 31);
            this.btAddfUserList.TabIndex = 2;
            this.btAddfUserList.Text = "Thêm";
            this.btAddfUserList.UseVisualStyleBackColor = true;
            this.btAddfUserList.Click += new System.EventHandler(this.btAddfUserList_Click);
            // 
            // txtTypefUserList5
            // 
            this.txtTypefUserList5.Location = new System.Drawing.Point(537, 71);
            this.txtTypefUserList5.Name = "txtTypefUserList5";
            this.txtTypefUserList5.Size = new System.Drawing.Size(22, 20);
            this.txtTypefUserList5.TabIndex = 1;
            this.txtTypefUserList5.Text = "0";
            // 
            // txtPassfUserList5
            // 
            this.txtPassfUserList5.Location = new System.Drawing.Point(340, 7);
            this.txtPassfUserList5.Name = "txtPassfUserList5";
            this.txtPassfUserList5.Size = new System.Drawing.Size(142, 20);
            this.txtPassfUserList5.TabIndex = 1;
            // 
            // txtDisplayfUserList
            // 
            this.txtDisplayfUserList.Location = new System.Drawing.Point(100, 33);
            this.txtDisplayfUserList.Name = "txtDisplayfUserList";
            this.txtDisplayfUserList.Size = new System.Drawing.Size(382, 20);
            this.txtDisplayfUserList.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(504, 10);
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
            this.label3.Size = new System.Drawing.Size(85, 23);
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 334);
            this.panel1.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnfUserListHome});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnfUserListHome
            // 
            this.mnfUserListHome.Name = "mnfUserListHome";
            this.mnfUserListHome.Size = new System.Drawing.Size(46, 20);
            this.mnfUserListHome.Text = "Home";
            this.mnfUserListHome.Click += new System.EventHandler(this.mnfUserListHome_Click);
            // 
            // fUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 358);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fUserList";
            this.Text = "fUserList";
            this.Load += new System.EventHandler(this.fUserList_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvfUserList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbfUserList)).EndInit();
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
        private System.Windows.Forms.Button btChangefUserList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btAddfUserList;
        private System.Windows.Forms.TextBox txtPassfUserList5;
        private System.Windows.Forms.TextBox txtDisplayfUserList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNamefUserList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Change;
        private System.Windows.Forms.TextBox txtTypefUserList5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nbfUserList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnfUserListHome;
    }
}