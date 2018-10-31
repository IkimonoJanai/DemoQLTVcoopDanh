namespace DemoQuanLyThuVien
{
    partial class fRentBook
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvRentBook = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btDmsVH = new System.Windows.Forms.Button();
            this.btDmsManga = new System.Windows.Forms.Button();
            this.btDmsCNTT = new System.Windows.Forms.Button();
            this.btDmsDoujin = new System.Windows.Forms.Button();
            this.btDMSLN = new System.Windows.Forms.Button();
            this.btDMSAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvPickRentBook = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbfebMSSV = new System.Windows.Forms.Label();
            this.lbfrbName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btConfirmRent = new System.Windows.Forms.Button();
            this.btfRBDeselect = new System.Windows.Forms.Button();
            this.btThanThanh = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnReturnfRentBook = new System.Windows.Forms.ToolStripMenuItem();
            this.discountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpMãToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRentBook)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPickRentBook)).BeginInit();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtgvRentBook);
            this.panel1.Location = new System.Drawing.Point(183, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 203);
            this.panel1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(95, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(543, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh mục sách";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtgvRentBook
            // 
            this.dtgvRentBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRentBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.idCategory,
            this.releaseYear,
            this.nameAuthor,
            this.nameNXB,
            this.price});
            this.dtgvRentBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvRentBook.Location = new System.Drawing.Point(0, 33);
            this.dtgvRentBook.Name = "dtgvRentBook";
            this.dtgvRentBook.Size = new System.Drawing.Size(543, 170);
            this.dtgvRentBook.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã";
            this.id.Name = "id";
            this.id.Width = 25;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên sách";
            this.name.Name = "name";
            // 
            // idCategory
            // 
            this.idCategory.DataPropertyName = "idCategory";
            this.idCategory.HeaderText = "Mã sách";
            this.idCategory.Name = "idCategory";
            this.idCategory.Width = 50;
            // 
            // releaseYear
            // 
            this.releaseYear.DataPropertyName = "releaseYear";
            this.releaseYear.HeaderText = "Năm sản xuất";
            this.releaseYear.Name = "releaseYear";
            this.releaseYear.Width = 45;
            // 
            // nameAuthor
            // 
            this.nameAuthor.DataPropertyName = "nameAuthor";
            this.nameAuthor.HeaderText = "Tên tác giả";
            this.nameAuthor.Name = "nameAuthor";
            this.nameAuthor.Width = 70;
            // 
            // nameNXB
            // 
            this.nameNXB.DataPropertyName = "nameNXB";
            this.nameNXB.HeaderText = "Nhà xuất bản";
            this.nameNXB.Name = "nameNXB";
            this.nameNXB.Width = 55;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Giá";
            this.price.Name = "price";
            this.price.Width = 55;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btDmsVH);
            this.panel2.Controls.Add(this.btDmsManga);
            this.panel2.Controls.Add(this.btDmsCNTT);
            this.panel2.Controls.Add(this.btDmsDoujin);
            this.panel2.Controls.Add(this.btDMSLN);
            this.panel2.Controls.Add(this.btDMSAll);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 234);
            this.panel2.TabIndex = 0;
            // 
            // btDmsVH
            // 
            this.btDmsVH.BackColor = System.Drawing.Color.White;
            this.btDmsVH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDmsVH.Location = new System.Drawing.Point(3, 202);
            this.btDmsVH.Name = "btDmsVH";
            this.btDmsVH.Size = new System.Drawing.Size(159, 28);
            this.btDmsVH.TabIndex = 1;
            this.btDmsVH.Text = "Văn học";
            this.btDmsVH.UseVisualStyleBackColor = false;
            this.btDmsVH.Click += new System.EventHandler(this.btDmsVH_Click);
            // 
            // btDmsManga
            // 
            this.btDmsManga.BackColor = System.Drawing.Color.White;
            this.btDmsManga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDmsManga.Location = new System.Drawing.Point(3, 168);
            this.btDmsManga.Name = "btDmsManga";
            this.btDmsManga.Size = new System.Drawing.Size(159, 28);
            this.btDmsManga.TabIndex = 1;
            this.btDmsManga.Text = "manga";
            this.btDmsManga.UseVisualStyleBackColor = false;
            this.btDmsManga.Click += new System.EventHandler(this.btDmsManga_Click);
            // 
            // btDmsCNTT
            // 
            this.btDmsCNTT.BackColor = System.Drawing.Color.White;
            this.btDmsCNTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDmsCNTT.Location = new System.Drawing.Point(3, 134);
            this.btDmsCNTT.Name = "btDmsCNTT";
            this.btDmsCNTT.Size = new System.Drawing.Size(159, 28);
            this.btDmsCNTT.TabIndex = 1;
            this.btDmsCNTT.Text = "Công nghệ thông tin";
            this.btDmsCNTT.UseVisualStyleBackColor = false;
            this.btDmsCNTT.Click += new System.EventHandler(this.btDmsCNTT_Click);
            // 
            // btDmsDoujin
            // 
            this.btDmsDoujin.BackColor = System.Drawing.Color.White;
            this.btDmsDoujin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDmsDoujin.Location = new System.Drawing.Point(3, 100);
            this.btDmsDoujin.Name = "btDmsDoujin";
            this.btDmsDoujin.Size = new System.Drawing.Size(159, 28);
            this.btDmsDoujin.TabIndex = 1;
            this.btDmsDoujin.Text = "doujinshi";
            this.btDmsDoujin.UseVisualStyleBackColor = false;
            this.btDmsDoujin.Click += new System.EventHandler(this.btDmsDoujin_Click);
            // 
            // btDMSLN
            // 
            this.btDMSLN.BackColor = System.Drawing.Color.White;
            this.btDMSLN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDMSLN.Location = new System.Drawing.Point(3, 66);
            this.btDMSLN.Name = "btDMSLN";
            this.btDMSLN.Size = new System.Drawing.Size(159, 28);
            this.btDMSLN.TabIndex = 1;
            this.btDMSLN.Text = "light novel";
            this.btDMSLN.UseVisualStyleBackColor = false;
            this.btDMSLN.Click += new System.EventHandler(this.btDMSLN_Click);
            // 
            // btDMSAll
            // 
            this.btDMSAll.BackColor = System.Drawing.Color.White;
            this.btDMSAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDMSAll.Location = new System.Drawing.Point(3, 32);
            this.btDMSAll.Name = "btDMSAll";
            this.btDMSAll.Size = new System.Drawing.Size(159, 28);
            this.btDMSAll.TabIndex = 1;
            this.btDMSAll.Text = "All";
            this.btDMSAll.UseVisualStyleBackColor = false;
            this.btDMSAll.Click += new System.EventHandler(this.btDMSAll_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvPickRentBook);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(365, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 133);
            this.panel3.TabIndex = 0;
            // 
            // dtgvPickRentBook
            // 
            this.dtgvPickRentBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPickRentBook.Location = new System.Drawing.Point(5, 29);
            this.dtgvPickRentBook.Name = "dtgvPickRentBook";
            this.dtgvPickRentBook.Size = new System.Drawing.Size(356, 101);
            this.dtgvPickRentBook.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sách đã chọn";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbfebMSSV);
            this.panel4.Controls.Add(this.lbfrbName);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(12, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(346, 162);
            this.panel4.TabIndex = 0;
            // 
            // lbfebMSSV
            // 
            this.lbfebMSSV.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbfebMSSV.Location = new System.Drawing.Point(107, 69);
            this.lbfebMSSV.Name = "lbfebMSSV";
            this.lbfebMSSV.Size = new System.Drawing.Size(200, 20);
            this.lbfebMSSV.TabIndex = 3;
            // 
            // lbfrbName
            // 
            this.lbfrbName.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbfrbName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbfrbName.Location = new System.Drawing.Point(107, 33);
            this.lbfrbName.Name = "lbfrbName";
            this.lbfrbName.Size = new System.Drawing.Size(200, 22);
            this.lbfrbName.TabIndex = 3;
            this.lbfrbName.Click += new System.EventHandler(this.lbfrbName_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(107, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "label8";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày mượn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "MSSV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông tin của bạn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btConfirmRent
            // 
            this.btConfirmRent.Location = new System.Drawing.Point(398, 168);
            this.btConfirmRent.Name = "btConfirmRent";
            this.btConfirmRent.Size = new System.Drawing.Size(96, 25);
            this.btConfirmRent.TabIndex = 0;
            this.btConfirmRent.Text = "Hoàn tất mượn";
            this.btConfirmRent.UseVisualStyleBackColor = true;
            this.btConfirmRent.Click += new System.EventHandler(this.btConfirmRent_Click);
            // 
            // btfRBDeselect
            // 
            this.btfRBDeselect.Location = new System.Drawing.Point(546, 168);
            this.btfRBDeselect.Name = "btfRBDeselect";
            this.btfRBDeselect.Size = new System.Drawing.Size(96, 25);
            this.btfRBDeselect.TabIndex = 0;
            this.btfRBDeselect.Text = "Bỏ chọn";
            this.btfRBDeselect.UseVisualStyleBackColor = true;
            // 
            // btThanThanh
            // 
            this.btThanThanh.Location = new System.Drawing.Point(546, 405);
            this.btThanThanh.Name = "btThanThanh";
            this.btThanThanh.Size = new System.Drawing.Size(96, 25);
            this.btThanThanh.TabIndex = 0;
            this.btThanThanh.Text = "Thêm";
            this.btThanThanh.UseVisualStyleBackColor = true;
            this.btThanThanh.Click += new System.EventHandler(this.btThanThanh_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnReturnfRentBook,
            this.discountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnReturnfRentBook
            // 
            this.mnReturnfRentBook.Name = "mnReturnfRentBook";
            this.mnReturnfRentBook.Size = new System.Drawing.Size(46, 20);
            this.mnReturnfRentBook.Text = "Home";
            this.mnReturnfRentBook.Click += new System.EventHandler(this.mnReturnfRentBook_Click);
            // 
            // discountToolStripMenuItem
            // 
            this.discountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpMãToolStripMenuItem});
            this.discountToolStripMenuItem.Name = "discountToolStripMenuItem";
            this.discountToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.discountToolStripMenuItem.Text = "Discount";
            // 
            // nhậpMãToolStripMenuItem
            // 
            this.nhậpMãToolStripMenuItem.Name = "nhậpMãToolStripMenuItem";
            this.nhậpMãToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.nhậpMãToolStripMenuItem.Text = "Nhập mã";
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(14, 10);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(171, 372);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.listView1);
            this.panel5.Location = new System.Drawing.Point(732, 29);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(197, 401);
            this.panel5.TabIndex = 3;
            // 
            // fRentBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 442);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btThanThanh);
            this.Controls.Add(this.btfRBDeselect);
            this.Controls.Add(this.btConfirmRent);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fRentBook";
            this.Text = "fRentBook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fRentBook_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRentBook)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPickRentBook)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btConfirmRent;
        private System.Windows.Forms.Button btfRBDeselect;
        private System.Windows.Forms.Button btThanThanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgvRentBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnReturnfRentBook;
        private System.Windows.Forms.ToolStripMenuItem discountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpMãToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbfebMSSV;
        private System.Windows.Forms.Label lbfrbName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button btDmsVH;
        private System.Windows.Forms.Button btDmsManga;
        private System.Windows.Forms.Button btDmsCNTT;
        private System.Windows.Forms.Button btDmsDoujin;
        private System.Windows.Forms.Button btDMSLN;
        private System.Windows.Forms.Button btDMSAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvPickRentBook;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel5;
    }
}