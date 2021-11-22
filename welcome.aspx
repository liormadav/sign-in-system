<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="welcome.aspx.cs" Inherits="SignIn2.welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style.css" rel="stylesheet" />

</head>
<body>
    <div id="navigation">
        <ul>
            <li><a href="#home">Home</a></li>
            <li><a href="#news">about</a></li>
            <li><a href="#contact">Contact</a></li>
            <li style="float: right"><a class="active" href="signout.aspx">sign out</a></li>
        </ul>
    </div>
    <form id="form1" runat="server">
        <div>
            <div class="card">
                <header>
                </header>
                <div class="announcement">
                    <asp:Label CssClass="italic" ID="name" runat="server" Text=""></asp:Label>
                    <h1>congrats</h1>
                    <label class="italic">you logged in successfully</label>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
