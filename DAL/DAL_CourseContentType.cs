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
    public class DAL_CourseContentType
    {
        #region 增、删、改
        //添加单词包类型
        public int AddCourseContentType(CourseContentType cct)
        {
            string sql = "insert into CourseContentType values(@a,@b)";
            SqlParameter[] par ={
                                   new SqlParameter ("@a",cct.CCT_NAME),
                                   new SqlParameter ("@b",cct.CCT_DESC)
                               };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, par);
        }

        //删除单词包类型
        public int DeleteCourseContentType(int id)
        {
            string sql = "delete from CourseContentType where CCT_ID=@a";
            SqlParameter[] par ={
                                    new SqlParameter ("@a",id)
                                };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, par);
        }

        //修改单词包类型
        public int UpdateCourseContentType(CourseContentType cct)
        {
            string sql = @"update CourseContentType set CCT_ID=@a,CCT_DESC=@b where id=@c";
            SqlParameter[] par = new SqlParameter[]{
                new SqlParameter ("@c",cct.CCT_ID),
                new SqlParameter ("@a",cct.CCT_NAME),
                new SqlParameter ("@b",cct.CCT_DESC)
            };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, par);
        }
        #endregion

        //查询单词包类型
        public List<CourseContentType> SeleteCourseContentType()
        {
            string sql = "selete * from CourseContentType";
            List<CourseContentType> lcct = new List<CourseContentType>();
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, System.Data.CommandType.Text, null);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    CourseContentType cct = new CourseContentType();
                    cct.CCT_ID = Convert.ToInt32(sdr["CCT_ID"].ToString());
                    cct.CCT_NAME = sdr["CCT_NAME"].ToString();
                    cct.CCT_DESC = sdr["CCT_DESC"].ToString();
                    lcct.Add(cct);
                }
            }
            sdr.Close();
            return lcct;
        }
    }
}
