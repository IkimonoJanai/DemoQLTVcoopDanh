using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQuanLyThuVien.DAO
{
    public class BookDAO
    {
        private static BookDAO instance;

        public static BookDAO Instance
       {
            get { if (Instance == null) Instance = new BookDAO(); return BookDAO.Instance; }
           private set { BookDAO.Instance = value; }
       }
        private BookDAO() { }
        // public get book by category id
    }
}
