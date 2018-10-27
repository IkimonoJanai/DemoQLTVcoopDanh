using DemoQuanLyThuVien.DAO;
using DemoQuanLyThuVien.DTO;
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
    public partial class fBookList : Form
    {
        BindingSource loadBook = new BindingSource();
        public fBookList()
        {
            InitializeComponent();
        }

        private void fBookList_Load(object sender, EventArgs e)
        {
            load();
            AddBookBinding();
            LoadCategoryBookIntoCombobox(cbBookListIdCategory);
        }
        void load()
        {
            string sql = "SELECT * FROM Book";
            dtgvfBookList.DataSource = DataProvider.Instance.ExecuteQuery(sql);
        }
        void AddBookBinding()
        {
            txtBookListId.DataBindings.Add(new Binding("Text", dtgvfBookList.DataSource, "id"));
            txtBookListName.DataBindings.Add(new Binding("Text", dtgvfBookList.DataSource, "name"));
            txtBookListYear.DataBindings.Add(new Binding("Text", dtgvfBookList.DataSource, "releaseYear"));
            txtBookListAuthor.DataBindings.Add(new Binding("Text", dtgvfBookList.DataSource, "nameAuthor"));
            txtBookListNameNXB.DataBindings.Add(new Binding("Text", dtgvfBookList.DataSource, "nameNXB"));
            nbfBookListPrice.DataBindings.Add(new Binding("Value", dtgvfBookList.DataSource, "price"));
        }
        void  LoadCategoryBookIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "name";
        }

        private void txtBookListId_TextChanged(object sender, EventArgs e)
        {
            if (dtgvfBookList.SelectedCells.Count > 0)
            {
                int id = (int)dtgvfBookList.SelectedCells[0].OwningRow.Cells["idCategory"].Value;

                Category category = CategoryDAO.Instance.GetListCategoryId(id);

                cbBookListIdCategory.SelectedItem = category;

                int index = -1;
                int i = 0;

                foreach (Category item in cbBookListIdCategory.Items)
                {
                    if (item.id == category.id)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cbBookListIdCategory.SelectedIndex = index;
            }

        }

        private void btfBookListRefresh_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Book";
            loadBook.DataSource = DataProvider.Instance.ExecuteQuery(sql);
        }

    }
}
