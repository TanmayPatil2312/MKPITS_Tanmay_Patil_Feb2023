<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registerform.aspx.cs" Inherits="RegistrationForm.registerform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            background-color: #FFFFCC;
        }
        .auto-style3 {
            width: 100%;
            border: 3px solid #00FF00;
            background-color: #FFFF00;
        }
        .auto-style4 {
            text-align: center;
            width: 574px;
        }
        .auto-style6 {
            width: 574px;
            height: 83px;
            text-align: center;
        }
        .auto-style7 {
            height: 83px;
        }
        .auto-style8 {
            width: 574px;
            height: 211px;
            text-align: center;
        }
        .auto-style9 {
            height: 211px;
        }
        .auto-style10 {
            text-align: center;
            margin-left: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong><em><span class="auto-style2">Registration Form </span></em></strong>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <table cellspacing="1" class="auto-style3">
            <tr>
                <td class="auto-style4">Name</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Password</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Address</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Mobile No.</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBox4" runat="server" MaxLength="10" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Date of Birth</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBox5" runat="server" TextMode="Date"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Gender</td>
                <td class="auto-style10">
                    <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RadioButton ID="RadioButton3" runat="server" Text="Other" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Hobbies</td>
                <td class="auto-style1">
                    <asp:CheckBox ID="CheckedBox1" runat="server" Text="Music" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox2" runat="server" Text="Running" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">City</td>
                <td class="auto-style1">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Pune</asp:ListItem>
                        <asp:ListItem>Mumbai</asp:ListItem>
                        <asp:ListItem>Delhi</asp:ListItem>
                        <asp:ListItem>Hyderabad</asp:ListItem>
                        <asp:ListItem>Bengaluru</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Button ID="Button1" runat="server" Height="44px" OnClick="Button1_Click" Text="Save" Width="103px" />
                </td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td id="Label1" class="auto-style8">
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style9"></td>
            </tr>
        </table>
    </form>
</body>
</html>
