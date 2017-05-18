using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiCiZhanModel
{

    public class UserDownload
    {
        private int uD_ID;
        public int UD_ID
        {
            get { return uD_ID; }
            set { uD_ID = value; }
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

        private int cD_ID;
        public int CD_ID
        {
            get { return cD_ID; }
            set { cD_ID = value; }
        }

        private bool cD_IsBei;
        public bool CD_IsBei
        {
            get { return cD_IsBei; }
            set { cD_IsBei = value; }
        }

        private bool uD_CUT;
        public bool UD_CUT
        {
            get { return uD_CUT; }
            set { uD_CUT = value; }
        }

        private DateTime uD_STUDY;
        public DateTime UD_STUDY
        {
            get { return uD_STUDY; }
            set { uD_STUDY = value; }
        }

        private DateTime uD_Review;
        public DateTime UD_Review
        {
            get { return uD_Review; }
            set { uD_Review = value; }
        }

        private int uD_DATE;
        public int UD_DATE
        {
            get { return uD_DATE; }
            set { uD_DATE = value; }
        }

        private string uD_Status;
        public string UD_Status
        {
            get { return uD_Status; }
            set { uD_Status = value; }
        }
    }
}
