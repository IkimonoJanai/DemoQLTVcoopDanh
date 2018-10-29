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
        bool hidden;
        int PanelHeight , pnMssv;
        public FormAdmin()
        {
            InitializeComponent();
            PanelHeight = pnGiaLaiMenu.Height;
            pnMssv = pnGiaLaiNameAndMssv.Height;
            hidden = false;
            pnGiaLaiMenu.Height = pnGiaLaiMenu.Height - 999;
            //pnGiaLaiMenu.Size.Height = 10; 
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
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdminShowList3_Click(object sender, EventArgs e)
        {
            fBookList fBL = new fBookList();
            this.Hide();
            fBL.ShowDialog();
            this.Show();
        }

        private void buttonAdminShowList1_Click(object sender, EventArgs e)
        {
            fRentList fRL = new fRentList();
            this.Hide();
            fRL.ShowDialog();
            this.Show();
        }

        private void buttonAdminShowList2_Click(object sender, EventArgs e)
        {
            fUserList fUL = new fUserList();
            this.Hide();
            fUL.ShowDialog();
            this.Show();
        }

        #endregion

        private void MenuSlide_Tick(object sender, EventArgs e)
        {  
            if(hidden)
            {
                pnGiaLaiMenu.Height = pnGiaLaiMenu.Height -10;

                if (pnGiaLaiMenu.Height <= 0)
                {
                    MenuSlide.Stop();
                    hidden = false;
                    this.Refresh();
                    btMenuClose.Text = "MENU";
                }
            }
            else
            {
                pnGiaLaiMenu.Height = pnGiaLaiMenu.Height + 10;
                if(pnGiaLaiMenu.Height >= 105 )
                {
                    MenuSlide.Stop();
                    hidden = true;
                    this.Refresh();
                    btMenuClose.Text = "CLOSE";
                }
            }
        }

        private void btMenuClose_Click(object sender, EventArgs e)
        {
            MenuSlide.Start();
        }

        private int ImageId = 1;
        private void LoadImageRunning()
        {
            if(ImageId == 13)
            {
                ImageId = 1;
            }
            picAdminScroll.ImageLocation = string.Format(@"Img\{0}.jpg", ImageId);
            ImageId++;
        }

        private void picRun_Tick(object sender, EventArgs e)
        {
            LoadImageRunning();
        }











    }
}
