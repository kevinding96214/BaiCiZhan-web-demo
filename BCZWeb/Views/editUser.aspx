<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editUser.aspx.cs" Inherits="BCZWeb.Views.editUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no"/>
    <title>百词斩管理平台</title>
    <link href="../Content/admin.css" rel="stylesheet" />
    <link rel="icon" href="../Image/b_icon2.ico" type="image/x-icon" />
    <link rel="shortcut icon" href="../Image/b_icon2.ico" type="image/x-icon" />
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
        #adduser, #rmuser {
            margin:0 auto;
        }
        #add, #del {
            width: 300px;
            margin-top: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" method="post">
        <div class="row center-block" >
            <div id="adduser" class="col-md-6">
    <p>用户名：<asp:TextBox ID="uname" runat="server" CssClass="text-info" /></p>
        <p>新密码：<asp:TextBox ID="upwd" runat="server" TextMode="Password" CssClass="text-info" /></p>
        <p><asp:Button ID="add" runat="server" Text="新增用户" CssClass="btn btn-success" OnClick="add_Click" /></p>
    </div>
        <div id="rmuser" class="col-md-6">
            <p>用户ID：<asp:TextBox ID="uid" runat="server" CssClass="text-info" /></p>
            <p>用户名：<asp:TextBox ID="duname" runat="server" CssClass="text-info" /></p>
            <p><asp:Button ID="del" runat="server" Text="删除用户" CssClass="btn btn-danger" OnClick="del_Click" /></p>
        </div>
        </div>
    <div class="row">
        <div class="col-md-12">
            <asp:GridView ID="list" runat="server" CssClass="table table-hover text-center" />
        </div>
    </div>
    </form>
</body>
</html>
