using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BCZWeb.Views
{
    public partial class footer : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nowYear = DateTime.Now.Year.ToString();
            nYear.Text = nowYear;
        }
    }
}