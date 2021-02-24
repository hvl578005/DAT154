<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="HotelProsj4.register" %>

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">

    <head runat="server">
        <title>STARLIGHT HOTEL</title>
        <link rel="stylesheet" type="text/css" href="stylesheet.css">
    </head>


    <body>
        <h1>Welcome to Starlight Hotel!</h1>
        <div class="main">
            <p>Register as a new user</p>
            <form id="form2" runat="server">
                <asp:Label ID="Phone_nr" runat="server" Text="Phone number "></asp:Label>
                <asp:TextBox ID="box1" runat="server"></asp:TextBox><br>
                <asp:Label ID="FirstName" runat="server" Text="First name "></asp:Label>
                <asp:TextBox ID="box2" runat="server"></asp:TextBox><br>
                <asp:Label ID="LastName" runat="server" Text="Last name "></asp:Label>
                <asp:TextBox ID="box3" runat="server"></asp:TextBox><br>
                <asp:Label ID="Password" runat="server" Text="Password "></asp:Label>
                <asp:TextBox ID="box4" runat="server" TextMode="Password"></asp:TextBox><br>
                <div class="bcon">
                    <!--<button class="btn">Submit</button>-->
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" />
                    <br>
                </div>
                <p>Already an user? Login <a href="login.aspx">here</a></p>
        </div>
        </form>
    </body>

    </html>
