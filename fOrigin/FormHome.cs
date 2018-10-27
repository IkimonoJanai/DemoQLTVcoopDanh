using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoQuanLyThuVien
{
    public partial class FormHome : Form
    {
        private Account loginAccountUser;

        public Account LoginAccountUser
        {
            get { return loginAccountUser; }
            set { loginAccountUser = value; ChangeAccount(loginAccountUser.Type); }
        }


        //ChangeAccount(loginAccountUser.Type);

        public FormHome(Account acc)
        {
            InitializeComponent();
            this.LoginAccountUser = acc;
        }
        private void label2_MouseHover(object sender, EventArgs e)
        {
            
        }
        private void label2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        #region Method
        #endregion

        #region Property
        #endregion

        #region Events

        private void btRentList_Click(object sender, EventArgs e)
        {
            fRentList fRL = new fRentList();
            this.Hide();
            fRL.ShowDialog();
            this.Show();
        }


        #endregion 

        private void mnAdminHause_Click(object sender, EventArgs e)
        {
            FormAdmin fA = new FormAdmin();
            this.Hide();
            fA.ShowDialog();
            this.Show();
        }

        void ChangeAccount (int Type)
        {
            mnAdminHause.Enabled = Type == 1;
        }

        private void btRent_Click(object sender, EventArgs e)
        {
            fRentBook fRB = new fRentBook();
            this.Hide();
            fRB.ShowDialog();
            this.Show();
        }

        //#region Property
        //#endregion
        //#region Method
        //#endregion
        //#region Events
        //#endregion


    }
}
