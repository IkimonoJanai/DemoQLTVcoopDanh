using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DemoQuanLyThuVien.DAO;

namespace DemoQuanLyThuVien
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtName.Text = Properties.Settings.Default.UserName;
            txtPassword.Text = Properties.Settings.Default.PassWork;
        }
        #region Property
        #endregion
        #region Method
        #endregion
        
        
        #region Events

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {

            string userName = txtName.Text;
            string passWord = txtPassword.Text;

            if (Login(userName, passWord))
            {
                Account loginAccountUser = AccountDAO.Instance.LoginByUsername(userName);

                FormHome f = new FormHome(loginAccountUser);
                if (checkBox1.Checked)
                {
                    Properties.Settings.Default.UserName = txtName.Text;
                    Properties.Settings.Default.PassWork = txtPassword.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {

                    Properties.Settings.Default.UserName = txtName.Text;
                    Properties.Settings.Default.Save();
                }
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("sai tên hoặc mật khẩu , vui lòng thử lại");
            }
        }
        #endregion
        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }



        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }
    }
}
