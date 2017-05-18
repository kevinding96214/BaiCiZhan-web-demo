using BaiCiZhanDAL;
using BaiCiZhanModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiCiZhanBLL
{
    public class BLL_UserActivity
    {
        DAL_UserActivity dua = new DAL_UserActivity();

        public int AddUserActivity(UserActivity ua)
        {
            return dua.AddUserActivity(ua);
        }

        public int DeleteUserActivity(string id)
        {
            return dua.DeleteUserActivity(id);
        }

        public int UpdateUserActivity(UserActivity ua)
        {
            return dua.UpdateUserActivity(ua);
        }

        public List<UserActivity> SelectUserActivity()
        {
            return dua.SeleteUserActivity();
        }
    }
}
