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
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL_Coures bc = new BLL_Coures();
            list.DataSource = bc.SeleteCoures();
            list.DataBind();
            
        }

        protected void id_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            UserCollect uc = new UserCollect();
            Coures c = new Coures();
            BLL_Coures bc = new BLL_Coures();
            BLL_UserCollect bu = new BLL_UserCollect();
            Button btn = (Button)e.CommandSource;
            if (btn.Text == "添加该计划")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                string ew = ((TextBox)(this.list.FindControl("ew"))).Text.Trim();
                bc.select(id);
                uc.C_ID = id;
                uc.UC_StartDay = DateTime.Now;
                uc.UC_EveWord = Convert.ToInt32(ew);
                Response.Write("<script>alert('该计划添加成功！');</script>");
            }
            else if (btn.Text == "删除该计划")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                bu.DeleteUserCollect(id);
                Response.Write("<script>alert('该计划删除成功！');</script>");
            }
        }
    }
}