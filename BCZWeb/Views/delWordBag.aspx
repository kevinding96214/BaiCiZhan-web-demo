<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="delWordBag.aspx.cs" Inherits="BCZWeb.Views.delWordBag" %>

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
        #del{
            width:300px;
            margin-top:20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="text-center">
        <p>单词包ID：<asp:TextBox ID="wbid" runat="server" CssClass="text-info" /></p>
        <p>词包名称：<asp:TextBox ID="wbname" runat="server" CssClass="text-info" /></p>
        <p><asp:Button ID="del" runat="server" Text="删除" CssClass="btn btn-danger" OnClick="del_Click" /></p>
        <p><asp:GridView ID="list" runat="server" CssClass="table table-hover text-center" /></p>
    </div>
    </form>
</body>
</html>
