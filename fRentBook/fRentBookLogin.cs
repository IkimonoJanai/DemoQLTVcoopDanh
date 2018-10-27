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
    public partial class fRentBookLogin : Form
    {
        public fRentBookLogin()
        {
            InitializeComponent();
        }

        private void btRentBookSignup_Click(object sender, EventArgs e)
        {
            fRentBookSignUp f = new fRentBookSignUp();
            f.ShowDialog();
        }

        private void btRentBookLogin_Click(object sender, EventArgs e)
        {
            fRentBook fRB = new fRentBook();
            this.Hide();
            fRB.ShowDialog();
            this.Show();

        }
    }
}
