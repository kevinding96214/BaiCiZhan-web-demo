<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addWordBag.aspx.cs" Inherits="BCZWeb.Views.addWordBag" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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
            margin-top:14%;
        }
        #save{
            width:300px;
            margin-top:20px;
        }
        #wbtype{
            width:175px;
            height:25px;
        }
    </style>
</head>
<body class="text-center">
    <form id="form1" runat="server">
    <div>
        <p>词包名称：<asp:TextBox ID="wbname" runat="server" CssClass="text-info" /></p>
        <p>词包类型：<asp:DropDownList ID="wbtype" runat="server">
            <asp:ListItem Text="--请选择单词包类型--" />
                </asp:DropDownList></p>
        <p>编辑时间：<asp:Label ID="date" runat="server" /></p>
        <p><asp:Button ID="save" runat="server" Text="保存" CssClass="btn btn-info" OnClick="save_Click" /></p>
        </div>
    </form>
</body>
</html>