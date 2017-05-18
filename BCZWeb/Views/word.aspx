<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="word.aspx.cs" Inherits="BCZWeb.Views.word" Async="true" %>
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
        body{
            overflow:hidden;
        }
        form{
            width:100%;
            height:75%;
            margin:80px auto 0 auto;
        }
        #collect{
            width:80%;
            height:100%;
            margin:0 auto;
            padding:20px;
            border-radius:5px;
            text-align:center;
            background-color:rgba(255,255,255,.6);
        }
        .p{
            font-size:20px;
        }
        #start,#fix{
            width:200px;
            margin:10px;
        }
    </style>
</head>
<body>
    <uc1:head runat="server" id="head" />
    <form id="form1" runat="server">
    <div id="collect">
        <h2>当前计划：</h2>
        <p class="p">
            计划ID：<asp:Label ID="ucid" runat="server" ForeColor="#ccc" Font-Size="XX-Large" />&nbsp;&nbsp;&nbsp;
            单词包ID：<asp:Label ID="cid" runat="server" ForeColor="#ccc" Font-Size="XX-Large" />
        </p>
        <p class="p">计划开始时间：<asp:Label ID="stime" runat="server" ForeColor="#ccc" Font-Size="XX-Large" /></p>
        <p class="p">计划结束时间：<asp:Label ID="etime" runat="server" ForeColor="#ccc" Font-Size="XX-Large" /></p>
        <p class="p">
            计划剩余天数：<asp:Label ID="sumday" runat="server" ForeColor="YellowGreen" Font-Size="XX-Large" />
            &nbsp;&nbsp;/&nbsp;&nbsp;<asp:Label ID="surday" runat="server" ForeColor="OrangeRed" Font-Size="XX-Large" />
        </p>
        <p class="p">
            <asp:Button ID="start" runat="server" Text="开始背词" CssClass="btn btn-info" OnClick="start_Click" />
            <asp:Button ID="fix" runat="server" Text="修改计划" CssClass="btn btn-warning" OnClick="fix_Click" />
        </p>
    </div>
    </form>
    <uc1:footer runat="server" id="footer" />
</body>
</html>
