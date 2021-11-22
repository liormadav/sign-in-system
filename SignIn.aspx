﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="WebApplication2.SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign In</title>
    <link href="login.css" rel="stylesheet" />
</head>
<body>

    <form id="form1" runat="server" method ="Post">
        <div id="sign in">
            <div>
                <%--<input type="text" placeholder="first name" id="fNameBox" name="fName" />
                <br />
                <br />
                <input type="text" placeholder="last name" id="lNameBox" name="lName" />
                <br />
                <br />--%>

                <input type="text" placeholder="enter username" id="userName" name="userName" />
                <br />
                <br />

                <input type="password" placeholder="enter password" id="passwordBox" name="password" />
                <br />
                <br />

                <div><asp:Label ID="message" runat="server" Text="" ></asp:Label></div>
                <input type="submit" name="Submit" value="signIn" />
                <br />
                <br />
                to create an account click <a href="signup.aspx">here</a>
                
                
            </div>
        </div>
    </form>
</body>
</html>
