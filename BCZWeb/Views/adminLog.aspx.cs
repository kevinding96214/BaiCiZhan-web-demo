using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaiCiZhanBLL;
using BaiCiZhanModel;
using System.Web.Security;

namespace BCZWeb.Views
{
    public partial class adminLog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlog_Click(object sender, EventArgs e)
        {
            BLL_Lecturer log = new BLL_Lecturer();
            string pass = FormsAuthentication.HashPasswordForStoringInConfigFile(apwd.Text, "MD5");
            log.log(admin.Text, pass);
            if (log.log(admin.Text, pass))
            {
                Session["name"] = admin.Text;
                Session["pass"] = pass;
                Response.Write("<script>window.location.href ='admin.aspx';</script>");
            }
            else
            {
                Response.Write("<script>alert('用户名或密码错误！');history.go(-1);</script>");
            }
        }
    }
}