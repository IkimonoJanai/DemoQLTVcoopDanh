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
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvBook = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtMssv = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btConfirmRent = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnReturnfRentBook = new System.Windows.Forms.ToolStripMenuItem();
            this.discountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpMãToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBook)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtgvBook);
            this.panel1.Location = new System.Drawing.Point(183, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 199);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(542, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh mục sách";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtgvBook
            // 
            this.dtgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.idCategory,
            this.releaseYear,
            this.nameAuthor,
            this.nameNXB,
            this.price});
            this.dtgvBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvBook.Location = new System.Drawing.Point(0, 29);
            this.dtgvBook.Name = "dtgvBook";
            this.dtgvBook.Size = new System.Drawing.Size(542, 170);
            this.dtgvBook.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "Mã";
            this.id.Name = "id";
            this.id.Width = 25;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Tên sách";
            this.name.Name = "name";
            // 
            // idCategory
            // 
            this.idCategory.HeaderText = "Mã sách";
            this.idCategory.Name = "idCategory";
            this.idCategory.Width = 50;
            // 
            // releaseYear
            // 
            this.releaseYear.HeaderText = "Năm sản xuất";
            this.releaseYear.Name = "releaseYear";
            this.releaseYear.Width = 45;
            // 
            // nameAuthor
            // 
            this.nameAuthor.HeaderText = "Tên tác giả";
            this.nameAuthor.Name = "nameAuthor";
            this.nameAuthor.Width = 70;
            // 
            // nameNXB
            // 
            this.nameNXB.HeaderText = "Nhà xuất bản";
            this.nameNXB.Name = "nameNXB";
            this.nameNXB.Width = 55;
            // 
            // price
            // 
            this.price.HeaderText = "Giá";
            this.price.Name = "price";
            this.price.Width = 55;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.treeView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 230);
            this.panel2.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 29);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(162, 201);
            this.treeView1.TabIndex = 2;
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
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(365, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 133);
            this.panel3.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(20, 29);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 58);
            this.dataGridView2.TabIndex = 1;
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
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.txtMssv);
            this.panel4.Controls.Add(this.txtUserName);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(12, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(346, 162);
            this.panel4.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // txtMssv
            // 
            this.txtMssv.Location = new System.Drawing.Point(107, 69);
            this.txtMssv.Name = "txtMssv";
            this.txtMssv.ReadOnly = true;
            this.txtMssv.Size = new System.Drawing.Size(139, 20);
            this.txtMssv.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(107, 36);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(200, 20);
            this.txtUserName.TabIndex = 2;
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(546, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 25);
            this.button3.TabIndex = 0;
            this.button3.Text = "Bỏ chọn";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnReturnfRentBook,
            this.discountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(738, 24);
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
            // fRentBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 442);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btConfirmRent);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fRentBook";
            this.Text = "fRentBook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fRentBook_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBook)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btConfirmRent;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgvBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnReturnfRentBook;
        private System.Windows.Forms.ToolStripMenuItem discountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpMãToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtMssv;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}