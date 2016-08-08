<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="store.aspx.cs" Inherits="ShiningStone.store" %>

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
            <div class="fullcontent">
                <h2>
                    Store
                </h2>
                <asp:GridView ID="GridViewProduct" runat="server" AutoGenerateColumns="False" 
                    CellSpacing="4" DataKeyNames="ProductId" DataSourceID="LinqDataSourceProduct" 
                    GridLines="None" ShowHeader="False">
                    <Columns>
                        <asp:ImageField DataImageUrlField="ProductImage">
                        </asp:ImageField>
                        <asp:BoundField DataField="ProductName" HeaderText="ProductName" 
                            SortExpression="ProductName" />
                        <asp:BoundField DataField="ProductPrice" DataFormatString="{0:c}" 
                            HeaderText="ProductPrice" SortExpression="ProductPrice" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <a href="buy.aspx?productid=<%# Eval("ProductID") %>">Buy Now</a>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <asp:LinqDataSource ID="LinqDataSourceProduct" runat="server" ContextTypeName="ShiningStone.ShiningStoneDataContext"
                    EntityTypeName="" OrderBy="ProductName" TableName="Products">
                </asp:LinqDataSource>
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
