<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="BCZWeb.Views.index" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no"/>
    <title>百词斩</title>
    <link href="../Content/index.css" rel="stylesheet" type="text/css" />
    <link href="../Contentlayout.css" rel="stylesheet" type="text/css" />
    <link rel="icon" href="../Image/b_icon2.ico" type="image/x-icon" />
    <link rel="shortcut icon" href="../Image/b_icon2.ico" type="image/x-icon" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />

</head>
<body>
    <div class="navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <a href="index.aspx"><img id="logo" src="../Image/logo2.png" alt="百词斩" draggable="false" /></a>
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav navbar-right">
                    <li><a href="index.aspx">首页</a></li>
                    <li><a href="word.aspx">背单词</a></li>
                    <li><a href="wordTv.aspx">单词TV</a></li>
                    <li><a href="join.aspx">加入我们</a></li>
                    <li><a id="down" href="#">客户端下载</a></li>
                </ul>
            </div>
            <div id="downBox">
                <img src="../Image/android-d.png" alt="安卓客户端" draggable="false" />
                <img src="../Image/apple-d.png" alt="苹果客户端" draggable="false" />
            </div>
        </div>
    </div>
    <div id="wrap" title="按住拖动登录框">
        <div id="pics">
            <div id="login" class="text-center">
                
                <form runat="server" id="logForm" method="post">
                    <h3>用户登录</h3>
                    <p><asp:textbox runat="server" id="account" class="text-info" placeholder="用户名" title="请输入用户名" /></p>
                    <p><asp:textbox runat="server" id="passwd" TextMode="Password"  name="passwd" class="text-info" placeholder="密码" title="请输入密码" /></p>
                    <p><asp:button runat="server" id="log" Text="登录" name="denglu" class="btn btn-info" title="登录" OnClick="log_Click" />
                        <asp:button runat="server" id="sig" Text="注册" name="zhuce" class="btn btn-warning" title="注册" OnClick="sig_Click" /></p>
                    <hr class="divider" />第三方平台登录
                    <p>
                        <a href="#"><img class="log" src="../Image/weixin.png" alt="微信登录" title="微信登录" draggable="false" /></a>
                        <a href="#"><img class="log" src="../Image/sina.png" alt="新浪登陆" title="新浪登录" draggable="false" /></a>
                        <a href="#"><img class="log" src="../Image/renren.png" alt="人人登录" title="人人登录" draggable="false" /></a>
                    </p>
                </form>
            </div>
            <img id="bgpic" src="../Image/down1.jpg" alt="" draggable="false" />
        </div>
    </div>
    <footer class="text-center">
        <hr class="divider" />
        <p>成都超爱学习教育科技出品&nbsp;&nbsp;&copy; <asp:Label runat="server" ID="nYear" />&nbsp;baicizhan.com.&nbsp;All&nbsp;Rights&nbsp;Reserved.&nbsp;蜀ICP备12013359号</p>
        <p>地址：四川省成都市天府大道中段软件园E区E2-1402&nbsp;超有爱&nbsp;-&nbsp;[<a href="adminLog.aspx">管理登录</a>]</p>
    </footer>
    <script src="../scripts/jquery-3.2.0.min.js"></script>
    <script src="../scripts/bootstrap.min.js"></script>
    <script src="../scripts/Baicizhan.js"></script>
</body>
</html>