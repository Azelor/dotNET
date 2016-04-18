<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Exercise1.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Calculate Depreciation
    </h2>
    
    <table>
        <tr>
            <td>
                Starting Value:</td>
            <td>
                <asp:TextBox ID="TextBoxStartingValue" runat="server">3217.89</asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Depreciation Rate (Decimal):</td>
            <td style="margin-left: 40px">
                <asp:TextBox ID="TextBoxDepreciationRate" runat="server">0.5</asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Number of Years
            </td>
            <td style="margin-left: 40px">
                <asp:TextBox ID="TextBoxNumberOfYears" runat="server">5</asp:TextBox>
            </td>
        </tr>
    </table>
    <asp:Label ID="LabelError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
    <asp:Table ID="TableDepreciatedNumbers" Visible="false" runat="server">
        <asp:TableHeaderRow>
            <asp:TableHeaderCell>Year</asp:TableHeaderCell>
            <asp:TableHeaderCell>Value</asp:TableHeaderCell>
        </asp:TableHeaderRow>
    </asp:Table>
    <asp:Button ID="ButtonCalculate" runat="server" Text="Calculate" onclick="ButtonCalculate_Click" />
    
</asp:Content>
