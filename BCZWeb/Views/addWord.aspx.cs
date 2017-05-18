using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using BaiCiZhanModel;
using BaiCiZhanBLL;

namespace BCZWeb.Views
{
    public partial class addWord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void upload1_Click(object sender, EventArgs e)
        {
            string path = Server.MapPath("../Image/Word/" + tpic.FileName);
            tpic.SaveAs(path);
            wpic1.ImageUrl = "../Image/Word/" + tpic.FileName;
            wpic1.AlternateText = "正确图片地址";
        }

        protected void upload2_Click(object sender, EventArgs e)
        {
            string path = Server.MapPath("../Image/Word/" + fpic1.FileName);
            fpic1.SaveAs(path);
            wpic2.ImageUrl = "../Image/Word/" + fpic1.FileName;
            wpic2.AlternateText = "错误图片地址";
        }

        protected void upload3_Click(object sender, EventArgs e)
        {
            string path = Server.MapPath("../Image/Word/" + fpic2.FileName);
            fpic2.SaveAs(path);
            wpic3.ImageUrl = "../Image/Word/" + fpic2.FileName;
            wpic3.AlternateText = "错误图片地址";
        }

        protected void upload4_Click(object sender, EventArgs e)
        {
            string path = Server.MapPath("../Image/Word/" + fpic3.FileName);
            fpic3.SaveAs(path);
            wpic4.ImageUrl = "../Image/Word/" + fpic3.FileName;
            wpic3.AlternateText = "错误图片地址";
        }

        protected void tpic_DataBinding(object sender, EventArgs e)
        {
            wpic1.ImageUrl = "../Image/Word/" + tpic.FileName;
            wpic1.AlternateText = "正确图片地址";
        }

        protected void save_Click(object sender, EventArgs e)
        {
            try
            {
                CourseDetails cd = new CourseDetails();
                cd.C_ID = Convert.ToInt32(wbid.Text);
                cd.CD_NAME = wname.Text;
                cd.CD_YINBIAO = wyinbiao.Text;
                cd.CD_Mean = wmean.Text;
                cd.CD_SENEng = wen.Text;
                cd.CD_SENChi = wcn.Text;
                cd.CD_VIDEO = wvideo.Text;
                cd.CD_RIGHT_PIC = "../Image/Word/" + tpic.FileName;
                cd.CD_WRONG_PIC1 = "../Image/Word/" + fpic1.FileName;
                cd.CD_WRONG_PIC2 = "../Image/Word/" + fpic2.FileName;
                cd.CD_WRONG_PIC3 = "../Image/Word/" + fpic3.FileName;
                BLL_CourseDetails add = new BLL_CourseDetails();
                add.AddCourseDetails(cd);
                if (add.AddCourseDetails(cd) > 0)
                {
                    Response.Write(@"<script>alert('保存成功！');</script>");
                }
                else
                {
                    Response.Write(@"<script>alert('保存失败！');history.go(-1);</script>");
                }
            }
            catch
            {
                Response.Write(@"<script>alert('保存失败！');histoy.go(-1);</script>");
            }
        }
    }
}