<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="BCZWeb.Views.admin" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no"/>
    <title>百词斩管理平台</title>
    <link href="../Content/admin.css" rel="stylesheet" />
    <link rel="icon" href="../Image/b_icon2.ico" type="image/x-icon" />
    <link rel="shortcut icon" href="../Image/b_icon2.ico" type="image/x-icon" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <div id="left" runat="server">
        <p><a href="index.aspx"><img src="../Image/logo2.png" /></a></p>
        <p><span class="glyphicon glyphicon-home"></span><a href="index.aspx" >网站首页</a></p>
        <p><span class="glyphicon glyphicon-plus-sign"></span><a href="addWord.aspx" target="frame" >增加单词</a></p>
        <p><span class="glyphicon glyphicon-list"></span><a href="wordList.aspx" target="frame">浏览单词</a></p>
        <p><span class="glyphicon glyphicon-edit"></span><a href="addWordBag.aspx" target="frame">添加词库</a></p>
        <p><span class="glyphicon glyphicon glyphicon-remove-sign"></span><a href="delWordBag.aspx" target="frame">删除词库</a></p>
        <p><span class="glyphicon glyphicon-user"></span><a href="editUser.aspx" target="frame">用户管理</a></p>
        <p><span class="glyphicon glyphicon-cog"></span><a href="myProf.aspx" target="frame">个人资料</a></p>
        <p><span class="glyphicon glyphicon-exclamation-sign"></span><a href="addAdmin.aspx" target="frame">管理权限</a></p>
    </div>
    <div id="right" runat="server">
        <iframe id="frame" name="frame" seamless="seamless"></iframe>
    </div>
    <script src="../scripts/bootstrap.min.js"></script>
</body>
</html>
