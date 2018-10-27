using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQuanLyThuVien.DTO
{
    public class Book
    {
        public int id { get; set; }
        public string name { get; set; }
        public int idCategory { get; set; }
        public int releaseYear { get; set; }
        public string nameAuthor { get; set; }
        public string nameNXB { get; set; }
        public double price { get; set; }

        public Book (int id,string name, int idCategory, int releaseYear, string nameAuthor ,string nameNXB ,double price)
        {
            this.id = id;
            this.name = name;
            this.idCategory = idCategory;
            this.releaseYear = releaseYear;
            this.nameAuthor = nameAuthor;
            this.nameNXB = nameNXB;
            this.price = price;
        }
    }
}
