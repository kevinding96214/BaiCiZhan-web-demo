using BaiCiZhanDAL;
using BaiCiZhanModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiCiZhanBLL
{
    public class BLL_Users
    {
        DAL_Users dus = new DAL_Users();

        public int AddUsers(Users us)
        {
            return dus.AddUsers(us);
        }

        public int DeleteUsers(Users us)
        {
            return dus.DeleteUsers(us);
        }

        public int UpdateUsers(Users us)
        {
            return dus.UpdateUsers(us);
        }

        public List<Users> SelectUsers()
        {
            return dus.SeleteUsers();
        }
        //查询当前用户资料
        public List<Users> select(Users u)
        {
            return dus.select(u);
        }
        public bool log(string name,string pass)
        {
            return dus.log(name, pass);
        }
    }
}
