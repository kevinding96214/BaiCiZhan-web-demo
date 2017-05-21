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
            BCZWeb.Views.index index = new BCZWeb.Views.index();
            if (Session["name"] == null)
            {
                Response.Write("<script>alert('请先登录！');history.go(-1);</script>");
            }
            //SpeechSynthesizer tts = new SpeechSynthesizer();
            //tts.Speak("Hello");
            //tts.SpeakAsyncCancelAll();
            int id = 7;
            UserCollect uc = new UserCollect();
            BLL_UserCollect bu = new BLL_UserCollect();
            List<UserCollect> luc = bu.SelectUserCollect(id);
            ucid.Text = luc[0].UC_ID.ToString();
            cid.Text = luc[0].C_ID.ToString();
            stime.Text = luc[0].UC_StartDay.ToShortDateString();
            etime.Text = luc[0].US_EndDay.ToShortDateString();
            sumday.Text = luc[0].UC_ComDay.ToString();
            surday.Text = Convert.ToDateTime(etime.Text).Subtract(DateTime.Now).Days.ToString();
        }

        //开始背单词
        protected void start_Click(object sender, EventArgs e)
        {

        }
        //修改计划
        protected void fix_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.location.href='fix.aspx';</script>");
        }
    }
}