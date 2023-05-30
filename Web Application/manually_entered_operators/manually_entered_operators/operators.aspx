<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="operators.aspx.cs" Inherits="manually_entered_operators.operators" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-weight: 700;
            font-style: italic;
            background-color: #CCFFFF;
        }
        .auto-style2 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            HCL TECHNOLOGIES LTD NAGPUR<br />
            <br />
            Manually entered operator and perform the calculation<br />
            <br />
        </div>
        <p>
            Number 1 :-&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            Number 2 :-&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            Operator :-&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p style="text-align: center">
            <asp:Button ID="Button1" runat="server" BackColor="#CCFFCC" Height="41px" OnClick="Button1_Click" Text="Button" Width="130px" />
        </p>
        <p class="auto-style2">
            Result :-&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
    <p class="auto-style2" style="margin-left: 480px">
        &nbsp;</p>
</body>
</html>
