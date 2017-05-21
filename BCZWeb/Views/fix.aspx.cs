using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaiCiZhanBLL;
using BaiCiZhanModel;

namespace BCZWeb.Views
{
    public partial class fix : System.Web.UI.Page
    {
        static BCZWeb.Views.userProf up = new userProf();
        protected void Page_Load(object sender, EventArgs e)
        {
            Coures c = new Coures();
            BLL_Coures bc = new BLL_Coures();
            List<Coures> lc = bc.SeleteCoures();
            for (int i = 0; i < bc.SeleteCoures().Count; i++)
            {
                Button btn = new Button();
                btn.Width = 100;
                btn.Height = 100;
                btn.ID = Convert.ToString(lc[i].C_ID);
                btn.CssClass = "book btn btn-info";
                btn.Text = lc[i].C_NAME;
                btn.Click += Btn_Click;
                panel.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button t = (Button)sender;
            Coures c = new Coures();
            BLL_Coures bc = new BLL_Coures();
            bname.Text = t.Text;
            bid.Text = t.ID;
        }

        protected void add_Click(object sender, EventArgs e)
        {
            UserCollect uc = new UserCollect();
            BLL_UserCollect buc = new BLL_UserCollect();
            uc.U_ID = up.Session["id"].ToString();
            uc.C_ID = Convert.ToInt32(bid.Text);
            uc.UC_EveWord = Convert.ToInt32(ew.Text);
            uc.UC_StartDay = Convert.ToDateTime(sday.Value);
            uc.US_EndDay = Convert.ToDateTime(eday.Value);
            uc.UC_ComDay = Convert.ToDateTime(eday.Value).Subtract(Convert.ToDateTime(sday.Value)).Days;

            if (buc.AddUserCollect(uc) > 0)
            {
                Response.Write("<script>alert('添加成功！');</script>");
            }
            else
            {
                Response.Write("<script>alert('添加失败！');</script>");
            }
        }

        protected void del_Click(object sender, EventArgs e)
        {
            userProf up = new userProf();
            BLL_UserCollect buc = new BLL_UserCollect();

            if (buc.DeleteUserCollect(Convert.ToInt32(up.Session["id"].ToString())) > 0)
            {
                Response.Write("<script>alert('删除成功！');</script>");
            }
            else
            {
                Response.Write("<script>alert('删除失败！');</script>");
            }
        }
    }
}