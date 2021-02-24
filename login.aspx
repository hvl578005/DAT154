<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="HotelProsj4.login" %>
<%--  --%>
    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">

    <head runat="server">
        <title>STARLIGHT HOTEL</title>
        <link rel="stylesheet" type="text/css" href="stylesheet.css">
    </head>

    <body>
        <h1>Welcome to Starlight Hotel!</h1>
        <div class="main">
            <p>Login to book a room or to edit your reservation.</p>
            <form id="form1" runat="server">
                <!-- <label>Username</label> -->
                <asp:Label ID="Phone_nr" runat="server" Text="Username "></asp:Label>
                <!-- <input type="text" value="" /> -->
                <asp:TextBox ID="box1" runat="server"></asp:TextBox>
                <br>
                <!-- <label>Password</label>-->
                <!--<input type="password" value="" />-->
                <asp:Label ID="password" runat="server" Text="Password "></asp:Label>
                <asp:TextBox ID="box2" runat="server" TextMode="Password"></asp:TextBox>
            
        <div class="bcon">
            <!--<button class="btn">Submit</button>-->
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Log In" />
            <br>
        </div>
        <p>Not an user? Register <a href="register.aspx">here</a></p>
                <asp:Label ID="Label4" runat="server"></asp:Label>
                </form>
        </div>
    </body>

    </html>