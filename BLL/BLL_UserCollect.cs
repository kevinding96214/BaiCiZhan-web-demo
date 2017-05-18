using BaiCiZhanDAL;
using BaiCiZhanModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiCiZhanBLL
{
    public class BLL_UserCollect
    {
        DAL_UserCollect duc = new DAL_UserCollect();

        public int AddUserCollect(UserCollect uc)
        {
            return duc.AddUserCollect(uc);
        }

        public int DeleteUserCollect(int id)
        {
            return duc.DeleteUserCollect(id);
        }

        public int UpdateUserCollect(UserCollect uc)
        {
            return duc.UpdateUserCollect(uc);
        }

        public List<UserCollect>SelectUserCollect(int id)
        {
            return duc.SeleteUserCollect(id);
        }
    }
}
