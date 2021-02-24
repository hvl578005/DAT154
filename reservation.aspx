<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reservation.aspx.cs" Inherits="HotelProsj4.reservation" %>

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">

    <head runat="server">
        <title>STARLIGHT HOTEL</title>
        <link rel="stylesheet" type="text/css" href="stylesheet.css">
    </head>

    <body>
        <h1>Book your dream room now!</h1>
        <div class="main">
            <form id="form1" runat="server">
                <asp:Label ID="welcomegirl" runat="server"></asp:Label><br><br>

                <p>See your bookings <a href="checkbooking.aspx">here</a></p><br />


                <asp:Label ID="Check_in" runat="server" Text="Check in"></asp:Label><br>
                <asp:TextBox ID="TextBox1" runat="server" ReadOnly="False" TextMode ="Date"></asp:TextBox>
                <br><br>
                <asp:Label ID="Check_out" runat="server" Text="Check out "></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" ReadOnly="False" TextMode ="Date"></asp:TextBox>
                <br><br>

                <asp:Label ID="Quality" runat="server" Text="Quality of room"></asp:Label>
                <asp:DropDownList id="DropDownList1" AutoPostBack="True" OnSelectedIndexChanged="Selection_Change" runat="server">
                <asp:ListItem Selected="True" Value="Standard">Standard</asp:ListItem>
                <asp:ListItem Value="Double">Double</asp:ListItem>
                <asp:ListItem Value="Deluxe">Deluxe</asp:ListItem>
                </asp:DropDownList>  
                <br><br>

                
                <asp:Label ID="NumOfBeds" runat="server" Text="Number of beds: "></asp:Label>
                <asp:Label ID="Beds" runat="server"></asp:Label>
                <br><br>

                <asp:Label ID="Pric" runat="server" Text="Price per night: "></asp:Label>
                <asp:Label ID="Price" runat="server"></asp:Label>
                <br><br>

                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Save" />
                <br>
                <!--onclick="btnSave_Click"-->

            </form>
        </div>

    </body>

    </html>