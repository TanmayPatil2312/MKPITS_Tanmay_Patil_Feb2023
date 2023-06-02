<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ad_rotator.aspx.cs" Inherits="AD_rotator.ad_rotator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/XMLFile1.xml" Height="300px" Width="400px" />
        </div>
    </form>
</body>
</html>
