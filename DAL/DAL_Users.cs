using BaiCiZhanHelper;
using BaiCiZhanModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiCiZhanDAL
{
    public class DAL_Users
    {
        #region 增删改
        public int AddUsers(Users us)
        {
            string sql = "insert into Users(U_NAME, U_PASSWORD, U_IMG, U_EMAIL, U_REGISTERTIME) values(@a,@b,@c,@d,@e)";
            SqlParameter[] par ={
                                   new SqlParameter ("@a",us.U_NAME),
                                   new SqlParameter ("@b",us.U_PASSWORD),
                                   new SqlParameter ("@c",us.U_IMG),
                                   new SqlParameter ("@d",us.U_EMAIL),
                                   new SqlParameter ("@e",us.U_REGISTERTIME)
                               };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, par);
        }

        public int DeleteUsers(Users us)
        {
            string sql = "delete from Users where U_ID=@a and U_NAME=@b";
            SqlParameter[] par ={
                                    new SqlParameter ("@a",us.U_ID),
                                    new SqlParameter("@b",us.U_NAME)
                                };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, par);
        }

        public int UpdateUsers(Users us)
        {
            string sql = "update Users set U_NAME=@b, U_PASSWORD=@c, U_IMG=@d, U_EMAIL=@e where U_ID=@a";
            SqlParameter[] par ={
                                   new SqlParameter ("@a",us.U_ID),
                                   new SqlParameter ("@b",us.U_NAME),
                                   new SqlParameter ("@c",us.U_PASSWORD),
                                   new SqlParameter ("@d",us.U_IMG),
                                   new SqlParameter ("@e",us.U_EMAIL)
                               };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, par);
        }
        //查询当前用户资料并输出
        public List<Users> select(Users u)
        {
            string sql = "select * from Users where U_NAME=@a and U_PASSWORD=@b";
            SqlParameter[] par =
            {
                new SqlParameter("@a",u.U_NAME),
                new SqlParameter("@b",u.U_PASSWORD)
            };
            List<Users> lu = new List<Users>();
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, System.Data.CommandType.Text, par);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    Users us = new Users();
                    u.U_ID = Convert.ToInt32(sdr["U_ID"]);
                    u.U_NAME = sdr["U_NAME"].ToString();
                    u.U_PASSWORD = sdr["U_PASSWORD"].ToString();
                    u.U_IMG = (string)sdr["U_IMG"];
                    u.U_EMAIL = sdr["U_EMAIL"].ToString();
                    u.U_REGISTERTIME = Convert.ToDateTime(sdr["U_REGISTERTIME"]);
                    lu.Add(u);
                }
            }
            sdr.Close();
            return lu;
        }
        #endregion
        public List<Users> SeleteUsers()
        {
            string sql = "select * from Users";
            List<Users> lus = new List<Users>();
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, System.Data.CommandType.Text, null);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    Users us = new Users();
                    us.U_ID = Convert.ToInt32(sdr["U_ID"]);
                    us.U_NAME = sdr["U_NAME"].ToString();
                    us.U_PASSWORD = sdr["U_PASSWORD"].ToString();
                    us.U_IMG = (string)sdr["U_IMG"];
                    us.U_EMAIL = sdr["U_EMAIL"].ToString();
                    us.U_REGISTERTIME = Convert.ToDateTime(sdr["U_REGISTERTIME"]);
                    lus.Add(us);
                }
            }
            sdr.Close();
            return lus;
        }
        //用户登录
        public bool log(string name, string pass)
        {
            string sql = "select U_NAME,U_PASSWORD from Users where U_NAME=@a and U_PASSWORD=@b";
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@a",name),
                new SqlParameter("@b",pass)
            };

            if (SQLHelper.ExecuteReader(sql, System.Data.CommandType.Text, par).HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}