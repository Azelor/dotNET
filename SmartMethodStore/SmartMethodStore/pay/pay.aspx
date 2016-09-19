<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="pay.aspx.cs" Inherits="SmartMethodStore.pay.pay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Enter Delivery Address
    </h2>
    <table>
        <tr>
            <td>
                Address 1
            </td>
            <td>
                <asp:TextBox ID="TextBoxOrderAddress1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Address 2
            </td>
            <td>
                <asp:TextBox ID="TextBoxOrderAddress2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Town
            </td>
            <td>
                <asp:TextBox ID="TextBoxOrderTown" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Region
            </td>
            <td>
                <asp:TextBox ID="TextBoxOrderRegion" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Country
            </td>
            <td>
                <asp:LinqDataSource ID="LinqDataSourceCountry" runat="server" ContextTypeName="SmartMethodStore.StoreDataContext" EntityTypeName="" OrderBy="CountryName" TableName="Countries">
                </asp:LinqDataSource>
                <asp:DropDownList ID="DropDownListCountry" runat="server" DataSourceID="LinqDataSourceCountry" DataTextField="CountryName" DataValueField="CountryID">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                Post Code
            </td>
            <td>
                <asp:TextBox ID="TextBoxOrderPostCode" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <asp:Button ID="ButtonContinueToPayment" runat="server" Text="Continue to Payment" OnClick="ButtonContinueToPayment_Click" />
</asp:Content>
