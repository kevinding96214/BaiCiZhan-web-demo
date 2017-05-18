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
    public class DAL_LecturerType
    {
        #region 增删改
        public int AddLecturerType(LecturerType lt)
        {
            string sql = "insert into LecturerType values(@a.@b.@c)";
            SqlParameter[] par ={
                                   new SqlParameter ("@a",lt.LT_ID),
                                   new SqlParameter ("@b",lt.LT_NAME),
                                   new SqlParameter ("@c",lt.LT_DESC)
                               };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, par);
        }

        public int DeleteLecturerType(int id)
        {
            string sql = "delete from LecturerType where LT_ID=@a";
            SqlParameter[] par ={
                                    new SqlParameter ("@a",id)
                                };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, par);
        }

        public int UpdateLecturerType(LecturerType lt)
        {
            string sql = @"update LecturerType set LT_NAME=@b,LT_DESC=@c where LT_ID=@a";
            SqlParameter[] par ={
                                    new  SqlParameter ("@a",lt.LT_ID ),
                                    new  SqlParameter ("@b",lt.LT_NAME ),
                                    new  SqlParameter ("@c",lt.LT_DESC)
                                };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, par);
        }
        #endregion

        public List<LecturerType> SeleteLecturerType()
        {
            List<LecturerType> llt = new List<LecturerType>();
            string sql = "select LT_NAME from LecturerType";
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, System.Data.CommandType.Text, null);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    LecturerType lt = new LecturerType();
                    lt.LT_NAME = sdr["LT_NAME"].ToString();
                    llt.Add(lt);
                }
            }
            sdr.Close();
            return llt;
        }
    }
}
