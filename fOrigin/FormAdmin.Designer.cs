namespace DemoQuanLyThuVien
{
    partial class FormAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.panel9 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.MenuSlide = new System.Windows.Forms.Timer(this.components);
            this.picRun = new System.Windows.Forms.Timer(this.components);
            this.picAdminScroll = new System.Windows.Forms.PictureBox();
            this.pnGiaLaiNameAndMssv = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.lbAdminName = new System.Windows.Forms.Label();
            this.lbAdminMssv = new System.Windows.Forms.Label();
            this.picBanhRang = new System.Windows.Forms.PictureBox();
            this.pnGiaLaiMenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.drawHinhThoi8 = new DemoQuanLyThuVien.DrawHinhThoi();
            this.drawHinhThoi7 = new DemoQuanLyThuVien.DrawHinhThoi();
            this.drawHinhThoi6 = new DemoQuanLyThuVien.DrawHinhThoi();
            this.drawHinhThoi5 = new DemoQuanLyThuVien.DrawHinhThoi();
            this.drawHinhThoi4 = new DemoQuanLyThuVien.DrawHinhThoi();
            this.drawHinhThoi3 = new DemoQuanLyThuVien.DrawHinhThoi();
            this.buttonAdminShowList4 = new DemoQuanLyThuVien.ButtonAdminShowList();
            this.drawHinhThoi1 = new DemoQuanLyThuVien.DrawHinhThoi();
            this.buttonAdminShowList3 = new DemoQuanLyThuVien.ButtonAdminShowList();
            this.drawHinhThoi2 = new DemoQuanLyThuVien.DrawHinhThoi();
            this.buttonAdminShowList2 = new DemoQuanLyThuVien.ButtonAdminShowList();
            this.buttonAdminShowList1 = new DemoQuanLyThuVien.ButtonAdminShowList();
            this.banhRang = new System.Windows.Forms.Timer(this.components);
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdminScroll)).BeginInit();
            this.pnGiaLaiNameAndMssv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanhRang)).BeginInit();
            this.pnGiaLaiMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel9.Controls.Add(this.button3);
            this.panel9.Controls.Add(this.button12);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(794, 48);
            this.panel9.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.Location = new System.Drawing.Point(5, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 42);
            this.button3.TabIndex = 0;
            this.button3.Text = "Quay lại";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button12.Location = new System.Drawing.Point(687, 7);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(95, 35);
            this.button12.TabIndex = 0;
            this.button12.Text = "Chợ đen";
            this.button12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // MenuSlide
            // 
            this.MenuSlide.Interval = 30;
            this.MenuSlide.Tick += new System.EventHandler(this.MenuSlide_Tick);
            // 
            // picRun
            // 
            this.picRun.Enabled = true;
            this.picRun.Interval = 3000;
            this.picRun.Tick += new System.EventHandler(this.picRun_Tick);
            // 
            // picAdminScroll
            // 
            this.picAdminScroll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picAdminScroll.Image = global::DemoQuanLyThuVien.Properties.Resources._11;
            this.picAdminScroll.Location = new System.Drawing.Point(467, 6);
            this.picAdminScroll.Name = "picAdminScroll";
            this.picAdminScroll.Size = new System.Drawing.Size(190, 92);
            this.picAdminScroll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdminScroll.TabIndex = 12;
            this.picAdminScroll.TabStop = false;
            // 
            // pnGiaLaiNameAndMssv
            // 
            this.pnGiaLaiNameAndMssv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.pnGiaLaiNameAndMssv.Controls.Add(this.picBanhRang);
            this.pnGiaLaiNameAndMssv.Controls.Add(this.lbAdminMssv);
            this.pnGiaLaiNameAndMssv.Controls.Add(this.lbAdminName);
            this.pnGiaLaiNameAndMssv.Controls.Add(this.button11);
            this.pnGiaLaiNameAndMssv.Controls.Add(this.button9);
            this.pnGiaLaiNameAndMssv.Location = new System.Drawing.Point(148, 316);
            this.pnGiaLaiNameAndMssv.Name = "pnGiaLaiNameAndMssv";
            this.pnGiaLaiNameAndMssv.Size = new System.Drawing.Size(237, 63);
            this.pnGiaLaiNameAndMssv.TabIndex = 8;
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::DemoQuanLyThuVien.Properties.Resources.btAdd;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.Location = new System.Drawing.Point(163, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(26, 22);
            this.button9.TabIndex = 0;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.BackgroundImage = global::DemoQuanLyThuVien.Properties.Resources.btPicMssv;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.Location = new System.Drawing.Point(146, 28);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(26, 22);
            this.button11.TabIndex = 0;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // lbAdminName
            // 
            this.lbAdminName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAdminName.Location = new System.Drawing.Point(3, 5);
            this.lbAdminName.Name = "lbAdminName";
            this.lbAdminName.Size = new System.Drawing.Size(154, 23);
            this.lbAdminName.TabIndex = 9;
            this.lbAdminName.Text = "Nguyễn Minh Đức";
            // 
            // lbAdminMssv
            // 
            this.lbAdminMssv.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAdminMssv.Location = new System.Drawing.Point(2, 29);
            this.lbAdminMssv.Name = "lbAdminMssv";
            this.lbAdminMssv.Size = new System.Drawing.Size(138, 23);
            this.lbAdminMssv.TabIndex = 10;
            this.lbAdminMssv.Text = "1651010045";
            // 
            // picBanhRang
            // 
            this.picBanhRang.BackgroundImage = global::DemoQuanLyThuVien.Properties.Resources.bg_btn_setting_material_normal1;
            this.picBanhRang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBanhRang.Location = new System.Drawing.Point(195, 26);
            this.picBanhRang.Name = "picBanhRang";
            this.picBanhRang.Size = new System.Drawing.Size(35, 35);
            this.picBanhRang.TabIndex = 11;
            this.picBanhRang.TabStop = false;
            this.picBanhRang.Click += new System.EventHandler(this.picBanhRang_Click);
            // 
            // pnGiaLaiMenu
            // 
            this.pnGiaLaiMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(186)))), ((int)(((byte)(235)))));
            this.pnGiaLaiMenu.Controls.Add(this.drawHinhThoi8);
            this.pnGiaLaiMenu.Controls.Add(this.drawHinhThoi7);
            this.pnGiaLaiMenu.Controls.Add(this.drawHinhThoi6);
            this.pnGiaLaiMenu.Controls.Add(this.drawHinhThoi5);
            this.pnGiaLaiMenu.Controls.Add(this.drawHinhThoi4);
            this.pnGiaLaiMenu.Controls.Add(this.drawHinhThoi3);
            this.pnGiaLaiMenu.Controls.Add(this.button2);
            this.pnGiaLaiMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnGiaLaiMenu.Location = new System.Drawing.Point(0, 419);
            this.pnGiaLaiMenu.Name = "pnGiaLaiMenu";
            this.pnGiaLaiMenu.Size = new System.Drawing.Size(794, 10);
            this.pnGiaLaiMenu.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 10);
            this.button2.TabIndex = 0;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::DemoQuanLyThuVien.Properties.Resources.book_ends_311495;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnGiaLaiMenu);
            this.panel1.Controls.Add(this.buttonAdminShowList4);
            this.panel1.Controls.Add(this.drawHinhThoi1);
            this.panel1.Controls.Add(this.buttonAdminShowList3);
            this.panel1.Controls.Add(this.drawHinhThoi2);
            this.panel1.Controls.Add(this.buttonAdminShowList2);
            this.panel1.Controls.Add(this.pnGiaLaiNameAndMssv);
            this.panel1.Controls.Add(this.buttonAdminShowList1);
            this.panel1.Controls.Add(this.picAdminScroll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 429);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 384);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 35);
            this.panel2.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(186)))), ((int)(((byte)(235)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(186)))), ((int)(((byte)(235)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(699, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Menu";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // drawHinhThoi8
            // 
            this.drawHinhThoi8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(218)))));
            this.drawHinhThoi8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawHinhThoi8.ForeColor = System.Drawing.Color.Black;
            this.drawHinhThoi8.Image = global::DemoQuanLyThuVien.Properties.Resources.setting_youtube;
            this.drawHinhThoi8.Location = new System.Drawing.Point(666, 4);
            this.drawHinhThoi8.Name = "drawHinhThoi8";
            this.drawHinhThoi8.Size = new System.Drawing.Size(106, 106);
            this.drawHinhThoi8.TabIndex = 1;
            this.drawHinhThoi8.Text = "YT";
            this.drawHinhThoi8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drawHinhThoi8.UseVisualStyleBackColor = false;
            // 
            // drawHinhThoi7
            // 
            this.drawHinhThoi7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(156)))), ((int)(((byte)(37)))));
            this.drawHinhThoi7.BackgroundImage = global::DemoQuanLyThuVien.Properties.Resources.bg_btn_add_sticker_draw_picture_normal1;
            this.drawHinhThoi7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.drawHinhThoi7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawHinhThoi7.ForeColor = System.Drawing.Color.Black;
            this.drawHinhThoi7.Location = new System.Drawing.Point(537, 3);
            this.drawHinhThoi7.Name = "drawHinhThoi7";
            this.drawHinhThoi7.Size = new System.Drawing.Size(106, 106);
            this.drawHinhThoi7.TabIndex = 1;
            this.drawHinhThoi7.Text = "YT";
            this.drawHinhThoi7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drawHinhThoi7.UseVisualStyleBackColor = false;
            // 
            // drawHinhThoi6
            // 
            this.drawHinhThoi6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(218)))));
            this.drawHinhThoi6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawHinhThoi6.ForeColor = System.Drawing.Color.Black;
            this.drawHinhThoi6.Image = global::DemoQuanLyThuVien.Properties.Resources.bt_clip_rotate;
            this.drawHinhThoi6.Location = new System.Drawing.Point(408, 7);
            this.drawHinhThoi6.Name = "drawHinhThoi6";
            this.drawHinhThoi6.Size = new System.Drawing.Size(106, 106);
            this.drawHinhThoi6.TabIndex = 1;
            this.drawHinhThoi6.Text = "YT";
            this.drawHinhThoi6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drawHinhThoi6.UseVisualStyleBackColor = false;
            // 
            // drawHinhThoi5
            // 
            this.drawHinhThoi5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(218)))));
            this.drawHinhThoi5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawHinhThoi5.ForeColor = System.Drawing.Color.Black;
            this.drawHinhThoi5.Image = global::DemoQuanLyThuVien.Properties.Resources.bg_btn_setting_material_normal;
            this.drawHinhThoi5.Location = new System.Drawing.Point(279, 6);
            this.drawHinhThoi5.Name = "drawHinhThoi5";
            this.drawHinhThoi5.Size = new System.Drawing.Size(106, 106);
            this.drawHinhThoi5.TabIndex = 1;
            this.drawHinhThoi5.Text = "YT";
            this.drawHinhThoi5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drawHinhThoi5.UseVisualStyleBackColor = false;
            // 
            // drawHinhThoi4
            // 
            this.drawHinhThoi4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(214)))), ((int)(((byte)(218)))));
            this.drawHinhThoi4.BackgroundImage = global::DemoQuanLyThuVien.Properties.Resources.bg_duration_selection;
            this.drawHinhThoi4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.drawHinhThoi4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawHinhThoi4.ForeColor = System.Drawing.Color.Black;
            this.drawHinhThoi4.Location = new System.Drawing.Point(150, 4);
            this.drawHinhThoi4.Name = "drawHinhThoi4";
            this.drawHinhThoi4.Size = new System.Drawing.Size(106, 106);
            this.drawHinhThoi4.TabIndex = 1;
            this.drawHinhThoi4.Text = "YT";
            this.drawHinhThoi4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drawHinhThoi4.UseVisualStyleBackColor = false;
            // 
            // drawHinhThoi3
            // 
            this.drawHinhThoi3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(12)))), ((int)(((byte)(24)))));
            this.drawHinhThoi3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawHinhThoi3.ForeColor = System.Drawing.Color.Black;
            this.drawHinhThoi3.Image = global::DemoQuanLyThuVien.Properties.Resources.setting_youtube;
            this.drawHinhThoi3.Location = new System.Drawing.Point(21, 3);
            this.drawHinhThoi3.Name = "drawHinhThoi3";
            this.drawHinhThoi3.Size = new System.Drawing.Size(106, 106);
            this.drawHinhThoi3.TabIndex = 1;
            this.drawHinhThoi3.Text = "YT";
            this.drawHinhThoi3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drawHinhThoi3.UseVisualStyleBackColor = false;
            // 
            // buttonAdminShowList4
            // 
            this.buttonAdminShowList4.asd = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonAdminShowList4.asd2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonAdminShowList4.asd3 = System.Drawing.Color.White;
            this.buttonAdminShowList4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAdminShowList4.button = "Danh sách ABCXYZ";
            this.buttonAdminShowList4.buttonAdmin1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAdminShowList4.img = ((System.Drawing.Image)(resources.GetObject("buttonAdminShowList4.img")));
            this.buttonAdminShowList4.Location = new System.Drawing.Point(467, 302);
            this.buttonAdminShowList4.Name = "buttonAdminShowList4";
            this.buttonAdminShowList4.Size = new System.Drawing.Size(308, 60);
            this.buttonAdminShowList4.TabIndex = 11;
            // 
            // drawHinhThoi1
            // 
            this.drawHinhThoi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.drawHinhThoi1.BackgroundImage = global::DemoQuanLyThuVien.Properties.Resources.Saintquartz;
            this.drawHinhThoi1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.drawHinhThoi1.Location = new System.Drawing.Point(7, 236);
            this.drawHinhThoi1.Name = "drawHinhThoi1";
            this.drawHinhThoi1.Size = new System.Drawing.Size(142, 142);
            this.drawHinhThoi1.TabIndex = 9;
            this.drawHinhThoi1.UseVisualStyleBackColor = false;
            // 
            // buttonAdminShowList3
            // 
            this.buttonAdminShowList3.asd = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonAdminShowList3.asd2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonAdminShowList3.asd3 = System.Drawing.Color.White;
            this.buttonAdminShowList3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAdminShowList3.button = "Danh sách Sách";
            this.buttonAdminShowList3.buttonAdmin1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAdminShowList3.img = ((System.Drawing.Image)(resources.GetObject("buttonAdminShowList3.img")));
            this.buttonAdminShowList3.Location = new System.Drawing.Point(467, 236);
            this.buttonAdminShowList3.Name = "buttonAdminShowList3";
            this.buttonAdminShowList3.Size = new System.Drawing.Size(308, 60);
            this.buttonAdminShowList3.TabIndex = 11;
            this.buttonAdminShowList3.Click += new System.EventHandler(this.buttonAdminShowList3_Click);
            // 
            // drawHinhThoi2
            // 
            this.drawHinhThoi2.BackColor = System.Drawing.Color.Black;
            this.drawHinhThoi2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.drawHinhThoi2.FlatAppearance.BorderSize = 0;
            this.drawHinhThoi2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drawHinhThoi2.Location = new System.Drawing.Point(3, 232);
            this.drawHinhThoi2.Name = "drawHinhThoi2";
            this.drawHinhThoi2.Size = new System.Drawing.Size(150, 150);
            this.drawHinhThoi2.TabIndex = 10;
            this.drawHinhThoi2.Text = "drawHinhThoi2";
            this.drawHinhThoi2.UseVisualStyleBackColor = false;
            // 
            // buttonAdminShowList2
            // 
            this.buttonAdminShowList2.asd = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonAdminShowList2.asd2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonAdminShowList2.asd3 = System.Drawing.Color.White;
            this.buttonAdminShowList2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAdminShowList2.button = "Danh sách NV";
            this.buttonAdminShowList2.buttonAdmin1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAdminShowList2.img = ((System.Drawing.Image)(resources.GetObject("buttonAdminShowList2.img")));
            this.buttonAdminShowList2.Location = new System.Drawing.Point(467, 170);
            this.buttonAdminShowList2.Name = "buttonAdminShowList2";
            this.buttonAdminShowList2.Size = new System.Drawing.Size(307, 60);
            this.buttonAdminShowList2.TabIndex = 11;
            this.buttonAdminShowList2.Click += new System.EventHandler(this.buttonAdminShowList2_Click);
            // 
            // buttonAdminShowList1
            // 
            this.buttonAdminShowList1.asd = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonAdminShowList1.asd2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonAdminShowList1.asd3 = System.Drawing.Color.White;
            this.buttonAdminShowList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAdminShowList1.button = "Danh sách thuê";
            this.buttonAdminShowList1.buttonAdmin1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAdminShowList1.img = ((System.Drawing.Image)(resources.GetObject("buttonAdminShowList1.img")));
            this.buttonAdminShowList1.Location = new System.Drawing.Point(467, 104);
            this.buttonAdminShowList1.Name = "buttonAdminShowList1";
            this.buttonAdminShowList1.Size = new System.Drawing.Size(308, 60);
            this.buttonAdminShowList1.TabIndex = 11;
            this.buttonAdminShowList1.Click += new System.EventHandler(this.buttonAdminShowList1_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gia Lai\'s Hause";
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAdminScroll)).EndInit();
            this.pnGiaLaiNameAndMssv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBanhRang)).EndInit();
            this.pnGiaLaiMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Timer MenuSlide;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer picRun;
        private System.Windows.Forms.PictureBox picAdminScroll;
        private ButtonAdminShowList buttonAdminShowList1;
        private System.Windows.Forms.Panel pnGiaLaiNameAndMssv;
        private System.Windows.Forms.PictureBox picBanhRang;
        private System.Windows.Forms.Label lbAdminMssv;
        private System.Windows.Forms.Label lbAdminName;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
        private ButtonAdminShowList buttonAdminShowList2;
        private DrawHinhThoi drawHinhThoi2;
        private ButtonAdminShowList buttonAdminShowList3;
        private DrawHinhThoi drawHinhThoi1;
        private ButtonAdminShowList buttonAdminShowList4;
        private System.Windows.Forms.Panel pnGiaLaiMenu;
        private DrawHinhThoi drawHinhThoi8;
        private DrawHinhThoi drawHinhThoi7;
        private DrawHinhThoi drawHinhThoi6;
        private DrawHinhThoi drawHinhThoi5;
        private DrawHinhThoi drawHinhThoi4;
        private DrawHinhThoi drawHinhThoi3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer banhRang;
    }
}