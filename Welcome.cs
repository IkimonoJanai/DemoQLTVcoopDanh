using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DemoFormLog
{
    public partial class Welcome : Form
    {
        
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, pass;
            Welcome frmWelcome = new Welcome();

            user = txtName.Text;
            pass = txtPass.Text;
            //rong


            //Dung
            //if (txtName.Text == "admin" && txtPass.Text == "111")
            if(Login_Func(user , pass) == true)
            {
                MessageBox.Show("Log in success");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            //sai

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        bool Login_Func (string user ,string pass)
        {
            string cnString = "SERVER = .; DATABASE = CoffeeShop; INTEGRATED SECURITY = true";
            SqlConnection cn = new SqlConnection(cnString);
            cn.Open();
            // COUNT username trong database
            string sql = "SELECT COUNT(UserName) FROM Users WHERE UserName = '" + user + "' AND Password = '" + pass + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn; 
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            int count = (int)cmd.ExecuteScalar();// lay gia tri

            cn.Close();
            if (count >= 1)
                return true;
            else
                return false;
        }
    }
}
