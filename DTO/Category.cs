using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DemoQuanLyThuVien.DTO
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public Category(int id , string name)
        {
            this.id = id;
            this.name = name;
        }
        public Category(DataRow row)
        {
            this.id = (int)row["id"];
            this.name = row["name"].ToString();
        }
    }
}
