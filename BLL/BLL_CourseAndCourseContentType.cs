using BaiCiZhanDAL;
using BaiCiZhanModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiCiZhanBLL
{
    public class BLL_CourseAndCourseContentType
    {
        DAL_CourseAndCourseContentType dcct = new DAL_CourseAndCourseContentType();
        public List<CourseAndCourseContentType> GetAll()
        {
            return dcct.GetAll();
        }
    }
}
