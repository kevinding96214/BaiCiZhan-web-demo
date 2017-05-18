<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userProf.aspx.cs" Inherits="BCZWeb.Views.userProf" %>

<%@ Register Src="~/Views/head.ascx" TagPrefix="uc1" TagName="head" %>
<%@ Register Src="~/Views/footer.ascx" TagPrefix="uc1" TagName="footer" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>百词斩</title>
    <link href="../Content/layout.css" rel="stylesheet" type="text/css" />
    <link rel="icon" href="../Image/b_icon2.ico" type="image/x-icon" />
    <link rel="shortcut icon" href="../Image/b_icon2.ico" type="image/x-icon" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        form{
            margin-top:100px;
            width:100%;
            font-size:18px;
        }
        #photo{
            width:150px;
        }
        #fileup{
            margin:0 auto;
        }
        #save{
            width:200px;
        }
    </style>
</head>
<body>
<uc1:head runat="server" ID="head" />
    <form id="form1" runat="server" class="text-center">
    <div>
        <p><asp:Image ID="photo" runat="server" /></p>
        <h1>您好！<%=Session["name"] %></h1>
        <p><asp:FileUpload ID="fileup" runat="server" /></p>
        <p>用户ID：<asp:Label ID="id" runat="server" /></p>
        <p>用户账号：<asp:TextBox ID="name" runat="server" CssClass="text-info" /></p>
        <p>设置密码：<asp:TextBox ID="pass" runat="server" TextMode="Password" CssClass="text-info" /></p>
        <p>电子邮箱：<asp:TextBox ID="email" runat="server" TextMode="Email" CssClass="text-info" /></p>
        <p>注册时间：<asp:Label ID="date" runat="server" /></p>
        <p><asp:Button ID="save" runat="server" Text="保存修改" CssClass="btn btn-info" OnClick="save_Click" /></p>
    </div>
    </form>
    <uc1:footer runat="server" ID="footer" />
</body>
</html>
