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
    public class DAL_UserDownload
    {
        #region 增删改
        public int AddUserDownload(UserDownload ud)
        {
            string sql = "insert into UserDownload values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j)";
            SqlParameter[] par={
                                   new SqlParameter ("@a",ud.UD_ID),
                                   new SqlParameter ("@b",ud.U_ID),
                                   new SqlParameter ("@c",ud.C_ID),
                                   new SqlParameter ("@d",ud.CD_ID),
                                   new SqlParameter ("@e",ud.CD_IsBei),
                                   new SqlParameter ("@f",ud.UD_CUT),
                                   new SqlParameter ("@g",ud.UD_STUDY),
                                   new SqlParameter ("@h",ud.UD_Review),
                                   new SqlParameter ("@i",ud.UD_DATE),
                                   new SqlParameter ("@j",ud.UD_Status)
                               };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, par);
        }

        public int DeleteUserDownload(int id)
        {
            string sql = "delete from UserDowmload where UD_ID=@a";
            SqlParameter[] par ={
                                    new SqlParameter ("@a",id)
                                };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, par);
        }

        public int UpdateUserDownload(UserDownload ud)
        {
            string sql = @"insert into UserDownload set U_ID=@a2,C_ID=@a3,CD_ID=@a4,
                        CD_IsBei=@a5,UD_CUT=@a6,UD_STUDY=@a7,UD_Review=@a8,
                        UD_DATE=@a9,UD_Status=@a10 where UD_ID=@a1";
            SqlParameter[] par ={
                                   new SqlParameter ("@a1",ud.UD_ID),
                                   new SqlParameter ("@a2",ud.U_ID),
                                   new SqlParameter ("@a3",ud.C_ID),
                                   new SqlParameter ("@a4",ud.CD_ID),
                                   new SqlParameter ("@a5",ud.CD_IsBei),
                                   new SqlParameter ("@a6",ud.UD_CUT),
                                   new SqlParameter ("@a7",ud.UD_STUDY),
                                   new SqlParameter ("@a8",ud.UD_Review),
                                   new SqlParameter ("@a9",ud.UD_DATE),
                                   new SqlParameter ("@a10",ud.UD_Status)
                               };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, par);
        }
        #endregion

        public List<UserDownload> SeleteUserDownload()
        {
            List<UserDownload> lud = new List<UserDownload>();
            string sql = "select * from UserDownload";
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, System.Data.CommandType.Text, null);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    UserDownload ud = new UserDownload();
                    ud.UD_ID=Convert .ToInt32 (sdr["UD_ID"]);
                    ud.U_ID = sdr["U_ID"].ToString();
                    ud.C_ID = Convert.ToInt32(sdr["C_ID"]);
                    ud.CD_ID = Convert.ToInt32(sdr["CD_ID"]);
                    ud.CD_IsBei = Convert.ToBoolean(sdr["CD_IsBei"]);
                    ud.UD_CUT = Convert.ToBoolean(sdr["UD_CUT"]);
                    ud.UD_STUDY = Convert.ToDateTime(sdr["UD_STUDY"]);
                    ud.UD_Review = Convert.ToDateTime(sdr["UD_Review"]);
                    ud.UD_DATE = Convert.ToInt32(sdr["UD_DATE"]);
                    ud.UD_Status = sdr["UD_Status"].ToString();
                    lud.Add(ud);
                }
            }
            sdr.Close();
            return lud;
        }
    }
}
