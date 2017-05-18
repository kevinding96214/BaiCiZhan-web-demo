<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wordList.aspx.cs" Inherits="BCZWeb.Views.wordList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:GridView ID="list" runat="server" AllowPaging="true" PageSize="15" CssClass="table table-hover table-condensed" OnPageIndexChanging="list_PageIndexChanging" />
    </div>
    </form>
</body>
</html>
