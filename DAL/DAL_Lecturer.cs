using BaiCiZhanHelper;
using BaiCiZhanModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiCiZhanDAL
{
    public class DAL_Lecturer
    {
        #region 增、改、删
        //添加管理员
        public int AddLecturer(Lecturer lt)
        {
            string sql = "insert into Lecturer(L_NAME,L_PASS,L_TYPE,L_VDATE) values(@a,@b,@c,@d)";
            SqlParameter[] par ={
                                   new SqlParameter ("@a",lt.L_NAME),
                                   new SqlParameter ("@b",lt.L_PASS),
                                   new SqlParameter ("@c",lt.L_TYPE),
                                   new SqlParameter ("@d",lt.L_VDATE)
                               };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, par);
        }

        //修改管理员
        public int UpdateLecturer(Lecturer lt)
        {
            string sql = "update Lecturer set L_PASS=@c where L_ID=@a and L_NAME=@b";
            SqlParameter [] par={
                                    new SqlParameter ("@a",lt.L_ID),
                                    new SqlParameter("@b",lt.L_NAME),
                                    new SqlParameter ("@c",lt.L_PASS)
                                };

            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, par);
        }

        //删除管理员
        public int DeleteLecturer(Lecturer lt)
        {
            string sql = "delete from Lecturer where L_ID=@a and L_NAME=@b and L_TYPE=@c";
            SqlParameter[] par ={
                                    new SqlParameter ("@a",lt.L_ID),
                                    new SqlParameter("@b",lt.L_NAME),
                                    new SqlParameter("@c",lt.L_TYPE)
                                };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, par);
        }
        #endregion

        //查询管理员
        public List<Lecturer > SelectLecturer(Lecturer lt)
        {
            string sql = "select * from Lecturer where L_NAME=@a and L_PASS=@b";
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@a",lt.L_NAME),
                new SqlParameter("@b",lt.L_PASS)
            };
            List<Lecturer> llt = new List<Lecturer>();
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, System.Data.CommandType.Text, par);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    lt.L_ID = Convert.ToInt32(sdr["L_ID"].ToString());
                    lt.L_TYPE = Convert.ToInt32(sdr["L_TYPE"].ToString());
                    lt.L_VDATE = Convert.ToDateTime(sdr["L_VDATE"].ToString());
                    lt.L_NAME = sdr["L_NAME"].ToString();
                    lt.L_PASS = sdr["L_PASS"].ToString();
                    llt.Add(lt);
                }
            }
            sdr.Close();
            return llt;
        }
        //查询所有管理员并输出到gridview控件
        public List<Lecturer> Select()
        {
            string sql = "select * from Lecturer";
            List<Lecturer> llt = new List<Lecturer>();
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, System.Data.CommandType.Text, null);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    Lecturer lt = new Lecturer();
                    lt.L_ID = Convert.ToInt32(sdr["L_ID"].ToString());
                    lt.L_TYPE = Convert.ToInt32(sdr["L_TYPE"].ToString());
                    lt.L_VDATE = Convert.ToDateTime(sdr["L_VDATE"].ToString());
                    lt.L_NAME = sdr["L_NAME"].ToString();
                    lt.L_PASS = sdr["L_PASS"].ToString();
                    llt.Add(lt);
                }
            }
            sdr.Close();
            return llt;
        }
        //管理员登录
        public bool log(string name,string pass)
        {
            string sql = "select L_NAME,L_PASS from Lecturer where L_NAME=@a and L_PASS=@b";
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@a",name),
                new SqlParameter("@b",pass)
            };
            
            if(SQLHelper.ExecuteReader(sql, System.Data.CommandType.Text, par).HasRows)
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
