<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="website._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Messho</h1>
            <p class="lead">Lowest Prices
Best Quality Shopping</p>
           
        </section>

        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <h2 id="gettingStartedTitle">Free Delivery</h2>
                <p>
Register as a Meesho Supplier
                </p>
                <p>
                    <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948"></a>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="librariesTitle">
                <h2 id="librariesTitle"></h2>
                <p>
                     <img src="image1.jpg" style="width:350;height:250";>
                </p>
                <p>
                    <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949"></a>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="hostingTitle">
                <h2 id="hostingTitle">&nbsp;</h2>
                <p>
               
                </p>
                <p>
                    <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950"></a>
                </p>
            </section>
       <hr />
<div class="row">
<h1 align=center>------------------ Top Categories to choose from ---------------</h1>
    </div>
     <hr>
    <div>
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" RepeatDirection="Horizontal" Width="100%" OnSelectedIndexChanged="DataList1_SelectedIndexChanged">
            <ItemTemplate>
    <table cellpadding="2" cellspacing="0" border="1" style="width: 300px; height: 100px;
        border: dashed 2px #04AFEF; background-color: #FFFFFF">
    <tr>
    <td align="center">
<a href='<%# Eval("ProductId","productdetails.aspx?ProductId={0}") %>'>
    <asp:Image ID="Image1" ImageUrl='<%# Bind("ImageName", "~/images/{0}") %>' runat="server"

        Height="100"
    
        Width="100" />
    </a>

    </td>
    </tr>

<tr>
<td align="center">
<span > <%# Eval("ProductName") %></span><br />
<span > <%# Eval("ProductDesc") %></span><br />
<span >Rs. <%# Eval("ProductPrice") %> onwards</span><br />

</td>
</tr>
</table>
</ItemTemplate>
        </asp:DataList>
    


        </div>
    </main>

    </div>
</asp:Content>
