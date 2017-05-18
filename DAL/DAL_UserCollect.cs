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
    public class DAL_UserCollect
    {
        #region 增删改
        public int AddUserCollect(UserCollect uc)
        {
            string sql = "insert into UserCollect(U_ID,C_ID,UC_EveWord,UC_ComDay,US_EndDay,UC_isRead) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7)";
            SqlParameter[] par ={
                                   new SqlParameter ("@a1",uc.U_ID),
                                   new SqlParameter ("@a2",uc.C_ID ),
                                   new SqlParameter ("@a3",uc.UC_EveWord),
                                   new SqlParameter ("@a4",uc.UC_ComDay),
                                   new SqlParameter ("@a5",uc.UC_StartDay),
                                   new SqlParameter ("@a6",uc.US_EndDay),
                                   new SqlParameter ("@a7",uc.UC_isRead)
                               };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, par);
        }

        public int DeleteUserCollect(int id)
        {
            string sql = "delete from UserCollect where UC_ID=@a";
            SqlParameter[] par ={
                                    new SqlParameter ("@a",id)
                                };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, par);
        }

        public int UpdateUserCollect(UserCollect uc)
        {
            string sql = @"update UserCollect set U_ID=@b,C_ID=@c,UC_EveWord=@d,UC_ComDay=@e,UC_StartDay=@f,US_EndDay=@g,UC_isRead=@h where UC_ID=@a";
            SqlParameter[] par ={
                                    new SqlParameter ("@a",uc.UC_ID),
                                    new SqlParameter ("@b",uc.U_ID),
                                    new SqlParameter ("@c",uc.C_ID),
                                    new SqlParameter ("@d",uc.UC_EveWord),
                                    new SqlParameter ("@e",uc.UC_ComDay),
                                    new SqlParameter ("@f",uc.UC_StartDay),
                                    new SqlParameter ("@g",uc.US_EndDay),
                                    new SqlParameter ("@h",uc.UC_isRead)
                                };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, par);
        }
        #endregion

        public List<UserCollect > SeleteUserCollect(int id)
        {
            string sql = "select * from UserCollect where U_ID=@ID";
            List<UserCollect> luc = new List<UserCollect>();
            SqlParameter[] par =
            {
                new SqlParameter("@ID",id)
            };
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, System.Data.CommandType.Text, par);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    UserCollect uc = new UserCollect();
                    uc.UC_ID = Convert.ToInt32(sdr["UC_ID"]);
                    uc.U_ID = sdr["U_ID"].ToString();
                    uc.C_ID = Convert.ToInt32(sdr["C_ID"]);
                    uc.UC_EveWord = Convert.ToInt32(sdr["UC_EveWord"]);
                    uc.UC_ComDay = Convert.ToInt32(sdr["UC_ComDay"]);
                    uc.UC_StartDay = Convert.ToDateTime(sdr["UC_StartDay"]);
                    uc.US_EndDay = Convert.ToDateTime(sdr["US_EndDay"]);
                    luc.Add(uc);
                }
            }
            sdr.Close();
            return luc;
        }
    }
}
