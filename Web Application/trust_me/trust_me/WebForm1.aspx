<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="trust_me.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            margin-left: 65px;
        }
        .auto-style3 {
            width: 100%;
            height: 512px;
        }
        .auto-style7 {
            width: 525px;
        }
        .auto-style8 {
            width: 525px;
            height: 258px;
        }
        .auto-style9 {
            height: 258px;
        }
        .auto-style10 {
            width: 100%;
            border-style: solid;
            border-width: 4px;
        }
        .auto-style13 {
            width: 203px;
            height: 33px;
        }
        .auto-style14 {
            height: 33px;
        }
        .auto-style16 {
            width: 100%;
            border-style: solid;
            border-width: 5px;
        }
        .auto-style17 {
            width: 244px;
        }
        .auto-style18 {
            width: 248px;
        }
        .auto-style19 {
            width: 248px;
            height: 26px;
        }
        .auto-style20 {
            height: 26px;
        }
        .auto-style21 {
            width: 244px;
            height: 33px;
        }
        .auto-style22 {
            width: 203px;
        }
        .auto-style25 {
            width: 218px;
            height: 22px;
        }
        .auto-style26 {
            height: 22px;
        }
        .auto-style27 {
            width: 218px;
            height: 43px;
        }
        .auto-style28 {
            height: 43px;
        }
        .auto-style30 {
            width: 218px;
            height: 62px;
        }
        .auto-style31 {
            height: 62px;
        }
        .auto-style32 {
            width: 100%;
            border-style: solid;
            border-width: 10px;
        }
        .auto-style33 {
            width: 259px;
        }
        .auto-style34 {
            width: 315px;
        }
        .auto-style35 {
            width: 304px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Store Management Systemmm</strong></div>
        <asp:Panel ID="Panel1" runat="server" CssClass="auto-style2" Height="510px" Width="1033px">
            &nbsp;
            <table class="auto-style3">
                <tr>
                    <td class="auto-style8">Item Entry
                        <br />
                        <table class="auto-style16">
                            <tr>
                                <td class="auto-style18">Item Entry :-</td>
                                <td>
                                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style18">Category:- </td>
                                <td>
                                    <asp:DropDownList ID="DropDownList1" runat="server">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style18">Rate:- </td>
                                <td>
                                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style19">Balance Quantity:-</td>
                                <td class="auto-style20">
                                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td class="auto-style9">Vendor Master TB<br />
                        <table class="auto-style16">
                            <tr>
                                <td class="auto-style17">Vendor Name :- </td>
                                <td>
                                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style17">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style17">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style21"></td>
                                <td class="auto-style14"></td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Departemnt TB<br />
                        <table class="auto-style10">
                            <tr>
                                <td class="auto-style13">Department Name:- </td>
                                <td class="auto-style14">
                                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style22">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style22">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style22">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style22">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                    <td>Transaction Detail TB<br />
                        <table class="auto-style16">
                            <tr>
                                <td class="auto-style25">Transaction Date:-</td>
                                <td class="auto-style26">
                                    <asp:TextBox ID="TextBox10" runat="server" TextMode="DateTime"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style30">Quantity :-</td>
                                <td class="auto-style31">
                                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style27"></td>
                                <td class="auto-style28"></td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <table class="auto-style32">
                <tr>
                    <td class="auto-style33">&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" Text="ADD" />
                    </td>
                    <td class="auto-style34">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button2" runat="server" Text="MODIFY" />
                    </td>
                    <td class="auto-style35">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button3" runat="server" Text="DELETE" />
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button4" runat="server" Text="SEARCH" />
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style33">&nbsp;</td>
                    <td class="auto-style34">&nbsp;</td>
                    <td class="auto-style35">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </p>
    </form>
</body>
</html>
