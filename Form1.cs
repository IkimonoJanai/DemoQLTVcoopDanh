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
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Show();
            //this.Enabled = false;

            //Welcome frmWel = new Welcome();
            //DialogResult result = frmWel.ShowDialog();

            //if (result == DialogResult.OK)
            //{
            //    this.Enabled = true;
            //    lbWelcome.Text = "COHE SHOPPU NI YOUKOSOU";
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////string id, ncc, add;
            //string cnString = "SERVER = .; DATABASE = CoffeeShop; INTEGRATED SECURITY = true";
            //SqlConnection cn = new SqlConnection(cnString);
            //cn.Open();
            //// COUNT username trong database
            ////string sql = "SELECT COUNT(Id) FROM Id WHERE UserName = '" + user + "' AND Password = '" + pass + "'";
            ////string sql = "INSERT INTO Supplier VALUES = '"
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = cn;
            ////cmd.CommandText = sql;
            //cmd.CommandType = CommandType.Text;
            ////int row = cmd.ExecuteNonQuery();
            //int count = (int)cmd.ExecuteScalar();// lay gia tri

            //cn.Close();
            
        }

        private void lbWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
