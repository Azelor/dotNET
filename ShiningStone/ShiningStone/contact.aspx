<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="ShiningStone.contact" %>

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
                    Contact Us
                </h2>
                <p>
                    Please fill in the box below with any questions or comments and click "Send Message".</p>
                &nbsp;<asp:TextBox ID="TextBoxContactMessage" runat="server" Height="200px" TextMode="MultiLine"
                    Width="480px"></asp:TextBox>
                <br />
                <asp:Button ID="ButtonSend" runat="server" Text="Send Message" />
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
