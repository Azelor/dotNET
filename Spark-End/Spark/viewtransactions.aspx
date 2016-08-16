<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewtransactions.aspx.cs" Inherits="Spark.viewtransactions" %>

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
                <a href="default.aspx" class="MenuLink">Home</a> <a href="newtransaction.aspx" class="MenuLink">New Invoice</a> <a href="viewtransactions.aspx" class="ActiveLink">View Invoices</a> <a href="reports.aspx" class="MenuLink">Reports</a>
            </div>
        </div>
        <div class="ClearFloats">
            <div class="Content">
                <table>
                    <tr>
                        <td>
                            Period:
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownListSelectPeriod" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListSelectPeriod_SelectedIndexChanged">
                                <asp:ListItem>-- Select Period --</asp:ListItem>
                                <asp:ListItem>2011</asp:ListItem>
                                <asp:ListItem>2010</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
                <asp:Panel ID="Panel2010" runat="server" Visible="False">
                    <h2>
                        2010 Invoices</h2>
                    <table cellspacing="0" id="GridView2010" style="width: 75%; border-collapse: collapse;">
                        <tr>
                            <th scope="col">
                                Invoice Number
                            </th>
                            <th scope="col">
                                Customer
                            </th>
                            <th scope="col">
                                Date
                            </th>
                            <th scope="col">
                                Amount
                            </th>
                            <th scope="col">
                                Tax Amount
                            </th>
                        </tr>
                        <tr>
                            <td>
                                4981
                            </td>
                            <td>
                                Lehmanns Marktstand
                            </td>
                            <td>
                                01/01/2010
                            </td>
                            <td>
                                &#163;970.88
                            </td>
                            <td>
                                &#163;194.18
                            </td>
                        </tr>
                        <tr>
                            <td>
                                9557
                            </td>
                            <td>
                                Magazzini Alimentari Riuniti
                            </td>
                            <td>
                                01/01/2010
                            </td>
                            <td>
                                &#163;91.35
                            </td>
                            <td>
                                &#163;18.27
                            </td>
                        </tr>
                        <tr>
                            <td>
                                1579
                            </td>
                            <td>
                                Lehmanns Marktstand
                            </td>
                            <td>
                                02/01/2010
                            </td>
                            <td>
                                -&#163;150.56
                            </td>
                            <td>
                                -&#163;30.11
                            </td>
                        </tr>
                        <tr>
                            <td>
                                8847
                            </td>
                            <td>
                                QUICK-Stop
                            </td>
                            <td>
                                02/01/2010
                            </td>
                            <td>
                                &#163;642.49
                            </td>
                            <td>
                                &#163;128.50
                            </td>
                        </tr>
                        <tr>
                            <td>
                                5506
                            </td>
                            <td>
                                Bottom-Dollar Markets
                            </td>
                            <td>
                                02/01/2010
                            </td>
                            <td>
                                &#163;274.19
                            </td>
                            <td>
                                &#163;54.84
                            </td>
                        </tr>
                        <tr>
                            <td>
                                6871
                            </td>
                            <td>
                                Bottom-Dollar Markets
                            </td>
                            <td>
                                02/01/2010
                            </td>
                            <td>
                                &#163;666.36
                            </td>
                            <td>
                                &#163;133.27
                            </td>
                        </tr>
                        <tr>
                            <td>
                                6257
                            </td>
                            <td>
                                B&#39;s Beverages
                            </td>
                            <td>
                                02/01/2010
                            </td>
                            <td>
                                &#163;625.93
                            </td>
                            <td>
                                &#163;125.19
                            </td>
                        </tr>
                        <tr>
                            <td>
                                5691
                            </td>
                            <td>
                                La maison d&#39;Asie
                            </td>
                            <td>
                                02/01/2010
                            </td>
                            <td>
                                &#163;648.53
                            </td>
                            <td>
                                &#163;129.71
                            </td>
                        </tr>
                        <tr>
                            <td>
                                5506
                            </td>
                            <td>
                                Ana Trujillo Emparedados y helados
                            </td>
                            <td>
                                04/01/2010
                            </td>
                            <td>
                                &#163;804.39
                            </td>
                            <td>
                                &#163;160.88
                            </td>
                        </tr>
                        <tr>
                            <td>
                                4679
                            </td>
                            <td>
                                B&#39;s Beverages
                            </td>
                            <td>
                                05/01/2010
                            </td>
                            <td>
                                &#163;884.25
                            </td>
                            <td>
                                &#163;176.85
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
                <asp:Panel ID="Panel2011" runat="server" Visible="False">
                    <h2>2011 Invoices</h2>
                    <table cellspacing="0" id="GridView2011" style="width: 75%; border-collapse: collapse;">
                        <tr>
                            <th scope="col">
                                Invoice Number
                            </th>
                            <th scope="col">
                                Customer
                            </th>
                            <th scope="col">
                                Date
                            </th>
                            <th scope="col">
                                Amount
                            </th>
                            <th scope="col">
                                Tax Amount
                            </th>
                        </tr>
                        <tr>
                            <td>
                                2431
                            </td>
                            <td>
                                Cactus Comidas para llevar
                            </td>
                            <td>
                                01/01/2011
                            </td>
                            <td>
                                &#163;526.12
                            </td>
                            <td>
                                &#163;105.22
                            </td>
                        </tr>
                        <tr>
                            <td>
                                5129
                            </td>
                            <td>
                                Bottom-Dollar Markets
                            </td>
                            <td>
                                01/01/2011
                            </td>
                            <td>
                                &#163;304.47
                            </td>
                            <td>
                                &#163;60.89
                            </td>
                        </tr>
                        <tr>
                            <td>
                                5219
                            </td>
                            <td>
                                La maison d&#39;Asie
                            </td>
                            <td>
                                01/01/2011
                            </td>
                            <td>
                                &#163;546.37
                            </td>
                            <td>
                                &#163;109.27
                            </td>
                        </tr>
                        <tr>
                            <td>
                                6920
                            </td>
                            <td>
                                Ana Trujillo Emparedados y helados
                            </td>
                            <td>
                                01/01/2011
                            </td>
                            <td>
                                -&#163;705.39
                            </td>
                            <td>
                                -&#163;141.08
                            </td>
                        </tr>
                        <tr>
                            <td>
                                5753
                            </td>
                            <td>
                                Island Trading
                            </td>
                            <td>
                                01/01/2011
                            </td>
                            <td>
                                &#163;274.81
                            </td>
                            <td>
                                &#163;54.96
                            </td>
                        </tr>
                        <tr>
                            <td>
                                9789
                            </td>
                            <td>
                                Cactus Comidas para llevar
                            </td>
                            <td>
                                01/01/2011
                            </td>
                            <td>
                                &#163;828.36
                            </td>
                            <td>
                                &#163;165.67
                            </td>
                        </tr>
                        <tr>
                            <td>
                                1680
                            </td>
                            <td>
                                La maison d&#39;Asie
                            </td>
                            <td>
                                01/01/2011
                            </td>
                            <td>
                                &#163;215.75
                            </td>
                            <td>
                                &#163;43.15
                            </td>
                        </tr>
                        <tr>
                            <td>
                                7983
                            </td>
                            <td>
                                La maison d&#39;Asie
                            </td>
                            <td>
                                01/01/2011
                            </td>
                            <td>
                                &#163;951.05
                            </td>
                            <td>
                                &#163;190.21
                            </td>
                        </tr>
                        <tr>
                            <td>
                                6080
                            </td>
                            <td>
                                La maison d&#39;Asie
                            </td>
                            <td>
                                02/01/2011
                            </td>
                            <td>
                                &#163;311.98
                            </td>
                            <td>
                                &#163;62.40
                            </td>
                        </tr>
                        <tr>
                            <td>
                                7687
                            </td>
                            <td>
                                La maison d&#39;Asie
                            </td>
                            <td>
                                02/01/2011
                            </td>
                            <td>
                                &#163;424.77
                            </td>
                            <td>
                                &#163;84.95
                            </td>
                        </tr>
                </asp:Panel>
            </div>
            <div class="Footer">
            </div>
        </div>
    </form>
</body>
</html>
