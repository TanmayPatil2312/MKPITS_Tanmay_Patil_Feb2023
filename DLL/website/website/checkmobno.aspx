<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="checkmobno.aspx.cs" Inherits="website.checkmobno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p class="text-center">
        Check Mobile No. With OTP</p>
    <p class="text-center">
        Enter OTP:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p class="text-center">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
    </p>
    <p class="text-center">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;: -
    </p>
</asp:Content>
