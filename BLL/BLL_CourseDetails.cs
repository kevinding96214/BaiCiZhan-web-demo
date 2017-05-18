using BaiCiZhanDAL;
using BaiCiZhanModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiCiZhanBLL
{
    public class BLL_CourseDetails
    {
        DAL_CourseDetails dd = new DAL_CourseDetails();

        public int AddCourseDetails(CourseDetails cd)
        {
            return dd.AddCourseDetails(cd);
        }

        public int DeleteCourseDetails(int id)
        {
            return dd.DeleteCourseDetails(id);
        }

        public List<CourseDetails> SeleteCourseDetails()
        {
            return dd.SeleteCourseDetails();
        }
        public int total(Coures c)
        {
            return dd.total(c);
        }
    }
}
