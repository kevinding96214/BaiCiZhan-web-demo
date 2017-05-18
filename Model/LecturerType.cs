using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiCiZhanModel
{
    public class LecturerType
    {
        private int lT_ID;
        public int LT_ID
        {
            get { return lT_ID; }
            set { lT_ID = value; }
        }

        private string lT_NAME;
        public string LT_NAME
        {
            get { return lT_NAME; }
            set { lT_NAME = value; }
        }

        private string lT_DESC;
        public string LT_DESC
        {
            get { return lT_DESC; }
            set { lT_DESC = value; }
        }
    }
}
