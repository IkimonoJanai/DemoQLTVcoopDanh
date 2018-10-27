using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DemoQuanLyThuVien
{
    public partial class fUserList : Form
    {
        SqlDataAdapter da;
        SqlConnection cn;
        DataTable UserListTable;
        public fUserList()
        {
            InitializeComponent();
            //LoadUserList();
            //string queryInsert = @"INSERT INTO Employees (firstname,lastname) VALUES ('Pete','Houston')";
            //string queryDelete = @"DELETE FROM Employees WHERE firstname = 'Pete' AND lastname = 'Houston'";
        }

        #region Events
        private void fUserList_Load(object sender, EventArgs e)
        {
            string cnStr = "Data Source=BEOSAMA-PC\\SQLEXPRESS;Initial Catalog=DemoQuanLyThuVienAlphaVer1_2;Integrated Security=True";
            cn = new SqlConnection(cnStr);

            DataSet ds = LoadUserList();
            UserListTable = ds.Tables[0];
            dtgvfUserList.DataSource = UserListTable;

        }

        private void btAddfUserList_Click(object sender, EventArgs e)
        {
            DataRow row = UserListTable.NewRow();
            row["UserName"] = txtNamefUserList.Text;
            row["DisplayName"] = txtDisplayfUserList.Text;
            row["PassWord"] = txtPassfUserList5.Text;
            row["Type"] = nbfUserList.Value;// dcm best vl

            UserListTable.Rows.Add(row);
        }


        private void btSavefUserList_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Update(UserListTable);
        }

        private void btChangefUserList_Click(object sender, EventArgs e)
        {
            //dcm no ko biet cu phap update
        }

        private void dtgvfUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataRow row = UserListTable.NewRow();

           // UserListTable.Rows(row)
            int col = e.ColumnIndex;
            if (dtgvfUserList.Columns[col] is DataGridViewButtonColumn && dtgvfUserList.Columns[col].Name == "Delete")
            {
                int row = e.RowIndex;
                //do
                //{
                    //UserListTable.Rows.RemoveAt(row);// cái này lỗi sml với ko lưu được
                    UserListTable.Rows[row].Delete();//cái này dùng như cứt
                //} while (row > 5);
            }
        }

        private void mnfUserListHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion



        #region Methods
        DataSet LoadUserList()
        {
            string sql = "SELECT * FROM Account";

            da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        }


        #endregion

        
    }
}
