using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiCiZhanHelper
{
    public class DBHelper
    {
        /// <summary>
        /// 创建连接对象
        /// </summary>
        /// <returns>连接对象</returns>
        public static SqlConnection CreateConn()
        {
            string connStr = "Server=KEVINDING; Database=BczQg; uid=sa; pwd=1111";
            SqlConnection conn = new SqlConnection(connStr);
            return conn;
        }

        /// <summary>
        /// 增、删、改操作
        /// </summary>
        /// <param name="sqlText">sql语句</param>
        /// <returns>受影响的行数</returns>
        public static int ExecuteNonQuery(string sqlText, SqlParameter[] pars)
        {
            using (SqlConnection conn = CreateConn())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlText, conn);
                if (pars != null)
                {
                    cmd.Parameters.AddRange(pars);
                }
                int count = cmd.ExecuteNonQuery();

                return count;

            }
        }
        /// <summary>
        /// 单值查询
        /// </summary>
        /// <param name="sqlText">sql语句</param>
        /// <returns>单个值</returns>
        public static object ExecuteScalar(string sqlText, SqlParameter[] pars)
        {
            using (SqlConnection conn = CreateConn())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlText, conn);
                if (pars != null)
                {
                    cmd.Parameters.AddRange(pars);
                }
                object obj = cmd.ExecuteScalar();
                conn.Close();
                return obj;
            }
        }

        /// <summary>
        /// 多值查询:查询一行数据
        /// </summary>
        /// <param name="sqlText"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sqlText, SqlParameter[] pars)
        {
            SqlConnection conn = CreateConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlText, conn);
            //判断pars是否为空
            if (pars != null)
            {
                cmd.Parameters.AddRange(pars);
            }
            SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return sdr;
        }
        /// <summary>
        /// 多值查询:查询所有
        /// </summary>
        /// <param name="sqlText">sql语句</param>
        /// <returns>数据表</returns>
        public static DataTable QueryData(string sqlText, SqlParameter[] pars)
        {
            using (SqlConnection conn = CreateConn())
            {
                SqlDataAdapter sda = new SqlDataAdapter(sqlText, conn);
                if (pars != null)
                {
                    sda.SelectCommand.Parameters.AddRange(pars);
                }
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
        }

        //定义一个方法:调用存储过程
        public static SqlDataReader ExecuteProc(string procName, SqlParameter[] pars)
        {
            SqlConnection conn = CreateConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand(procName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (pars != null)
            {
                cmd.Parameters.AddRange(pars);
            }
            SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return sdr;
        }
        /// <summary>
        /// 执行增删改的存储过程
        /// </summary>
        /// <param name="ProName"></param>
        /// <param name="par"></param>
        /// <returns></returns>
        public static int ExecuteProcCommand(string ProName, SqlParameter[] par)
        {
            using (SqlConnection conn = CreateConn())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(ProName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (par != null)
                {
                    cmd.Parameters.AddRange(par);
                }
                int num = cmd.ExecuteNonQuery();
                return num;
            }
        }
    }
}
