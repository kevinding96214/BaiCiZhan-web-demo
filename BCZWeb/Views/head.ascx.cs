using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BCZWeb.Views
{
    public partial class layout : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BCZWeb.Views.index ind = new BCZWeb.Views.index();
            if (ind.Session["name"] != null && ind.Session["pass"] != null)
            {
                home.Text = "个人中心";
                home.NavigateUrl = "userProf.aspx";
            }
            else
            {
                home.Text = "首页";
                home.NavigateUrl = "index.aspx";
            }
        }
    }
}