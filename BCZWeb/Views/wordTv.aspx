<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wordTv.aspx.cs" Inherits="BCZWeb.Views.wordTv" %>

<%@ Register Src="~/Views/head.ascx" TagPrefix="uc1" TagName="head" %>
<%@ Register Src="~/Views/footer.ascx" TagPrefix="uc1" TagName="footer" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>百词斩</title>
    <link href="../Content/layout.css" rel="stylesheet" type="text/css" />
    <link href="../Content/join.css" rel="stylesheet" type="text/css" />
    <link rel="icon" href="../Image/b_icon2.ico" type="image/x-icon" />
    <link rel="shortcut icon" href="../Image/b_icon2.ico" type="image/x-icon" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        form{
            margin:0 auto;
            margin-top:100px;
            width:100%;
            height:100%;
        }
        #top{
            margin:0 auto;
            margin-top:100px;
            width:80%;
            overflow:hidden;
        }
        #left{
            display:inline;
            float:left;
        }
        #right{
            display:inline;
            margin-right:-5px;
            float:right;
        }
        td{
            padding:15px 5px;
        }
        #right img{
            width:140px;
            height:75px;
        }
        #middle,#bottom{
            width:100%;
            margin:50px auto;
        }
        .tj{
            width:100%;
            color: #000;
            font-size:2em;
            text-indent:20px;
            border-radius:20px 0 0 20px;
            background:linear-gradient(to right, #fff, transparent);
        }
        .tjitems{
            background-color:#fff;
            padding-bottom:10px;
            overflow:hidden;
            border-radius:5px;
            text-align:center;
        }
        .tjitems h4{
            margin-top:20px;
        }
        .tjitems img{
            transition:all .8s;
            -moz-transition:all .8s;
            -webkit-transition:all .8s;
            -o-transition:all .8s;
        }
        .tjitems img:hover{
            transform:scale(1.1,1.1);
            -moz-transform:scale(1.1,1.1);
            -webkit-transform:scale(1.1,1.1);
            -o-transform:scale(1.1,1.1);
            -ms-transform:scale(1.1,1.1);
        }
    </style>
</head>
<body>
    <uc1:head runat="server" ID="head" />
        <div id="top">
            <div id="left">
                <embed src="http://player.polyv.net/videos/f445c74f8ca07348978f7ad123372098_f.swf" quality="high" width="465" height="310" allowScriptAccess="always" allowFullscreen="true" type="application/x-shockwave-flash"></embed>
            </div>
            <div id="right">
                <table>
                    <tr>
                        <td>
                            <img src="../Image/9_book_face.png" draggable="false" />
                        </td>
                        <td>
                            <img src="../Image/12_book_face.png" draggable="false" />
                        </td>
                        <td>
                            <img src="../Image/2_book_face.png" draggable="false" />
                        </td>
                        <td>
                            <img src="../Image/3_book_face.png" draggable="false" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <img src="../Image/7_book_face.png" draggable="false" />
                        </td>
                        <td>
                            <img src="../Image/11_book_face.png" draggable="false" />
                        </td>
                        <td>
                            <img src="../Image/10_book_face.png" draggable="false" />
                        </td>
                        <td>
                            <img src="../Image/1_book_face.png" draggable="false" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <img src="../Image/8_book_face.png" draggable="false" />
                        </td>
                        <td>
                            <img src="../Image/6_book_face.png" draggable="false" />
                        </td>
                        <td>
                            <img src="../Image/5_book_face.png" draggable="false" />
                        </td>
                        <td>
                            <img src="../Image/4_book_face.png" draggable="false" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>

    <!--最新推荐-->
    <div id="middle" class="row">
        <p class="tj">最新推荐...</p>
        <div class="col-md-3">
            <div class="tjitems">
                <img src="../Image/bcztv_20151106170614_封面11.png" draggable="false" />
                <hgroup>
                    <h4>狂欢双“十一”之买买买</h4>
                    <h5>与买买买有关的10个单词！</h5>
                </hgroup>
            </div>
        </div>
        <div class="col-md-3">
            <div class="tjitems">
                <img src="../Image/bcztv_20150926142733_cover－易混词.jpg" draggable="false" />
                <hgroup>
                    <h4>易混词合集VOL.1</h4>
                    <h5>一次讲清易混点！</h5>
                </hgroup>
            </div>
        </div>
        <div class="col-md-3">
            <div class="tjitems">
                <img src="../Image/bcztv_20150811181323_重口小讲堂.png" draggable="false" />
                <hgroup>
                    <h4>重口小讲堂</h4>
                    <h5>传播重口画面是我们的职责！</h5>
                </hgroup>
            </div>
        </div>
        <div class="col-md-3">
            <div class="tjitems">
                <img src="../Image/bcztv_20150912151023_embarrassed%20knowledge－0818.png" draggable="false" />
                <hgroup>
                    <h4>羞羞的知识</h4>
                    <h5>未满18岁请撤离！</h5>
                </hgroup>
            </div>
        </div>
    </div>

    <!--热门推荐-->
    <div id="bottom" class="row">
        <p class="tj">热门推荐...</p>
        <div class="col-md-3">
            <div class="tjitems">
                <img src="../Image/bcztv_20150829181744_cover－virgo.png" draggable="false" />
                <hgroup>
                    <h4>谜之处女座</h4>
                    <h5>还原一个真实的处女座~</h5>
                </hgroup>
            </div>
        </div>
        <div class="col-md-3">
            <div class="tjitems">
                <img src="../Image/bcztv_20150829181607_开学季.png" draggable="false" />
                <hgroup>
                    <h4>开学啦！</h4>
                    <h5>那些课堂上发生的趣事~</h5>
                </hgroup>
            </div>
        </div>
        <div class="col-md-3">
            <div class="tjitems">
                <img src="../Image/bcztv_20150916170445_看mv学单词.jpg" draggable="false" />
                <hgroup>
                    <h4>看MV学单词VOL.1</h4>
                    <h5>跟着MV来刷单词~</h5>
                </hgroup>
            </div>
        </div>
        <div class="col-md-3">
            <div class="tjitems">
                <img src="../Image/bcztv_20150925160849_cover－一起过中秋.png" draggable="false" />
                <hgroup>
                    <h4>一起过中秋</h4>
                    <h5>那些和中秋有关的单词~</h5>
                </hgroup>
            </div>
        </div>
    </div>
    <uc1:footer runat="server" ID="footer" />
</body>
</html>
