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
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nowYear = DateTime.Now.Year.ToString();
            nYear.Text = nowYear;
        }

        protected void log_Click(object sender, EventArgs e)
        {
            string name = account.Text;
            string pwd = FormsAuthentication.HashPasswordForStoringInConfigFile(passwd.Text, "MD5");
            BLL_Users log = new BLL_Users();
            log.log(name, pwd);
            if (log.log(name, pwd))
            {
                Response.Write("<script>window.location.href ='userProf.aspx';</script>");
                Session["name"] = account.Text;
                Session["pass"] = FormsAuthentication.HashPasswordForStoringInConfigFile(passwd.Text, "MD5");
            }
            else
            {
                Response.Write(@"<script>alert('用户名或密码错误！');history.go(-1);</script>");
            }

        }

        protected void sig_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.location.href ='sign.aspx';</script>");
        }
    }
}