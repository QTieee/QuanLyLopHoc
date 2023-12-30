using QuanLyLopHoc.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace QuanLyLopHoc.BLL
{
    class Lop
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
        public DataTable GetDataSanPham()
        {
            string[] parameters = { };
            string[] values = { };
            return providers.GetData("Select* From LOPHOC", parameters, values, false);
        }

        public int LOPHOCExecuteNonQuery(string queryOrSpName, string[] Parameters, object[] Values, bool isStored)
        {
            return providers.ExecuteNonQuery(queryOrSpName, Parameters, Values, isStored);
        }
        public int CheckPK(string malop)
        {
            providers.Connect();
            string strsql = "Select count(*) from LOPHOC where MALOP=@malop";
            SqlCommand Cmd = new SqlCommand(strsql, Connection());
            SqlParameter para = new SqlParameter("@malop", malop);
            Cmd.Parameters.Add(para);
            int kqsql = (int)Cmd.ExecuteScalar();
            return kqsql;
        }
    }
}
