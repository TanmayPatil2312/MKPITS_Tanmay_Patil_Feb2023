<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="trust_proj_with_class_lib.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p class="text-center">
        <strong>Transaction Details</strong></p>
    <p class="text-start" style="margin-left: 80px">
        <asp:RadioButton ID="RadioButton1" runat="server" Text="Issues" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="RadioButton2" runat="server" Text="Purchase" />
    </p>
    <p class="text-start" style="margin-left: 80px">
        Item Name :&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
    </p>
    <p class="text-start" style="margin-left: 80px">
        Transaction Date :&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" TextMode="Date"></asp:TextBox>
    </p>
    <p class="text-start" style="margin-left: 80px">
        Department Name :&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server">
        </asp:DropDownList>
    </p>
    <p class="text-start" style="margin-left: 80px">
        Vendor Name :&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList3" runat="server">
        </asp:DropDownList>
    </p>
    <p class="text-start" style="margin-left: 80px">
        Quantity :&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p class="text-start" style="margin-left: 200px">
        <asp:Button ID="Button1" runat="server" Text="SUBMIT" />
    </p>
    <p class="text-start" style="margin-left: 200px">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;:
    </p>
</asp:Content>
