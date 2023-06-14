<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="trust_us.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 40px;
        }
        .auto-style10 {
            width: 100%;
            border-style: solid;
            border-width: 4px;
        }
        .auto-style13 {
            width: 318px;
            height: 33px;
            font-size: x-large;
        }
        .auto-style14 {
            height: 33px;
        }
        .auto-style22 {
            width: 318px;
        }
        .auto-style23 {
            text-align: center;
            margin-left: 40px;
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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style23">
        <strong>Department Master Page</strong></p>
    <p class="auto-style1">
        <table __designer:mapid="28" class="auto-style10">
            <tr __designer:mapid="29">
                <td __designer:mapid="2a" class="auto-style13">Department Name:- </td>
                <td __designer:mapid="2b" class="auto-style14">
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr __designer:mapid="2d">
                <td __designer:mapid="2e" class="auto-style22">&nbsp;</td>
                <td __designer:mapid="2f">&nbsp;</td>
            </tr>
            <tr>
                <td __designer:mapid="12" class="auto-style22">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Text="ADD" />
                </td>
                <td __designer:mapid="13" class="auto-style23"></td>
            </tr>
            <tr>
                <td __designer:mapid="12" class="auto-style24">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;<asp:Button ID="Button2" runat="server" Text="MODIFY" />
                    &nbsp;</td>
                <td __designer:mapid="13" class="auto-style25"></td>
            </tr>
            <tr>
                <td __designer:mapid="12" class="auto-style26">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" Text="DELETE" />
                    &nbsp;</td>
                <td __designer:mapid="13" class="auto-style27"></td>
            </tr>
            <tr>
                <td __designer:mapid="12" class="auto-style28">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;
                    <asp:Button ID="Button4" runat="server" Text="SEARCH" />
                    &nbsp;&nbsp;</td>
                <td __designer:mapid="13" class="auto-style29"></td>
            </tr>
        </table>
&nbsp;</p>
</asp:Content>
