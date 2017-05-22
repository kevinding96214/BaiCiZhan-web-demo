using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Speech;
using System.Speech.Synthesis;
using BaiCiZhanBLL;
using BaiCiZhanModel;

namespace BCZWeb.Views
{
    public partial class word : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //try
            //{
                if (Session["name"] == null)
                {
                    Response.Write("<script>alert('请先登录！');history.go(-1);</script>");
                }
                //SpeechSynthesizer tts = new SpeechSynthesizer();
                //tts.Speak("Hello");
                //tts.SpeakAsyncCancelAll();
                BCZWeb.Views.userProf up = new BCZWeb.Views.userProf();
                int id = Convert.ToInt32(up.Session["id"]);
                UserCollect uc = new UserCollect();
                BLL_UserCollect bu = new BLL_UserCollect();
                List<UserCollect> luc = bu.SelectUserCollect(id);
                BLL_Coures bc = new BLL_Coures();
                ucid.Text = luc[0].UC_ID.ToString();
                cid.Text = luc[0].C_ID.ToString();
                stime.Text = luc[0].UC_StartDay.ToShortDateString();
                etime.Text = luc[0].US_EndDay.ToShortDateString();
                sumday.Text = luc[0].UC_ComDay.ToString();
                surday.Text = Convert.ToDateTime(etime.Text).Subtract(DateTime.Now).Days.ToString();
                List<Coures> lc = bc.select(Convert.ToInt32(cid.Text));
                current.Text = lc[0].C_NAME;
            //}
            //catch
            //{
            //    Response.Redirect("fix.aspx");
            //}
        }

        //开始背单词
        protected void start_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.location.href='start.aspx';</script>");
        }
        //修改计划
        protected void fix_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.location.href='fix.aspx';</script>");
        }
    }
}