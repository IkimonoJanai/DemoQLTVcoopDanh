using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DemoQuanLyThuVien.DAO;

namespace DemoQuanLyThuVien
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        #region Property
        #endregion
        #region Method
        #endregion

        #region Events
        

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRentList_Click(object sender, EventArgs e)
        {
            fRentBookLogin fRBL = new fRentBookLogin();
            this.Hide();
            fRBL.ShowDialog();
            this.Show();
        }

        private void btBookList_Click(object sender, EventArgs e)
        {
            fBookList fBL = new fBookList();
            this.Hide();
            fBL.ShowDialog();
            this.Show();
        }

        private void btfUserList_Click(object sender, EventArgs e)
        {
            fUserList fUL = new fUserList();
            this.Hide();
            fUL.ShowDialog();
            this.Show();
        }

        #endregion





        // Data Reader
            // load account
            //string UserName, DisplayName, PassWord, Type;
            //string cnStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=DemoQuanLyThuVienAlpha;Integrated Security=True";
            //SqlConnection cn = new SqlConnection(cnStr);
            //cn.Open();
            //string sql = "SELECT * FROM Account";
            //SqlCommand cmd = new SqlCommand(sql, cn);
            //SqlDataReader dr = cmd.ExecuteReader();
            //List<Account> list = new List<Account>();
            //while (dr.Read())
            //{
            //    //Class Account
            //    UserName = dr[0].ToString();
            //    DisplayName = dr[1].ToString();
            //    PassWord = dr[2].ToString();
            //    Type = dr[3].ToString();
            //    Account acc = new Account(UserName, DisplayName, PassWord, Type);
            //    list.Add(acc);
            //}
            //dr.Close();
            //cn.Close();
            //dtgvBook.DataSource = list;


            /*
             * ********************* button ADD *********************************
             * 
             * 
             * 
             */
            //string cnStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=DemoQuanLyThuVienAlpha;Integrated Security=True";
            //SqlConnection cn = new SqlConnection(cnStr);
            //string id,ten, idCategory, price;
            //id = txtBookId.Text;
            //ten = txtBookName.Text;
            //idCategory = txtBookIdCategory.Text;
            //price = txtBookPrice.Text; //nmBookPrice.ToString();
            //if (string.IsNullOrEmpty(id))
            //    return;
            //string sql = "INSERT INTO Book VALUES('" + id + "',N'" + ten + "','" + idCategory + "','" + price + "')";
            //SqlCommand cmd = new SqlCommand(sql,cn);

            //cn.Open();
            //int number = cmd.ExecuteNonQuery();
            //if (number <= 0)
            //    MessageBox.Show("thêm thất bại!");
            //else
            //    MessageBox.Show("thêm thành công"); 
            //cn.Close();


            /*
             * ********************* button del *************************************
             * 
             * 
             * 
             * 
             */
            //string cnStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=DemoQuanLyThuVienAlpha;Integrated Security=True";
            //SqlConnection cn = new SqlConnection(cnStr);
            //string sql = "";
            //sql = "DELETE FROM DemoQuanLyThuVienAlpha WHERE ID('" + txtId.Text + "')";
            //SqlCommand cmd = new SqlCommand(sql, cn);
            //cmd.CommandText = sql;

            //cmd.ExecuteNonQuery();
            //cn.Close();
            //try
            //{
            //    txtId.Clear();
            //    txtName.Clear();
            //    //xóa id tên xóa cả list vừa thêm vào
            //}
            //catch { }
            //MessageBox.Show("Xóa thành công!!!!!!");



            /*
             * ********************* button update ****************************************
             * 
             * 
             * 
             */
            //string id, danhmuc, ten, gia;
            //id = txtId.Text;
            //ten = txtName.Text;
            //if (txtId.Text != "")
            //    {
            //        string cnStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=DemoQuanLyThuVienAlpha;Integrated Security=True";
            //        // Thay đổi dòng này khi vào máy mới
            //        SqlConnection cn = new SqlConnection(cnStr);
            //        string sql = "";
            //        sql = "UPDATE DemoQuanLyThuVienAlpha SET Id('" + id + "')";
            //        SqlCommand cmd = new SqlCommand(sql, cn);
            //        cmd.CommandText = sql;
            //        cmd.ExecuteNonQuery();
            //        MessageBox.Show("cập nhật thành công.");
            //        cn.Close();
            //    }
            //else
            //    {
            //        MessageBox.Show("cập nhật thất bại");
            //    }
        //}

    }
}
