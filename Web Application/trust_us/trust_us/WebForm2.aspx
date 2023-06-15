<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="trust_us.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style16 {
            width: 100%;
            border-style: solid;
            border-width: 5px;
        }
        .auto-style19 {
            width: 248px;
            height: 26px;
            font-size: x-large;
        }
        .auto-style20 {
            height: 26px;
            width: 784px;
        }
        .auto-style21 {
            width: 784px;
        }
        .auto-style22 {
            width: 248px;
            height: 78px;
        }
        .auto-style23 {
            height: 78px;
            width: 784px;
        }
        .auto-style24 {
            width: 248px;
            height: 69px;
        }
        .auto-style25 {
            height: 69px;
            width: 784px;
        }
        .auto-style26 {
            width: 248px;
            height: 80px;
        }
        .auto-style27 {
            height: 80px;
            width: 784px;
        }
        .auto-style28 {
            width: 248px;
            height: 75px;
        }
        .auto-style29 {
            height: 75px;
            width: 784px;
        }
        .auto-style30 {
            width: 248px;
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Item Entry Page
    <br />
    </strong>
    <table __designer:mapid="4" class="auto-style16">
        <tr __designer:mapid="5">
            <td __designer:mapid="6" class="auto-style30">Item Entry :-</td>
            <td __designer:mapid="7" class="auto-style21">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr __designer:mapid="9">
            <td __designer:mapid="a" class="auto-style30">Category:- </td>
            <td __designer:mapid="b" class="auto-style21">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Electronic </asp:ListItem>
                    <asp:ListItem>Consumable</asp:ListItem>
                    <asp:ListItem>Furniture</asp:ListItem>
                    <asp:ListItem>Stationary</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr __designer:mapid="d">
            <td __designer:mapid="e" class="auto-style30">Rate:- </td>
            <td __designer:mapid="f" class="auto-style21">
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr __designer:mapid="11">
            <td __designer:mapid="12" class="auto-style19">Balance Quantity:-</td>
            <td __designer:mapid="13" class="auto-style20">
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr __designer:mapid="11">
            <td __designer:mapid="12" class="auto-style19">Item ID:-</td>
            <td __designer:mapid="13" class="auto-style20">
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr __designer:mapid="11">
            <td __designer:mapid="12" class="auto-style22">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ADD" />
            </td>
            <td __designer:mapid="13" class="auto-style23"></td>
        </tr>
        <tr __designer:mapid="11">
            <td __designer:mapid="12" class="auto-style24">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="UPDATE" />
                &nbsp;</td>
            <td __designer:mapid="13" class="auto-style25"></td>
        </tr>
        <tr __designer:mapid="11">
            <td __designer:mapid="12" class="auto-style26">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="DELETE" />
                &nbsp;</td>
            <td __designer:mapid="13" class="auto-style27"></td>
        </tr>
        <tr __designer:mapid="11">
            <td __designer:mapid="12" class="auto-style28">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;
                <asp:Button ID="Button4" runat="server" Text="SEARCH" OnClick="Button4_Click" />
                &nbsp;&nbsp;</td>
            <td __designer:mapid="13" class="auto-style29">&nbsp; Grid view Below
                <br />
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
                <br />
                <br />
                <br />
                <asp:Panel ID="Panel1" runat="server">
                    <asp:Label ID="Label1" runat="server" Text="Show Result"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Show Grid View " />
                </asp:Panel>
            </td>
        </tr>
        <tr __designer:mapid="11">
            <td __designer:mapid="12" class="auto-style28">&nbsp;</td>
            <td __designer:mapid="13" class="auto-style29">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
