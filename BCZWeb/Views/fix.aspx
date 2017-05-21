<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fix.aspx.cs" Inherits="BCZWeb.Views.fix" EnableSessionState="True"  %>
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
            width:100%;
            padding:80px 20px 20px 20px;
        }
        #collect{
            width:80%;
            margin:0 auto;
            padding:20px;
            border-radius:5px;
            text-align:center;
            background-color:rgba(255,255,255,.6);
        }
        #edit{
            margin-top:20px;
        }
        .book{
            margin:10px;
            background-color:#0094ff;
            color:#fff;
            font-size:18px;
        }
        #panel{
            width:100%;
        }
        #add,#del{
            width:150px;
        }
    </style>
</head>
<body>
    <uc1:head runat="server" id="head" />
    <form id="form1" runat="server">
    <div id="collect">
            <asp:Panel ID="panel" runat="server" />
        <div id="edit">
            <p>单词书名：<asp:TextBox ID="bname" runat="server" ReadOnly="true" placeholder="单词书名称" /></p>
                <p>单词书号：<asp:TextBox ID="bid" runat="server" ReadOnly="true" placeholder="单词书编号" /></p>
                    <p>每日词量：<asp:TextBox ID="ew" runat="server" TextMode="Number" Text="15" placeholder="每日单词量" /></p>
            <p>开始时间：<input type="date" id="sday" runat="server" /> </p>
               <p> 结束时间：<input type="date" id="eday" runat="server" /> </p>
            <p>
                <asp:Button ID="add" runat="server" Text="添加计划" CssClass="btn btn-info" OnClick="add_Click" />
                <asp:Button ID="del" runat="server" Text="删除计划" CssClass="btn btn-danger" OnClick="del_Click" />
            </p>
        </div>
    </div>
    </form>
    <uc1:footer runat="server" id="footer" />
</body>
</html>