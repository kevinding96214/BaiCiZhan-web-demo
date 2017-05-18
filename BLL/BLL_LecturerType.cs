using BaiCiZhanDAL;
using BaiCiZhanModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiCiZhanBLL
{
    public class BLL_LecturerType
    {
        DAL_LecturerType dlt = new DAL_LecturerType();

        public int AddLectuerType(LecturerType lt)
        {
            return dlt.AddLecturerType(lt);
        }

        public int DeleteLecturerType(int id)
        {
            return dlt.DeleteLecturerType(id);
        }

        public int UpdateLecturerType(LecturerType lt)
        {
            return dlt.UpdateLecturerType(lt);
        }

        public List<LecturerType> SeleteLecturerType()
        {
            return dlt.SeleteLecturerType();
        }
    }
}
