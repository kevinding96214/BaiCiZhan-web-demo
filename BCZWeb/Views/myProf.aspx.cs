using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaiCiZhanBLL;
using BaiCiZhanModel;
using BCZWeb;
using System.Web.Security;

namespace BCZWeb.Views
{
    public partial class myProf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BCZWeb.Views.adminLog al = new BCZWeb.Views.adminLog();
            Lecturer lt = new Lecturer();
            BLL_Lecturer blt = new BLL_Lecturer();
            lt.L_ID = lt.L_ID;
            lt.L_NAME = al.Session["name"].ToString();
            lt.L_PASS = al.Session["pass"].ToString();
            blt.SelectLecturer(lt);
            adminId.Text = lt.L_ID.ToString();
            adminType.Text = lt.L_TYPE.ToString();
            time.Text = lt.L_VDATE.ToString();
            account.Text = al.Session["name"].ToString();

        }
        
        protected void save_Click(object sender, EventArgs e)
        {
            try
            {
                Lecturer lt = new Lecturer();
                lt.L_ID = Convert.ToInt32(adminId.Text);
                lt.L_NAME = account.Text;
                lt.L_PASS = FormsAuthentication.HashPasswordForStoringInConfigFile(passwd.Text, "MD5");
                BLL_Lecturer update = new BLL_Lecturer();
                update.UpdateLecturer(lt);
                if (update.UpdateLecturer(lt) > 0)
                {
                    Response.Write(@"<script>alert('更新成功！');</script>");
                }
                else
                {
                    Response.Write(@"<script>alert('更新失败！');history.go(-1);</script>");
                }
            }
            catch
            {
                Response.Write(@"<script>alert('更新失败！');history.go(-1);</script>");
            }
        }
    }
}