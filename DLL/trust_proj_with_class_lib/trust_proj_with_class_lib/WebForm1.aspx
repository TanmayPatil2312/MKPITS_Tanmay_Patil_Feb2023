<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="trust_proj_with_class_lib.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p class="text-center">
        <strong>Item Master Details</strong></p>
    <p>
    Item Name :-
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
<p>
    Category :-
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>Electronics</asp:ListItem>
        <asp:ListItem>Consumable</asp:ListItem>
        <asp:ListItem>Furniture</asp:ListItem>
        <asp:ListItem>Stationary</asp:ListItem>
    </asp:DropDownList>
</p>
<p>
    Rate:-
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</p>
<p>
    Balance Quantity :-
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
</p>
<p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="ADD" OnClick="Button1_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="UPDATE" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button3" runat="server" Text="DELETE" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button4" runat="server" Text="SEARCH" />
</p>
<p style="margin-left: 80px">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    : -
</p>
</asp:Content>
