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
        // error : display combobox type to name
        BindingSource dataBindUserlist = new BindingSource();
        SqlDataAdapter da;
        SqlConnection cn;
        DataTable UserListTable;
        DataRow row;
        public fUserList()
        {
            InitializeComponent();

        }

        #region Events
        private void fUserList_Load(object sender, EventArgs e)
        {
            f_LoadUserList();
            AddUserBinding();
            //comboUserListName(cbfUserListType);
        }

        void f_LoadUserList()
        {
            string cnStr = "Data Source=BEOSAMA-PC\\SQLEXPRESS;Initial Catalog=DemoQuanLyThuVienAlphaVer1_2;Integrated Security=True";
            cn = new SqlConnection(cnStr);
            DataSet ds = LoadUserList();
            UserListTable = ds.Tables[0];//datatable
            dtgvfUserList.DataSource = UserListTable;
        }
        private void btAddfUserList_Click(object sender, EventArgs e)
        {
            row = UserListTable.NewRow();
            row["UserName"] = txtNamefUserList.Text;
            row["DisplayName"] = txtDisplayfUserList.Text;
            row["PassWord"] = txtPassfUserList5.Text;
            row["Type"] = nbfUserList.Value;// dcm best vl
            UserListTable.Rows.Add(row);
        }

        void AddUserBinding()
        {
            txtNamefUserList.DataBindings.Add("text", dtgvfUserList.DataSource, "UserName",true , DataSourceUpdateMode.Never);
            txtDisplayfUserList.DataBindings.Add("text", dtgvfUserList.DataSource, "DisplayName", true, DataSourceUpdateMode.Never);
            txtPassfUserList5.DataBindings.Add("text", dtgvfUserList.DataSource, "PassWord", true, DataSourceUpdateMode.Never);
            nbfUserList.DataBindings.Add("value", dtgvfUserList.DataSource, "Type", true, DataSourceUpdateMode.Never);
        }
        private void btSavefUserList_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Update(UserListTable);
        }
        //void comboUserListName(ComboBox cb)
        //{
        //    DataRow row = UserListTable.NewRow();
        //    row["type"] = 
        //    cb.DataSource = row["type"].ToString();
        //    UserListTable.Rows.Add(row);
        //    cb.DisplayMember = "DisplayName";
        //}

        private void dtgvfUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int col = e.ColumnIndex;
            if (dtgvfUserList.Columns[col] is DataGridViewButtonColumn && dtgvfUserList.Columns[col].Name == "Delete")
            {
                int row = e.RowIndex;

                    //UserListTable.Rows.RemoveAt(row);// cái này lỗi sml với ko lưu được
                    UserListTable.Rows[row].Delete();//cái này dùng như cứt
            }
            //else if (dtgvfUserList.Columns[col]is DataGridViewButtonColumn && dtgvfUserList.Columns[col].Name == "Change")
            //{
            //    int row = e.RowIndex;
            //    UserListTable.Rows[row].BeginEdit();

            //}
            

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

        private void button3_Click(object sender, EventArgs e)
        {
            dataBindUserlist.DataSource = UserListTable;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this Contrucstion is still in work");
        }

        //private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        //{
        //    menuStrip1.BackColor = Color.White;
        //}



    }
}
