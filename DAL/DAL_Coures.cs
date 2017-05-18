using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaiCiZhanModel;
using System.Data.SqlClient;
using BaiCiZhanHelper;

namespace BaiCiZhanDAL
{
    public class DAL_Coures
    {
        #region 增、改、删
        //添加单词包
        public int AddCoures(Coures cr)
        {
            string sql = "insert into Coures values(@a,@b,@c)";
            SqlParameter[] par ={
                                   new SqlParameter ("@a",cr.C_NAME),
                                   new SqlParameter ("@b",cr.CCT_ID),
                                   new SqlParameter ("@c",cr.C_RELEASEDATE),
                               };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, par);
        }

        //修改单词包
        public int UpdateCoures(Coures cr)
        {
            string sql = @"update Coures set C_NAME=@b where C_ID=@a";
            SqlParameter[] par ={
                                    new SqlParameter ("@a",cr.C_ID),
                                    new SqlParameter ("@b",cr.C_NAME),
                                };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, par);
        }
        
        // 删除单词包
        public int DeleteCoures(Coures cr)
        {
            string sql = "delete from Coures where C_ID=@a and C_NAME=@b";
            SqlParameter[] par = new SqlParameter[] {
                new SqlParameter ("@a",cr.C_ID),
                new SqlParameter("@b",cr.C_NAME)
            };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, par);
        }
        #endregion

        //查询所有单词包
        public List<Coures> SeleteCoures()
        {
            string sql = "select * from Coures";
            List<Coures> lc = new List<Coures>();
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, System.Data.CommandType.Text, null);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    Coures cr = new Coures();
                    cr.C_ID = Convert.ToInt32(sdr["C_ID"].ToString());
                    cr.C_NAME = sdr["C_NAME"].ToString();
                    cr.CCT_ID = Convert.ToInt32(sdr["CCT_ID"].ToString());
                    cr.C_RELEASEDATE = Convert.ToDateTime (sdr["C_RELEASEDATE"].ToString());
                    cr.C_VOCABULARY = Convert.ToDouble(sdr["C_VOCABULARY"].ToString());
                    lc.Add (cr);
                }
            }
            sdr.Close ();
            return lc;
        }
        public List<Coures> select(int id)
        {
            string sql = "select * from Coures where C_ID=@ID";
            Coures cr = new Coures();
            List<Coures> lc = new List<Coures>();
            SqlParameter[] par =
            {
                new SqlParameter("@ID",id),
            };
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, System.Data.CommandType.Text, par);
            while (sdr.Read())
            {
                cr.C_ID = Convert.ToInt32(sdr["C_ID"].ToString());
                cr.C_NAME = sdr["C_NAME"].ToString();
                cr.CCT_ID = Convert.ToInt32(sdr["CCT_ID"].ToString());
                cr.C_RELEASEDATE = Convert.ToDateTime(sdr["C_RELEASEDATE"].ToString());
                cr.C_VOCABULARY = Convert.ToDouble(sdr["C_VOCABULARY"].ToString());
                lc.Add(cr);
            }
            sdr.Close();
            return lc;
        }
    }
}
