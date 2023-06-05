<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="usermanagement.aspx.cs" Inherits="userManagement.usermanagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    
    <script type="text/javascript" language="javascript">
        function alert_meth()
        {
            alert("Client Side MessageBox");
        }

        function confirm_meth()
        {
            if (confirm("Do you want to continue ! Click 'Yes' ") == true) {
                document.writeln("<b> you had click on 'Yes' Button</b>");
            }
            else
            {
                document.writeln("<b> you had click on 'NO' Button </b>");
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button OnClientClick="alert_meth()" ID="Button1" runat="server" Text="Button" />
            <br />
            <br />
            <br />
            <asp:Button OnClientClick="confirm_meth()" ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
