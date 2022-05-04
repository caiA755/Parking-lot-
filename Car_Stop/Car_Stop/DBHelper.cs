using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Car_Stop
{
   class DBHelper
    {
        public static string strConn = "server=.;database=Parking;integrated security=true;";   //连接数据库
        public static DataSet Select(string sql)   //查询语句
        {
            try
            {
                DataSet ds = new DataSet();
                new SqlDataAdapter(sql, strConn).Fill(ds);
                return ds;
            }
            catch
            {
                return null;
            }
        }
        public static bool NonSelect(string sql)   //非查询语句
        {
            try
            {
                SqlConnection c = new SqlConnection(strConn);
                c.Open();
                return (new SqlCommand(sql, c)).ExecuteNonQuery() > 0;
            }
            catch
            {
                return false;
            }
        }
        //聚合函数
        public static object ExecuteScalar(string sql) {
            SqlConnection c = new SqlConnection(strConn);
            c.Open();
            SqlCommand cmd = new SqlCommand(sql, c);
            object result = cmd.ExecuteScalar();
            c.Close();
            return result;
        }
    }
}
