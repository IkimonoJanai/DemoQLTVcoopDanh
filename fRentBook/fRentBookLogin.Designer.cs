namespace DemoQuanLyThuVien
{
    partial class fRentBookLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookLoginName = new System.Windows.Forms.TextBox();
            this.btRentBookLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookLoginPassword = new System.Windows.Forms.TextBox();
            this.btRentBookSignup = new System.Windows.Forms.Button();
            this.picBookBeosama = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBookBeosama)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV";
            // 
            // txtBookLoginName
            // 
            this.txtBookLoginName.Location = new System.Drawing.Point(96, 22);
            this.txtBookLoginName.Name = "txtBookLoginName";
            this.txtBookLoginName.Size = new System.Drawing.Size(171, 20);
            this.txtBookLoginName.TabIndex = 1;
            this.txtBookLoginName.Text = "1651010045";
            // 
            // btRentBookLogin
            // 
            this.btRentBookLogin.Location = new System.Drawing.Point(96, 88);
            this.btRentBookLogin.Name = "btRentBookLogin";
            this.btRentBookLogin.Size = new System.Drawing.Size(80, 26);
            this.btRentBookLogin.TabIndex = 2;
            this.btRentBookLogin.Text = "Đăng nhập";
            this.btRentBookLogin.UseVisualStyleBackColor = true;
            this.btRentBookLogin.Click += new System.EventHandler(this.btRentBookLogin_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // txtBookLoginPassword
            // 
            this.txtBookLoginPassword.Location = new System.Drawing.Point(96, 49);
            this.txtBookLoginPassword.Name = "txtBookLoginPassword";
            this.txtBookLoginPassword.Size = new System.Drawing.Size(171, 20);
            this.txtBookLoginPassword.TabIndex = 1;
            this.txtBookLoginPassword.Text = "1651010045";
            this.txtBookLoginPassword.UseSystemPasswordChar = true;
            // 
            // btRentBookSignup
            // 
            this.btRentBookSignup.Location = new System.Drawing.Point(187, 88);
            this.btRentBookSignup.Name = "btRentBookSignup";
            this.btRentBookSignup.Size = new System.Drawing.Size(80, 26);
            this.btRentBookSignup.TabIndex = 2;
            this.btRentBookSignup.Text = "Đăng ký";
            this.btRentBookSignup.UseVisualStyleBackColor = true;
            this.btRentBookSignup.Click += new System.EventHandler(this.btRentBookSignup_Click);
            // 
            // picBookBeosama
            // 
            this.picBookBeosama.Image = global::DemoQuanLyThuVien.Properties.Resources._37740358_265002680945844_5831663752210022400_n;
            this.picBookBeosama.Location = new System.Drawing.Point(7, 75);
            this.picBookBeosama.Name = "picBookBeosama";
            this.picBookBeosama.Size = new System.Drawing.Size(78, 62);
            this.picBookBeosama.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBookBeosama.TabIndex = 3;
            this.picBookBeosama.TabStop = false;
            // 
            // fRentBookLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 149);
            this.Controls.Add(this.picBookBeosama);
            this.Controls.Add(this.btRentBookSignup);
            this.Controls.Add(this.btRentBookLogin);
            this.Controls.Add(this.txtBookLoginPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBookLoginName);
            this.Controls.Add(this.label1);
            this.Name = "fRentBookLogin";
            this.Text = "fRentBookLogin";
            ((System.ComponentModel.ISupportInitialize)(this.picBookBeosama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookLoginName;
        private System.Windows.Forms.Button btRentBookLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookLoginPassword;
        private System.Windows.Forms.Button btRentBookSignup;
        private System.Windows.Forms.PictureBox picBookBeosama;
    }
}