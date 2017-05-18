using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiCiZhanModel
{
    public class Lecturer
    {
        private int l_ID;
        public int L_ID
        {
            get { return l_ID; }
            set { l_ID = value; }
        }

        private int l_TYPE;
        public int L_TYPE
        {
            get { return l_TYPE; }
            set { l_TYPE = value; }
        }

        private DateTime l_VDATE;
        public DateTime L_VDATE
        {
            get { return l_VDATE; }
            set { l_VDATE = value; }
        }

        private string l_NAME;
        public string L_NAME
        {
            get { return l_NAME; }
            set { l_NAME = value; }
        }

        private string l_PASS;
        public string L_PASS
        {
            get { return l_PASS; }
            set { l_PASS = value; }
        }
    }
}
