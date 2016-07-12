<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calculator.aspx.cs" Inherits="My_Project.calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBoxFirstNumber" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBoxSecondNumber" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonCalculate" runat="server" OnClick="ButtonCalculate_Click" Text="Calculate" />
    
        <asp:Button ID="ButtonCalculate2" runat="server" OnClick="ButtonCalculate2_Click" Text="Button" />
    
    </div>
        <asp:Label ID="LabelResult" runat="server"></asp:Label>
    </form>
</body>
</html>
