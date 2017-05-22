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
    public partial class editUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL_Users bu = new BLL_Users();
            list.DataSource = bu.SelectUsers();
            list.DataBind();
        }

        protected void add_Click(object sender, EventArgs e)
        {
            try
            {
                Users us = new Users();
                us.U_NAME = uname.Text;
                us.U_PASSWORD = FormsAuthentication.HashPasswordForStoringInConfigFile(upwd.Text, "MD5");
                us.U_IMG = "../Image/logo.png";
                us.U_EMAIL = "example@example.com";
                us.U_REGISTERTIME = DateTime.Now;
                BLL_Users add = new BLL_Users();
                if (add.AddUsers(us) > 0)
                {
                    Response.Write(@"<script>alert('添加成功！');</script>");
                }
                else
                {
                    Response.Write(@"<script>alert('添加失败！');history.go(-1);</script>");
                }
            }
            catch
            {
                Response.Write(@"<script>alert('添加失败！');history.go(-1);</script>");
            }
            
        }

        protected void del_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_UserCollect buc = new BLL_UserCollect();
                BLL_Users del = new BLL_Users();
                Users us = new Users();
                us.U_ID = Convert.ToInt32(uid.Text);
                us.U_NAME = duname.Text;
                buc.DeleteUserCollect(Convert.ToInt32(uid.Text));
                if (del.DeleteUsers(us) > 0)
                {
                    Response.Write(@"<script>alert('删除成功！');location.reload();</script>");
                    
                }
            }
            catch
            {
                Response.Write(@"<script>alert('删除失败！');history.go(-1);</script>");
            }
        }
    }
}