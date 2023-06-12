<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="asp_cash__emi.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            margin-left: 80px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Cash and EMI Grid View</strong></div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
&nbsp;&nbsp;&nbsp;
        <div class="auto-style2">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="GridViewLoad" />
            <br />
        </div>
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Show EMI" />
        <p>
            Total Amount :-
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            Amount Paid : - <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <asp:RadioButton ID="RadioButton1" runat="server" Text="CASH" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="RadioButton2" runat="server" Text="EMI" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
