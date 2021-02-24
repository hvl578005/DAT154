<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="roomreservation.aspx.cs"
    Inherits="HotelProsj4.roomreservation" %>

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">

    <head runat="server">
        <title>STARLIGHT HOTEL</title>
        <link rel="stylesheet" type="text/css" href="stylesheet.css" />
    </head>

    <body>
        <h1>Book your dream room now!</h1>
        <div class="main"></div>
        <form id="form1" runat="server">
            <asp:Label ID="Quality" runat="server" Text="Quality of room"></asp:Label>
            <asp:DropDownList id="DropDownList1" AutoPostBack="True" OnSelectedIndexChanged="Selection_Change" runat="server">
                <asp:ListItem Selected="True" Value="Standard">Standard</asp:ListItem>
                <asp:ListItem Value="Double">Double</asp:ListItem>
                <asp:ListItem Value="Deluxe">Deluxe</asp:ListItem>

                <asp:Label ID="NumOfBeds" runat="server" Text="Number of beds"></asp:Label>
               <!-- <asp:Label ID="Beds" runat="server" Text="1 orr 2 or 3"></asp:Label> -->

                <asp:Label ID="Price" runat="server" Text="Price per night"></asp:Label>
                <!-- <asp:Label ID="Price" runat="server" Text="500"></asp:Label>-->
        </form>
        </div>
    </body>
    </html>



<!-- INSERT INTO Room(Room_id, Beds, Price, Quality)
VALUES (1, 1, 500, 'Standard')

INSERT INTO Room(Room_id, Beds, Price, Quality)
VALUES (2, 2, 800, 'Double')

INSERT INTO Room(Room_id, Beds, Price, Quality)
VALUES (3, 2, 1000, 'Deluxe') -->