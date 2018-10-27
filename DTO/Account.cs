using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DemoQuanLyThuVien
{
    public class Account
    {
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string PassWord { get; set; }
        public int Type { get; set; }

        public Account(string UserName, string DisplayName,int Type, string PassWord = null)
        {
            this.UserName = UserName;
            this.DisplayName = DisplayName;
            this.PassWord = PassWord;
            this.Type = Type;
        }
        public Account(DataRow row)
        {
            this.UserName = row["UserName"].ToString();
            this.DisplayName = row["DisplayName"].ToString();
            this.Type = (int)row["Type"];
            this.PassWord = row["PassWord"].ToString();
        }
    }
}
