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
    public partial class delWordBag : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL_Coures bc = new BLL_Coures();
            list.DataSource = bc.SeleteCoures();
            list.DataBind();
        }

        protected void del_Click(object sender, EventArgs e)
        {
            try
            {
                Coures cs = new Coures();
                cs.C_ID = Convert.ToInt32(wbid.Text);
                cs.C_NAME = wbname.Text;
                BLL_Coures del = new BLL_Coures();
                del.DeleteCoures(cs);
                if (del.DeleteCoures(cs) > 0)
                {
                    Response.Write(@"<script>alert('删除成功！');location.reload();</script>");
                }
                else
                {
                    Response.Write(@"<script>alert('删除失败！');history.go(-1);</script>");
                }
            }
            catch
            {
                Response.Write(@"<script>alert('删除失败！'); history.go(-1);</script>");
            }
        }
    }
}