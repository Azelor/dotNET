<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="newtransaction.aspx.cs" Inherits="Spark.newtransaction" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link rel="Stylesheet" href="/styles/layout.css" />
    <link rel="Stylesheet" href="/styles/text.css" />
    <style type="text/css">
        .auto-style1 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="Header">
            <h1>
                Spark Accounts
            </h1>
            <div class="Menu">
                <a href="default.aspx" class="MenuLink">Home</a>
                <a href="newtransaction.aspx" class="ActiveLink">New Invoice</a>
                <a href="viewtransactions.aspx" class="MenuLink">View Invoices</a>
                <a href="reports.aspx" class="MenuLink">Reports</a>
            </div>
        </div>
        <div class="ClearFloats">
        <div class="Content">
            <asp:Panel ID="PanelAddInvoice" runat="server">
                <h1>
                    New Invoice
                </h1>
                <table>
                    <tr>
                        <td>
                            Customer
                        </td>
                        <td>
                            <asp:LinqDataSource ID="LinqDataSourceCustomer" runat="server" ContextTypeName="Spark.SparkDataContext" EntityTypeName="" OrderBy="CustomerName" TableName="Customers" Where="CustomerID != @CustomerID">
                                <WhereParameters>
                                    <asp:Parameter DefaultValue="5" Name="CustomerID" Type="Int32" />
                                </WhereParameters>
                            </asp:LinqDataSource>
                            <asp:DropDownList ID="DropDownListCustomer" runat="server" DataTextField="CustomerName" DataValueField="CustomerID" AppendDataBoundItems="True" DataSourceID="LinqDataSourceCustomer">
                                <asp:ListItem Selected="True">-- Select Customer --</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Invoice Number
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxInvoiceNumber" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorInvoiceNumber" runat="server" ControlToValidate="TextBoxInvoiceNumber" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Amount
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxAmount" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorAmount" runat="server" ControlToValidate="TextBoxAmount" ErrorMessage="*"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="RangeValidatorAmount" runat="server" ControlToValidate="TextBoxAmount" ErrorMessage="*" MaximumValue="9999" MinimumValue="0.01" Type="Currency"></asp:RangeValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            Tax Amount (20%)
                        </td>
                        <td class="auto-style1">
                            <asp:TextBox ID="TextBoxTaxAmount" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorTaxAmount" runat="server" ControlToValidate="TextBoxTaxAmount" ErrorMessage="*"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="RangeValidatorTaxAmount" runat="server" ControlToValidate="TextBoxTaxAmount" ErrorMessage="*" MaximumValue="9999" MinimumValue="0.01" Type="Currency"></asp:RangeValidator>
                        </td>
                    </tr>
                </table>
                <asp:Label ID="LabelError" runat="server" ForeColor="Red"></asp:Label>
                <br />
                <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" onclick="ButtonSubmit_Click" />
            </asp:Panel>
            <asp:Panel ID="PanelConfirmAdded" runat="server" Visible="False">
                <p>
                    Your invoice was successfully added.</p>
            </asp:Panel>
        </div>
        <div class="Footer">
        </div>
    </div>
    </form>
</body>
</html>
