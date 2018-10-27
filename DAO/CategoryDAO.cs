using DemoQuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DemoQuanLyThuVien.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }
        private CategoryDAO() { }

        public List<Category> GetListCategory()
        {
            Category category;
            List<Category> list = new List<Category>();
            string sql = "SELECT * FROM BookCategory";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);

            foreach(DataRow item in data.Rows)
            {
                category = new Category(item);
                list.Add(category);
            }
            return list;
        }

        public Category GetListCategoryId(int id)
        {

            Category category = null;
            string sql = "SELECT * FROM BookCategory WHERE id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);

            foreach(DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }
            return category;
        }
    }
}
