<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidateForm.aspx.cs" Inherits="validationform.ValidateForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
            border: 5px solid #000000;
            background-color: #C0C0C0;
        }
        .auto-style3 {
            width: 382px;
        }
        .auto-style4 {
            width: 360px;
        }
        .auto-style5 {
            background-color: #C0C0C0;
        }
        .auto-style6 {
            width: 360px;
            background-color: #C0C0C0;
        }
        .auto-style7 {
            width: 382px;
            background-color: #C0C0C0;
        }
        .auto-style8 {
            width: 382px;
            height: 33px;
            background-color: #CCCCCC;
        }
        .auto-style9 {
            width: 360px;
            height: 33px;
            background-color: #CCCCCC;
        }
        .auto-style10 {
            height: 33px;
            background-color: #FF6699;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong><em><span class="auto-style5">Validate Control </span></em></strong>
        </div>
        <table cellpadding="4" cellspacing="3" class="auto-style2">
            <tr>
                <td class="auto-style7">First Name</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style5"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" CssClass="auto-style5" ErrorMessage="RequiredFieldValidator">Enter First Name</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Password</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style5" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" CssClass="auto-style5" ErrorMessage="Password does not match">Enter correct password </asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Re-Enter Password</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style5" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style5" Height="48px" Text="Submit" Width="136px" />
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" CssClass="auto-style5" Text="Label"></asp:Label>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8"></td>
                <td class="auto-style9"></td>
                <td class="auto-style10"></td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
        </table>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
