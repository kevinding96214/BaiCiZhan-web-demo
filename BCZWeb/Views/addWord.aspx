<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addWord.aspx.cs" Inherits="BCZWeb.Views.addWord" %>

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
        }
        #form1{
            margin-top:60px;
        }
        .row{
            margin-top:20px;
        }
        #wtype{
            width:175px;
            height:25px;
        }
        #save{
            width:200px;
            margin-top:20px;
        }
    </style>
</head>
<body class="text-center">
    <form id="form1" runat="server">
    <div>
        <p>单词包ID：<asp:TextBox ID="wbid" runat="server" CssClass="text-info" />
            &nbsp;&nbsp;&nbsp;&nbsp;单词名称：<asp:TextBox ID="wname" runat="server" CssClass="text-info" /></p>
        <p>单词音标：<asp:TextBox ID="wyinbiao" runat="server" CssClass="text-info" />
            &nbsp;&nbsp;&nbsp;&nbsp;单词释义：<asp:TextBox ID="wmean" runat="server" CssClass="text-info" /></p>
        <p>英文例句：<asp:TextBox ID="wen" runat="server" CssClass="text-info" />
            &nbsp;&nbsp;&nbsp;&nbsp;中文例句：<asp:TextBox ID="wcn" runat="server" CssClass="text-info" /></p>
        <p>视频地址：<asp:TextBox ID="wvideo" runat="server" CssClass="text-info" />
        </p>
        <div class="row">
        <div class="col col-md-3">
            <p>正确图片：<asp:FileUpload ID="tpic" runat="server" /><asp:Button ID="upload1" runat="server" Text="上传" OnClick="upload1_Click" CssClass="btn btn-info" /></p>
            <asp:Image ID="wpic1" runat="server" BorderWidth="1" ImageAlign="Middle" Height="200px" Width="200px" />
        </div>
        <div class="col col-md-3">
            <p>错误图片1：<asp:FileUpload ID="fpic1" runat="server" /><asp:Button ID="upload2" runat="server" Text="上传" OnClick="upload2_Click" CssClass="btn btn-info" /></p>
            <asp:Image ID="wpic2" runat="server" BorderWidth="1" ImageAlign="Middle" Height="200px" Width="200px" />
        </div>
        <div class="col col-md-3">
            <p>错误图片2：<asp:FileUpload ID="fpic2" runat="server" /><asp:Button ID="upload3" runat="server" Text="上传" OnClick="upload3_Click" CssClass="btn btn-info" /></p>
            <asp:Image ID="wpic3" runat="server" BorderWidth="1" ImageAlign="Middle" Height="200px" Width="200px" />
        </div>
        <div class="col col-md-3">
            <p>错误图片3：<asp:FileUpload ID="fpic3" runat="server" /><asp:Button ID="upload4" runat="server" Text="上传" OnClick="upload4_Click" CssClass="btn btn-info" /></p>
            <asp:Image ID="wpic4" runat="server" BorderWidth="1" ImageAlign="Middle" Height="200px" Width="200px" />
        </div>
        </div>
    </div>
        <p><asp:Button ID="save" runat="server" Text="保存" CssClass="btn btn-info" OnClick="save_Click" /></p>
    </form>
</body>
</html>