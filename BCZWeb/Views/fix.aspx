<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fix.aspx.cs" Inherits="BCZWeb.Views.fix" %>
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
    </style>
</head>
<body>
    <uc1:head runat="server" id="head" />
    <form id="form1" runat="server">
    <div id="collect">
        <asp:GridView ID="list" runat="server" AutoGenerateColumns="false" CssClass="table table-hover" OnRowCommand="id_RowCommand" >
            <Columns>
                <asp:BoundField DataField="C_ID" HeaderText="单词书ID" />
                <asp:BoundField DataField="C_NAME" HeaderText="单词书名称" />
                <asp:BoundField DataField="C_RELEASEDATE" HeaderText="创建时间" />
                <asp:BoundField DataField="C_VOCABULARY" HeaderText="单词总量" />
                <asp:TemplateField HeaderText="计划操作">
                    <ItemTemplate>
                        <asp:TextBox ID="ew" runat="server" Text="每日单词量" Width="100" />
                        <asp:Button ID="add" runat="server" Text="添加该计划" CssClass="btn btn-info" CommandArgument='<%# Eval("C_ID") %>' />
                        <asp:Button ID="del" runat="server" Text="删除该计划" CssClass="btn btn-danger" CommandArgument='<%# Eval("C_ID") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    </form>
    <uc1:footer runat="server" id="footer" />
</body>
</html>