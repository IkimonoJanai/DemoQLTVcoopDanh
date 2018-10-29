using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DemoQuanLyThuVien.DTO;

namespace DemoQuanLyThuVien.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            string sql = "USP_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(sql ,new object[] {@userName , @passWord});

            return result.Rows.Count > 0;
        }

        public Account LoginByUsername(string userName)
        {

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Account WHERE username = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        bool LoginAdmin(string userName , string passWord)
        {
            return LoginAdmin(userName, passWord);
        }
    }
}
