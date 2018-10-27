namespace DemoQuanLyThuVien
{
    partial class fHomePage
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
            this.btfHomePageUser = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btfHomePageAdmin = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btfHomePageUser
            // 
            this.btfHomePageUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btfHomePageUser.Location = new System.Drawing.Point(96, 102);
            this.btfHomePageUser.Name = "btfHomePageUser";
            this.btfHomePageUser.Size = new System.Drawing.Size(150, 150);
            this.btfHomePageUser.TabIndex = 0;
            this.btfHomePageUser.Text = "Real business";
            this.btfHomePageUser.UseVisualStyleBackColor = true;
            this.btfHomePageUser.Click += new System.EventHandler(this.btfHomePageUser_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::DemoQuanLyThuVien.Properties.Resources._41166776_281680885985415_7738645376416088064_n;
            this.panel2.Controls.Add(this.btfHomePageUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(361, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 404);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DemoQuanLyThuVien.Properties.Resources._41188570_281680922652078_5144838339152576512_n;
            this.panel1.Controls.Add(this.btfHomePageAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 404);
            this.panel1.TabIndex = 1;
            // 
            // btfHomePageAdmin
            // 
            this.btfHomePageAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btfHomePageAdmin.Location = new System.Drawing.Point(100, 102);
            this.btfHomePageAdmin.Name = "btfHomePageAdmin";
            this.btfHomePageAdmin.Size = new System.Drawing.Size(150, 150);
            this.btfHomePageAdmin.TabIndex = 0;
            this.btfHomePageAdmin.Text = "Fun Hause";
            this.btfHomePageAdmin.UseVisualStyleBackColor = true;
            this.btfHomePageAdmin.Click += new System.EventHandler(this.btfHomePageAdmin_Click);
            // 
            // fHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 404);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fHomePage";
            this.Text = "fHomePage";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btfHomePageUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btfHomePageAdmin;
        private System.Windows.Forms.Panel panel2;
    }
}