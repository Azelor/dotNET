<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StableBase._Default" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to StableBase!
    </h2>
    <div>
    <h3>News</h3>
    <asp:Label ID="LabelNews" runat="server"></asp:Label>
    <div id="NewsDiv">
    </div>
    </div>
</asp:Content>
