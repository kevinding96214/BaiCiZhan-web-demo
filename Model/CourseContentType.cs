using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiCiZhanModel
{

    public class CourseContentType
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
    }
}
