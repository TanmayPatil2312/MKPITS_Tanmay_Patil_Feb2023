<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="cart.aspx.cs" Inherits="website.cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p class="text-center">
        SIGN UP TO SAVE YOUR ORDER</p>
    <p class="text-center">
        Enter Mobile No.&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p class="text-center">
        <asp:Button ID="Button1" runat="server" BorderStyle="Ridge" OnClick="Button1_Click" Text="Submit" />
    </p>
</asp:Content>
