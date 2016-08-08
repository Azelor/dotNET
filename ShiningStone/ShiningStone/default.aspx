<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ShiningStone._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Shining Stone Jewelers</title>
    <link href="Styles/layout.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="wrapper">
        <div class="header">
            <h1>
                Shining Stone<br />
                Gems
            </h1>
        </div>
        <div class="menu">
            <span class="menulink"><a href="default.aspx">Home</a></span> <span class="menulink">
                <a href="news.aspx">News</a></span> <span class="menulink"><a href="store.aspx">Store</a></span>
            <span class="menulink"><a href="contact.aspx">Contact</a></span>
        </div>
        <div class="content">
            <div class="leftcontent">
                <p>
                    Welcome to Shining Stone Gems, your #1 source for fine gemstones.</p>
                <p>
                    Please visit the Store to browse our merchandise!</p>
            </div>
            <div class="rightcontent">
                <h2>
                    New Products
                </h2>
                <asp:DataList ID="DataListProducts" runat="server" DataKeyField="ProductId">
                    <ItemTemplate>
                        <a href="buy.aspx?productid=<%#Eval("ProductID")%>">
                            <%# Eval("ProductName") %></a>
                    </ItemTemplate>
                </asp:DataList>
                <br />
            </div>
        </div>
        <div class="clearfloats">
        </div>
        <div class="footer">
            Copyright &copy; 2011 The Smart Method.
        </div>
    </div>
    </form>
</body>
</html>
