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
    public partial class fRentBook : Form
    {
        public fRentBook()
        {
            InitializeComponent();
        }

        private void btConfirmRent_Click(object sender, EventArgs e)
        {
            
        }

        private void mnReturnfRentBook_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fRentBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Close();



        }
    }
}
