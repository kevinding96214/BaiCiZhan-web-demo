<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addAdmin.aspx.cs" Inherits="BCZWeb.Views.addAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no"/>
    <title>百词斩管理平台</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        body{
            margin:0;
            padding:20px;
            background:url("../Image/abg.jpg") no-repeat fixed;
            background-size:cover;
            text-shadow:0 0 1px #fff;
        }
        #form1{
            text-align:center;
            margin-top:14%;
        }
        #addadmin, #rmadmin {
            margin:0 auto;
        }
        #add, #del {
            width: 300px;
            margin-top: 20px;
        }
        #addtype,#deltype{
            width:175px;
            height:25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" method="post">
        <div class="row center-block" >
        <div id="addadmin" class="col-md-6">
            <p>管理员账号：<asp:TextBox ID="aname" runat="server" CssClass="text-info" /></p>
            <p>管理员密码：<asp:TextBox ID="apwd" runat="server" TextMode="Password" CssClass="text-info" /></p>
            <p>管理员类型：<asp:DropDownList ID="addtype" runat="server" AutoPostBack="false"></asp:DropDownList></p>
            <p><asp:Button ID="add" runat="server" Text="新增管理员" CssClass="btn btn-success" OnClick="add_Click" /></p>
        </div>
        <div id="rmadmin" class="col-md-6">
            <p>管理员的ID：<asp:TextBox ID="aid" runat="server" CssClass="text-info" /></p>
            <p>管理员账号：<asp:TextBox ID="daname" runat="server" CssClass="text-info" /></p>
            <p>管理员类型：<asp:DropDownList ID="deltype" runat="server" AutoPostBack="false"></asp:DropDownList></p>
            <p><asp:Button ID="del" runat="server" Text="删除管理员" CssClass="btn btn-danger" OnClick="del_Click" /></p>
        </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:GridView ID="list" runat="server" CssClass="table table-hover text-center" HeaderStyle-HorizontalAlign="Center" />
            </div>
        </div>
    </form>
</body>
</html>
