using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQuanLyThuVien
{
    class Account
    {

        //public string id { get; set; }
        public string UserName { get; set; }
        public String DisplayName { get; set; }
        public string PassWord { get; set; }
        public string Type { get; set; }

        public Account(string id, string UserName, string PassWord, string Type)
        {
            //this.id = id;
            this.UserName = UserName;
            this.DisplayName = DisplayName;
            this.PassWord = PassWord;
            this.Type = Type;

        }
    }
}
