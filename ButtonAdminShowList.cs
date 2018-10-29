using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DemoQuanLyThuVien
{
    public partial class ButtonAdminShowList : UserControl
    {
        public ButtonAdminShowList()
        {
            InitializeComponent();
        }
        public string button
        {
            get { return button2.Text; }
            set { button2.Text = value; }
        }

        public Color asd
        {
            get {return panel1.BackColor;}
            set { panel1.BackColor = value; }
        }

        public Color asd2
        {
            get { return panel2.BackColor; }
            set { panel2.BackColor = value; }
        }

        public Color asd3
        {
            get { return panel3.BackColor; }
            set { panel3.BackColor = value; }
        }
        public Color buttonAdmin1
        {
            get { return button2.BackColor; }
            set { button2.BackColor = value; }
        }
        public Image img
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fRentList fRL = new fRentList();
            fRL.ShowDialog();
        }



    }
}
