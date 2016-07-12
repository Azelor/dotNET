<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="namingtest.aspx.cs" Inherits="My_Project.namingtest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="LabelDay" runat="server" Text="Label"></asp:Label>
    
    </div>
        <asp:Button ID="ButtonMonday" runat="server" OnClick="ButtonMonday_Click" Text="Monday" />
        <asp:Button ID="ButtonTuesday" runat="server" Text="Tuesday" />
        <asp:Button ID="ButtonWednesday" runat="server" Text="Wednesday" />
    </form>
</body>
</html>
