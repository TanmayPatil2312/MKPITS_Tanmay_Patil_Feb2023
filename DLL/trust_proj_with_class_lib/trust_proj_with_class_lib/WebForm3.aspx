<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="trust_proj_with_class_lib.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p class="text-center">
        <strong>Vendor Details </strong>
    </p>
    <p class="text-start">
        Vendor ID :
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p class="text-start">
        Vendor Name :
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p class="text-start" style="margin-left: 40px">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ADD" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="UPDATE" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="DELETE" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="SEARCH" />
    </p>
    <p class="text-start" style="margin-left: 40px">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;:
    </p>
</asp:Content>
