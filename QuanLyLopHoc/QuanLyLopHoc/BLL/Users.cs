using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using QuanLyLopHoc.DAL;

namespace QuanLyLopHoc.BLL
{
    class Users
    {
        Providers providers = new Providers();
        public SqlConnection Connection()
        {
            return providers.connection;
        }
        public Boolean Connect()
        {
            return providers.Connect();
        }
        public void DisConnect()
        {
            providers.DisConnect();
        }
        public int CheckUser(string User, string Pass)
        {
            providers.Connect();
            string strsql = "Select count(*) from USERS where ((TenTK=@TaiKhoan)and(MatKhau=@MatKhauNguoiDung))";
            SqlCommand Cmd = new SqlCommand(strsql, Connection());
            SqlParameter para1 = new SqlParameter("@TaiKhoan", User);
            SqlParameter para2 = new SqlParameter("@MatKhauNguoiDung", Pass);
            Cmd.Parameters.Add(para1);
            Cmd.Parameters.Add(para2);
            int kqsql = (int)Cmd.ExecuteScalar();
            return kqsql;
        }
    }
}
