using BaiCiZhanDAL;
using BaiCiZhanModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiCiZhanBLL
{
    public class BLL_CourseContentType
    {
        DAL_CourseContentType dct = new DAL_CourseContentType();

        public int AddCourseContentType(CourseContentType cct)
        {
            return dct.AddCourseContentType(cct);
        }

        public int UpdateCourseContentType(CourseContentType cct)
        {
            return dct.UpdateCourseContentType(cct);
        }

        public int DeleteCourseContentType(int id)
        {
            return dct.DeleteCourseContentType(id);
        }

        public List<CourseContentType> SeleteCourseContentType()
        {
            return dct.SeleteCourseContentType();
        }
    }
}
