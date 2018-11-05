namespace DemoQuanLyThuVien
{
    partial class fBookList
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
            this.dtgvfBookList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.nbfBookListPrice = new System.Windows.Forms.NumericUpDown();
            this.txtBookListAuthor = new System.Windows.Forms.TextBox();
            this.cbBookListIdCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btfBookListDelete = new System.Windows.Forms.Button();
            this.txtBookListName = new System.Windows.Forms.TextBox();
            this.btfBookListChange = new System.Windows.Forms.Button();
            this.btfBookListRefresh = new System.Windows.Forms.Button();
            this.btfBookListAdd = new System.Windows.Forms.Button();
            this.txtBookListNameNXB = new System.Windows.Forms.TextBox();
            this.txtBookListYear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBookListId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnfRentList = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvfBookList)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbfBookListPrice)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvfBookList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(124, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(686, 264);
            this.panel3.TabIndex = 3;
            // 
            // dtgvfBookList
            // 
            this.dtgvfBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvfBookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.idCategory,
            this.releaseYear,
            this.nameAuthor,
            this.nameNXB,
            this.price});
            this.dtgvfBookList.Location = new System.Drawing.Point(3, 20);
            this.dtgvfBookList.Name = "dtgvfBookList";
            this.dtgvfBookList.Size = new System.Drawing.Size(680, 244);
            this.dtgvfBookList.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã";
            this.id.Name = "id";
            this.id.Width = 30;
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
            this.idCategory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idCategory.Width = 30;
            // 
            // releaseYear
            // 
            this.releaseYear.DataPropertyName = "releaseYear";
            this.releaseYear.HeaderText = "Năm SX";
            this.releaseYear.Name = "releaseYear";
            this.releaseYear.Width = 40;
            // 
            // nameAuthor
            // 
            this.nameAuthor.DataPropertyName = "nameAuthor";
            this.nameAuthor.HeaderText = "Tên tác giả";
            this.nameAuthor.Name = "nameAuthor";
            this.nameAuthor.Width = 110;
            // 
            // nameNXB
            // 
            this.nameNXB.DataPropertyName = "nameNXB";
            this.nameNXB.HeaderText = "Tên NXB";
            this.nameNXB.Name = "nameNXB";
            this.nameNXB.Width = 80;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Giá";
            this.price.Name = "price";
            this.price.Width = 65;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.nbfBookListPrice);
            this.panel2.Controls.Add(this.txtBookListAuthor);
            this.panel2.Controls.Add(this.cbBookListIdCategory);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btfBookListDelete);
            this.panel2.Controls.Add(this.txtBookListName);
            this.panel2.Controls.Add(this.btfBookListChange);
            this.panel2.Controls.Add(this.btfBookListRefresh);
            this.panel2.Controls.Add(this.btfBookListAdd);
            this.panel2.Controls.Add(this.txtBookListNameNXB);
            this.panel2.Controls.Add(this.txtBookListYear);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtBookListId);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(124, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 105);
            this.panel2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(346, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tác giả ";
            // 
            // nbfBookListPrice
            // 
            this.nbfBookListPrice.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nbfBookListPrice.Location = new System.Drawing.Point(410, 62);
            this.nbfBookListPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nbfBookListPrice.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.nbfBookListPrice.Name = "nbfBookListPrice";
            this.nbfBookListPrice.Size = new System.Drawing.Size(264, 20);
            this.nbfBookListPrice.TabIndex = 4;
            // 
            // txtBookListAuthor
            // 
            this.txtBookListAuthor.Location = new System.Drawing.Point(410, 36);
            this.txtBookListAuthor.Name = "txtBookListAuthor";
            this.txtBookListAuthor.Size = new System.Drawing.Size(264, 20);
            this.txtBookListAuthor.TabIndex = 1;
            // 
            // cbBookListIdCategory
            // 
            this.cbBookListIdCategory.FormattingEnabled = true;
            this.cbBookListIdCategory.Location = new System.Drawing.Point(174, 7);
            this.cbBookListIdCategory.Name = "cbBookListIdCategory";
            this.cbBookListIdCategory.Size = new System.Drawing.Size(160, 21);
            this.cbBookListIdCategory.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(346, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên sách";
            // 
            // btfBookListDelete
            // 
            this.btfBookListDelete.Location = new System.Drawing.Point(234, 71);
            this.btfBookListDelete.Name = "btfBookListDelete";
            this.btfBookListDelete.Size = new System.Drawing.Size(68, 31);
            this.btfBookListDelete.TabIndex = 2;
            this.btfBookListDelete.Text = "Xóa";
            this.btfBookListDelete.UseVisualStyleBackColor = true;
            this.btfBookListDelete.Click += new System.EventHandler(this.btfBookListDelete_Click);
            // 
            // txtBookListName
            // 
            this.txtBookListName.Location = new System.Drawing.Point(410, 7);
            this.txtBookListName.Name = "txtBookListName";
            this.txtBookListName.Size = new System.Drawing.Size(264, 20);
            this.txtBookListName.TabIndex = 1;
            // 
            // btfBookListChange
            // 
            this.btfBookListChange.Location = new System.Drawing.Point(160, 71);
            this.btfBookListChange.Name = "btfBookListChange";
            this.btfBookListChange.Size = new System.Drawing.Size(68, 31);
            this.btfBookListChange.TabIndex = 2;
            this.btfBookListChange.Text = "Sửa";
            this.btfBookListChange.UseVisualStyleBackColor = true;
            this.btfBookListChange.Click += new System.EventHandler(this.btfBookListChange_Click);
            // 
            // btfBookListRefresh
            // 
            this.btfBookListRefresh.BackColor = System.Drawing.Color.White;
            this.btfBookListRefresh.BackgroundImage = global::DemoQuanLyThuVien.Properties.Resources.bt_clip_rotate;
            this.btfBookListRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btfBookListRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btfBookListRefresh.Location = new System.Drawing.Point(86, 71);
            this.btfBookListRefresh.Name = "btfBookListRefresh";
            this.btfBookListRefresh.Size = new System.Drawing.Size(68, 31);
            this.btfBookListRefresh.TabIndex = 2;
            this.btfBookListRefresh.UseVisualStyleBackColor = false;
            this.btfBookListRefresh.Click += new System.EventHandler(this.btfBookListRefresh_Click);
            // 
            // btfBookListAdd
            // 
            this.btfBookListAdd.Location = new System.Drawing.Point(12, 71);
            this.btfBookListAdd.Name = "btfBookListAdd";
            this.btfBookListAdd.Size = new System.Drawing.Size(68, 31);
            this.btfBookListAdd.TabIndex = 2;
            this.btfBookListAdd.Text = "Thêm";
            this.btfBookListAdd.UseVisualStyleBackColor = true;
            this.btfBookListAdd.Click += new System.EventHandler(this.btfBookListAdd_Click);
            // 
            // txtBookListNameNXB
            // 
            this.txtBookListNameNXB.Location = new System.Drawing.Point(234, 33);
            this.txtBookListNameNXB.Name = "txtBookListNameNXB";
            this.txtBookListNameNXB.Size = new System.Drawing.Size(100, 20);
            this.txtBookListNameNXB.TabIndex = 1;
            // 
            // txtBookListYear
            // 
            this.txtBookListYear.Location = new System.Drawing.Point(54, 36);
            this.txtBookListYear.Name = "txtBookListYear";
            this.txtBookListYear.Size = new System.Drawing.Size(100, 20);
            this.txtBookListYear.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(347, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giá";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(171, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên NXB";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(115, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "mã sách";
            // 
            // txtBookListId
            // 
            this.txtBookListId.Location = new System.Drawing.Point(54, 10);
            this.txtBookListId.Name = "txtBookListId";
            this.txtBookListId.ReadOnly = true;
            this.txtBookListId.Size = new System.Drawing.Size(55, 20);
            this.txtBookListId.TabIndex = 1;
            this.txtBookListId.TextChanged += new System.EventHandler(this.txtBookListId_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Năm SX";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 372);
            this.panel1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnfRentList});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnfRentList
            // 
            this.mnfRentList.Name = "mnfRentList";
            this.mnfRentList.Size = new System.Drawing.Size(52, 20);
            this.mnfRentList.Text = "Home";
            // 
            // fBookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 396);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "fBookList";
            this.Text = "fBookList";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvfBookList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbfBookListPrice)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvfBookList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnfRentList;
        private System.Windows.Forms.Button btfBookListDelete;
        private System.Windows.Forms.Button btfBookListChange;
        private System.Windows.Forms.Button btfBookListRefresh;
        private System.Windows.Forms.Button btfBookListAdd;
        private System.Windows.Forms.TextBox txtBookListNameNXB;
        private System.Windows.Forms.TextBox txtBookListAuthor;
        private System.Windows.Forms.TextBox txtBookListYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBookListName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBookListId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBookListIdCategory;
        private System.Windows.Forms.NumericUpDown nbfBookListPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}