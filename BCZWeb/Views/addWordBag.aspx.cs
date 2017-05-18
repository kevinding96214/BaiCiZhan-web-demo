using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaiCiZhanBLL;
using BaiCiZhanModel;
using System.Data.SqlClient;

namespace BCZWeb.Views
{
    public partial class addWordBag : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            wbtype.Items.Clear();
            wbtype.Items.Insert(0, new ListItem("请选择类别", "0"));
            date.Text = DateTime.Now.ToString();
            string connStr = "Server=KEVINDING; Database=BczQg; uid=sa; pwd=1111";
            string sql = "select CCT_NAME from CourseContentType";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand con = new SqlCommand(sql, conn);
            con.CommandType = System.Data.CommandType.Text;
            SqlDataReader sdr = con.ExecuteReader();
            while (sdr.Read())
            {
                wbtype.Items.Add(sdr["CCT_NAME"].ToString());
            }
            
        }

        protected void save_Click(object sender, EventArgs e)
        {
            try
            {
                Coures cs = new Coures();
                cs.C_NAME = wbname.Text;
                cs.CCT_ID = wbtype.SelectedIndex;
                cs.C_RELEASEDATE = DateTime.Now;
                BLL_Coures save = new BLL_Coures();
                save.AddCoures(cs);
                if (save.AddCoures(cs) > 0)
                {
                    Response.Write(@"<script>alert('保存成功！'); </script>");
                }
                else
                {
                    Response.Write(@"<script>alert('保存失败！');history.go(-1);</script>");
                }
            }
            catch
            {
                Response.Write(@"<script>alert('保存失败！'); history.go(-1);</script>");
            }
        }
    }
}