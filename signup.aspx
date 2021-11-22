<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="SignIn2.signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>הרשמה לאתר</title>
    <link href="SignUp.css" rel="stylesheet" />
</head>
<body>
    <div id="container">
    <form id="signup" method="post" name="signup" runat="server">    
            <h1>create an account</h1>
        <br />
            first name <input type="text" id="fName" name="fName" /> <br /> <br />
            last name <input type="text" id="lName" name="lName" /> <br /> <br />
            username <input type="text" id="userName" name="userName" /> <br /> <br />
            email <input type="email" id="email" name="email" /> <br /> <br />
            password <input type="password" id="password" name="password" /> <br /> <br />
            phone <input type="tel" id="phone" name="phone" /> <br /> <br />


            <asp:radiobuttonlist id="kita1" runat="server">
        <asp:listitem id="option1" runat="server" value="י1" />
        <asp:listitem id="option2" runat="server" value="י2" />
        <asp:listitem id="Listitem1" runat="server" value="י3" />
        <asp:listitem id="Listitem2" runat="server" value="י4" />
</asp:radiobuttonlist>


            <div><asp:Label ID="message" runat="server" Text="" ></asp:Label></div>
            <input type="submit" id="submit" name="submit" value="create" />
        <br />
        <br />
        <label>already have an account ? <a href="SignIn.aspx">click here</a></label>
        
    </form>
        </div>
</body>
</html>
