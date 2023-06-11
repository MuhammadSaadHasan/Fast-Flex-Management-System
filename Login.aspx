<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>
<html>
  <head>
    <meta charset="UTF-8">
    <title>Login Page</title>
    <style>
      body{
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            font-size: small
        }
        img {
              display: block;
              margin-left: auto;
              margin-right: auto;
        }
        .main{
            height: 300px;
            margin: 1% 1% 1% 35%;
            font-size: large;
            color:#359ada;
        }
        .input-field, .input-field select {
            font-size: large;
            height: 35px;
            width: 50%;
            border: none;
            color:#359ada;
            border-bottom: 1px solid #359ada; 
            border-radius: 10px;
            outline: none;
            background: none; 
            -webkit-appearance: none; 
            -moz-appearance: none; 
            appearance: none; 
        }

        .login{
            padding: 0.5%;
            width: 20%;
            border-radius: 15px;
            color: #359ada;
            border: solid 2px #359ada;
            transition: ease 1s;
            font-size: large;
        }
        .login:hover{
            background-color: #359ada;
            color: white;
            z-index: 100;
        }


    </style>
  </head>
  <body>
 <body>
    <form id="form1" runat="server">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/image/logo.jfif" />
        <div class = "main">
            <asp:Label ID="LabelEmail" runat="server" Text="Username:" />
            <br />
            <asp:TextBox ID="TextBoxUsername" runat="server" CssClass="input-field" TextMode="SingleLine" />
            <br />
            <asp:Label ID="LabelPassword" runat="server" Text="Password:" />
            <br />
            <asp:TextBox ID="TextBoxPassword" runat="server" CssClass="input-field" TextMode="Password" />
            <br />
            <br />
            <asp:Button ID="LoginButton" runat="server" Text="Login" CssClass="login" OnClick="LoginButton_Click" />
            <asp:Label ID="LabelRole" runat="server" Text="Role:" />
            <asp:DropDownList ID="DropDownListRole" runat="server" CssClass="input-field">
                <asp:ListItem Value="Admin">Admin</asp:ListItem>
                <asp:ListItem Value="Teacher">Teacher</asp:ListItem>
                <asp:ListItem Value="Student">Student</asp:ListItem>
            </asp:DropDownList>


            <br />
            <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>

</html>



