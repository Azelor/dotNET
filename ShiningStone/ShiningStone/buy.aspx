<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="buy.aspx.cs" Inherits="ShiningStone.buy" %>

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
                <asp:Panel ID="PanelOrder" runat="server">
                    <h4>
                        You are buying:
                        <asp:Label ID="LabelProductName" runat="server"></asp:Label>
                    </h4>
                    <p>
                        Please fill in the form below with your address details and phone number.
                        <br />
                        A sales representative will contact you to arrange payment.
                    </p>
                    <table>
                        <tr>
                            <td>
                                Address 1
                            </td>
                            <td>
                                <asp:TextBox ID="TextBoxAddress1" runat="server" BackColor="#FFCCCC" Columns="50" MaxLength="50"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorAddress1" runat="server" ControlToValidate="TextBoxAddress1" ErrorMessage="Address 1 Required">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Address 2
                            </td>
                            <td>
                                <asp:TextBox ID="TextBoxAddress2" runat="server" BackColor="#FFCCCC" Columns="50" MaxLength="50"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorAddress2" runat="server" ControlToValidate="TextBoxAddress2" ErrorMessage="Address 2 Required">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Address 3
                            </td>
                            <td>
                                <asp:TextBox ID="TextBoxAddress3" runat="server" Columns="50" MaxLength="50"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Address 4
                            </td>
                            <td>
                                <asp:TextBox ID="TextBoxAddress4" runat="server" Columns="50" MaxLength="50"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Country
                            </td>
                            <td>
                                <asp:DropDownList ID="DropDownListCountry" runat="server" DataSourceID="LinqDataSourceCountry"
                                    DataTextField="CountryName" DataValueField="CountryID">
                                </asp:DropDownList>
                                <asp:LinqDataSource ID="LinqDataSourceCountry" runat="server" ContextTypeName="ShiningStone.ShiningStoneDataContext"
                                    EntityTypeName="" OrderBy="CountryName" TableName="Countries">
                                </asp:LinqDataSource>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Post Code
                            </td>
                            <td>
                                <asp:TextBox ID="TextBoxPostCode" runat="server" BackColor="#FFCCCC"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorPostCode" runat="server" ControlToValidate="TextBoxPostCode" ErrorMessage="Post Code Required">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Phone Number
                            </td>
                            <td>
                                <asp:TextBox ID="TextBoxPhoneNumber" runat="server" BackColor="#FFCCCC"></asp:TextBox>
                                <asp:RangeValidator ID="RangeValidatorPhoneNumber" runat="server" ControlToValidate="TextBoxPhoneNumber" ErrorMessage="Invalid Phone Number" MaximumValue="999999" MinimumValue="0" Type="Integer">*</asp:RangeValidator>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:CheckBox ID="CheckBoxAcceptTerms" runat="server" Text="I accept the terms and conditions" />
                            </td>
                        </tr>
                    </table>
                    <asp:Button ID="ButtonSubmitOrder" runat="server" Text="Submit Order" 
                        OnClick="ButtonSubmitOrder_Click" Font-Bold="True" />
                    <asp:ValidationSummary ID="ValidationSummaryBuy" runat="server" />
                </asp:Panel>
                <asp:Panel ID="PanelOrderComplete" runat="server" Visible="false">
                    <h4>
                        Thank you for your order
                    </h4>
                    <p>
                        Your order has been received. A sales representative will be in touch shortly.
                    </p>
                </asp:Panel>
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
