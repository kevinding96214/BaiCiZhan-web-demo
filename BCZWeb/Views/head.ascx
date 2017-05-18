<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="head.ascx.cs" Inherits="BCZWeb.Views.layout" %>
<div class="navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <img id="logo" src="../Image/logo2.png" alt="百词斩" draggable="false" />
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav navbar-right">
                    <li><asp:HyperLink ID="home" runat="server" Text="首页" /></li>
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