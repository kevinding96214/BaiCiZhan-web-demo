using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiCiZhanModel
{

    public class UserCollect
    {
        private int uC_ID;
        public int UC_ID
        {
            get { return uC_ID; }
            set { uC_ID = value; }
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

        private int uC_EveWord;
        public int UC_EveWord
        {
            get { return uC_EveWord; }
            set { uC_EveWord = value; }
        }

        private int uC_ComDay;
        public int UC_ComDay
        {
            get { return uC_ComDay; }
            set { uC_ComDay = value; }
        }

        private DateTime uC_StartDay;
        public DateTime UC_StartDay
        {
            get { return uC_StartDay; }
            set { uC_StartDay = value; }
        }

        private DateTime uS_EndDay;
        public DateTime US_EndDay
        {
            get { return uS_EndDay; }
            set { uS_EndDay = value; }
        }

        private bool uC_isRead;
        public bool UC_isRead
        {
            get { return uC_isRead; }
            set { uC_isRead = value; }
        }
    }
}
