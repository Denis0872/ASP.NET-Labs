<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Start.aspx.cs" Inherits="RSVP2.Start" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Styles.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="rek"> <h1>Приглашение на семинар</h1>
                <p>Вы приглашены на наш семинар</p> 
                <p>Подтвердите свое согласие, пройдя регистрацию</p> 

            </div> 
            <div class="info"> Семинар состоится 1 января 2021 года в 7.30 </div>

        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Width="222px" Font-Size="Medium" BackColor="#FFCC00" BorderColor="Black" BorderStyle="Solid" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" Width="285px" />
        </p>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Brawlstars" Width="293px" />
    </form>
</body>
</html>
