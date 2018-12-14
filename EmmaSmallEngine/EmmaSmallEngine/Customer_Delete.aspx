<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer_Delete.aspx.cs" Inherits="EmmaSmallEngine.Customer_Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Emma's Small Engine - Delete Customer</title>
    <link rel="stylesheet" href="~/css/styles.css" />
</head>
<body class="Font">
    <form id="login" runat="server">
        <div>
            <asp:Image class="Banner" ID="LoginBanner" runat="server" ImageUrl="~/img/logo.png" />
        </div>
        <br />
        <div align="center">
            <h1>Delete Customer:</h1>
            <asp:Label ID="Label1" runat="server" Text="First Name:"></asp:Label>&nbsp<asp:Label ID="lblFirst" runat="server"></asp:Label><br />
            <asp:Label ID="Label2" runat="server" Text="Last Name:"></asp:Label>&nbsp<asp:Label ID="lblLast" runat="server"></asp:Label><br />
            <asp:Label ID="Label3" runat="server" Text="Phone #:"></asp:Label>&nbsp<asp:Label ID="lblPhone" runat="server"></asp:Label><br />
            <asp:Label ID="Label4" runat="server" Text="Address:"></asp:Label>&nbsp<asp:Label ID="lblAddress" runat="server"></asp:Label><br />
            <asp:Label ID="Label5" runat="server" Text="City:"></asp:Label>&nbsp<asp:Label ID="lblCity" runat="server"></asp:Label><br />
            <asp:Label ID="Label6" runat="server" Text="Postal Code"></asp:Label>&nbsp<asp:Label ID="lblPostal" runat="server"></asp:Label><br />
            <asp:Label ID="Label7" runat="server" Text="Email Address"></asp:Label>&nbsp<asp:Label ID="lblEmail" runat="server"></asp:Label><br />
            <asp:Button runat="server" ID="btnDelete" type="Submit" Text="Delete" OnClick="btnDelete_Click" />
        </div>
    </form>
</body>
</html>
