<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="trust_us.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style16 {
            width: 100%;
            border-style: solid;
            border-width: 5px;
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
            width: 330px;
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Vendor Master Page</strong></p>
    <p>
        <table __designer:mapid="17" class="auto-style16">
            <tr __designer:mapid="18">
                <td __designer:mapid="19" class="auto-style30">Vendor Name :- </td>
                <td __designer:mapid="1a">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr __designer:mapid="1c">
                <td __designer:mapid="1d" class="auto-style30">Vendor ID :-</td>
                <td __designer:mapid="1e">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td __designer:mapid="12" class="auto-style22">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Text="ADD" OnClick="Button1_Click" />
                </td>
                <td __designer:mapid="13" class="auto-style23"></td>
            </tr>
            <tr>
                <td __designer:mapid="12" class="auto-style24">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;<asp:Button ID="Button2" runat="server" Text="MODIFY" OnClick="Button2_Click" />
                    &nbsp;</td>
                <td __designer:mapid="13" class="auto-style25"></td>
            </tr>
            <tr>
                <td __designer:mapid="12" class="auto-style26">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" Text="DELETE" OnClick="Button3_Click" />
                    &nbsp;</td>
                <td __designer:mapid="13" class="auto-style27"></td>
            </tr>
            <tr>
                <td __designer:mapid="12" class="auto-style28">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;
                    <asp:Button ID="Button4" runat="server" Text="SEARCH" OnClick="Button4_Click" />
                    &nbsp;&nbsp;</td>
                <td __designer:mapid="13" class="auto-style29"></td>
            </tr>
            <tr>
                <td __designer:mapid="12" class="auto-style28">Grid View This Side --&gt;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Show Grid View " />
                </td>
                <td __designer:mapid="13" class="auto-style29">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                    &nbsp;</td>
            </tr>
            <tr>
                <td __designer:mapid="12" class="auto-style28">Result --------&gt;</td>
                <td __designer:mapid="13" class="auto-style29">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
&nbsp;</p>
</asp:Content>
