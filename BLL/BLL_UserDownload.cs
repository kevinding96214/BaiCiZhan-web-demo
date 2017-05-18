using BaiCiZhanDAL;
using BaiCiZhanModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiCiZhanBLL
{
    public class BLL_UserDownload
    {
        DAL_UserDownload dud = new DAL_UserDownload();

        public int AddUserDownload(UserDownload ud)
        {
            return dud.AddUserDownload(ud);
        }

        public int UpdateUserDownload(int id)
        {
            return dud.DeleteUserDownload(id);
        }

        public int UpdatUserDownload(UserDownload ud)
        {
            return dud.UpdateUserDownload(ud);
        }

        public List<UserDownload > SelectUserDownload()
        {
            return dud.SeleteUserDownload();
        }
    }
}
