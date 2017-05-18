using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiCiZhanModel
{

    public class UserActivity
    {
        private string uA_ID;
        public string UA_ID
        {
            get { return uA_ID; }
            set { uA_ID = value; }
        }

        private string u_ID;
        public string U_ID
        {
            get { return u_ID; }
            set { u_ID = value; }
        }

        private int c_ID;
        public int C_ID
        {
            get { return c_ID; }
            set { c_ID = value; }
        }

        private DateTime uA_DATE;
        public DateTime UA_DATE
        {
            get { return uA_DATE; }
            set { uA_DATE = value; }
        }

        private int uA_WordNum;
        public int UA_WordNum
        {
            get { return uA_WordNum; }
            set { uA_WordNum = value; }
        }
    }
}
