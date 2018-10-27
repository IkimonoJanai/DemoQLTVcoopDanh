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
    public partial class fHomePage : Form
    {
        
        public fHomePage()
        {
            InitializeComponent();
        }

        private void btfHomePageAdmin_Click(object sender, EventArgs e)
        {
            //string username = "";
            //string password = "";
            //if (LoginUser(username, password))
            //{
            //    Main m = new Main();
            //    this.Hide();
            //    m.ShowDialog();
            //    this.Show();
            //}
            //else
            //{
            //    MessageBox.Show("","");
            //}
            //int type = txt
            //if(LoginById(int type))
            //{
            //}
        }

        private void btfHomePageUser_Click(object sender, EventArgs e)
        {

        }

        bool LoginById(int id )
        {

            return LoginById(id);

        }
    }
}
