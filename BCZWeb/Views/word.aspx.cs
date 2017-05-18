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
            bu.SelectUserCollect(id);
            ucid.Text = uc.UC_ID.ToString();
            cid.Text = uc.C_ID.ToString();
            stime.Text = ((DateTime)uc.UC_StartDay).ToString();
            etime.Text = ((DateTime)uc.US_EndDay).ToString();
            sumday.Text = (uc.US_EndDay - uc.UC_StartDay).ToString();

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