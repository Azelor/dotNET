<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Spark._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link rel="Stylesheet" href="/styles/layout.css" />
    <link rel="Stylesheet" href="/styles/text.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="Header">
            <h1>
                Spark Accounts
            </h1>
            <div class="Menu">
                <a href="default.aspx" class="ActiveLink">Home</a>
                <a href="newtransaction.aspx" class="MenuLink">New Invoice</a>
                <a href="viewtransactions.aspx" class="MenuLink">View Invoices</a>
                <a href="reports.aspx" class="MenuLink">Reports</a>
            </div>
        </div>
        <div class="ClearFloats">
        <div class="Content">
            <p>Welcome to Spark Accounts, a very simple web-based invoice recording system.</p>
        </div>
        <div class="Footer">
        </div>
    </div>
    </form>
</body>
</html>
