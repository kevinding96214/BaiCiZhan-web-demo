using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaiCiZhanBLL;
using BaiCiZhanModel;
using System.Data.SqlClient;
using System.Web.Security;

namespace BCZWeb.Views
{
    public partial class addAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                addtype.Items.Clear();
                deltype.Items.Clear();
                deltype.Items.Insert(0, new ListItem("请选择类别", "0"));
                addtype.Items.Insert(0, new ListItem("请选择类别", "0"));
                string connStr = "Server=KEVINDING; Database=BczQg; uid=sa; pwd=1111";
                string sql = "select LT_NAME from LecturerType";
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                SqlCommand con = new SqlCommand(sql, conn);
                con.CommandType = System.Data.CommandType.Text;
                SqlDataReader sdr = con.ExecuteReader();
                while (sdr.Read())
                {
                    addtype.Items.Add(sdr["LT_NAME"].ToString());
                    deltype.Items.Add(sdr["LT_NAME"].ToString());
                }
                BLL_Lecturer bl = new BLL_Lecturer();
                list.DataSource = bl.Select();
                list.DataBind();
        }

        protected void del_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_Lecturer del = new BLL_Lecturer();
                Lecturer lt = new Lecturer();
                lt.L_ID = Convert.ToInt32(aid.Text);
                lt.L_NAME = daname.Text;
                lt.L_TYPE = deltype.SelectedIndex;
                if (del.DeleteLecturer(lt) > 0)
                {
                    Response.Write(@"<script>alert('删除成功！');</script>");
                }
                else
                {
                    Response.Write(@"<script>alert('删除失败！');history.go(-1);</script>");
                }
            }
            catch
            {
                Response.Write(@"<script>alert('删除失败！');history.go(-1);</script>");
            }
        }

        protected void add_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_Lecturer add = new BLL_Lecturer();
                Lecturer lt = new Lecturer();
                lt.L_NAME = aname.Text;
                lt.L_PASS = FormsAuthentication.HashPasswordForStoringInConfigFile(apwd.Text, "MD5");
                lt.L_TYPE = addtype.SelectedIndex;
                lt.L_VDATE = DateTime.Now;
                if (add.AddLecturer(lt) > 0)
                {
                    Response.Write(@"<script>alert('添加成功！');</script>");
                }
                else
                {
                    Response.Write("<script>alert('添加失败');history.go(-1);</script>");
                }
            }
            catch
            {
                Response.Write(@"<script>alert('添加失败！');history.go(-1);</script>");
            }
        }
    }
}