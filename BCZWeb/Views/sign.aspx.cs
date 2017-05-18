using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using BaiCiZhanBLL;
using BaiCiZhanModel;

namespace BCZWeb.Views
{
    public partial class sign : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ok_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_Users bu = new BLL_Users();
                Users us = new Users();
                us.U_NAME = name.Text;
                us.U_PASSWORD = FormsAuthentication.HashPasswordForStoringInConfigFile(pass.Text, "MD5");
                us.U_EMAIL = email.Text;
                us.U_REGISTERTIME = DateTime.Now.ToLocalTime();
                us.U_IMG = "../Image/logo.png";
                if (bu.AddUsers(us) > 0)
                {
                    Response.Write("<script>alert('注册成功！');window.location.href='index.aspx';</script>");
                }
                else
                {
                    Response.Write("<script>alert('注册失败！');history.go(-1);</script>");
                }
            }
            catch
            {
                Response.Write("<script>alert('注册失败！');history.go(-1);</script>");
            }
        }
    }
}