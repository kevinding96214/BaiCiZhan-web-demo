using BaiCiZhanModel;
using BaiCiZhanDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiCiZhanBLL
{
    public class BLL_Lecturer
    {
        public static DAL_Lecturer lr = new DAL_Lecturer();
        //添加管理员
        public int AddLecturer(Lecturer lt)
        {
            return lr.AddLecturer(lt);
        }

        //修改管理员密码
        public int UpdateLecturer(Lecturer lt)
        {
            return lr.UpdateLecturer(lt);
        }

        //删除管理员
        public int DeleteLecturer(Lecturer lt)
        {
            return lr.DeleteLecturer(lt);
        }

        //查询管理员
        public void SelectLecturer(Lecturer lt)
        {
            lr.SelectLecturer(lt);
        }
        //查询所有管理员并输出到gridview
        public List<Lecturer> Select()
        {
            return lr.Select();
        }
        //管理员登录
        public bool log(string name, string pass)
        {
            return lr.log(name, pass);
        }
    }
}
