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
    /// 单词表
    /// </summary>
    public class DAL_CourseDetails
    {
        #region 增、删、改
        //添加单词
        public int AddCourseDetails(CourseDetails cd)
        {
            string sql = "insert into CourseDetails(C_ID,CD_NAME,CD_YINBIAO,CD_Mean,CD_RIGHT_PIC,CD_WRONG_PIC1,CD_WRONG_PIC2,CD_WRONG_PIC3,CD_SENEng,CD_SENChi,CD_VIDEO) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10,@a11)";
            SqlParameter[] par ={
                                   new SqlParameter ("@a1",cd.C_ID),
                                   new SqlParameter ("@a2",cd.CD_NAME),
                                   new SqlParameter ("@a3",cd.CD_YINBIAO),
                                   new SqlParameter ("@a4",cd.CD_Mean),
                                   new SqlParameter ("@a5",cd.CD_RIGHT_PIC),
                                   new SqlParameter ("@a6",cd.CD_WRONG_PIC1),
                                   new SqlParameter ("@a7",cd.CD_WRONG_PIC2),
                                   new SqlParameter ("@a8",cd.CD_WRONG_PIC3),
                                   new SqlParameter ("@a9",cd.CD_SENEng),
                                   new SqlParameter ("@a10",cd.CD_SENChi),
                                   new SqlParameter ("@a11",cd.CD_VIDEO)
                               };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, par);
        }
        
        //删除单词
        public int DeleteCourseDetails(int id)
        {
            string sql="delete from CourseDetails where CD_ID=@a";
            SqlParameter[] par={
                                    new SqlParameter("@a",id)
                                };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, par);
        }
        
        #endregion

        public List<CourseDetails> SeleteCourseDetails()
        {
            List<CourseDetails> lcd = new List<CourseDetails>();
            string sql = "select * from CourseDetails";
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, System.Data.CommandType.Text, null);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    CourseDetails cd = new CourseDetails();
                    cd.C_ID = Convert.ToInt32(sdr["C_ID"]);
                    cd.CD_ID = Convert.ToInt32(sdr["CD_ID"]);
                    cd.CD_NAME = sdr["CD_NAME"].ToString();
                    cd.CD_YINBIAO = sdr["CD_YINBIAO"].ToString();
                    cd.CD_Mean = sdr["CD_Mean"].ToString();
                    cd.CD_RIGHT_PIC = (string)sdr["CD_RIGHT_PIC"];
                    cd.CD_WRONG_PIC1 = (string)sdr["CD_WRONG_PIC1"];
                    cd.CD_WRONG_PIC2 = (string)sdr["CD_WRONG_PIC2"];
                    cd.CD_WRONG_PIC3 = (string)sdr["CD_WRONG_PIC3"];
                    cd.CD_SENEng = sdr["CD_SENEng"].ToString();
                    cd.CD_SENChi = sdr["CD_SENChi"].ToString();
                    cd.CD_VIDEO = sdr["CD_VIDEO"].ToString();
                    lcd.Add(cd);
                }
            }
            sdr.Close();
            return lcd;
        }

        public int total(Coures c)
        {
            string sql = "select count(*) from CourseDetails where C_ID=@id";
            SqlParameter[] par =
            {
                new SqlParameter("@id",c.C_ID),
            };
            return Convert.ToInt32(SQLHelper.ExecuteScalar(sql, System.Data.CommandType.Text, par));
        }
    }
}
