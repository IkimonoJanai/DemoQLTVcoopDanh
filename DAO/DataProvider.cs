using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DemoQuanLyThuVien.DAO
{
    public class DataProvider
    {
        private string cnStr = "Data Source=BEOSAMA-PC\\SQLEXPRESS;Initial Catalog=DemoQuanLyThuVienAlphaVer1_2;Integrated Security=True";
        private static DataProvider instance;
        
        public static DataProvider Instance
        {
        get {if(instance == null) instance = new DataProvider(); return DataProvider.instance; }
        private set { DataProvider.instance = value; }
        }

        private DataProvider(){}

        public DataTable ExecuteQuery(string sql, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection cn = new SqlConnection(cnStr))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);

                if (parameter != null)
                {
                    string[] listpara = sql.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                cn.Close();
            }
            
            return data;
        }
        public int ExecuteNonQuery(string sql, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection cn = new SqlConnection(cnStr))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);

                if (parameter != null)
                {
                    string[] listpara = sql.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                cn.Close();
            }

            return data;
        }
        public object ExecuteScalar(string sql, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection cn = new SqlConnection(cnStr))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);

                if (parameter != null)
                {
                    string[] listpara = sql.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteScalar();
                cn.Close();
            }

            return data;
        }



    }
}
