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
    public partial class userProf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BCZWeb.Views.index index = new BCZWeb.Views.index();
            Users u = new Users();
            u.U_NAME = index.Session["name"].ToString();
            u.U_PASSWORD = index.Session["pass"].ToString();
            BLL_Users bu = new BLL_Users();
            bu.select(u);
            photo.ImageUrl = u.U_IMG;
            id.Text = u.U_ID.ToString();
            name.Text = u.U_NAME;
            pass.Text = u.U_PASSWORD;
            email.Text = u.U_EMAIL;
            date.Text = u.U_REGISTERTIME.ToString();
        }
        
        protected void save_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Server.MapPath(@"../Image/User/" + fileup.FileName);
                fileup.SaveAs(path);
                photo.ImageUrl = @"../Image/User/" + fileup.FileName;
                BLL_Users bu = new BLL_Users();
                Users u = new Users();
                u.U_ID = Convert.ToInt32(id.Text);
                u.U_IMG = photo.ImageUrl;
                u.U_NAME = name.Text;
                u.U_PASSWORD = FormsAuthentication.HashPasswordForStoringInConfigFile(pass.Text, "MD5");
                u.U_EMAIL = email.Text;
                bu.UpdateUsers(u);
                if (bu.UpdateUsers(u) > 0)
                {
                    Response.Write("<script>alert('修改成功！');</script>");
                }
                else
                {
                    Response.Write("<script>alert('修改失败！');history.go(-1);</script>");
                }
            }
            catch
            {
                Response.Write("<script>alert('修改失败！');history.go(-1);</script>");
            }

        }
    }
}