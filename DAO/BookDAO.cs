using DemoQuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DemoQuanLyThuVien.DAO
{
    public class BookDAO
    {
        private static BookDAO instance;

        public static BookDAO Instance
       {
           get { if (instance == null) instance = new BookDAO(); return BookDAO.instance; }
           private set { BookDAO.instance = value; }
       }
        private BookDAO() { }
        // public get book by category id

        public List<Book> getBookById(int id) 
        {
            List<Book> list = new List<Book>();
            string sql = "SELECT * FROM Book WHERE idCategory = " + id;
            
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);

            foreach (DataRow item in data.Rows)
            {
                Book book = new Book(item);
                list.Add(book);
            }
            return list;
        }

        public List<Book> getBook()
        {
            List<Book> list = new List<Book>();
            string sql = "SELECT * FROM Book";

            DataTable data = DataProvider.Instance.ExecuteQuery(sql);

            foreach (DataRow item in data.Rows)
            {
                Book book = new Book(item);
                list.Add(book);
            }
            return list;
        }
        //name , cateId , yearrl , nameAuthor , nameNXB , price
        public bool InsertBook(string name, int cateId, int yearrl, string nameAuthor, string nameNXB, float price)
        {
            string sql = string.Format("INSERT dbo.Book( name , idCategory , releaseYear , nameAuthor , nameNXB , price ) VALUES  ( N'{0}' , {1} , {2} , N'{3}' , N'{4}' , {5} )", name, cateId, yearrl, nameAuthor, nameNXB, price);
            int result = DataProvider.Instance.ExecuteNonQuery(sql);

            return  result > 0;
        }

        public bool UpdateBook(int idBook ,string name, int cateId, int yearrl, string nameAuthor, string nameNXB, float price)
        {
            string sql = string.Format("UPDATE dbo.Book SET name = N'{0}' , idCategory = {1} , releaseYear = {2} , nameAuthor = N'{3}' , nameNXB = N'{4}', price = {5} WHERE id = {6} ", name, cateId, yearrl, nameAuthor, nameNXB, price ,idBook );
            int result = DataProvider.Instance.ExecuteNonQuery(sql);

            return result > 0;// dis me :v
        }
        public bool DeleteBookById(int idFood)
        {
            //billinfoDAO
            string sql = string.Format("DELETE Book WHERE id = {0}", idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(sql);

            return result > 0;
        }
    }
}
