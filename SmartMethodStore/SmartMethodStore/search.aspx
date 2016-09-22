<%@ Page Title="Search" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="SmartMethodStore.search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Search
    </h2>
    <p>
        &nbsp;<table>
            <tr>
                <td>Product Name:</td>
                <td>
                    <asp:TextBox ID="TextBoxProductName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Price Below:</td>
                <td>
                    <asp:TextBox ID="TextBoxPriceBelow" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="ButtonSearch" runat="server" Text="Search" OnClick="ButtonSearch_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    <asp:GridView ID="GridViewProduct" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ProductID" ForeColor="#333333" GridLines="None" ShowHeader="False" OnRowCommand="GridViewProduct_RowCommand">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:ImageField DataImageUrlField="ProductImageUrl">
            </asp:ImageField>
            <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
            <asp:BoundField DataField="ProductPrice" DataFormatString="{0:c}" HeaderText="ProductPrice" SortExpression="ProductPrice" />
            <asp:ButtonField CommandName="AddToCart" Text="Add to cart" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    </p>
</asp:Content>
