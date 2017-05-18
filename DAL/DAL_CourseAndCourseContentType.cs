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
    /// <summary>
    /// 单词包单词类型数据访问
    /// </summary>
    public class DAL_CourseAndCourseContentType
    {
        //查询单词包、单词类型
        public List<CourseAndCourseContentType> GetAll()
        {
            List<CourseAndCourseContentType> lcct = new List<CourseAndCourseContentType>();
            string sql=@"selete CourseContentType.CCT_ID,CourseContentType.CCT_NAME,
                        CourseContentType.CCT_DESC,Course.C_ID,Course.C_NAME,
                        Course.C_RELEASEDATE,Course.C_VOCABULARY from 
                        CourseContentType inner join Course on 
                        CourseContentType.CCT_ID=Course.CCT_ID";
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, System.Data.CommandType.Text, null);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    CourseAndCourseContentType cacct = new CourseAndCourseContentType();
                    cacct.CCT_ID = Convert.ToInt32(sdr["CCT_ID"].ToString());
                    cacct.CCT_NAME = sdr["CCT_NAME"].ToString();
                    cacct.CCT_DESC = sdr["CCT_DESC"].ToString();
                    cacct.C_ID = Convert.ToInt32(sdr["C_ID"]);
                    cacct.C_NAME = sdr["C_NAME"].ToString ();
                    cacct.C_RELEASEDATE = Convert.ToDateTime(sdr["C_RELEASEDATE"]);
                    cacct.C_VOCABULARY = Convert.ToDouble(sdr["C_VOCABULARY"]);
                    lcct.Add(cacct);
                }
            }
            sdr.Close();
            return lcct;
        }
    }
}
