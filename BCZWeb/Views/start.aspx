<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="start.aspx.cs" Inherits="BCZWeb.Views.start" %>

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
    </style>
</head>
<body>
    <uc1:head runat="server" ID="head" />
    <form id="form1" runat="server">
    <div id="collect">
        
    </div>
    </form>
    <uc1:footer runat="server" ID="footer" />
</body>
</html>
