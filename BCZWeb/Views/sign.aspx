<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sign.aspx.cs" Inherits="BCZWeb.Views.sign" %>

<%@ Register Src="~/Views/head.ascx" TagPrefix="uc1" TagName="head" %>
<%@ Register Src="~/Views/footer.ascx" TagPrefix="uc1" TagName="footer" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>百词斩</title>
    <link href="../Content/layout.css" rel="stylesheet" type="text/css" />
    <link rel="icon" href="../Image/b_icon2.ico" type="image/x-icon" />
    <link rel="shortcut icon" href="../Image/b_icon2.ico" type="image/x-icon" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        form{
            width:100%;
            height:100%;
            margin:0 auto;
            margin-top:100px;
            padding-top:8%;
        }
        #name,#pass,#email{
            width:300px;
            height:30px;
        }
        #ok,#reset{
            width:150px;
            height:30px;
            margin:20px 10px;
        }
    </style>
</head>
<body>
    <uc1:head runat="server" ID="head" />
    <form id="form1" runat="server" method="post" class="text-center">
        <h3>用户账号</h3>
        <p><asp:TextBox ID="name" runat="server" /></p>
        <h3>用户密码</h3>
        <asp:TextBox ID="pass" runat="server" TextMode="Password" />
        <h3>用户邮箱</h3>
        <asp:TextBox ID="email" runat="server" TextMode="Email" />
        <p>
            <asp:Button ID="ok" runat="server" CssClass="btn btn-info" Text="注册" OnClick="ok_Click" />
            <input type="reset" id="reset" value="重置" class="btn btn-warning" />
        </p>
    </form>
    <uc1:footer runat="server" ID="footer" />
</body>
</html>
