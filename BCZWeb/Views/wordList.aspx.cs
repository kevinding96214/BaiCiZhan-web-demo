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
    public partial class wordList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL_CourseDetails bcd = new BLL_CourseDetails();
            list.DataSource = bcd.SeleteCourseDetails();
            list.DataBind();
        }

        protected void list_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            list.PageIndex = e.NewPageIndex;
            list.DataBind();
        }
    }
}