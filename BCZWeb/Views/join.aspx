<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="join.aspx.cs" Inherits="BCZWeb.Views.join" %>

<%@ Register Src="~/Views/head.ascx" TagPrefix="uc1" TagName="head" %>
<%@ Register Src="~/Views/footer.ascx" TagPrefix="uc1" TagName="footer" %>



<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>百词斩</title>
    <link href="../Content/layout.css" rel="stylesheet" type="text/css" />
    <link rel="icon" href="../Image/b_icon2.ico" type="image/x-icon" />
    <link rel="shortcut icon" href="../Image/b_icon2.ico" type="image/x-icon" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <style>
#Jbox{
    width:70%;
    margin:80px auto 20px auto;
}
#Jbox img{
    width:100%;
}
section{
    width:70%;
    text-shadow:0 0 1px #fff;
    font-size:18px;
    margin:0 auto;
}
    </style>
</head>
<body>
    <uc1:head runat="server" ID="head" />
    <div id="Jbox">
        <img id="photo" src="../Image/jobs-04.jpg" alt="" draggable="false" />
    </div>
    <section class="text-left">
        <p>成都超有爱科技有限公司成立于 2012 年，以背单词 App 百词斩切入了在线教育市场。</p>
        <p>目前的产品分为 App 软件和实体书籍两个类别，其中App“百词斩”的用户已过千万，领先目前所有的在线教育创业公司。而由核心业务衍生出的实体书业务则为公司提供了稳定的现金流，配合经纬中国 A 轮千万级别的投资，目前公司正稳定而快速的发展中。</p>
        <p>超有爱科技独有的企业文化和强有竞争力的薪酬体系，吸引了大批来自北上广知名互联网公司的资深员工鼎力支持，在相当长的时间内，我们都专注于做好用户体验以及 高度关注 “ 用户增长，用户活跃 ” 这两项指标，努力把用户体验做到极致。</p>
        <p>信仰相同理念的你，快来一起 high : )</p>
        <table id="tab1" class="table table-bordered table-striped text-center">
            <tr>
                <th class="text-center" colspan="4"><a class="qz" href="#">全职岗位</a>&nbsp;&nbsp;|&nbsp;&nbsp;<a class="sx" href="#">实习岗位</a></th>
            </tr>
            <tr>
                <td>超级Server服务器开发工程师</td>
                <td>技术类</td>
                <td>成都</td>
                <td>2016-12-14</td>
            </tr>
            <tr>
                <td>超级iOS开发工程师</td>
                <td>技术类</td>
                <td>成都</td>
                <td>2016-12-2</td>
            </tr>
            <tr>
                <td>超级Android开发工程师</td>
                <td>技术类</td>
                <td>成都</td>
                <td>2016-12-2</td>
            </tr>
            <tr>
                <td>超级UI设计师</td>
                <td>设计类</td>
                <td>成都</td>
                <td>2015-7-15</td>
            </tr>
        </table>
        <table id="tab2" class="table table-bordered table-striped text-center" style="display:none;">
            <tr>
                <th class="text-center" colspan="4"><a class="qz" href="#">全职岗位</a>&nbsp;&nbsp;|&nbsp;&nbsp;<a class="sx" href="#">实习岗位</a></th>
            </tr>
            <tr>
                <td>平面设计实习生</td>
                <td>设计类</td>
                <td>成都</td>
                <td>2016-12-14</td>
            </tr>
            <tr>
                <td>后端开发实习</td>
                <td>技术类</td>
                <td>成都</td>
                <td>2016-12-2</td>
            </tr>
            <tr>
                <td>英语编辑</td>
                <td>职能类</td>
                <td>成都</td>
                <td>2016-12-2</td>
            </tr>
            <tr>
                <td>英语策划编辑（文字方向）</td>
                <td>职能类</td>
                <td>成都</td>
                <td>2015-7-15</td>
            </tr>
        </table>
    </section>
    <uc1:footer runat="server" ID="footer" />
</body>
</html>

