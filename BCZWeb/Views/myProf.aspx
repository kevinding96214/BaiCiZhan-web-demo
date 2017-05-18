<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="myProf.aspx.cs" Inherits="BCZWeb.Views.myProf" %>

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
        #uphoto{
            width:150px;
            height:150px;
            border:1px #000 solid;
        }
        #save {
            width: 300px;
            margin-top: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" method="post">
    <div>
    <p>管理员ID：<asp:Label ID="adminId" runat="server" /></p>
    <p>管理类型：<asp:Label ID="adminType" runat="server" /></p>
    <p>任命时间：<asp:Label ID="time" runat="server" /></p>
    <p>管理账号：<asp:Label ID="account" runat="server" /></p>
    <p>更改密码：<asp:TextBox ID="passwd" runat="server" TextMode="Password" CssClass="text-info" /></p>
    <p><asp:Button ID="save" runat="server" Text="保存修改" CssClass="btn btn-info" OnClick="save_Click" /></p>
    </div>
    </form>
</body>
</html>
