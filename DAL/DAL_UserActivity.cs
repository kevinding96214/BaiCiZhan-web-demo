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
    public class DAL_UserActivity
    {
        #region 增删改
        public int AddUserActivity(UserActivity ua)
        {
            string sql = "insert into UserActivity values(@a,@b,@c,@d,@e)";
            SqlParameter[] par ={
                                   new SqlParameter ("@a",ua.UA_ID),
                                   new SqlParameter ("@b",ua.U_ID),
                                   new SqlParameter ("@c",ua.C_ID),
                                   new SqlParameter ("@d",ua.UA_DATE),
                                   new SqlParameter ("@e",ua.UA_WordNum)
                               };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, par);
        }

        public int DeleteUserActivity(string id)
        {
            string sql = "delete from UserActivity where UA_ID=@a";
            SqlParameter[] par ={
                                    new SqlParameter ("@a",id)
                                };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, par);
        }

        public int UpdateUserActivity(UserActivity ua)
        {
            string sql = @"update UserActivity U_ID=@b,C_ID=@c,UA_DATE=@d,UA_WordNum=@e where UA_ID=@a";
            SqlParameter[] par ={
                                    new SqlParameter ("@a",ua.UA_ID),
                                    new SqlParameter ("@b",ua.U_ID),
                                    new SqlParameter ("@c",ua.C_ID),
                                    new SqlParameter ("@d",ua.UA_DATE),
                                    new SqlParameter ("@e",ua.UA_WordNum)
                                };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, par);
        }
        #endregion

        public List<UserActivity> SeleteUserActivity()
        {
            List<UserActivity> lua = new List<UserActivity>();
            string sql = "select * from UserActivity";
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, System.Data.CommandType.Text, null);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    UserActivity ua = new UserActivity();
                    ua.UA_ID = sdr["UA_ID"].ToString();
                    ua.U_ID = sdr["U_ID"].ToString();
                    ua.C_ID = Convert.ToInt32(sdr["C_ID"]);
                    ua.UA_DATE = Convert.ToDateTime(sdr["UA_DATE"]);
                    ua.UA_WordNum = Convert.ToInt32(sdr["UA_WordNum"]);
                    lua.Add(ua);
                }
            }
            sdr.Close();
            return lua;
        }
    }
}
