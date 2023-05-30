<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webapp1.aspx.cs" Inherits="WebApp_Project_1.webapp1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
        <div>
            <strong><em>RAJA BHAU SOFTWARE </em></strong></div>
    <hr />
        <p style="text-align: left">
            Enter First Number :-&nbsp;&nbsp; <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p style="text-align: left; height: 38px">
            Enter Second Number :-
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p style="text-align: left">
            <asp:Button ID="Button1" runat="server" Height="37px" OnClick="Button1_Click" Text="ADDITION" Width="134px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Height="37px" OnClick="Button2_Click" Text="Substraction" Width="143px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Height="32px" OnClick="Button3_Click" Text="MULTIPLICATION" Width="207px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" Height="34px" OnClick="Button4_Click" Text="DIVISION" Width="118px" />
        </p>
        <p style="text-align: left">
            Result :-&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
    <p style="text-align: left">
        &nbsp;</p>
</body>
</html>
