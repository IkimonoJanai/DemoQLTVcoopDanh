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

        private void lbfrbName_Click(object sender, EventArgs e)
        {
            //FormLogin f = new FormLogin();
            
            //this.lbfebMSSV = txt
        }



        private void btDMSAll_Click(object sender, EventArgs e)
        {

            dtgvRentBook.DataSource = BookDAO.Instance.getBook();

        }

        private void btThanThanh_Click(object sender, EventArgs e)
        {
            if (dtgvRentBook.SelectedCells.Count > 0)
            {
                
            }
        }
        private void btDMSLN_Click(object sender, EventArgs e)
        {
            dtgvRentBook.DataSource = BookDAO.Instance.getBookById(1);
        }

        private void btDmsManga_Click(object sender, EventArgs e)
        {
            dtgvPickRentBook.DataSource = BookDAO.Instance.getBookById(2);
        }

        private void btDmsVH_Click(object sender, EventArgs e)
        {
            dtgvPickRentBook.DataSource = BookDAO.Instance.getBookById(5);
        }

        private void btDmsDoujin_Click(object sender, EventArgs e)
        {
            dtgvPickRentBook.DataSource = BookDAO.Instance.getBookById(4);
        }

        private void btDmsCNTT_Click(object sender, EventArgs e)
        {
            dtgvPickRentBook.DataSource = BookDAO.Instance.getBookById(3);
        }

        void GetDataForDtgvPickRentBook()
        {
            



        }






    }
}
