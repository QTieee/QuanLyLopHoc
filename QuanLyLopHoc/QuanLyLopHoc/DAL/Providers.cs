using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace QuanLyLopHoc.DAL
{
    class Providers
    {
        public SqlConnection connection;
        public bool Connect()
        {
            string connectionStr = ConfigurationManager.ConnectionStrings["ConnectStr"].ConnectionString.ToString();
            connection = new SqlConnection(connectionStr);
            if ((connection.State == ConnectionState.Closed) || (connection.State == ConnectionState.Broken))
            {
                connection.Open();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DisConnect()
        {
            connection.Close();
            connection.Dispose();
        }
        public SqlCommand Command(string queryOrSpName, string[] Parameters, object[] Values, bool isStored)
        {
            SqlCommand cmd = new SqlCommand(queryOrSpName, connection);
            if (isStored)
            {
                cmd.CommandText = queryOrSpName;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;
            }
            if (Parameters != null)
            {
                for (int i = 0; i < Parameters.Length; i++)
                {
                    cmd.Parameters.AddWithValue(Parameters[i], Values[i]);
                }
            }
            return cmd;
        }
        public SqlDataReader ExecuteReader(string queryOrName, string[] Parameters, object[] Values, bool isStored)
        {
            SqlDataReader reader = Command(queryOrName, Parameters, Values, isStored).ExecuteReader();
            DisConnect();
            return reader;
        }
        public int ExecuteNonQuery(string queryOrName, string[] Parameters, object[] Values, bool isStored)
        {
            int rec = Command(queryOrName, Parameters, Values, isStored).ExecuteNonQuery();
            DisConnect();
            return rec;
        }
        public int ExecuteScalar(string queryOrName, string[] Parameters, object[] Values, bool isStored)
        {
            int Scalar = (int)Command(queryOrName, Parameters, Values, isStored).ExecuteScalar();
            DisConnect();
            return Scalar;
        }
        public DataTable GetData(string queryOrName, string[] Parameters, object[] Values, bool isStored)
        {
            DataTable tbl = new DataTable();
            SqlCommand cmd = Command(queryOrName, Parameters, Values, isStored);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tbl);
            DisConnect();
            return tbl;
        }
    }
}
