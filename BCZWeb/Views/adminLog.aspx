<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminLog.aspx.cs" Inherits="BCZWeb.Views.adminLog" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no"/>
    <title>管理员登录</title>
    <link rel="icon" href="../Image/b_icon2.ico" type="image/x-icon" />
    <link rel="shortcut icon" href="../Image/b_icon2.ico" type="image/x-icon" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        body {
            background: url("../Image/adbg.jpg") fixed no-repeat;
            background-size:cover;
            margin:0;
            padding-top:16%;
            color:#fff;
            font-size:20px;
        }
        #form1 {
            width:300px;
            margin:0 auto;
        }
        .btn{
            width:100%;
            margin-top:50px;
        }
        #admin,#apwd{
            width:100%;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server" class="text-center">
            <p>管理员账号<asp:TextBox ID="admin" runat="server" class="text-info" placeholder="请输入账号" /></p>
            <p>管理员密码<asp:TextBox ID="apwd" TextMode="Password" runat="server" class="text-info" placeholder="请输入密码" /></p>
            <p><asp:Button ID="btnlog" runat="server" Text="登录后台" CssClass="btn btn-info" OnClick="btnlog_Click" /></p>
    </form>
</body>
</html>