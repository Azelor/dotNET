<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reports.aspx.cs" Inherits="Spark.reports" %>

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
                <a href="default.aspx" class="MenuLink">Home</a>
                <a href="newtransaction.aspx" class="MenuLink">New Invoice</a>
                <a href="viewtransactions.aspx" class="MenuLink">View Invoices</a>
                <a href="reports.aspx" class="ActiveLink">Reports</a>
            </div>
        </div>
        <div class="ClearFloats">
        <div class="Content">
            <asp:Label ID="LabelReport" runat="server"></asp:Label>
            <asp:LinqDataSource ID="LinqDataSourceInvoice" runat="server" ContextTypeName="Spark.SparkDataContext" EnableDelete="True" EnableInsert="True" EnableUpdate="True" EntityTypeName="" OrderBy="InvoiceID" TableName="Invoices">
            </asp:LinqDataSource>
            <asp:GridView ID="GridViewInvoice" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="InvoiceID" DataSourceID="LinqDataSourceInvoice" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="InvoiceDate" DataFormatString="{0:d}" HeaderText="InvoiceDate" SortExpression="InvoiceDate" />
                    <asp:BoundField DataField="InvoiceAmount" DataFormatString="{0:c}" HeaderText="InvoiceAmount" SortExpression="InvoiceAmount" />
                    <asp:BoundField DataField="InvoiceTaxAmount" DataFormatString="{0:c}" HeaderText="InvoiceTaxAmount" SortExpression="InvoiceTaxAmount" />
                    <asp:BoundField DataField="InvoiceNumber" HeaderText="InvoiceNumber" SortExpression="InvoiceNumber" />
                    <asp:CommandField ShowDeleteButton="True" />
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
            <br />
            <asp:DetailsView ID="DetailsViewInvoice" runat="server" AllowPaging="True" AutoGenerateRows="False" DataKeyNames="InvoiceID" DataSourceID="LinqDataSourceInvoice" Height="50px" Width="125px">
                <Fields>
                    <asp:BoundField DataField="InvoiceID" HeaderText="InvoiceID" InsertVisible="False" ReadOnly="True" SortExpression="InvoiceID" />
                    <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" SortExpression="CustomerID" />
                    <asp:BoundField DataField="InvoiceDate" HeaderText="InvoiceDate" SortExpression="InvoiceDate" />
                    <asp:BoundField DataField="InvoiceAmount" HeaderText="InvoiceAmount" SortExpression="InvoiceAmount" />
                    <asp:BoundField DataField="InvoiceTaxAmount" HeaderText="InvoiceTaxAmount" SortExpression="InvoiceTaxAmount" />
                    <asp:BoundField DataField="InvoiceNumber" HeaderText="InvoiceNumber" SortExpression="InvoiceNumber" />
                    <asp:CommandField ShowEditButton="True" />
                    <asp:CommandField ShowInsertButton="True" />
                </Fields>
            </asp:DetailsView>
            <br />
        </div>
        <div class="Footer">
        </div>
    </div>
    </form>
</body>
</html>
