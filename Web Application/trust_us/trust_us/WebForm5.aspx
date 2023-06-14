<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="trust_us.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style16 {
            width: 100%;
            border-style: solid;
            border-width: 5px;
        }
        .auto-style25 {
            width: 218px;
            height: 22px;
        }
        .auto-style26 {
            height: 22px;
        }
        .auto-style30 {
            width: 218px;
            height: 62px;
            font-size: x-large;
        }
        .auto-style31 {
            height: 62px;
        }
        .auto-style27 {
            width: 218px;
            height: 43px;
        }
        .auto-style28 {
            height: 43px;
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
        .auto-style29 {
            height: 75px;
            width: 784px;
        }
        .auto-style32 {
            width: 218px;
            height: 22px;
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Transaction Page </strong>
    </p>
    <p>
        <table __designer:mapid="3b" class="auto-style16">
            <tr __designer:mapid="3c">
                <td __designer:mapid="3d" class="auto-style32">Transaction Date:-</td>
                <td __designer:mapid="3e" class="auto-style26">
                    <asp:TextBox ID="TextBox10" runat="server" TextMode="DateTime"></asp:TextBox>
                </td>
            </tr>
            <tr __designer:mapid="40">
                <td __designer:mapid="41" class="auto-style30">Quantity :-</td>
                <td __designer:mapid="42" class="auto-style31">
                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr __designer:mapid="44">
                <td __designer:mapid="45" class="auto-style27"></td>
                <td __designer:mapid="46" class="auto-style28"></td>
            </tr>
            <tr>
                <td __designer:mapid="12" class="auto-style22">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Text="ADD" />
                </td>
            </tr>
            <tr>
                <td __designer:mapid="12" class="auto-style24">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;<asp:Button ID="Button2" runat="server" Text="MODIFY" />
                    &nbsp;</td>
            </tr>
            <tr>
                <td __designer:mapid="12" class="auto-style26">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" Text="DELETE" />
                    &nbsp;</td>
            </tr>
            <tr>
                <td __designer:mapid="12" class="auto-style28">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;
                    <asp:Button ID="Button4" runat="server" Text="SEARCH" />
                    &nbsp;&nbsp;</td>
            </tr>
        </table>
    </p>
</asp:Content>
