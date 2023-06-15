<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="trust_us.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style16 {
            width: 100%;
            border-style: solid;
            border-width: 5px;
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
        .auto-style32 {
            width: 218px;
            height: 22px;
            font-size: x-large;
        }
        .auto-style34 {
            font-size: large;
        }
        .auto-style35 {
            width: 218px;
            height: 22px;
            font-size: large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style34">Transaction Page</span></strong></p>
    <p>
        <table __designer:mapid="3b" class="auto-style16">
            <tr __designer:mapid="3c">
                <td __designer:mapid="3d" class="auto-style32">
                    <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" GroupName="mode" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Issue" />
                </td>
                <td __designer:mapid="3e" class="auto-style26">
                    <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" CssClass="auto-style34" GroupName="mode" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Purchase" />
                </td>
            </tr>
            <tr __designer:mapid="3c">
                <td __designer:mapid="3d" class="auto-style32">Item Name :</td>
                <td __designer:mapid="3e" class="auto-style26">
                    <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr __designer:mapid="3c">
                <td __designer:mapid="3d" class="auto-style35">Transaction Date:-</td>
                <td __designer:mapid="3e" class="auto-style26">
                    <asp:TextBox ID="TextBox10" runat="server" TextMode="DateTime"></asp:TextBox>
                </td>
            </tr>
            <tr __designer:mapid="3c">
                <td __designer:mapid="3d" class="auto-style35">
                    <asp:Label ID="Label2" runat="server" Text="Department_Name:"></asp:Label>
                </td>
                <td __designer:mapid="3e" class="auto-style26">
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Department_name" DataValueField="Department_id">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:trust_meConnectionString %>" ProviderName="<%$ ConnectionStrings:trust_meConnectionString.ProviderName %>" SelectCommand="SELECT [Department_id], [Department_name] FROM [Department_mast]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr __designer:mapid="3c">
                <td __designer:mapid="3d" class="auto-style35">
                    <asp:Label ID="Label3" runat="server" Text="Vendor_Name:"></asp:Label>
                </td>
                <td __designer:mapid="3e" class="auto-style26">
                    <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="Vendor_Name" DataValueField="Vendor_id">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:trust_meConnectionString %>" SelectCommand="SELECT [Vendor_Name], [Vendor_id] FROM [Vendor_mast]"></asp:SqlDataSource>
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
                <td __designer:mapid="46" class="auto-style28">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                    &nbsp;</td>
            </tr>
            <tr __designer:mapid="44">
                <td __designer:mapid="45" class="auto-style27">Result: </td>
                <td __designer:mapid="46" class="auto-style28">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            </table>
    </p>
</asp:Content>
