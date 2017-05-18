using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiCiZhanModel
{
    /// <summary>
    /// 单词包单词类型
    /// </summary>
    public class CourseAndCourseContentType
    {
        private int cCT_ID;
        public int CCT_ID
        {
            get { return cCT_ID; }
            set { cCT_ID = value; }
        }

        private string cCT_NAME;
        public string CCT_NAME
        {
            get { return cCT_NAME; }
            set { cCT_NAME = value; }
        }

        private string cCT_DESC;
        public string CCT_DESC
        {
            get { return cCT_DESC; }
            set { cCT_DESC = value; }
        }

        private int c_ID;
        public int C_ID
        {
            get { return c_ID; }
            set { c_ID = value; }
        }

        private string c_NAME;
        public string C_NAME
        {
            get { return c_NAME; }
            set { c_NAME = value; }
        }

        private DateTime c_RELEASEDATE;
        public DateTime C_RELEASEDATE
        {
            get { return c_RELEASEDATE; }
            set { c_RELEASEDATE = value; }
        }

        private double c_VOCABULARY;
        public double C_VOCABULARY
        {
            get { return c_VOCABULARY; }
            set { c_VOCABULARY = value; }
        }
    }
}
